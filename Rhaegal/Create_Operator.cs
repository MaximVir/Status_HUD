﻿using System;
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

        SQLmethods m = new SQLmethods();
        public Create_Operator()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopAlias());
            comboBox2.Items.AddRange(m.PopWorkStream());
            comboBox3.Items.AddRange(m.PopShift());
            comboBox4.Items.AddRange(m.PopLocation());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
            
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
    }
}
