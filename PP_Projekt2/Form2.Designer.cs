
namespace Adam_Bieszk_Projekt_PP {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.opcjeWykresu = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Series5 = new System.Windows.Forms.CheckBox();
            this.Series4 = new System.Windows.Forms.CheckBox();
            this.Series3 = new System.Windows.Forms.CheckBox();
            this.Series2 = new System.Windows.Forms.CheckBox();
            this.Series1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.ColorDialog();
            this.barsColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.opcjeWykresu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(623, 629);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "Średnie";
            // 
            // opcjeWykresu
            // 
            this.opcjeWykresu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.opcjeWykresu.Controls.Add(this.button6);
            this.opcjeWykresu.Controls.Add(this.button2);
            this.opcjeWykresu.Controls.Add(this.button1);
            this.opcjeWykresu.Controls.Add(this.groupBox4);
            this.opcjeWykresu.Controls.Add(this.label1);
            this.opcjeWykresu.Controls.Add(this.label6);
            this.opcjeWykresu.Controls.Add(this.button7);
            this.opcjeWykresu.Controls.Add(this.label5);
            this.opcjeWykresu.Controls.Add(this.label3);
            this.opcjeWykresu.Controls.Add(this.button5);
            this.opcjeWykresu.Controls.Add(this.label4);
            this.opcjeWykresu.Controls.Add(this.button4);
            this.opcjeWykresu.Controls.Add(this.button3);
            this.opcjeWykresu.Location = new System.Drawing.Point(662, 12);
            this.opcjeWykresu.Name = "opcjeWykresu";
            this.opcjeWykresu.Size = new System.Drawing.Size(209, 634);
            this.opcjeWykresu.TabIndex = 12;
            this.opcjeWykresu.TabStop = false;
            this.opcjeWykresu.Text = "Opcje wykresu";
            this.opcjeWykresu.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(44, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 46);
            this.button6.TabIndex = 22;
            this.button6.Text = "Schowaj legendę";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "Pokaż legendę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Wybierz kolor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Series5);
            this.groupBox4.Controls.Add(this.Series4);
            this.groupBox4.Controls.Add(this.Series3);
            this.groupBox4.Controls.Add(this.Series2);
            this.groupBox4.Controls.Add(this.Series1);
            this.groupBox4.Location = new System.Drawing.Point(0, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 234);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pokazywanie danych";
            // 
            // Series5
            // 
            this.Series5.AutoSize = true;
            this.Series5.Checked = true;
            this.Series5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series5.Location = new System.Drawing.Point(19, 140);
            this.Series5.Name = "Series5";
            this.Series5.Size = new System.Drawing.Size(138, 21);
            this.Series5.TabIndex = 4;
            this.Series5.Text = "Ukryj średnie 4-5";
            this.Series5.UseVisualStyleBackColor = true;
            this.Series5.CheckedChanged += new System.EventHandler(this.seria5_CheckedChanged);
            // 
            // Series4
            // 
            this.Series4.AutoSize = true;
            this.Series4.Checked = true;
            this.Series4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series4.Location = new System.Drawing.Point(19, 113);
            this.Series4.Name = "Series4";
            this.Series4.Size = new System.Drawing.Size(142, 21);
            this.Series4.TabIndex = 3;
            this.Series4.Text = "Ukryj średnie  3-4";
            this.Series4.UseVisualStyleBackColor = true;
            this.Series4.CheckedChanged += new System.EventHandler(this.seria4_CheckedChanged);
            // 
            // Series3
            // 
            this.Series3.AutoSize = true;
            this.Series3.Checked = true;
            this.Series3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series3.Location = new System.Drawing.Point(19, 86);
            this.Series3.Name = "Series3";
            this.Series3.Size = new System.Drawing.Size(142, 21);
            this.Series3.TabIndex = 2;
            this.Series3.Text = "Ukryj średnie  2-3";
            this.Series3.UseVisualStyleBackColor = true;
            this.Series3.CheckedChanged += new System.EventHandler(this.seria3_CheckedChanged);
            // 
            // Series2
            // 
            this.Series2.AutoSize = true;
            this.Series2.Checked = true;
            this.Series2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series2.Location = new System.Drawing.Point(19, 59);
            this.Series2.Name = "Series2";
            this.Series2.Size = new System.Drawing.Size(142, 21);
            this.Series2.TabIndex = 1;
            this.Series2.Text = "Ukryj średnie  1-2";
            this.Series2.UseVisualStyleBackColor = true;
            this.Series2.CheckedChanged += new System.EventHandler(this.seria2_CheckedChanged);
            // 
            // Series1
            // 
            this.Series1.AutoSize = true;
            this.Series1.Checked = true;
            this.Series1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Series1.Location = new System.Drawing.Point(19, 32);
            this.Series1.Name = "Series1";
            this.Series1.Size = new System.Drawing.Size(142, 21);
            this.Series1.TabIndex = 0;
            this.Series1.Text = "Ukryj średnie  0-1";
            this.Series1.UseVisualStyleBackColor = true;
            this.Series1.CheckedChanged += new System.EventHandler(this.seria1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Eksportuj obrazek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Widoczność legendy:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 53);
            this.button7.TabIndex = 16;
            this.button7.Text = "Zapisz wykres jako obrazek";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zmień kolor słupków:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zmień kolor tła:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 30);
            this.button5.TabIndex = 13;
            this.button5.Text = "Wybierz kolor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zwiększ / zmniejsz czcionkę";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "A-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "A+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 658);
            this.Controls.Add(this.opcjeWykresu);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Wykres i jego funkcje";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.opcjeWykresu.ResumeLayout(false);
            this.opcjeWykresu.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox opcjeWykresu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Series5;
        private System.Windows.Forms.CheckBox Series4;
        private System.Windows.Forms.CheckBox Series3;
        private System.Windows.Forms.CheckBox Series2;
        private System.Windows.Forms.CheckBox Series1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog backgroundColor;
        private System.Windows.Forms.ColorDialog barsColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}