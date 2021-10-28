
namespace Project2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.seedVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalMoney = new System.Windows.Forms.TextBox();
            this.betMoney = new System.Windows.Forms.TextBox();
            this.dealer_card1 = new System.Windows.Forms.PictureBox();
            this.dealer_card3 = new System.Windows.Forms.PictureBox();
            this.dealer_card2 = new System.Windows.Forms.PictureBox();
            this.dealer_card5 = new System.Windows.Forms.PictureBox();
            this.dealer_card4 = new System.Windows.Forms.PictureBox();
            this.player1_card5 = new System.Windows.Forms.PictureBox();
            this.player1_card4 = new System.Windows.Forms.PictureBox();
            this.player1_card3 = new System.Windows.Forms.PictureBox();
            this.player1_card2 = new System.Windows.Forms.PictureBox();
            this.player1_card1 = new System.Windows.Forms.PictureBox();
            this.dealerVal = new System.Windows.Forms.TextBox();
            this.playerVal = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.softMode = new System.Windows.Forms.CheckBox();
            this.hardMode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player";
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.playButton.BackColor = System.Drawing.Color.Ivory;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(671, 317);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 40);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a seed: ";
            // 
            // seedVal
            // 
            this.seedVal.Location = new System.Drawing.Point(134, 188);
            this.seedVal.Name = "seedVal";
            this.seedVal.Size = new System.Drawing.Size(63, 20);
            this.seedVal.TabIndex = 7;
            this.seedVal.Text = "999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
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
            // dealer_card1
            // 
            this.dealer_card1.Location = new System.Drawing.Point(252, 42);
            this.dealer_card1.Name = "dealer_card1";
            this.dealer_card1.Size = new System.Drawing.Size(60, 80);
            this.dealer_card1.TabIndex = 12;
            this.dealer_card1.TabStop = false;
            // 
            // dealer_card3
            // 
            this.dealer_card3.Location = new System.Drawing.Point(434, 42);
            this.dealer_card3.Name = "dealer_card3";
            this.dealer_card3.Size = new System.Drawing.Size(60, 80);
            this.dealer_card3.TabIndex = 13;
            this.dealer_card3.TabStop = false;
            // 
            // dealer_card2
            // 
            this.dealer_card2.Location = new System.Drawing.Point(343, 42);
            this.dealer_card2.Name = "dealer_card2";
            this.dealer_card2.Size = new System.Drawing.Size(60, 80);
            this.dealer_card2.TabIndex = 14;
            this.dealer_card2.TabStop = false;
            // 
            // dealer_card5
            // 
            this.dealer_card5.Location = new System.Drawing.Point(606, 42);
            this.dealer_card5.Name = "dealer_card5";
            this.dealer_card5.Size = new System.Drawing.Size(60, 80);
            this.dealer_card5.TabIndex = 15;
            this.dealer_card5.TabStop = false;
            // 
            // dealer_card4
            // 
            this.dealer_card4.Location = new System.Drawing.Point(515, 42);
            this.dealer_card4.Name = "dealer_card4";
            this.dealer_card4.Size = new System.Drawing.Size(60, 80);
            this.dealer_card4.TabIndex = 16;
            this.dealer_card4.TabStop = false;
            // 
            // player1_card5
            // 
            this.player1_card5.Location = new System.Drawing.Point(606, 168);
            this.player1_card5.Name = "player1_card5";
            this.player1_card5.Size = new System.Drawing.Size(60, 80);
            this.player1_card5.TabIndex = 17;
            this.player1_card5.TabStop = false;
            // 
            // player1_card4
            // 
            this.player1_card4.Location = new System.Drawing.Point(515, 168);
            this.player1_card4.Name = "player1_card4";
            this.player1_card4.Size = new System.Drawing.Size(60, 80);
            this.player1_card4.TabIndex = 18;
            this.player1_card4.TabStop = false;
            // 
            // player1_card3
            // 
            this.player1_card3.Location = new System.Drawing.Point(431, 168);
            this.player1_card3.Name = "player1_card3";
            this.player1_card3.Size = new System.Drawing.Size(60, 80);
            this.player1_card3.TabIndex = 19;
            this.player1_card3.TabStop = false;
            // 
            // player1_card2
            // 
            this.player1_card2.Location = new System.Drawing.Point(343, 168);
            this.player1_card2.Name = "player1_card2";
            this.player1_card2.Size = new System.Drawing.Size(60, 80);
            this.player1_card2.TabIndex = 20;
            this.player1_card2.TabStop = false;
            // 
            // player1_card1
            // 
            this.player1_card1.Location = new System.Drawing.Point(252, 168);
            this.player1_card1.Name = "player1_card1";
            this.player1_card1.Size = new System.Drawing.Size(60, 80);
            this.player1_card1.TabIndex = 21;
            this.player1_card1.TabStop = false;
            // 
            // dealerVal
            // 
            this.dealerVal.Location = new System.Drawing.Point(13, 32);
            this.dealerVal.MinimumSize = new System.Drawing.Size(20, 55);
            this.dealerVal.Name = "dealerVal";
            this.dealerVal.ReadOnly = true;
            this.dealerVal.Size = new System.Drawing.Size(108, 29);
            this.dealerVal.TabIndex = 23;
            // 
            // playerVal
            // 
            this.playerVal.Location = new System.Drawing.Point(13, 126);
            this.playerVal.MinimumSize = new System.Drawing.Size(20, 55);
            this.playerVal.Name = "playerVal";
            this.playerVal.ReadOnly = true;
            this.playerVal.Size = new System.Drawing.Size(108, 29);
            this.playerVal.TabIndex = 24;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(392, 359);
            this.result.MinimumSize = new System.Drawing.Size(20, 60);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(130, 60);
            this.result.TabIndex = 26;
            this.result.Visible = false;
            // 
            // softMode
            // 
            this.softMode.AutoSize = true;
            this.softMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softMode.Location = new System.Drawing.Point(20, 28);
            this.softMode.Name = "softMode";
            this.softMode.Size = new System.Drawing.Size(74, 22);
            this.softMode.TabIndex = 27;
            this.softMode.Text = "Soft 17";
            this.softMode.UseVisualStyleBackColor = true;
            // 
            // hardMode
            // 
            this.hardMode.AutoSize = true;
            this.hardMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardMode.Location = new System.Drawing.Point(20, 63);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(79, 22);
            this.hardMode.TabIndex = 28;
            this.hardMode.Text = "Hard 17";
            this.hardMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.softMode);
            this.groupBox1.Controls.Add(this.hardMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 87);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dealerVal);
            this.groupBox2.Controls.Add(this.playerVal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.player1_card1);
            this.Controls.Add(this.player1_card2);
            this.Controls.Add(this.player1_card3);
            this.Controls.Add(this.player1_card4);
            this.Controls.Add(this.player1_card5);
            this.Controls.Add(this.dealer_card4);
            this.Controls.Add(this.dealer_card5);
            this.Controls.Add(this.dealer_card2);
            this.Controls.Add(this.dealer_card3);
            this.Controls.Add(this.dealer_card1);
            this.Controls.Add(this.seedVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_card1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalMoney;
        private System.Windows.Forms.TextBox betMoney;
        private System.Windows.Forms.PictureBox dealer_card1;
        private System.Windows.Forms.PictureBox dealer_card3;
        private System.Windows.Forms.PictureBox dealer_card2;
        private System.Windows.Forms.PictureBox dealer_card5;
        private System.Windows.Forms.PictureBox dealer_card4;
        private System.Windows.Forms.PictureBox player1_card5;
        private System.Windows.Forms.PictureBox player1_card4;
        private System.Windows.Forms.PictureBox player1_card3;
        private System.Windows.Forms.PictureBox player1_card2;
        private System.Windows.Forms.PictureBox player1_card1;
        private System.Windows.Forms.TextBox dealerVal;
        private System.Windows.Forms.TextBox playerVal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.CheckBox softMode;
        private System.Windows.Forms.CheckBox hardMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

