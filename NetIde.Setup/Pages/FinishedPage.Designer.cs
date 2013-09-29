﻿namespace NetIde.Setup.Pages
{
    partial class FinishedPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._headerLabel = new System.Windows.Forms.Label();
            this._wizardLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._controlContainer = new System.Windows.Forms.TableLayoutPanel();
            this._start = new System.Windows.Forms.CheckBox();
            this.formFooter1 = new NetIde.Setup.FormFooter();
            this._cancelButton = new System.Windows.Forms.Button();
            this._acceptButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._controlContainer.SuspendLayout();
            this.formFooter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(484, 309);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._headerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._wizardLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._controlContainer, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _headerLabel
            // 
            this._headerLabel.AutoSize = true;
            this._headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._headerLabel.Location = new System.Drawing.Point(3, 6);
            this._headerLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this._headerLabel.Name = "_headerLabel";
            this._headerLabel.Size = new System.Drawing.Size(93, 20);
            this._headerLabel.TabIndex = 0;
            this._headerLabel.Text = "<<mode>>";
            // 
            // _wizardLabel
            // 
            this._wizardLabel.AutoSize = true;
            this._wizardLabel.Location = new System.Drawing.Point(3, 38);
            this._wizardLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this._wizardLabel.Name = "_wizardLabel";
            this._wizardLabel.Size = new System.Drawing.Size(97, 13);
            this._wizardLabel.TabIndex = 1;
            this._wizardLabel.Text = "<<mode sub text>>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click Finish to close the wizard.";
            // 
            // _controlContainer
            // 
            this._controlContainer.ColumnCount = 1;
            this._controlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._controlContainer.Controls.Add(this._start, 0, 0);
            this._controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._controlContainer.Location = new System.Drawing.Point(0, 97);
            this._controlContainer.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this._controlContainer.Name = "_controlContainer";
            this._controlContainer.RowCount = 1;
            this._controlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._controlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this._controlContainer.Size = new System.Drawing.Size(460, 188);
            this._controlContainer.TabIndex = 4;
            // 
            // _start
            // 
            this._start.AutoSize = true;
            this._start.Checked = true;
            this._start.CheckState = System.Windows.Forms.CheckState.Checked;
            this._start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._start.Location = new System.Drawing.Point(3, 3);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(71, 18);
            this._start.TabIndex = 0;
            this._start.Text = "&Start {0}";
            this._start.UseVisualStyleBackColor = true;
            // 
            // formFooter1
            // 
            this.formFooter1.Controls.Add(this._cancelButton);
            this.formFooter1.Controls.Add(this._acceptButton);
            this.formFooter1.Location = new System.Drawing.Point(0, 309);
            this.formFooter1.Name = "formFooter1";
            this.formFooter1.Size = new System.Drawing.Size(484, 53);
            this.formFooter1.TabIndex = 1;
            // 
            // _cancelButton
            // 
            this._cancelButton.Enabled = false;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cancelButton.Location = new System.Drawing.Point(397, 20);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _acceptButton
            // 
            this._acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._acceptButton.Location = new System.Drawing.Point(316, 20);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(75, 23);
            this._acceptButton.TabIndex = 2;
            this._acceptButton.Text = "&Finish";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // FinishedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formFooter1);
            this.Name = "FinishedPage";
            this.Size = new System.Drawing.Size(484, 362);
            this.Load += new System.EventHandler(this.FinishedPage_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._controlContainer.ResumeLayout(false);
            this._controlContainer.PerformLayout();
            this.formFooter1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _headerLabel;
        private System.Windows.Forms.Label _wizardLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel _controlContainer;
        private FormFooter formFooter1;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.CheckBox _start;
    }
}
