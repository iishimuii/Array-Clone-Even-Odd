namespace WindowsFormsApplication1
{
    partial class ArrayUi
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
            this.firstArrayButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SecArraybutton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EvenButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.evenLabel = new System.Windows.Forms.Label();
            this.oddLabel = new System.Windows.Forms.Label();
            this.cloneRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CloneDayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArrayButton
            // 
            this.firstArrayButton.Location = new System.Drawing.Point(0, 50);
            this.firstArrayButton.Name = "firstArrayButton";
            this.firstArrayButton.Size = new System.Drawing.Size(75, 23);
            this.firstArrayButton.TabIndex = 0;
            this.firstArrayButton.Text = "First Array";
            this.firstArrayButton.UseVisualStyleBackColor = true;
            this.firstArrayButton.Click += new System.EventHandler(this.firstArrayButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 88);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(170, 172);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // SecArraybutton
            // 
            this.SecArraybutton.Location = new System.Drawing.Point(81, 50);
            this.SecArraybutton.Name = "SecArraybutton";
            this.SecArraybutton.Size = new System.Drawing.Size(75, 23);
            this.SecArraybutton.TabIndex = 2;
            this.SecArraybutton.Text = "Sec Array";
            this.SecArraybutton.UseVisualStyleBackColor = true;
            this.SecArraybutton.Click += new System.EventHandler(this.SecArraybutton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(162, 50);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EvenButton
            // 
            this.EvenButton.Location = new System.Drawing.Point(373, 50);
            this.EvenButton.Name = "EvenButton";
            this.EvenButton.Size = new System.Drawing.Size(75, 23);
            this.EvenButton.TabIndex = 5;
            this.EvenButton.Text = "Even ";
            this.EvenButton.UseVisualStyleBackColor = true;
            this.EvenButton.Click += new System.EventHandler(this.EvenButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Odd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // evenLabel
            // 
            this.evenLabel.AutoSize = true;
            this.evenLabel.Location = new System.Drawing.Point(386, 116);
            this.evenLabel.Name = "evenLabel";
            this.evenLabel.Size = new System.Drawing.Size(0, 13);
            this.evenLabel.TabIndex = 7;
            // 
            // oddLabel
            // 
            this.oddLabel.AutoSize = true;
            this.oddLabel.Location = new System.Drawing.Point(481, 116);
            this.oddLabel.Name = "oddLabel";
            this.oddLabel.Size = new System.Drawing.Size(0, 13);
            this.oddLabel.TabIndex = 8;
            // 
            // cloneRichTextBox
            // 
            this.cloneRichTextBox.Location = new System.Drawing.Point(237, 88);
            this.cloneRichTextBox.Name = "cloneRichTextBox";
            this.cloneRichTextBox.Size = new System.Drawing.Size(100, 172);
            this.cloneRichTextBox.TabIndex = 9;
            this.cloneRichTextBox.Text = "";
            // 
            // CloneDayButton
            // 
            this.CloneDayButton.Location = new System.Drawing.Point(262, 50);
            this.CloneDayButton.Name = "CloneDayButton";
            this.CloneDayButton.Size = new System.Drawing.Size(75, 23);
            this.CloneDayButton.TabIndex = 10;
            this.CloneDayButton.Text = "Clon Button";
            this.CloneDayButton.UseVisualStyleBackColor = true;
            this.CloneDayButton.Click += new System.EventHandler(this.CloneDayButton_Click);
            // 
            // ArrayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 313);
            this.Controls.Add(this.CloneDayButton);
            this.Controls.Add(this.cloneRichTextBox);
            this.Controls.Add(this.oddLabel);
            this.Controls.Add(this.evenLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EvenButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.SecArraybutton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.firstArrayButton);
            this.Name = "ArrayUi";
            this.Text = "ArrayUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstArrayButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button SecArraybutton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EvenButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label evenLabel;
        private System.Windows.Forms.Label oddLabel;
        private System.Windows.Forms.RichTextBox cloneRichTextBox;
        private System.Windows.Forms.Button CloneDayButton;
    }
}