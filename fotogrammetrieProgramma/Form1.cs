using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using fotogrammetrie;

namespace fotogrammetrieProgramma
{
    public partial class FotogrammetrieForm : Form
    {
        Fotogrammetrie fotogrammetrie;
        string file;
        bool fileOpened;
         
        public FotogrammetrieForm()
        {
            InitializeComponent();
            fotogrammetrie = new Fotogrammetrie();
            Reset();
            Console.SetOut(new ControlWriter(textBox1));
            fileOpened = false;
            opslaanToolStripMenuItem.Enabled = false;
        }

        private void berekenen_Click(object sender, EventArgs e)
        {
            try
            {
                Camera camera1 = new Camera
            (
                Convert.ToDouble(camera1XCoordinaat.Text),
                Convert.ToDouble(camera1YCoordinaat.Text),
                (Convert.ToDouble(camera1Alpha.Text) * Math.PI) / 180,
                Convert.ToInt16(camera1Resolutie.Text)
            );
                Camera camera2 = new Camera
                (
                    Convert.ToDouble(camera2XCoordinaat.Text),
                    Convert.ToDouble(camera2YCoordinaat.Text),
                    (Convert.ToDouble(camera2Alpha.Text) * Math.PI) / 180,
                    Convert.ToInt16(camera2Resolutie.Text)
                );

                fotogrammetrie = new Fotogrammetrie(camera1, camera2, Convert.ToInt16(coordinaatFoto1.Text), Convert.ToInt16(coordinaatFoto2.Text));

                Coordinaat resultaat = fotogrammetrie.berekenWaarde();
                Console.WriteLine("De gevonden coördinaat is: (" + resultaat.x + "; " + resultaat.y + ")");
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            
        }

        private void reseten_Click(object sender, EventArgs e)
        {
            if (fileOpened)
                OpenFile();
            else
                Reset();
        }

        private void Reset()
        {
            camera1XCoordinaat.Text = "0";
            camera1YCoordinaat.Text = "0";
            camera1Alpha.Text = "0";
            camera1Resolutie.Text = "0";

            camera2XCoordinaat.Text = "0";
            camera2YCoordinaat.Text = "0";
            camera2Alpha.Text = "0";
            camera2Resolutie.Text = "0";

            coordinaatFoto1.Text = "0";
            coordinaatFoto2.Text = "0";

            fotogrammetrie.Reset();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Activate();
            aboutbox.Show();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            string location;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "lul files (*.lul)|*.lul";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((location = openFileDialog1.FileName) != null)
                    {
                        Filesystem filesystem = new Filesystem(location);
                        FotogrammetrieData data = filesystem.ReadFile();

                        camera1XCoordinaat.Text = data.camera1.coordinaat.x.ToString();
                        camera1YCoordinaat.Text = data.camera1.coordinaat.y.ToString();
                        camera1Alpha.Text = data.camera1.zichthoek.ToString();
                        camera1Resolutie.Text = data.camera1.resolutie.ToString();

                        camera2XCoordinaat.Text = data.camera2.coordinaat.x.ToString();
                        camera2YCoordinaat.Text = data.camera2.coordinaat.y.ToString();
                        camera2Alpha.Text = data.camera2.zichthoek.ToString();
                        camera2Resolutie.Text = data.camera2.resolutie.ToString();

                        coordinaatFoto1.Text = data.coordinaat1.ToString();
                        coordinaatFoto2.Text = data.coordinaat2.ToString();

                        fileOpened = true;
                        file = location;
                        opslaanToolStripMenuItem.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opslaan();

        }

        private void Opslaan()
        {
            try
            {
                FotogrammetrieData data = new FotogrammetrieData();

                data.camera1 = new Camera
                (
                    Convert.ToDouble(camera1XCoordinaat.Text),
                    Convert.ToDouble(camera1YCoordinaat.Text),
                    Convert.ToDouble(camera1Alpha.Text),
                    Convert.ToInt16(camera1Resolutie.Text)
                );
                data.camera2 = new Camera
                (
                    Convert.ToDouble(camera2XCoordinaat.Text),
                    Convert.ToDouble(camera2YCoordinaat.Text),
                    Convert.ToDouble(camera2Alpha.Text),
                    Convert.ToInt16(camera2Resolutie.Text)
                );
                data.coordinaat1 = Convert.ToInt16(coordinaatFoto1.Text);
                data.coordinaat2 = Convert.ToInt16(coordinaatFoto2.Text);

                Filesystem fileSystem = new Filesystem(file);
                fileSystem.WriteFile(data);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void nieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileOpened = false;
            Reset();
        }

        private void opslaanAlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!fileOpened)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "lul files (*.lul)|*.lul";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((file = saveFileDialog.FileName) != null)
                        {
                            fileOpened = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
            Opslaan();
        }
    }

    public class ControlWriter : TextWriter
    {
        private Control textbox;
        public ControlWriter(Control textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }
    }
}
