using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using ToDoApp.Models;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace ToDoApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<MenuModel> menuModels;
        public string userid;
        public MainViewModel(string Id)
        {
            MenuModels = new ObservableCollection<MenuModel>();

            menuModels.Add(new MenuModel() { IconFont = "\xe635",Name= "MyDay", Title = "My Day", BackColor = "#218868", Display = false });
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Name = "Important", Title = "Important", BackColor = "#EE3B3B"});
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Name = "Planed", Title = "Planned", BackColor = "#218868" });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Name = "AssignToYou", Title = "Assigned to you", BackColor = "#EE3B3B" });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Name = "Task", Title = "Tasks", BackColor = "#218868" });
            MenuModel = MenuModels[0];
            TaskDBEntities _taskDBEntities =new  TaskDBEntities();
            userid = Id;
            //_taskDBEntities.Tasks
            var allMyDay = _taskDBEntities.MyDays.SqlQuery("Select * from dbo.MyDay where UserId=" + Id).ToList();
            foreach (var element in allMyDay)
            {
                TaskInfo x = new TaskInfo();
                //element.TaskText
                x.Content = element.MyDayText;
                x.Id =element.Id;
                menuModels[0].TaskInfos.Add(x);
            }

            var allImportant = _taskDBEntities.Importants.SqlQuery("Select * from dbo.Important where UserId=" + Id).ToList();
            foreach (var element in allImportant)
            {
                TaskInfo x = new TaskInfo();
                x.Id = element.Id;
                x.Content = element.ImportantText;
                menuModels[1].TaskInfos.Add(x);
            }

            var allPlaned = _taskDBEntities.Planeds.SqlQuery("Select * from dbo.Planed where UserId=" + Id).ToList();
            foreach (var element in allPlaned)
            {
                TaskInfo x = new TaskInfo();
                x.Id =element.Id;
                x.Content = element.PlanedText;
                menuModels[2].TaskInfos.Add(x);
            }
            var allAssignToYou = _taskDBEntities.AssignToYous.SqlQuery("Select * from dbo.AssignToYou where UserId=" + Id).ToList();
            foreach (var element in allAssignToYou)
            {
                TaskInfo x = new TaskInfo();
                x.Id = element.Id;
                x.Content = element.AssignToYouText;
                menuModels[3].TaskInfos.Add(x);
            }
            var allTasks = _taskDBEntities.Tasks.SqlQuery("Select * from dbo.task where UserId=" + Id).ToList();
            foreach (var element in allTasks)
            {
                TaskInfo x = new TaskInfo();
                x.Id = element.Id;
                x.Content = element.TaskText;
                menuModels[4].TaskInfos.Add(x);
            }
            SelectedCommand = new RelayCommand<MenuModel>(t => Select(t));
            SelectedTaskCommand = new RelayCommand<TaskInfo>(t => SelectedTask(t));
        }

    
        public ObservableCollection<MenuModel> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }
        public RelayCommand<MenuModel> SelectedCommand { get; set; }
        public RelayCommand<TaskInfo> SelectedTaskCommand { get; set; }

        private MenuModel menuModel;

        public MenuModel MenuModel
        {
            get { return menuModel; }
            set { menuModel = value; RaisePropertyChanged(); }
        }

        private TaskInfo info;

        public TaskInfo Info
        {
            get { return info; }
            set { info = value; RaisePropertyChanged(); }
        }

        private void Select(MenuModel model)
        {
            MenuModel = model;
        }

        public void AddTaskInfo(string content)
        {
            MenuModel.TaskInfos.Add(new TaskInfo()
            {
                Content = content
            });

            AddToDataBase(MenuModel.Name, content);
        }
        public void RemoveItem(TaskInfo collection)
        {
            
            MenuModel.TaskInfos.Remove(collection);
            removeDatabase(MenuModel.Name, collection.Id);
        }

        private void removeDatabase(string name, int id)
        {
            string col = name + "Text";

            string connectionString = "Server=DESKTOP-JOK8PNO; Database=TaskDB; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand deleteCommand = connection.CreateCommand())

                {
                    deleteCommand.CommandText = "delete from " + name + " where Id=@Id";
                    deleteCommand.Parameters.AddWithValue("@Id", id);
                    deleteCommand.Connection.Open();
                    deleteCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Delete from Database successful");
        }

        private void AddToDataBase(string name,string content)
        {
            string col = name + "Text";
     
            string connectionString = "Server=DESKTOP-JOK8PNO; Database=TaskDB; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand insertCommand = connection.CreateCommand())

                {
                    insertCommand.CommandText = "INSERT INTO " + name + " (UserId," + col + ") VALUES (@user,@txt)";
                    insertCommand.Parameters.AddWithValue("@user", Int32.Parse(userid));
                    insertCommand.Parameters.AddWithValue("@txt", content);
                    insertCommand.Connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Add to Database successful");
        }

        public void SelectedTask(TaskInfo task)
        {
            Info = task;
            Messenger.Default.Send(task, "Expand");
        }
    }
}