﻿using perfectTiming.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perfectTiming.View
{
    public partial class frmActualTimings : MetroFramework.Forms.MetroForm
    {
        public frmActualTimings()
        {
            AppController app = AppController.Instance;
            InitializeComponent();
        }
    }
}
