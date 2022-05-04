using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_EspagnolTrad
{
    public partial class BtnExitEtMinus : UserControl
    {
        public BtnExitEtMinus()
        {
            InitializeComponent();
        }

        private void BtnExitEtMinus_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnRéduire_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
        }
    }
}
