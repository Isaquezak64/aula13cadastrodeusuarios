namespace aula13cadastrodeusuarios
{
    public partial class Form1 : Form
    {
        List<Pessoas> pessoas = new List<Pessoas>();
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaInterface()
        {
            for (int i = 0; i < pessoas.Count; i++) {
                listView1.Items.Add(pessoas[i].nome);

            
            }
            listView1.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;

            Pessoas pessoa = new Pessoas(nome, idade, rua, cidade);
            pessoas.Add(pessoa);
        }
    }
}