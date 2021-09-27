using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек. 
            Сортировка должна происходить при помощи события. Сортировка происходит при введении пользователем либо числа 1(сортировка А - Я), 
            либо числа 2(сортировка Я - А).
            Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с использованием собственного типа исключения.*/

            List<string> names = new List<string>();
            names.Add("Иванов");
            names.Add("Петров");
            names.Add("Сидоров");
            names.Add("Абалаков");
            names.Add("Яйценюх");

            NumberReader numberReader = new NumberReader(names);
            numberReader.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено не корректное значение");
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        static void ShowNumber(int number, List<string> names)
        {
            switch (number)
            {
                case 1: names.Sort(); break;
                case 2: names.Sort(); names.Reverse(); break;
            }

            Console.WriteLine("-----------------------------------------");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}