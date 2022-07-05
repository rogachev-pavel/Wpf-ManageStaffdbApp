using ManageStaffDBapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManageStaffDBapp.ViewModel
{
    internal class UpdateValuesVM : DataManageVM
    {

        private readonly RelayCommand updateDepartment;
        public RelayCommand UpdateDepartment
        {
            get
            {
                return updateDepartment ?? new RelayCommand(obj =>
                {

                    Window wnd = obj as Window;
                    string resultStr = "";

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
    }
}
