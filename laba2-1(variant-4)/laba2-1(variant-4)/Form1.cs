using System;
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
            try
            {
                double x = double.Parse(textX.Text);
                double y = double.Parse(textY.Text);
                double r1 = double.Parse(textR1.Text);
                double r2 = double.Parse(textR2.Text);

                if (r1 <= r2 || r2 <= 0)
                {
                    lblResult.Text = "Ошибка: R1 должно быть > R2 > 0";
                    return;
                }

                double distanceSquared = x * x + y * y;
                bool isInRing = (distanceSquared >= r2 * r2) && (distanceSquared <= r1 * r1);

                lblResult.Text = isInRing ? "Точка в кольце" : "Точка вне кольца";
            }
            catch
            {
                lblResult.Text = "Ошибка ввода данных";
            }
        }
    }
}
