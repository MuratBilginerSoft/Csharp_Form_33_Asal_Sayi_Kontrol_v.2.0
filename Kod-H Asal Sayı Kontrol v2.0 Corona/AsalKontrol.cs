using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Asal_Sayı_Kontrol_v2._0_Corona
{
    public class AsalKontrol
    {
        public void AsalBul(int x,PictureBox Picturebox)
        {

            if (x==1)
            {
                Picturebox.BackgroundImage=Image.FromFile("Mark.png");
            }

            else if (x==2)
            {
                Picturebox.BackgroundImage = Image.FromFile("Ok.png");
            }

            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        Picturebox.BackgroundImage = Image.FromFile("Mark.png");
                        break;
                    }

                    else
                    {
                        Picturebox.BackgroundImage = Image.FromFile("Ok.png");
                    }
                }   
            }
        }


    }
}
