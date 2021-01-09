using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//(c) Devosa Iván
//készült 2018.05.07 és 2018.05.12.

namespace MarkUp_Language_Code_Generator.NET
{
    public partial class Form1 : Form
    {
        private string fajlnev;

        public Form1()
        {
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 form_main = new Form1();
            //form_main.Text += ProductName + ProductVersion;
            
        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            //Form1 form_main = new Form1();
            //Form1.ActiveForm.Text = ProductName +" "+ ProductVersion+" "+ //AssemblyCopyright;
            openFileDialog1.ShowDialog();           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            webBrowser1.Navigate(openFileDialog1.FileName);
            fajlnev = openFileDialog1.FileName;
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fajlnev;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void button_kodgeneralas_Click(object sender, EventArgs e)
        {
            string szoveg = //"<html><body>"+
                "<hr> <br> " +
                "<img border=\"0\" src=\"http://kik.kefo.hu/c/document_library/get_file?p_l_id=10132&folderId=306859&name=DLFE-4744.png\" width=\"130\" height=\"96\" align=\"right\">" +
                "<p font size=\"10\" face=\"Arial\"" +Environment.NewLine+
                "<br>Sorszám:    " + textBox_sorszam.Text + Environment.NewLine +
                "<br>Cím:<b>    " + textBox_cim.Text +"</b>"+ Environment.NewLine +
                "<br>Alcím:  " +textBox_alcim.Text+ Environment.NewLine +
                "<br>Szerzők:    " +textBox_szerzok.Text+ Environment.NewLine +
                "<br>Kiadó: "    +textBox_kiado.Text+ Environment.NewLine +
                "<br>Kiadás helye: " + textBox_kiadas_helye.Text+ Environment.NewLine +
                "<br>Kiadás ideje: " + textBox_kiadas_ideje.Text + Environment.NewLine +
                "<br>ISBN:    " + textBox_ISBN.Text+ Environment.NewLine +
                "<br>Kiadvány ára:    "  +   textBox_kiadvany_ara.Text+ Environment.NewLine +
                "<br>Megjegzés, további információ:    " + textBox_megjegyzes.Text + Environment.NewLine +
                "<br>Letöltési URL:  <a href=\""  + textBox_letoltesi_URL.Text + "\">IDE KATTINTVA </a> </p>" + Environment.NewLine +
                ""//"</body></html>"
                ;

            //http://kik.kefo.hu/c/document_library/get_file?p_l_id=10132&folderId=306859&name=DLFE-4744.png
            // <A HREF="http://www.secapl.com/cgi-bin/qs">Stock Market Quotes</A><BR>

            richTextBox1.Clear();
            richTextBox1.AppendText(szoveg);
            /*
            richTextBox1.SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)+"\\tmp.htm",RichTextBoxStreamType.PlainText);
            webBrowser1.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)+"\\tmp.htm");
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\tmp.htm");
            */
            richTextBox1.SaveFile(Path.Combine(Path.GetTempPath(), "tmp.htm"), RichTextBoxStreamType.PlainText);
            webBrowser1.Navigate(Path.Combine(Path.GetTempPath(), "tmp.htm"));
            //MessageBox.Show(Path.GetTempPath()+ "\tmp.htm");
            //MessageBox.Show(Path.Combine(Path.GetTempPath(), "tmp.htm"));
            
        }

        private void button_masolas_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void betöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_betoltes.PerformClick();
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_mentes.PerformClick();
        }

        private void kódgenerálásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_kodgeneralas.PerformClick();
        }

        private void vágólapraMásolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_masolas.PerformClick();
        }

        private void aProgramrólToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 form_about = new AboutBox1();
            form_about.Show();
        }

        
    }
}
