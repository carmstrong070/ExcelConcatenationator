namespace AFHSBEntryGenerator
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
            this.txt_Mappings = new System.Windows.Forms.TextBox();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Mappings
            // 
            this.txt_Mappings.Location = new System.Drawing.Point(56, 70);
            this.txt_Mappings.Name = "txt_Mappings";
            this.txt_Mappings.Size = new System.Drawing.Size(465, 22);
            this.txt_Mappings.TabIndex = 0;
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(56, 49);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(286, 17);
            this.lbl_Path.TabIndex = 1;
            this.lbl_Path.Text = "Path to folder with Mapping and Translation:";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(586, 66);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(93, 31);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 150);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.txt_Mappings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Mappings;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Button btn_Generate;
    }
}

