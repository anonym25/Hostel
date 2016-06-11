using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoRoom
    {
        /// <summary>
        /// Получение списка комнат
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Room> GetRooms(HotelContext context)
        {
            IQueryable<Room> query = context.Rooms.AsNoTracking();
            List<Room> rooms = query.ToList();
            return rooms;
        }

        /// <summary>
        /// Получение списка комнат по primary key
        /// </summary>
        /// <param name="context"></param>
        /// <param name="individualNumber"></param>
        /// <returns></returns>
        public Room GetRoomOnId(HotelContext context, int numberRoom)
        {
            Room rooms = context.Rooms.Where(c => c.NumberRoom == numberRoom).FirstOrDefault();
            return rooms;
        }

        /// <summary>
        ///  Добавление комнаты
        /// </summary>
        /// <param name="context"></param>
        /// <param name="typeRoom"></param>
        public void AddRoom(HotelContext context, string typeRoom)
        {
            Room rooms = context.Rooms.Add(new Room { TypeRoom = typeRoom });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление комнаты
        /// </summary>
        /// <param name="context"></param>
        /// <param name="numberRoom"></param>
        /// <param name="typeRoom"></param>
        public void UpdateRoom(HotelContext context, int numberRoom, string typeRoom)
        {
            Room rooms = context.Rooms.Where(c => c.NumberRoom == numberRoom).FirstOrDefault();
            rooms.TypeRoom = typeRoom;
            context.SaveChanges();
        }
       /// <summary>
       /// Удаление комнаты
       /// </summary>
       /// <param name="context"></param>
       /// <param name="numberRoom"></param>
        public void DeleteRoom(HotelContext context, int numberRoom)
        {
            Room rooms = context.Rooms.Where(c => c.NumberRoom == numberRoom).FirstOrDefault();
            context.Rooms.Remove(rooms);
            context.SaveChanges();
        }
    }
}
