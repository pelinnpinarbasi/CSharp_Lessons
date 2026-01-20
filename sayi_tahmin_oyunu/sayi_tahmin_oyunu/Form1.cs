using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmin_oyunu
{
   
	public partial class Form1 : Form
	{
		private int tutulanSayi;
		private int tahminHakki = 3;

		public Form1()
		{
			InitializeComponent();
			YeniSayiTut();
		}

		private void YeniSayiTut()
		{
			Random rnd = new Random();
			tutulanSayi = rnd.Next(0, 11); 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tahminHakki > 0)
			{
				int kullaniciTahmini;
				bool gecerliMi = int.TryParse(textBox1.Text, out kullaniciTahmini);


				tahminHakki--;

				if (kullaniciTahmini == tutulanSayi)
				{
					label3.Text = "Tebrikler! Doğru tahmin ettiniz.";
					button1.Enabled = false;
				}
				else
				{
					if (tahminHakki > 0)
					{
						string yonlendirme = kullaniciTahmini < tutulanSayi
							? "Daha büyük bir sayı girin."
							: "Daha küçük bir sayı girin.";

						label2.Text = $"Kalan hakkınız: { tahminHakki}";
						;
						label3.Text = $"Yanlış! {yonlendirme}";
					}
					else
					{
						label2.Text = $" Doğru sayı: {tutulanSayi}";
						label3.Text = $"Üzgünüm, tahmin hakkınız bitti.";
						button1.Enabled = false;
					}
				}
			}
		}
	}
}u

