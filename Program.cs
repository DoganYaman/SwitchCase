using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;

            //Expression
            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız!");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi!");
                    break;
            }
        
        switch (mounth)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış ayındasınız!");
                return;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar ayındasınız!");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz ayındasınız!");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar ayındasınız!");
                return;
        }
        }
    }
}
