﻿namespace Summitive_yo
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
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(62, 165);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(165, 84);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Click To Read Horoscope";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summitive_yo.Properties.Resources.cancer_n_shit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "horoscopeSummative";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
    }
}

