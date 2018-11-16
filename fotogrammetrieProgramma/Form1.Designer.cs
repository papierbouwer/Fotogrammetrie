namespace fotogrammetrieProgramma
{
    partial class FotogrammetrieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotogrammetrieForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.camera1 = new System.Windows.Forms.TabPage();
            this.camera1Resolutie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.camera1Alpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.camera1YCoordinaat = new System.Windows.Forms.TextBox();
            this.camera1XCoordinaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.camera2 = new System.Windows.Forms.TabPage();
            this.camera2Resolutie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.camera2Alpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.camera2YCoordinaat = new System.Windows.Forms.TextBox();
            this.camera2XCoordinaat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reseten = new System.Windows.Forms.Button();
            this.berekenen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.coordinaatFoto2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.coordinaatFoto1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veranderOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.camera1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.camera2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 537);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.reseten);
            this.splitContainer2.Panel2.Controls.Add(this.berekenen);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(388, 537);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.camera1);
            this.tabControl1.Controls.Add(this.camera2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 156);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // camera1
            // 
            this.camera1.Controls.Add(this.camera1Resolutie);
            this.camera1.Controls.Add(this.label7);
            this.camera1.Controls.Add(this.camera1Alpha);
            this.camera1.Controls.Add(this.label3);
            this.camera1.Controls.Add(this.groupBox1);
            this.camera1.Location = new System.Drawing.Point(4, 22);
            this.camera1.Name = "camera1";
            this.camera1.Padding = new System.Windows.Forms.Padding(3);
            this.camera1.Size = new System.Drawing.Size(380, 130);
            this.camera1.TabIndex = 0;
            this.camera1.Text = "Camera 1";
            this.camera1.UseVisualStyleBackColor = true;
            // 
            // camera1Resolutie
            // 
            this.camera1Resolutie.Location = new System.Drawing.Point(111, 108);
            this.camera1Resolutie.Name = "camera1Resolutie";
            this.camera1Resolutie.Size = new System.Drawing.Size(257, 20);
            this.camera1Resolutie.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Resolutie foto:";
            // 
            // camera1Alpha
            // 
            this.camera1Alpha.Location = new System.Drawing.Point(111, 82);
            this.camera1Alpha.Name = "camera1Alpha";
            this.camera1Alpha.Size = new System.Drawing.Size(257, 20);
            this.camera1Alpha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hoek lens (alpha):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.camera1YCoordinaat);
            this.groupBox1.Controls.Add(this.camera1XCoordinaat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coördinaten";
            // 
            // camera1YCoordinaat
            // 
            this.camera1YCoordinaat.Location = new System.Drawing.Point(28, 39);
            this.camera1YCoordinaat.Name = "camera1YCoordinaat";
            this.camera1YCoordinaat.Size = new System.Drawing.Size(334, 20);
            this.camera1YCoordinaat.TabIndex = 1;
            // 
            // camera1XCoordinaat
            // 
            this.camera1XCoordinaat.Location = new System.Drawing.Point(28, 17);
            this.camera1XCoordinaat.Name = "camera1XCoordinaat";
            this.camera1XCoordinaat.Size = new System.Drawing.Size(334, 20);
            this.camera1XCoordinaat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // camera2
            // 
            this.camera2.Controls.Add(this.camera2Resolutie);
            this.camera2.Controls.Add(this.label8);
            this.camera2.Controls.Add(this.camera2Alpha);
            this.camera2.Controls.Add(this.label4);
            this.camera2.Controls.Add(this.groupBox2);
            this.camera2.Location = new System.Drawing.Point(4, 22);
            this.camera2.Name = "camera2";
            this.camera2.Padding = new System.Windows.Forms.Padding(3);
            this.camera2.Size = new System.Drawing.Size(380, 130);
            this.camera2.TabIndex = 1;
            this.camera2.Text = "Camera 2";
            this.camera2.UseVisualStyleBackColor = true;
            // 
            // camera2Resolutie
            // 
            this.camera2Resolutie.Location = new System.Drawing.Point(111, 108);
            this.camera2Resolutie.Name = "camera2Resolutie";
            this.camera2Resolutie.Size = new System.Drawing.Size(257, 20);
            this.camera2Resolutie.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Resolutie foto:";
            // 
            // camera2Alpha
            // 
            this.camera2Alpha.Location = new System.Drawing.Point(111, 82);
            this.camera2Alpha.Name = "camera2Alpha";
            this.camera2Alpha.Size = new System.Drawing.Size(257, 20);
            this.camera2Alpha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hoek lens (alpha):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.camera2YCoordinaat);
            this.groupBox2.Controls.Add(this.camera2XCoordinaat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coördinaten";
            // 
            // camera2YCoordinaat
            // 
            this.camera2YCoordinaat.Location = new System.Drawing.Point(28, 39);
            this.camera2YCoordinaat.Name = "camera2YCoordinaat";
            this.camera2YCoordinaat.Size = new System.Drawing.Size(334, 20);
            this.camera2YCoordinaat.TabIndex = 1;
            // 
            // camera2XCoordinaat
            // 
            this.camera2XCoordinaat.Location = new System.Drawing.Point(28, 17);
            this.camera2XCoordinaat.Name = "camera2XCoordinaat";
            this.camera2XCoordinaat.Size = new System.Drawing.Size(334, 20);
            this.camera2XCoordinaat.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(388, 268);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            // 
            // reseten
            // 
            this.reseten.Location = new System.Drawing.Point(197, 80);
            this.reseten.Name = "reseten";
            this.reseten.Size = new System.Drawing.Size(181, 23);
            this.reseten.TabIndex = 8;
            this.reseten.Text = "Reset";
            this.reseten.UseVisualStyleBackColor = true;
            this.reseten.Click += new System.EventHandler(this.reseten_Click);
            // 
            // berekenen
            // 
            this.berekenen.Location = new System.Drawing.Point(19, 80);
            this.berekenen.Name = "berekenen";
            this.berekenen.Size = new System.Drawing.Size(172, 23);
            this.berekenen.TabIndex = 7;
            this.berekenen.Text = "Bereken";
            this.berekenen.UseVisualStyleBackColor = true;
            this.berekenen.Click += new System.EventHandler(this.berekenen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.coordinaatFoto2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.coordinaatFoto1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 74);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gedetecteerd punt";
            // 
            // coordinaatFoto2
            // 
            this.coordinaatFoto2.Location = new System.Drawing.Point(115, 46);
            this.coordinaatFoto2.Name = "coordinaatFoto2";
            this.coordinaatFoto2.Size = new System.Drawing.Size(257, 20);
            this.coordinaatFoto2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Coördinaat foto 2";
            // 
            // coordinaatFoto1
            // 
            this.coordinaatFoto1.Location = new System.Drawing.Point(115, 20);
            this.coordinaatFoto1.Name = "coordinaatFoto1";
            this.coordinaatFoto1.Size = new System.Drawing.Size(257, 20);
            this.coordinaatFoto1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Coördinaat foto 1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.berekenenToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.opslaanAlsToolStripMenuItem,
            this.opslaanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.nieuwToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // opslaanAlsToolStripMenuItem
            // 
            this.opslaanAlsToolStripMenuItem.Name = "opslaanAlsToolStripMenuItem";
            this.opslaanAlsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opslaanAlsToolStripMenuItem.Text = "Opslaan Als";
            this.opslaanAlsToolStripMenuItem.Click += new System.EventHandler(this.opslaanAlsToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.opslaanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // berekenenToolStripMenuItem
            // 
            this.berekenenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veranderOverlapToolStripMenuItem});
            this.berekenenToolStripMenuItem.Name = "berekenenToolStripMenuItem";
            this.berekenenToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.berekenenToolStripMenuItem.Text = "Berekenen";
            // 
            // veranderOverlapToolStripMenuItem
            // 
            this.veranderOverlapToolStripMenuItem.Name = "veranderOverlapToolStripMenuItem";
            this.veranderOverlapToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.veranderOverlapToolStripMenuItem.Text = "Verander overlap";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // FotogrammetrieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FotogrammetrieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotogrammetrie programma";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.camera1.ResumeLayout(false);
            this.camera1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.camera2.ResumeLayout(false);
            this.camera2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage camera1;
        private System.Windows.Forms.TabPage camera2;
        private System.Windows.Forms.TextBox camera1Alpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox camera1YCoordinaat;
        private System.Windows.Forms.TextBox camera1XCoordinaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox camera2Alpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox camera2YCoordinaat;
        private System.Windows.Forms.TextBox camera2XCoordinaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox camera1Resolutie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox camera2Resolutie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox coordinaatFoto2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox coordinaatFoto1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reseten;
        private System.Windows.Forms.Button berekenen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berekenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veranderOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

