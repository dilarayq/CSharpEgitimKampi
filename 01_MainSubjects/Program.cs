using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string name;
            //name = "Dilara";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 90";
            //customerEmail = "test@gmail.com";
            //district = "Üsküdar";
            //city = "İstanbul";
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            #endregion

            #region Int Değişkenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 12;
            int friesPrice = 65;
            int pizzaPrice = 250;
            int lemonadePrice = 35;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 2;
            cokeCount = 2;
            waterCount = 0;
            friesCount = 3;
            pizzaCount = 1;
            lemonadeCount = 1;

            totalPrice = (hamburgerPrice * hamburgerCount) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Hamburger Fiyatı: " + (hamburgerCount*hamburgerPrice) + " TL");
            Console.WriteLine("Kola Fiyatı: " + (cokeCount*cokePrice) + " TL");
            Console.WriteLine("Su Fiyatı: " + (waterCount*waterPrice) + " TL");
            Console.WriteLine("Kızartma Fiyatı: " + (friesCount*friesPrice) + " TL");
            Console.WriteLine("Pizza Fiyatı: " + pizzaCount*pizzaPrice + " TL");
            Console.WriteLine("Limonata Fiyatı: " + (lemonadeCount*lemonadePrice) + " TL");

            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion
            Console.Read();
        }
    }
}
