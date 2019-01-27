using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EntityProject.Entities;

namespace EntityProject
{
    public partial class Form1 : Form
    {
        RelationContext db = new RelationContext();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        void doldur()
        {
           
            var kayitlar = (from k in db.musterilers
                            select k).ToList(); 
            bs.DataSource = kayitlar;

            

          /*  txtMarka.DataBindings.Add("Text",bs,"marka");
            txtModel.DataBindings.Add("Text",bs,"model");
            txtSerino.DataBindings.Add("Text",bs,"serino");
            txtSikayet.DataBindings.Add("Text",bs,"sikayet");
            txtucret.DataBindings.Add("Text",bs,"ucret");
            txtislem.DataBindings.Add("Text",bs,"yapilanislem");*/
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            doldur();
            dataGridView1.DataSource = bs;

        }

        void temizle()
        {
            txtMarka.Text = "";
            txtModel.Text = "";
            txtSerino.Text = "";
            txtSikayet.Text = "";
            txtislem.Text = "";
            txtucret.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            cihazlar cihaz = new cihazlar();
            cihaz.marka = txtMarka.Text;
            cihaz.model = txtModel.Text;
            cihaz.serino = txtSerino.Text;
            cihaz.sikayet = txtSikayet.Text;
            cihaz.yapilanislem = txtislem.Text;
            cihaz.kayit_tarihi = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString());
            cihaz.ucret = txtucret.Text;
            cihaz.cihazsahibi = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            db.cihazlars.Add(cihaz);
            db.SaveChanges();
            MessageBox.Show("Kaydetme işlemi başarılı.");
            temizle();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dondur = new DialogResult();
            if (txtadsoyad.Text == " " && txttc.Text == " " && txttel.Text == " ")
            { MessageBox.Show("İlgili alanları doldurunuz.."); }
            else
            {
                musteriler yenibey = new musteriler();
                yenibey.adsoyad = txtadsoyad.Text;
                yenibey.tc = txttc.Text;
                yenibey.telefon = txttel.Text;
                db.musterilers.Add(yenibey);
                db.SaveChanges();
                dondur = MessageBox.Show("Kaydetme işlemi başarılı.. Yeniden işlem yapmak ister misin?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dondur == DialogResult.Yes)
                {
                    txtadsoyad.Text = "";
                    txttc.Text = "";
                    txttel.Text = "";
                }
                else
                {
                    txtadsoyad.Text = "";
                    txttc.Text = "";
                    txttel.Text = "";
                    panel1.Visible = false;
                }
                dataGridView1.Refresh();
                doldur();

            }
        }
    }
}
