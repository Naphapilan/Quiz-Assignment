using System.Text;

namespace Quiz
{

    public partial class Form1 : Form
    {
        income_and_expenses oCal = new income_and_expenses();
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
                this.dataGridView1.Text = readAllLine[0];

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string listRAW = readAllLine[i];
                    string[] listSplited = listRAW.Split(',');
                    IncomeAndExpenses list = new IncomeAndExpenses(listSplited[0], listSplited[1], listSplited[2]);
                }

            }
        }
        private void addDataToGridView(string list, string income, string expenses)
        {
            this.dataGridView1.Rows.Add(new string[] { list, income, expenses });
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
                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < column; j++)
                        {
                            if (this.dataGridView1.Rows[i].Cells[j].Value != null)
                          {
                                strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    File.WriteAllText(saveFileDialog.FileName, this.dataGridView1.Text, Encoding.UTF8);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxList.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
            
            string income = this.textBox3.Text;
            string expenses = this.textBox4.Text;

            double dInput = Convert.ToDouble(income);
            oCal.addList(income, expenses: expenses);

            double sumIncome = oCal.getIncome();
            textBox5.Text = sumIncome.ToString();

            double sumExpenses = oCal.getExpenses();
            textBox6.Text = sumExpenses.ToString();




        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0) 
            { 
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}