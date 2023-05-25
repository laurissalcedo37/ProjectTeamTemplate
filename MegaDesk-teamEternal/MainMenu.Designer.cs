namespace MegaDesk_JimDeMordaunt
{
    partial class MainMenu
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
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteButton.Location = new System.Drawing.Point(51, 38);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(190, 61);
            this.AddNewQuoteButton.TabIndex = 0;
            this.AddNewQuoteButton.Text = "Add New Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = false;
            this.AddNewQuoteButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(51, 273);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 63);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesButton.Location = new System.Drawing.Point(51, 193);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(190, 62);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = false;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ViewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesButton.Location = new System.Drawing.Point(51, 114);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(190, 61);
            this.ViewQuotesButton.TabIndex = 3;
            this.ViewQuotesButton.Text = "View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = false;
            this.ViewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(657, 389);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ViewQuotesButton;
    }
}

