namespace MathParser
{
    partial class parserForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.chartParsedExpr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLimits = new System.Windows.Forms.Label();
            this.txtMin_x = new System.Windows.Forms.TextBox();
            this.txtMax_x = new System.Windows.Forms.TextBox();
            this.txtMin_y = new System.Windows.Forms.TextBox();
            this.txtMax_y = new System.Windows.Forms.TextBox();
            this.txtTab = new System.Windows.Forms.TextBox();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartParsedExpr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(98, 46);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(537, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(34, 16);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(165, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Print math expression ";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartParsedExpr
            // 
            this.chartParsedExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartParsedExpr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartParsedExpr.Legends.Add(legend1);
            this.chartParsedExpr.Location = new System.Drawing.Point(37, 138);
            this.chartParsedExpr.Name = "chartParsedExpr";
            this.chartParsedExpr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartParsedExpr.Series.Add(series1);
            this.chartParsedExpr.Size = new System.Drawing.Size(736, 305);
            this.chartParsedExpr.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(661, 42);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblLimits
            // 
            this.lblLimits.AutoSize = true;
            this.lblLimits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLimits.Location = new System.Drawing.Point(34, 80);
            this.lblLimits.Name = "lblLimits";
            this.lblLimits.Size = new System.Drawing.Size(52, 20);
            this.lblLimits.TabIndex = 4;
            this.lblLimits.Text = "where";
            this.lblLimits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMin_x
            // 
            this.txtMin_x.Location = new System.Drawing.Point(98, 79);
            this.txtMin_x.Name = "txtMin_x";
            this.txtMin_x.Size = new System.Drawing.Size(66, 20);
            this.txtMin_x.TabIndex = 5;
            // 
            // txtMax_x
            // 
            this.txtMax_x.Location = new System.Drawing.Point(245, 80);
            this.txtMax_x.Name = "txtMax_x";
            this.txtMax_x.Size = new System.Drawing.Size(66, 20);
            this.txtMax_x.TabIndex = 6;
            // 
            // txtMin_y
            // 
            this.txtMin_y.Location = new System.Drawing.Point(98, 105);
            this.txtMin_y.Name = "txtMin_y";
            this.txtMin_y.Size = new System.Drawing.Size(66, 20);
            this.txtMin_y.TabIndex = 7;
            // 
            // txtMax_y
            // 
            this.txtMax_y.Location = new System.Drawing.Point(245, 106);
            this.txtMax_y.Name = "txtMax_y";
            this.txtMax_y.Size = new System.Drawing.Size(66, 20);
            this.txtMax_y.TabIndex = 8;
            // 
            // txtTab
            // 
            this.txtTab.Location = new System.Drawing.Point(415, 80);
            this.txtTab.Name = "txtTab";
            this.txtTab.Size = new System.Drawing.Size(66, 20);
            this.txtTab.TabIndex = 9;
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTab.Location = new System.Drawing.Point(330, 82);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(64, 20);
            this.lblTab.TabIndex = 10;
            this.lblTab.Text = "with tab";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(174, 80);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(60, 20);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "<= x <=";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.Location = new System.Drawing.Point(174, 106);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(60, 20);
            this.lblY.TabIndex = 12;
            this.lblY.Text = "<= y <=";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFx.Location = new System.Drawing.Point(33, 46);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(44, 20);
            this.lblFx.TabIndex = 13;
            this.lblFx.Text = "f(x) =";
            this.lblFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(-2, 460);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(801, 90);
            this.txtLog.TabIndex = 14;
            // 
            // parserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblFx);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.txtTab);
            this.Controls.Add(this.txtMax_y);
            this.Controls.Add(this.txtMin_y);
            this.Controls.Add(this.txtMax_x);
            this.Controls.Add(this.txtMin_x);
            this.Controls.Add(this.lblLimits);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chartParsedExpr);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Name = "parserForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartParsedExpr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParsedExpr;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLimits;
        private System.Windows.Forms.TextBox txtMin_x;
        private System.Windows.Forms.TextBox txtMax_x;
        private System.Windows.Forms.TextBox txtMin_y;
        private System.Windows.Forms.TextBox txtMax_y;
        private System.Windows.Forms.TextBox txtTab;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TextBox txtLog;
    }
}

