using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rhaegal
{
    public partial class Main : Form
    {
        readonly SQLmethods m = new SQLmethods();

        public Main()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string Status, Alias;
            Alias = "Rhaegal";
            Status = "Idle";

            m.SetStatus(Status, Alias);
        }
    }
}
