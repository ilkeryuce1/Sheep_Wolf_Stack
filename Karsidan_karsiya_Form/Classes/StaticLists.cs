using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Karsidan_karsiya_Form.Classes
{
    static class StaticLists
    {
        public static List<Canli> Anoktasındakiler = new List<Canli>();
        public static List<Canli> Bnoktasındakiler = new List<Canli>();
        public static void LstAdanBye(Canli canli)
        {
            Gecis(canli);
            Bnoktasındakiler.Add(canli);
            Anoktasındakiler.Remove(canli);
        }
        public static void LstBdenAya(Canli canli)
        {
            Gecis(canli);
            Anoktasındakiler.Add(canli);
            Bnoktasındakiler.Remove(canli);
        }

        static void Gecis(Canli canli)
        {
            //MessageBox.Show($"{canli.GetType().Name} Karşıya Geçiyor");
            //Thread.Sleep(2000);
            //MessageBox.Show($"{canli.GetType().Name} Başarıyla Karşıya Geçti\n");
        }

        //public static bool YemeyeCalis(List<Canli> liste)
        //{
        //    Hayvan etcil = liste.FirstOrDefault(n => n is Hayvan && ((Hayvan)n).BeslenmeTuru == BeslenmeTuruConst.BeslenmeTuru.Etcil) as Hayvan;
        //    Hayvan otcul = liste.FirstOrDefault(n => n is Hayvan && ((Hayvan)n).BeslenmeTuru == BeslenmeTuruConst.BeslenmeTuru.Otcul) as Hayvan;
        //    Bitki bitki = liste.FirstOrDefault(n => n is Bitki) as Bitki;

        //    return (etcil != null && otcul != null) || (otcul != null && bitki != null);
        //}
        public static void OyunaBaslat()
        {
            Bnoktasındakiler.Clear();
            Anoktasındakiler.Clear();
            Kuzu kuzu = new Kuzu();
            Kurt kurt = new Kurt();
            Ot ot = new Ot();
            Anoktasındakiler.Add(kuzu);
            Anoktasındakiler.Add(kurt);
            Anoktasındakiler.Add(ot);
        }
    }
}
