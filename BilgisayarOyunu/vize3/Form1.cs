using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize3
{
    public partial class Form1: Form
    {
        
		private PictureBox[] nesneler; 
		private int kalanNesne;
		private Random rnd = new Random();
		private bool oyuncuSirasi = true; 

		public Form1()
		{
			InitializeComponent();
			OyunuBaslat();
		}

		private void OyunuBaslat()
		{
			
			nesneler = Controls.OfType<PictureBox>().OrderBy(p => p.Left).ToArray();
			kalanNesne = nesneler.Length;

			foreach (var nesne in nesneler)
			{
				nesne.Visible = true;
			}

			label1.Text = "Oyuncu başlıyor!";
		}

		private void NesneAl(int miktar)
		{
			if (miktar < 1 || miktar > 2 || miktar > kalanNesne)
				return;

			int alinan = 0;
			foreach (var nesne in nesneler)
			{
				if (nesne.Visible)
				{
					nesne.Visible = false;
					alinan++;
					kalanNesne--;

					if (alinan == miktar)
						break;
				}
			}

			if (kalanNesne == 0)
			{
				label1.Text = oyuncuSirasi ?  "Oyuncu Kazandı!!!":"Bilgisayar Kazandı!!!";
				MessageBox.Show(label1.Text);
				return;
			}

			oyuncuSirasi = !oyuncuSirasi;

			if (!oyuncuSirasi)
				BilgisayarHamlesi();
		}

		private void BilgisayarHamlesi()
		{
			int alinan = rnd.Next(1, Math.Min(3, kalanNesne + 1)); 
			label1.Text = $"Bilgisayar {alinan} nesne aldı.";
			NesneAl(alinan);
		}



		private void button1_Click(object sender, EventArgs e)
		{
				if (oyuncuSirasi)
					NesneAl(1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (oyuncuSirasi)
				NesneAl(2);
		}

	
	}
	
}
	



