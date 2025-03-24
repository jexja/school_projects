using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation4_JexJaacob
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void BtnLocalPhoneNumbers_Click(object sender, EventArgs e)
        {
            LocalPhonesForm local = new LocalPhonesForm();
            local.ShowDialog();
        }

        private void BtnImportedPhoneNumbers_Click(object sender, EventArgs e)
        {
            ImportedPhonesForm imported = new ImportedPhonesForm();
            imported.ShowDialog();
        }

        private void BtnOnlinePhoneNumbers_Click(object sender, EventArgs e)
        {
            OnlinePhonesForm online = new OnlinePhonesForm();
            online.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
