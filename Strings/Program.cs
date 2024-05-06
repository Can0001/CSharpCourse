using System;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");// bitiyorsa true bitmiyorsa false değeri alırız.
            bool result4 = sentence.StartsWith("My name");// başlıyorsa true başlamıyorsa false değeri alırız.

            var result5 = sentence.IndexOf("name");//name kaçıncı karakterden başlar. Bulamadığında -1 değerini verir.
            var result6 = sentence.IndexOf(" ");// Bulduğu ilk boşluğu sayar ve devam etmez.
            var result7 = sentence.LastIndexOf(" ");//Aramaya sondan başlar.
            var result8 = sentence.Insert(0,"Hello, ");
            var result9 = sentence.Substring(3);//3.karakterden itibaren ekran çıktısı verdi.
            var result10 = sentence.ToLower();//Bütün karakterleri küçük harfe çevirir.
            var result11 = sentence.ToUpper();//Bütün karakterleri büyük harfe çevirir.
            var result12 = sentence.Replace(" ","-");//Boşluk yerine - işaretini koydu.
            var result13 = sentence.Remove(2,5);//Belli bir indexten sonrasını atmak için kullanılır. Virgülden sonraki ise kaç tane silinmesi gerek olduğunu yazarız.


            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
