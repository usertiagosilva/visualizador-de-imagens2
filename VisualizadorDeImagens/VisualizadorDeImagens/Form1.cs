namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Criar um OpenFileDialog para permitir a seleção de uma imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Definir os tipos de arquivo que o usuário pode selecionar
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            // Verificar se o usuário selecionou um arquivo válido
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carregar a imagem no PictureBox
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }
    }
}
