namespace ConsoleApp83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int maximumNumber = 101;
            int number2 = 2;
            int degreeNumber2 = 0;
            int degreeResult = number2;

            number = random.Next(maximumNumber);

            for (int i = number2; i <= number; i *= number2)
            {
                degreeNumber2++;
                degreeResult *= number2;
            }

            Console.WriteLine("Ваше число - " + number + ". Степень - " + degreeNumber2 + ". Результат найденной степени - " + degreeResult + ".");
        }
    }
}