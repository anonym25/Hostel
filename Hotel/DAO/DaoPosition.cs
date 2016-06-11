using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoPosition
    {
        /// <summary>
        /// Получение списка должностей
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Position> GetPosition(HotelContext context)
        {
            IQueryable<Position> query = context.Positions.AsNoTracking();
            List<Position> positions = query.ToList();
            return positions;
        }
        /// <summary>
        /// Получение списка должностей по primary key
        /// </summary>
        /// <param name="context"></param>
        /// <param name="identifierPosition"></param>
        /// <returns></returns>
        public Position GetPositionOnId(HotelContext context, int identifierPosition)
        {
            Position positions = context.Positions.Where(c => c.IdentifierPosition == identifierPosition).FirstOrDefault();
            return positions;
        }

        public Position GetPositionOnString(HotelContext context, string namePosition)
        {
            Position positions = context.Positions.Where(c => c.NamePosition == namePosition).FirstOrDefault();
            return positions;
        }
        /// <summary>
        /// Добавление должности
        /// </summary>
        /// <param name="context"></param>
        /// <param name="namePosition"></param>
        /// <param name="description"></param>
        public void AddPosition(HotelContext context, string namePosition, string description)
        {
            Position positions = context.Positions.Add(new Position { NamePosition = namePosition, Description = description });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление должности
        /// </summary>
        /// <param name="context"></param>
        /// <param name="identifierPosition"></param>
        /// <param name="namePosition"></param>
        /// <param name="description"></param>
        public void UpdatePosition(HotelContext context, int identifierPosition, string namePosition, string description)
        {
            Position positions = context.Positions.Where(c => c.IdentifierPosition == identifierPosition).FirstOrDefault();
            positions.NamePosition = namePosition;
            positions.Description = description;
            context.SaveChanges();
        }
 
        /// <summary>
        ///Удаление должности 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="identifierPosition"></param>
        public void DeletePosition(HotelContext context, int identifierPosition)
        {
            Position positions = context.Positions.Where(c => c.IdentifierPosition == identifierPosition).FirstOrDefault();
            context.Positions.Remove(positions);
            context.SaveChanges();
        }
    }
}
