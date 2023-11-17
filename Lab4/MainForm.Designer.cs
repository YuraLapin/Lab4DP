namespace Lab4Main
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseDecryptedButton = new Button();
            chooseEncryptedFile = new Button();
            startEnctyptionButton = new Button();
            startDecryptionButton = new Button();
            keyGenButton = new Button();
            keyTextBox = new TextBox();
            SuspendLayout();
            // 
            // chooseDecryptedButton
            // 
            chooseDecryptedButton.Location = new Point(12, 12);
            chooseDecryptedButton.Name = "chooseDecryptedButton";
            chooseDecryptedButton.Size = new Size(243, 23);
            chooseDecryptedButton.TabIndex = 0;
            chooseDecryptedButton.Text = "Указать путь к расшифрованному файлу";
            chooseDecryptedButton.UseVisualStyleBackColor = true;
            chooseDecryptedButton.Click += chooseDecryptedButton_Click;
            // 
            // chooseEncryptedFile
            // 
            chooseEncryptedFile.Location = new Point(12, 41);
            chooseEncryptedFile.Name = "chooseEncryptedFile";
            chooseEncryptedFile.Size = new Size(243, 23);
            chooseEncryptedFile.TabIndex = 1;
            chooseEncryptedFile.Text = "Указать путь к зашифрованному файлу";
            chooseEncryptedFile.UseVisualStyleBackColor = true;
            chooseEncryptedFile.Click += chooseEncryptedFile_Click;
            // 
            // startEnctyptionButton
            // 
            startEnctyptionButton.Location = new Point(277, 12);
            startEnctyptionButton.Name = "startEnctyptionButton";
            startEnctyptionButton.Size = new Size(101, 23);
            startEnctyptionButton.TabIndex = 2;
            startEnctyptionButton.Text = "Зашифровать";
            startEnctyptionButton.UseVisualStyleBackColor = true;
            startEnctyptionButton.Click += startEnctyptionButton_Click;
            // 
            // startDecryptionButton
            // 
            startDecryptionButton.Location = new Point(277, 41);
            startDecryptionButton.Name = "startDecryptionButton";
            startDecryptionButton.Size = new Size(101, 23);
            startDecryptionButton.TabIndex = 3;
            startDecryptionButton.Text = "Расшифровать";
            startDecryptionButton.UseVisualStyleBackColor = true;
            startDecryptionButton.Click += startDecryptionButton_Click;
            // 
            // keyGenButton
            // 
            keyGenButton.Location = new Point(12, 97);
            keyGenButton.Name = "keyGenButton";
            keyGenButton.Size = new Size(142, 23);
            keyGenButton.TabIndex = 4;
            keyGenButton.Text = "Сгенерировать ключ";
            keyGenButton.UseVisualStyleBackColor = true;
            keyGenButton.Click += keyGenButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(12, 126);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(366, 131);
            keyTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 271);
            Controls.Add(keyTextBox);
            Controls.Add(keyGenButton);
            Controls.Add(startDecryptionButton);
            Controls.Add(startEnctyptionButton);
            Controls.Add(chooseEncryptedFile);
            Controls.Add(chooseDecryptedButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseDecryptedButton;
        private Button chooseEncryptedFile;
        private Button startEnctyptionButton;
        private Button startDecryptionButton;
        private Button keyGenButton;
        public TextBox keyTextBox;
    }
}