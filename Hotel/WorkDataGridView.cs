using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.DAO;
using System.Windows.Forms;

namespace Hotel
{
    class WorkDataGridView
    {
        DaoEmployee daoEmployee = new DaoEmployee();
        DaoPosition daoPosition = new DaoPosition();
        DaoRoom daoRoom = new DaoRoom();
        DaoRecall daoRecall = new DaoRecall();
        DaoHotelUser daoHotelUser = new DaoHotelUser();
        DaoAnswer daoAnswer = new DaoAnswer();
        public void PrintEmployee(DataGridView employeeDataGridView)
        {

            List<Employee> listEmployee = daoEmployee.GetEmployee(Data.context);
            List<Position> listPosition = daoPosition.GetPosition(Data.context);
            employeeDataGridView.Rows.Clear();
            int i = 0;
            foreach (Employee employee in listEmployee)
            {
                employeeDataGridView.Rows.Add(employee.IndividualNumber, employee.Surname, employee.Name, employee.Patronymic);
                employeeDataGridView.Rows[i].Cells[4].Value = employee.Position.NamePosition;
                i++;
            }
        }

        public void TabEmployee(DataGridView employeeDataGridView)
        {
            List<Employee> listEmployee = daoEmployee.GetEmployee(Data.context);
            List<Employee> listEmployeeNew = new List<Employee>();
            List<Position> listPosition = daoPosition.GetPosition(Data.context);
            for (int i = 0; i < employeeDataGridView.RowCount - 1; i++)
            {
                Employee employee1 = new Employee();
                if (employeeDataGridView.Rows[i].Cells[0].Value != null)
                    employee1.IndividualNumber = Convert.ToInt16(employeeDataGridView.Rows[i].Cells[0].Value.ToString());
                employee1.Surname = employeeDataGridView.Rows[i].Cells[1].Value.ToString();
                employee1.Name = employeeDataGridView.Rows[i].Cells[2].Value.ToString();
                employee1.Patronymic = employeeDataGridView.Rows[i].Cells[3].Value.ToString();
                employee1.Position = daoPosition.GetPositionOnString(Data.context, employeeDataGridView.Rows[i].Cells[4].Value.ToString());
                listEmployeeNew.Add(employee1);
            }
            for (int i = 0; i < listEmployee.Count; i++)
            {
                if (listEmployee[i].IndividualNumber != listEmployeeNew[i].IndividualNumber || listEmployee[i].Surname != listEmployeeNew[i].Surname || listEmployee[i].Name != listEmployeeNew[i].Name || listEmployee[i].Patronymic != listEmployeeNew[i].Patronymic || listEmployee[i].Position != listEmployeeNew[i].Position)
                    daoEmployee.UpdateEmployee(Data.context, listEmployeeNew[i].IndividualNumber, listEmployeeNew[i].Surname, listEmployeeNew[i].Name, listEmployeeNew[i].Patronymic, listEmployeeNew[i].Position);
            }
            for (int i = listEmployee.Count; i < listEmployeeNew.Count; i++)
                daoEmployee.AddEmployee(Data.context, listEmployeeNew[i].Surname, listEmployeeNew[i].Name, listEmployeeNew[i].Patronymic, listEmployeeNew[i].Position);
        }

        public void TabPosition(DataGridView positionDataGridView)
        {
            List<Position> listPositionNew = new List<Position>();
            List<Position> listPosition = daoPosition.GetPosition(Data.context);
            for (int i = 0; i < positionDataGridView.RowCount - 1; i++)
            {
                Position positionNew = new Position();
                if (Convert.ToInt16(positionDataGridView.Rows[i].Cells[0].Value.ToString()) != -1)
                    positionNew.IdentifierPosition = Convert.ToInt16(positionDataGridView.Rows[i].Cells[0].Value.ToString());
                positionNew.NamePosition = positionDataGridView.Rows[i].Cells[1].Value.ToString();
                positionNew.Description = positionDataGridView.Rows[i].Cells[2].Value.ToString();
                listPositionNew.Add(positionNew);
            }
            for (int i = 0; i < listPosition.Count; i++)
            {
                if (listPosition[i].NamePosition != listPositionNew[i].NamePosition || listPosition[i].Description != listPositionNew[i].Description)
                    daoPosition.UpdatePosition(Data.context, listPositionNew[i].IdentifierPosition, listPositionNew[i].NamePosition, listPositionNew[i].Description);
            }
            for (int i = listPosition.Count; i < listPositionNew.Count; i++)
                daoPosition.AddPosition(Data.context, listPositionNew[i].NamePosition, listPositionNew[i].Description);
        }

        public void TabRoom(DataGridView roomDataGridView)
        {
            List<Room> listRoomNew = new List<Room>();
            List<Room> listRoom = daoRoom.GetRooms(Data.context);
            for (int i = 0; i < roomDataGridView.RowCount - 1; i++)
            {
                Room roomNew = new Room();
                if (Convert.ToInt16(roomDataGridView.Rows[i].Cells[0].Value.ToString()) != -1)
                    roomNew.NumberRoom = Convert.ToInt16(roomDataGridView.Rows[i].Cells[0].Value.ToString());
                roomNew.TypeRoom = roomDataGridView.Rows[i].Cells[1].Value.ToString();
                listRoomNew.Add(roomNew);
            }
            for (int i = 0; i < listRoom.Count; i++)
            {
                if (listRoom[i].TypeRoom != listRoomNew[i].TypeRoom)
                    daoRoom.UpdateRoom(Data.context, listRoomNew[i].NumberRoom, listRoomNew[i].TypeRoom);
            }
            for (int i = listRoom.Count; i < listRoomNew.Count; i++)
                daoRoom.AddRoom(Data.context, listRoomNew[i].TypeRoom);
        }

        public void PrintRecall(DataGridView recallDataGridView)
        {

            List<Recall> listRecall = daoRecall.GetRecall(Data.context);
            recallDataGridView.Rows.Clear();
            string fio = "", fioEmployee = "", room = "";
            foreach (Recall recall in listRecall)
            {
                fio = recall.HotelUser.Surname + " " + recall.HotelUser.Name + " " + recall.HotelUser.Patronymic;
                if (recall.Employee != null)
                    fioEmployee = recall.Employee.Surname + " " + recall.Employee.Name + " " + recall.Employee.Patronymic;
                else fioEmployee = "";
                if (recall.Room != null)
                    room = recall.Room.NumberRoom.ToString();
                else room = "";
                if (recall.Answers.Count != 0)
                    foreach (Answer answer in recall.Answers)
                        recallDataGridView.Rows.Add(recall.NumberRecall, fio, recall.DateTime, recall.TypeRecall, recall.SubjectRecall, recall.TopicRecall, recall.Comment, answer.AnswerOnRecall, room, fioEmployee);
                else recallDataGridView.Rows.Add(recall.NumberRecall, fio, recall.DateTime, recall.TypeRecall, recall.SubjectRecall, recall.TopicRecall, recall.Comment, "", room, fioEmployee);
            }
        }

        public void PrintAnswer(DataGridView answerDataGridView)
        {

            List<Answer> listAnswer = daoAnswer.GetAnswer(Data.context);
            answerDataGridView.Rows.Clear();
            string fio = "", fioEmployee = "";
            foreach (Answer answer in listAnswer)
            {
                fio = answer.Recall.HotelUser.Surname + " " + answer.Recall.HotelUser.Name + " " + answer.Recall.HotelUser.Patronymic;
                fioEmployee = answer.Employee.Surname + " " + answer.Employee.Name + " " + answer.Employee.Patronymic;
                answerDataGridView.Rows.Add(answer.NumberAnswer, fio, answer.Recall.Comment, fio, answer.DateTimeAnswer, answer.AnswerOnRecall, fioEmployee);
            }
        }
    }
}
