using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoRecall
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Recall> GetRecall(HotelContext context)
        {
            IQueryable<Recall> query = context.Recalls.AsNoTracking();
            List<Recall> recalls = query.ToList();
            return recalls;
        }

        public List<Recall> GetRecallBookOnDate(HotelContext context, DateTime dateRecall, DateTime dateRecall2)
        {
            List<Recall> recalls = context.Recalls.Where(c => (c.DateTime > dateRecall && c.DateTime < dateRecall2)).ToList();
            return recalls;
        }

        public List<Recall> GetRecallBookOnString(HotelContext context, List<Recall> listRecalls, string stringRecall)
        {
            List<Recall> recalls = listRecalls.Where(c => (c.TypeRecall == stringRecall) || (c.SubjectRecall == stringRecall) || (c.NumberRecall.ToString() == stringRecall)).ToList();
            return recalls;
        }

        public List<Recall> GetRecallBookOnString(HotelContext context, List<Recall> listRecalls, int intRecall)
        {
            List<Recall> recalls = listRecalls.Where(c => c.IndividualNumberFK == intRecall).ToList();
            return recalls;
        }

        public List<Recall> GetRecallBookOnStringLike(HotelContext context, List<Recall> listRecalls, string stringRecall)
        {
            List<Recall> recalls = listRecalls.Where(c => c.TopicRecall.Contains(stringRecall) || c.TopicRecall.StartsWith(stringRecall) || c.TopicRecall.EndsWith(stringRecall)).ToList();
            return recalls;
        }

        /// <summary>
        /// Получение списка отзывов по primary key
        /// </summary>
        /// <param name="context"></param>
        /// <param name="numberRecall"></param>
        /// <returns></returns>
        public Recall GetRecallOnId(HotelContext context, int numberRecall)
        {
            Recall recalls = context.Recalls.Where(c => c.NumberRecall == numberRecall).FirstOrDefault();
            return recalls;
        }

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="dateTime"></param>
        /// <param name="typeRecall"></param>
        /// <param name="topicRecall"></param>
        /// <param name="comment"></param>
        /// <param name="hotelUser"></param>
        /// <param name="room"></param>
        /// <param name="employee"></param>
        public void AddRecall(HotelContext context, DateTime dateTime, string typeRecall, string topicRecall, string comment, HotelUser hotelUser, Room room, Employee employee)
        {
            //var context = new HotelContext();
            Recall recalls = context.Recalls.Add(new Recall { DateTime = dateTime, TypeRecall = typeRecall, Comment = comment, HotelUser = hotelUser, Room = room, Employee = employee });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="numberRecall"></param>
        /// <param name="dateTime"></param>
        /// <param name="typeRecall"></param>
        /// <param name="topicRecall"></param>
        /// <param name="comment"></param>
        /// <param name="hotelUser"></param>
        /// <param name="room"></param>
        /// <param name="employee"></param>
        public void UpdateRecall(HotelContext context, int numberRecall, DateTime dateTime, string typeRecall, string topicRecall, string comment, HotelUser hotelUser, Room room, Employee employee)
        {
            Recall recalls = context.Recalls.Where(c => c.NumberRecall == numberRecall).FirstOrDefault();
            recalls.DateTime = dateTime;
            recalls.TypeRecall = typeRecall;
            recalls.TopicRecall = topicRecall;
            recalls.Comment = comment;
            recalls.HotelUser = hotelUser;
            recalls.Room = room;
            recalls.Employee = employee;
            context.SaveChanges();
        }
       /// <summary>
       /// Удаление сотрудника
       /// </summary>
       /// <param name="context"></param>
       /// <param name="numberRecall"></param>
        public void DeleteRecall(HotelContext context, int numberRecall)
        {
            Recall recalls = context.Recalls.Where(c => c.NumberRecall == numberRecall).FirstOrDefault();
            context.Recalls.Remove(recalls);
            context.SaveChanges();
        }
    }
}
