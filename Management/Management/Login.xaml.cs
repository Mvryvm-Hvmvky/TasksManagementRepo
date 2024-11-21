using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Management
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        TasksManagementDBEntities1 DB = new TasksManagementDBEntities1();
        public Login()
        {
            InitializeComponent();
        }
 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Passwordtxt.Text) ||
                string.IsNullOrWhiteSpace(Emailtxt.Text))
            {
                MessageBox.Show("All fields must be filled");
                return;
                
            }
  
            var rec = DB.Users.FirstOrDefault(U => U.Email == Emailtxt.Text && U.uPassword == Passwordtxt.Text);
            if (rec != null)
            {
                if(rec.uRole.ToLower().Trim() == "employee")
                {
                    MessageBox.Show("Login Successfuly");
                    NavigationService.Navigate(new EmployeePage(rec));
                }

                else if (rec.uRole.ToLower().Trim() == "manager")
                {
                    MessageBox.Show("Login Successfuly");
                    NavigationService.Navigate(new ManagerPage());
                }
            }
            else
            {
                MessageBox.Show($"Account Not Found !!");
                return;
            }
        }

        private void ConfirmPassword(object sender, RoutedEventArgs e)
        {
                if (string.IsNullOrWhiteSpace(Emailtxt.Text))
                {
                    MessageBox.Show("Plese Enter Your Email");
                    return;
                }
                var rec = DB.Users.FirstOrDefault(U => U.Email == Emailtxt.Text);
                if (rec != null)
                {
                    this.NavigationService.Navigate(new Sign(rec));
                }
                else
                {
                    MessageBox.Show("Email not found");
                }  
            //var rec = DB.Userrs.FirstOrDefault(U => U.UserEmail == Emailtxt.Text);
        }
    }
}
