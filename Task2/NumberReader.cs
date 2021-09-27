using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class NumberReader
    {
        public List<string> names;
        public NumberReader(List<string> names) { this.names = names; }

        public delegate void NumberEnteredDelegate(int number, List<string> names);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение 1 для сортировки от А-Я, либо значение 2 для сортировки от Я-А");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new MyException("Введенное значение не соответствует запросу");

            NumberEntered(number, names);
        }
        protected virtual void NumberEntered(int number, List<string> names)
        {
            NumberEnteredEvent?.Invoke(number, names);
        }
    }
}
