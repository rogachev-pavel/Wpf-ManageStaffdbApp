using ManageStaffDBapp.Model;
using ManageStaffDBapp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManageStaffDBapp.ViewModel
{
    internal class DataManageVM : INotifyPropertyChanged
    {
        //Department model values
        public string DepartmentName { get; set; }

        //Position model values
        public string PositionName { get; set; }
        public decimal PositionSalary { get; set; }
        public int PositionMaxNumber { get; set; }
        public Department PositionDepartment { get; set; }

        //User model values
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserPhone { get; set; }
        public Position UserPosition { get; set; }


        private List<Department> alldepartments = DataWorker.GetAllDepartments();
        public List<Department> AllDepartments
        {
            get { return alldepartments; }
            set
            {
                alldepartments = value;
                NotifyPropertyChanged(nameof(AllDepartments));
            }
        }


        private List<Position> allpositions = DataWorker.GetAllPositions();
        public List<Position> AllPositions
        {
            get { return allpositions; }
            set
            {
                allpositions = value;
                NotifyPropertyChanged(nameof(AllPositions));
            }
        }


        private List<User> allusers = DataWorker.GetAllUsers();
        public List<User> AllUsers
        {
            get { return allusers; }
            set
            {
                allusers = value;
                NotifyPropertyChanged(nameof(AllUsers));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string resultStr = "";
    }
}
