using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoEmployee
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Employee> GetEmployee(HotelContext context)
        {
            IQueryable<Employee> query = context.Employees.AsNoTracking();
            List<Employee> employees = query.ToList();
            return employees;
        }

        /// <summary>
        /// Получение списка сотрудников по primary key
        /// </summary>
        /// <param name="context"></param>
        /// <param name="individualNumber"></param>
        /// <returns></returns>
        public Employee GetEmployeeOnId(HotelContext context, int individualNumber)
        {
            Employee employees = context.Employees.Where(c => c.IndividualNumber == individualNumber).FirstOrDefault();
            return employees;
        }

        public List<Employee> GetEmployeeOnString(HotelContext context, string namePosition)
        {
            IQueryable<Employee> query = context.Employees.Where(c => c.Position.NamePosition == namePosition);
            List<Employee> employees = query.ToList();
            return employees;
        }

        public Employee GetEmployeeOnSurname(HotelContext context, string surname)
        {
            Employee employees = context.Employees.Where(c => c.Surname == surname).FirstOrDefault();
            return employees;
        }
        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="position"></param>
        public void AddEmployee(HotelContext context, string surname, string name, string patronymic, Position position)
        {
            //var context = new HotelContext();
            Employee employees = context.Employees.Add(new Employee { Surname = surname, Name = name, Patronymic = patronymic, Position = position });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="individualNumber"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="position"></param>
        public void UpdateEmployee(HotelContext context, int individualNumber, string surname, string name, string patronymic, Position position)
        {
            Employee employees = context.Employees.Where(c => c.IndividualNumber == individualNumber).FirstOrDefault();
            employees.Surname = surname;
            employees.Name = name;
            employees.Patronymic = patronymic;
            employees.Position = position;
            context.SaveChanges();
        }
        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="individualNumber"></param>
        public void DeleteEmployee(HotelContext context, int individualNumber)
        {
            Employee employees = context.Employees.Where(c => c.IndividualNumber == individualNumber).FirstOrDefault();
            context.Employees.Remove(employees);
            context.SaveChanges();
        }
    }
}
