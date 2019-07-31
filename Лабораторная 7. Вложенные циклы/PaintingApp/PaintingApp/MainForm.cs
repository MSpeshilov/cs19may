﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PenTool p = PenTool.prepare(this);
            p.down();
            p.right();
            p.right();
            p.right();
            p.startLine();
            p.right();
            p.down();
            
            int q = 1;
            while (q <= 4)
            {
                p.down();

                q = q + 1;
            }


            p.endLine();
        }
    }
}
