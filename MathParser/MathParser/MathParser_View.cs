using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathParser
{
    public partial class parserForm : Form
    {
        public parserForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ProcessInput(txtInput.Text);
        }

        private void ProcessInput(string expression)
        {
            RPNParser parser = new RPNParser();
            parser.Parse("2.0*3.0");
            //     string s1 = "pi+5*5+5*3-5*5-5*3+1E1";
            //     string s2 = "sin(cos(tg(sh(ch(th(100))))))";
            //     double d1 = parser.Parse(s1, isRadians);
            //     double d2 = parser.Parse(s2, isRadians);
            //
            //     Console.WriteLine(d1); // 13.141592...
            //     Console.WriteLine(d2); // 0.0174524023974442
            //     Console.ReadKey(true); 
        }
    }
}
