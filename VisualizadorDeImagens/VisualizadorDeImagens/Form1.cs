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
            // Criar um OpenFileDialog para permitir a sele��o de uma imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Definir os tipos de arquivo que o usu�rio pode selecionar
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

            // Verificar se o usu�rio selecionou um arquivo v�lido
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
