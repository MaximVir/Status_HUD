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
        public string Alias;

        public Main()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string Status;
            Status = "Idle";

            m.SetStatus(Status, Alias);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string Status;
            Status = "In-Flight";
            m.SetStatus(Status, Alias);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string Status;
            Status = "Lunch";
            m.SetStatus(Status, Alias);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string Status;
            Status = "AFK";
            m.SetStatus(Status, Alias);
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string Status;
            Status = "Training";
            m.SetStatus(Status, Alias);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = button1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Alias = textBox1.Text;
            int count = m.CheckExistance(Alias);

            if (count > 0)
            {
                groupBox1.Visible = true;
                textBox1.Enabled = false;
                button1.Enabled = false;
                label1.Text = Alias;

            }
            else { MessageBox.Show("gd"); }
        }

        public void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        { 

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string newBoard = m.PostToBoard();
            richTextBox1.Text = newBoard;
        }
    }
}
