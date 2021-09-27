using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Adam_Bieszk_Projekt_PP {
    public partial class Form2 : Form {
        Int32 FontSizeX = 10, FontSizeY = 7, changeFontSizeX = 0, changeFontSizeY = 0;
        Color innyKolor = Color.Blue;
        public Form2() {
            InitializeComponent();
        }
        int[] data = new int[6];
        private void Form2_Load(object sender, EventArgs e) {
            this.AutoSize = true;
            this.AutoScroll = true;
            Form1 form = new Form1();
            data = form.przekazDane();
            this.drawChart();
            opcjeWykresu.Visible = true;
        }
        public void drawChart() {
            chart1.Titles.Add("Średnie studentów");
            chart1.Series.Add("Średnie");
            chart1.Series["Średnie"].Points.AddXY("0-1", data[0]);
            chart1.Series["Średnie"].Points.AddXY("1-2", data[1]);
            chart1.Series["Średnie"].Points.AddXY("2-3", data[2]);
            chart1.Series["Średnie"].Points.AddXY("3-4", data[3]);
            chart1.Series["Średnie"].Points.AddXY("4-5", data[4]);
            chart1.AllowDrop = true;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Przedziały";
            chart1.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Center;
            chart1.ChartAreas["ChartArea1"].AxisX.TextOrientation = TextOrientation.Auto;
            chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", FontSizeX, FontStyle.Bold);
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Ilość średnich";
            chart1.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Center;
            chart1.ChartAreas["ChartArea1"].AxisY.TextOrientation = TextOrientation.Horizontal;
            chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", FontSizeY, FontStyle.Bold);
        }

        private void seria1_CheckedChanged(object sender, EventArgs e) {
            if (Series1.Checked) {
                chart1.Series["Średnie"].Points[0].Color = innyKolor;
                chart1.Series["Średnie"].Points[0].AxisLabel = "0-1";
            }
            else {
                chart1.Series["Średnie"].Points[0].Color = Color.Transparent;
                chart1.Series["Średnie"].Points[0].AxisLabel = "";
            }
        }

        private void seria2_CheckedChanged(object sender, EventArgs e) {
            if (Series2.Checked) {
                chart1.Series["Średnie"].Points[1].Color = innyKolor;
                chart1.Series["Średnie"].Points[1].AxisLabel = "1-2";
            }
            else {
                chart1.Series["Średnie"].Points[1].Color = Color.Transparent;
                chart1.Series["Średnie"].Points[1].AxisLabel = "";
            }
        }

        private void seria3_CheckedChanged(object sender, EventArgs e) {
            if (Series3.Checked) {
                chart1.Series["Średnie"].Points[2].Color = innyKolor;
                chart1.Series["Średnie"].Points[2].AxisLabel = "2-3";
            }
            else {
                chart1.Series["Średnie"].Points[2].Color = Color.Transparent;
                chart1.Series["Średnie"].Points[2].AxisLabel = "";
            }
        }
        private void seria4_CheckedChanged(object sender, EventArgs e) {
            if (Series4.Checked) {
                chart1.Series["Średnie"].Points[3].Color = innyKolor;
                chart1.Series["Średnie"].Points[3].AxisLabel = "3-4";
            }
            else {
                chart1.Series["Średnie"].Points[3].Color = Color.Transparent;
                chart1.Series["Średnie"].Points[3].AxisLabel = "";
            }
        }

        private void seria5_CheckedChanged(object sender, EventArgs e) {
            if (Series5.Checked) {
                chart1.Series["Średnie"].Points[4].Color = innyKolor;
                chart1.Series["Średnie"].Points[4].AxisLabel = "4-5";
            }
            else {
                chart1.Series["Średnie"].Points[4].Color = Color.Transparent;
                chart1.Series["Średnie"].Points[4].AxisLabel = "";
            }
        }
        //increase font size
        private void button3_Click(object sender, EventArgs e) {
            changeFontSizeX += 2;
            changeFontSizeY += 2;
            FontSizeX += changeFontSizeX;
            FontSizeY += changeFontSizeY;
            if (FontSizeX > 0 && FontSizeY > 0) {
                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", FontSizeX, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", FontSizeY, FontStyle.Bold);
            }
            else {
                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 7, FontStyle.Bold);
            }
        }

        //decrease of font size

        private void button4_Click(object sender, EventArgs e) {
            changeFontSizeX -= 2;
            changeFontSizeY -= 2;
            FontSizeX += changeFontSizeX;
            FontSizeY += changeFontSizeY;
            if (FontSizeX > 0 && FontSizeY > 0) {
                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", FontSizeX, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", FontSizeY, FontStyle.Bold);
            }
            else {
                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
                chart1.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 7, FontStyle.Bold);
            }
        }

        //change background's color
        private void button5_Click(object sender, EventArgs e) {
            if(backgroundColor.ShowDialog() == DialogResult.OK) {
                backgroundColor.ShowHelp = true;
                chart1.ChartAreas[0].BackColor = backgroundColor.Color;
            }

        }

        //change bars colors

        private void button1_Click(object sender, EventArgs e) {
            if (barsColor.ShowDialog() == DialogResult.OK) {
                barsColor.ShowHelp = true;
                innyKolor = barsColor.Color;
                chart1.Series["Średnie"].Color = innyKolor;
            }
        }

        //pokazywanie legendy

        private void button2_Click(object sender, EventArgs e) {
            chart1.Series["Średnie"].IsVisibleInLegend = true;
            button2.Visible = false;
            button6.Visible = true;
        }

        // chowanie legendy
        private void button6_Click(object sender, EventArgs e) {
            chart1.Series["Średnie"].IsVisibleInLegend = false;
            button6.Visible = false;
            button2.Visible = true;
        }

        //zapis wykresu do obrazka
        private void button7_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Obraz PNG|*.png|Obraz JPEG|*.jpg";
            saveFileDialog.Title = "Zapisz wykres jako obrazek";
            saveFileDialog.FileName = "Wykres.png";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "") {
                try {
                    if (saveFileDialog.CheckPathExists) {
                        if (saveFileDialog.FilterIndex == 2) {
                            this.chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1) {
                            this.chart1.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }
                        MessageBox.Show("Udało się zapisać wykres!", "Zapisano!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Podana ścieżka nie istnieje!");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
