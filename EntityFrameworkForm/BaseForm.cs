﻿using DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkForm
{
    public partial class BaseForm : Form
    {
        public NService service;
        public BaseForm()
        {
            InitializeComponent();
            service = new NService();
        }
    }
}