
namespace Project_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rollButton = new System.Windows.Forms.Button();
            this.stas = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.seedVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxCount1 = new System.Windows.Forms.TextBox();
            this.minCount1 = new System.Windows.Forms.TextBox();
            this.mean1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxCount2 = new System.Windows.Forms.TextBox();
            this.minCount2 = new System.Windows.Forms.TextBox();
            this.mean2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mean3 = new System.Windows.Forms.TextBox();
            this.max3 = new System.Windows.Forms.TextBox();
            this.min3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Silver;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(1013, 129);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(96, 49);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "ROLL!";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // stas
            // 
            this.stas.BackColor = System.Drawing.Color.Silver;
            this.stas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stas.Location = new System.Drawing.Point(142, 275);
            this.stas.Name = "stas";
            this.stas.Size = new System.Drawing.Size(142, 36);
            this.stas.TabIndex = 1;
            this.stas.Text = "STATISTICS!";
            this.stas.UseVisualStyleBackColor = false;
            this.stas.Click += new System.EventHandler(this.stas_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resetButton.Location = new System.Drawing.Point(695, 24);
            this.resetButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 58);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "60",
            "600",
            "6000",
            "60000"});
            this.comboBox.Location = new System.Drawing.Point(164, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(120, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.Text = "Please choose";
            // 
            // seedVal
            // 
            this.seedVal.Location = new System.Drawing.Point(465, 26);
            this.seedVal.Name = "seedVal";
            this.seedVal.ReadOnly = true;
            this.seedVal.Size = new System.Drawing.Size(120, 20);
            this.seedVal.TabIndex = 4;
            this.seedVal.Text = "999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the seeds:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Tan;
            this.chart1.BorderlineColor = System.Drawing.Color.Peru;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 317);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dice 1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Dice 2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(555, 287);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // pic2
            // 
            this.pic2.Image = global::Project_1.Properties.Resources.face1;
            this.pic2.Location = new System.Drawing.Point(935, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(101, 95);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::Project_1.Properties.Resources.face1;
            this.pic1.Location = new System.Drawing.Point(1065, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(101, 95);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 8;
            this.pic1.TabStop = false;
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.Color.Silver;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(837, 275);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(142, 36);
            this.sumButton.TabIndex = 9;
            this.sumButton.Text = "SUM OF 2 DICES";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of rolls:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxCount1);
            this.groupBox1.Controls.Add(this.minCount1);
            this.groupBox1.Controls.Add(this.mean1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 119);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice 1";
            // 
            // maxCount1
            // 
            this.maxCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCount1.Location = new System.Drawing.Point(102, 91);
            this.maxCount1.Name = "maxCount1";
            this.maxCount1.ReadOnly = true;
            this.maxCount1.Size = new System.Drawing.Size(111, 22);
            this.maxCount1.TabIndex = 19;
            // 
            // minCount1
            // 
            this.minCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCount1.Location = new System.Drawing.Point(102, 56);
            this.minCount1.Name = "minCount1";
            this.minCount1.Size = new System.Drawing.Size(111, 22);
            this.minCount1.TabIndex = 18;
            // 
            // mean1
            // 
            this.mean1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mean1.Location = new System.Drawing.Point(102, 21);
            this.mean1.Name = "mean1";
            this.mean1.ReadOnly = true;
            this.mean1.Size = new System.Drawing.Size(111, 22);
            this.mean1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mean";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Min Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Max Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxCount2);
            this.groupBox2.Controls.Add(this.minCount2);
            this.groupBox2.Controls.Add(this.mean2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 119);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dice 2";
            // 
            // maxCount2
            // 
            this.maxCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCount2.Location = new System.Drawing.Point(100, 90);
            this.maxCount2.Name = "maxCount2";
            this.maxCount2.ReadOnly = true;
            this.maxCount2.Size = new System.Drawing.Size(126, 22);
            this.maxCount2.TabIndex = 16;
            // 
            // minCount2
            // 
            this.minCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCount2.Location = new System.Drawing.Point(100, 57);
            this.minCount2.Name = "minCount2";
            this.minCount2.ReadOnly = true;
            this.minCount2.Size = new System.Drawing.Size(126, 22);
            this.minCount2.TabIndex = 17;
            // 
            // mean2
            // 
            this.mean2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mean2.Location = new System.Drawing.Point(100, 23);
            this.mean2.Name = "mean2";
            this.mean2.ReadOnly = true;
            this.mean2.Size = new System.Drawing.Size(126, 22);
            this.mean2.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Max Count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Min Count";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mean";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 167);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Tan;
            this.chart2.BorderlineColor = System.Drawing.Color.Peru;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(602, 317);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sum";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(555, 287);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.min3);
            this.groupBox4.Controls.Add(this.max3);
            this.groupBox4.Controls.Add(this.mean3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(602, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 167);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sum Of 2 Dices\' Summary";
            // 
            // mean3
            // 
            this.mean3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mean3.Location = new System.Drawing.Point(157, 33);
            this.mean3.Name = "mean3";
            this.mean3.Size = new System.Drawing.Size(100, 22);
            this.mean3.TabIndex = 17;
            // 
            // max3
            // 
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.Location = new System.Drawing.Point(157, 78);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(100, 22);
            this.max3.TabIndex = 18;
            // 
            // min3
            // 
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.Location = new System.Drawing.Point(157, 125);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(100, 22);
            this.min3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mean";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Min Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Max Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1178, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedVal);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Roll a Dice!";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button stas;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox seedVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mean1;
        private System.Windows.Forms.TextBox maxCount2;
        private System.Windows.Forms.TextBox minCount2;
        private System.Windows.Forms.TextBox mean2;
        private System.Windows.Forms.TextBox maxCount1;
        private System.Windows.Forms.TextBox minCount1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox min3;
        private System.Windows.Forms.TextBox max3;
        private System.Windows.Forms.TextBox mean3;
    }
}

