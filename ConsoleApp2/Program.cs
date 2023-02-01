
using ConsoleApp2;

List<Сотрудник> Сотрудники = new List<Сотрудник>();

while (true)
{
    bool Sort_positionatwork = false;
    int []SortType = null;
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить сотрудника(Простой вариант)");
    Console.WriteLine("2. Добавить сотрудника(Подробный вариант)");
    Console.WriteLine("3. Вывести всех сотрудников");
    Console.WriteLine("4. Подсчитать возраст каждого из них");
    Console.WriteLine("5. Отсортировать по должностям");
    Console.Write("\nВыбор: ");

   string inputString = Console.ReadLine();
    try
    {
        string Выбор = inputString;

        switch (Выбор)
        {
            case "1":
                {
                    Console.Write("Введите фамилию: ");
                    string familia = Console.ReadLine();

                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите дату рождения (YYYY.MM.DD): ");
                    string age = Console.ReadLine();

                    Сотрудник Новичек = new Сотрудник(familia, name, null, age, null, null);
                    Сотрудники.Add(Новичек);
                    Sort_positionatwork = false;
                    break;
                }
            case "2":
                {
                    Console.Write("Введите фамилию: ");
                    string familia = Console.ReadLine();

                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите Ваш Гендер: ");
                    string sex = Console.ReadLine();

                    Console.Write("Введите дату рождения (YYYY.MM.DD): ");
                    string age = Console.ReadLine();

                    Console.Write("Введите Вашу должность:  ");
                    string positionatwork = Console.ReadLine();

                    Console.Write("Введите дату устройства на работу (YYYY.MM.DD): ");
                    string timeofworking = Console.ReadLine();

                    Сотрудник Новичек = new Сотрудник(familia, name, sex, age, positionatwork, timeofworking);
                    Сотрудники.Add(Новичек);
                    Sort_positionatwork = false;
                    break;
                }
            case "3":
                {
                    if (Сотрудники.Count == 0)
                        Console.WriteLine("В базе нет сотрудников.");
                    else
                    {
                        if (SortType == null)
                            for (int i = 0; i < Сотрудники.Count; i++)
                                Console.WriteLine(Сотрудники[i].Print());
                       else
                        for (int i = 0; i < SortType.Length; i++)
                            Console.WriteLine(Сотрудники[SortType[i]].Print());
                    }
                    break;
                }
            case "4":
                {
                    if (Сотрудники.Count == 0)
                        Console.WriteLine("В базе нет сотрудников.");
                    else
                    {
                        for (int i = 0; i < Сотрудники.Count; i++)
                        {
                            if (Сотрудники[i].GetAge() != 0)
                            Console.WriteLine($"{Сотрудники[i].GetFullName()}: {Сотрудники[i].GetAge()}"); 
                            else Console.WriteLine($"{Сотрудники[i].GetFullName()}: Возраст не указан."); 
                        }
                            
                    }
                    break;
                }
            //case "5":
            //    {
            //        if (Сотрудники.Count == 0)
            //            Console.WriteLine("В базе нет сотрудников.");
            //        else
            //        {
            //            SortType = new int[Сотрудники.Count];
            //            for (int temp = 0; temp < Сотрудники.Count * 100; temp++)
            //            {
            //                for (int j = 0; j < Сотрудники.Count - 1; j++)
            //                {
            //                    string x = Сотрудники[j].Getpositionatwork();
            //                    string y = Сотрудники[j+1].Getpositionatwork();
            //                    if (x.Equals(y))
            //                    {
                                    
            //                    }
            //                }
            //            }
            //        }
            //        break;
            //    }
            default:
                {
                    Console.WriteLine("Такой вариант не предусмотрен.");
                    break;
                }
        }
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadLine();
    }
    finally
    {
        Console.Clear();
    }
}