using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoodCalculater
{
    public partial class calo : Form
    {
       
         

        private void lblRead_Click(object sender, EventArgs e)
        {
            string path = @"C:\calo.txt";
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    sb.Append(sr.ReadLine());
                }
            }
            txbFoodEnergy.Text = sb.ToString();
        }

    }
}
