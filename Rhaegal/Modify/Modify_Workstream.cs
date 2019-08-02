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
    public partial class Modify_Workstream : Form
    {
        SQLmethods m = new SQLmethods();
        public Modify_Workstream()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopWorkStream());
            comboBox2.Items.AddRange(m.PopAlias());
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Workstream = comboBox1.Text;
            string Alias = comboBox2.Text;
            m.ModifyWorkstream(Workstream, Alias);
        }
    }
}
