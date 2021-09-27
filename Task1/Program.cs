using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Создайте свой тип исключения.
            2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
               Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения(блок finally по желанию).
            3. В блоке catch выведите в консольном сообщении текст исключения.*/

            Exception[] exceptions = new Exception[5];
            exceptions[0] = new IndexOutOfRangeException();
            exceptions[1] = new TimeoutException();
            exceptions[2] = new DivideByZeroException();
            exceptions[3] = new ArgumentOutOfRangeException();
            exceptions[4] = new MyException("Мое исключение");

            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception ex) when (ex is IndexOutOfRangeException)
                {
                    Console.WriteLine("Произошло исключение!");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is TimeoutException)
                {
                    Console.WriteLine("Произошло исключение!");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is DivideByZeroException)
                {
                    Console.WriteLine("Произошло исключение!");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Произошло исключение!");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (ex is MyException)
                {
                    Console.WriteLine("Произошло исключение!");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //int number = i + 1;
                    Console.WriteLine($"Номер исключения: {i + 1}");
                }
            }

            Console.ReadKey();

        }
    }
}
