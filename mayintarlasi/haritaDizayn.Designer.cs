namespace mayintarlasi
{
    partial class haritaDizayn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.karakter = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbBos = new System.Windows.Forms.RadioButton();
            this.rbMayin = new System.Windows.Forms.RadioButton();
            this.rbBomba = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbHarita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbIskele = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.karakter);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 332);
            this.panel1.TabIndex = 0;
            // 
            // karakter
            // 
            this.karakter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.karakter.Location = new System.Drawing.Point(0, 0);
            this.karakter.Name = "karakter";
            this.karakter.Size = new System.Drawing.Size(40, 40);
            this.karakter.TabIndex = 0;
            this.karakter.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Harita aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbBos
            // 
            this.rbBos.AutoSize = true;
            this.rbBos.Location = new System.Drawing.Point(715, 86);
            this.rbBos.Name = "rbBos";
            this.rbBos.Size = new System.Drawing.Size(66, 17);
            this.rbBos.TabIndex = 2;
            this.rbBos.TabStop = true;
            this.rbBos.Text = "Boş Varil";
            this.rbBos.UseVisualStyleBackColor = true;
            // 
            // rbMayin
            // 
            this.rbMayin.AutoSize = true;
            this.rbMayin.Location = new System.Drawing.Point(715, 109);
            this.rbMayin.Name = "rbMayin";
            this.rbMayin.Size = new System.Drawing.Size(53, 17);
            this.rbMayin.TabIndex = 3;
            this.rbMayin.TabStop = true;
            this.rbMayin.Text = "Mayın";
            this.rbMayin.UseVisualStyleBackColor = true;
            // 
            // rbBomba
            // 
            this.rbBomba.AutoSize = true;
            this.rbBomba.Location = new System.Drawing.Point(715, 132);
            this.rbBomba.Name = "rbBomba";
            this.rbBomba.Size = new System.Drawing.Size(85, 17);
            this.rbBomba.TabIndex = 4;
            this.rbBomba.TabStop = true;
            this.rbBomba.Text = "Bombalı Varil";
            this.rbBomba.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "haritayı kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(299, 348);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 69);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbHarita
            // 
            this.tbHarita.Location = new System.Drawing.Point(700, 266);
            this.tbHarita.Name = "tbHarita";
            this.tbHarita.Size = new System.Drawing.Size(100, 20);
            this.tbHarita.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "harita adı";
            // 
            // rbIskele
            // 
            this.rbIskele.AutoSize = true;
            this.rbIskele.Location = new System.Drawing.Point(715, 155);
            this.rbIskele.Name = "rbIskele";
            this.rbIskele.Size = new System.Drawing.Size(100, 17);
            this.rbIskele.TabIndex = 9;
            this.rbIskele.TabStop = true;
            this.rbIskele.Text = "İskele (1 ADET)";
            this.rbIskele.UseVisualStyleBackColor = true;
            // 
            // haritaDizayn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 451);
            this.Controls.Add(this.rbIskele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHarita);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbBomba);
            this.Controls.Add(this.rbMayin);
            this.Controls.Add(this.rbBos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "haritaDizayn";
            this.Text = "formm";
            this.Load += new System.EventHandler(this.formm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox karakter;
        private System.Windows.Forms.RadioButton rbBos;
        private System.Windows.Forms.RadioButton rbMayin;
        private System.Windows.Forms.RadioButton rbBomba;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbHarita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbIskele;
    }
}