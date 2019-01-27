using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityProject.Entities;

namespace EntityProject
{
    public partial class iadeVEteslim : Form
    {
        public iadeVEteslim()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        BindingSource bisi = new BindingSource();
        RelationContext db = new RelationContext();


        //iade edilenler için
        void kayitlari_cek()
        {

            var kayitlari = (from k in db.iadeedilenlers
                            select k).ToList();
            bs.DataSource = kayitlari;

        }

        //teslim edilenler için

        void kayitlari_cekelimbakalim()
        {

            var kayitlar = (from k in db.teslimedilenlers
                            select k).ToList();
            bisi.DataSource = kayitlar;

        }

        //CİHAZSAHİBİNE GÖRE ARAMA   ----iade edilenlerde
        void arayalimbakalim()
        {
            var bulunankayitlar = db.iadeedilenlers.Where(k => k.cihazsahibi.Contains(textBox1.Text)).ToList();
            bs.DataSource = bulunankayitlar;
            if (textBox1.Text == "") kayitlari_cek();
        }

        //SERİNOYA GÖRE ARAMA ----iade edilenlerde 
        void ariyoruzozaman()
        {
            var bulunankayitlar = db.iadeedilenlers.Where(k => k.serino.Contains(textBox2.Text)).ToList();
            bs.DataSource = bulunankayitlar;
            if (textBox2.Text == "") kayitlari_cek();
        }

        
        //CİHAZSAHİBİNE GÖRE ARAMA   ----teslim edilenlerde edilenlerde
        void arayalimbakalim2()
        {
            var bulunankayitlar = db.teslimedilenlers.Where(k => k.cihazsahibi.Contains(textBox3.Text)).ToList();
            bisi.DataSource = bulunankayitlar;
            if (textBox3.Text == "") kayitlari_cekelimbakalim();
        }
        //SERİNOYA GÖRE ARAMA ----iade edilenlerde 
        void ariyoruzozaman2()
        {
            var bulunankayitlar = db.teslimedilenlers.Where(k => k.serino.Contains(textBox4.Text)).ToList();
            bisi.DataSource = bulunankayitlar;
            if (textBox4.Text == "") kayitlari_cekelimbakalim();
        }

        private void iadeVEteslim_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            dataGridView1.DataSource = bs;
            dataGridView2.DataSource = bisi;
            kayitlari_cek();
            kayitlari_cekelimbakalim();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
                textBox2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
                textBox1.Enabled = false;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arayalimbakalim();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ariyoruzozaman();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            arayalimbakalim2();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
                textBox4.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox4.Enabled = true;
                textBox4.Focus();
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ariyoruzozaman2();
        }

       
    }
}
