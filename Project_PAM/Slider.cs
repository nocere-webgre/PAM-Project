using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_PAM
{
    public class Slider
    {
        private Image[] images = new Image[] {
            Properties.Resources.Algorytmy_tekstowe___minimizery___v12,
            Properties.Resources.Algorytmy_tekstowe___wyszukiwanie___v12,
            Properties.Resources.Algorytmy_tekstowe_v12,
            Properties.Resources.IO_1,
            Properties.Resources.IO_2,
            Properties.Resources.IO_3,
            Properties.Resources.IO_4,
            Properties.Resources.IO_5,
            Properties.Resources.IO_6,
            Properties.Resources.monografia,
            Properties.Resources.obszary_badan_med1,
            Properties.Resources.slajd1,
            Properties.Resources.slajd2_zatrudnienie,
            Properties.Resources.slajdy_biol1_ROS,
            Properties.Resources.slajdy_biol2_OCT,
            Properties.Resources.slajdy_biotechnol_1_,
            Properties.Resources.slajdy_grafika1,
            Properties.Resources.slajdy_grafika2,
            Properties.Resources.slajdy_grafika3,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK1,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK2,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK3,
            Properties.Resources.Tomo1,
            Properties.Resources.Tomo2,
            Properties.Resources.Tomo3,
            Properties.Resources.Tomo4
        };

        public Image[] Images()
        {
            return images;
        }

        public Image LoadPrevImage(int i)
        {
            if (i == 0) i = 25;
            return images[i];

        }

        //funkcja wrzuca nstępne zdjęcie
        public Image LoadNextImage(int i)
        {            
            if (i >= (images.Length-2))
            {
                return images[0];
            }
            return images[i];

        }
    }

    
}
