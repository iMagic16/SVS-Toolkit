﻿namespace SVS_Toolkit
{
    partial class MainFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtFileLoc = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstOutput);
            this.groupBox1.Controls.Add(this.BtnBrowse);
            this.groupBox1.Controls.Add(this.TxtFileLoc);
            this.groupBox1.Controls.Add(this.BtnGo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Change Comparison - Deduplicator";
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.Location = new System.Drawing.Point(8, 20);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(534, 264);
            this.LstOutput.TabIndex = 6;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 294);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(61, 20);
            this.BtnBrowse.TabIndex = 5;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtFileLoc
            // 
            this.TxtFileLoc.Location = new System.Drawing.Point(79, 294);
            this.TxtFileLoc.Name = "TxtFileLoc";
            this.TxtFileLoc.Size = new System.Drawing.Size(428, 20);
            this.TxtFileLoc.TabIndex = 4;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(513, 294);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(29, 20);
            this.BtnGo.TabIndex = 3;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BrowseDialog
            // 
            this.BrowseDialog.Filter = "File to Compare|*.txt|All Files|*.*";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "SVS Toolkit";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtFileLoc;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.ListBox LstOutput;
        private System.Windows.Forms.OpenFileDialog BrowseDialog;
    }
}

