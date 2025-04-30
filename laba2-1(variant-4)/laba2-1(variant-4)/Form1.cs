using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_1_variant_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textX.Text);
            double y = double.Parse(textY.Text);
            double r1 = double.Parse(textR1.Text);
            double r2 = double.Parse(textR2.Text);

            double distance = Math.Sqrt(x * x + y * y);

            if (r1 > r2 && r2 > 0)
            {
                if (distance > r2 && distance < r1)
                    lblResult.Text = "Точка принадлежит кольцу.";
                else
                    lblResult.Text = "Точка НЕ принадлежит кольцу.";
            }
            else
            {
                lblResult.Text = "Ошибка: R1 должно быть больше R2 и R2 > 0.";
            }
        }
    }
}
