namespace ExcelConcatenationator
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
            this.listBox_Paths = new System.Windows.Forms.ListBox();
            this.btn_AddPath = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.lbl_EnterPath = new System.Windows.Forms.Label();
            this.btn_RemovePath = new System.Windows.Forms.Button();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Paths
            // 
            this.listBox_Paths.FormattingEnabled = true;
            this.listBox_Paths.Location = new System.Drawing.Point(28, 71);
            this.listBox_Paths.Name = "listBox_Paths";
            this.listBox_Paths.Size = new System.Drawing.Size(298, 134);
            this.listBox_Paths.TabIndex = 0;
            // 
            // btn_AddPath
            // 
            this.btn_AddPath.Location = new System.Drawing.Point(353, 42);
            this.btn_AddPath.Name = "btn_AddPath";
            this.btn_AddPath.Size = new System.Drawing.Size(132, 23);
            this.btn_AddPath.TabIndex = 1;
            this.btn_AddPath.Text = "Add Path";
            this.btn_AddPath.UseVisualStyleBackColor = true;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(28, 42);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(298, 20);
            this.txt_Path.TabIndex = 2;
            // 
            // lbl_EnterPath
            // 
            this.lbl_EnterPath.AutoSize = true;
            this.lbl_EnterPath.Location = new System.Drawing.Point(28, 23);
            this.lbl_EnterPath.Name = "lbl_EnterPath";
            this.lbl_EnterPath.Size = new System.Drawing.Size(68, 13);
            this.lbl_EnterPath.TabIndex = 3;
            this.lbl_EnterPath.Text = "Enter a path:";
            // 
            // btn_RemovePath
            // 
            this.btn_RemovePath.Location = new System.Drawing.Point(353, 100);
            this.btn_RemovePath.Name = "btn_RemovePath";
            this.btn_RemovePath.Size = new System.Drawing.Size(132, 23);
            this.btn_RemovePath.TabIndex = 4;
            this.btn_RemovePath.Text = "Remove Selected Path";
            this.btn_RemovePath.UseVisualStyleBackColor = true;
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(28, 242);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(298, 20);
            this.txt_Destination.TabIndex = 5;
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(28, 223);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(88, 13);
            this.lbl_Destination.TabIndex = 6;
            this.lbl_Destination.Text = "Destination Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 283);
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

        private System.Windows.Forms.ListBox listBox_Paths;
        private System.Windows.Forms.Button btn_AddPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label lbl_EnterPath;
        private System.Windows.Forms.Button btn_RemovePath;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Label lbl_Destination;
    }
}

