using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Lesson._5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//// Switch Case			
			///*
			// switch(değer1)
			//{
			//case(değer2):
			//yapılacak işlemler
			//break; // case boluna sağlayan değer2lerle işi bittikten sonra case bloğunun çalışmasını durdurur

			//case(değer3):
			//yapılacak işlemler
			//break;

			//default; // hiçbir case bloğuna girmezse default bloğuna girer
			//yapılacak işlemler
			//breakk
			//}
			// */

			////MİNİ ATM UYGULAMASI 2
			///*
			//	1- Bakiye görüntüleme
			//	2- Para çekme	
			//	3- Para yatırma 	
			//	4- q'ya basarsa çıkış yaptıracğız
			// */
			//int balance = 700;

			//Console.WriteLine("ATM'ye Hoşgeldiniz");
			//Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
			//Console.WriteLine("Bakiye görüntülemek için 1'e basınız");
			//Console.WriteLine("Para çekmek için 2'ye basınız");
			//Console.WriteLine("Para yatırmak için 3'e basınız");
			//Console.WriteLine("Çıkış yapmak için q'e basınız");
			//string choice = Console.ReadLine();
			//switch (choice)
			//{
			//	case "1":
			//		Console.WriteLine("Bakiyeniz: "+balance);
			//		break;

			//	case "2":
			//		Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
			//		int money =Convert.ToInt32(Console.ReadLine());
			//		if (money <= balance)
			//		{
			//			balance = balance - money;
			//			Console.WriteLine("Yeni bakiyeniz: " + balance);
			//		}
			//		else
			//		{
			//			Console.WriteLine("Bakiyeniz yetersiz");
			//		}
			//		break;

			//	case "3":
			//		Console.WriteLine("Yatırmak istediğiniz tutarı giriniz :");
			//		int money2=Convert.ToInt32(Console.ReadLine());
			//		balance = balance + money2;
			//		Console.WriteLine("Yeni bakiyeniz: " + balance);
			//		break;

			//	case "q":
			//		Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz");
			//		break;

			//	default:
			//		Console.WriteLine("Lütfen geçerli bir işlem giriniz");
			//		break ;
			//}

			// DÖNGÜLER
			// FOR DÖGÜSÜ
			/*
			 for(int degisken_adi= baslangic_deger; kosul; arttırma_azaltma)
			{
			çalışacak kodlar
			}
			 */



		}
	}
}
