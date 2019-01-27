namespace EntityProject
{
    partial class Arama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtteslim = new System.Windows.Forms.DateTimePicker();
            this.dtiade = new System.Windows.Forms.DateTimePicker();
            this.teslimtarihi = new System.Windows.Forms.Label();
            this.iadetarihi = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.tbsikayet = new System.Windows.Forms.TextBox();
            this.tbcihazsahibi = new System.Windows.Forms.TextBox();
            this.tbucret = new System.Windows.Forms.TextBox();
            this.tbyapilanislem = new System.Windows.Forms.TextBox();
            this.tbserino = new System.Windows.Forms.TextBox();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.tbmarka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngucelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(21, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 28);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Seri No İle Ara:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(21, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 28);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsim İle Ara:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(204, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtteslim);
            this.groupBox2.Controls.Add(this.dtiade);
            this.groupBox2.Controls.Add(this.teslimtarihi);
            this.groupBox2.Controls.Add(this.iadetarihi);
            this.groupBox2.Controls.Add(this.dttarih);
            this.groupBox2.Controls.Add(this.tbsikayet);
            this.groupBox2.Controls.Add(this.tbcihazsahibi);
            this.groupBox2.Controls.Add(this.tbucret);
            this.groupBox2.Controls.Add(this.tbyapilanislem);
            this.groupBox2.Controls.Add(this.tbserino);
            this.groupBox2.Controls.Add(this.tbmodel);
            this.groupBox2.Controls.Add(this.tbmarka);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(18, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 460);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cihaz Bilgileri:";
            // 
            // dtteslim
            // 
            this.dtteslim.Location = new System.Drawing.Point(156, 382);
            this.dtteslim.Name = "dtteslim";
            this.dtteslim.Size = new System.Drawing.Size(260, 26);
            this.dtteslim.TabIndex = 45;
            this.dtteslim.ValueChanged += new System.EventHandler(this.dtteslim_ValueChanged);
            // 
            // dtiade
            // 
            this.dtiade.Location = new System.Drawing.Point(156, 320);
            this.dtiade.Name = "dtiade";
            this.dtiade.Size = new System.Drawing.Size(260, 26);
            this.dtiade.TabIndex = 44;
            this.dtiade.ValueChanged += new System.EventHandler(this.dtiade_ValueChanged);
            // 
            // teslimtarihi
            // 
            this.teslimtarihi.AutoSize = true;
            this.teslimtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimtarihi.Location = new System.Drawing.Point(17, 381);
            this.teslimtarihi.Name = "teslimtarihi";
            this.teslimtarihi.Size = new System.Drawing.Size(123, 24);
            this.teslimtarihi.TabIndex = 43;
            this.teslimtarihi.Text = "Teslim Tarihi:";
            this.teslimtarihi.Click += new System.EventHandler(this.teslimtarihi_Click);
            // 
            // iadetarihi
            // 
            this.iadetarihi.AutoSize = true;
            this.iadetarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadetarihi.Location = new System.Drawing.Point(17, 320);
            this.iadetarihi.Name = "iadetarihi";
            this.iadetarihi.Size = new System.Drawing.Size(103, 24);
            this.iadetarihi.TabIndex = 43;
            this.iadetarihi.Text = "İade Tarihi:";
            this.iadetarihi.Click += new System.EventHandler(this.iadetarihi_Click);
            // 
            // dttarih
            // 
            this.dttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Location = new System.Drawing.Point(158, 156);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(273, 28);
            this.dttarih.TabIndex = 42;
            // 
            // tbsikayet
            // 
            this.tbsikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsikayet.Location = new System.Drawing.Point(648, 37);
            this.tbsikayet.Multiline = true;
            this.tbsikayet.Name = "tbsikayet";
            this.tbsikayet.Size = new System.Drawing.Size(273, 130);
            this.tbsikayet.TabIndex = 41;
            // 
            // tbcihazsahibi
            // 
            this.tbcihazsahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbcihazsahibi.Location = new System.Drawing.Point(158, 255);
            this.tbcihazsahibi.Name = "tbcihazsahibi";
            this.tbcihazsahibi.Size = new System.Drawing.Size(273, 28);
            this.tbcihazsahibi.TabIndex = 40;
            // 
            // tbucret
            // 
            this.tbucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbucret.Location = new System.Drawing.Point(158, 202);
            this.tbucret.Name = "tbucret";
            this.tbucret.Size = new System.Drawing.Size(273, 28);
            this.tbucret.TabIndex = 39;
            // 
            // tbyapilanislem
            // 
            this.tbyapilanislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbyapilanislem.Location = new System.Drawing.Point(648, 255);
            this.tbyapilanislem.Multiline = true;
            this.tbyapilanislem.Name = "tbyapilanislem";
            this.tbyapilanislem.Size = new System.Drawing.Size(273, 150);
            this.tbyapilanislem.TabIndex = 38;
            // 
            // tbserino
            // 
            this.tbserino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbserino.Location = new System.Drawing.Point(158, 112);
            this.tbserino.Name = "tbserino";
            this.tbserino.Size = new System.Drawing.Size(273, 28);
            this.tbserino.TabIndex = 37;
            // 
            // tbmodel
            // 
            this.tbmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmodel.Location = new System.Drawing.Point(158, 76);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(273, 28);
            this.tbmodel.TabIndex = 36;
            // 
            // tbmarka
            // 
            this.tbmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmarka.Location = new System.Drawing.Point(158, 37);
            this.tbmarka.Name = "tbmarka";
            this.tbmarka.Size = new System.Drawing.Size(273, 28);
            this.tbmarka.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(496, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Yapılan İslem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cihaz Sahibi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ucret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kayıt Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(505, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sikayet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Seri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marka:";
            // 
            // btngucelle
            // 
            this.btngucelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btngucelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngucelle.Location = new System.Drawing.Point(27, 59);
            this.btngucelle.Name = "btngucelle";
            this.btngucelle.Size = new System.Drawing.Size(142, 49);
            this.btngucelle.TabIndex = 3;
            this.btngucelle.Text = "Güncelle";
            this.btngucelle.UseVisualStyleBackColor = false;
            this.btngucelle.Click += new System.EventHandler(this.btngucelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(27, 144);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(142, 49);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(1076, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum Değişikliği";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(19, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 49);
            this.button4.TabIndex = 2;
            this.button4.Text = "Teslim Edildi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(19, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "İade";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnsil);
            this.groupBox4.Controls.Add(this.btngucelle);
            this.groupBox4.Location = new System.Drawing.Point(1324, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 209);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1541, 258);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1552, 766);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Arama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.TextBox tbsikayet;
        private System.Windows.Forms.TextBox tbcihazsahibi;
        private System.Windows.Forms.TextBox tbucret;
        private System.Windows.Forms.TextBox tbyapilanislem;
        private System.Windows.Forms.TextBox tbserino;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.TextBox tbmarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngucelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtteslim;
        private System.Windows.Forms.DateTimePicker dtiade;
        private System.Windows.Forms.Label teslimtarihi;
        private System.Windows.Forms.Label iadetarihi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
    }
}