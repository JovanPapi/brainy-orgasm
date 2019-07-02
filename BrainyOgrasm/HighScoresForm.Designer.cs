﻿namespace BrainyOgrasm
{
    partial class HighScoresForm
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
            this.dgvUsersScores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbVisualStudio = new System.Windows.Forms.RadioButton();
            this.rbScientists = new System.Windows.Forms.RadioButton();
            this.rbUniverse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersScores
            // 
            this.dgvUsersScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersScores.Location = new System.Drawing.Point(12, 54);
            this.dgvUsersScores.Name = "dgvUsersScores";
            this.dgvUsersScores.Size = new System.Drawing.Size(243, 135);
            this.dgvUsersScores.TabIndex = 10;
            this.dgvUsersScores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersScores_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "User - Score :";
            // 
            // rbVisualStudio
            // 
            this.rbVisualStudio.AutoSize = true;
            this.rbVisualStudio.Font = new System.Drawing.Font("Arial", 9F);
            this.rbVisualStudio.Location = new System.Drawing.Point(164, 12);
            this.rbVisualStudio.Name = "rbVisualStudio";
            this.rbVisualStudio.Size = new System.Drawing.Size(94, 19);
            this.rbVisualStudio.TabIndex = 8;
            this.rbVisualStudio.TabStop = true;
            this.rbVisualStudio.Text = "VisualStudio";
            this.rbVisualStudio.UseVisualStyleBackColor = true;
            this.rbVisualStudio.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbScientists
            // 
            this.rbScientists.AutoSize = true;
            this.rbScientists.Font = new System.Drawing.Font("Arial", 9F);
            this.rbScientists.Location = new System.Drawing.Point(86, 12);
            this.rbScientists.Name = "rbScientists";
            this.rbScientists.Size = new System.Drawing.Size(79, 19);
            this.rbScientists.TabIndex = 7;
            this.rbScientists.TabStop = true;
            this.rbScientists.Text = "Scientists";
            this.rbScientists.UseVisualStyleBackColor = true;
            this.rbScientists.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbUniverse
            // 
            this.rbUniverse.AutoSize = true;
            this.rbUniverse.Font = new System.Drawing.Font("Arial", 9F);
            this.rbUniverse.Location = new System.Drawing.Point(12, 12);
            this.rbUniverse.Name = "rbUniverse";
            this.rbUniverse.Size = new System.Drawing.Size(74, 19);
            this.rbUniverse.TabIndex = 6;
            this.rbUniverse.TabStop = true;
            this.rbUniverse.Text = "Universe";
            this.rbUniverse.UseVisualStyleBackColor = true;
            this.rbUniverse.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 202);
            this.Controls.Add(this.dgvUsersScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVisualStudio);
            this.Controls.Add(this.rbScientists);
            this.Controls.Add(this.rbUniverse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HighScoresForm";
            this.Text = "High Scores Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbVisualStudio;
        private System.Windows.Forms.RadioButton rbScientists;
        private System.Windows.Forms.RadioButton rbUniverse;
    }
}