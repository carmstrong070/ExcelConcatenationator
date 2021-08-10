
namespace AirmenFSCGenerator
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
            this.btn_GenerateApplyValues = new System.Windows.Forms.Button();
            this.btn_GenerateCodeBehindBehavior = new System.Windows.Forms.Button();
            this.btn_GenerateHtml = new System.Windows.Forms.Button();
            this.lbl_PathToExcel = new System.Windows.Forms.Label();
            this.txt_PathToExcel = new System.Windows.Forms.TextBox();
            this.btn_GenerateResponseReview = new System.Windows.Forms.Button();
            this.btn_GenerateAHLTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerateApplyValues
            // 
            this.btn_GenerateApplyValues.Location = new System.Drawing.Point(487, 113);
            this.btn_GenerateApplyValues.Name = "btn_GenerateApplyValues";
            this.btn_GenerateApplyValues.Size = new System.Drawing.Size(167, 23);
            this.btn_GenerateApplyValues.TabIndex = 9;
            this.btn_GenerateApplyValues.Text = "Generate Apply Values";
            this.btn_GenerateApplyValues.UseVisualStyleBackColor = true;
            this.btn_GenerateApplyValues.Click += new System.EventHandler(this.btn_GenerateApplyValues_Click);
            // 
            // btn_GenerateCodeBehindBehavior
            // 
            this.btn_GenerateCodeBehindBehavior.Location = new System.Drawing.Point(487, 83);
            this.btn_GenerateCodeBehindBehavior.Name = "btn_GenerateCodeBehindBehavior";
            this.btn_GenerateCodeBehindBehavior.Size = new System.Drawing.Size(167, 23);
            this.btn_GenerateCodeBehindBehavior.TabIndex = 8;
            this.btn_GenerateCodeBehindBehavior.Text = "Generate Initial Control State";
            this.btn_GenerateCodeBehindBehavior.UseVisualStyleBackColor = true;
            this.btn_GenerateCodeBehindBehavior.Click += new System.EventHandler(this.btn_GenerateCodeBehindBehavior_Click);
            // 
            // btn_GenerateHtml
            // 
            this.btn_GenerateHtml.Location = new System.Drawing.Point(487, 53);
            this.btn_GenerateHtml.Name = "btn_GenerateHtml";
            this.btn_GenerateHtml.Size = new System.Drawing.Size(167, 23);
            this.btn_GenerateHtml.TabIndex = 7;
            this.btn_GenerateHtml.Text = "Generate HTML";
            this.btn_GenerateHtml.UseVisualStyleBackColor = true;
            this.btn_GenerateHtml.Click += new System.EventHandler(this.btn_GenerateHtml_Click);
            // 
            // lbl_PathToExcel
            // 
            this.lbl_PathToExcel.AutoSize = true;
            this.lbl_PathToExcel.Location = new System.Drawing.Point(53, 34);
            this.lbl_PathToExcel.Name = "lbl_PathToExcel";
            this.lbl_PathToExcel.Size = new System.Drawing.Size(77, 13);
            this.lbl_PathToExcel.TabIndex = 6;
            this.lbl_PathToExcel.Text = "Path To Excel:";
            // 
            // txt_PathToExcel
            // 
            this.txt_PathToExcel.Location = new System.Drawing.Point(53, 53);
            this.txt_PathToExcel.Name = "txt_PathToExcel";
            this.txt_PathToExcel.Size = new System.Drawing.Size(306, 20);
            this.txt_PathToExcel.TabIndex = 5;
            // 
            // btn_GenerateResponseReview
            // 
            this.btn_GenerateResponseReview.Location = new System.Drawing.Point(487, 143);
            this.btn_GenerateResponseReview.Name = "btn_GenerateResponseReview";
            this.btn_GenerateResponseReview.Size = new System.Drawing.Size(167, 23);
            this.btn_GenerateResponseReview.TabIndex = 10;
            this.btn_GenerateResponseReview.Text = "Generate Response Review";
            this.btn_GenerateResponseReview.UseVisualStyleBackColor = true;
            this.btn_GenerateResponseReview.Click += new System.EventHandler(this.btn_GenerateResponseReview_Click);
            // 
            // btn_GenerateAHLTA
            // 
            this.btn_GenerateAHLTA.Location = new System.Drawing.Point(487, 173);
            this.btn_GenerateAHLTA.Name = "btn_GenerateAHLTA";
            this.btn_GenerateAHLTA.Size = new System.Drawing.Size(167, 23);
            this.btn_GenerateAHLTA.TabIndex = 11;
            this.btn_GenerateAHLTA.Text = "Generate AHLTA";
            this.btn_GenerateAHLTA.UseVisualStyleBackColor = true;
            this.btn_GenerateAHLTA.Click += new System.EventHandler(this.btn_GenerateAHLTA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GenerateAHLTA);
            this.Controls.Add(this.btn_GenerateResponseReview);
            this.Controls.Add(this.btn_GenerateApplyValues);
            this.Controls.Add(this.btn_GenerateCodeBehindBehavior);
            this.Controls.Add(this.btn_GenerateHtml);
            this.Controls.Add(this.lbl_PathToExcel);
            this.Controls.Add(this.txt_PathToExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerateApplyValues;
        private System.Windows.Forms.Button btn_GenerateCodeBehindBehavior;
        private System.Windows.Forms.Button btn_GenerateHtml;
        private System.Windows.Forms.Label lbl_PathToExcel;
        private System.Windows.Forms.TextBox txt_PathToExcel;
        private System.Windows.Forms.Button btn_GenerateResponseReview;
        private System.Windows.Forms.Button btn_GenerateAHLTA;
    }
}

