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
    public partial class Modify_Shift : Form
    {
        SQLmethods m = new SQLmethods();
        public Modify_Shift()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopAlias());
            comboBox2.Items.AddRange(m.PopShift());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Alias = comboBox1.Text;
            string Shift = comboBox2.Text;
            m.ModifyShift(Shift, Alias);
        }
    }
}
