namespace Lab4Main
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string errorMessage)
        {
            InitializeComponent();
            errorMessageLabel.Text = errorMessage;
            this.Width = errorMessageLabel.Width + 50;
            this.Height = errorMessageLabel.Height + 75;
            Load += new EventHandler(ErrorForm_Load);
        }

        private void ErrorForm_Load(object sender, System.EventArgs e)
        {
            this.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}
