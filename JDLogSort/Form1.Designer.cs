
namespace JDLogSort
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
            this.browsebtn = new System.Windows.Forms.Button();
            this.directorytb = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.TargetFolderGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previewlistbox = new System.Windows.Forms.ListBox();
            this.sortbtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.outputlistbox = new System.Windows.Forms.ListBox();
            this.outputlistbox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foundcountlabel = new System.Windows.Forms.Label();
            this.notfoundcountlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savepathtb = new System.Windows.Forms.TextBox();
            this.savepathclearbtn = new System.Windows.Forms.Button();
            this.savepathbrowsebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfilecountlabel = new System.Windows.Forms.Label();
            this.outputclearbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.subdirlistbox = new System.Windows.Forms.ListBox();
            this.subdircountlabel = new System.Windows.Forms.Label();
            this.TargetFolderGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(583, 27);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(100, 27);
            this.browsebtn.TabIndex = 0;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // directorytb
            // 
            this.directorytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorytb.Location = new System.Drawing.Point(21, 32);
            this.directorytb.Name = "directorytb";
            this.directorytb.ReadOnly = true;
            this.directorytb.Size = new System.Drawing.Size(556, 20);
            this.directorytb.TabIndex = 1;
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(689, 27);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(57, 27);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // TargetFolderGroupBox
            // 
            this.TargetFolderGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TargetFolderGroupBox.Controls.Add(this.subdircountlabel);
            this.TargetFolderGroupBox.Controls.Add(this.label5);
            this.TargetFolderGroupBox.Controls.Add(this.subdirlistbox);
            this.TargetFolderGroupBox.Controls.Add(this.txtfilecountlabel);
            this.TargetFolderGroupBox.Controls.Add(this.label1);
            this.TargetFolderGroupBox.Controls.Add(this.previewlistbox);
            this.TargetFolderGroupBox.Controls.Add(this.directorytb);
            this.TargetFolderGroupBox.Controls.Add(this.clearbtn);
            this.TargetFolderGroupBox.Controls.Add(this.browsebtn);
            this.TargetFolderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TargetFolderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetFolderGroupBox.Location = new System.Drawing.Point(5, 24);
            this.TargetFolderGroupBox.Margin = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.TargetFolderGroupBox.Name = "TargetFolderGroupBox";
            this.TargetFolderGroupBox.Size = new System.Drawing.Size(776, 572);
            this.TargetFolderGroupBox.TabIndex = 3;
            this.TargetFolderGroupBox.TabStop = false;
            this.TargetFolderGroupBox.Text = "Target Folder";
            this.TargetFolderGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target Folder Detected Text Files (.txt)";
            // 
            // previewlistbox
            // 
            this.previewlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewlistbox.FormattingEnabled = true;
            this.previewlistbox.HorizontalScrollbar = true;
            this.previewlistbox.ItemHeight = 20;
            this.previewlistbox.Location = new System.Drawing.Point(20, 331);
            this.previewlistbox.Name = "previewlistbox";
            this.previewlistbox.ScrollAlwaysVisible = true;
            this.previewlistbox.Size = new System.Drawing.Size(725, 224);
            this.previewlistbox.TabIndex = 7;
            // 
            // sortbtn
            // 
            this.sortbtn.BackColor = System.Drawing.Color.Green;
            this.sortbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortbtn.ForeColor = System.Drawing.Color.Transparent;
            this.sortbtn.Location = new System.Drawing.Point(356, 720);
            this.sortbtn.Margin = new System.Windows.Forms.Padding(15, 15, 15, 25);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(279, 80);
            this.sortbtn.TabIndex = 5;
            this.sortbtn.Text = "SORT";
            this.sortbtn.UseVisualStyleBackColor = false;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // outputlistbox
            // 
            this.outputlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistbox.FormattingEnabled = true;
            this.outputlistbox.ItemHeight = 24;
            this.outputlistbox.Location = new System.Drawing.Point(799, 52);
            this.outputlistbox.Name = "outputlistbox";
            this.outputlistbox.ScrollAlwaysVisible = true;
            this.outputlistbox.Size = new System.Drawing.Size(383, 748);
            this.outputlistbox.TabIndex = 8;
            // 
            // outputlistbox2
            // 
            this.outputlistbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistbox2.FormattingEnabled = true;
            this.outputlistbox2.ItemHeight = 24;
            this.outputlistbox2.Location = new System.Drawing.Point(1202, 52);
            this.outputlistbox2.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.outputlistbox2.Name = "outputlistbox2";
            this.outputlistbox2.ScrollAlwaysVisible = true;
            this.outputlistbox2.Size = new System.Drawing.Size(369, 748);
            this.outputlistbox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(799, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Conditions Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(1198, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Conditions Not Found";
            // 
            // foundcountlabel
            // 
            this.foundcountlabel.AutoSize = true;
            this.foundcountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundcountlabel.ForeColor = System.Drawing.Color.Green;
            this.foundcountlabel.Location = new System.Drawing.Point(996, 21);
            this.foundcountlabel.Name = "foundcountlabel";
            this.foundcountlabel.Size = new System.Drawing.Size(20, 24);
            this.foundcountlabel.TabIndex = 13;
            this.foundcountlabel.Text = "0";
            // 
            // notfoundcountlabel
            // 
            this.notfoundcountlabel.AutoSize = true;
            this.notfoundcountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notfoundcountlabel.ForeColor = System.Drawing.Color.Brown;
            this.notfoundcountlabel.Location = new System.Drawing.Point(1414, 21);
            this.notfoundcountlabel.Name = "notfoundcountlabel";
            this.notfoundcountlabel.Size = new System.Drawing.Size(20, 24);
            this.notfoundcountlabel.TabIndex = 14;
            this.notfoundcountlabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.savepathtb);
            this.groupBox1.Controls.Add(this.savepathclearbtn);
            this.groupBox1.Controls.Add(this.savepathbrowsebtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 73);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Directory";
            // 
            // savepathtb
            // 
            this.savepathtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savepathtb.Location = new System.Drawing.Point(20, 32);
            this.savepathtb.Name = "savepathtb";
            this.savepathtb.ReadOnly = true;
            this.savepathtb.Size = new System.Drawing.Size(556, 20);
            this.savepathtb.TabIndex = 10;
            // 
            // savepathclearbtn
            // 
            this.savepathclearbtn.Location = new System.Drawing.Point(688, 27);
            this.savepathclearbtn.Name = "savepathclearbtn";
            this.savepathclearbtn.Size = new System.Drawing.Size(57, 27);
            this.savepathclearbtn.TabIndex = 11;
            this.savepathclearbtn.Text = "Clear";
            this.savepathclearbtn.UseVisualStyleBackColor = true;
            // 
            // savepathbrowsebtn
            // 
            this.savepathbrowsebtn.Location = new System.Drawing.Point(582, 27);
            this.savepathbrowsebtn.Name = "savepathbrowsebtn";
            this.savepathbrowsebtn.Size = new System.Drawing.Size(100, 27);
            this.savepathbrowsebtn.TabIndex = 9;
            this.savepathbrowsebtn.Text = "Browse";
            this.savepathbrowsebtn.UseVisualStyleBackColor = true;
            this.savepathbrowsebtn.Click += new System.EventHandler(this.savepathbrowsebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 80);
            this.label4.TabIndex = 16;
            this.label4.Text = "Locks are sorted conditionally by\r\n- 3GM AT ACK: OK;\r\n- Now Is UNLOCK\r\n- pSendDat" +
    "a= ";
            // 
            // txtfilecountlabel
            // 
            this.txtfilecountlabel.AutoSize = true;
            this.txtfilecountlabel.Location = new System.Drawing.Point(731, 310);
            this.txtfilecountlabel.Name = "txtfilecountlabel";
            this.txtfilecountlabel.Size = new System.Drawing.Size(14, 15);
            this.txtfilecountlabel.TabIndex = 9;
            this.txtfilecountlabel.Text = "0";
            this.txtfilecountlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // outputclearbtn
            // 
            this.outputclearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputclearbtn.Location = new System.Drawing.Point(653, 720);
            this.outputclearbtn.Name = "outputclearbtn";
            this.outputclearbtn.Size = new System.Drawing.Size(128, 80);
            this.outputclearbtn.TabIndex = 10;
            this.outputclearbtn.Text = "Clear Output";
            this.outputclearbtn.UseVisualStyleBackColor = true;
            this.outputclearbtn.Click += new System.EventHandler(this.outputclearbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sub Directories of Target Folder";
            // 
            // subdirlistbox
            // 
            this.subdirlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdirlistbox.FormattingEnabled = true;
            this.subdirlistbox.HorizontalScrollbar = true;
            this.subdirlistbox.ItemHeight = 20;
            this.subdirlistbox.Location = new System.Drawing.Point(21, 103);
            this.subdirlistbox.Name = "subdirlistbox";
            this.subdirlistbox.ScrollAlwaysVisible = true;
            this.subdirlistbox.Size = new System.Drawing.Size(725, 184);
            this.subdirlistbox.TabIndex = 10;
            // 
            // subdircountlabel
            // 
            this.subdircountlabel.AutoSize = true;
            this.subdircountlabel.Location = new System.Drawing.Point(731, 83);
            this.subdircountlabel.Name = "subdircountlabel";
            this.subdircountlabel.Size = new System.Drawing.Size(14, 15);
            this.subdircountlabel.TabIndex = 12;
            this.subdircountlabel.Text = "0";
            this.subdircountlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1588, 828);
            this.Controls.Add(this.outputclearbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.notfoundcountlabel);
            this.Controls.Add(this.foundcountlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputlistbox2);
            this.Controls.Add(this.outputlistbox);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.TargetFolderGroupBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "JD Log File Sorter";
            this.TargetFolderGroupBox.ResumeLayout(false);
            this.TargetFolderGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.TextBox directorytb;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.GroupBox TargetFolderGroupBox;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox previewlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox outputlistbox;
        private System.Windows.Forms.ListBox outputlistbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label foundcountlabel;
        private System.Windows.Forms.Label notfoundcountlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox savepathtb;
        private System.Windows.Forms.Button savepathclearbtn;
        private System.Windows.Forms.Button savepathbrowsebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtfilecountlabel;
        private System.Windows.Forms.Button outputclearbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox subdirlistbox;
        private System.Windows.Forms.Label subdircountlabel;
    }
}

