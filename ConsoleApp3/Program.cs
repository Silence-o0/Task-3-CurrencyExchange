
    class Converter
    {
        public decimal DollarCoef   { get; set; }
        public decimal EuroCoef   { get; set; }
        public Converter(decimal dollarCoef, decimal euroCoef)
        {
            this.DollarCoef = dollarCoef;
            this.EuroCoef = euroCoef;
        }
        public decimal ConvertCurrency(decimal coef)
        {
            Console.Write("Вкажiть суму, яку хочете конвертувати: ");
            decimal sum = this.EnterAndCheckCorrectness();
            return sum * coef;
        }
        public decimal EnterAndCheckCorrectness()
        {
            decimal money;
            while (true)
            {
                try
                {
                    money = Convert.ToDecimal(Console.ReadLine());
                    while (money <= 0)
                    {
                        Console.WriteLine("Значення не може бути вiд'ємним або дорiвнювати нулю.");
                        money = Convert.ToDecimal(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Недопустимий тип значення! Введiть ще раз.");
                    continue;
                }
                break;
            }
            return money;
        }
    }

   

    internal class Program
    {
        public static int EnterAndCheckTypeOfOperationNum ()
        {
            int num;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Недопустимий тип значення! Введiть ще раз.");
                    continue;
                }
                break;
            }
            return num;
        }
        private static void Main(string[] args)
        {
            Converter convertObj = new Converter( 0, 0 );

                Console.Write("Введiть курс долара по вiдношенню до гривнi: ");
                convertObj.DollarCoef = convertObj.EnterAndCheckCorrectness();

                Console.Write("Введiть курс євро по вiдношенню до гривнi: ");
                convertObj.EuroCoef = convertObj.EnterAndCheckCorrectness();

            while (true)
            {
                Console.WriteLine("Оберiть, з якими валютами ви хочете здiйснити операцiю, та введiть номер.");
                Console.WriteLine("1. Долар/гривня.");
                Console.WriteLine("2. Євро/гривня.");
                Console.WriteLine("3. Долар/євро.");
                Console.WriteLine("0. Завершити програму.");

                int currencyChooseNum = EnterAndCheckTypeOfOperationNum();

                int operationNum;

                switch (currencyChooseNum)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Вкажiть номер операцiї, яку хочете здiйснити.");
                            Console.WriteLine("1. Конвертувати гривню в долар.");
                            Console.WriteLine("2. Конвертувати долар в гривню.");
                            Console.WriteLine("0. Повернутися в головне меню.");

                            operationNum = EnterAndCheckTypeOfOperationNum();
                        }
                        while (operationNum < 0 || operationNum > 2);

                        if (operationNum == 1)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(1 / convertObj.DollarCoef), 2)} USD.");
                        }
                        else if (operationNum == 2)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(convertObj.DollarCoef), 2)} UAH.");
                        }
                        break;
                    case 2:
                        do 
                        {
                            Console.WriteLine("Вкажiть номер операцiї, яку хочете здiйснити.");
                            Console.WriteLine("1. Конвертувати гривню в євро.");
                            Console.WriteLine("2. Конвертувати євро у гривню.");
                            Console.WriteLine("0. Повернутися в головне меню.");

                            operationNum = EnterAndCheckTypeOfOperationNum();
                        }
                        while (operationNum < 0 || operationNum > 2);

                        if (operationNum == 1)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(1 / convertObj.EuroCoef), 2)} EUR.");
                        }
                        else if (operationNum == 2)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(convertObj.EuroCoef), 2)} UAH.");
                        }
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Вкажiть номер операцiї, яку хочете здiйснити.");
                            Console.WriteLine("1. Конвертувати долар в євро.");
                            Console.WriteLine("2. Конвертувати євро у долар.");
                            Console.WriteLine("0. Повернутися в головне меню.");

                            operationNum = EnterAndCheckTypeOfOperationNum();
                        }
                        while (operationNum < 0 || operationNum > 2);

                        if (operationNum == 1)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(convertObj.EuroCoef/ convertObj.DollarCoef), 2)} EUR.");
                        }
                        else if (operationNum == 2)
                        {
                            Console.WriteLine($"Результат: {Math.Round(convertObj.ConvertCurrency(convertObj.DollarCoef / convertObj.EuroCoef), 2)} USD.");
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Помилка! Введеної операцiї не iснує!");
                        break;
                }

            }
        }
    }