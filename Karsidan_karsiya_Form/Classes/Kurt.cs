namespace Karsidan_karsiya_Form.Classes
{
    public class Kurt:Hayvan
    {
        public Kurt()
        {
            BeslenmeTuru = BeslenmeTuruConst.BeslenmeTuru.Etcil;
        }
        public override bool YemeyiDene(Canli c, out string sonuc)
        {
            bool yedi = c is Kuzu;
            sonuc = yedi ? $"Kurt {c.GetType().Name} 'yu Yedi":string.Empty;
            return yedi;
        }
    }
}
