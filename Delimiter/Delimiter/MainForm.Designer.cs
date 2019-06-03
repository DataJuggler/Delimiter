

#region using statements


#endregion

namespace Delimiter
{

    #region class MainForm
    /// <summary>
    /// This method [Enter Method Description]
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox ItemsTextBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button ClearButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl DelimiterTextBox;
        private System.Windows.Forms.Button AddDelimiterButton;
        private System.Windows.Forms.Button DistinctListButton2;
        private System.Windows.Forms.Label InstructionsLabel;
        private DataJuggler.Win.Controls.LabelCheckBoxControl SingleQuotesCheckbox;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemsTextBox = new System.Windows.Forms.TextBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddDelimiterButton = new System.Windows.Forms.Button();
            this.DistinctListButton2 = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.SingleQuotesCheckbox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.DelimiterTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SuspendLayout();
            // 
            // ItemsTextBox
            // 
            this.ItemsTextBox.Location = new System.Drawing.Point(33, 40);
            this.ItemsTextBox.Multiline = true;
            this.ItemsTextBox.Name = "ItemsTextBox";
            this.ItemsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemsTextBox.Size = new System.Drawing.Size(401, 400);
            this.ItemsTextBox.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ItemsLabel.Location = new System.Drawing.Point(29, 20);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(65, 18);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = global::Delimiter.Properties.Resources.Black_Button;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ClearButton.Location = new System.Drawing.Point(455, 241);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(118, 45);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ClearButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AddDelimiterButton
            // 
            this.AddDelimiterButton.BackColor = System.Drawing.Color.Transparent;
            this.AddDelimiterButton.BackgroundImage = global::Delimiter.Properties.Resources.Black_Button;
            this.AddDelimiterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDelimiterButton.FlatAppearance.BorderSize = 0;
            this.AddDelimiterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddDelimiterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddDelimiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDelimiterButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddDelimiterButton.Location = new System.Drawing.Point(455, 135);
            this.AddDelimiterButton.Name = "AddDelimiterButton";
            this.AddDelimiterButton.Size = new System.Drawing.Size(294, 45);
            this.AddDelimiterButton.TabIndex = 6;
            this.AddDelimiterButton.Text = "Add Delimiter && Copy";
            this.AddDelimiterButton.UseVisualStyleBackColor = false;
            this.AddDelimiterButton.Click += new System.EventHandler(this.AddDelimiter_Click);
            this.AddDelimiterButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.AddDelimiterButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // DistinctListButton2
            // 
            this.DistinctListButton2.BackColor = System.Drawing.Color.Transparent;
            this.DistinctListButton2.BackgroundImage = global::Delimiter.Properties.Resources.Black_Button;
            this.DistinctListButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DistinctListButton2.FlatAppearance.BorderSize = 0;
            this.DistinctListButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DistinctListButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DistinctListButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistinctListButton2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DistinctListButton2.Location = new System.Drawing.Point(455, 188);
            this.DistinctListButton2.Name = "DistinctListButton2";
            this.DistinctListButton2.Size = new System.Drawing.Size(294, 45);
            this.DistinctListButton2.TabIndex = 7;
            this.DistinctListButton2.Text = "Get Distinct List && Copy";
            this.DistinctListButton2.UseVisualStyleBackColor = false;
            this.DistinctListButton2.Click += new System.EventHandler(this.DistinctListButton_Click);
            this.DistinctListButton2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DistinctListButton2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.InstructionsLabel.Location = new System.Drawing.Point(33, 443);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(401, 23);
            this.InstructionsLabel.TabIndex = 71;
            this.InstructionsLabel.Text = "Enter or paste items one per line";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SingleQuotesCheckbox
            // 
            this.SingleQuotesCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.SingleQuotesCheckbox.CheckBoxHorizontalOffSet = 0;
            this.SingleQuotesCheckbox.CheckBoxVerticalOffSet = 4;
            this.SingleQuotesCheckbox.CheckChangedListener = null;
            this.SingleQuotesCheckbox.Checked = false;
            this.SingleQuotesCheckbox.Editable = true;
            this.SingleQuotesCheckbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleQuotesCheckbox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SingleQuotesCheckbox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleQuotesCheckbox.LabelText = "Surround With Single Quotes:";
            this.SingleQuotesCheckbox.LabelWidth = 280;
            this.SingleQuotesCheckbox.Location = new System.Drawing.Point(440, 74);
            this.SingleQuotesCheckbox.Name = "SingleQuotesCheckbox";
            this.SingleQuotesCheckbox.Size = new System.Drawing.Size(369, 28);
            this.SingleQuotesCheckbox.TabIndex = 72;
            // 
            // DelimiterTextBox
            // 
            this.DelimiterTextBox.BackColor = System.Drawing.Color.Transparent;
            this.DelimiterTextBox.BottomMargin = 0;
            this.DelimiterTextBox.Editable = true;
            this.DelimiterTextBox.Encrypted = false;
            this.DelimiterTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelimiterTextBox.LabelBottomMargin = 0;
            this.DelimiterTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.DelimiterTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelimiterTextBox.LabelText = "Delimiter:";
            this.DelimiterTextBox.LabelTopMargin = 4;
            this.DelimiterTextBox.LabelWidth = 128;
            this.DelimiterTextBox.Location = new System.Drawing.Point(534, 40);
            this.DelimiterTextBox.MultiLine = false;
            this.DelimiterTextBox.Name = "DelimiterTextBox";
            this.DelimiterTextBox.OnTextChangedListener = null;
            this.DelimiterTextBox.PasswordMode = false;
            this.DelimiterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DelimiterTextBox.Size = new System.Drawing.Size(198, 28);
            this.DelimiterTextBox.TabIndex = 4;
            this.DelimiterTextBox.TextBoxBottomMargin = 0;
            this.DelimiterTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.DelimiterTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.DelimiterTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 16F);
            this.DelimiterTextBox.TextBoxTopMargin = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Delimiter.Properties.Resources.Deep_Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.SingleQuotesCheckbox);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.DistinctListButton2);
            this.Controls.Add(this.AddDelimiterButton);
            this.Controls.Add(this.DelimiterTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.ItemsTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 540);
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delimiter";
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
