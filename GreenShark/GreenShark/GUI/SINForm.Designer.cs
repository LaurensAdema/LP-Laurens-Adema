﻿namespace GreenShark.GUI
{
    partial class SINForm
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
            this.tcSin = new System.Windows.Forms.TabControl();
            this.tpSinMission = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbFunctions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoatType = new System.Windows.Forms.ComboBox();
            this.tbLon2 = new System.Windows.Forms.TextBox();
            this.tbLon1 = new System.Windows.Forms.TextBox();
            this.tbLat2 = new System.Windows.Forms.TextBox();
            this.btSaveSin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLat1 = new System.Windows.Forms.TextBox();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cbMaterials = new System.Windows.Forms.ComboBox();
            this.tcSin.SuspendLayout();
            this.tpSinMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSin
            // 
            this.tcSin.Controls.Add(this.tpSinMission);
            this.tcSin.Location = new System.Drawing.Point(12, 12);
            this.tcSin.Name = "tcSin";
            this.tcSin.SelectedIndex = 0;
            this.tcSin.Size = new System.Drawing.Size(662, 375);
            this.tcSin.TabIndex = 1;
            // 
            // tpSinMission
            // 
            this.tpSinMission.Controls.Add(this.numericUpDown2);
            this.tpSinMission.Controls.Add(this.cbMaterials);
            this.tpSinMission.Controls.Add(this.numericUpDown1);
            this.tpSinMission.Controls.Add(this.cbFunctions);
            this.tpSinMission.Controls.Add(this.label1);
            this.tpSinMission.Controls.Add(this.cbBoatType);
            this.tpSinMission.Controls.Add(this.tbLon2);
            this.tpSinMission.Controls.Add(this.tbLon1);
            this.tpSinMission.Controls.Add(this.tbLat2);
            this.tpSinMission.Controls.Add(this.btSaveSin);
            this.tpSinMission.Controls.Add(this.label6);
            this.tpSinMission.Controls.Add(this.label5);
            this.tpSinMission.Controls.Add(this.label4);
            this.tpSinMission.Controls.Add(this.label2);
            this.tpSinMission.Controls.Add(this.tbLat1);
            this.tpSinMission.Controls.Add(this.dtpDeparture);
            this.tpSinMission.Controls.Add(this.tbDescription);
            this.tpSinMission.Location = new System.Drawing.Point(4, 22);
            this.tpSinMission.Name = "tpSinMission";
            this.tpSinMission.Size = new System.Drawing.Size(654, 349);
            this.tpSinMission.TabIndex = 0;
            this.tpSinMission.Text = "Missie";
            this.tpSinMission.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // cbFunctions
            // 
            this.cbFunctions.FormattingEnabled = true;
            this.cbFunctions.Location = new System.Drawing.Point(19, 46);
            this.cbFunctions.Name = "cbFunctions";
            this.cbFunctions.Size = new System.Drawing.Size(92, 21);
            this.cbFunctions.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type boot";
            // 
            // cbBoatType
            // 
            this.cbBoatType.FormattingEnabled = true;
            this.cbBoatType.Location = new System.Drawing.Point(124, 73);
            this.cbBoatType.Name = "cbBoatType";
            this.cbBoatType.Size = new System.Drawing.Size(121, 21);
            this.cbBoatType.TabIndex = 19;
            // 
            // tbLon2
            // 
            this.tbLon2.Location = new System.Drawing.Point(163, 223);
            this.tbLon2.Name = "tbLon2";
            this.tbLon2.Size = new System.Drawing.Size(60, 20);
            this.tbLon2.TabIndex = 16;
            // 
            // tbLon1
            // 
            this.tbLon1.Location = new System.Drawing.Point(124, 223);
            this.tbLon1.Name = "tbLon1";
            this.tbLon1.Size = new System.Drawing.Size(33, 20);
            this.tbLon1.TabIndex = 15;
            // 
            // tbLat2
            // 
            this.tbLat2.Location = new System.Drawing.Point(163, 199);
            this.tbLat2.Name = "tbLat2";
            this.tbLat2.Size = new System.Drawing.Size(60, 20);
            this.tbLat2.TabIndex = 14;
            // 
            // btSaveSin
            // 
            this.btSaveSin.Location = new System.Drawing.Point(576, 323);
            this.btSaveSin.Name = "btSaveSin";
            this.btSaveSin.Size = new System.Drawing.Size(75, 23);
            this.btSaveSin.TabIndex = 13;
            this.btSaveSin.Text = "Opslaan";
            this.btSaveSin.UseVisualStyleBackColor = true;
            this.btSaveSin.Click += new System.EventHandler(this.btSaveSin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Beschrijving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vertrek datum";
            // 
            // tbLat1
            // 
            this.tbLat1.Location = new System.Drawing.Point(124, 199);
            this.tbLat1.Name = "tbLat1";
            this.tbLat1.Size = new System.Drawing.Size(33, 20);
            this.tbLat1.TabIndex = 5;
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(124, 100);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtpDeparture.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(124, 129);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(245, 64);
            this.tbDescription.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(124, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 24;
            // 
            // cbMaterials
            // 
            this.cbMaterials.FormattingEnabled = true;
            this.cbMaterials.Location = new System.Drawing.Point(19, 20);
            this.cbMaterials.Name = "cbMaterials";
            this.cbMaterials.Size = new System.Drawing.Size(92, 21);
            this.cbMaterials.TabIndex = 23;
            // 
            // SINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(182)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.tcSin);
            this.Name = "SINForm";
            this.Text = "SINForm";
            this.tcSin.ResumeLayout(false);
            this.tpSinMission.ResumeLayout(false);
            this.tpSinMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSin;
        private System.Windows.Forms.TabPage tpSinMission;
        private System.Windows.Forms.TextBox tbLon2;
        private System.Windows.Forms.TextBox tbLon1;
        private System.Windows.Forms.TextBox tbLat2;
        private System.Windows.Forms.Button btSaveSin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLat1;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoatType;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox cbMaterials;
    }
}