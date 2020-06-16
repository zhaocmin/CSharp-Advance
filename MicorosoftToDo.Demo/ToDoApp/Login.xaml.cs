using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Data;

namespace ToDoApp
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        //Registration registration = new Registration();
        //Welcome welcome = new Welcome();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
   
                string userName = userText.Text;
                string password = passwordBox1.Password;
                TaskDBEntities _taskDBEntities = new TaskDBEntities();
            //   var user = _taskDBEntities.Tasks.SqlQuery("Select * from Users where Email='" + userName + "'  and password='" + password + "'").FirstOrDefault();
            SqlConnection conn = new SqlConnection("Server=DESKTOP-JOK8PNO; Database=TaskDB; Integrated Security=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Users where username='" + userName + "'  and password='" + password + "'", conn);

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                string username1 = dataSet.Tables[0].Rows[0]["username"].ToString();
                string userId = dataSet.Tables[0].Rows[0]["Id"].ToString();
                MainWindow todo = new MainWindow(userId);
                this.Visibility = Visibility.Hidden;
                todo.Show();
                Close();

            }
            else
            {
                errormessage.Text = "Sorry! Please enter existing emailid/password.";
            }
            conn.Close();


        }
    }
     
    
}
