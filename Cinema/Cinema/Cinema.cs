using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cinema
{

    /*

     */

    class Cinema
    {
        private bool[,] seats = new bool[30, 15];
        private const int size = 16;
        private const int space = 2;

        public void Draw(Graphics g)
        {
            Pen redPen = new Pen(Color.Red, 1);          // Create a pen
          // Point startPoint = new Point(YourStorage.xStart, YourStorage.YequalBoth);             // Define the start and end points of the line
          // Point endPoint = new Point(1250, YourStorage.YequalBoth);
         //  g.DrawLine(redPen, startPoint, endPoint);                 // Draw the line
           
            Pen blackPen = new Pen(Color.Black, 1);          // Create a pen
          //  Point startPoint2 = new Point(YourStorage.xStart, YourStorage.Yaxis);
          //  Point endPoint2 = new Point(YourStorage.xStart, 750);
          //  g.DrawLine(blackPen, startPoint2, endPoint2);                 // Draw the line
           
            Pen greenPen = new Pen(Color.Green, 1);          // Create a pen
            for (int i = 0; i < 1250; i++)
            {
                i=i+19;
         //   Point startPoint3 = new Point(YourStorage.xStart+i, YourStorage.Yaxis);
           // Point endPoint3 = new Point(YourStorage.xStart+i, 20);
            //g.DrawLine(greenPen, startPoint3, endPoint3);                 // Draw the line
            }
            string drawString = "10";             // Define the text to draw
            Font drawFont = new Font("Arial", 8);                 // Create a font
             // SolidBrush drawBrush = new SolidBrush(Color.Black);               // Create a brush
            SolidBrush drawBrush = new SolidBrush(Color.Blue);               // Create a brush
            float x = 0.0F; float y = 5.0F;    // Set the position to draw the text
            g.DrawString(drawString, drawFont, drawBrush, x, y);                 // Draw the text

            string maxdrawString = "1250";             // Define the text to draw
            //SolidBrush drawBrush = new SolidBrush(Color.Blue);               // Create a brush
            float x2 = 1220.0F;         float y2 = 5.0F;    // Set the position to draw the text
            g.DrawString(maxdrawString, drawFont, drawBrush, x2, y2);                 // Draw the text

            drawFont.Dispose();     drawBrush.Dispose();  // Dispose of the objects


            //e.Graphics.DrawLine(blackPen, startPoint, endPoint);
            //  Brush brush;
            //  for (int j = 0; j < seats.GetLength(1); j++)
            //{
            //  for (int i = 0; i < seats.GetLength(0); i++)
            //{
            //  if (seats[i, j])
            //    brush = Brushes.Red;
            //         else
            //           brush = Brushes.Green;
            //     g.FillRectangle(brush, i * (size + space), j * (size + space), size, size);
            //  }
            //
            Pen yellowPen = new Pen(Color.Yellow, 1);          // Create a pen
         
              //  Point startPoint9 = new Point(YourStorage.xStart, YourStorage.currentY);             // Define the start and end points of the
                //string wtString = YourStorage.tempWT;
              //  int number = int.Parse(wtString);
                //Point endPoint9 = new Point(number, YourStorage.currentY);
          //      g.DrawLine(yellowPen, startPoint9, endPoint9);                 // Draw the line      
                                                                               //  for (int ij = 0; ij < 2147483647; ij++)
            //
              //  YourStorage.currentY = YourStorage.currentY + 5;
           // }

           
        }
        public void plotDraw(Graphics g)
        {
           
           
//number = number + 10;
//            wtString = number.ToString();
        //    WtBox.Text = wtString;
//YourStorage.tempWT = wtString;
      //      YourStorage.tempWT = WtBox.text;
            //    wtString;
            
            // g.DrawLine(redPen, startPoint, endPoint);                 // Draw the line
        
        }

    }
}
