namespace MegaDesk_JimDeMordaunt
{
    partial class ViewAllQuotes
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
            this.AllQuotesToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllQuotesToMenu
            // 
            this.AllQuotesToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AllQuotesToMenu.Location = new System.Drawing.Point(542, 288);
            this.AllQuotesToMenu.Name = "AllQuotesToMenu";
            this.AllQuotesToMenu.Size = new System.Drawing.Size(203, 59);
            this.AllQuotesToMenu.TabIndex = 0;
            this.AllQuotesToMenu.Text = "Main Menu";
            this.AllQuotesToMenu.UseVisualStyleBackColor = false;
            this.AllQuotesToMenu.Click += new System.EventHandler(this.AllQuotesToMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllQuotesToMenu);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllQuotesToMenu;
    }
}