
namespace Function_Plotter
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputEquation = new System.Windows.Forms.TextBox();
            this.MinBound = new System.Windows.Forms.TextBox();
            this.MaxBound = new System.Windows.Forms.TextBox();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 113);
            this.button1.TabIndex = 0;
            this.button1.Text = "Plot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "F(x) =";
            // 
            // InputEquation
            // 
            this.InputEquation.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEquation.Location = new System.Drawing.Point(399, 37);
            this.InputEquation.Name = "InputEquation";
            this.InputEquation.Size = new System.Drawing.Size(534, 34);
            this.InputEquation.TabIndex = 4;
            // 
            // MinBound
            // 
            this.MinBound.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBound.Location = new System.Drawing.Point(399, 83);
            this.MinBound.Name = "MinBound";
            this.MinBound.Size = new System.Drawing.Size(534, 32);
            this.MinBound.TabIndex = 5;
            // 
            // MaxBound
            // 
            this.MaxBound.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBound.Location = new System.Drawing.Point(399, 128);
            this.MaxBound.Name = "MaxBound";
            this.MaxBound.Size = new System.Drawing.Size(534, 33);
            this.MaxBound.TabIndex = 6;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart.BackColor = System.Drawing.SystemColors.GrayText;
            this.cartesianChart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartesianChart.Location = new System.Drawing.Point(4, -8);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Padding = new System.Windows.Forms.Padding(0, 5, 5, 9);
            this.cartesianChart.Size = new System.Drawing.Size(1213, 511);
            this.cartesianChart.TabIndex = 7;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Interval Begining :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Interval End :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.InputEquation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MinBound);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaxBound);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1235, 739);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cartesianChart);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Function Plotter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputEquation;
        private System.Windows.Forms.TextBox MinBound;
        private System.Windows.Forms.TextBox MaxBound;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

