﻿namespace private_class_application
{
    partial class StudentRegistrationinfo
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
            this.Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 11);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 0;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Personalinfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // StudentRegistrationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Display);
            this.Name = "StudentRegistrationinfo";
            this.Text = "StudentRegistrationinfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}