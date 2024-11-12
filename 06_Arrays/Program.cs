using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] number = new int[10];
            //number[0] = 50;
            //number[1] = 48;
            //number[2] = 698;
            //number[3] = 24;
            //number[7] = 748;

            //Console.WriteLine(number[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };

            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            //for(int i=0;i<number.Length;i++)
            //{
            //    if (number[i]%3==0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '/', '-' };

            //for(int i =0;i<symbols.Length;i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i=0;i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            #endregion

            #region Dizi Metotları
            //string[] persons = { "Ali", "Ahmet", "Onur", "Dilara", "Deniz","Buse" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 82, 10, 22, 35 };
            //Array.Sort(numbers);

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 82, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " - Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 65, 897 ,748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%2==1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
