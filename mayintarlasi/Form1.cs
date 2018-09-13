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
    public partial class Form1 : Form
    {
        
        Image karakterResim =mayintarlasi.Properties.Resources.deneme;

        dinamit patlama;
        DataTable t;
        string harita;
        // karakter animasyon
        bool animSag=false;
        bool animSol = false;
        bool animAlt = false;
        bool animUst = false;
        int kirk=40;
        public int level;
       
        bool okFirlat=false;
        Point okKonum;
        oyuncu oyuncum = new oyuncu();
        //karakter animasyon


        List<kutu> tumKutular=new List<kutu>();
        public Form1( int a)
        {
            level = a;
            harita =leveller()[level];
            InitializeComponent();
            
            //VERİTABANI ADI oyunum
            //tablo adı dizayn
            // grupNo pozX pozY boyutX boyutY tag

        }
       
      

        private void Form1_Load(object sender, EventArgs e)
        {
            //aglantii();
            //baslangic();
            // kutularaDegerVer();
            baslangic();
          //  resm = mayintarlasi.Properties.Resources.hediye;
            //renk = new Color();
            //kutuBoyutu = new Size(20,20);
        }
        void LevelAtla() {

            if (level < leveller().Length)
            {
                harita = leveller()[level];
                level++;
            }
            else
            {
                MessageBox.Show("TÜM LEVELLERİ BİTİRDİNİZ");

            }
        }
        public void dosyadanOku()
        {
           
            string dosya_yolu = @harita;
          
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
           
            StreamReader sw = new StreamReader(fs);
         
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                int posX = Convert.ToInt32(yazi.Split(',')[0]);
                int posY = Convert.ToInt32(yazi.Split(',')[1]);
                int boyutX = Convert.ToInt32(yazi.Split(',')[2]);
                int boyutY = Convert.ToInt32(yazi.Split(',')[3]);
                string tag = yazi.Split(',')[4];

              
                    kutu a = new kutu();
                    a.Location = new Point(posX, posY);
                    a.Size = new Size(boyutX, boyutY);
                    a.Tag =tag;
                    panel2.Controls.Add(a);

                
                yazi = sw.ReadLine();
            }
         
            sw.Close();
            fs.Close();
           
        }

      
        public void baslangic()
        {

            //karakter.Parent = pictureBox1;
            //oyuncu.bombaEkle();
            //MessageBox.Show(oyuncu.bombaSayisi.ToString());
            //foreach (Control item in panel2.Controls)
            //{
            //    if (item is kutu)
            //        panel2.Controls.Remove(item);
            //}
            tumKutular.Clear();
            panel2.Controls.Clear();
            LevelAtla();
            dosyadanOku();
           //IIIIIIIIIIIIIIIIIII
            karakter.BackgroundImage = karakterResim;
            karakter.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(karakter);
            MessageBox.Show("Level "+level.ToString());
            karakter.Location = new Point(0,0);


            foreach (Control item in panel2.Controls)
            {
               
                if (item is kutu)
                {
                   // item.Parent = pictureBox1;
                    kutu kutum = (kutu)item;
                    //if (item.Tag.ToString()!="bos")
                    //    if (r.Next(0, 5)==1 ) {
                    //    item.Tag = "mayin";

                    //}

                    if (item.Tag.ToString() == "mayin" ||
                        item.Tag.ToString() == "kutu" ||
                            item.Tag.ToString() == "bomba")
                    {
                        kutum.BackgroundImage = mayintarlasi.Properties.Resources.varil;
                        kutum.BackColor = Color.Transparent;
                        kutum.BringToFront();
                        item.Click += İtem_Click;
                    }
                    else if (item.Tag.ToString() == "iskele") {
                        kutum.BackgroundImage = null;
                        kutum.BackColor = Color.LightGreen;
                        kutum.BringToFront();
                    }
                   
                    tumKutular.Add(kutum);
                   
                    //MessageBox.Show(item.Tag.ToString());
                    //Image.FromFile(@"gorseller\kutu.png");



                }   // item.tiklandiMi = true;
               
            }


        }

       
        Random r = new Random();
      

        PictureBox okum;
        private void İtem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("tuıklandı");
            kutu gelen = (kutu)sender;
            if (gelen.Tag.ToString()!="bos") {
                if ((gelen.Top == karakter.Bottom && gelen.Left == karakter.Left) ||
                    (gelen.Bottom == karakter.Top && gelen.Left == karakter.Left) ||
                    (gelen.Top == karakter.Top && karakter.Right == gelen.Left) ||
                    (gelen.Top == karakter.Top && karakter.Left == gelen.Right) ||
                    (gelen.Top == karakter.Bottom && gelen.Left == karakter.Left + 40) ||
                    (karakter.Top == gelen.Bottom && karakter.Left == gelen.Left + 40) ||
                    (karakter.Top == gelen.Bottom && karakter.Left == gelen.Left - 40) ||
                     (gelen.Top == karakter.Bottom && gelen.Left == karakter.Left - 40)
                    ) {
                   
                    panel2.Controls.Remove(okum);
                    okFirlat = true;
                    okKonum = new Point(gelen.Location.X, gelen.Location.Y);
                    okum = new PictureBox();
                    okum.Size = new Size(20, 20);
                    okum.BackgroundImageLayout = ImageLayout.Stretch;
                    okum.BackgroundImage = mayintarlasi.Properties.Resources.deneme;


                    okum.BackColor = Color.Transparent;

                    panel2.Controls.Add(okum);
                    okum.Location = karakter.Location;
                    okum.BringToFront();

                    if (gelen.Tag.ToString() == "mayin")
                    {
                        MessageBox.Show("mayınnnnnnn");
                        level--;
                        baslangic();
                    }
                    else
                    {
                        
                            if (gelen.Tag.ToString() == "bomba") {
                                gelen.BackgroundImageLayout = ImageLayout.Stretch;
                                gelen.BackgroundImage = mayintarlasi.Properties.Resources.bomba1;
                                
                            }
                            else {
                                gelen.BackgroundImage = null;
                            etrafinaBak(gelen);
                        }

                            gelen.tiklandiMi = true;

                        


                        //gelen.tiklandiMi = true;
                        //if (gelen.tiklandiMi == true)
                        //{
                        //    etrafinaBak(gelen);
                        //    //gelen.BackgroundImage = null;

                        //}
                    }
                }

              
            }
        }

        public void etrafinaBak(kutu kutumuz)
        {
            int adet = 0;
           
            foreach (kutu item in tumKutular)
                {
                    if (kutumuz.Right == item.Left &&
                        kutumuz.Top == item.Top)
                    {
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                      
                    }
                    if (kutumuz.Left == item.Right &&
                        kutumuz.Top == item.Top)
                    {
                        //item.Text = "sol";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                    if (kutumuz.Top == item.Bottom &&
                       kutumuz.Left == item.Left)
                    {
                        //item.Text = "ust";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                    if (kutumuz.Bottom == item.Top &&
                      kutumuz.Left == item.Left)
                    {
                        //item.Text = "alt";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }

                    //////////////////////////////////////////////////
                    if (kutumuz.Top == item.Bottom &&
                      kutumuz.Left == item.Left + 40)
                    {
                        // item.Text = "sol ust";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                    if (kutumuz.Top == item.Bottom &&
                     kutumuz.Left == item.Left - 40)
                    {
                        // item.Text = "sag ust";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                    if (kutumuz.Bottom == item.Top &&
                     kutumuz.Left - 40 == item.Left)
                    {

                        //item.Text = "sol alt";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                    if (kutumuz.Bottom == item.Top &&
                    kutumuz.Left + 40 == item.Left)
                    {
                        //   item.Text = "sag alt";
                        if (item.Tag.ToString() == "mayin")
                        {
                            adet++;
                        }
                    }
                //if (adet > 0)
                //{
                //    // MessageBox.Show(kutumuz.Location.ToString());
                //    // kutumuz.Text = adet.ToString();
                //    Label deger = new Label();
                //    deger.Location = kutumuz.Location;
                //    deger.Size = kutumuz.Size;
                //    deger.Text = adet.ToString();
                //    deger.ForeColor = Color.Yellow;
                //    deger.Font = new Font("Arial", 15, FontStyle.Bold);

                //    panel2.Controls.Add(deger);
                //    deger.BringToFront();


                //}

                //kutumuz.tiklandiMi = true;
                //kutumuz.BackgroundImage = null;
                kutumuz.deger = adet;
               
                if (adet > 0 )
                {
                   
                    Label degerlb = new Label();
                    degerlb.Location = kutumuz.Location;
                    degerlb.Size = new Size(40, 40);
                    degerlb.Text = kutumuz.deger.ToString();
                    degerlb.ForeColor = Color.White;
                    degerlb.Parent = kutumuz;
                    degerlb.BackColor = Color.Transparent;
                    degerlb.Font = new Font("Arial", 25, FontStyle.Bold);
                    //gelen.BackgroundImage = mayintarlasi.Properties.Resources.kutu2;
                    panel2.Controls.Add(degerlb);
                    degerlb.BringToFront();
                    //  gelen.deger--;
                    kutumuz.tiklandiMi = true;
                    // MessageBox.Show(gelen.deger.ToString());
                }

            }
           

        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            karakter.BringToFront();
            if (e.KeyCode == Keys.D) {
                bool temiz;
                foreach (kutu item in tumKutular)
                {
                    if(karakter.Right==item.Left && karakter.Top==item.Top)
                    {
                        if (item.Tag.ToString() == "iskele")
                        {
                            MessageBox.Show("TEbrikler !!");
                            baslangic();
                        }
                        if (item.tiklandiMi || item.Tag.ToString() == "bos" || item.Tag.ToString() == "iskele")
                        {
                           
                           
                              karakter.BackgroundImage=mayintarlasi.Properties.Resources.gemiSag;
                            // karakter.Left += 40;
                            animSag = true;
                             if (item.Tag.ToString() == "bomba")
                            {
                                // MessageBox.Show("bombayı aldın");
                               // MessageBox.Show(item.Tag.ToString());
                                item.BackgroundImage = null;
                                oyuncum.ekle("bomba");
                                item.Tag = "bos";
                                etrafinaBak(item);
                                // MessageBox.Show(item.Tag.ToString());
                                //etrafinaBak(item);
                            }
                            //else if (item.Tag.ToString() == "mayin")
                            //{

                            //}

                            break;
                        }
                      

                        //  MessageBox.Show("item");
                        

                    }
                }
                
            }

            if (e.KeyCode == Keys.A)
            {
                
                bool temiz;
                foreach (kutu item in tumKutular)
                {
                    if (karakter.Left == item.Right && karakter.Top == item.Top)
                    {
                        if (item.Tag.ToString() == "iskele")
                        {
                            MessageBox.Show("TEbrikler !!");
                            baslangic();
                        }
                            
                        // MessageBox.Show("sd");
                        if (item.tiklandiMi || item.Tag.ToString()=="bos" || item.Tag.ToString() == "iskele")
                        {
                           
                             karakter.BackgroundImage = mayintarlasi.Properties.Resources.geliSol;
                            animSol = true;
                            if (item.Tag.ToString() == "bomba")
                            {
                                item.BackgroundImage = null;
                                oyuncum.ekle("bomba");
                                item.Tag = "bos";
                                etrafinaBak(item);
                            }
                            // karakter.Left -= 40;
                            break;
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.S)
            {

                bool temiz;
                foreach (kutu item in tumKutular)
                {
                    if (karakter.Bottom == item.Top && karakter.Left == item.Left)
                    {
                        if (item.Tag.ToString() == "iskele")
                        {
                            MessageBox.Show("TEbrikler !!");
                            baslangic();
                        }
                        //MessageBox.Show("sd");
                        if (item.tiklandiMi || item.Tag.ToString() == "bos" || item.Tag.ToString() == "iskele")
                        {
                            if (item.Tag.ToString() == "bomba")
                            {
                                // MessageBox.Show("bombayı aldın");
                                item.BackgroundImage = null;
                                oyuncum.ekle("bomba");
                                item.Tag = "bos";
                                etrafinaBak(item);
                            }
                            karakter.BackgroundImage = mayintarlasi.Properties.Resources.gemiAsagi;
                            animAlt = true;
                            // karakter.Top += 40;
                            break;
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.W)
            {

                bool temiz;
                foreach (kutu item in tumKutular)
                {
                    if (karakter.Top == item.Bottom && karakter.Left == item.Left)
                    {
                        if (item.Tag.ToString() == "iskele")
                        {
                            MessageBox.Show("TEbrikler !!");
                            baslangic();
                        }
                        //MessageBox.Show("sd");
                        if (item.tiklandiMi || item.Tag.ToString() == "bos" || item.Tag.ToString() == "iskele")
                        {
                            karakter.BackgroundImage = mayintarlasi.Properties.Resources.gemiUst;
                            //karakter.Top -= 40;
                            animUst = true;
                            if (item.Tag.ToString() == "bomba")
                            {
                                // MessageBox.Show("bombayı aldın");
                                item.BackgroundImage = null;
                                oyuncum.ekle("bomba");
                                item.Tag = "bos";
                                etrafinaBak(item);
                            }
                            break;
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.Space)
            {
                if (oyuncum.bombaSayisi > 0)
                {
                    patlama = new dinamit(panel2);
                    patlama.Location = karakter.Location;
                    panel2.Controls.Add(patlama);
                    patlama.BringToFront();
                    patlama.baslat();
                   
                    oyuncum.bombaSayisi--;
                  

                }
            }


            }

        private void karakterYuru_Tick(object sender, EventArgs e)
        {
            if (animSag)
            {
                if (kirk > 0)
                {
                    karakter.Left++;
                    kirk--;

                }
                else
                {
                    animSag = false;
                    kirk = 40;

                }
            }
            if (animSol)
            {
                if (kirk > 0)
                {
                    karakter.Left--;
                    kirk--;

                }
                else
                {
                    animSol = false;
                    kirk = 40;

                }
            }
            if (animUst)
            {
                if (kirk > 0)
                {
                    karakter.Top--;
                    kirk--;

                }
                else
                {
                    animUst = false;
                    kirk = 40;

                }
            }
            if (animAlt)
            {
                if (kirk > 0)
                {
                    karakter.Top++;
                    kirk--;

                }
                else
                {
                    animAlt = false;
                    kirk = 40;

                }
            }


            //ok firlat
            if(okFirlat)
            {
               
                //panel2.Controls.Remove(okum);
                if (okum.Top > okKonum.Y)
                    okum.Top--;
                else if (okum.Top < okKonum.Y)
                    okum.Top++;
                if (okum.Left < okKonum.X)
                    okum.Left++;
                if (okum.Left > okKonum.X)
                    okum.Left--;

                if(okum.Location==okKonum)
                    panel2.Controls.Remove(okum);




            }
            
                //PictureBox patlamaalani = new PictureBox();
                //patlamaalani.Location = new Point(patlama.Location.X-40,patlama.Location.Y-40);
                //patlamaalani.Size = new Size(120, 120);
                //patlamaalani.BackColor = Color.Green;
                //panel2.Controls.Add(patlamaalani);
                //patlamaalani.BringToFront();
                //patlama.sureSifirla();
                
              //  MessageBox.Show("BOM");



            
        }

        private void oyunKontrol_Tick(object sender, EventArgs e)
        {
            eldekiBomba.Text = "Eldeki bomba sayisi "+ oyuncum.bombaSayisi.ToString();
        }

        string[] leveller()
        {
            string[] dosyalar = Directory.GetFiles(@"haritalar\", "*.txt");
            return dosyalar ;



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
