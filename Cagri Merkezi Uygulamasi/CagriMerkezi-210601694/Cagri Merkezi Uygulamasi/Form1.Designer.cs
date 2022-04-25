
namespace Cagri_Merkezi_Uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnaramaYap = new System.Windows.Forms.Button();
            this.cagriAtama = new System.Windows.Forms.Button();
            this.cagriyiBitir = new System.Windows.Forms.Button();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCallType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.temsilci1 = new System.Windows.Forms.GroupBox();
            this.lbltemsilci1 = new System.Windows.Forms.Label();
            this.txtTemsilci1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtMusteri1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtCagri1 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.temsilci2 = new System.Windows.Forms.GroupBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txtCagri2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtMusteri2 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtTemsilci2 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.temsilci3 = new System.Windows.Forms.GroupBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtCagri3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtMusteri3 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.txtTemsilci3 = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.temsilci4 = new System.Windows.Forms.GroupBox();
            this.txtNot4 = new System.Windows.Forms.TextBox();
            this.lbl16 = new System.Windows.Forms.Label();
            this.txtCagri4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl15 = new System.Windows.Forms.Label();
            this.txtMusteri4 = new System.Windows.Forms.TextBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.txtTemsilci4 = new System.Windows.Forms.TextBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CagriListesi = new System.Windows.Forms.ListBox();
            this.TemsilciListesi = new System.Windows.Forms.ListBox();
            this.lblAtama = new System.Windows.Forms.Label();
            this.txtCagriNo = new System.Windows.Forms.TextBox();
            this.btnAtamalr = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Notlar = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.temsilci1.SuspendLayout();
            this.temsilci2.SuspendLayout();
            this.temsilci3.SuspendLayout();
            this.temsilci4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaramaYap
            // 
            this.btnaramaYap.Location = new System.Drawing.Point(194, 107);
            this.btnaramaYap.Name = "btnaramaYap";
            this.btnaramaYap.Size = new System.Drawing.Size(108, 37);
            this.btnaramaYap.TabIndex = 0;
            this.btnaramaYap.Text = "Arama Yap";
            this.btnaramaYap.UseVisualStyleBackColor = true;
            this.btnaramaYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cagriAtama
            // 
            this.cagriAtama.Location = new System.Drawing.Point(135, 268);
            this.cagriAtama.Name = "cagriAtama";
            this.cagriAtama.Size = new System.Drawing.Size(107, 37);
            this.cagriAtama.TabIndex = 2;
            this.cagriAtama.Text = "Çağrıyı Ata";
            this.cagriAtama.UseVisualStyleBackColor = true;
            // 
            // cagriyiBitir
            // 
            this.cagriyiBitir.Location = new System.Drawing.Point(82, 185);
            this.cagriyiBitir.Name = "cagriyiBitir";
            this.cagriyiBitir.Size = new System.Drawing.Size(99, 37);
            this.cagriyiBitir.TabIndex = 3;
            this.cagriyiBitir.Text = "Çağrıyı Bitir";
            this.cagriyiBitir.UseVisualStyleBackColor = true;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(142, 29);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(160, 22);
            this.txtNameClient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Adı Soyadı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arama Tipi:";
            // 
            // cboxCallType
            // 
            this.cboxCallType.FormattingEnabled = true;
            this.cboxCallType.Items.AddRange(new object[] {
            "Ticari",
            "Bireysel"});
            this.cboxCallType.Location = new System.Drawing.Point(142, 67);
            this.cboxCallType.Margin = new System.Windows.Forms.Padding(4);
            this.cboxCallType.Name = "cboxCallType";
            this.cboxCallType.Size = new System.Drawing.Size(160, 24);
            this.cboxCallType.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 579);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNameClient);
            this.tabPage1.Controls.Add(this.cboxCallType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnaramaYap);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.temsilci4);
            this.tabPage2.Controls.Add(this.temsilci3);
            this.tabPage2.Controls.Add(this.temsilci2);
            this.tabPage2.Controls.Add(this.temsilci1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Temsilcisi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // temsilci1
            // 
            this.temsilci1.Controls.Add(this.txtNot1);
            this.temsilci1.Controls.Add(this.lbl4);
            this.temsilci1.Controls.Add(this.txtCagri1);
            this.temsilci1.Controls.Add(this.cagriyiBitir);
            this.temsilci1.Controls.Add(this.lbl3);
            this.temsilci1.Controls.Add(this.txtMusteri1);
            this.temsilci1.Controls.Add(this.lbl2);
            this.temsilci1.Controls.Add(this.txtTemsilci1);
            this.temsilci1.Controls.Add(this.lbltemsilci1);
            this.temsilci1.Location = new System.Drawing.Point(6, 6);
            this.temsilci1.Name = "temsilci1";
            this.temsilci1.Size = new System.Drawing.Size(200, 222);
            this.temsilci1.TabIndex = 0;
            this.temsilci1.TabStop = false;
            this.temsilci1.Text = "Görüşme1";
            // 
            // lbltemsilci1
            // 
            this.lbltemsilci1.Location = new System.Drawing.Point(6, 30);
            this.lbltemsilci1.Name = "lbltemsilci1";
            this.lbltemsilci1.Size = new System.Drawing.Size(99, 22);
            this.lbltemsilci1.TabIndex = 10;
            this.lbltemsilci1.Text = "Temsilci Id: ";
            this.lbltemsilci1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltemsilci1.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtTemsilci1
            // 
            this.txtTemsilci1.Location = new System.Drawing.Point(95, 30);
            this.txtTemsilci1.Name = "txtTemsilci1";
            this.txtTemsilci1.ReadOnly = true;
            this.txtTemsilci1.Size = new System.Drawing.Size(86, 22);
            this.txtTemsilci1.TabIndex = 11;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(6, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 45);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Müşteri ID/Ad";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMusteri1
            // 
            this.txtMusteri1.Location = new System.Drawing.Point(95, 75);
            this.txtMusteri1.Name = "txtMusteri1";
            this.txtMusteri1.ReadOnly = true;
            this.txtMusteri1.Size = new System.Drawing.Size(86, 22);
            this.txtMusteri1.TabIndex = 13;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(6, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(88, 23);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "Çağrı Id:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCagri1
            // 
            this.txtCagri1.Location = new System.Drawing.Point(95, 112);
            this.txtCagri1.Name = "txtCagri1";
            this.txtCagri1.ReadOnly = true;
            this.txtCagri1.Size = new System.Drawing.Size(86, 22);
            this.txtCagri1.TabIndex = 15;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(6, 152);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(88, 23);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Notlar:";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(95, 152);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.ReadOnly = true;
            this.txtNot1.Size = new System.Drawing.Size(86, 22);
            this.txtNot1.TabIndex = 17;
            // 
            // temsilci2
            // 
            this.temsilci2.Controls.Add(this.txtNot2);
            this.temsilci2.Controls.Add(this.lbl8);
            this.temsilci2.Controls.Add(this.txtCagri2);
            this.temsilci2.Controls.Add(this.button1);
            this.temsilci2.Controls.Add(this.lbl7);
            this.temsilci2.Controls.Add(this.txtMusteri2);
            this.temsilci2.Controls.Add(this.lbl6);
            this.temsilci2.Controls.Add(this.txtTemsilci2);
            this.temsilci2.Controls.Add(this.lbl5);
            this.temsilci2.Location = new System.Drawing.Point(233, 6);
            this.temsilci2.Name = "temsilci2";
            this.temsilci2.Size = new System.Drawing.Size(200, 222);
            this.temsilci2.TabIndex = 18;
            this.temsilci2.TabStop = false;
            this.temsilci2.Text = "Görüşme2";
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(95, 152);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.ReadOnly = true;
            this.txtNot2.Size = new System.Drawing.Size(86, 22);
            this.txtNot2.TabIndex = 17;
            // 
            // lbl8
            // 
            this.lbl8.Location = new System.Drawing.Point(6, 152);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(88, 23);
            this.lbl8.TabIndex = 16;
            this.lbl8.Text = "Notlar:";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCagri2
            // 
            this.txtCagri2.Location = new System.Drawing.Point(95, 112);
            this.txtCagri2.Name = "txtCagri2";
            this.txtCagri2.ReadOnly = true;
            this.txtCagri2.Size = new System.Drawing.Size(86, 22);
            this.txtCagri2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çağrıyı Bitir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl7
            // 
            this.lbl7.Location = new System.Drawing.Point(6, 109);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(88, 23);
            this.lbl7.TabIndex = 14;
            this.lbl7.Text = "Çağrı Id:";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMusteri2
            // 
            this.txtMusteri2.Location = new System.Drawing.Point(95, 75);
            this.txtMusteri2.Name = "txtMusteri2";
            this.txtMusteri2.ReadOnly = true;
            this.txtMusteri2.Size = new System.Drawing.Size(86, 22);
            this.txtMusteri2.TabIndex = 13;
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(6, 64);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(88, 45);
            this.lbl6.TabIndex = 12;
            this.lbl6.Text = "Müşteri ID/Ad";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemsilci2
            // 
            this.txtTemsilci2.Location = new System.Drawing.Point(95, 30);
            this.txtTemsilci2.Name = "txtTemsilci2";
            this.txtTemsilci2.ReadOnly = true;
            this.txtTemsilci2.Size = new System.Drawing.Size(86, 22);
            this.txtTemsilci2.TabIndex = 11;
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(6, 30);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(99, 22);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Temsilci Id: ";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temsilci3
            // 
            this.temsilci3.Controls.Add(this.txtNot3);
            this.temsilci3.Controls.Add(this.lbl12);
            this.temsilci3.Controls.Add(this.txtCagri3);
            this.temsilci3.Controls.Add(this.button2);
            this.temsilci3.Controls.Add(this.lbl11);
            this.temsilci3.Controls.Add(this.txtMusteri3);
            this.temsilci3.Controls.Add(this.lbl10);
            this.temsilci3.Controls.Add(this.txtTemsilci3);
            this.temsilci3.Controls.Add(this.lbl9);
            this.temsilci3.Location = new System.Drawing.Point(15, 273);
            this.temsilci3.Name = "temsilci3";
            this.temsilci3.Size = new System.Drawing.Size(200, 222);
            this.temsilci3.TabIndex = 19;
            this.temsilci3.TabStop = false;
            this.temsilci3.Text = "Görüşme3";
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(95, 152);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.ReadOnly = true;
            this.txtNot3.Size = new System.Drawing.Size(86, 22);
            this.txtNot3.TabIndex = 17;
            // 
            // lbl12
            // 
            this.lbl12.Location = new System.Drawing.Point(6, 152);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(88, 23);
            this.lbl12.TabIndex = 16;
            this.lbl12.Text = "Notlar:";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCagri3
            // 
            this.txtCagri3.Location = new System.Drawing.Point(95, 112);
            this.txtCagri3.Name = "txtCagri3";
            this.txtCagri3.ReadOnly = true;
            this.txtCagri3.Size = new System.Drawing.Size(86, 22);
            this.txtCagri3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Çağrıyı Bitir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl11
            // 
            this.lbl11.Location = new System.Drawing.Point(6, 109);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(88, 23);
            this.lbl11.TabIndex = 14;
            this.lbl11.Text = "Çağrı Id:";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMusteri3
            // 
            this.txtMusteri3.Location = new System.Drawing.Point(95, 75);
            this.txtMusteri3.Name = "txtMusteri3";
            this.txtMusteri3.ReadOnly = true;
            this.txtMusteri3.Size = new System.Drawing.Size(86, 22);
            this.txtMusteri3.TabIndex = 13;
            // 
            // lbl10
            // 
            this.lbl10.Location = new System.Drawing.Point(6, 60);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(88, 45);
            this.lbl10.TabIndex = 12;
            this.lbl10.Text = "Müşteri ID/Ad";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemsilci3
            // 
            this.txtTemsilci3.Location = new System.Drawing.Point(95, 30);
            this.txtTemsilci3.Name = "txtTemsilci3";
            this.txtTemsilci3.ReadOnly = true;
            this.txtTemsilci3.Size = new System.Drawing.Size(86, 22);
            this.txtTemsilci3.TabIndex = 11;
            // 
            // lbl9
            // 
            this.lbl9.Location = new System.Drawing.Point(6, 30);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(99, 22);
            this.lbl9.TabIndex = 10;
            this.lbl9.Text = "Temsilci Id: ";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temsilci4
            // 
            this.temsilci4.Controls.Add(this.txtNot4);
            this.temsilci4.Controls.Add(this.lbl16);
            this.temsilci4.Controls.Add(this.txtCagri4);
            this.temsilci4.Controls.Add(this.button3);
            this.temsilci4.Controls.Add(this.lbl15);
            this.temsilci4.Controls.Add(this.txtMusteri4);
            this.temsilci4.Controls.Add(this.lbl14);
            this.temsilci4.Controls.Add(this.txtTemsilci4);
            this.temsilci4.Controls.Add(this.lbl13);
            this.temsilci4.Location = new System.Drawing.Point(242, 273);
            this.temsilci4.Name = "temsilci4";
            this.temsilci4.Size = new System.Drawing.Size(200, 222);
            this.temsilci4.TabIndex = 20;
            this.temsilci4.TabStop = false;
            this.temsilci4.Text = "Görüşme1";
            // 
            // txtNot4
            // 
            this.txtNot4.Location = new System.Drawing.Point(95, 152);
            this.txtNot4.Name = "txtNot4";
            this.txtNot4.ReadOnly = true;
            this.txtNot4.Size = new System.Drawing.Size(86, 22);
            this.txtNot4.TabIndex = 17;
            // 
            // lbl16
            // 
            this.lbl16.Location = new System.Drawing.Point(6, 152);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(88, 23);
            this.lbl16.TabIndex = 16;
            this.lbl16.Text = "Notlar:";
            this.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCagri4
            // 
            this.txtCagri4.Location = new System.Drawing.Point(95, 112);
            this.txtCagri4.Name = "txtCagri4";
            this.txtCagri4.ReadOnly = true;
            this.txtCagri4.Size = new System.Drawing.Size(86, 22);
            this.txtCagri4.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çağrıyı Bitir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl15
            // 
            this.lbl15.Location = new System.Drawing.Point(6, 109);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(88, 23);
            this.lbl15.TabIndex = 14;
            this.lbl15.Text = "Çağrı Id:";
            this.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMusteri4
            // 
            this.txtMusteri4.Location = new System.Drawing.Point(95, 75);
            this.txtMusteri4.Name = "txtMusteri4";
            this.txtMusteri4.ReadOnly = true;
            this.txtMusteri4.Size = new System.Drawing.Size(86, 22);
            this.txtMusteri4.TabIndex = 13;
            // 
            // lbl14
            // 
            this.lbl14.Location = new System.Drawing.Point(6, 64);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(88, 45);
            this.lbl14.TabIndex = 12;
            this.lbl14.Text = "Müşteri ID/Ad";
            this.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemsilci4
            // 
            this.txtTemsilci4.Location = new System.Drawing.Point(95, 30);
            this.txtTemsilci4.Name = "txtTemsilci4";
            this.txtTemsilci4.ReadOnly = true;
            this.txtTemsilci4.Size = new System.Drawing.Size(86, 22);
            this.txtTemsilci4.TabIndex = 11;
            // 
            // lbl13
            // 
            this.lbl13.Location = new System.Drawing.Point(6, 30);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(99, 22);
            this.lbl13.TabIndex = 10;
            this.lbl13.Text = "Temsilci Id: ";
            this.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAtamalr);
            this.tabPage3.Controls.Add(this.txtCagriNo);
            this.tabPage3.Controls.Add(this.lblAtama);
            this.tabPage3.Controls.Add(this.TemsilciListesi);
            this.tabPage3.Controls.Add(this.CagriListesi);
            this.tabPage3.Controls.Add(this.cagriAtama);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(487, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Atamalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CagriListesi
            // 
            this.CagriListesi.FormattingEnabled = true;
            this.CagriListesi.ItemHeight = 16;
            this.CagriListesi.Location = new System.Drawing.Point(34, 30);
            this.CagriListesi.Name = "CagriListesi";
            this.CagriListesi.Size = new System.Drawing.Size(120, 212);
            this.CagriListesi.TabIndex = 3;
            // 
            // TemsilciListesi
            // 
            this.TemsilciListesi.FormattingEnabled = true;
            this.TemsilciListesi.ItemHeight = 16;
            this.TemsilciListesi.Location = new System.Drawing.Point(231, 30);
            this.TemsilciListesi.Name = "TemsilciListesi";
            this.TemsilciListesi.Size = new System.Drawing.Size(120, 212);
            this.TemsilciListesi.TabIndex = 4;
            // 
            // lblAtama
            // 
            this.lblAtama.AutoSize = true;
            this.lblAtama.Location = new System.Drawing.Point(31, 390);
            this.lblAtama.Name = "lblAtama";
            this.lblAtama.Size = new System.Drawing.Size(109, 17);
            this.lblAtama.TabIndex = 5;
            this.lblAtama.Text = "Çağrı Numarası:";
            // 
            // txtCagriNo
            // 
            this.txtCagriNo.Location = new System.Drawing.Point(146, 387);
            this.txtCagriNo.Name = "txtCagriNo";
            this.txtCagriNo.Size = new System.Drawing.Size(100, 22);
            this.txtCagriNo.TabIndex = 6;
            // 
            // btnAtamalr
            // 
            this.btnAtamalr.Location = new System.Drawing.Point(93, 429);
            this.btnAtamalr.Name = "btnAtamalr";
            this.btnAtamalr.Size = new System.Drawing.Size(153, 28);
            this.btnAtamalr.TabIndex = 7;
            this.btnAtamalr.Text = "Özel Çağrıyı Ata";
            this.btnAtamalr.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Notlar);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(487, 550);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Günlükler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Notlar
            // 
            this.Notlar.FormattingEnabled = true;
            this.Notlar.ItemHeight = 16;
            this.Notlar.Location = new System.Drawing.Point(24, 45);
            this.Notlar.Name = "Notlar";
            this.Notlar.Size = new System.Drawing.Size(159, 228);
            this.Notlar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.temsilci1.ResumeLayout(false);
            this.temsilci1.PerformLayout();
            this.temsilci2.ResumeLayout(false);
            this.temsilci2.PerformLayout();
            this.temsilci3.ResumeLayout(false);
            this.temsilci3.PerformLayout();
            this.temsilci4.ResumeLayout(false);
            this.temsilci4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaramaYap;
        private System.Windows.Forms.Button cagriAtama;
        private System.Windows.Forms.Button cagriyiBitir;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCallType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox temsilci1;
        private System.Windows.Forms.Label lbltemsilci1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtCagri1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtMusteri1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtTemsilci1;
        private System.Windows.Forms.GroupBox temsilci4;
        private System.Windows.Forms.TextBox txtNot4;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.TextBox txtCagri4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.TextBox txtMusteri4;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.TextBox txtTemsilci4;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.GroupBox temsilci3;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox txtCagri3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtMusteri3;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox txtTemsilci3;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.GroupBox temsilci2;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txtCagri2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txtMusteri2;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txtTemsilci2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAtamalr;
        private System.Windows.Forms.TextBox txtCagriNo;
        private System.Windows.Forms.Label lblAtama;
        private System.Windows.Forms.ListBox TemsilciListesi;
        private System.Windows.Forms.ListBox CagriListesi;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox Notlar;
    }
}

