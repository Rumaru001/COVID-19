namespace CoVID
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lStatistic = new System.Windows.Forms.Label();
            this.bParse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bAdd = new System.Windows.Forms.Button();
            this.chBPdf = new System.Windows.Forms.CheckBox();
            this.bImport = new System.Windows.Forms.Button();
            this.tBCountry = new System.Windows.Forms.TextBox();
            this.tBCases = new System.Windows.Forms.TextBox();
            this.tBDeaths = new System.Windows.Forms.TextBox();
            this.tBRecoveries = new System.Windows.Forms.TextBox();
            this.lCountry = new System.Windows.Forms.Label();
            this.lCases = new System.Windows.Forms.Label();
            this.lDeaths = new System.Windows.Forms.Label();
            this.lRecoveries = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "COVID-19";
            // 
            // lStatistic
            // 
            this.lStatistic.AutoSize = true;
            this.lStatistic.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatistic.Location = new System.Drawing.Point(2, 170);
            this.lStatistic.Name = "lStatistic";
            this.lStatistic.Size = new System.Drawing.Size(179, 40);
            this.lStatistic.TabIndex = 3;
            this.lStatistic.Text = "Statistic in:";
            this.lStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bParse
            // 
            this.bParse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bParse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bParse.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bParse.FlatAppearance.BorderSize = 0;
            this.bParse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bParse.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bParse.Location = new System.Drawing.Point(82, 106);
            this.bParse.Name = "bParse";
            this.bParse.Size = new System.Drawing.Size(256, 61);
            this.bParse.TabIndex = 11;
            this.bParse.Text = "PARSE";
            this.bParse.UseVisualStyleBackColor = false;
            this.bParse.Click += new System.EventHandler(this.bParse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 89);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bAdd.FlatAppearance.BorderSize = 0;
            this.bAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bAdd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(110, 381);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(194, 48);
            this.bAdd.TabIndex = 15;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // chBPdf
            // 
            this.chBPdf.AutoSize = true;
            this.chBPdf.Checked = true;
            this.chBPdf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBPdf.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBPdf.Location = new System.Drawing.Point(12, 444);
            this.chBPdf.Name = "chBPdf";
            this.chBPdf.Size = new System.Drawing.Size(400, 26);
            this.chBPdf.TabIndex = 14;
            this.chBPdf.Text = "Open PDF after import (Recommended)";
            this.chBPdf.UseVisualStyleBackColor = true;
            // 
            // bImport
            // 
            this.bImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bImport.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bImport.FlatAppearance.BorderSize = 0;
            this.bImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bImport.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bImport.Location = new System.Drawing.Point(85, 483);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(256, 61);
            this.bImport.TabIndex = 16;
            this.bImport.Text = "IMPORT";
            this.bImport.UseVisualStyleBackColor = false;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // tBCountry
            // 
            this.tBCountry.Location = new System.Drawing.Point(194, 226);
            this.tBCountry.Name = "tBCountry";
            this.tBCountry.ReadOnly = true;
            this.tBCountry.Size = new System.Drawing.Size(191, 22);
            this.tBCountry.TabIndex = 17;
            // 
            // tBCases
            // 
            this.tBCases.Location = new System.Drawing.Point(194, 265);
            this.tBCases.Name = "tBCases";
            this.tBCases.ReadOnly = true;
            this.tBCases.Size = new System.Drawing.Size(191, 22);
            this.tBCases.TabIndex = 18;
            // 
            // tBDeaths
            // 
            this.tBDeaths.Location = new System.Drawing.Point(194, 304);
            this.tBDeaths.Name = "tBDeaths";
            this.tBDeaths.ReadOnly = true;
            this.tBDeaths.Size = new System.Drawing.Size(191, 22);
            this.tBDeaths.TabIndex = 17;
            // 
            // tBRecoveries
            // 
            this.tBRecoveries.Location = new System.Drawing.Point(194, 343);
            this.tBRecoveries.Name = "tBRecoveries";
            this.tBRecoveries.ReadOnly = true;
            this.tBRecoveries.Size = new System.Drawing.Size(191, 22);
            this.tBRecoveries.TabIndex = 18;
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountry.Location = new System.Drawing.Point(34, 219);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(107, 30);
            this.lCountry.TabIndex = 19;
            this.lCountry.Text = "Country";
            // 
            // lCases
            // 
            this.lCases.AutoSize = true;
            this.lCases.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCases.Location = new System.Drawing.Point(37, 258);
            this.lCases.Name = "lCases";
            this.lCases.Size = new System.Drawing.Size(85, 30);
            this.lCases.TabIndex = 19;
            this.lCases.Text = "Cases";
            // 
            // lDeaths
            // 
            this.lDeaths.AutoSize = true;
            this.lDeaths.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDeaths.Location = new System.Drawing.Point(37, 297);
            this.lDeaths.Name = "lDeaths";
            this.lDeaths.Size = new System.Drawing.Size(96, 30);
            this.lDeaths.TabIndex = 19;
            this.lDeaths.Text = "Deaths";
            // 
            // lRecoveries
            // 
            this.lRecoveries.AutoSize = true;
            this.lRecoveries.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRecoveries.Location = new System.Drawing.Point(37, 336);
            this.lRecoveries.Name = "lRecoveries";
            this.lRecoveries.Size = new System.Drawing.Size(146, 30);
            this.lRecoveries.TabIndex = 19;
            this.lRecoveries.Text = "Recoveries";
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(364, 144);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(51, 23);
            this.bUpdate.TabIndex = 20;
            this.bUpdate.Text = "UPD";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 555);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.lRecoveries);
            this.Controls.Add(this.lDeaths);
            this.Controls.Add(this.lCases);
            this.Controls.Add(this.lCountry);
            this.Controls.Add(this.tBRecoveries);
            this.Controls.Add(this.tBDeaths);
            this.Controls.Add(this.tBCases);
            this.Controls.Add(this.tBCountry);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.chBPdf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bParse);
            this.Controls.Add(this.lStatistic);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "COVID-19 Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lStatistic;
        private System.Windows.Forms.Button bParse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.CheckBox chBPdf;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.TextBox tBCountry;
        private System.Windows.Forms.TextBox tBCases;
        private System.Windows.Forms.TextBox tBDeaths;
        private System.Windows.Forms.TextBox tBRecoveries;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lCases;
        private System.Windows.Forms.Label lDeaths;
        private System.Windows.Forms.Label lRecoveries;
        private System.Windows.Forms.Button bUpdate;
    }
}