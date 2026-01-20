using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Lesson._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// ekrana yazdırma işlemleri

			/*
			Console.Write("Hello World "); // write komutunda imleç aynı satırda kalır
			Console.WriteLine("Pelin"); // writeline komutunda imleç bir alt satıra iner
			Console.WriteLine("Hello World"); 
			Console.WriteLine("Pelin");
			
			*/

			// Değişkenler


			// Byte veri tipi
			/*

			byte birinci = 5;
			byte ikinci = 25;
			byte maxDeger= byte.MaxValue; // MaxValue sayesinde değişkenin alabileceği en yüksek değere bakabiliriz
			byte minDeger= byte.MinValue; // MinValue sayesinde değişkenin alabileceği en düşük değere bakabiliriz

			Console.WriteLine(birinci);
			Console.WriteLine(ikinci);
			Console.WriteLine(maxDeger);
			Console.WriteLine(minDeger);
			Console.WriteLine("Byte değşikeninin alabileceği değer aralığı: "+minDeger+" ile "+maxDeger+" arasındadır");
			// byte değeri 0 ile 255 sayıları arasında değer alabilir
			// Byte değişkeni bellekte 1 byte'lık alan kaplar
			*/

			// Short veri tipi 
			/*
			short minDeger = short.MinValue;
			short maxDeger = short.MaxValue;

			Console.WriteLine("Short değşikeninin alabileceği değer aralığı: " + minDeger + " ile " + maxDeger + " arasındadır");
			// Short değeri -32768 ile 32767 sayıları arasında değer alabilir
			// Short değişkeni bellekte 2 byte'lık alan kaplar
			*/

			// İnt veri tipi
			/*
			int minDeger = int.MinValue;
			int maxDeger= int.MaxValue;

			Console.WriteLine("İnt değşikeninin alabileceği değer aralığı: " + minDeger + " ile " + maxDeger + " arasındadır");
			// İnt değeri -2147483648 ile 2147483647 sayıları arasında değer alabilir
			// İnt değişkeni bellekte 4 byte'lık alan kaplar
			*/

			// Long veri tipi
			/*
			long minDeger = long.MinValue;
			long maxDeger = long.MaxValue;

			Console.WriteLine("Long değşikeninin alabileceği değer aralığı: " + minDeger + " ile " + maxDeger + " arasındadır");
			// Long değeri -9223372036854775808 ile 9223372036854775807 sayıları arasında değer alabilir 19 basamaklı sayılar
			// Long değişkeni bellekte 8 byte'lık alan kaplar
			*/

			// Float veri tipi
			/*
			float minDeger = float.MinValue;
			float maxDeger = float.MaxValue;

			Console.WriteLine("Float değşikeninin alabileceği değer aralığı: " + minDeger + " ile " + maxDeger + " arasındadır");
			// Float değeri -3.402823E+38 ile 3.402823E+38 sayıları arasında değer alabilir 7 basamaklı sayılar
			// Float değişkeni bellekte 4 byte'lık alan kaplar
			// float x=5.36 diye bir değer ataması yapamayız çünkü ondalık sayılarda atamada değişkeni double olarak atar ve bu şekilde kullanılmaz
			
			float x = 5.36f; // ondalık sayılarda float kullanmak için atadığımız deeğerin sonuna "f" konur

			Console.Write(x);
			*/

			// Double veri tipi
			/*
			double minDeger = double.MinValue;
			double maxDeger = double.MaxValue;

			Console.WriteLine("Double değşikeninin alabileceği değer aralığı: " + minDeger + " ile " + maxDeger + " arasındadır");
			// Double değeri -1.79769313486232E+308 ile 1.79769313486232E+308 sayıları arasında değer alabilir 15 basamaklı sayılar
			// Double değişkeni bellekte 8 byte'lık alan kaplar
			*/

			// Char veri tipi

			// Karakterleri tutmak için Char veri tipi kullanılır
			// Tek tırnak içerisinde tek değer olacak şekilde kullanılır
			/*
			 char karakter = 'E';
			char karakter2 = '?';

			Console.WriteLine(karakter);
			Console.WriteLine(karakter2);
			*/

			// String veri tipi
			/*
			string isim = "Pelin";
			string soyad = "Pınarbaşı";
			string x = "C# Dersine hoşgeldiniz";

			Console.WriteLine(isim);
			Console.WriteLine(soyad);
			Console.WriteLine(x);
			*/

			// Bool veri tipi
			/*
			bool sonuc = 10 > 5;
			bool sonuc2 = 4 > 7;
			Console.WriteLine(sonuc); // ekrana true değeri çıkar çünkü sonuc'a atadığımız değer doğru
			Console.WriteLine(sonuc2); // ekrana tfalse değeri çıkar çünkü sonuc2'a atadığımız değer yanlış
			*/

			// Object veri tipi
			/*
			object ad = "pelin";
			object x = 5;
			object y = 12.56;
			object z = 'Z';
			object sonuc = 3 < 7;

			Console.WriteLine(ad);
			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(z);
			Console.WriteLine(sonuc);

			// Object veri tipi ile her şeyi tanımlayabiliriz
			*/
			Console.ReadLine(); // ekranın biz kapatana kadar açık kalmasını sağlar
		}
	}
}
