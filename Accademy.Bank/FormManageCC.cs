﻿using Accademy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Bank
{
    public partial class FormManageCC : Form
    {
        public FormManageCC(string numconto)
        {
            InitializeComponent();
            this.lbl_numconto.Text = numconto;

        }
    }
}
