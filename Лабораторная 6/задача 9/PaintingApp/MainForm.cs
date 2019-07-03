using System;
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
            p.right();
            p.right();

            int q;
            q = 1;
            p.startLine();
            p.right();
            while (q <= 5)
            {
                p.down();
                q = q + 1;
            }
            
            p.right();
            p.right();
            p.right();
            p.right();
            p.right();
            p.right();
            p.right();
            p.up();
            p.up();
            p.right();
            p.down();
            p.down();
            p.down();
            p.left();
            p.down();
            p.down();
            p.down();
            p.down();
            p.down();
            p.down();
            p.down();
            p.left();
            p.left();
            p.up();
            p.right();
            p.up();
            p.up();
            p.up();
            p.left();
            p.left();
            p.left();
            p.left();
            p.left();
            p.left();
            p.down();
            p.down();
            p.down();
            p.down();
            p.left();
            p.left();
            p.up();
            p.right();
            p.up();
            p.up();
            p.up();
            p.left();
            p.up();
            p.up();
            p.up();
            p.up();
            p.up();
            p.left();
            p.left();
            p.left();
            p.up();
            p.up();
            p.right();
            p.right();
            p.up();
            p.right();
            p.right();
            p.up();
            p.endLine();
        }
    }
}
