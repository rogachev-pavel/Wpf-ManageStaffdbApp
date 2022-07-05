using ManageStaffDBapp.Model;
using ManageStaffDBapp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStaffDBapp.ViewModel
{
    internal class UpdateItemsInWindowVM : DataManageVM
    {
        public void UpdateItemsInWindow()
        {
            UpdateAllDepartments();
            UpdateAllPositions();
            UpdateAllUsers();
        }

        private void UpdateAllDepartments()
        {
            AllDepartments = DataWorker.GetAllDepartments();
            MainWindow.AllDepartmensView.ItemsSource = null;
            MainWindow.AllDepartmensView.Items.Clear();
            MainWindow.AllDepartmensView.ItemsSource = AllDepartments;
            MainWindow.AllDepartmensView.Items.Refresh();
        }

        private void UpdateAllPositions()
        {
            AllPositions = DataWorker.GetAllPositions();
            MainWindow.AllPositionsView.ItemsSource = null;
            MainWindow.AllPositionsView.Items.Clear();
            MainWindow.AllPositionsView.ItemsSource = AllPositions;
            MainWindow.AllPositionsView.Items.Refresh();
        }

        private void UpdateAllUsers()
        {
            AllUsers = DataWorker.GetAllUsers();
            MainWindow.AllUsersView.ItemsSource = null;
            MainWindow.AllUsersView.Items.Clear();
            MainWindow.AllUsersView.ItemsSource = AllUsers;
            MainWindow.AllUsersView.Items.Refresh();
        } 
    }
}
