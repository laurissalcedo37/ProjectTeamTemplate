namespace MegaDesk_JimDeMordaunt
{
    partial class AddQuote
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
            this.AddQouteToMenuButton = new System.Windows.Forms.Button();
            this.CustomerFullNameInput = new System.Windows.Forms.TextBox();
            this.CustomerFullNameLabel = new System.Windows.Forms.Label();
            this.NumberDrawersLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.dateTimeQuote = new System.Windows.Forms.DateTimePicker();
            this.NumDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.DeskMatLabel = new System.Windows.Forms.Label();
            this.DeskDepthInput = new System.Windows.Forms.NumericUpDown();
            this.DeskWidthInput = new System.Windows.Forms.NumericUpDown();
            this.RushOrderInput = new System.Windows.Forms.ComboBox();
            this.DesktopMatInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQouteToMenuButton
            // 
            this.AddQouteToMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddQouteToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQouteToMenuButton.Location = new System.Drawing.Point(12, 19);
            this.AddQouteToMenuButton.Name = "AddQouteToMenuButton";
            this.AddQouteToMenuButton.Size = new System.Drawing.Size(193, 44);
            this.AddQouteToMenuButton.TabIndex = 0;
            this.AddQouteToMenuButton.Text = "Main Menu";
            this.AddQouteToMenuButton.UseVisualStyleBackColor = false;
            this.AddQouteToMenuButton.Click += new System.EventHandler(this.AddQouteToMenuButton_Click);
            // 
            // CustomerFullNameInput
            // 
            this.CustomerFullNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFullNameInput.Location = new System.Drawing.Point(487, 35);
            this.CustomerFullNameInput.Name = "CustomerFullNameInput";
            this.CustomerFullNameInput.Size = new System.Drawing.Size(290, 28);
            this.CustomerFullNameInput.TabIndex = 1;
            // 
            // CustomerFullNameLabel
            // 
            this.CustomerFullNameLabel.AutoSize = true;
            this.CustomerFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFullNameLabel.Location = new System.Drawing.Point(268, 35);
            this.CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            this.CustomerFullNameLabel.Size = new System.Drawing.Size(193, 24);
            this.CustomerFullNameLabel.TabIndex = 2;
            this.CustomerFullNameLabel.Text = "Customer Full Name: ";
            // 
            // NumberDrawersLabel
            // 
            this.NumberDrawersLabel.AutoSize = true;
            this.NumberDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberDrawersLabel.Location = new System.Drawing.Point(268, 190);
            this.NumberDrawersLabel.Name = "NumberDrawersLabel";
            this.NumberDrawersLabel.Size = new System.Drawing.Size(173, 24);
            this.NumberDrawersLabel.TabIndex = 7;
            this.NumberDrawersLabel.Text = "Number of Drawers";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(232, 282);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(113, 24);
            this.RushOrderLabel.TabIndex = 0;
            this.RushOrderLabel.Text = "Rush Order:";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(271, 138);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(112, 24);
            this.DeskDepthLabel.TabIndex = 10;
            this.DeskDepthLabel.Text = "Desk Depth ";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(268, 87);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(115, 24);
            this.DeskWidthLabel.TabIndex = 11;
            this.DeskWidthLabel.Text = "Desk Width: ";
            // 
            // dateTimeQuote
            // 
            this.dateTimeQuote.CustomFormat = "MMMM dd yyyy";
            this.dateTimeQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeQuote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeQuote.Location = new System.Drawing.Point(12, 153);
            this.dateTimeQuote.Name = "dateTimeQuote";
            this.dateTimeQuote.Size = new System.Drawing.Size(123, 28);
            this.dateTimeQuote.TabIndex = 50;
            this.dateTimeQuote.TabStop = false;
            this.dateTimeQuote.Value = new System.DateTime(2023, 5, 7, 0, 12, 54, 0);
            this.dateTimeQuote.Visible = false;
            // 
            // NumDrawersInput
            // 
            this.NumDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawersInput.Location = new System.Drawing.Point(487, 190);
            this.NumDrawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDrawersInput.Name = "NumDrawersInput";
            this.NumDrawersInput.Size = new System.Drawing.Size(60, 28);
            this.NumDrawersInput.TabIndex = 13;
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteButton.Location = new System.Drawing.Point(12, 87);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(193, 44);
            this.AddNewQuoteButton.TabIndex = 15;
            this.AddNewQuoteButton.Text = "Add Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = false;
            this.AddNewQuoteButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // DeskMatLabel
            // 
            this.DeskMatLabel.AutoSize = true;
            this.DeskMatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMatLabel.Location = new System.Drawing.Point(580, 282);
            this.DeskMatLabel.Name = "DeskMatLabel";
            this.DeskMatLabel.Size = new System.Drawing.Size(153, 24);
            this.DeskMatLabel.TabIndex = 51;
            this.DeskMatLabel.Text = "Desktop Material ";
            // 
            // DeskDepthInput
            // 
            this.DeskDepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthInput.Location = new System.Drawing.Point(487, 138);
            this.DeskDepthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DeskDepthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepthInput.Name = "DeskDepthInput";
            this.DeskDepthInput.Size = new System.Drawing.Size(60, 28);
            this.DeskDepthInput.TabIndex = 3;
            this.DeskDepthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskDepthInput_KeyPress);
            // 
            // DeskWidthInput
            // 
            this.DeskWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInput.Location = new System.Drawing.Point(487, 85);
            this.DeskWidthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.DeskWidthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Size = new System.Drawing.Size(60, 28);
            this.DeskWidthInput.TabIndex = 2;
            this.DeskWidthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // RushOrderInput
            // 
            this.RushOrderInput.BackColor = System.Drawing.Color.Teal;
            this.RushOrderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushOrderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderInput.FormattingEnabled = true;
            this.RushOrderInput.Items.AddRange(new object[] {
            "3 day",
            "5 day",
            "7 day",
            "14 day regular"});
            this.RushOrderInput.Location = new System.Drawing.Point(236, 318);
            this.RushOrderInput.Name = "RushOrderInput";
            this.RushOrderInput.Size = new System.Drawing.Size(202, 30);
            this.RushOrderInput.TabIndex = 55;
            // 
            // DesktopMatInput
            // 
            this.DesktopMatInput.BackColor = System.Drawing.Color.Teal;
            this.DesktopMatInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DesktopMatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMatInput.FormattingEnabled = true;
            this.DesktopMatInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.DesktopMatInput.Location = new System.Drawing.Point(584, 318);
            this.DesktopMatInput.Name = "DesktopMatInput";
            this.DesktopMatInput.Size = new System.Drawing.Size(202, 30);
            this.DesktopMatInput.TabIndex = 56;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.Controls.Add(this.DesktopMatInput);
            this.Controls.Add(this.RushOrderInput);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.DeskDepthInput);
            this.Controls.Add(this.DeskMatLabel);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Controls.Add(this.NumDrawersInput);
            this.Controls.Add(this.dateTimeQuote);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.NumberDrawersLabel);
            this.Controls.Add(this.CustomerFullNameLabel);
            this.Controls.Add(this.CustomerFullNameInput);
            this.Controls.Add(this.AddQouteToMenuButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQouteToMenuButton;
        private System.Windows.Forms.TextBox CustomerFullNameInput;
        private System.Windows.Forms.Label CustomerFullNameLabel;
        private System.Windows.Forms.Label NumberDrawersLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.DateTimePicker dateTimeQuote;
        private System.Windows.Forms.NumericUpDown NumDrawersInput;
        private System.Windows.Forms.Button AddNewQuoteButton;
        private System.Windows.Forms.Label DeskMatLabel;
        private System.Windows.Forms.NumericUpDown DeskDepthInput;
        private System.Windows.Forms.NumericUpDown DeskWidthInput;
        private System.Windows.Forms.ComboBox RushOrderInput;
        private System.Windows.Forms.ComboBox DesktopMatInput;
    }
}