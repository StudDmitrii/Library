using System.Data;
using System.Text.RegularExpressions;

namespace Library
{
    internal class Functions
    {
        public static void OpenNewWin2(object sender, int width, WinEnum source)
        {
            main_form MainForm = new main_form(width, sender.ToString(), source, false);
            MainForm.Show();
            MainForm.Width = width;
        }
        public static List<string[]>? OpenNewWin(object sender, WinEnum? source = null, bool fromAddForm = false, Form? owner = null)
        {
            main_form MainForm = new main_form(sender.ToString(), source, fromAddForm);
            if (fromAddForm == true)
            {
                MainForm.Owner = owner;
                if (MainForm.ShowDialog() == DialogResult.OK)
                {
                    return MainForm.returnRows;
                }
                return null;
            }
            else
            {
                MainForm.Show();
                return null;
            }
        }

        public static string? CheckNewAuthor(string name1, string name2, string name3)
        {
            if (name1 == "") return "Введите имя"; //error
            //name1 = PrepareName(name1);
            if (!Regex.IsMatch(name1, @"^[A-ЯЁ][а-яё]+$")) return "Имя: минимум 2 русские буквы (без пробелов)"; //error

            if (name2 == "") return "Введите фамилию"; //error
            //name2 = PrepareName(name2);
            if (!Regex.IsMatch(name2, @"^[A-ЯЁ][а-яё]+$")) return "Фамилия: минимум 2 русских буквы (без пробелов)"; //error

            if (name3 != "")
            {
                //name3 = PrepareName(name3);
                if (!Regex.IsMatch(name3, @"^[A-ЯЁ][а-яё]{0,}$")) return "Отчество: минимум 2 русских буквы (без пробелов)"; //error
            }

            return null;
        }

        public static string PrepareName(string name)
        {
            if (name == "") return "";
            name = name.Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return name;
        }

        public static string? CheckNewPublisher(string name, string address)
        {
            if (name == "") return "Введите наименование"; //error
            //if (!Regex.IsMatch(name, @"^[A-ЯЁ][а-яё]+$")) return "Имя: минимум 2 русские буквы (без пробелов)"; //error

            if (address == "") return "Введите адрес"; //error
            //if (!Regex.IsMatch(address, @"^[A-ЯЁ][а-яё]+$")) return "Фамилия: минимум 2 русских буквы (без пробелов)"; //error

            return null;
        }

        public static string? CheckNewGenre(string name)
        {
            if (name == "") return "Введите наименование"; //error
            if (!Regex.IsMatch(name, @"^.{2,}$")) return "Наименование: минимум 2 символа"; //error

            return null;
        }

        public static string? CheckNewPosition(string name)
        {
            if (name == "") return "Введите наименование"; //error
            if (!Regex.IsMatch(name, @"^.{2,}$")) return "Наименование: минимум 2 символа"; //error

            return null;
        }

        public static string? CheckNewBook(string name, int rows1, int rows2, int publisher, DateTime date)
        {
            if (name == "") return "Введите название книги"; //error
            if (rows1 == 0) return "Заполните авторов"; //error
            if (rows2 == 0) return "Заполните жанры"; //error
            if (rows2 == 0) return "Заполните жанры"; //error
            if (publisher == -1) return "Выберите издательство"; //error
            if (date > DateTime.Now.Date) return "Проверьте даты"; //error

            return null;
        }

        public static string? CheckNewUser(string name1, string name2, string name3, string contact)
        {
            if (name1 == "") return "Введите имя"; //error
            //name1 = PrepareName(name1);
            if (!Regex.IsMatch(name1, @"^[A-ЯЁ][а-яё]+$")) return "Имя: минимум 2 русские буквы (без пробелов)"; //error

            if (name2 == "") return "Введите фамилию"; //error
            //name2 = PrepareName(name2);
            if (!Regex.IsMatch(name2, @"^[A-ЯЁ][а-яё]+$")) return "Фамилия: минимум 2 русских буквы (без пробелов)"; //error

            if (name3 != "")
            {
                //name3 = PrepareName(name3);
                if (!Regex.IsMatch(name3, @"^[A-ЯЁ][а-яё]{0,}$")) return "Отчество: минимум 2 русских буквы (без пробелов)"; //error
            }

            if (contact == "") return "Добавитье контактные данные для пользователя"; //error

            return null;
        }

        public static string? CheckNewLibrarian(string name1, string name2, string name3, int position)
        {
            if (name1 == "") return "Введите имя"; //error
            //name1 = PrepareName(name1);
            if (!Regex.IsMatch(name1, @"^[A-ЯЁ][а-яё]+$")) return "Имя: минимум 2 русские буквы (без пробелов)"; //error

            if (name2 == "") return "Введите фамилию"; //error
            //name2 = PrepareName(name2);
            if (!Regex.IsMatch(name2, @"^[A-ЯЁ][а-яё]+$")) return "Фамилия: минимум 2 русских буквы (без пробелов)"; //error

            if (name3 != "")
            {
                //name3 = PrepareName(name3);
                if (!Regex.IsMatch(name3, @"^[A-ЯЁ][а-яё]{0,}$")) return "Отчество: минимум 2 русских буквы (без пробелов)"; //error
            }

            if (position == -1) return "Выберите должность"; //error

            return null;
        }

        public static string? CheckNewEntry(int user, int book, DateTime takeDate, DateTime planReturnDate, DateTime factReturnDate, int worker)
        {
            if (user == -1) return "Выберите читательский билет";
            if (book == -1) return "Выберите книгу";
            if (worker == -1) return "Выберите ответственного";
            if (takeDate > DateTime.Now.Date) return "Проверьте дату выдачи";
            if (planReturnDate < takeDate || factReturnDate < takeDate) return "Проверьте даты. Дата возврата должна быть больше или равно даты выдачи";
            if (factReturnDate < DateTime.Now.Date) return "Вы можете подтвердить возврат заранее";
            return null;
        }
    }
}
