using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using NCalc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Plotter
{
    public partial class Form1 : Form
    {
        /**
         * To undersdant how the code is working, start with button1_Click method. 
         * button1_Click is the major method in the project which calls other functions.
         * 
         */

        public Form1()
        {
            InitializeComponent();
            //Displays a message box when user runs the program. The message includes the rules and warning to use the Function plotter.  
            MessageBox.Show("Rules: \n1-Equation musn't be empty\n2-Min of interval must be less than max of interval" +
                                   "\n3-Variables other than x isn't valid.\n4-Operators other than (+,-,*,/,^) is invalid." +
                                   "\n5-Division by zero isn't allowed.");
        }
        /**
         * IsOperator: Checks whether a string represents an operator or not. 
         */
        static bool IsOperator(String ch)
        {
            if (ch == "^" || ch == "*" || ch == "/" || ch == "+" || ch == "-")
        {
                return true;
            }
        else
            {
                return false;
            }
        }
        /**
         IsValidChar: checks if a character is an valid in the function.
        Valid means is the character is an operator, a variable (x), or a number.
         */
        static bool IsValidChar(char ch)
        {
            string str = ""; str += ch;
            if (Char.IsLetter(ch) && ch != 'x')
            {
                MessageBox.Show("Invalid variable : " + ch);
                return false;

            }

            else if (!(Char.IsLetter(ch)|| Char.IsDigit(ch)) && !IsOperator(str))
                {
                   MessageBox.Show("Invalid Operator : " + ch);
                return false;
            }
            return true;
        }
        /**
         IsMissingOperator: check if there a missing operator between two consecutive characters.
         */
        static bool IsMissingOperator(string prev, string curr)
        {
            if (prev == "x" && curr == "x")
            {
                return true;
            }
            else if ((int.TryParse(prev, out int value) && curr == "x")||(prev == "x" && (int.TryParse(curr, out int val))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
          ExctractArr: converts the equation from string into an ArrayList of objects.
        returns true if it's possible to convert the string into a function.
         */

        static bool ExctractArr(String line, ref ArrayList array)
        {

            for (int i = 0; i < line.Length; i++){
                string curr = ""; curr += line[i];

                if (curr == " ") {
                    continue;
                }
                else if ((array.Count != 0))
                {
                   if(!IsValidChar(line[i])){
                        return false;
                    }

                    string prev = (string)array[array.Count - 1];
                    if (int.TryParse(prev, out int value) && int.TryParse(curr, out int Val)){
                        array.RemoveAt(array.Count - 1);
                        array.Add(prev + curr);
                        continue;
                    }
                    else if (prev == "/" && curr == "0"){
                        MessageBox.Show("Division by zero not allowed");
                        return false;
                    }
                    else if (IsOperator(prev) && IsOperator(curr)){
                        MessageBox.Show("Missing variable or number between "+prev+" and "+curr);
                        return false;
                    }
                    else if (IsMissingOperator(prev, curr)) {
                        MessageBox.Show("Missing operator between " + prev + " and " + curr);
                        return false;
                    }
                    else {
                        array.Add(curr);
                    }
                }
                else
                {
                    if (!IsValidChar(line[i]))
                    {
                        return false ;
                    }
                    array.Add(curr);
                }



            }
            return true;
        }
        /**
          Function: calculates the value of the equation to a specific value of x. 
         */

        public static  double Function(string equation, double value)
        {
            var expr = new NCalc.Expression(equation);
            expr.Parameters["x"] = value;
            return ((double)(expr.Evaluate()));
        }
        /**
         GetEquation: converts an array list into a string represents the equation.
         */
        static String GetEquation(ArrayList array)
        {
            StringBuilder equation = new StringBuilder(); String str;
            for (int i = 0; i < array.Count; i++)
            {
                str= (string)array[i];
                if (str == "^")
                {
                    i++;
                    int cnt = Convert.ToInt32(array[i]);
                    for (int j = 0; j < cnt - 1; j++)
                    {
                        equation.Append("* x ");
                    }
                }
                else
                {
                    equation.Append(str + " ");
                }
            }
            return equation.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             stores the begining and the end of the intervals from textboxes to double variables named MinValue and MaxValue.
             */
            double MinValue = Convert.ToDouble(MinBound.Text);
            double MaxValue = Convert.ToDouble(MaxBound.Text);
            /*
             * checks that the end of the interval is greater than the begining of the interval
             * Also, checks that user has entered an equation.
             */
            if (MinValue>=MaxValue)
            {
                MessageBox.Show("Value of minimum of interval should be less than Maximum of the interval.");
                return;
            }
            else if (InputEquation.Text == "")
            {
                MessageBox.Show("Equation musn't be empty.");
            }

            ArrayList array = new ArrayList();
            /*
             Checks that equation is valid. and also converts it into an arrayList of objects.
             */
            if (!ExctractArr(InputEquation.Text, ref array)) {
                return;
            };
            /*
             converts the arrayList which the input equation is stored to a string.
             */
            /*
              Please note that:  the reason behind converting the input equation into an ArrayList, and then from ArrayList to a string:
             I use (NCalc) class for calculating equation in a specific value of x: which takes a string equation but with a specific format like:
             doesn't support ^ operator, every two consecutive characters have to be separated by space. To make it easy for the user I did it in this way.
             */
            String equation = GetEquation(array);
            /*
             calculating points from start of the interval to the end and storing these points in ChartValues<ObservablePoint>: it's just like an array of points
             */
            ChartValues<ObservablePoint> List1Points = new ChartValues<ObservablePoint>();
            for (double i = MinValue; i <= MaxValue; i+=0.2)
            {

                List1Points.Add(new ObservablePoint
                {
                    X = i,
                    Y = Function(equation, i)
                });
            }
            /*
             plotting the calculated points in the Cartesian coordinates.
            the tool I used in the GUI for plotting the points is called: cartesianChart 
             */
            cartesianChart.Series = new SeriesCollection {
               new LineSeries{
                Values=List1Points,PointGeometrySize=5

               } 
            };


        }



    }
}
