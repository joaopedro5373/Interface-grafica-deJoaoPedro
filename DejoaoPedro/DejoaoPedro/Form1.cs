namespace DejoaoPedro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBoxConteudo.Text = text;
                labelDeJoaoPedro.Text = filename;
            }

        }

        private void button_encriptar_Click(object sender, EventArgs e)
        {
            string textoEncriptado = "";
            foreach (char c in textBoxConteudo.Text)
            {
                textoEncriptado += (char)(c + 4);
            }
            textBoxConteudo.Text = textoEncriptado;
        }

        private void button_desencriptar_Click(object sender, EventArgs e)
        {
            string textoDesencriptado = "";
            foreach (char c in textBoxConteudo.Text)
            {
                textoDesencriptado += (char)(c - 4);
            }
            textBoxConteudo.Text = textoDesencriptado;
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                var result = sfd.ShowDialog(this);
                if (result != DialogResult.OK) return;

                filename = sfd.FileName;
                labelDeJoaoPedro.Text = filename;
                if (!File.Exists(filename)) File.Create(filename).Close();
            }
            File.WriteAllText(filename, textBoxConteudo.Text);
            MessageBox.Show("Arquivo salvo com sucesso");
        
        }
    }
}
