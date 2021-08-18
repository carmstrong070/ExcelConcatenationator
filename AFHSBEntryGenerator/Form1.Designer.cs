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
            this.btn_CompareValidValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Mappings
            // 
            this.txt_Mappings.Location = new System.Drawing.Point(42, 57);
            this.txt_Mappings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Mappings.Name = "txt_Mappings";
            this.txt_Mappings.Size = new System.Drawing.Size(350, 20);
            this.txt_Mappings.TabIndex = 0;
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(42, 40);
            this.lbl_Path.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(215, 13);
            this.lbl_Path.TabIndex = 1;
            this.lbl_Path.Text = "Path to folder with Mapping and Translation:";
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(440, 54);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 25);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_CompareValidValues
            // 
            this.btn_CompareValidValues.Location = new System.Drawing.Point(440, 85);
            this.btn_CompareValidValues.Name = "btn_CompareValidValues";
            this.btn_CompareValidValues.Size = new System.Drawing.Size(75, 37);
            this.btn_CompareValidValues.TabIndex = 4;
            this.btn_CompareValidValues.Text = "Compare Valid Values";
            this.btn_CompareValidValues.UseVisualStyleBackColor = true;
            this.btn_CompareValidValues.Click += new System.EventHandler(this.btn_CompareValidValues_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 207);
            this.Controls.Add(this.btn_CompareValidValues);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.txt_Mappings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Mappings;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_CompareValidValues;
    }
}

