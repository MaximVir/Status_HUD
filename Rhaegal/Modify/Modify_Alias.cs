using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rhaegal.Modify
{
    public partial class Modify_Alias : Form
    {
        SQLmethods m = new SQLmethods();
        public Modify_Alias()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopAlias());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string OldAlias = comboBox1.Text;
            string NewAlias = textBox1.Text;

            m.ModifyAlias(OldAlias, NewAlias);
        }
    }
}
