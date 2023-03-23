using DevExpress.Data.Filtering.Helpers;
using System;
using System.Linq;

namespace Karsidan_karsiya_Form
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {

        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textEdit1.Text))
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }

        }

    }
}
