using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Сотрудник
    {
        private string Фамилия;
        private string Имя;
        private string? Отчество;
        private DateTime Дата_Рождения;
        private string? Должность;
        private string? Телефон;
        // public static string[] Список_Должностей = new string[] { "Директор", "Лох", "Пидр"};
        private string? Гендер;
        private DateTime Момент_приема_на_работу;

        public Сотрудник(string Фамилия, string Имя, string Гендер, string Дата_Рождения, string Должность1, string Момент_приема_на_работу)
        {
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Гендер = Гендер;

            try
            {
                this.Дата_Рождения = DateTime.Parse(Дата_Рождения);
            }
            catch
            {
                this.Дата_Рождения = new DateTime(0001, 1, 1);
            }

            this.Должность = Должность;

            try
            {
                this.Момент_приема_на_работу = DateTime.Parse(Момент_приема_на_работу);
            }
            catch
            {
                this.Момент_приема_на_работу = new DateTime();
            }

            Отчество = null;
            Телефон = null;
        }
        //public Сотрудник(string Фамилия, string Имя, string Отчество, string Дата_Рождения, string Должность) //, string Телефон)
        //{
        //    this.Фамилия = Фамилия;
        //    this.Имя = Имя;
        //    this.Отчество = Отчество;


        //    if (Список_Должностей.ToList().IndexOf(Должность) == -1)
        //    {
        //        this.Должность = null;
        //    }
        //    else
        //        this.Должность = Должность;

        //    // this.Телефон = Телефон;

        //    try
        //    {
        //        this.Дата_Рождения = DateTime.Parse(Дата_Рождения);
        //    }
        //    catch
        //    {
        //        this.Дата_Рождения = new DateTime(0001, 1, 1);
        //    }
        //}

        public string Print()
        {
            string Output = $"Фамилия: {Фамилия}\nИмя: {Имя}\n";
            if (Отчество != null)
                Output += $"Отчество: {Отчество}\n";
            if (Гендер != null)
                Output += $"Гендер: {Гендер}\n";

            if (Дата_Рождения.Year != 0001)
            {
                Output += "Дата Рождения: ";
                Output += Дата_Рождения.ToShortDateString() + "\n";
            }
            if (Должность != null)
                Output += $"Должность: {Должность}\n";
            if (Момент_приема_на_работу.Year != 0001)
            {
                Output += "Момент приема на работу: ";
                Output += Момент_приема_на_работу.ToShortDateString();
            }
            if (Должность != null)
                Output += $"Должность: {Должность}\n";
            if (Телефон != null)
                Output += $"Телефон: {Телефон}\n";

            return Output + "\n";
        }
        public int GetAge()
        {
            if (Дата_Рождения.Year == 0001)
                return 0;
            int Age = DateTime.Now.Year - Дата_Рождения.Year;
            if (DateTime.Now.Month < Дата_Рождения.Month || DateTime.Now.Month == Дата_Рождения.Month && DateTime.Now.Day < Дата_Рождения.Day) 
            Age--;
            return Age;
        }

        public string Getpositionatwork()
        {
            return Должность;
        }
        public string GetFullName()
        {
            return $"{Фамилия} {Имя} {Отчество}";
        }
        public void SetФамилия(string Value) { Фамилия = Value; }
        public void SetИмя(string Value) { Имя = Value; }
        public void SetОтчество(string Value) { Отчество = Value; }
        public void SetДата_Рождения(string Value) { Дата_Рождения = DateTime.Parse(Value); }
        //public void SetДолжность(string Value) {
        //    if (Список_Должностей.ToList().IndexOf(Value) == -1)
        //    {
        //        this.Должность = null;
        //    }
        //    else
        //        this.Должность = Должность;
        //}
        public void SetТелефон(string Value) { Телефон = Value; }
    }
}
