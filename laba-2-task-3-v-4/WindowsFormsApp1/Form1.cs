using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            int score = 0;

            // Проверка первого вопроса (RadioButton)
            if (rbInt.Checked) score++;

            // Проверка второго вопроса (CheckBox)
            if (chkDouble.Checked && chkDecimal.Checked && chkFloat.Checked && !chkString.Checked)
                score++;

            lblResult.Text = $"Правильных ответов: {score}/2";
        }
    }
}
