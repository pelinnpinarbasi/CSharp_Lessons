
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Lesson._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// İf ve Else Karar Yapıları

			/* 
			 if(şart)
			{
			Şart sağlanıyorsa burada bulunan işlem gerçekleşir
			}
			else
			{
			Şart sağlanmıyorsa buradaki işlem gerçekleşir
			}
			 */

			// Öğrencinin notu 50'den büyükse başarılı değilse başarısız yazdıran programı kodlayınız
			/*
			int mark = 75;

			if (mark > 50)
			{
				Console.WriteLine("Öğrenci bu dersten başarılı bir şekilde geçmiştir");
			}
			else
			{
				Console.WriteLine("Dersten başarısız oldunuz");
			}

			Console.Read();
			*/

			/*
			if (şart1)
			{
				Şart sağlanıyorsa burada bulunan işlem gerçekleşir
			}

			else if (şart2)
			{
				Şart sağlanıyorsa burada bulunan işlem gerçekleşir
			}

			else
			{
				Hiçbir şart sağlanmıyorsa buradaki işlem gerçekleşir
			}
			*/

			/* Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalamsı
				- Eğer 80-100 arasındaysa A+
				- 60-80 arasındaysa A
				- 40-60 arasındaysa B+
				_ 40'dan küçükse F yazdıran kodu yazınız
			*/

			//Console.WriteLine("1. sınav notunuzu giriniz");
			//int exam1= Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("2. sınav notunuzu giriniz");
			//int exam2= Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("3. sınav notunuzu giriniz");
			//int exam3= Convert.ToInt32(Console.ReadLine());

			//int examTotal= (exam1 + exam2 + exam3)/3;

			//if(80<examTotal && examTotal<=100)
			//{
			//	Console.WriteLine("A+ aldınız");
			//}

			//else if (60 < examTotal && examTotal <= 80)
			//{
			//	Console.WriteLine("A aldınız");
			//}

			//else if (40 < examTotal && examTotal <= 60)
			//{
			//	Console.WriteLine("B+ aldınız");
			//}

			//else 
			//{
			//	Console.WriteLine("F aldınız");
			//}
			//Console.Read();

			//MİNİ ATM UYGULAMASI
			///*
			//	1- Bakiye görüntüleme
			//	2- Para çekme	
			//	3- Para yatırma 	
			//	4- q'ya basarsa çıkış yaptıracğız
			// */
			//int balance = 1000;
			//Console.WriteLine("Atm'ye Hoşgeldiniz");
			//Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
			//Console.WriteLine("Bakiye görüntülemek için 1'e basınız");
			//Console.WriteLine("Para çekmek için 2'ye basınız");
			//Console.WriteLine("Para yatırmak için 3'e basınız");
			//Console.WriteLine("Çıkış yapmak için q'e basınız");
			//string choice = Console.ReadLine();

			//if (choice == "1")
			//{
			//	Console.WriteLine("Bakiyeniz: " + balance);
			//}

			//else if (choice == "2")
			//{
			//	Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
			//	int money = Convert.ToInt32(Console.ReadLine());

			//	if (money <= balance)
			//	{
			//		balance = balance - money;
			//		Console.WriteLine("Kalan bakiyeniz: " + balance);
			//	}

			//	else
			//	{
			//		Console.WriteLine("Bakiyeniz yetersiz");
			//	}
			//}

			//else if (choice == "3")
			//{
			//	Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
			//	int money2 = Convert.ToInt32(Console.ReadLine());
			//	balance = balance + money2;
			//	Console.WriteLine("Yeni bakiyeniz: " + balance);
			//}

			//else if (choice == "q")
			//{
			//	Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz. İyi günler dileriz");
			//}

			//else
			//{
			//	Console.WriteLine("Lütfen geçerli bir işlem giriniz");
			//}

			//Console.Read();


			// BEDEN KİTLE İNDEKSİ
			/*
				- Beden kitle indeksi= Kilo/boy*boy
				- Beden kitle indeksi;
				- 18'e eşit veya düşükse ZAYIF
				- 18 ile 25 arsında ise NORMAL
				- 25'ten büyükse OBEZ yazdıran programı kodlayınız
			 */

			Console.WriteLine("Boyunuzu giriniz (Metre cinsinden): ");
			double height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Kilonuzu giriniz: ");
			double weight = Convert.ToDouble(Console.ReadLine());

			double bodyMassİndex= weight/(height*height);

			if (bodyMassİndex <= 18)
			{
				Console.WriteLine("Beden kitle indeksiniz: " + bodyMassİndex + " Zayıf");

			}

			else if (18<bodyMassİndex && bodyMassİndex<=25 )
			{
				Console.WriteLine("Beden kitle indeksiniz: " + bodyMassİndex + " Normal");

			}

			else if (bodyMassİndex>25)
			{
				Console.WriteLine("Beden kitle indeksiniz: " + bodyMassİndex + " Obez");

			}
		}

	}
}
