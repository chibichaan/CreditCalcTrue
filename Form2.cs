using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalc
{
    public partial class Form2 : Form
    {
        public Form2(Form1 OwnerForm, string answer)
        {
            InitializeComponent();
            ownerForm = OwnerForm; //доступны все открытые члены(поля, св-ва, методы и тд) класса форм1
            textBox1.Text = answer;
            textBox1.ReadOnly = true; //ничего нельзя писать в текстбоксе
        }

        Form1 ownerForm;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
