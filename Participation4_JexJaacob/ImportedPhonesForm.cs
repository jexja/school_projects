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
    public partial class ImportedPhonesForm : Form
    {
        public ImportedPhonesForm()
        {
            InitializeComponent();
        }

        private void ImportedPhonesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uVUPhoneNumsDataSet.UvuPhoneDirectory' table. You can move, or remove it, as needed.
            this.uvuPhoneDirectoryTableAdapter.Fill(this.uVUPhoneNumsDataSet.UvuPhoneDirectory);

        }

        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsDataSet);

        }
    }
}
