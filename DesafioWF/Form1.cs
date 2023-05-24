namespace DesafioWF
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        Aluno pessoa = null;

        void lerLinhaZ(string linha)
        {
            string[] dados = linha.Split('-');

            pessoa = new Aluno();

            // o primeiro dado recebido é indice 1 pois o indice 0 seria a letra (Z / Y)
            pessoa.Nome = dados[1];
            pessoa.Cidade = dados[3];
            pessoa.RG = dados[4];
            pessoa.CPF = dados[5];

            pessoas.Add(pessoa);

        }

        void lerLinhaY(string linha)
        {
            string[] dados = linha.Split('-');

            pessoa = new Aluno();

            Pessoa alunoAtual = pessoas[(pessoas.Count) - 1];
            // Se a função lerLinhaY for chamada, quer dizer que a pessoa da linha Z anterior é um aluno,
            // logo a ultima pessoa da lista de pessoas é o alunoAtual.

            pessoa.CodigoMatricula = dados[1];
            pessoa.CodigoCurso = dados[2];
            pessoa.Curso = dados[3];
            pessoa.Nome = alunoAtual.Nome;

            alunos.Add(pessoa);
        }
        public Form1()
        {
            InitializeComponent();

            string[] linhasCSV = File.ReadAllLines("csv.txt");

            for (int i = 0; i < linhasCSV.Length; i++)
            {
                string linha = linhasCSV[i];

                if (linha.StartsWith("Z-") && (i + 1 < linha.Length) && (!linha.Substring(i + 1).StartsWith("Z-")))
                {
                    lerLinhaZ(linha);
                }
                else if (linha.StartsWith("Y-"))
                {
                    if (pessoa != null)
                    {
                        lerLinhaY(linha);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1Dados.Multiline = true;
            textBox1Dados.ReadOnly = true;

            textBox1Dados.AppendText($"A quantidade de objetos Pessoa é: {pessoas.Count} {System.Environment.NewLine}");
            textBox1Dados.AppendText($"A quantidade de objetos Aluno é: {alunos.Count} {System.Environment.NewLine} {System.Environment.NewLine}");

            textBox1Dados.AppendText($"Essas são todas as pessoas: {System.Environment.NewLine} {System.Environment.NewLine}");


            foreach (Pessoa pessoaB in pessoas)
            {
                textBox1Dados.AppendText($"{pessoaB.Nome} {System.Environment.NewLine}");
            }

            textBox1Dados.AppendText($"{System.Environment.NewLine}");
            textBox1Dados.AppendText($"Esses são os cursos dos Alunos: {System.Environment.NewLine} {System.Environment.NewLine}");

            foreach (Aluno alunoB in alunos)
            {
                textBox1Dados.AppendText($"{alunoB.Nome} : {alunoB.Curso} {System.Environment.NewLine}");
            }
        }
    }
}