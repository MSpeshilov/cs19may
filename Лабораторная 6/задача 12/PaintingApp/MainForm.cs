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
            int q = 1;
            while (q <= 5)
            {
                p.right();
                q = q + 1;
            }
            p.startLine();
            q = 1;
            while (q <= 5)
            {
                p.right();
                p.down();
                q = q + 1;
            }
            p.left();
            q = 1;
            while (q <= 4)
            {
                p.down();
                q = q + 1;
            }
            p.left();
            q = 1;
            while (q <= 3)
            {
                p.up();
                q = q + 1;
            }
            p.left();
            p.left();
            p.down();
            p.down();
            p.right();
            p.right();
            p.down();
            q = 1;
            while (q <= 3)
            {
                p.left();
                q = q + 1;
            }
            q = 1;
            while (q <= 3)
            {
                p.up();
                q = q + 1;
            }
            p.left();
            p.left();
            q = 1;
            while (q <= 3)
            {
                p.down();
                q = q + 1;
            }
            p.right();
            p.right();
            q = 1;
            while (q <= 3)
            {
                p.left();
                q = q + 1;
            }
            q = 1;
            while (q <= 4)
            {
                p.up();
                q = q + 1;
            }
            p.left();
            q = 1;
            while (q <= 4)
            {
                p.up();
                p.right();
                q = q + 1;
            }
            p.up();

            p.endLine();
        }
    }
}
