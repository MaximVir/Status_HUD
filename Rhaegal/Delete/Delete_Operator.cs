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
    public partial class Delete_Operator : Form
    {
        SQLmethods m = new SQLmethods();
        public Delete_Operator()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(m.PopAlias());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Alias = comboBox1.Text;
            m.DeleteOperator(Alias);
        }
    }
}
