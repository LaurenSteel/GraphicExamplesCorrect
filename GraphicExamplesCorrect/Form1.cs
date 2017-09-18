using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamplesCorrect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();

            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Tahoma", 60, FontStyle.Bold);


            formGraphics.Clear(Color.SaddleBrown);
            formGraphics.DrawRectangle(drawPen, 100, 90, 300, 200);
            formGraphics.FillRectangle(drawBrush, 100, 90, 300, 200);

   
            drawBrush = new SolidBrush(Color.Black); 
            formGraphics.DrawString("n", drawFont, drawBrush, 130, 125);

            drawFont = new Font("DejaVuSerif", 50, FontStyle.Bold);
            drawBrush = new SolidBrush(Color.Red);
            formGraphics.DrawString("utella", drawFont, drawBrush, 180, 143);
        }
    }
}
