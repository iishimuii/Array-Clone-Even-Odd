namespace WindowsFormsApplication1
{
    partial class ArrayCloneEvenOddUi
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
            this.AddDaysButton = new System.Windows.Forms.Button();
            this.dayClonebutton = new System.Windows.Forms.Button();
            this.EvenDaysButton = new System.Windows.Forms.Button();
            this.OddDaysButton = new System.Windows.Forms.Button();
            this.evenDaysLabel = new System.Windows.Forms.Label();
            this.oddDayslabel = new System.Windows.Forms.Label();
            this.firstRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cloneRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddDaysButton
            // 
            this.AddDaysButton.Location = new System.Drawing.Point(8, 54);
            this.AddDaysButton.Name = "AddDaysButton";
            this.AddDaysButton.Size = new System.Drawing.Size(75, 23);
            this.AddDaysButton.TabIndex = 0;
            this.AddDaysButton.Text = "Add Days";
            this.AddDaysButton.UseVisualStyleBackColor = true;
            this.AddDaysButton.Click += new System.EventHandler(this.AddDaysButton_Click);
            // 
            // dayClonebutton
            // 
            this.dayClonebutton.Location = new System.Drawing.Point(106, 54);
            this.dayClonebutton.Name = "dayClonebutton";
            this.dayClonebutton.Size = new System.Drawing.Size(75, 23);
            this.dayClonebutton.TabIndex = 1;
            this.dayClonebutton.Text = "Clone";
            this.dayClonebutton.UseVisualStyleBackColor = true;
            this.dayClonebutton.Click += new System.EventHandler(this.dayClonebutton_Click);
            // 
            // EvenDaysButton
            // 
            this.EvenDaysButton.Location = new System.Drawing.Point(213, 54);
            this.EvenDaysButton.Name = "EvenDaysButton";
            this.EvenDaysButton.Size = new System.Drawing.Size(75, 23);
            this.EvenDaysButton.TabIndex = 2;
            this.EvenDaysButton.Text = "Even Days";
            this.EvenDaysButton.UseVisualStyleBackColor = true;
            this.EvenDaysButton.Click += new System.EventHandler(this.EvenDaysButton_Click);
            // 
            // OddDaysButton
            // 
            this.OddDaysButton.Location = new System.Drawing.Point(329, 54);
            this.OddDaysButton.Name = "OddDaysButton";
            this.OddDaysButton.Size = new System.Drawing.Size(75, 23);
            this.OddDaysButton.TabIndex = 3;
            this.OddDaysButton.Text = "Odd Days";
            this.OddDaysButton.UseVisualStyleBackColor = true;
            this.OddDaysButton.Click += new System.EventHandler(this.OddDaysButton_Click);
            // 
            // evenDaysLabel
            // 
            this.evenDaysLabel.AutoSize = true;
            this.evenDaysLabel.Location = new System.Drawing.Point(225, 110);
            this.evenDaysLabel.Name = "evenDaysLabel";
            this.evenDaysLabel.Size = new System.Drawing.Size(0, 13);
            this.evenDaysLabel.TabIndex = 4;
            // 
            // oddDayslabel
            // 
            this.oddDayslabel.AutoSize = true;
            this.oddDayslabel.Location = new System.Drawing.Point(345, 110);
            this.oddDayslabel.Name = "oddDayslabel";
            this.oddDayslabel.Size = new System.Drawing.Size(0, 13);
            this.oddDayslabel.TabIndex = 5;
            // 
            // firstRichTextBox
            // 
            this.firstRichTextBox.Location = new System.Drawing.Point(8, 107);
            this.firstRichTextBox.Name = "firstRichTextBox";
            this.firstRichTextBox.Size = new System.Drawing.Size(83, 113);
            this.firstRichTextBox.TabIndex = 6;
            this.firstRichTextBox.Text = "";
            // 
            // cloneRichTextBox
            // 
            this.cloneRichTextBox.Location = new System.Drawing.Point(106, 107);
            this.cloneRichTextBox.Name = "cloneRichTextBox";
            this.cloneRichTextBox.Size = new System.Drawing.Size(77, 113);
            this.cloneRichTextBox.TabIndex = 7;
            this.cloneRichTextBox.Text = "";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(8, 12);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 8;
            // 
            // ArrayCloneEvenOddUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.cloneRichTextBox);
            this.Controls.Add(this.firstRichTextBox);
            this.Controls.Add(this.oddDayslabel);
            this.Controls.Add(this.evenDaysLabel);
            this.Controls.Add(this.OddDaysButton);
            this.Controls.Add(this.EvenDaysButton);
            this.Controls.Add(this.dayClonebutton);
            this.Controls.Add(this.AddDaysButton);
            this.Name = "ArrayCloneEvenOddUi";
            this.Text = "ArrayCloneEvenOddUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDaysButton;
        private System.Windows.Forms.Button dayClonebutton;
        private System.Windows.Forms.Button EvenDaysButton;
        private System.Windows.Forms.Button OddDaysButton;
        private System.Windows.Forms.Label evenDaysLabel;
        private System.Windows.Forms.Label oddDayslabel;
        private System.Windows.Forms.RichTextBox firstRichTextBox;
        private System.Windows.Forms.RichTextBox cloneRichTextBox;
        private System.Windows.Forms.TextBox addTextBox;
    }
}