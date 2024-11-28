using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private const string InspectionName = "Автоинспекция г. Чита"; //Константа, которая хранит название инспекции.
        private string chiefInspector = "Васильев Василий Иванович"; //Строка, представляющая имя главного инспектора.
        private List<string> workers = new List<string> //Список строк, представляющий работников инспекции.
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector() // метод возвращает ФИО главного инспектора автоинспекции.
        {
            return chiefInspector;
        }

        public string GetCarInspection() // метод возвращает название автоинспекции.
        {
            return InspectionName;
        }

        public bool SetInspector(string fullname) //метод изменяет ФИО главного инспектора, только если данное ФИО есть в списке сотрудников
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
                Console.WriteLine("\nУспешно изменено.");
                return true; // Успешно изменено
            }
            else 
            {
                Console.WriteLine("\nИзменение не выполнено");
                return false;
            } // Изменение не выполнено
        }

        public string GenerateNumber(string number, char symbol, int code) /*метод
                                                                           формирует из принимаемых аргументов госномер вида
                                                                           SYMBOLnumber_CODE, где symbol в верхнем регистре любая буква.
                                                                           Number – случайный номер, code – код региона(75), и возвращает
                                                                           сгенерированный номер пользователю.*/
        {
            if (!char.IsUpper(symbol) || !int.TryParse(number, out _) || code <= 0)
            {
                throw new ArgumentException("Некорректные входные данные.");
            }
            return $"{symbol}{number}_{code}";
        }

        public List<string> GetWorker() // метод возвращает список сотрудников
        {
            return new List<string>(workers);
        }

        public void AddWorker(string fullname) //метод добавляет нового сотрудника в список сотрудников.
        {
            if (!string.IsNullOrWhiteSpace(fullname) && !workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}
