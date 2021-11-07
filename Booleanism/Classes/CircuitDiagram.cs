/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
April 12, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Collections;
using System.Drawing;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of the Circuit Diagram.
    /// </summary>
    class CircuitDiagram
    {
        ArrayList list;     //Components to add in the diagram.
        string diagramTitle;

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public CircuitDiagram()
        {
            list = new ArrayList();
        }

        /// <summary>
        /// Initializes the class with specific list of components.
        /// </summary>
        /// <param name="List">List of components which will be added in the diagram.</param>
        public CircuitDiagram(ArrayList List)
        {
            list = List;
        }

        /// <summary>
        /// Initializes the class with specific list of components and title.
        /// </summary>
        /// <param name="List">List of components which will be added in the diagram.</param>
        /// <param name="DiagramTitle">Title of diagram. It will appear on the top of diagram.</param>
        public CircuitDiagram(ArrayList List, string DiagramTitle)
        {
            list = List;
            diagramTitle = DiagramTitle;
        }

        /// <summary>
        /// Gets or sets the list of components.
        /// </summary>
        public ArrayList List { get { return list; } set { list = value; } }

        /// <summary>
        /// Gets diagram as image.
        /// </summary>
        /// <param name="size">Size of diagram.</param>
        /// <returns></returns>
        public Bitmap GetDiagram(Size size)
        {
            Bitmap saveBmp = WhiteBackground(size.Width, size.Height);
            Graphics g = Graphics.FromImage(saveBmp);
            g.DrawString(diagramTitle + "\nDated: " + DateTime.Today.ToShortDateString(), new Font("Calibri", 12), Brushes.Blue, 0, 0);
            foreach (object obj in list)
            {
                Digital dig = (Digital)obj;
                Bitmap bmp = new Bitmap(dig.Width, dig.Height);
                dig.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                g.DrawImage((Image)bmp, new Point(dig.Location.X, dig.Location.Y));
                g.DrawString(dig.Title, new Font("Arial", 8, FontStyle.Italic), Brushes.Red, dig.Location.X, dig.Location.Y + dig.Height);
            }
            foreach (object obj in Wire.wireList)
            {
                Wire wire = (Wire)obj;
                g.DrawLine(new Pen(wire.Color, wire.Size), wire.StartPoint, wire.FinalPoint);
            }

            return saveBmp;
        }

        /// <summary>
        /// Gets diagram as image.
        /// </summary>
        /// <param name="width">Width of diagram.</param>
        /// <param name="height">Height of diagram.</param>
        /// <returns></returns>
        public Bitmap GetDiagram(int width, int height)
        {
            Bitmap saveBmp = WhiteBackground(width, height);
            Graphics g = Graphics.FromImage(saveBmp);
            g.DrawString(diagramTitle + "\nDated: " + DateTime.Today.ToShortDateString(), new Font("Calibri", 12), Brushes.Blue, 0, 0);
            foreach (object obj in list)
            {
                Digital dig = (Digital)obj;
                Bitmap bmp = new Bitmap(dig.Width, dig.Height);
                dig.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                g.DrawImage((Image)bmp, new Point(dig.Location.X, dig.Location.Y));
                g.DrawString(dig.Title, new Font("Arial", 8, FontStyle.Italic), Brushes.Red, dig.Location.X, dig.Location.Y + dig.Height);
            }
            foreach (object obj in Wire.wireList)
            {
                Wire wire = (Wire)obj;
                g.DrawLine(new Pen(wire.Color, wire.Size), wire.StartPoint, wire.FinalPoint);
            }

            return saveBmp;
        }

        /// <summary>
        /// Gets diagram as graphics. It is very useful for printing purpose.
        /// </summary>
        /// <param name="g">Graphics object that will contain the diagram.</param>
        public void GetDiagram(Graphics g)
        {
            g.DrawString(diagramTitle + "\nDated: " + DateTime.Today.ToShortDateString(), new Font("Calibri", 12), Brushes.Blue, 0, 0);
            foreach (object obj in list)
            {
                Digital dig = (Digital)obj;
                Bitmap bmp = new Bitmap(dig.Width, dig.Height);
                dig.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                g.DrawImage((Image)bmp, new Point(dig.Location.X, dig.Location.Y));
                g.DrawString(dig.Title, new Font("Arial", 8, FontStyle.Italic), Brushes.Red, dig.Location.X, dig.Location.Y + dig.Height);
            }

            foreach (object obj in Wire.wireList)
            {
                Wire wire = (Wire)obj;
                g.DrawLine(new Pen(wire.Color,wire.Size), wire.StartPoint, wire.FinalPoint);
            }
        }

        private Bitmap WhiteBackground(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bmp.SetPixel(j, i, Color.White);
                }
            }
            return bmp;
        }
    }
}
