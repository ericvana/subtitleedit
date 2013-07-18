﻿namespace Nikse.SubtitleEdit.Forms
{
    partial class SetMinimumDisplayTimeBetweenParagraphs
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
            this.groupBoxLinesFound = new System.Windows.Forms.GroupBox();
            this.SubtitleListview1 = new Nikse.SubtitleEdit.Controls.SubtitleListView();
            this.numericUpDownMinMillisecondsBetweenLines = new System.Windows.Forms.NumericUpDown();
            this.labelMaxMillisecondsBetweenLines = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxShowOnlyChangedLines = new System.Windows.Forms.CheckBox();
            this.comboBoxFrameRate = new System.Windows.Forms.ComboBox();
            this.labelOneFrameIsXMS = new System.Windows.Forms.Label();
            this.groupBoxFrameInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxLinesFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinMillisecondsBetweenLines)).BeginInit();
            this.groupBoxFrameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLinesFound
            // 
            this.groupBoxLinesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLinesFound.Controls.Add(this.SubtitleListview1);
            this.groupBoxLinesFound.Location = new System.Drawing.Point(18, 94);
            this.groupBoxLinesFound.Name = "groupBoxLinesFound";
            this.groupBoxLinesFound.Size = new System.Drawing.Size(726, 347);
            this.groupBoxLinesFound.TabIndex = 14;
            this.groupBoxLinesFound.TabStop = false;
            this.groupBoxLinesFound.Text = "Preview";
            // 
            // SubtitleListview1
            // 
            this.SubtitleListview1.AllowDrop = true;
            this.SubtitleListview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtitleListview1.DisplayExtraFromExtra = false;
            this.SubtitleListview1.FirstVisibleIndex = -1;
            this.SubtitleListview1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleListview1.FullRowSelect = true;
            this.SubtitleListview1.GridLines = true;
            this.SubtitleListview1.HideSelection = false;
            this.SubtitleListview1.Location = new System.Drawing.Point(6, 19);
            this.SubtitleListview1.Name = "SubtitleListview1";
            this.SubtitleListview1.OwnerDraw = true;
            this.SubtitleListview1.Size = new System.Drawing.Size(714, 322);
            this.SubtitleListview1.TabIndex = 5;
            this.SubtitleListview1.UseCompatibleStateImageBehavior = false;
            this.SubtitleListview1.UseSyntaxColoring = true;
            this.SubtitleListview1.View = System.Windows.Forms.View.Details;
            // 
            // numericUpDownMinMillisecondsBetweenLines
            // 
            this.numericUpDownMinMillisecondsBetweenLines.Location = new System.Drawing.Point(18, 34);
            this.numericUpDownMinMillisecondsBetweenLines.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinMillisecondsBetweenLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinMillisecondsBetweenLines.Name = "numericUpDownMinMillisecondsBetweenLines";
            this.numericUpDownMinMillisecondsBetweenLines.Size = new System.Drawing.Size(64, 24);
            this.numericUpDownMinMillisecondsBetweenLines.TabIndex = 34;
            this.numericUpDownMinMillisecondsBetweenLines.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMinMillisecondsBetweenLines.ValueChanged += new System.EventHandler(this.numericUpDownMinMillisecondsBetweenLines_ValueChanged);
            this.numericUpDownMinMillisecondsBetweenLines.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownMinMillisecondsBetweenLines_KeyUp);
            // 
            // labelMaxMillisecondsBetweenLines
            // 
            this.labelMaxMillisecondsBetweenLines.AutoSize = true;
            this.labelMaxMillisecondsBetweenLines.Location = new System.Drawing.Point(15, 18);
            this.labelMaxMillisecondsBetweenLines.Name = "labelMaxMillisecondsBetweenLines";
            this.labelMaxMillisecondsBetweenLines.Size = new System.Drawing.Size(217, 17);
            this.labelMaxMillisecondsBetweenLines.TabIndex = 35;
            this.labelMaxMillisecondsBetweenLines.Text = "Mininum milliseconds between lines";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(595, 447);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 36;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(676, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxShowOnlyChangedLines
            // 
            this.checkBoxShowOnlyChangedLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowOnlyChangedLines.AutoSize = true;
            this.checkBoxShowOnlyChangedLines.Location = new System.Drawing.Point(18, 444);
            this.checkBoxShowOnlyChangedLines.Name = "checkBoxShowOnlyChangedLines";
            this.checkBoxShowOnlyChangedLines.Size = new System.Drawing.Size(178, 21);
            this.checkBoxShowOnlyChangedLines.TabIndex = 38;
            this.checkBoxShowOnlyChangedLines.Text = "Show only modified lines";
            this.checkBoxShowOnlyChangedLines.UseVisualStyleBackColor = true;
            this.checkBoxShowOnlyChangedLines.CheckedChanged += new System.EventHandler(this.checkBoxShowOnlyChangedLines_CheckedChanged);
            // 
            // comboBoxFrameRate
            // 
            this.comboBoxFrameRate.FormattingEnabled = true;
            this.comboBoxFrameRate.Location = new System.Drawing.Point(7, 25);
            this.comboBoxFrameRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFrameRate.Name = "comboBoxFrameRate";
            this.comboBoxFrameRate.Size = new System.Drawing.Size(160, 25);
            this.comboBoxFrameRate.TabIndex = 39;
            this.comboBoxFrameRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrameRate_SelectedIndexChanged);
            // 
            // labelOneFrameIsXMS
            // 
            this.labelOneFrameIsXMS.AutoSize = true;
            this.labelOneFrameIsXMS.Location = new System.Drawing.Point(6, 57);
            this.labelOneFrameIsXMS.Name = "labelOneFrameIsXMS";
            this.labelOneFrameIsXMS.Size = new System.Drawing.Size(170, 17);
            this.labelOneFrameIsXMS.TabIndex = 40;
            this.labelOneFrameIsXMS.Text = "One frame is x milliseconds";
            // 
            // groupBoxFrameInfo
            // 
            this.groupBoxFrameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFrameInfo.Controls.Add(this.comboBoxFrameRate);
            this.groupBoxFrameInfo.Controls.Add(this.labelOneFrameIsXMS);
            this.groupBoxFrameInfo.Location = new System.Drawing.Point(355, 12);
            this.groupBoxFrameInfo.Name = "groupBoxFrameInfo";
            this.groupBoxFrameInfo.Size = new System.Drawing.Size(383, 76);
            this.groupBoxFrameInfo.TabIndex = 41;
            this.groupBoxFrameInfo.TabStop = false;
            this.groupBoxFrameInfo.Text = "Frame rate info";
            // 
            // SetMinimumDisplayTimeBetweenParagraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 480);
            this.Controls.Add(this.groupBoxFrameInfo);
            this.Controls.Add(this.checkBoxShowOnlyChangedLines);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownMinMillisecondsBetweenLines);
            this.Controls.Add(this.labelMaxMillisecondsBetweenLines);
            this.Controls.Add(this.groupBoxLinesFound);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "SetMinimumDisplayTimeBetweenParagraphs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set minimum display time between paragraphs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetMinimalDisplayTimeDifference_KeyDown);
            this.groupBoxLinesFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinMillisecondsBetweenLines)).EndInit();
            this.groupBoxFrameInfo.ResumeLayout(false);
            this.groupBoxFrameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLinesFound;
        private System.Windows.Forms.NumericUpDown numericUpDownMinMillisecondsBetweenLines;
        private System.Windows.Forms.Label labelMaxMillisecondsBetweenLines;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private Controls.SubtitleListView SubtitleListview1;
        private System.Windows.Forms.CheckBox checkBoxShowOnlyChangedLines;
        private System.Windows.Forms.ComboBox comboBoxFrameRate;
        private System.Windows.Forms.Label labelOneFrameIsXMS;
        private System.Windows.Forms.GroupBox groupBoxFrameInfo;
    }
}