﻿/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
June 11, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Collections;

namespace Booleanism
{
    /// <summary>
    /// Gives the features of TruthTable
    /// </summary>
    class TruthTable
    {
        ArrayList list;             //List of components, using in truth table.
        ArrayList inputs;           //Inputs,extracting from 'list', instants of PushButton
        ArrayList digComp;          //Gates, FF etc, extracting from 'list'
        bool[,] inp;                //Total combinations from formula 2^n

        enum FileType
        {
            HTML = 0, Text = 1
        }

        enum TruthTableType
        {
            Short = 0, Long = 1
        }

        /// <summary>
        /// Initializes the class with default values.
        /// </summary>
        public TruthTable()
        {
            list = new ArrayList();
        }

        /// <summary>
        /// Initializes the class with the list of Digital components which will be included in the Truth Table. Make sure that all the instants, containing in this list, must be the instants of the Digital class.
        /// </summary>
        /// <param name="List"></param>
        public TruthTable(ArrayList List)
        {
            list = List;
        }

        /// <summary>
        /// Gets the Truth Table of the given components. Truth Table will be made with respect to loading the components in the list.
        /// </summary>
        public string TextTable(string title)
        {
            string s = "Truth Table of " + title + "\n---------------------------------------------------------------------------------\n\n\n\n";
            SeparatePushButtons();
            inp = GenerateCombinations();
            digComp = SeparateGatesAndFlipFlops();
            for (int i = 0; i < inputs.Count; i++)
            {
                Digital p = (PushButton)inputs[i];
                s += p.Title + "\t";
            }

            for (int i = 0; i < digComp.Count; i++)
            {
                Digital dig = (Digital)digComp[i];
                s += dig.Title + "\t";
            }
            s += "\n" + TotalCombinations(FileType.Text);
            s += "\n\nThis Truth Table is automatically generated by Booleanism V 2.0\nDated: " + DateTime.Today.ToShortDateString();
            return s;
        }

        public string HTMLTable(string fileTitle)
        {
            SeparatePushButtons();
            inp = GenerateCombinations();
            digComp = SeparateGatesAndFlipFlops();
            string s = "<html><header><title>" + fileTitle + "</title></header><body>";
            s += "<h3><u>Truth Table of " + fileTitle + "</u></h3><table border = \"1\"><tr>";
            for (int i = 0; i < inputs.Count; i++)
            {
                Digital p = (PushButton)inputs[i];
                s += "<th>" + p.Title + "</th>";
                
            }

            for (int i = 0; i < digComp.Count; i++)
            {
                Digital dig = (Digital)digComp[i];
                s += "<th>" +dig.Title + "</th>";
            }
            s += "</tr>" + TotalCombinations(FileType.HTML);
            s += "</table><h4>This Truth Table is automatically generated by Booleanism V 2.0</h4><h5><i>Dated: " + DateTime.Today.ToShortDateString() + "</i></h5></body></html>" ;
            return s;
        }

        public string  ShortTable(Digital component)
        {
            ArrayList tempList = new ArrayList(list);
            for (int i = 0; i < tempList.Count; i++)
            {
                Digital dig = (Digital)tempList[i];
                if(dig is PushButton)
                    tempList.RemoveAt(i--);
                else
                {
                    if (dig != component && !(CheckSignalFrom(component, dig.Name)) )
                        tempList.RemoveAt(i--);
                }
            }

            string s = "Truth Table of " + component.Name + "\n---------------------------------------------------------------------------------\n\n\n\n";
            SeparatePushButtons();
            inp = GenerateCombinations();
            digComp = tempList;
            for (int i = 0; i < inputs.Count; i++)
            {
                Digital p = (PushButton)inputs[i];
                s += p.Title + "\t";
            }

            for (int i = 0; i < digComp.Count; i++)
            {
                Digital dig = (Digital)digComp[i];
                s += dig.Title + "\t";
            }
            s += "\n" + TotalCombinations(FileType.Text);
            s += "\n\nThis Truth Table is automatically generated by Booleanism V 2.0\nDated: " + DateTime.Today.ToShortDateString();
            return s;
        }

        private bool CheckSignalFrom(Digital dig, string signalFrom)
        {
            bool ans = false;
            for (int i = 0; i < dig.GetAvailablePins.Length; i++)
                if (dig.GetAvailablePins[i] != null && dig.GetAvailablePins[i].SignalFrom == signalFrom)
                {
                    ans = true;
                    break;
                }
            return ans;
        }



        /// <summary>
        /// Initializes the class with the list of Digital components which will be included in the Truth Table. Make sure that all the instants, containing in this list, must be the instants of the Digital class.
        /// </summary>
        public ArrayList SetList { set { list = value; } }

        #region Private methods

        private string TotalCombinations(FileType type)
        {
            string s = "";
            bool[,] result = GenerateCombinations();
            switch (type)
            {
                case FileType.Text:
                    for (int row = 0; row < result.GetLength(0); row++)
                    {
                        for (int col = 0; col < result.GetLength(1); col++)
                        {
                            s += result[row, col] == true ? "1" + "\t" : "0" + "\t";
                        }
                        foreach (Object obj in digComp)
                        {
                            Digital dig = (Digital)obj;
                            s += Gates(row, dig, FileType.Text);
                        }
                        s += "\n";
                    }
                    break;
                case FileType.HTML:
                    for (int row = 0; row < result.GetLength(0); row++)
                    {
                        s += "<tr>";
                        for (int col = 0; col < result.GetLength(1); col++)
                        {
                            s += "<td>";
                            s += result[row, col] == true ? "1" + "\t" : "0" + "\t";
                            s += "</td>";
                        }
                        foreach (Object obj in digComp)
                        {
                            Digital dig = (Digital)obj;
                            s += Gates(row, dig, FileType.HTML);
                        }
                        s += "</tr>";
                    }
                    break;
                default:
                    break;
            }
            
            return s;
        }

        private string Gates(int row, Digital dig, FileType type)
        {
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                if (dig.GetAvailablePins[i] != null && dig.GetAvailablePins[i].isPinContentOfAnother)
                {
                    int col;
                    if (dig.GetAvailablePins[i].SignalFrom.Contains("Button"))
                    {
                        col = Convert.ToInt32(dig.GetAvailablePins[i].SignalFrom.Substring(6));
                        dig.SetInputOn(i, inp[row, col - 1]);
                    }
                    else
                    {
                        Digital temp = GetDigitalByName(dig.GetAvailablePins[i].SignalFrom);
                        if(temp != null)
                            dig.SetInputOn(i, temp.GetOutput());
                    }
                }
            }
            switch(type)
            {
                case FileType.HTML:
                    s += "<td>";
                    s += dig.GetOutput() ? "1" + "\t" : "0" + "\t";
                    s += "</td>";
                    break;
                default:
                    s += dig.GetOutput() ? "1" + "\t" : "0" + "\t";
                    break;
            }
            
            return s;
        }

        private Digital GetDigitalByName(string name)
        {
            Digital dig = null;
            for (int i = 0; i < digComp.Count; i++)
            {
                Digital temp = (Digital)digComp[i];
                if (temp.Name == name)
                {
                    dig = temp;
                    break;
                }
            }
            return dig;
        }

        private ArrayList SeparateGatesAndFlipFlops()
        {
            ArrayList digList = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                Digital temp = (Digital)list[i];
                if (!(list[i] is PushButton || list[i] is LED || list[i] is Clock_Signal) && IsContentOfAnther(i))
                    digList.Add(list[i]);
            }
            return digList;
        }

        //Check whether an input pin operated by an other Digital instant or not.
        private bool IsContentOfAnther(int index)
        {
            bool ans = false;
            Digital temp = (Digital)list[index];
            for (int i = 0; i < 5; i++)
                if (temp.GetAvailablePins[i] != null && temp.GetAvailablePins[i].isPinContentOfAnother)
                {
                    ans = true;
                    break;
                }
            return ans;

        }

        private int CountOfPushButton()
        {
            int ans = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is PushButton)
                    ans++;
            }
            return ans;
        }

        //Separate PushButton's instants
        private void SeparatePushButtons()
        {
            inputs = new ArrayList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is PushButton)
                    inputs.Add(list[i]);
            }
        }

        private bool[,] GenerateCombinations()
        {
            int j = CountOfPushButton();
            bool[,] result = new bool[(int)Math.Pow(2, j), j];
            for (int col = 0; col < result.GetLength(1); col++)
            {
                int a = (int)Math.Pow(2, col);
                for (int row = 0; row < result.GetLength(0); row++)
                {
                    if (row + a > result.GetLength(0))
                        result[result.GetLength(0) - 1, col] = true;
                    else
                    {
                        for (int k = 0; k < a; k++)
                        {
                            result[row++ + a, col] = true;
                        }
                        row += a - 1;
                    }
                }

            }
            return result;
        }
    }
}
#endregion