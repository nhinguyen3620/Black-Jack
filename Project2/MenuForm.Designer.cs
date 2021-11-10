
namespace Project2
{
    partial class MenuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seedVal = new System.Windows.Forms.TextBox();
            this.numDeckLabel = new System.Windows.Forms.Label();
            this.seedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.softMode = new System.Windows.Forms.CheckBox();
            this.hardMode = new System.Windows.Forms.CheckBox();
            this.numDeckVal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "NEW PLAYER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "HELP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Black Jack";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seedVal
            // 
            this.seedVal.Location = new System.Drawing.Point(222, 157);
            this.seedVal.Name = "seedVal";
            this.seedVal.Size = new System.Drawing.Size(85, 20);
            this.seedVal.TabIndex = 4;
            // 
            // numDeckLabel
            // 
            this.numDeckLabel.AutoSize = true;
            this.numDeckLabel.Location = new System.Drawing.Point(219, 92);
            this.numDeckLabel.Name = "numDeckLabel";
            this.numDeckLabel.Size = new System.Drawing.Size(63, 13);
            this.numDeckLabel.TabIndex = 5;
            this.numDeckLabel.Text = "# of Decks:";
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(219, 141);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(35, 13);
            this.seedLabel.TabIndex = 6;
            this.seedLabel.Text = "Seed:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.softMode);
            this.groupBox1.Controls.Add(this.hardMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 61);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // softMode
            // 
            this.softMode.AutoSize = true;
            this.softMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softMode.Location = new System.Drawing.Point(6, 28);
            this.softMode.Name = "softMode";
            this.softMode.Size = new System.Drawing.Size(60, 17);
            this.softMode.TabIndex = 27;
            this.softMode.Text = "Soft 17";
            this.softMode.UseVisualStyleBackColor = true;
            this.softMode.CheckedChanged += new System.EventHandler(this.softMode_CheckedChanged);
            // 
            // hardMode
            // 
            this.hardMode.AutoSize = true;
            this.hardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardMode.Location = new System.Drawing.Point(72, 28);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(64, 17);
            this.hardMode.TabIndex = 28;
            this.hardMode.Text = "Hard 17";
            this.hardMode.UseVisualStyleBackColor = true;
            this.hardMode.CheckedChanged += new System.EventHandler(this.hardMode_CheckedChanged);
            // 
            // numDeckVal
            // 
            this.numDeckVal.FormattingEnabled = true;
            this.numDeckVal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numDeckVal.Location = new System.Drawing.Point(222, 108);
            this.numDeckVal.Name = "numDeckVal";
            this.numDeckVal.Size = new System.Drawing.Size(85, 21);
            this.numDeckVal.TabIndex = 32;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(328, 433);
            this.Controls.Add(this.numDeckVal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.numDeckLabel);
            this.Controls.Add(this.seedVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seedVal;
        private System.Windows.Forms.Label numDeckLabel;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox softMode;
        private System.Windows.Forms.CheckBox hardMode;
        private System.Windows.Forms.ComboBox numDeckVal;
    }
}