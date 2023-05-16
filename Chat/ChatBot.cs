/// разработчик: Самаев Антон ИВТ-21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Chat
{
    // абстрактный класс чатбота
    /*
    public abstract class AbstractChatBot
    {
        // абстрактный метод для ответа
        public abstract string answer(string s);
    }*/



    // класс чатбот(наследник от абстрактного класса)
    public class ChatBotCS : AbstractChatBot
    {
        // имя пользователя
        private string username;

        //todo: hist
        //List<string> hist = new List<string>();
        string hist;

        // сетер для имени пользователя
        public void username_set(string user)
        {
            username = user;
        }

        // гетер для имени пользователя
        public string username_get()
        {
            return username;
        }

        public override string answer(string s)
        {
            // перевод всех символов в нижний регистр
            s = s.ToLower();
            // удаление всех пробелов в начале и конце
            s = s.Trim();

            /// ответ на приветствие
            // прив(\w *) обозначает, найти все слова, которые имеют корень "прив"
            Regex hello = new Regex(@"прив(\w*)");
            MatchCollection matchesH = hello.Matches(s);
            // если есть совпадения, написать ответ
            if (matchesH.Count > 0)
            {
                return "Привет";                               
            }

            /// показ времени
            // врем(\w *) обозначает, найти все слова, которые имеют корень "врем"
            Regex time = new Regex(@"врем(\w*)");
            MatchCollection matchesT = time.Matches(s);
            if (matchesT.Count > 0)
            {
                return ChatBotTime();
            }

            /// показ даты
            // дат(\w *) обозначает, найти все слова, которые имеют корень "дат"
            Regex date = new Regex(@"дат(\w*)");
            MatchCollection matchesD = date.Matches(s);
            if (matchesD.Count > 0)
            {
                return ChatBotDate();
            }

            /// суммирование чисел
            // прибавь(\w *) обозначает, найти все слова, которые имеют корень "прибавь"
            Regex Sum = new Regex(@"прибавь(\w*)");
            MatchCollection matchesSum = Sum.Matches(s);
            if (matchesSum.Count > 0)
            {
                return Convert.ToString(ChatBotSum(s));
            }

            /// умножение чисел
            // умножь(\w *) обозначает, найти все слова, которые имеют корень "умножь"
            Regex Mult = new Regex(@"умножь(\w*)");
            MatchCollection matchesMult = Mult.Matches(s);
            if (matchesMult.Count > 0)
            {
                return Convert.ToString(ChatBotMult(s));
            }

            /// разность чисел
            // разность(\w *) обозначает, найти все слова, которые имеют корень "разность"
            Regex Diff = new Regex(@"разность(\w*)");
            MatchCollection matchesDiff = Diff.Matches(s);
            if (matchesDiff.Count > 0)
            {
                return Convert.ToString(ChatBotDiff(s));
            }

            /// деление чисел
            // раздели(\w *) обозначает, найти все слова, которые имеют корень "раздели"
            Regex Division = new Regex(@"раздели(\w*)");
            MatchCollection matchesDivision = Division.Matches(s);
            if (matchesDivision.Count > 0)
            {
                return Convert.ToString(ChatBotDivision(s));
            }

            // если не найдено совпадений, отвечает это
            else
            {
                return "Не знаю, что ответить";
            }
        }

        /// вывод времени
        public string ChatBotTime()
        {
            return DateTime.Now.ToString("T");
        }

        /// вывод даты
        private string ChatBotDate()
        {
            return DateTime.Now.ToString("D");
        }

        /// сумма двух параметров
        private float ChatBotSum(string s)
        {
            // split делит строку на массив; каждое отдельное слово это элемент массива(различает слова благодаря пробелам между ними)
            string[] s_arr = s.Split();
            float x1 = float.Parse(s_arr[1]);
            float x2 = float.Parse(s_arr[3]);
            return x1 + x2;
        }

        /// умножение двух параметров
        private float ChatBotMult(string s)
        {
            string[] s_arr = s.Split();
            float x1 = float.Parse(s_arr[1]);
            float x2 = float.Parse(s_arr[3]);
            return x1 * x2;
        }

        /// разница двух параметров
        private float ChatBotDiff(string s)
        {
            string[] s_arr = s.Split();
            float x1 = float.Parse(s_arr[1]);
            float x2 = float.Parse(s_arr[3]);
            return x1 - x2;
        }

        /// деление двух параметров
        private float ChatBotDivision(string s)
        {
            string[] s_arr = s.Split();
            float x1 = float.Parse(s_arr[1]);
            float x2 = float.Parse(s_arr[3]);
            return x1 / x2;
        }

        /// сохранение истории
        public void SaveToHist(string text)
        {
            this.hist = text;
        }

        /// гетер для истории
        public string get_hist()
        {
            return this.hist;
        }

        /// сохранение истории в файл
        public void SaveToFile(string path, string hist)
        {
            path = @"MyFile";
            // сохранение истории
            File.AppendAllText(path, hist);
        }
    }
}
