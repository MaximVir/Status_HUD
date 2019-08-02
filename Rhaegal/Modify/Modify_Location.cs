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
    public partial class Modify_Location : Form
    {
        SQLmethods m = new SQLmethods();
        public Modify_Location()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopAlias());
            comboBox2.Items.AddRange(m.PopLocation());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Alias = comboBox1.Text;
            string Location = comboBox2.Text;
            m.ModifyLocation(Location, Alias);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
