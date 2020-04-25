using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class Program
    {
        public static int arrSize = 0;
        public static Tours[] tur;
        static void Main(string[] args)
        {
            tur = new Tours[arrSize];
            Console.WriteLine("Длина массива: " + tur.Length);
            for (int i = 0; i < tur.Length; i++)
            {
                Console.WriteLine("Заполните элемент массива");
                tur[i] = new Tours();
                Console.WriteLine("Введите название поездки");
                string poezdka = Console.ReadLine();

                tur[i].Poezdka = poezdka;

                Console.WriteLine("Введите продолжительность поездки");
                string prodol = Console.ReadLine();


                tur[i].Prodol = prodol;

                Console.WriteLine("Введите цену");
                string price = Console.ReadLine();


                tur[i].Price = price;
            }
            Console.WriteLine("Массив");
            foreach (Tours b in tur)
            {
                Console.WriteLine(b.Poezdka);
                Console.WriteLine(b.Prodol);
                Console.WriteLine(b.Price);
                Console.WriteLine();
            }

        }

        
}
