using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Adam_Bieszk_Projekt_PP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Int32 iloscSrednich01 = 0, iloscSrednich12 = 0, iloscSrednich23 = 0, iloscSrednich34 = 0, iloscSrednich45 = 0;
        public static Int32[] wyniki = new Int32[5]; 
        String[] przedzialy = new String[]{"0-1","1-2","2-3","3-4","4-5"};

        //ustawienie rezponsywności aplikacji
        private void Form1_Load(object sender, EventArgs e) {
            this.AutoSize = true;
            this.AutoScroll = true;
        }

        //odczyt pliku

        private void button1_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            this.Activate();
            var fileStream = openFileDialog1.OpenFile();
            String folder = openFileDialog1.InitialDirectory;
            String fName = openFileDialog1.FileName;
            String openPath = Path.Combine(folder, fName);
            StreamReader odczyt = new StreamReader(openPath);
            Int32 dlugoscPliku = (int)odczyt.BaseStream.Length, n = 0;
            Double[] srednie = new Double[dlugoscPliku];
            String linia = "";
            try {
                while (!odczyt.EndOfStream) {
                    linia = odczyt.ReadLine();
                    srednie[n] = Double.Parse(linia);
                    if (srednie[n] > 0 && srednie[n] < 1) {
                        iloscSrednich01++;
                    }
                    else if (srednie[n] >= 1 && srednie[n] < 2) {
                        iloscSrednich12++;
                    }
                    else if (srednie[n] >= 2 && srednie[n] < 3) {
                        iloscSrednich23++;
                    }
                    else if (srednie[n] >= 3 && srednie[n] < 4) {
                        iloscSrednich34++;
                    }
                    else if (srednie[n] >= 4 && srednie[n] < 5) {
                        iloscSrednich45++;
                    }
                    n++;
                }
                odczyt.Close();
                //opracowanie wyników
                wyniki[0] = iloscSrednich01;
                wyniki[1] = iloscSrednich12;
                wyniki[2] = iloscSrednich23;
                wyniki[3] = iloscSrednich34;
                wyniki[4] = iloscSrednich45;
                MessageBox.Show("Udało się otworzyć plik", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Visible = true;
                for (int i = 0; i < 5; i++) {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Insert(i, przedzialy[i], wyniki[i]);
                }
            }
            catch {
                MessageBox.Show("Nie udało się załadować pliku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            groupBox3.Visible = true;
            dataGridView1.Visible = true;
            groupBox2.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
        }

        //segregacja danych - tabela
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                dataGridView1.Rows[0].Visible = true;
            }
            else {
                dataGridView1.Rows[0].Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                dataGridView1.Rows[1].Visible = true;
            }
            else {
                dataGridView1.Rows[1].Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                dataGridView1.Rows[2].Visible = true;
            }
            else {
                dataGridView1.Rows[2].Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            if (checkBox4.Checked) {
                dataGridView1.Rows[3].Visible = true;
            }
            else {
                dataGridView1.Rows[3].Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            if (checkBox5.Checked) {
                dataGridView1.Rows[4].Visible = true;
            }
            else {
                dataGridView1.Rows[4].Visible = false;
            }
        }

        //zapisywanie pliku

        private void button2_Click(object sender, EventArgs e) {
            saveFileDialog1.ShowDialog();
            String zapisDirectory = saveFileDialog1.InitialDirectory;
            String zapisFileName = saveFileDialog1.FileName;
            String zapisPath = Path.Combine(zapisDirectory, zapisFileName);
            try {
                StreamWriter zapis = new StreamWriter(zapisPath);
                zapis.WriteLine("Ilość średnich z przedziału 0-1: " + iloscSrednich01);
                zapis.WriteLine("Ilość średnich z przedziału 1-2: " + iloscSrednich12);
                zapis.WriteLine("Ilość średnich z przedziału 2-3: " + iloscSrednich23);
                zapis.WriteLine("Ilość średnich z przedziału 3-4: " + iloscSrednich34);
                zapis.WriteLine("Ilość średnich z przedziału 4-5: " + iloscSrednich45);
                zapis.Close();
                if (File.Exists(zapisPath)) {
                    MessageBox.Show("Udało się zapisać plik", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //narysujWykres();
                    Form2 form = new Form2();
                    form.Show();
                }
            }
            catch (System.IO.IOException exp) {
                MessageBox.Show(exp.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentException arg_exp) {
                MessageBox.Show(arg_exp.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int[] przekazDane() {
            return wyniki;
        }
    }
}
