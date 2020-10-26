using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathParser
{
    public partial class parserForm : Form
    {
        double minX = 0;
        double maxX = 0;
        double minY = 0;
        double maxY = 0;
        double tab = 0;

        public parserForm()
        {
            InitializeComponent();
            chartParsedExpr.Series["Fx"].ChartType = SeriesChartType.FastLine;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            chartParsedExpr.Series["Fx"].Points.Clear();
            ProcessInput(txtInput.Text);
        }

        private double TreatAsDouble(string text) {
            text = text.Replace(',', '.');
            double res;
            double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out res);
            return res;
        }

        private void ProcessInput(string expression)
        {
            try
            {
                //Validate limits
                minX = TreatAsDouble(txtMin_x.Text);
                maxX = TreatAsDouble(txtMax_x.Text);
                minY = TreatAsDouble(txtMin_y.Text);
                maxY = TreatAsDouble(txtMax_y.Text);
                tab = TreatAsDouble(txtTab.Text);

                if (minX > maxX || minY > maxY || tab <= 0)
                {
                    throw new ArgumentException("Incorrect input");
                }

                RPNParser parser = new RPNParser();
                //string FormatString = parser.FormatString(expression);
                if (expression.Contains("x"))
                {
                    //Draw graph
                    for (double x = minX; x < maxX; x += tab)
                    {
                        //string TempInput = FormatString;
                        string TempInput;
                        string X = x.ToString(".");
                        if (x < 0)
                        { 
                            X = "(" + X + ")";
                        }
                        //X = X.Replace(',', '.');
                        TempInput = expression.Replace("x", X);
                        double y = parser.Parse(TempInput);
                        if (minY <= y && y <= maxY)
                        {
                            //Add dot to graph
                            chartParsedExpr.Series["Fx"].Points.AddXY(x, y);
                        }
                    }
                }
                else
                {
                    double y = parser.Parse(expression);
                    //Draw line
                    for (double x = minX; x < maxX; x += tab)
                    {
                        chartParsedExpr.Series["Fx"].Points.AddXY(x, y);
                    }
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText("    " + ex.Message + "\n");
            }
        }
    }
}
