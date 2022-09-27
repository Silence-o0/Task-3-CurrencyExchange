class Converter
{
    public decimal dollarCoef;
    public decimal euroCoef;
    public Converter(decimal dollarCoef, decimal euroCoef)
    {
        this.dollarCoef = dollarCoef;
        this.euroCoef = euroCoef;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введiть курс долара по вiдношенню до гривнi: ");
        decimal dollarToHryvnia = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введiть курс євро по вiдношенню до гривнi: ");
        decimal euroToHryvnia = Convert.ToDecimal(Console.ReadLine());
        Converter cvrt = new Converter(dollarToHryvnia, euroToHryvnia);

        while (true)
        {
            Console.WriteLine("Оберiть операцiю, яку хочете здiйснити та введiть її номер:");
            Console.WriteLine("1. Конвертувати гривню в долар.");
            Console.WriteLine("2. Конвертувати гривню в євро.");
            Console.WriteLine("3. Конвертувати долар у гривню.");
            Console.WriteLine("4. Конвертувати євро у гривню.");
            Console.WriteLine("0. Завершити програму.");
            int operationNum = Convert.ToInt32(Console.ReadLine());

            decimal sumToConvert = 0;
            if (operationNum != 0)
            {
                Console.Write("Введiть суму, яку хочете конвертувати: ");
                sumToConvert = Convert.ToDecimal(Console.ReadLine());
            }
            switch (operationNum) {
                case 1:            
                Console.WriteLine($"Результат: {Math.Round(sumToConvert / cvrt.dollarCoef, 2)} доларiв.");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {Math.Round(sumToConvert / cvrt.euroCoef, 2)} євро.");                 
                    break;
                case 3:
                    Console.WriteLine($"Результат: {Math.Round(sumToConvert * cvrt.dollarCoef, 2)} гривень.");
                    break;
                case 4:
                    Console.WriteLine($"Результат: {Math.Round(sumToConvert * cvrt.euroCoef, 2)} гривень.");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:  
                    Console.WriteLine("ERROR");
                    break;
            }
        
        }
    }
}