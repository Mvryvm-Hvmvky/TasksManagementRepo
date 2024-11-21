using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        TasksManagementDBEntities1  DB = new TasksManagementDBEntities1();

        public ManagerPage()
        {
            InitializeComponent();
            View();
        }
        void View()
        {
            var M = DB.Tasks.Select(T => T.tStatus).ToList();
            Comp.SelectedItem = M;
            DG1.ItemsSource = DB.Tasks.Select(T => new
            {
                T.User.Email,
                T.ID,
                T.tStatus,
                T.tDescription,
                T.Title  
            }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtxt.Text))
            {
                MessageBox.Show("please enter task id");
                return;
            }
            int id = int.Parse(idtxt.Text);
            var task = DB.Tasks.FirstOrDefault(x => x.ID == id);
            if (task != null)
            {
                DB.Tasks.Remove(task);
                DB.SaveChanges();
                MessageBox.Show("task deleted done !!");
                View();
            }
            else
            {
                MessageBox.Show($"Task with ID {id} wasn't found");
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtxt.Text)) {

                MessageBox.Show(" Enter task id");
                return;
            }
            if (string.IsNullOrWhiteSpace(titletxt.Text))
            {
                MessageBox.Show(" Enter Task title");
                return;
            }
            if (string.IsNullOrWhiteSpace(destxt.Text))
            {
                MessageBox.Show("enter task description");
                return;
            }
            

            if (string.IsNullOrWhiteSpace(Comp.SelectedItem.ToString()))
            {
                MessageBox.Show(" Choose from Compobox");
                return;
            }

            var empl = DB.Users.Where(U=> U.Email == Emailtxt.Text);

            if(empl == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            int Id = int.Parse(idtxt.Text);
            Task task = DB.Tasks.FirstOrDefault(T => T.ID == Id);
            task.Title = titletxt.Text;
            task.tDescription = destxt.Text;
            task.tStatus = Comp.Text;
            task.User.Email = Emailtxt.Text;
            DB.Tasks.AddOrUpdate(task);
            DB.SaveChanges();
            View();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtxt.Text))
            {
                MessageBox.Show(" Enter task id");
                return;
            }
            if (string.IsNullOrWhiteSpace(titletxt.Text))
            {

                MessageBox.Show(" Enter Task title");
                return;
            }
            if (string.IsNullOrWhiteSpace(destxt.Text))
            {

                MessageBox.Show("enter task description");
                return;
            }
            if (Comp.SelectedItem == null)
            {
                MessageBox.Show("Choose from combo box");
                return;
            }

            int Id = int.Parse(idtxt.Text);
            var task = DB.Tasks.FirstOrDefault(T => T.ID == Id);
            task.Title = titletxt.Text;
            task.tDescription = destxt.Text;
            task.tStatus = Comp.Text;
            task.User.Email = Emailtxt.Text;
            DB.Tasks.Add(task);
            DB.SaveChanges();
            View();
        }
    }
}
