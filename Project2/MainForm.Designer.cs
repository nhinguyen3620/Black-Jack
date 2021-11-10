
namespace Project2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.seedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalMoney = new System.Windows.Forms.TextBox();
            this.betMoney = new System.Windows.Forms.TextBox();
            this.dealerVal = new System.Windows.Forms.TextBox();
            this.playerVal = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gameResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDeckLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDeck = new System.Windows.Forms.Label();
            this.seedV = new System.Windows.Forms.Label();
            this.gameMode = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player";
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(464, 296);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(91, 34);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(353, 296);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(91, 34);
            this.standButton.TabIndex = 3;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Firebrick;
            this.resetButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(671, 390);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 38);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.playButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(671, 317);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 40);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedLabel.Location = new System.Drawing.Point(10, 188);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(0, 20);
            this.seedLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bet ($)";
            // 
            // totalMoney
            // 
            this.totalMoney.Location = new System.Drawing.Point(100, 25);
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.ReadOnly = true;
            this.totalMoney.Size = new System.Drawing.Size(100, 20);
            this.totalMoney.TabIndex = 10;
            this.totalMoney.Text = "100";
            // 
            // betMoney
            // 
            this.betMoney.Location = new System.Drawing.Point(100, 65);
            this.betMoney.Name = "betMoney";
            this.betMoney.Size = new System.Drawing.Size(100, 20);
            this.betMoney.TabIndex = 11;
            // 
            // dealerVal
            // 
            this.dealerVal.Location = new System.Drawing.Point(13, 32);
            this.dealerVal.MinimumSize = new System.Drawing.Size(20, 55);
            this.dealerVal.Name = "dealerVal";
            this.dealerVal.ReadOnly = true;
            this.dealerVal.Size = new System.Drawing.Size(108, 55);
            this.dealerVal.TabIndex = 23;
            // 
            // playerVal
            // 
            this.playerVal.Location = new System.Drawing.Point(13, 126);
            this.playerVal.MinimumSize = new System.Drawing.Size(20, 55);
            this.playerVal.Name = "playerVal";
            this.playerVal.ReadOnly = true;
            this.playerVal.Size = new System.Drawing.Size(108, 55);
            this.playerVal.TabIndex = 24;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(392, 359);
            this.result.MinimumSize = new System.Drawing.Size(20, 60);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(130, 20);
            this.result.TabIndex = 26;
            this.result.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dealerVal);
            this.groupBox2.Controls.Add(this.playerVal);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(705, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 195);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.totalMoney);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.betMoney);
            this.groupBox3.Location = new System.Drawing.Point(14, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 108);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // gameResult
            // 
            this.gameResult.AutoSize = true;
            this.gameResult.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResult.Location = new System.Drawing.Point(373, 399);
            this.gameResult.MinimumSize = new System.Drawing.Size(200, 100);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(200, 100);
            this.gameResult.TabIndex = 32;
            this.gameResult.Text = "label6";
            this.gameResult.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 34;
            // 
            // numDeckLabel
            // 
            this.numDeckLabel.AutoSize = true;
            this.numDeckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeckLabel.Location = new System.Drawing.Point(12, 241);
            this.numDeckLabel.Name = "numDeckLabel";
            this.numDeckLabel.Size = new System.Drawing.Size(0, 20);
            this.numDeckLabel.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Number of Decks: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Seed Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Game Mode:";
            // 
            // numDeck
            // 
            this.numDeck.AutoSize = true;
            this.numDeck.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeck.Location = new System.Drawing.Point(157, 49);
            this.numDeck.Name = "numDeck";
            this.numDeck.Size = new System.Drawing.Size(0, 21);
            this.numDeck.TabIndex = 39;
            // 
            // seedV
            // 
            this.seedV.AutoSize = true;
            this.seedV.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedV.Location = new System.Drawing.Point(157, 95);
            this.seedV.Name = "seedV";
            this.seedV.Size = new System.Drawing.Size(0, 21);
            this.seedV.TabIndex = 40;
            // 
            // gameMode
            // 
            this.gameMode.AutoSize = true;
            this.gameMode.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMode.Location = new System.Drawing.Point(157, 142);
            this.gameMode.Name = "gameMode";
            this.gameMode.Size = new System.Drawing.Size(0, 21);
            this.gameMode.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.gameMode);
            this.Controls.Add(this.seedV);
            this.Controls.Add(this.numDeck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDeckLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalMoney;
        private System.Windows.Forms.TextBox betMoney;
        private System.Windows.Forms.TextBox dealerVal;
        private System.Windows.Forms.TextBox playerVal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label gameResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numDeckLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label numDeck;
        private System.Windows.Forms.Label seedV;
        private System.Windows.Forms.Label gameMode;
    }
}

