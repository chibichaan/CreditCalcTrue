namespace CreditCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int interRate = 0; //���������� ������
        int finalInterRate = 0;
        int monthlyPayment = 0; //������. �����

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChooseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
        private void youngParentCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChooseCheckBox();
            trackBar1_Scroll(sender, e, sale);
        }
        private void oldmanCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            int sale = ChooseCheckBox();  //���.����������  
            trackBar1_Scroll(sender, e, sale);
        }

        public int ChooseCheckBox()
        {
            int saleStudent,saleParent,saleOld, sale; //������

            if (studentCheckBox1.Checked) saleStudent = -1; 
            else saleStudent = 0;

            if (youngParentCheckBox2.Checked) saleParent = -2;
            else saleParent = 0;

            if (oldmanCheckBox3.Checked) saleOld = -3;
            else saleOld = 0;

            sale = saleStudent + saleParent + saleOld;
            return sale;
        }

        private void trackBar1_Scroll(object sender, EventArgs e, int sale) //���������� �������
        {
            if(trackBar1.Value < 13) interRate = 25;
            else if(trackBar1.Value < 37) interRate = 20;
            else if (trackBar1.Value <= trackBar1.Maximum) interRate = 17;

            finalInterRate = interRate + sale;
            interRateLabel2.Text = finalInterRate.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int sale = ChooseCheckBox();
            trackBar1_Scroll(sender, e, sale); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //������=������/��� + �������*����./12
            int creditNumb = Int32.Parse(textBox1.Text); //��������� � ����
            int perc = Convert.ToInt32(finalInterRate);
            monthlyPayment = (creditNumb/ trackBar1.Value) + (perc/12); //������� �� ������� �� ��������� �����.�������
            string answer = "";
            answer += "����� ������� " + textBox1.Text + " ���" + Environment.NewLine 
                     +"���� ������� " + trackBar1.Value + " ���" + Environment.NewLine 
                     + "���������� ������ " + finalInterRate.ToString() + " %" + Environment.NewLine 
                     + "�������� ������� "+ monthlyPayment + " ���";


            Form2 newf = new Form2(this, answer);
            newf.ShowDialog(); //�� ���� �������� �� ������ ����� ������� ������
            
            
        }
    }
}