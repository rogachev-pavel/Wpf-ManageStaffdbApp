using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStaffDBapp.Data;

namespace ManageStaffDBapp.Model
{
    internal class DataWorker
    {
        public static List<Department> GetAllDepartments()
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                var result = Db.DepartmentsRP.ToList();
                return result;
            }
        }

        public static List<Position> GetAllPositions()
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                var result = Db.PositionsRP.ToList();
                return result;
            }
        }
        public static List<User> GetAllUsers()
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                var result = Db.UsersRP.ToList();
                return result;
            }
        }

        public static string CreateDepartment(string name)
        {
            string result = "уже сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                bool checIsExist = Db.DepartmentsRP.Any(dep => dep.Name == name);
                if (!checIsExist)
                {
                    Department newDepartment = new Department { Name = name };
                    Db.DepartmentsRP.Add(newDepartment);
                    Db.SaveChanges();
                    result = "Департамент " + name + " добавлен";
                }
                return result;
            }
        }

        public static string CreatePosition(string name, decimal slary, int maxNumber, Department department)
        {
            string result = "уже сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                bool checIsExist = Db.PositionsRP.Any(pos => pos.Name == name && pos.Salary == slary);
                if (!checIsExist)
                {
                    Position newPosition = new Position { Name = name, Salary = slary, MaxNumber = maxNumber, DepartmentId = department.Id };
                    Db.PositionsRP.Add(newPosition);
                    Db.SaveChanges();
                    result = "Готово";
                }
                return result;
            }
        }

        public static string CreateUser(string name, string surName, string phone, Position position)
        {
            string result = "уже сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                bool checIsExist = Db.UsersRP.Any(us => us.Name == name && us.SurName == surName && us.Position == position);
                if (!checIsExist)
                {
                    User newPosition = new User { Name = name, SurName = surName, Phone = phone, PositionId = position.Id };
                    Db.UsersRP.Add(newPosition);
                    Db.SaveChanges();
                    result = "Готово";
                }
                return result;
            }
        }
        public static string DeleteDepartment(Department department)
        {
            string result = "объект не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                Db.DepartmentsRP.Remove(department);
                Db.SaveChanges();
                result = "Удалено";
            }
            return result;
        }
        public static string DeletePosition(Position position)
        {
            string result = "объект не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                Db.PositionsRP.Remove(position);
                Db.SaveChanges();
                result = "Удалено";
            }
            return result;
        }

        public static string DeleteUser(User user)
        {
            string result = "объект не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                Db.UsersRP.Remove(user);
                Db.SaveChanges();
                result = "Удалено";
            }
            return result;
        }

        public static string UpdateDepartment(Department oldDepartment, string newName)
        {
            string result = "не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                Department department = Db.DepartmentsRP.FirstOrDefault(x => x.Id == oldDepartment.Id);
                if (department != null)
                {
                    department.Name = newName;
                    Db.SaveChanges();
                    result = "Департамент" + newName + "обнавлен";
                }
                return result;
            }
        }
        public static string UpdatePosition(Position oldPosition, string newName, decimal newSlary, int newMaxNumber, Department newDepartment)
        {
            string result = "не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                Position position = Db.PositionsRP.FirstOrDefault(x => x.Id == oldPosition.Id);
                if (position != null)
                {
                    position.Name = newName;
                    position.Salary = newSlary;
                    position.MaxNumber = newMaxNumber;
                    position.DepartmentId = newDepartment.Id;
                    Db.SaveChanges();
                    result = "Должность" + newName + "обнавлена";
                }
                return result;
            }
        }

        public static string UpdateUser(User oldUser, string newName, string newSurName, string newPhone, Position newPosition)
        {
            string result = "не сушествует";
            using (AppDBcontext Db = new AppDBcontext())
            {
                User user = Db.UsersRP.FirstOrDefault(x => x.Id == oldUser.Id);
                if (user != null)
                {
                    user.Name = newName;
                    user. SurName = newSurName  ;
                    user.Phone = newPhone;
                    user.PositionId = newPosition.Id;
                    Db.SaveChanges();
                    result = "Пользователь" + newName + newSurName + "обнавлен";
                }
                return result;
            }
        }

        public static Position GetPositionById(int Id)
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                Position pos = Db.PositionsRP.FirstOrDefault(x => x.Id == Id);
                return pos;
            }
        }

        public static Department GetDepartmentById(int Id)
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                Department pos = Db.DepartmentsRP.FirstOrDefault(x => x.Id == Id);
                return pos;
            }
        }

        public static List<User> GetPositionUsersById(int Id)
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                List<User> users = Db.UsersRP.Where(x => x.PositionId == Id).ToList();
                return users;
            }
        }

        public static List<Position> GetDepartmentPositionById(int Id)
        {
            using (AppDBcontext Db = new AppDBcontext())
            {
                List<Position> positions = Db.PositionsRP.Where(x => x.DepartmentId == Id).ToList();
                return positions;
            }
        }
    }
}
