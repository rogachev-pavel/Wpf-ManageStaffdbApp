using ManageStaffDBapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ManageStaffDBapp.ViewModel
{
    internal class AddNewValueVM : DataManageVM
    {


        private readonly RelayCommand addNewDepartment;
        public RelayCommand AddNewDepartment
        {
            get
            {
                return addNewDepartment ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;

                    if (DepartmentName == null || DepartmentName.Replace(" ", "").Length == 0)
                    {
                        Style.SetRedBlockControll(wnd, "NameBlock");
                    }

                    else
                    {
                        resultStr = DataWorker.CreateDepartment(DepartmentName);
                        update.UpdateItemsInWindow();
                        OpenWindowVM.ShowMessageView(resultStr);
                        wnd.Close(); 
                    }
                });
            }
        }


        private readonly RelayCommand addNewPosition;
        public RelayCommand AddNewPosition
        {
            get
            {
                return addNewPosition ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;

                    if (PositionName == null || PositionName.Replace(" ", "").Length == 0)
                    {
                        Style.SetRedBlockControll(wnd, "NamePosBlock");
                    }

                    else if (PositionSalary == 0)
                    {
                        Style.SetRedBlockControll(wnd, "SalaryPosBlock");
                    }

                    else if (PositionMaxNumber == 0)
                    {
                        Style.SetRedBlockControll(wnd, "MaxNumberPosBlock");
                    }

                    else if (PositionDepartment == null)
                    {
                        MessageBox.Show("Укажите отдел");
                    }

                    else
                    {
                        resultStr = DataWorker.CreatePosition(PositionName, PositionSalary, PositionMaxNumber, PositionDepartment);
                        update.UpdateItemsInWindow();
                        OpenWindowVM.ShowMessageView(resultStr);
                        wnd.Close();

                    }
                });
            }
        }


        private readonly RelayCommand addNewUser;
        public RelayCommand AddNewUser
        {
            get
            {
                return addNewUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;

                    if (UserName == null || UserName.Replace(" ", "").Length == 0)
                    {
                        Style.SetRedBlockControll(wnd, "UserNameBlock");
                    }

                    else if (UserSurName == null || UserSurName.Replace(" ", "").Length == 0)
                    {
                        Style.SetRedBlockControll(wnd, "UserSurNameBlock");
                    }

                    else if (UserPhone == null || UserPhone.Replace(" ", "").Length == 0)
                    {
                        Style.SetRedBlockControll(wnd, "UserPhoneBlock");
                    }

                    else if (UserPosition == null)
                    {
                        MessageBox.Show("Укажите должность");
                    }

                    else
                    {
                        resultStr = DataWorker.CreateUser(UserName, UserSurName, UserPhone, UserPosition);
                        update.UpdateItemsInWindow();
                        OpenWindowVM.ShowMessageView(resultStr);
                        wnd.Close();
                    }
                });
            }
        }
    }
}
