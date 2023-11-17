namespace Lab4Main
{
    public partial class MainForm : Form
    {
        public MainFormLoader loader = new MainFormLoader();
        public MainFormUpdater updater = new MainFormUpdater();

        public BinaryReader reader = new BinaryReader();
        public BinaryPrinter printer = new BinaryPrinter();

        public Encryptor encryptor = new Encryptor();

        private string decryptedPath = "";
        private string encryptedPath = "";

        private string decryptedText = "";
        private string encryptedText = "";

        public string key = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private bool CheckInputs()
        {
            if (decryptedPath == "")
            {
                var errorForm = new ErrorForm("”казан неверный путь к расшифрованному файлу");
                errorForm.ShowDialog();
                return false;
            }

            if (encryptedPath == "")
            {
                var errorForm = new ErrorForm("”казан неверный путь к зашифрованному файлу");
                errorForm.ShowDialog();
                return false;
            }

            if (key == "")
            {
                var errorForm = new ErrorForm("—начала сгенерируйте ключ");
                errorForm.ShowDialog();
                return false;
            }

            return true;
        }

        private void chooseDecryptedButton_Click(object sender, EventArgs e)
        {
            decryptedPath = loader.Load("text files (*.txt)|*.txt");
        }

        private void startEnctyptionButton_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
            {
                return;
            }

            decryptedText = reader.Read(decryptedPath);
            string txt = encryptor.Encrypt(decryptedText, key);
            printer.Print(encryptedPath, txt);
        }

        private void chooseEncryptedFile_Click(object sender, EventArgs e)
        {
            encryptedPath = loader.Load("text files (*.txt)|*.txt");
        }

        private void startDecryptionButton_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
            {
                return;
            }

            encryptedText = reader.Read(encryptedPath);
            string txt = encryptor.Decrypt(encryptedText, key);
            printer.Print(decryptedPath, txt);
        }

        private void keyGenButton_Click(object sender, EventArgs e)
        {
            key = encryptor.GenerateKey();
            updater.UpdateTextBox(this);
        }
    }
}