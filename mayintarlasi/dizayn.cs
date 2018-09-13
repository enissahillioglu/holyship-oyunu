using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    public partial class dizayn : Form
    {
        string[] dosyalar;
        public dizayn()
        {
            InitializeComponent();
        }

        private void btOyun_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btEditor_Click(object sender, EventArgs e)
        {
            haritaDizayn harita = new haritaDizayn();
            harita.Show();

            this.Hide();
        }

        private void dizayn_Load(object sender, EventArgs e)
        {
            levelleriGoster();
        }

        public void levelleriGoster() {
            
           dosyalar= Directory.GetFiles(@"haritalar\", "*.txt");
            for (int i = 0; i < dosyalar.Length; i++)
            {
                Button a = new Button();
                a.Location = new Point(50*i,20);
                a.Size = new Size(50,50);
                a.Text = (i).ToString();
                a.Click += A_Click;
                this.Controls.Add(a);

            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            int numara = Convert.ToInt32(a.Text);
            Form1 oyun = new Form1(numara);
            oyun.Show();

           // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgi bilgi = new bilgi();
            bilgi.Show();
        }
    }
}
