namespace Sorter
{
    partial class Form1
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
            this.btnNum = new System.Windows.Forms.Button();
            this.btnLetters = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(27, 65);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 0;
            this.btnNum.Text = "Numbers";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnLetters
            // 
            this.btnLetters.Location = new System.Drawing.Point(121, 65);
            this.btnLetters.Name = "btnLetters";
            this.btnLetters.Size = new System.Drawing.Size(75, 23);
            this.btnLetters.TabIndex = 1;
            this.btnLetters.Text = "Letters";
            this.btnLetters.UseVisualStyleBackColor = true;
            this.btnLetters.Click += new System.EventHandler(this.btnLetters_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(216, 65);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Colors";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What do you want to sort?";
            // 
            // cboxColor
            // 
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
            this.cboxColor.Location = new System.Drawing.Point(314, 65);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(75, 21);
            this.cboxColor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 124);
            this.Controls.Add(this.cboxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnLetters);
            this.Controls.Add(this.btnNum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnLetters;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboxColor;
    }
}

