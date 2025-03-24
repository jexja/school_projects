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
    public partial class LocalPhonesForm : Form
    {
        public LocalPhonesForm()
        {
            InitializeComponent();
        }

        private void phoneListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonesDbDataSet);

        }

        private void LocalPhonesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonesDbDataSet.PhoneList' table. You can move, or remove it, as needed.
            this.phoneListTableAdapter.Fill(this.phonesDbDataSet.PhoneList);

        }

        // I accidently double clicked the text box before I had renamed it. Rather than go through all the trouble to fix it
        // I just left it as the default name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.phoneListTableAdapter.FillByFirstName(this.phonesDbDataSet.PhoneList, textBox1.Text);
        }

        private void BtnSortByLastName_Click(object sender, EventArgs e)
        {
            this.phoneListTableAdapter.SortByLastNameDesc(this.phonesDbDataSet.PhoneList);
        }


        private void BtnAgeOver30_Click(object sender, EventArgs e)
        {
            // Connect to our table adapter (middleman between our tables and C# code)
            // Call the method we defined, run the SQL querey against our own DB
            // fill the datagridview
            this.phoneListTableAdapter.FillByAgeOver30(this.phonesDbDataSet.PhoneList);
        }

        private void BtnAverageAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The average age is {this.phoneListTableAdapter.AverageAge()}");
        }

        // Clears the screen and empties the text box/datagridview
        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.phoneListTableAdapter.Fill(this.phonesDbDataSet.PhoneList);
        }
    }
}
