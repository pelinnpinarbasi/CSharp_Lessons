using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Lesson._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Toplama-Çıkarma Operatörleri
			/*
			int number1 = 6;
			int number2 = 12;
			int top = number1 + number2;
			int cik= number1 - number2;

			Console.WriteLine("toplam: " + top);
			Console.WriteLine("çıkarma: "+ cik);
			*/


			// Çarpma-Bölme Operatörleri
			/*
			int number1 = 60;
			int number2 = 15;
			int carp= number1 * number2;
			int böl= number1 / number2;

			Console.WriteLine("Çarpma: " + carp);
			Console.WriteLine("Bölme: " + böl);
			*/

			// Mod alma operatörü
			/*
			int number1 = 10;
			int number2 = 3;
			Console.WriteLine(number1%number2);
			*/

			// Artırma-Azaltma Operatörleri
			/*
			int number = 20;
			int number2 = 17;
			number++;
			number2--;
			Console.WriteLine(number);
			Console.WriteLine(number2);
			*/

			// Atama Operatörü "="
			/*
			int age = 21;
			*/

			// Eşittir Operatörü "=="
			/*
			int number1 = 4;
			int number2 = 4;

			bool Control= number1==number2;
			Console.WriteLine(Control);
			*/

			// Eşit Değil Operatörü " != "
			/*
			int number1 = 4;
			int number2 = 3;

			bool Control = number1 != number2;
			Console.WriteLine(Control);
			*/

			// Büyüktür, Büyük Eşit, Küçüktür, Küçük Eşit Operatörleri
			/*
			int age = 19;
			int age2 = 18;
			int age3 = 17;
			bool Control = age >= 18;
			bool control2= age2 >= 18;
			bool control3= age3 >= 18;
			Console.WriteLine(Control);
			Console.WriteLine(control2);
			Console.WriteLine(control3);
			*/

			// Ve Operatörü: &&
			/*
			int number1 = 5;
			int number2 = 5;
			int number3 = 10;

			bool control= number1==number2 && number1<=number3; // bu doğru çünkü iki ifadede doğru
			bool control2= number1==number2 && number1==number3; // bu yanlış çünkü ilk ifade doğru ama ikici yanlış

			Console.WriteLine(control);
			Console.WriteLine(control2);
			*/

			// Veya Operatörü: ||
			/*
			int number1 = 5;
			int number2 = 5;
			int number3 = 10;

			bool control = number1 == number2 || number1 <= number3; // bu doğru çünkü iki ifadede doğru
			bool control2 = number1 == number2 || number1 == number3; // bu doğru çünkü ifadelerden birisinin doğru olması yeterli
			bool control3= number1>number2 || number1 == number3; // bu yanlış çünkü tüm ihtimaller yanlış

			Console.WriteLine(control);
			Console.WriteLine(control2);
			Console.WriteLine(control3);
			*/

			// Değil Operatörü: !
			/*
			bool a=true;
			Console.WriteLine(!a); // normalde a değişkeni true'ken değildir operatörü ile onu false çevirdik ve çıktı false oldu
			*/

			// Ek Operatörler: +=, -=, /=, *=

			int a = 5;
			a += 4; // Bunun anlamı a=a+4 yani ilk önce a ile 4 topluyoruz sonra a'ya atıyoruz. Diğer operatöerlerde aynı işe yarıyor
			Console.WriteLine("a'nın değeri: "+a);




			Console.ReadLine();


		}
	}
}
