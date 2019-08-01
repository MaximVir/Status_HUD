using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rhaegal
{
    public partial class Create_Operator : Form
    {

        SQLmethods m = new SQLmethods();
        public Create_Operator()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] List = m.PopAlias();
            comboBox1.Items.AddRange(List);
        }

        private void Create_Operator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Operators' table. You can move, or remove it, as needed.
            this.operatorsTableAdapter.Fill(this.databaseDataSet.Operators);

        }
    }
}
