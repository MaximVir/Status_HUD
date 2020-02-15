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
        readonly SQLmethods m = new SQLmethods();

        public Create_Operator()
        {
            InitializeComponent();
            comboBox2.Items.AddRange(m.PopWorkStream());
            comboBox3.Items.AddRange(m.PopShift());
            comboBox4.Items.AddRange(m.PopLocation());
            label6.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Create_Operator_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String Alias = textBox1.Text;
            String Workstream = comboBox2.Text;
            String Shift = comboBox3.Text;
            String Location = comboBox4.Text;
            label6.Text = Alias;
            m.CreateOperator(Alias, Workstream, Location, Shift);
            label6.Visible = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
