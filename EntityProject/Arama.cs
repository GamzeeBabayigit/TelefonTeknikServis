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
    public partial class Arama : Form
    {
        RelationContext db = new RelationContext();
        BindingSource bs = new BindingSource();

        public Arama()
        {
            InitializeComponent();
        }

        private void Arama_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dataGridView1.DataSource = bs;
            kayitlari_cek();

            //iade ve teslim tıklandığında gözüksünler

            iadetarihi.Visible = false;
            teslimtarihi.Visible = false;
            dtiade.Visible = false;
            dtteslim.Visible = false;


            tbmarka.DataBindings.Add("Text", bs, "marka");
            tbmodel.DataBindings.Add("Text", bs, "model");
            tbserino.DataBindings.Add("Text", bs, "serino");
            dttarih.DataBindings.Add("Text", bs, "kayit_tarihi");
            tbucret.DataBindings.Add("Text", bs, "ucret");
            tbcihazsahibi.DataBindings.Add("Text", bs, "cihazsahibi");
            tbsikayet.DataBindings.Add("Text", bs, "sikayet");
            tbyapilanislem.DataBindings.Add("Text", bs, "yapilanislem");



        }

        void temizleyelim()
        {
            tbcihazsahibi.Text = "";
            tbmarka.Text = "";
            tbmodel.Text = "";
            tbserino.Text = "";
            tbsikayet.Text = "";
            tbucret.Text = "";
            tbyapilanislem.Text= "";

        }

        void kayitlari_cek()
        {
            
                var kayitlar = (from k in db.cihazlars
                                select k).ToList();
                bs.DataSource = kayitlar;
            
        }

        void arayalimbakalim()
        {
            var bulunankayitlar = db.cihazlars.Where(k => k.cihazsahibi.Contains(textBox1.Text)).ToList();
            bs.DataSource = bulunankayitlar;
            if (textBox1.Text == "") kayitlari_cek();
        }

        void ariyoruzozaman()
        {
            var bulunankayitlar = db.cihazlars.Where(k => k.serino.Contains(textBox2.Text)).ToList();
            bs.DataSource = bulunankayitlar;
            if (textBox2.Text == "") kayitlari_cek();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  txtKategoriGuncele.Text = dgvKategoriler.CurrentRow.Cells["Kategori"].Value.ToString();

            tbmarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            tbmarka.Text = dataGridView1.CurrentRow.Cells["model"].Value.ToString();
            tbserino.Text = dataGridView1.CurrentRow.Cells["serino"].Value.ToString();
            tbsikayet.Text = dataGridView1.CurrentRow.Cells["sikayet"].Value.ToString();
            tbucret.Text = dataGridView1.CurrentRow.Cells["ucret"].Value.ToString();
            tbyapilanislem.Text = dataGridView1.CurrentRow.Cells["yapilanislem"].ToString();
            tbcihazsahibi.Text = dataGridView1.CurrentRow.Cells["cihazsahibi"].ToString();
            dttarih.Text = dataGridView1.CurrentRow.Cells["kayit_tarihi"].ToString();
            
        }

        private void btngucelle_Click(object sender, EventArgs e)
        {
            string tutserino = tbserino.Text;
            var duzeltme = db.cihazlars.Where(u => u.serino == tutserino).FirstOrDefault();
            duzeltme.model = tbmodel.Text;
            duzeltme.marka = tbmarka.Text;
            duzeltme.sikayet = tbsikayet.Text;
            duzeltme.ucret = tbucret.Text;
            duzeltme.yapilanislem = tbyapilanislem.Text;
            duzeltme.kayit_tarihi = Convert.ToDateTime(dttarih.Text);
            db.SaveChanges();
            kayitlari_cek();
            MessageBox.Show("Düzeltme işlemi başarıyla gerçekleşti..");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string tutserino = tbserino.Text;
            DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                var silme = db.cihazlars.Where(u => u.serino == tutserino).FirstOrDefault();
                db.cihazlars.Remove(silme);
                db.SaveChanges();
                kayitlari_cek();
            }

        }

        private void button2_Click(object sender, EventArgs e) //iade butonu
        {
            iadetarihi.Visible = true;
            dtiade.Visible = true;

            teslimtarihi.Visible = false;
            dtteslim.Visible = false;
            

            //şimdiiii iade edilmesi gerekenleri iadeedinler tablosuna kaydedeceğiz

            iadeedilenler iade = new iadeedilenler();
            iade.marka = tbmarka.Text;
            iade.model = tbmodel.Text;
            iade.serino = tbserino.Text;
            iade.sikayet = tbsikayet.Text;
            iade.ucret = tbucret.Text;
            iade.yapilanislem = tbyapilanislem.Text;
            iade.cihazsahibi = tbcihazsahibi.Text;
            iade.kayit_tarihi = Convert.ToDateTime(dttarih.Value.ToLongDateString());
            iade.iade_tarihi = Convert.ToDateTime(dtiade.Value.ToLongDateString());
            db.iadeedilenlers.Add(iade);
            db.SaveChanges();

            MessageBox.Show("Ürün iade edildi.");
            temizleyelim();

        }

        private void button4_Click(object sender, EventArgs e) //teslim butonu
        {
            iadetarihi.Visible = false;
            dtiade.Visible = false;

            teslimtarihi.Visible = true;
            dtteslim.Visible = true;

            //Burada da teslim edilenleri teslimedilenler tablosuna kaydedeceğiz
            teslimedilenler teslimiyet = new teslimedilenler();
            teslimiyet.marka = tbmarka.Text;
            teslimiyet.model = tbmodel.Text;
            teslimiyet.serino = tbserino.Text;
            teslimiyet.sikayet = tbsikayet.Text;
            teslimiyet.ucret = tbucret.Text;
            teslimiyet.yapilanislem = tbyapilanislem.Text;
            teslimiyet.cihazsahibi = tbcihazsahibi.Text;
            teslimiyet.kayit_tarihi = Convert.ToDateTime(dttarih.Value.ToLongDateString());
            teslimiyet.teslim_tarihi = Convert.ToDateTime(dtiade.Value.ToLongDateString());
            db.teslimedilenlers.Add(teslimiyet);
            db.SaveChanges();
            MessageBox.Show("Ürün teslim edildi.");
            temizleyelim();


        }

        private void teslimtarihi_Click(object sender, EventArgs e)
        {

        }

        private void dtiade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtteslim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iadetarihi_Click(object sender, EventArgs e)
        {

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
            if(radioButton2.Checked)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ariyoruzozaman();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arayalimbakalim();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
