namespace Lab4Main
{
    partial class ErrorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorMessageLabel.Location = new Point(12, 9);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(99, 20);
            errorMessageLabel.TabIndex = 0;
            errorMessageLabel.Text = "errorMessage";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 71);
            Controls.Add(errorMessageLabel);
            Name = "ErrorForm";
            Text = "ERROR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorMessageLabel;
    }
}