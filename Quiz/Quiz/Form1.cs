using System.Text;

namespace Quiz
{
    public partial class Form1 : Form
    {
        Quiz oListcal = new Quiz();
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                this.textBox1.Text = readAllLine[0];
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strData = string.Empty;
            string filepath = String.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = " CSV(*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != String.Empty)
                {
                    filepath = saveFileDialog.FileName;



                    File.WriteAllText(saveFileDialog.FileName, this.textBox1.Text, Encoding.UTF8);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string list = this.textBoxList.Text;
            string amount = this.textBox3.Text;
            string type = this.textBox4.Text;

            double dList = Convert.ToDouble(list);
            oListcal.addlist(dList, amount, type);

            double income = oListcal.getSumIncome();
            textBox5.Text = income.ToString();

            double expenses = oListcal.getSunExpenses();
            textBox6.Text = expenses.ToString();

            textBox1.Text = oListcal.getAlldata();
        }
    }
}