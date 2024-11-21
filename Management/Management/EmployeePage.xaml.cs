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
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        TasksManagementDBEntities1 DB = new TasksManagementDBEntities1();
        User _user = new User();
        public EmployeePage(User user)
        {
            InitializeComponent();
            this._user = user;
            nameTxtBlock.Text = _user.uName;   
            Change();
        }

        void Change()
        {
            var rec = DB.Tasks.Where(T => (T.tStatus.ToLower().Trim() == "in progress" || T.tStatus.ToLower().Trim() == "pending") && T.userID == _user.ID)
                .Select(T => new{ T.ID,T.tDescription, T.tStatus,T.Title});
            DG1.ItemsSource = rec.ToList();
            var rec2 = DB.Tasks.Where(T => (T.tStatus.ToLower().Trim() == "completed") && T.userID == _user.ID)
                .Select(T => new{ T.ID, T.tDescription,T.tStatus,T.Title});
            DG2.ItemsSource = rec2.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtxt.Text))
            {
                MessageBox.Show("Please Enter Task id");
                return;
            }
            int Id = int.Parse(idtxt.Text);
            var emp = DB.Tasks.FirstOrDefault(T => T.ID == Id && T.userID == _user.ID);
            if (emp == null)
            {
                MessageBox.Show("Task not Found");
                return;
            }

            if (Comp.SelectedItem == null)
            {
                MessageBox.Show("Chosse From compo");
                return;
            }
            emp.tStatus = Comp.Text;
            DB.Tasks.AddOrUpdate(emp);
            DB.SaveChanges();
            Change();    
        }
    }
}

