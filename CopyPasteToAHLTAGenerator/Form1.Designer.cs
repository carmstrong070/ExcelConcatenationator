namespace CopyPasteToAHLTAGenerator
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
            this.btn_OpenXML = new System.Windows.Forms.Button();
            this.btn_CsvHelper = new System.Windows.Forms.Button();
            this.btn_ToStringOverride = new System.Windows.Forms.Button();
            this.btn_StreamWrite = new System.Windows.Forms.Button();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.btn_RemovePath = new System.Windows.Forms.Button();
            this.lbl_EnterPath = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_AddPath = new System.Windows.Forms.Button();
            this.listBox_Paths = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_OpenXML
            // 
            this.btn_OpenXML.Location = new System.Drawing.Point(497, 344);
            this.btn_OpenXML.Name = "btn_OpenXML";
            this.btn_OpenXML.Size = new System.Drawing.Size(132, 23);
            this.btn_OpenXML.TabIndex = 21;
            this.btn_OpenXML.Text = "OpenXML Excel File";
            this.btn_OpenXML.UseVisualStyleBackColor = true;
            // 
            // btn_CsvHelper
            // 
            this.btn_CsvHelper.Location = new System.Drawing.Point(497, 315);
            this.btn_CsvHelper.Name = "btn_CsvHelper";
            this.btn_CsvHelper.Size = new System.Drawing.Size(132, 23);
            this.btn_CsvHelper.TabIndex = 20;
            this.btn_CsvHelper.Text = "Csv Helper";
            this.btn_CsvHelper.UseVisualStyleBackColor = true;
            this.btn_CsvHelper.Click += new System.EventHandler(this.btn_CsvHelper_Click);
            // 
            // btn_ToStringOverride
            // 
            this.btn_ToStringOverride.Location = new System.Drawing.Point(497, 284);
            this.btn_ToStringOverride.Name = "btn_ToStringOverride";
            this.btn_ToStringOverride.Size = new System.Drawing.Size(132, 23);
            this.btn_ToStringOverride.TabIndex = 19;
            this.btn_ToStringOverride.Text = "Overrride ToString";
            this.btn_ToStringOverride.UseVisualStyleBackColor = true;
            // 
            // btn_StreamWrite
            // 
            this.btn_StreamWrite.Location = new System.Drawing.Point(497, 255);
            this.btn_StreamWrite.Name = "btn_StreamWrite";
            this.btn_StreamWrite.Size = new System.Drawing.Size(132, 23);
            this.btn_StreamWrite.TabIndex = 18;
            this.btn_StreamWrite.Text = "Stream WriteLine";
            this.btn_StreamWrite.UseVisualStyleBackColor = true;
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(172, 284);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(88, 13);
            this.lbl_Destination.TabIndex = 17;
            this.lbl_Destination.Text = "Destination Path:";
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(172, 303);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(298, 20);
            this.txt_Destination.TabIndex = 16;
            // 
            // btn_RemovePath
            // 
            this.btn_RemovePath.Location = new System.Drawing.Point(497, 161);
            this.btn_RemovePath.Name = "btn_RemovePath";
            this.btn_RemovePath.Size = new System.Drawing.Size(132, 23);
            this.btn_RemovePath.TabIndex = 15;
            this.btn_RemovePath.Text = "Remove Selected Path";
            this.btn_RemovePath.UseVisualStyleBackColor = true;
            this.btn_RemovePath.Click += new System.EventHandler(this.btn_RemovePath_Click);
            // 
            // lbl_EnterPath
            // 
            this.lbl_EnterPath.AutoSize = true;
            this.lbl_EnterPath.Location = new System.Drawing.Point(172, 84);
            this.lbl_EnterPath.Name = "lbl_EnterPath";
            this.lbl_EnterPath.Size = new System.Drawing.Size(68, 13);
            this.lbl_EnterPath.TabIndex = 14;
            this.lbl_EnterPath.Text = "Enter a path:";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(172, 103);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(298, 20);
            this.txt_Path.TabIndex = 13;
            // 
            // btn_AddPath
            // 
            this.btn_AddPath.Location = new System.Drawing.Point(497, 103);
            this.btn_AddPath.Name = "btn_AddPath";
            this.btn_AddPath.Size = new System.Drawing.Size(132, 23);
            this.btn_AddPath.TabIndex = 12;
            this.btn_AddPath.Text = "Add Path";
            this.btn_AddPath.UseVisualStyleBackColor = true;
            this.btn_AddPath.Click += new System.EventHandler(this.btn_AddPath_Click);
            // 
            // listBox_Paths
            // 
            this.listBox_Paths.FormattingEnabled = true;
            this.listBox_Paths.Location = new System.Drawing.Point(172, 132);
            this.listBox_Paths.Name = "listBox_Paths";
            this.listBox_Paths.Size = new System.Drawing.Size(298, 134);
            this.listBox_Paths.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OpenXML);
            this.Controls.Add(this.btn_CsvHelper);
            this.Controls.Add(this.btn_ToStringOverride);
            this.Controls.Add(this.btn_StreamWrite);
            this.Controls.Add(this.lbl_Destination);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.btn_RemovePath);
            this.Controls.Add(this.lbl_EnterPath);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.btn_AddPath);
            this.Controls.Add(this.listBox_Paths);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenXML;
        private System.Windows.Forms.Button btn_CsvHelper;
        private System.Windows.Forms.Button btn_ToStringOverride;
        private System.Windows.Forms.Button btn_StreamWrite;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Button btn_RemovePath;
        private System.Windows.Forms.Label lbl_EnterPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_AddPath;
        private System.Windows.Forms.ListBox listBox_Paths;
    }
}

