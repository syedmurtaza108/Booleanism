/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
June 10, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Booleanism
{
    /// <summary>
    /// Gives the features to read and write a file containing Digital's instants.
    /// </summary>
    class Digital_File
    {
        string file;            //File location
        StreamWriter sWriter;
        StreamReader sReader;

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public Digital_File()
        {
            
        }

        /// <summary>
        /// Initializes the class with specific file location.
        /// </summary>
        /// <param name="File">Name of file containing Digital's instants.</param>
        public Digital_File(string File)
        {
            file = File;
            
        }
        
        /// <summary>
        /// Initializes the class with file stream object.
        /// </summary>
        /// <param name="File">FileStream containing Digital's instants.</param>
        public Digital_File(FileStream File)
        {
            file = File.Name;
        }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public string File { get {return file; } set {file = value; } }


        #region Public methods
        /// <summary>
        /// Loads the file.
        /// </summary>
        /// <param name="contentPanel">In which Digital's instants will be added.</param>
        /// <param name="configPanel">In which the properties of Digital's instants will be added.</param>
        public void ReadFile(Panel contentPanel, Panel configPanel, Label detailsLabel)
        {
            try
            {
                sReader = new StreamReader(file);                
                string[] lines = sReader.ReadToEnd().Split('\n');
                ArrayList list = InitializeAllComponents(lines, contentPanel, configPanel, detailsLabel);
                for (int i = 6, count = 0; i<lines.Length && count < list.Count;i += 6, count++)
                    {
                        Digital dig = (Digital)list[count];
                        for (int j = 0; j < 5; j++, i += 2)
                        {
                            if (dig.GetAvailablePins[j] != null)
                            {
                                dig.GetAvailablePins[j].State = ReadStates(lines, i);
                                string signalFrom = ReadSignalFrom(lines, i+1);
                                if (signalFrom != "1" && signalFrom != "0")
                                {
                                    Digital temp = Digital.GetDigitalInstantByName(signalFrom);
                                    PushButton p;
                                    if (temp is PushButton)
                                    {
                                        p = (PushButton)temp;
                                        p.PreviousState = dig.GetAvailablePins[j].State;
                                        dig.SetInputOn(j, p.PreviousState);
                                    }
                                    else
                                    {
                                        dig.SetInputOn(j, temp.GetOutput());
                                    }
                                        temp.OutputPin.SetDigital(dig, j);
                                        dig.GetAvailablePins[j].ContentOf(temp, temp.OutputPin);
                                        Wire.RemoveAWire(dig, j);
                                        Wire w = new Wire(temp, dig, dig.ContentPanel.CreateGraphics(), j, Properties.Settings.Default.wireSize);
                                        w.DrawWire();
                                    }
                                }           
                        }
                        dig.OutputPin.State = ReadStates(lines, i++);
                    }
                sReader.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.FileLoadException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred.", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Writes the file.
        /// </summary>
        /// <param name="listOfComponent">List of components that will be written in the file.</param>
        public void WriteFile(ArrayList listOfComponent)
        {
            try
            {
                sWriter = new StreamWriter(file);
                foreach(Object obj in listOfComponent)
                {
                    if(obj is Digital && obj != null)
                    {
                        Digital dig = (Digital)obj;
                        sWriter.WriteLine(">>>" + dig.Name );
                        sWriter.WriteLine(">>Title: " + dig.Title);
                        sWriter.WriteLine(">>Pins: " + dig.ActivePins);
                        sWriter.WriteLine(">>Location[x]: " +dig.Location.X);
                        sWriter.WriteLine(">>Location[y]: " + dig.Location.Y);
                        if(dig is LED)
                        {
                            LED temp = (LED)dig;
                            sWriter.WriteLine(">>Color: " + temp.TypeOfLED);
                        }
                        else if(dig is Clock_Signal)
                        {
                            Clock_Signal temp = (Clock_Signal)dig;
                            sWriter.WriteLine(">>Interval: "+temp.IntervalComboBox.SelectedItem.ToString());
                        }
                        else if (dig is Display)
                        {
                            Display temp = (Display)dig;
                            sWriter.WriteLine(">>Color: " + temp.OnColor.Name);
                        }
                        else
                        {
                            sWriter.WriteLine(">>");
                        }
                        WriteStates(dig);
                    }
                }

                sWriter.Close();
            }
            catch(System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.FileLoadException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred.", "Booleanism V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #endregion


        #region Private methods
        private void RecognizeLEDType(string[] lines, int index, LED led)
        {
                string s = lines[index].Substring(9, lines[index].Length-10);
                switch(s)
                {
                    case "Red":
                        led.TypeOfLED = LED.LEDType.Red;
                        break;
                    case "Yellow":
                        led.TypeOfLED = LED.LEDType.Yellow;
                        break;
                    case "Green":
                        led.TypeOfLED = LED.LEDType.Green;
                        break;
                    case "Purple":
                        led.TypeOfLED = LED.LEDType.Purple;
                        break;
                    case "White":
                        led.TypeOfLED = LED.LEDType.White;
                        break;
                    default:
                        led.TypeOfLED = LED.LEDType.Blue;
                        break;

                }
            
        }

        private void RecognizeDisplay(string[] lines, int index, Display display)
        {
            string s = lines[index].Substring(9, lines[index].Length - 10);
            switch (s)
            {
                case "Red":
                    display.OnColor = Color.Red;
                    break;
                case "Gold":
                    display.OnColor = Color.Gold;
                    break;
                case "LimeGreen":
                    display.OnColor = Color.LimeGreen;
                    break;
                case "Blue":
                    display.OnColor = Color.Blue;
                    break;
                default:
                    display.OnColor = Color.Red;
                    break;

            }

        }

        private ArrayList InitializeAllComponents(string[] lines,Panel contentPanel, Panel configPanel, Label detailsLabel)
        {
            ArrayList list = new ArrayList();
            for(int i=0;i< lines.Length;i++)
            {
                if(lines[i].Contains(">>>"))
                {
                    string name = lines[i].Substring(3, lines[i++].Length - 4);
                    string title = lines[i].Substring(9, lines[i++].Length - 10);
                    int inpPins = Convert.ToInt32(lines[i].Substring(8, lines[i++].Length - 9));
                    int x = Convert.ToInt32(lines[i].Substring(15, lines[i++].Length - 16));
                    int y = Convert.ToInt32(lines[i].Substring(15, lines[i++].Length - 16));
                    Digital dig = RecognizeDigitalType(name, contentPanel, configPanel, inpPins);
                    if(dig is LED)
                    {
                        LED temp = (LED)dig;
                        RecognizeLEDType(lines, i++, temp);
                    }
                    else if(dig is Clock_Signal)
                    {
                        Clock_Signal temp = (Clock_Signal)dig;
                        string item = lines[i].Substring(12, lines[i++].Length - 13);
                        temp.IntervalComboBox.SelectedItem = item;
                    }
                    else if (dig is Display)
                    {
                        Display temp = (Display)dig;
                        RecognizeDisplay(lines, i++, temp);
                    }
                    dig.Name = name;
                    dig.Title = title;
                    dig.DetailsLabel = detailsLabel;
                    dig.Location = new System.Drawing.Point(x, y);
                    contentPanel.Controls.Add(dig);
                    list.Add(dig);
                }
            }
            return list;
        }

        private void WriteStates(Digital dig)
        {
            
            for(int i = 0; i<dig.GetAvailablePins.Length; i++)
            {
                
                if (dig.GetAvailablePins[i] == null)
                {
                    sWriter.WriteLine("Pin[" + i + "]: null");
                    sWriter.WriteLine("Pin[" + i + "] From: Null");
                }                    
                else
                {
                    sWriter.WriteLine("Pin[" + i + "]: " + dig.GetAvailablePins[i].State);
                    string content;
                    if (dig.GetAvailablePins[i].ContentOfDigital != null)
                        content = "Pin[" + i + "] From: " + dig.GetAvailablePins[i].ContentOfDigital.Name;
                    else
                        content = "Pin[" + i + "] From: " + dig.GetAvailablePins[i].SignalFrom;
                    sWriter.WriteLine(content);
                }
                    
            }
            sWriter.WriteLine("Output: " + dig.OutputPin.State);
            
        }

        private bool ReadStates(string[] lines, int index)
        {
            bool val =false;
            if (!lines[index].Contains("null"))
            {
                val = true ? lines[index].Contains("True") : false;
            }
            return val;
        }

        private string ReadSignalFrom(string[] lines, int index)
        {
            string val = null;
            if (!lines[index].Contains("null"))
            {
                val = lines[index].Substring(13, lines[index].Length - 14);
            }
            return val;
        }

        private Digital RecognizeDigitalType(string name,Panel contentPanel, Panel configPanel, int pins)
        {
            Digital digital;
            if (name.Contains("AND"))
                digital = new And(contentPanel, configPanel,pins);
            else if (name.Contains("OR"))
                digital = new Or(contentPanel, configPanel, pins);
            else if (name.Contains("XOR"))
                digital = new Xor(contentPanel, configPanel, pins);
            else if (name.Contains("NOT"))
                digital = new Not(contentPanel, configPanel);
            else if (name.Contains("NAND"))
                digital = new Nand(contentPanel, configPanel, pins);
            else if (name.Contains("NOR"))
                digital = new Nor(contentPanel, configPanel, pins);
            else if (name.Contains("RS"))
                digital = new RS(contentPanel, configPanel);
            else if (name.Contains("JK"))
                digital = new JK(contentPanel, configPanel);
            else if (name.Contains("DF"))
                digital = new D(contentPanel, configPanel);
            else if (name.Contains("Button"))
                digital = new PushButton(contentPanel);
            else if (name.Contains("LED"))
                digital = new LED(contentPanel, configPanel);
            else if (name.Contains("Clock"))
                digital = new Clock_Signal(contentPanel);
            else if (name.Contains("Display"))
                digital = new Display(contentPanel, configPanel);
            else
                digital = new And();
            return digital;
        }

        #endregion
    }
}
