using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font_Resizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float currentSize = lblFont.Font.Size;
            string fontName = lblFont.Name;
            lblFont.Font = new Font(fontName, currentSize + 5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            float currentSize = lblFont.Font.Size;
            string fontName = lblFont.Name;
            try
            {
                lblFont.Font = new Font(fontName, currentSize - 5);
            }

            catch (Exception)
            {
                lblFont.Font = new Font(fontName, currentSize + 10);
            }
        }
    }
}
