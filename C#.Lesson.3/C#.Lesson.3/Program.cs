using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace C_.Lesson._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Kullanıcıdan değer alma
			/*
			Console.WriteLine("Lütfen adınızı giriniz");
			string isim= Console.ReadLine();

			Console.WriteLine("Lütfen soyadınızı giriniz");
			string soyad= Console.ReadLine();
			Console.WriteLine("ad: " + isim);
			Console.WriteLine("Soyad: "+soyad);
			*/

			// Tür dönüşümleri

			// Sayısal Veri tiplerinin kendi arasındaki dönüşümleri
			int a = 5;
			byte b = (byte)a;
			float g = (float)b;

			Console.WriteLine(g.GetType()); // GetType ile hangi değişkeni kullandığımız gösterir
			Console.WriteLine(b);

			// String'ten int'te dönüşümler !! KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDEDİR

				// Parse döşümleri
			string number = "1";
			string number2= "2";
			Console.WriteLine(number+number2); // burada değişkneler string ile tanımlandığı için 1 ile 2 yana yazılmıştır.
			int c= int.Parse(number);
			int d= int.Parse(number2);
			Console.WriteLine(c+d); // burada tür dönüşümü yaptıktan sonra topladığımız için toplama işlemi gerçekleşir

				// Toİnt dönüşümleri
			string number3 = "3";
			string number4 = "4";
			int e= Convert.ToInt32(number3);
			int f = Convert.ToInt32(number4);
			Console.WriteLine(f+e);

			// İnt'ten Stringe dönüştürme

			int h = 5;
			int ı = 10;
			string sayi= h.ToString();
			string sayi2= ı.ToString();
			Console.WriteLine(sayi+sayi2);  // int'ten string' çevirdiğimiz için ekrana 510 çıkar

			// double'dan int'e

			double say = 5.22;
			int k= Convert.ToInt32(say);
			Console.WriteLine(k); // değer normalde 5.22 ama int sadece tam sayıları tutar




			Console.Read();

		}
	}
}
