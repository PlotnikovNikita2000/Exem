using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tour
{
    class Program
    {
        public static int arrSize = 0;
        public static Tours[] tur;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленный размер массива");
            string read = Console.ReadLine();
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

            Order();

            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                foreach (Tours pp in tur)
                {
                    sw.WriteLine(pp.Poezdka + "; " + pp.Prodol + "; " + pp.Price);
                }
                sw.Close();
            }

        }

         static void Order()
        {
            tur = tur.OrderByDescending(a => a.prodol).ThenByDescending(a => a.price).ToArray();
        }


    }

        
}
