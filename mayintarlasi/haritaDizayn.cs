using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace mayintarlasi
{
    public partial class haritaDizayn : Form
    {
        public haritaDizayn()
        {
            InitializeComponent();
        }
        string harita;
        public void bosSayfa()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    kutu a = new kutu();
                    a.Size = new Size(40, 40);
                    a.Location = new Point(i * 40, j * 40);
                    a.BackColor = Color.DarkSlateGray;
                    a.Tag = "bos";
                    panel1.Controls.Add(a);
                    a.Click += A_Click;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // string harita;
            panel1.Controls.Clear();

            harita = listBox1.Text;
            string dosya_yolu = @"haritalar/"+harita;
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            if (yazi == null)
            {
                MessageBox.Show("harita boşş");
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        kutu a = new kutu();
                        a.Size = new Size(40, 40);
                        a.Location = new Point(i * 40, j * 40);
                        a.BackColor = Color.DarkSlateGray;
                        a.Tag = "bos";
                        panel1.Controls.Add(a);
                        a.Click += A_Click;
                    }
                }
            }
            while (yazi != null)
            {
                for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                        int posX = Convert.ToInt32(yazi.Split(',')[0]);
                        int posY = Convert.ToInt32(yazi.Split(',')[1]);
                        int boyutX = Convert.ToInt32(yazi.Split(',')[2]);
                        int boyutY = Convert.ToInt32(yazi.Split(',')[3]);
                        string tag = yazi.Split(',')[4];

                        kutu a = new kutu();
                        a.Location = new Point(posX, posY);
                        a.Size = new Size(boyutX, boyutY);
                        a.Tag = tag;
                        panel1.Controls.Add(a);
                        if (tag == "kutu")
                            a.BackColor = Color.Green;
                        else if (tag == "bomba")
                            a.BackColor = Color.Blue;
                        else if (tag == "mayin")
                            a.BackColor = Color.Red;
                        else if (tag == "iskele")
                            a.BackColor = Color.DarkGray;

                        else a.BackColor = Color.DarkSlateGray;
                        // MessageBox.Show(tag);
                       
                        a.Click += A_Click;
                        yazi = sw.ReadLine();
                    }
            }
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.    




        }

        private void A_Click(object sender, EventArgs e)
        {
            kutu a = (kutu)sender;
            if (rbBos.Checked)
            {
                a.Tag = "kutu";
                a.BackColor = Color.Green;

            }
            if (rbBomba.Checked)
            {
                a.Tag = "bomba";
                a.BackColor = Color.Blue;
            }
            if (rbMayin.Checked)
            {
                a.Tag = "mayin";
                a.BackColor = Color.Red;
            }
            if (rbIskele.Checked)
            {
                bool var=false;
                foreach (Control item in panel1.Controls)
                {
                    if (item is kutu) {
                        if (item.Tag.ToString() == "iskele")
                        {
                            var = true;
                            break;
                        } }
                    
                }
                if (var)
                {
                    MessageBox.Show("sadece 1 iskele yerleştirebilirsinişz");
                }
                else
                {
                    a.Tag = "iskele";
                    a.BackColor = Color.LightSeaGreen;
                }
              
            }
            // MessageBox.Show(a.Tag.ToString());

            // throw new NotImplementedException();
        }

        private void formm_Load(object sender, EventArgs e)
        {
            bosSayfa();

            haritalariGoster();
            //Form1 a = new Form1();
            //a.Show();
        }

        public void haritalariGoster()
        {
            listBox1.Items.Clear();
            string[] dosyalar = Directory.GetFiles(@"haritalar\", "*.txt");
            foreach (string harita in dosyalar)
            {
                FileInfo haritam = new FileInfo(harita);


                listBox1.Items.Add(haritam.Name);
            }


        }
        ////////public void dosyadanOku()
        ////////{
        ////////    string dosya_yolu = @"haritalar/metinbelgesi.txt";
        ////////    //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
        ////////    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
        ////////    //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
        ////////    //2.parametre dosyanın açılacağını,
        ////////    //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
        ////////    StreamReader sw = new StreamReader(fs);
        ////////    //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
        ////////    string yazi = sw.ReadLine();
            
        ////////    while (yazi != null)
        ////////    {
        ////////        int posX = Convert.ToInt32(yazi.Split(',')[0]);
        ////////        int posY = Convert.ToInt32(yazi.Split(',')[1]);
        ////////        int boyutX = Convert.ToInt32(yazi.Split(',')[2]);
        ////////        int boyutY = Convert.ToInt32(yazi.Split(',')[3]);
        ////////        string tag = yazi.Split(',')[4];

        ////////        kutu a = new kutu();
        ////////        a.Location = new Point(posX,posY);
        ////////        a.Size = new Size(boyutX,boyutY);
        ////////        a.Tag = tag;
        ////////        panel1.Controls.Add(a);
        ////////        if(tag=="kutu")
        ////////        a.BackColor = Color.Green;
        ////////       else if (tag == "bomba")
        ////////            a.BackColor = Color.Blue;
        ////////       else if (tag == "mayin")
        ////////            a.BackColor = Color.Red;
        ////////        else a.BackColor = Color.FloralWhite;
        ////////        // MessageBox.Show(tag);
        ////////        yazi = sw.ReadLine();
        ////////    }
        ////////    //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
        ////////    //Son satır okunduktan sonra okuma işlemini bitirdik
        ////////    sw.Close();
        ////////    fs.Close();
        ////////    //İşimiz bitince kullandığımız nesneleri iade ettik.
        ////////}
        public void dosyayaYaz(string dosyaAdi)
        {
            string dosya_yolu = @"haritalar/"+dosyaAdi+".txt";
            haritalariGoster();
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new System.IO.FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            foreach (Control item in panel1.Controls)
            {
                if (item is kutu)
                {
                    sw.WriteLine( item.Location.X + "," + item.Location.Y + "," + item.Size.Width + "," + item.Size.Height + "," + item.Tag.ToString());
                    //sw.WriteLine(" sdf");

                }
            }
           
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

    
            
           

           
           
        ////////}

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbHarita.Text != "")
            {
                dosyayaYaz(tbHarita.Text);
            }
            else MessageBox.Show("harita adı boş bırakılamaz!");
            
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
