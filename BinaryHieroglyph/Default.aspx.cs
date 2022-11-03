using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BinaryHieroglyph
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(txtNumber.Text);

                int maxPower = 8;
                CheckForLabelBorder(lblRight4, ref number, LabelSide.Right, --maxPower);
                CheckForLabelBorder(lblLeft4, ref number, LabelSide.Left, --maxPower);
                CheckForLabelBorder(lblRight3, ref number, LabelSide.Right, --maxPower);
                CheckForLabelBorder(lblLeft3, ref number, LabelSide.Left, --maxPower);
                CheckForLabelBorder(lblRight2, ref number, LabelSide.Right, --maxPower);
                CheckForLabelBorder(lblLeft2, ref number, LabelSide.Left, --maxPower);
                CheckForLabelBorder(lblRight1, ref number, LabelSide.Right, --maxPower);
                CheckForLabelBorder(lblLeft1, ref number, LabelSide.Left, --maxPower);
            }
            catch { }
        }

        private enum LabelSide
        {
            Left,
            Right
        }

        private void CheckForLabelBorder(Label label, ref int number, LabelSide side, int powerToCheckFor)
        {
            bool isInPower = IsNumberHigherThanPower(ref number, powerToCheckFor);
            label.Style.Clear();
            label.CssClass = "Style" + side.ToString() + (isInPower ? "On" : "Off");
        }

        private bool IsNumberHigherThanPower(ref int numIn, int powerToCheckFor)
        {
            int power = Convert.ToInt32(Math.Pow(2, powerToCheckFor));
            if (numIn >= power)
            {
                numIn -= power;
                return true;
            }
            else
                return false;
        }
    }
}