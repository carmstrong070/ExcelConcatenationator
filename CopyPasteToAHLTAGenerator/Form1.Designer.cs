using System;

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
            this.btn_StaticLabels = new System.Windows.Forms.Button();
            this.lbl_Destination = new System.Windows.Forms.Label();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.lbl_EnterPath = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_GenerateSegments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sheet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_StaticLabels
            // 
            this.btn_StaticLabels.Location = new System.Drawing.Point(272, 244);
            this.btn_StaticLabels.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StaticLabels.Name = "btn_StaticLabels";
            this.btn_StaticLabels.Size = new System.Drawing.Size(176, 27);
            this.btn_StaticLabels.TabIndex = 20;
            this.btn_StaticLabels.Text = "Generate Static Labels";
            this.btn_StaticLabels.UseVisualStyleBackColor = true;
            this.btn_StaticLabels.Click += new System.EventHandler(this.btn_StaticLabels_Click);
            // 
            // lbl_Destination
            // 
            this.lbl_Destination.AutoSize = true;
            this.lbl_Destination.Location = new System.Drawing.Point(49, 155);
            this.lbl_Destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Destination.Name = "lbl_Destination";
            this.lbl_Destination.Size = new System.Drawing.Size(116, 17);
            this.lbl_Destination.TabIndex = 17;
            this.lbl_Destination.Text = "Destination Path:";
            // 
            // txt_Destination
            // 
            this.txt_Destination.Location = new System.Drawing.Point(52, 176);
            this.txt_Destination.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(396, 22);
            this.txt_Destination.TabIndex = 16;
            // 
            // lbl_EnterPath
            // 
            this.lbl_EnterPath.AutoSize = true;
            this.lbl_EnterPath.Location = new System.Drawing.Point(49, 93);
            this.lbl_EnterPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EnterPath.Name = "lbl_EnterPath";
            this.lbl_EnterPath.Size = new System.Drawing.Size(90, 17);
            this.lbl_EnterPath.TabIndex = 14;
            this.lbl_EnterPath.Text = "Enter a path:";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(52, 114);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(396, 22);
            this.txt_Path.TabIndex = 13;
            // 
            // btn_GenerateSegments
            // 
            this.btn_GenerateSegments.Location = new System.Drawing.Point(52, 244);
            this.btn_GenerateSegments.Name = "btn_GenerateSegments";
            this.btn_GenerateSegments.Size = new System.Drawing.Size(176, 27);
            this.btn_GenerateSegments.TabIndex = 21;
            this.btn_GenerateSegments.Text = "Generate Segments";
            this.btn_GenerateSegments.UseVisualStyleBackColor = true;
            this.btn_GenerateSegments.Click += new System.EventHandler(this.btn_GenerateSegments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sheet Number:";
            // 
            // txt_Sheet
            // 
            this.txt_Sheet.Location = new System.Drawing.Point(52, 54);
            this.txt_Sheet.Name = "txt_Sheet";
            this.txt_Sheet.Size = new System.Drawing.Size(37, 22);
            this.txt_Sheet.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 322);
            this.Controls.Add(this.txt_Sheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GenerateSegments);
            this.Controls.Add(this.btn_StaticLabels);
            this.Controls.Add(this.lbl_Destination);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.lbl_EnterPath);
            this.Controls.Add(this.txt_Path);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_RemovePath_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btn_StaticLabels;
        private System.Windows.Forms.Label lbl_Destination;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.Label lbl_EnterPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_GenerateSegments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sheet;
    }
}

