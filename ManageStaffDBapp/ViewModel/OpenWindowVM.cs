using ManageStaffDBapp.Model;
using ManageStaffDBapp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManageStaffDBapp.ViewModel
{
    internal class OpenWindowVM : DataManageVM
    {
        #region OPEN WindowMethotds


        //open add window
        private void OpenAddUserWindowMethod()
        {
            AddNewUserWindow newUserWindow = new AddNewUserWindow();
            SetCenterPositionWindow(newUserWindow);
        }

        private void OpenAddPositionWindowMethod()
        {
            AddNewPositionWindow newPosWindow = new AddNewPositionWindow();
            SetCenterPositionWindow(newPosWindow);
        }

        private void OpenAddDepartmentWindowMethod()
        {
            AddNewDepartmentWindow newDepartmentWindow = new AddNewDepartmentWindow();
            SetCenterPositionWindow(newDepartmentWindow);
        }

        //open create window 
        private void OpenEditUserWindowMethod()
        {
            EditUserWindow editUserWindow = new EditUserWindow();
            SetCenterPositionWindow(editUserWindow);
        }

        private void OpenEditPositionWindowMethod()
        {
            EditPositionWindow editPosWindow = new EditPositionWindow();
            SetCenterPositionWindow(editPosWindow);
        }

        private void OpenEditDepartmentWindowMethod()
        {
            EditDepartmentWindow editDepartmentWindow = new EditDepartmentWindow();
            SetCenterPositionWindow(editDepartmentWindow);
        }

        private static void SetCenterPositionWindow(Window windowName)
        {
            windowName.Owner = Application.Current.MainWindow;
            windowName.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            windowName.ShowDialog();
        }
        #endregion


        #region COMMAND TO OPEN WIN


        private RelayCommand openAddNewDepartmentWind;
        public RelayCommand OpenAddNewDepartmentWind
        {
            get
            {
                return openAddNewDepartmentWind ?? new RelayCommand(x => OpenAddDepartmentWindowMethod());
            }

        }

        private RelayCommand openAddNewUserWind;
        public RelayCommand OpenAddNewUserWind
        {
            get
            {
                return openAddNewUserWind ?? new RelayCommand(x => OpenAddUserWindowMethod());
            }

        }

        private RelayCommand openAddNewPositionWind;
        public RelayCommand OpenAddNewPositionWind
        {
            get
            {
                return openAddNewPositionWind ?? new RelayCommand(x => OpenAddPositionWindowMethod());
            }

        }


        private RelayCommand openEditDepartmentWind;
        public RelayCommand OpenEditDepartmentWind
        {
            get
            {
                return openEditDepartmentWind ?? new RelayCommand(x => OpenEditDepartmentWindowMethod());
            }

        }

        private RelayCommand openEditUserWind;
        public RelayCommand OpenEditUserWind
        {
            get
            {
                return openEditUserWind ?? new RelayCommand(x => OpenEditUserWindowMethod());
            }

        }

        private RelayCommand openEditPositionWind;
        public RelayCommand OpenEditPositionWind
        {
            get
            {
                return openEditPositionWind ?? new RelayCommand(x => OpenEditPositionWindowMethod());
            }

        }
        #endregion

        //Modal completion message
        public static void ShowMessageView(string message)
        {
            MessageView messageView = new MessageView(message);
            SetCenterPositionWindow(messageView);
        }
    }
}
