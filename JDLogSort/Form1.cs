using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDLogSort
{
    public partial class Form1 : Form
    {
        bool concheck = false;

        string[] con1 = new string[] { "3GM AT ACK:", "", "OK", "", ";" };


        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            //string savedir = null;
            //if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            //{
            //    savedir = folderBrowserDialog2.SelectedPath;
            //}
            //else {
            //    //return;
            //}
            int found = 0;
            int notfound = 0;
            foreach (string logfilepath in previewlistbox.Items) {

                string log = File.ReadAllText(logfilepath);
                string lockid = Path.GetFileName(logfilepath);
                string[] loginlines = File.ReadAllLines(logfilepath);
                bool gsm = false;
                bool niu = false;
                bool psd = false;
                string[] splitsourcepath = logfilepath.Split('\\');
                for (int i = 0; i < loginlines.Length; i++) {

                    //  Loop Check
                    if (gsm && niu && psd) {
                        continue;
                    }

                    //  3GM AT ACK: OK;
                    try
                    {
                        if (loginlines[i] == con1[0])
                        {
                            if (loginlines[i + 1] == con1[1])
                            {
                                if (loginlines[i + 2] == con1[2])
                                {
                                    gsm = true;
                                    if (loginlines[i + 3] == con1[3])
                                    {
                                        if (loginlines[i + 4] == con1[4])
                                        {
                                            gsm = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch {
                        outputlistbox2.Items.Add(lockid);
                    }

                    //  NOW IS UNLOCK
                    if (niu == false) {
                        if (loginlines[i].Contains("Now is UNLOCK")) ;
                        {
                            niu = true;
                        }
                    }

                    if (psd == false) {
                        if (loginlines[i].Contains("pSendData = ")) ;
                        {
                            psd = true;
                        }
                    }

                }
                //  display on output boxes
                if (gsm && niu && psd)
                {
                    found += 1;
                    foundcountlabel.Text = found.ToString();
                    outputlistbox.Items.Add(lockid);
                    if (savepathtb.Text != "") {
                        string path = Path.Combine(savepathtb.Text, "\\" + splitsourcepath[splitsourcepath.Length - 3] + "\\SUCESSFUL");
                        FileInfo fileInfo = new FileInfo(savepathtb.Text);
                        fileInfo.IsReadOnly = false;
                        DirectoryInfo di = Directory.CreateDirectory(path);
                        File.Copy(logfilepath, path+"\\"+splitsourcepath[splitsourcepath.Length-1],true);
                        Console.WriteLine("Passed");
                    }
                }
                else {
                    notfound += 1;
                    notfoundcountlabel.Text = notfound.ToString();
                    outputlistbox2.Items.Add(lockid);
                    if (savepathtb.Text != "")
                    {
                        string path = Path.Combine(savepathtb.Text, "\\" + splitsourcepath[splitsourcepath.Length - 3] + "\\UNSUCESSFUL");
                        FileInfo fileInfo = new FileInfo(savepathtb.Text);
                        fileInfo.IsReadOnly = false;
                        DirectoryInfo di = Directory.CreateDirectory(path);
                        File.Copy(logfilepath, path + "\\" + splitsourcepath[splitsourcepath.Length-1],true);
                        Console.WriteLine("Failed");
                    }
                }
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                directorytb.Text = folderBrowserDialog1.SelectedPath;
                previewlistbox.Items.Clear();
                subdirlistbox.Items.Clear();

                string[] allentries = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*", SearchOption.AllDirectories);
                string[] subdirectoryEntries = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                int subdircount = 0;
                int txtfilecount = 0;

                foreach (string entries in allentries)
                {
                    if (entries.Contains(".txt"))
                    {
                        previewlistbox.Items.Add(entries);
                        txtfilecount += 1;
                        txtfilecountlabel.Text = txtfilecount.ToString();
                    }
                    else {
                        subdirlistbox.Items.Add(entries);
                        subdircount += 1;
                        subdircountlabel.Text = subdircount.ToString();
                    }
                }
                //foreach (string file in files)
                //{
                //    previewlistbox.Items.Add(file);
                //    txtfilecount += 1;
                //    txtfilecountlabel.Text = txtfilecount.ToString();
                //    if (file.Contains(".txt"))
                //    {
                //        previewlistbox.Items.Add(file);
                //        txtfilecount += 1;
                //        txtfilecountlabel.Text = txtfilecount.ToString();
                //    }
                //}
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            directorytb.Text = "";
            subdirlistbox.Items.Clear();
            previewlistbox.Items.Clear();
            txtfilecountlabel.Text = "0";
        }

        private void savepathbrowsebtn_Click(object sender, EventArgs e)
        {
            savepathtb.Text = "";
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                savepathtb.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void outputclearbtn_Click(object sender, EventArgs e)
        {
            outputlistbox.Items.Clear();
            outputlistbox2.Items.Clear();
        }

        private void savepathclearbtn_Click(object sender, EventArgs e)
        {
            savepathtb.Text = "";
        }
    }
}
