using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int userNumber;

            Console.Write("Введите любое слово: ");
            userMessage = Console.ReadLine();
            Console.Write("Введите кол-во повторов: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userNumber; i++)
            {
                Console.WriteLine("userMessage");
            }
        }
    }
}
