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
    public partial class Create_Shift : Form
    {
        public Create_Shift()
        {
            InitializeComponent();
            textBox1.Text = "insert into shifts values('Days',\n'15:00:00.0000000', '23:59:59.0000000',\n'15:00:00.0000000', '23:59:59.0000000','15:00:00.0000000', '23:59:59.0000000','15:00:00.0000000', '23:59:59.0000000','15:00:00.0000000', '23:59:59.0000000',null, null, null, null);";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
