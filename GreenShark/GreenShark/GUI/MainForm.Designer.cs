namespace GreenShark.GUI
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMission = new System.Windows.Forms.TabPage();
            this.btNewHOPE = new System.Windows.Forms.Button();
            this.btNewSIN = new System.Windows.Forms.Button();
            this.lbxHOPE = new System.Windows.Forms.ListBox();
            this.lbxSIN = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSin = new System.Windows.Forms.Label();
            this.tpMissionProfile = new System.Windows.Forms.TabPage();
            this.btLogOut = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMission);
            this.tcMain.Controls.Add(this.tpMissionProfile);
            this.tcMain.Location = new System.Drawing.Point(12, 44);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1240, 625);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpMission
            // 
            this.tpMission.Controls.Add(this.btNewHOPE);
            this.tpMission.Controls.Add(this.btNewSIN);
            this.tpMission.Controls.Add(this.lbxHOPE);
            this.tpMission.Controls.Add(this.lbxSIN);
            this.tpMission.Controls.Add(this.label1);
            this.tpMission.Controls.Add(this.lblSin);
            this.tpMission.Location = new System.Drawing.Point(4, 22);
            this.tpMission.Name = "tpMission";
            this.tpMission.Size = new System.Drawing.Size(1232, 599);
            this.tpMission.TabIndex = 0;
            this.tpMission.Text = "Missiebeheer";
            this.tpMission.UseVisualStyleBackColor = true;
            // 
            // btNewHOPE
            // 
            this.btNewHOPE.Location = new System.Drawing.Point(634, 15);
            this.btNewHOPE.Name = "btNewHOPE";
            this.btNewHOPE.Size = new System.Drawing.Size(118, 23);
            this.btNewHOPE.TabIndex = 5;
            this.btNewHOPE.Text = "Nieuwe HOPE missie";
            this.btNewHOPE.UseVisualStyleBackColor = true;
            this.btNewHOPE.Click += new System.EventHandler(this.btNewHOPE_Click);
            // 
            // btNewSIN
            // 
            this.btNewSIN.Location = new System.Drawing.Point(24, 15);
            this.btNewSIN.Name = "btNewSIN";
            this.btNewSIN.Size = new System.Drawing.Size(118, 23);
            this.btNewSIN.TabIndex = 4;
            this.btNewSIN.Text = "Nieuwe SIN missie";
            this.btNewSIN.UseVisualStyleBackColor = true;
            this.btNewSIN.Click += new System.EventHandler(this.btNewSIN_Click);
            // 
            // lbxHOPE
            // 
            this.lbxHOPE.FormattingEnabled = true;
            this.lbxHOPE.Location = new System.Drawing.Point(634, 87);
            this.lbxHOPE.Name = "lbxHOPE";
            this.lbxHOPE.Size = new System.Drawing.Size(566, 485);
            this.lbxHOPE.TabIndex = 3;
            this.lbxHOPE.SelectedValueChanged += new System.EventHandler(this.lbxHOPE_SelectedValueChanged);
            // 
            // lbxSIN
            // 
            this.lbxSIN.FormattingEnabled = true;
            this.lbxSIN.Location = new System.Drawing.Point(24, 88);
            this.lbxSIN.Name = "lbxSIN";
            this.lbxSIN.Size = new System.Drawing.Size(555, 485);
            this.lbxSIN.TabIndex = 2;
            this.lbxSIN.SelectedValueChanged += new System.EventHandler(this.lbxSIN_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOPE";
            // 
            // lblSin
            // 
            this.lblSin.AutoSize = true;
            this.lblSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSin.Location = new System.Drawing.Point(19, 59);
            this.lblSin.Name = "lblSin";
            this.lblSin.Size = new System.Drawing.Size(46, 25);
            this.lblSin.TabIndex = 0;
            this.lblSin.Text = "SIN";
            // 
            // tpMissionProfile
            // 
            this.tpMissionProfile.Location = new System.Drawing.Point(4, 22);
            this.tpMissionProfile.Name = "tpMissionProfile";
            this.tpMissionProfile.Size = new System.Drawing.Size(1232, 599);
            this.tpMissionProfile.TabIndex = 1;
            this.tpMissionProfile.Text = "Missieprofielen";
            this.tpMissionProfile.UseVisualStyleBackColor = true;
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(1173, 15);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(75, 23);
            this.btLogOut.TabIndex = 1;
            this.btLogOut.Text = "Uitloggen";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(182)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tcMain.ResumeLayout(false);
            this.tpMission.ResumeLayout(false);
            this.tpMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMission;
        private System.Windows.Forms.Button btNewHOPE;
        private System.Windows.Forms.Button btNewSIN;
        private System.Windows.Forms.ListBox lbxHOPE;
        private System.Windows.Forms.ListBox lbxSIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSin;
        private System.Windows.Forms.TabPage tpMissionProfile;
        private System.Windows.Forms.Button btLogOut;
    }
}