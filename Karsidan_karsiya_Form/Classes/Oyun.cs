using System;
using System.Windows.Forms;

namespace Karsidan_karsiya_Form.Classes
{
    public class Oyun : IOyun
    {
        const string gameOver = "Kaybettiniz Tekrar Deneyiniz";
        const string gameWin = "Tebrikler Kazandınız";
        public string Durum(bool sonuc)
        {
            if (sonuc)
            {
                return $"{gameOver}\n";
       
            }
            else
            {
                return $"{gameWin}\n";
          
            }
        }

        public void OyunaBasla()
        {
            StaticLists.OyunaBaslat();
        }

    }
}
