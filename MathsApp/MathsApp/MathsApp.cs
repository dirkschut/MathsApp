using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsApp
{
    public partial class MathsApp : Form
    {
        private NumberConversion numberConversion;

        public MathsApp()
        {
            InitializeComponent();
            numberConversion = new NumberConversion(0);
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Open github repo in default browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrDLSable/MathsApp");
        }

        /// <summary>
        /// Changes the other conversion fields when the decimal one is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Decimal_TextChanged(object sender, EventArgs e)
        {
            int output = 0;
            if(int.TryParse(tb_Decimal.Text, out output))
            {
                numberConversion.SetDecimal(output);
                tb_Binary.Text = numberConversion.GetBinary();
                tb_Hexadecimal.Text = numberConversion.GetHexadecimal();
            }
        }
    }
}
