using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class DaoAnswer
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Answer> GetAnswer(HotelContext context)
        {
            IQueryable<Answer> query = context.Answers.AsNoTracking();
            List<Answer> answers = query.ToList();
            return answers;
        }

        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="dateTimeAnswer"></param>
        /// <param name="answerOnRecall"></param>
        /// <param name="recall"></param>
        /// <param name="employee"></param>
        public void AddAnswer(HotelContext context, DateTime dateTimeAnswer, string answerOnRecall, Recall recall, Employee employee)
        {
            //var context = new HotelContext();
            Answer answers = context.Answers.Add(new Answer { DateTimeAnswer = dateTimeAnswer, AnswerOnRecall = answerOnRecall, Recall = recall, Employee = employee });
            context.SaveChanges();
        }

        /// <summary>
        /// Обновление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="numberAnswer"></param>
        /// <param name="dateTimeAnswer"></param>
        /// <param name="answerOnRecall"></param>
        /// <param name="recall"></param>
        /// <param name="employee"></param>
        public void UpdateAnswer(HotelContext context, int numberAnswer, DateTime dateTimeAnswer, string answerOnRecall, Recall recall, Employee employee)
        {
            Answer answers = context.Answers.Where(c => c.NumberAnswer == numberAnswer).FirstOrDefault();
            answers.DateTimeAnswer = dateTimeAnswer;
            answers.AnswerOnRecall = answerOnRecall;
            answers.Recall = recall;
            answers.Employee = employee;
            context.SaveChanges();
        }
        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="context"></param>
        /// <param name="numberAnswer"></param>
        public void DeleteAnswer(HotelContext context, int numberAnswer)
        {
            Answer answers = context.Answers.Where(c => c.NumberAnswer == numberAnswer).FirstOrDefault();
            context.Answers.Remove(answers);
            context.SaveChanges();
        }
    }
}
