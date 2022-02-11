using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<yazar> yazarlar = new List<yazar>();
        List<Kitap> kitaplar = new List<Kitap>();
        List<Müşteri> müşteriler = new List<Müşteri>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            yazar yzr = new yazar();
            yzr.adi = txtYazarAdi.Text;
            yzr.dogumtarihi = dtYazarDogumTarihi.Value;

            if (chkNobel.Checked==true)
	        {
		        yzr.NobelÖdülü = true;
	        }
            else
            {
                yzr.NobelÖdülü =false;
            }
            yazarlar.Add(yzr);
            cmbYazar.Items.Add(yzr);
            cmbYazar.DisplayMember = "adi";
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
           Kitap ktp = new Kitap();
            ktp.kitapadi = txtKitapAdi.Text;
            ktp.kitaptürü = (string)cmbKitapTuru.SelectedItem;
            ktp.sayfasayısı =int.Parse(txtSayfaSayisi.Text);
            ktp.kitapfiyati = decimal.Parse(txtFiyat.Text);
            ktp.yazari = (yazar)cmbYazar.SelectedItem;
            kitaplar.Add(ktp);
            cmbKitap.Items.Add(ktp);
            cmbKitap.DisplayMember = "kitapadi";
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Müşteri mşt = new Müşteri();
            mşt.müsteriadi = txtMusteriAdi.Text;
            mşt.meslegi = txtMeslegi.Text;
            mşt.kitap = txtKitapAdi.Text;
            mşt.yas =int.Parse(txtMusteriYas.Text);
            müşteriler.Add(mşt);
        }
        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            foreach (var müsteri in müşteriler)
            {
                lsbMusteriler.Items.Add(müsteri.müsteriadi+" "+ müsteri.meslegi+" "+ müsteri.kitap+" "+müsteri.yas);
            }
        }  
    }
}
