using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoHotelUser
    {
        /// <summary>
        /// Получение списка пользователей гостиницы
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<HotelUser> GetHostelUser(HotelContext context)
        {
            IQueryable<HotelUser> query = context.HotelUsers.AsNoTracking();
            List<HotelUser> hotelUser = query.ToList();
            return hotelUser;
        }

        /// <summary>
        /// Получение пользователя по primary key
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userNumber"></param>
        /// <returns></returns>
        public HotelUser GetHotelUserOnId(HotelContext context, int userNumber)
        {
            HotelUser hotelUser = context.HotelUsers.Where(c => c.UserNumber == userNumber).FirstOrDefault();
            return hotelUser;
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="context"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        public void AddHostelUser(HotelContext context, string surname, string name, string patronymic, string email)
        {
            HotelUser hotelUser = context.HotelUsers.Add(new HotelUser { Surname = surname, Name = name, Patronymic = patronymic, Email = email });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление пользователя
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userNumber"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="email"></param>
        public void UpdateHotelUser(HotelContext context, int userNumber, string surname, string name, string patronymic, string email)
        {
            HotelUser hotelUser = context.HotelUsers.Where(c => c.UserNumber == userNumber).FirstOrDefault();
            hotelUser.Surname = surname;
            hotelUser.Name = name;
            hotelUser.Patronymic = patronymic;
            hotelUser.Email = email;
            context.SaveChanges();
        }
        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userNumber"></param>
        public void DeleteRoom(HotelContext context, int userNumber)
        {
            HotelUser hotelUser = context.HotelUsers.Where(c => c.UserNumber == userNumber).FirstOrDefault();
            context.HotelUsers.Remove(hotelUser);
            context.SaveChanges();
        }
    }
}
