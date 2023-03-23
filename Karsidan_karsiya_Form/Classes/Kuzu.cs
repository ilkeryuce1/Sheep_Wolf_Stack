namespace Karsidan_karsiya_Form.Classes
{
    public class Kuzu : Hayvan
    {
        public Kuzu()
        {
            BeslenmeTuru = BeslenmeTuruConst.BeslenmeTuru.Otcul;
        }
        public override bool YemeyiDene(Canli c, out string sonuc)
        {
            bool yedi = c is Bitki;
            sonuc = yedi ? $"Kuzu {c.GetType().Name} 'u Yedi" : string.Empty;
            return yedi;
        }
    }
}
