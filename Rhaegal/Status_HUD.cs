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
    public partial class Status_HUD : Form
    {
        readonly SQLmethods m = new SQLmethods();

        public Status_HUD()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string[] newBoard = m.PostToBoard();

            //0 = liveSite, 1 = Networking, 2 = infra, 3 = CXP
            liveSiteBox.Text = newBoard[0];
            networkingBox.Text = newBoard[1];
            infraBox.Text = newBoard[2];
            cxpBox.Text = newBoard[3];
        }

        private void JfdskljfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OperatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Operator c_o = new Create_Operator();

            c_o.ShowDialog();
        }
    }
}
