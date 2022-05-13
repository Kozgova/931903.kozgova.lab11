
namespace Лабораторная_11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btStart1 = new System.Windows.Forms.Button();
            this.edMean = new System.Windows.Forms.NumericUpDown();
            this.edVariance = new System.Windows.Forms.NumericUpDown();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAverage = new System.Windows.Forms.Label();
            this.lbVarience = new System.Windows.Forms.Label();
            this.lbSquare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Среднее значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дисперсия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Размер";
            // 
            // btStart1
            // 
            this.btStart1.Location = new System.Drawing.Point(113, 241);
            this.btStart1.Name = "btStart1";
            this.btStart1.Size = new System.Drawing.Size(157, 89);
            this.btStart1.TabIndex = 3;
            this.btStart1.Text = "Сгенерировать";
            this.btStart1.UseVisualStyleBackColor = true;
            this.btStart1.Click += new System.EventHandler(this.btStart1_Click);
            // 
            // edMean
            // 
            this.edMean.DecimalPlaces = 2;
            this.edMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edMean.Location = new System.Drawing.Point(222, 36);
            this.edMean.Name = "edMean";
            this.edMean.Size = new System.Drawing.Size(120, 22);
            this.edMean.TabIndex = 4;
            // 
            // edVariance
            // 
            this.edVariance.DecimalPlaces = 2;
            this.edVariance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edVariance.Location = new System.Drawing.Point(222, 110);
            this.edVariance.Name = "edVariance";
            this.edVariance.Size = new System.Drawing.Size(120, 22);
            this.edVariance.TabIndex = 5;
            this.edVariance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(222, 183);
            this.edSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 22);
            this.edSize.TabIndex = 6;
            this.edSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(444, 36);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(664, 516);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Среднее";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дисперсия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Хи квадрат";
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(209, 411);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(16, 17);
            this.lbAverage.TabIndex = 11;
            this.lbAverage.Text = "0";
            // 
            // lbVarience
            // 
            this.lbVarience.AutoSize = true;
            this.lbVarience.Location = new System.Drawing.Point(209, 476);
            this.lbVarience.Name = "lbVarience";
            this.lbVarience.Size = new System.Drawing.Size(16, 17);
            this.lbVarience.TabIndex = 12;
            this.lbVarience.Text = "0";
            // 
            // lbSquare
            // 
            this.lbSquare.AutoSize = true;
            this.lbSquare.Location = new System.Drawing.Point(209, 535);
            this.lbSquare.Name = "lbSquare";
            this.lbSquare.Size = new System.Drawing.Size(16, 17);
            this.lbSquare.TabIndex = 13;
            this.lbSquare.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 607);
            this.Controls.Add(this.lbSquare);
            this.Controls.Add(this.lbVarience);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edSize);
            this.Controls.Add(this.edVariance);
            this.Controls.Add(this.edMean);
            this.Controls.Add(this.btStart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStart1;
        private System.Windows.Forms.NumericUpDown edMean;
        private System.Windows.Forms.NumericUpDown edVariance;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.Label lbVarience;
        private System.Windows.Forms.Label lbSquare;
    }
}

