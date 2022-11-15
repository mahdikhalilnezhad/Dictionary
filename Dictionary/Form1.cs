namespace Dictionary
{
    public partial class Form1 : Form
    {
        dictionary dictionary = new dictionary(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                AttachDbFilename=E:\C_sharp_practice\Dictionary\Dictionary\DictionaryDataBase.mdf;
                                Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connctionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
            //                        AttachDbFilename=E:\C_sharp_practice\Dictionary\Dictionary\DictionaryDataBase.mdf;
            //                        Integrated Security=True";

            showData();



        }

        void showData(string word = null)
        {
            dataGridView_EnglishWord.DataSource = dictionary.ReturnRecordes(word);
            dataGridView_EnglishWord.Columns[0].Width = dataGridView_EnglishWord.Width;

        }

        private void dataGridView_EnglishWord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_EnglishWord_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txtTranslate.Text = dataGridView_EnglishWord.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void txtEnglishWord_TextChanged(object sender, EventArgs e)
        {
            showData(txtEnglishWord.Text);
        }
    }
}