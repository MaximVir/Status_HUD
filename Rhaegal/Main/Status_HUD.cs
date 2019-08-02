using Rhaegal.Modify;
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

        private void OperatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Operator c_o = new Create_Operator();

            c_o.ShowDialog();
        }

        private void ShiftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_Shift c_s = new Create_Shift();
            c_s.ShowDialog();
        }

        private void OperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Operator d_o = new Delete_Operator();
            d_o.ShowDialog();
        }

        private void AliasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify_Alias m_f = new Modify_Alias();
            m_f.ShowDialog();
        }

        private void WorkstreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify_Workstream m_w = new Modify_Workstream();
            m_w.ShowDialog();
        }

        private void LocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify_Location m_l = new Modify_Location();
            m_l.ShowDialog();
        }

        private void ShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify_Shift m_s = new Modify_Shift();
            m_s.ShowDialog();
        }
    }
}
