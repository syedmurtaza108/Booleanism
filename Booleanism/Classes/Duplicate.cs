using System;
using System.Windows.Forms;
using System.Drawing;
namespace Booleanism
{
    /// <summary>
    /// Gives the duplication features of Digital components
    /// </summary>
    public class Duplicate
    {
        Panel contentPanel;
        Panel configPanel;

        /// <summary>
        /// Initializes the class with no arguments.
        /// </summary>
        public Duplicate()
        {
            contentPanel = new Panel();
            configPanel = new Panel();
        }

        /// <summary>
        /// Initializes the class with specified values.
        /// </summary>
        /// <param name="contentPanel">In which the components are added.</param>
        /// <param name="configPanel">In which the properties of components are added.</param>
        public Duplicate(Panel contentPanel, Panel configPanel)
        {
            this.contentPanel = contentPanel;
            this.configPanel = configPanel; 
        }

        /// <summary>
        /// Gets the duplicate Digital object of specified Digital object.
        /// </summary>
        /// <param name="toDuplicate">Which is to duplicate.</param>
        public Digital GetDuplicate(Digital toDuplicate)
        {
            Digital dig;
            if (toDuplicate != null)
            {
                dig = RecognizeDigitalType(toDuplicate);
                dig.DetailsLabel = toDuplicate.DetailsLabel;
                toDuplicate.CopyConfiguration(dig);
            }
            else
                throw new NullDigitalException();
            return dig;
        }

        private Digital RecognizeDigitalType(Digital dig)
        {
            Digital digital;
            if (dig is And)
                digital = new And(contentPanel, configPanel);
            else if (dig is Or)
                digital = new Or(contentPanel, configPanel);
            else if (dig is Xor)
                digital = new Xor(contentPanel, configPanel);
            else if (dig is Not)
                digital = new Not(contentPanel, configPanel);
            else if (dig is Nand)
                digital = new Nand(contentPanel, configPanel);
            else if (dig is Nor)
                digital = new Nor(contentPanel, configPanel);
            else if (dig is RS)
                digital = new RS(contentPanel, configPanel);
            else if (dig is JK)
                digital = new JK(contentPanel, configPanel);
            else if (dig is D)
                digital = new D(contentPanel, configPanel);
            else if (dig is PushButton)
                digital = new PushButton(contentPanel);
            else if (dig is LED)
            {
                LED temp = (LED)dig;
                digital = new LED(temp.TypeOfLED,contentPanel, configPanel);
            }
            else if (dig is Clock_Signal)
                digital = new Clock_Signal(contentPanel);
            else
                digital = new And();
            return digital;
        }
    }
}
