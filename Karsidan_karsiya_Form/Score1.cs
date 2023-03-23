using System.Collections.Generic;
using System.Linq;

namespace Karsidan_karsiya_Form
{
    public partial class Score1 : DevExpress.XtraEditors.XtraForm
    {
        public Dictionary<string, int> adSkor = new Dictionary<string, int>();
        public Score1()
        {
            InitializeComponent();
        }
        private void Score1_Load(object sender, System.EventArgs e)
        {
           
            RefreshList();
        }
        public void RefreshList()
        {
            this.gamesTableAdapter.Fill( this.kurtKuzuDataSet.Games );
            gridControl1.DataSource = this.gamesTableAdapter;
       

        }

    }
}
