using static Karsidan_karsiya_Form.Classes.BeslenmeTuruConst;

namespace Karsidan_karsiya_Form.Classes
{
    public class Hayvan : Canli
    {
        public BeslenmeTuru BeslenmeTuru { get; set; }
        public override bool YemeyiDene(Canli c, out string sonuc)
        {
            throw new System.NotImplementedException();
        }
    }
}
