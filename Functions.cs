﻿using System.Data;
using System.Text.RegularExpressions;

namespace Library
{
    internal class Functions
    {
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
    }
}
