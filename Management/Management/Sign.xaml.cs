using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Sign.xaml
    /// </summary>
    public partial class Sign : Page
    {
        TasksManagementDBEntities1 DB = new TasksManagementDBEntities1();
        User _user = new User();
        public Sign(User user)
        {
            InitializeComponent();
            this._user = user;
        }
        
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Newpassword = NewPasswordtxt.Text,
                   confirmpasword = ConfirmPassordtxt.Text;
            
            if (string.IsNullOrWhiteSpace(Newpassword) ||
                string.IsNullOrWhiteSpace(confirmpasword))
            {
                MessageBox.Show("Plese Enter Your Password");
                return;

            }

            if (Newpassword.Length < 8 )
            {
                MessageBox.Show("Password Must be more than 8 ");
                return;
            }
            var rec = DB.Users.FirstOrDefault(U => U.uPassword != Newpassword && U.Email == _user.Email);
            if (rec != null && Newpassword == confirmpasword)
            {
                rec.uPassword = Newpassword;
                DB.Users.AddOrUpdate(rec);
                DB.SaveChanges();
                MessageBox.Show("Update Successfuly");
            }
            else
            {  
                MessageBox.Show("You already have this password for you account \n"+
                                "Or please check that the 2 fields are equal");
                return;
            }
        }
    }
}