using System.Text;

namespace _643450327_0
{
    public partial class Form1 : Form
    {
        _643450327_0 oListcal = new _643450327_0();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*.csv)|*.csv";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
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
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(saveFileDialog.FileName != String.Empty)
                {
                    filepath = saveFileDialog.FileName;

                   

                    File.WriteAllText(saveFileDialog.FileName, this.textBox1.Text, Encoding.UTF8);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string list = this.textBoxList.Text;
            string amount = this.textBox2.Text;
            string type = this.comboBox1.Text;

            double dList = Convert.ToDouble(list);
            oListcal.addlist(dList, amount, type);

            double income = oListcal.getSumIncome();
            textBox3.Text = income.ToString();

            double expenses = oListcal.getSunExpenses();
            textBox4.Text = expenses.ToString();

            textBox1.Text = oListcal.getAlldata();
        }

    }
}