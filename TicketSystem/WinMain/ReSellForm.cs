﻿using Common;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMain
{
    public partial class ReSellForm : MaterialForm
    {
        public ReSellForm()
        {
            InitializeComponent();
            Skin.SetSkin(this);
        }
    }
}
