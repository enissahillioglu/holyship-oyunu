using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    class dinamit : PictureBox
    {
        public int kalanSure=3;
       public bool patladi = false;
       public Panel panell;
        PictureBox patlamaalani= new PictureBox();
        Form1 form=new Form1(0) ;
        Timer a = new Timer();
        int indir = 3;
        public dinamit(Panel a) {
            this.panell = a;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = mayintarlasi.Properties.Resources.patlayacak;
            this.Size = new Size(40, 40);
            
        }
        public void sureSifirla()
        {
            a.Enabled = false;
            this.kalanSure = 3;
            patladi = false;
            indir = 3;
            

        }
        public void baslat()
        {
            
               
                a.Interval = 1000;
                a.Tick += A_Tick;
            a.Enabled = true;
            

        }

        public void A_Tick(object sender, EventArgs e)
        {
            if (this.kalanSure > 0)
            {

                this.kalanSure--;

            }
            else {

               // this.patladi = true;
              
                patlamaalani.Location = new Point(this.Location.X - 40, this.Location.Y - 40);
                patlamaalani.Size = new Size(120, 120);
                patlamaalani.BackgroundImage = mayintarlasi.Properties.Resources.deneme;
                patlamaalani.BackgroundImageLayout = ImageLayout.Stretch;
                this.panell.Controls.Add(patlamaalani);
                patlamaalani.BringToFront();
               
                if (indir > 0)
                    indir--;
                else
                {
                    panell.Controls.Remove(patlamaalani);
                    this.BackgroundImage = null;
                    foreach (Control item in panell.Controls)
                    {

                        if (item is kutu)
                        {
                            if (item.Tag.ToString() == "mayin" ||
                        item.Tag.ToString() == "kutu" ||
                            item.Tag.ToString() == "bomba" ||
                            item.Tag.ToString() == "karakter")
                            {
                                kutu kutum = (kutu)item;
                                if ((item.Left <= patlamaalani.Right-40) &&
                                     (item.Left >= patlamaalani.Left) && item.Top == patlamaalani.Top
                                     )
                                {



                                    form.etrafinaBak(kutum);
                                    kutum.tiklandiMi = true;
                                    //kutum.Tag = "bos";
                                    kutum.BackgroundImage = null;
                                   

                                }
                                if ((item.Left <= patlamaalani.Right - 40) &&
                                     (item.Left >= patlamaalani.Left) && item.Top-40 == patlamaalani.Top
                                     )
                                {

                                    form.etrafinaBak(kutum);
                                    kutum.tiklandiMi = true;
                                    //kutum.Tag = "bos";
                                    kutum.BackgroundImage = null;

                                }
                                if ((item.Left <= patlamaalani.Right - 40) &&
                                     (item.Left >= patlamaalani.Left) && item.Top - 80 == patlamaalani.Top
                                     )
                                {

                                    form.etrafinaBak(kutum);
                                    kutum.tiklandiMi = true;
                                    //kutum.Tag = "bos";
                                    kutum.BackgroundImage = null;

                                }
                               


                            }
                        }
                     
                    }         
                 
                    this.sureSifirla();
                    
                }
               
             
            }

            
        }
        
    }
}
