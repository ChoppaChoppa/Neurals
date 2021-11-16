using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurlas.CommunicationWithNeurons
{
    class DrawingNeuronsLines
    {
        public DrawingNeuronsLines()
        {

        }

        public void Draw(Graphics g, PointF neuronPoint, PointF centerPoint)
        {
            g.DrawLine(new Pen(Color.FromArgb(211, 153, 53)), neuronPoint, centerPoint);
        }


    }
}
