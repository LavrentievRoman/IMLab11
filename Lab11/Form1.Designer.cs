namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.meanNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.varianceNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeNum = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startButton = new System.Windows.Forms.Button();
            this.chiLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.meanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мат. ожидание";
            // 
            // meanNum
            // 
            this.meanNum.DecimalPlaces = 2;
            this.meanNum.Location = new System.Drawing.Point(12, 25);
            this.meanNum.Name = "meanNum";
            this.meanNum.Size = new System.Drawing.Size(120, 20);
            this.meanNum.TabIndex = 1;
            this.meanNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дисперсия";
            // 
            // varianceNum
            // 
            this.varianceNum.DecimalPlaces = 2;
            this.varianceNum.Location = new System.Drawing.Point(12, 74);
            this.varianceNum.Name = "varianceNum";
            this.varianceNum.Size = new System.Drawing.Size(120, 20);
            this.varianceNum.TabIndex = 3;
            this.varianceNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер выборки";
            // 
            // sizeNum
            // 
            this.sizeNum.Location = new System.Drawing.Point(12, 124);
            this.sizeNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sizeNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeNum.Name = "sizeNum";
            this.sizeNum.Size = new System.Drawing.Size(120, 20);
            this.sizeNum.TabIndex = 5;
            this.sizeNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(187, 9);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(601, 325);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 211);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 43);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiLabel.Location = new System.Drawing.Point(297, 413);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(14, 16);
            this.chiLabel.TabIndex = 41;
            this.chiLabel.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(184, 411);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 16);
            this.label.TabIndex = 40;
            this.label.Text = "Кси-квадрат:";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varianceLabel.Location = new System.Drawing.Point(297, 383);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(14, 16);
            this.varianceLabel.TabIndex = 39;
            this.varianceLabel.Text = "0";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label111.Location = new System.Drawing.Point(184, 381);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(80, 16);
            this.label111.TabIndex = 38;
            this.label111.Text = "Дисперсия:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meanLabel.Location = new System.Drawing.Point(297, 358);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(14, 16);
            this.meanLabel.TabIndex = 37;
            this.meanLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(184, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Мат. ожидание:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sizeNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varianceNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meanNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.meanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown meanNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown varianceNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sizeNum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label label7;
    }
}

