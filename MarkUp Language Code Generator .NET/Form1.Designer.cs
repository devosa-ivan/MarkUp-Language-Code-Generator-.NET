namespace MarkUp_Language_Code_Generator.NET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betöltésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.textBox_cim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_szerzok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kiado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_alcim = new System.Windows.Forms.TextBox();
            this.button_kodgeneralas = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kiadas_helye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kiadas_ideje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sorszam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_letoltesi_URL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_kiadvany_ara = new System.Windows.Forms.TextBox();
            this.button_masolas = new System.Windows.Forms.Button();
            this.kódgenerálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vágólapraMásolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProgramrólToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_megjegyzes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 361);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(380, 302);
            this.webBrowser1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.kódgenerálásToolStripMenuItem,
            this.vágólapraMásolásToolStripMenuItem,
            this.aProgramrólToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betöltésToolStripMenuItem,
            this.mentésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // betöltésToolStripMenuItem
            // 
            this.betöltésToolStripMenuItem.Name = "betöltésToolStripMenuItem";
            this.betöltésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.betöltésToolStripMenuItem.Text = "Betöltés";
            this.betöltésToolStripMenuItem.Click += new System.EventHandler(this.betöltésToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // button_betoltes
            // 
            this.button_betoltes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_betoltes.Image = ((System.Drawing.Image)(resources.GetObject("button_betoltes.Image")));
            this.button_betoltes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_betoltes.Location = new System.Drawing.Point(12, 29);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(80, 39);
            this.button_betoltes.TabIndex = 2;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = false;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // textBox_cim
            // 
            this.textBox_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_cim.Location = new System.Drawing.Point(411, 103);
            this.textBox_cim.Multiline = true;
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(217, 69);
            this.textBox_cim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(407, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CÍM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(407, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szerző(k)";
            // 
            // textBox_szerzok
            // 
            this.textBox_szerzok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_szerzok.Location = new System.Drawing.Point(411, 297);
            this.textBox_szerzok.Multiline = true;
            this.textBox_szerzok.Name = "textBox_szerzok";
            this.textBox_szerzok.Size = new System.Drawing.Size(217, 69);
            this.textBox_szerzok.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(407, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kiadó";
            // 
            // textBox_kiado
            // 
            this.textBox_kiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kiado.Location = new System.Drawing.Point(411, 391);
            this.textBox_kiado.Multiline = true;
            this.textBox_kiado.Name = "textBox_kiado";
            this.textBox_kiado.Size = new System.Drawing.Size(217, 69);
            this.textBox_kiado.TabIndex = 5;
            this.textBox_kiado.Text = "Neumann János Egyetem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(407, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alcím";
            // 
            // textBox_alcim
            // 
            this.textBox_alcim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_alcim.Location = new System.Drawing.Point(411, 199);
            this.textBox_alcim.Multiline = true;
            this.textBox_alcim.Name = "textBox_alcim";
            this.textBox_alcim.Size = new System.Drawing.Size(217, 69);
            this.textBox_alcim.TabIndex = 3;
            // 
            // button_kodgeneralas
            // 
            this.button_kodgeneralas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_kodgeneralas.Image = ((System.Drawing.Image)(resources.GetObject("button_kodgeneralas.Image")));
            this.button_kodgeneralas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kodgeneralas.Location = new System.Drawing.Point(98, 29);
            this.button_kodgeneralas.Name = "button_kodgeneralas";
            this.button_kodgeneralas.Size = new System.Drawing.Size(115, 39);
            this.button_kodgeneralas.TabIndex = 11;
            this.button_kodgeneralas.Text = "Kódgenerálás";
            this.button_kodgeneralas.UseVisualStyleBackColor = false;
            this.button_kodgeneralas.Click += new System.EventHandler(this.button_kodgeneralas_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_mentes.Image = ((System.Drawing.Image)(resources.GetObject("button_mentes.Image")));
            this.button_mentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mentes.Location = new System.Drawing.Point(312, 29);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(80, 39);
            this.button_mentes.TabIndex = 12;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = false;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(407, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kiadás helye";
            // 
            // textBox_kiadas_helye
            // 
            this.textBox_kiadas_helye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kiadas_helye.Location = new System.Drawing.Point(411, 487);
            this.textBox_kiadas_helye.Multiline = true;
            this.textBox_kiadas_helye.Name = "textBox_kiadas_helye";
            this.textBox_kiadas_helye.Size = new System.Drawing.Size(217, 65);
            this.textBox_kiadas_helye.TabIndex = 6;
            this.textBox_kiadas_helye.Text = "Kecskemét, Magyarország";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(407, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kiadás ideje";
            // 
            // textBox_kiadas_ideje
            // 
            this.textBox_kiadas_ideje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kiadas_ideje.Location = new System.Drawing.Point(411, 586);
            this.textBox_kiadas_ideje.Multiline = true;
            this.textBox_kiadas_ideje.Name = "textBox_kiadas_ideje";
            this.textBox_kiadas_ideje.Size = new System.Drawing.Size(94, 27);
            this.textBox_kiadas_ideje.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(407, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "ISBN";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ISBN.Location = new System.Drawing.Point(411, 636);
            this.textBox_ISBN.Multiline = true;
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(217, 27);
            this.textBox_ISBN.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(380, 250);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "HTML | *.htm| XML|*.xml\"|Minden fájl|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "HTML | *.htm| XML|*.xml\"|Minden fájl|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(407, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sorszám";
            // 
            // textBox_sorszam
            // 
            this.textBox_sorszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_sorszam.Location = new System.Drawing.Point(411, 49);
            this.textBox_sorszam.Multiline = true;
            this.textBox_sorszam.Name = "textBox_sorszam";
            this.textBox_sorszam.Size = new System.Drawing.Size(217, 27);
            this.textBox_sorszam.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(407, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Letöltési URL (http:// KELL!!)";
            // 
            // textBox_letoltesi_URL
            // 
            this.textBox_letoltesi_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_letoltesi_URL.Location = new System.Drawing.Point(411, 686);
            this.textBox_letoltesi_URL.Multiline = true;
            this.textBox_letoltesi_URL.Name = "textBox_letoltesi_URL";
            this.textBox_letoltesi_URL.Size = new System.Drawing.Size(217, 69);
            this.textBox_letoltesi_URL.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(516, 565);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kiadvány ára";
            // 
            // textBox_kiadvany_ara
            // 
            this.textBox_kiadvany_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kiadvany_ara.Location = new System.Drawing.Point(520, 588);
            this.textBox_kiadvany_ara.Multiline = true;
            this.textBox_kiadvany_ara.Name = "textBox_kiadvany_ara";
            this.textBox_kiadvany_ara.Size = new System.Drawing.Size(95, 42);
            this.textBox_kiadvany_ara.TabIndex = 8;
            // 
            // button_masolas
            // 
            this.button_masolas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_masolas.Image = ((System.Drawing.Image)(resources.GetObject("button_masolas.Image")));
            this.button_masolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_masolas.Location = new System.Drawing.Point(219, 29);
            this.button_masolas.Name = "button_masolas";
            this.button_masolas.Size = new System.Drawing.Size(87, 39);
            this.button_masolas.TabIndex = 26;
            this.button_masolas.Text = "Vágólap";
            this.button_masolas.UseVisualStyleBackColor = false;
            this.button_masolas.Click += new System.EventHandler(this.button_masolas_Click);
            // 
            // kódgenerálásToolStripMenuItem
            // 
            this.kódgenerálásToolStripMenuItem.Name = "kódgenerálásToolStripMenuItem";
            this.kódgenerálásToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.kódgenerálásToolStripMenuItem.Text = "Kódgenerálás";
            this.kódgenerálásToolStripMenuItem.Click += new System.EventHandler(this.kódgenerálásToolStripMenuItem_Click);
            // 
            // vágólapraMásolásToolStripMenuItem
            // 
            this.vágólapraMásolásToolStripMenuItem.Name = "vágólapraMásolásToolStripMenuItem";
            this.vágólapraMásolásToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.vágólapraMásolásToolStripMenuItem.Text = "Vágólapra másolás";
            this.vágólapraMásolásToolStripMenuItem.Click += new System.EventHandler(this.vágólapraMásolásToolStripMenuItem_Click);
            // 
            // aProgramrólToolStripMenuItem
            // 
            this.aProgramrólToolStripMenuItem.Name = "aProgramrólToolStripMenuItem";
            this.aProgramrólToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aProgramrólToolStripMenuItem.Text = "A programról...";
            this.aProgramrólToolStripMenuItem.Click += new System.EventHandler(this.aProgramrólToolStripMenuItem_Click);
            // 
            // textBox_megjegyzes
            // 
            this.textBox_megjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_megjegyzes.Location = new System.Drawing.Point(12, 686);
            this.textBox_megjegyzes.Multiline = true;
            this.textBox_megjegyzes.Name = "textBox_megjegyzes";
            this.textBox_megjegyzes.Size = new System.Drawing.Size(380, 69);
            this.textBox_megjegyzes.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 666);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Megjegyzés (HA van van további információ...)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_megjegyzes);
            this.Controls.Add(this.button_masolas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_kiadvany_ara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_letoltesi_URL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_sorszam);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_kiadas_ideje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_kiadas_helye);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_kodgeneralas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_alcim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_kiado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_szerzok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cim);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HTML kódgenerátor \'Liferay Portal\' portálhoz  .NET ©2018, Devosa Iván";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betöltésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.TextBox textBox_cim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_szerzok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kiado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_alcim;
        private System.Windows.Forms.Button button_kodgeneralas;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_kiadas_helye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_kiadas_ideje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_sorszam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_letoltesi_URL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_kiadvany_ara;
        private System.Windows.Forms.Button button_masolas;
        private System.Windows.Forms.ToolStripMenuItem kódgenerálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vágólapraMásolásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProgramrólToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_megjegyzes;
        private System.Windows.Forms.Label label11;
    }
}

