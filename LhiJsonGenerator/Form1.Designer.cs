namespace LhiJsonGenerator
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
            this.txt_PathToExcel = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txt_JsonOutput = new System.Windows.Forms.TextBox();
            this.btn_GenerateFromValidValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_PathToExcel
            // 
            this.txt_PathToExcel.Location = new System.Drawing.Point(26, 25);
            this.txt_PathToExcel.Name = "txt_PathToExcel";
            this.txt_PathToExcel.Size = new System.Drawing.Size(412, 20);
            this.txt_PathToExcel.TabIndex = 0;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(467, 22);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txt_JsonOutput
            // 
            this.txt_JsonOutput.Location = new System.Drawing.Point(26, 62);
            this.txt_JsonOutput.Multiline = true;
            this.txt_JsonOutput.Name = "txt_JsonOutput";
            this.txt_JsonOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_JsonOutput.Size = new System.Drawing.Size(412, 214);
            this.txt_JsonOutput.TabIndex = 2;
            // 
            // btn_GenerateFromValidValues
            // 
            this.btn_GenerateFromValidValues.Location = new System.Drawing.Point(467, 62);
            this.btn_GenerateFromValidValues.Name = "btn_GenerateFromValidValues";
            this.btn_GenerateFromValidValues.Size = new System.Drawing.Size(75, 47);
            this.btn_GenerateFromValidValues.TabIndex = 3;
            this.btn_GenerateFromValidValues.Text = "Generate from Valid Values";
            this.btn_GenerateFromValidValues.UseVisualStyleBackColor = true;
            this.btn_GenerateFromValidValues.Click += new System.EventHandler(this.btn_GenerateFromValidValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 300);
            this.Controls.Add(this.btn_GenerateFromValidValues);
            this.Controls.Add(this.txt_JsonOutput);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txt_PathToExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PathToExcel;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox txt_JsonOutput;
        private System.Windows.Forms.Button btn_GenerateFromValidValues;
    }
}

