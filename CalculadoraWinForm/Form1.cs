namespace CalculadoraWinForm
{
    public partial class Form1 : Form
    {
        List<string> ListHistorico = new List<string>();
        string conta;
        string operacao;
        public Form1()
        {
            InitializeComponent();
            PrimeiroNumero.Text = "0";
            SegundoNumero.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Adição.Checked) { conta = Convert.ToString(Convert.ToDouble(PrimeiroNumero.Text) + Convert.ToDouble(SegundoNumero.Text)); operacao = "+"; }
            else if (Subtração.Checked) { conta = Convert.ToString(Convert.ToDouble(PrimeiroNumero.Text) - Convert.ToDouble(SegundoNumero.Text)); operacao = "-"; }
            else if (Multiplicação.Checked) { conta = Convert.ToString(Convert.ToDouble(PrimeiroNumero.Text) * Convert.ToDouble(SegundoNumero.Text)); operacao = "x"; }
            else if (Divisão.Checked) { conta = Convert.ToString(Convert.ToDouble(PrimeiroNumero.Text) / Convert.ToDouble(SegundoNumero.Text)); operacao = "/"; }
            Resposta.Text = conta;
            ListHistorico.Add(Convert.ToString(PrimeiroNumero.Text) + " " + operacao + " " + Convert.ToString(SegundoNumero.Text) + " = " + conta );
            
            InformacoesContas.Text +=" | "+ListHistorico[ListHistorico.Count-1];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Resposta.Text = "0";
            PrimeiroNumero.Text = "0";
            SegundoNumero.Text = "0";

        }

        private void InformacoesContas_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
