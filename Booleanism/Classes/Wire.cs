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
    /// Gives the features of a wire.
    /// </summary>
    public sealed class Wire
    {

        private String Name;
        private Point iniPoint;     //Wire starting from
        private Point finalPoint;   //Wire ending from
        private Color color;        //Color of wire
        public static ArrayList wireList = new ArrayList();     //Total wires initializing from this class.
        static ArrayList digList = new ArrayList();             //To avoid double occurrences of same wire.
        static ArrayList pinList = new ArrayList();
        static int num = 0;
        static Graphics g;          //Graphics in which wire to be drawn.
        Digital dig;                //Digital's instant to which wire will be linked.
        int pinNum;                 //Pin of Digital's instant to which wire will be linked.
        float size = 2.0f;

        #region Constructors
        /// <summary>
        /// Initializes the class with default values.Graphics property must be set after otherwise NullPointerException will occur.
        /// </summary>
        public Wire()
        {
            iniPoint = new Point(0, 0);
            finalPoint = new Point(0, 0);
            Name = "Wire" + num.ToString(); num++;
            dig = new And();
            wireList.Add(this);
        }

        /// <summary>
        /// Initializes the class with specific points.Graphics property must be set after otherwise NullPointerException will occur.
        /// </summary>
        /// <param name="startPoint">Points where from wire will be started.</param>
        /// <param name="endPoint">Points to which wire will be ended.</param>
        public Wire(Point startPoint, Point endPoint)
        {
            iniPoint = startPoint;
            finalPoint = endPoint;
            SetWireColor();
            Name = "Wire" + num.ToString(); num++;
            dig = new And();
            wireList.Add(this);
        }

        /// <summary>
        /// Initializes the class with specific coordinates.Graphics property must be set after otherwise NullPointerException will occur.
        /// </summary>
        /// <param name="x1">x-coordinate of the point from where the wire will be started.</param>
        /// <param name="y1">y-coordinate of the point from where the wire will be started.</param>
        /// <param name="x2">x-coordinate of the point to which the wire will be ended.</param>
        /// <param name="y2">y-coordinate of the point to which the wire will be ended.</param>
        public Wire(int x1, int y1, int x2, int y2)
        {
            iniPoint.X = x1;
            iniPoint.Y = y1;
            finalPoint.X = x2;
            finalPoint.Y = y2;
            Name = "Wire" + num.ToString(); num++;
            dig = new And();
            wireList.Add(this);
        }

        /// <summary>
        /// Initializes the class with specific Digitals instants, graphics and pin number. Graphics property must be set after otherwise NullPointerException will occur.
        /// </summary>
        /// <param name="dig1">Digital's instant from where wire will be started.</param>
        /// <param name="dig2">Digital's instant to which wire will be ended.</param>
        /// <param name="pinNum">Specific pin of Digital's instant to which wire will be ended.</param>
        public Wire(Digital dig1, Digital dig2, int pinNum)
        {
            Name = "Wire" + num.ToString(); num++;
            dig = dig2;
            digList.Add(dig);
            wireList.Add(this);
            this.pinNum = pinNum;
            pinList.Add(pinNum);
            iniPoint = new Point(dig1.Location.X + dig1.Width, dig1.Location.Y + 42);
            finalPoint = new Point(dig2.Location.X, dig2.Location.Y + YCoordinate(pinNum));
        }

        /// <summary>
        /// Initializes the class with specific Digitals instants, graphics and pin number.
        /// </summary>
        /// <param name="dig1">Digital's instant from where wire will be started.</param>
        /// <param name="dig2">Digital's instant to which wire will be ended.</param>
        /// <param name="graphics">Graphics in which wire will be drawn.</param>
        /// <param name="pinNum">Specific pin of Digital's instant to which wire will be ended.</param>
        public Wire(Digital dig1,Digital dig2, Graphics graphics, int pinNum)
        {
            g = graphics;
            Name = "Wire" + num.ToString(); num++;
            dig = dig2;
            digList.Add(dig);
            SetWireColor();
            wireList.Add(this);
            this.pinNum = pinNum;
            pinList.Add(pinNum);
            iniPoint = new Point(dig1.Location.X + dig1.Width, dig1.Location.Y + 42);
            finalPoint = new Point(dig2.Location.X, dig2.Location.Y + YCoordinate(pinNum));
        }

        /// <summary>
        /// Initializes the class with specific Digitals instants, graphics and pin number.
        /// </summary>
        /// <param name="dig1">Digital's instant from where wire will be started.</param>
        /// <param name="dig2">Digital's instant to which wire will be ended.</param>
        /// <param name="graphics">Graphics in which wire will be drawn.</param>
        /// <param name="pinNum">Specific pin of Digital's instant to which wire will be ended.</param>
        /// <param name="wireSize">Size of wire.</param>
        public Wire(Digital dig1, Digital dig2, Graphics graphics, int pinNum, float wireSize)
        {
            g = graphics;
            Name = "Wire" + num.ToString(); num++;
            dig = dig2;
            size = wireSize;
            digList.Add(dig);
            SetWireColor();
            wireList.Add(this);
            this.pinNum = pinNum;
            pinList.Add(pinNum);
            iniPoint = new Point(dig1.Location.X + dig1.Width, dig1.Location.Y + 42);
            finalPoint = new Point(dig2.Location.X, dig2.Location.Y + YCoordinate(pinNum));
        }

        #endregion

        /// <summary>
        /// Gets or sets the starting point from where the wire will be started.
        /// </summary>
        public Point StartPoint { get { return iniPoint; } set {iniPoint = value; } }

        /// <summary>
        /// Gets or sets the ending point to which the wire will be ended.
        /// </summary>
        public Point FinalPoint { get { return finalPoint; } set { finalPoint = value; } }

        /// <summary>
        /// Gets or sets the graphics in which the wire will be drawn.
        /// </summary>
        public Graphics Graphics { get {return g; } set {g = value; } }

        /// <summary>
        /// Gets or sets the size of wire.
        /// </summary>
        public float Size { get {return size; } set {size = value; } }

        /// <summary>
        /// Gets the color of wire.
        /// </summary>
        public Color Color { get { return color; } }


        #region Public methods
        /// <summary>
        /// Draws the wire
        /// </summary>
        public void DrawWire()
        {
            SetWireColor();
            g.DrawLine(new Pen(color, size), iniPoint, finalPoint);
        }

        /// <summary>
        /// Removes the wire of the specific Digital's instant and pin number.
        /// </summary>
        /// <param name="dig">Digital's instant which owns the wire.</param>
        /// <param name="pinNum">Pin number of Digital's instant.</param>
        public static void RemoveAWire(Digital dig, int pinNum)
        {
            for (int i = 0; i < wireList.Count; i++)
            {
                Digital tempDig = (Digital)digList[i];
                Wire tempWire = (Wire)wireList[i];
                int pinNo = (int)pinList[i];
                if (tempDig.Name == dig.Name && pinNo == pinNum)
                {
                    g.DrawLine(new Pen(Color.White, tempWire.Size), tempWire.iniPoint, tempWire.finalPoint);
                    wireList.RemoveAt(i);
                    digList.RemoveAt(i);
                    pinList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Removes the wire of the specific name.
        /// </summary>
        /// <param name="name">Name of wire which is to remove.</param>
        public static void RemoveAWire(string name)
        {
            for (int i = 0; i < wireList.Count; i++)
            {
                Wire tempWire = (Wire)wireList[i];
                if (tempWire.Name == name)
                {
                    g.DrawLine(new Pen(Color.White, tempWire.Size), tempWire.iniPoint, tempWire.finalPoint);
                    wireList.RemoveAt(i);
                    digList.RemoveAt(i);
                    pinList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Removes this wire.
        /// </summary>
        public void Remove()
        {
            for (int i = 0; i < wireList.Count; i++)
            {
                Wire tempWire = (Wire)wireList[i];
                int pinNo = (int)pinList[i];
                if (tempWire == this)
                {
                    g.DrawLine(new Pen(Color.White, tempWire.Size), tempWire.iniPoint, tempWire.finalPoint);
                    wireList.RemoveAt(i);
                    digList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Refreshes this wires.
        /// </summary>
        public void Refresh()
        {
            for (int i = 0; i < Wire.wireList.Count; i++)
            {
                Wire temp = (Wire)Wire.wireList[i];
                if(temp == this)
                {
                    temp.DrawWire();
                    break;
                }
            }
        }

        /// <summary>
        /// Refreshes all the initialized wires.
        /// </summary>
        /// 
        public static void RefreshAll()
        { 
            for (int i = 0; i < Wire.wireList.Count; i++)
            {
                Wire temp = (Wire)Wire.wireList[i];
                temp.DrawWire();
            }
        }
        #endregion

        #region Private methods

        private int YCoordinate(int pinNum)
        {
            int ans = 0;
            switch(pinNum)
            {
                case 0:
                    if (dig.ActivePins == 1)
                        ans = 14 * 2 + 11;
                    else
                        ans = 11;
                    break;
                case 1:
                    ans = 14 + 11;
                    break;
                case 2:
                    ans = 14 * 2 + 11;
                    break;
                case 3:
                    ans = 14 * 3 +11;
                    break;
                case 4:
                    ans = 14 * 4 + 11;
                    break;
                default:
                    break; 
            }
            return ans;
        }

        //Randomly set the color of wire from the set of three colors.
        private void SetWireColor()
        {
            Random r = new Random();
            int a = r.Next(10);
            if (a < 3)
                color = Properties.Settings.Default.wireColor;
            else if (a < 6)
                color = Properties.Settings.Default.wireColor2;
            else
                color = Properties.Settings.Default.wireColor3;
        }
        #endregion
    }
}
