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
    public partial class OnlinePhonesForm : Form
    {
        public OnlinePhonesForm()
        {
            InitializeComponent();
        }

        private void OnlinePhonesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
            this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable);

        }

        private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uVUPhoneNumsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }
    }
}
