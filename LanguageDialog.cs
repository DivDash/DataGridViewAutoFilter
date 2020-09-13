using System;
using System.Windows.Forms;

namespace DataGridViewAutoFilter
{
    public partial class LanguageDialog : Form
    {
        public LanguageDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
