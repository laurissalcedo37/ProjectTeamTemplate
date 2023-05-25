namespace MegaDesk_JimDeMordaunt
{
    partial class SearchQuotes
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
            this.SearchToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchToMenuButton
            // 
            this.SearchToMenuButton.Location = new System.Drawing.Point(9, 10);
            this.SearchToMenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchToMenuButton.Name = "SearchToMenuButton";
            this.SearchToMenuButton.Size = new System.Drawing.Size(125, 41);
            this.SearchToMenuButton.TabIndex = 0;
            this.SearchToMenuButton.Text = "Main Menu";
            this.SearchToMenuButton.UseVisualStyleBackColor = true;
            this.SearchToMenuButton.Click += new System.EventHandler(this.SearchToMenuButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SearchToMenuButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchToMenuButton;
    }
}