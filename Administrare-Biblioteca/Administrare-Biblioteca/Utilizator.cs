using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrare_Biblioteca
{
    class Utilizator:Control
    {
        public Utilizator()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(new SolidBrush(Color.Black));
            Rectangle rect = new Rectangle(15, 15, 10, 10);
            g.DrawString("Report !", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), new SolidBrush(Color.Black), new Point(rect.X - 5, rect.Y - 12));
        }
    }
}
