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
            p.down();
            p.right();
            p.startLine();

            p.right();
            p.down();
            p.right();
            p.up();
            p.right();
            p.down();
            p.down();
            int q = 1;
            while (q <= 5)
            {
                p.right();
                q = q + 1;
            }
            p.up();
            p.up();
            p.left();
            p.up();
            p.right();
            p.right();
            q = 1;
            while (q <= 6)
            {
                p.down();
                q = q + 1;
            }q = 1;
            while (q <= 4)
            {
                p.down();
                p.down();
                p.down();
                p.left();
                p.up();
                p.up();
                p.up();
                p.left();
                q = q + 1;
            }
            p.up();
            p.up();
            p.left();
            q = 1;
            while (q <= 3)
            {
                p.up();
                q = q + 1;
            }

            p.endLine();
        }
    }
}
