namespace WindowsFormsFrontEnd
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbDBConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cklstAvailableTables = new System.Windows.Forms.CheckedListBox();
            this.tbGenerateCodeFolder = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ckbxBuildDTOs = new System.Windows.Forms.CheckBox();
            this.ckbxBuildRepos = new System.Windows.Forms.CheckBox();
            this.fbCodeLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Tables and Views";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Tables and Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Generate Code Location";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(174, 51);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(272, 23);
            this.tbSearch.TabIndex = 4;
            // 
            // tbDBConnectionString
            // 
            this.tbDBConnectionString.Location = new System.Drawing.Point(174, 18);
            this.tbDBConnectionString.Name = "tbDBConnectionString";
            this.tbDBConnectionString.Size = new System.Drawing.Size(499, 23);
            this.tbDBConnectionString.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(679, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cklstAvailableTables
            // 
            this.cklstAvailableTables.FormattingEnabled = true;
            this.cklstAvailableTables.Location = new System.Drawing.Point(174, 80);
            this.cklstAvailableTables.Name = "cklstAvailableTables";
            this.cklstAvailableTables.Size = new System.Drawing.Size(499, 310);
            this.cklstAvailableTables.TabIndex = 7;
            // 
            // tbGenerateCodeFolder
            // 
            this.tbGenerateCodeFolder.Location = new System.Drawing.Point(174, 396);
            this.tbGenerateCodeFolder.Name = "tbGenerateCodeFolder";
            this.tbGenerateCodeFolder.Size = new System.Drawing.Size(396, 23);
            this.tbGenerateCodeFolder.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(679, 395);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // ckbxBuildDTOs
            // 
            this.ckbxBuildDTOs.AutoSize = true;
            this.ckbxBuildDTOs.Location = new System.Drawing.Point(684, 82);
            this.ckbxBuildDTOs.Name = "ckbxBuildDTOs";
            this.ckbxBuildDTOs.Size = new System.Drawing.Size(82, 19);
            this.ckbxBuildDTOs.TabIndex = 10;
            this.ckbxBuildDTOs.Text = "Build DTOs";
            this.ckbxBuildDTOs.UseVisualStyleBackColor = true;
            // 
            // ckbxBuildRepos
            // 
            this.ckbxBuildRepos.AutoSize = true;
            this.ckbxBuildRepos.Location = new System.Drawing.Point(684, 107);
            this.ckbxBuildRepos.Name = "ckbxBuildRepos";
            this.ckbxBuildRepos.Size = new System.Drawing.Size(88, 19);
            this.ckbxBuildRepos.TabIndex = 11;
            this.ckbxBuildRepos.Text = "Build Repos";
            this.ckbxBuildRepos.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(576, 396);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.ckbxBuildRepos);
            this.Controls.Add(this.ckbxBuildDTOs);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbGenerateCodeFolder);
            this.Controls.Add(this.cklstAvailableTables);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbDBConnectionString);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbSearch;
        private TextBox tbDBConnectionString;
        private Button btnConnect;
        private CheckedListBox cklstAvailableTables;
        private TextBox tbGenerateCodeFolder;
        private Button btnGenerate;
        private CheckBox ckbxBuildDTOs;
        private CheckBox ckbxBuildRepos;
        private FolderBrowserDialog fbCodeLocation;
        private Button btnBrowse;
    }
}