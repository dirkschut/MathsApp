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
        public MathsApp()
        {
            InitializeComponent();
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
    }
}
