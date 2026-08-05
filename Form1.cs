using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace guiCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
                    }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog(this);
            foreach (string file in openFileDialog1.FileNames)
            {
                listBox1.Items.Add(file);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = "";
            String ss = "";
            folderBrowserDialog1.SelectedPath = ".";
            folderBrowserDialog1.ShowNewFolderButton=true;
            folderBrowserDialog1.ShowDialog();
            s = folderBrowserDialog1.SelectedPath;
            if (s != "")
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    int ii = 0;
                    String f = file;
                    ii=file.LastIndexOf("\\")+1;
                    if(ii>0)f=file.Substring(ii,file.Length-ii);

                    statusStrip1.Text = s +"\\" +f;
                    File.Copy(file, s+"\\"+f);

                }
            }
        }
    }
}
