
namespace kelimeOyunu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBulKlm = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGirilenSayi = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTamam);
            this.groupBox1.Controls.Add(this.txtHarf);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir Harf Giriniz";
            // 
            // btnTamam
            // 
            this.btnTamam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTamam.Location = new System.Drawing.Point(3, 42);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(169, 35);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHarf.Location = new System.Drawing.Point(3, 16);
            this.txtHarf.MaxLength = 1;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(169, 20);
            this.txtHarf.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBulKlm);
            this.groupBox2.Location = new System.Drawing.Point(210, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Kelime";
            // 
            // lblBulKlm
            // 
            this.lblBulKlm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBulKlm.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulKlm.Location = new System.Drawing.Point(3, 16);
            this.lblBulKlm.Name = "lblBulKlm";
            this.lblBulKlm.Size = new System.Drawing.Size(169, 61);
            this.lblBulKlm.TabIndex = 0;
            this.lblBulKlm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGirilenSayi);
            this.groupBox3.Location = new System.Drawing.Point(15, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Girilen Harfler";
            // 
            // lblGirilenSayi
            // 
            this.lblGirilenSayi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGirilenSayi.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirilenSayi.Location = new System.Drawing.Point(3, 16);
            this.lblGirilenSayi.Name = "lblGirilenSayi";
            this.lblGirilenSayi.Size = new System.Drawing.Size(364, 61);
            this.lblGirilenSayi.TabIndex = 0;
            this.lblGirilenSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(311, 20);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(22, 13);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = ":60";
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(408, 20);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(16, 13);
            this.lblCan.TabIndex = 6;
            this.lblCan.Text = ":5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(175, 317);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(91, 46);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kelimeOyunu.Properties.Resources.cann;
            this.pictureBox2.Location = new System.Drawing.Point(377, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kelimeOyunu.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(280, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(12, 39);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(67, 13);
            this.lblSoru.TabIndex = 8;
            this.lblSoru.Text = "....................";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(761, 374);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBulKlm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGirilenSayi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSoru;
    }
}

