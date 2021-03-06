namespace TSDev {
	partial class frmDebugWizard {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label4;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebugWizard));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlStep1 = new System.Windows.Forms.Panel();
			this.optAutoDbg = new System.Windows.Forms.RadioButton();
			this.lblMainCs = new System.Windows.Forms.Label();
			this.txtMainCS = new System.Windows.Forms.TextBox();
			this.cmdBrowseMainCs = new System.Windows.Forms.Button();
			this.optNonAutoDbg = new System.Windows.Forms.RadioButton();
			this.cmdPrevious = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdNext = new System.Windows.Forms.Button();
			this.pnlStep2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDebugExe = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDebugPasswd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmdBrowseEngine = new System.Windows.Forms.Button();
			this.txtDebugPort = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDebugParams = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlStep1.SuspendLayout();
			this.pnlStep2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.White;
			this.pnlTop.Controls.Add(this.lblTitle);
			this.pnlTop.Controls.Add(this.pictureBox1);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(527, 75);
			this.pnlTop.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TSDev.Properties.Resources.startupbanner;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(138, 69);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(147, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(364, 69);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Step 1 - Debug Control";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlStep1
			// 
			this.pnlStep1.Controls.Add(this.cmdBrowseMainCs);
			this.pnlStep1.Controls.Add(this.txtMainCS);
			this.pnlStep1.Controls.Add(this.lblMainCs);
			this.pnlStep1.Controls.Add(this.optNonAutoDbg);
			this.pnlStep1.Controls.Add(this.optAutoDbg);
			this.pnlStep1.Controls.Add(label2);
			this.pnlStep1.Location = new System.Drawing.Point(12, 81);
			this.pnlStep1.Name = "pnlStep1";
			this.pnlStep1.Size = new System.Drawing.Size(503, 226);
			this.pnlStep1.TabIndex = 1;
			this.pnlStep1.VisibleChanged += new System.EventHandler(this.pnlStep1_VisibleChanged);
			// 
			// label2
			// 
			label2.Location = new System.Drawing.Point(3, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(497, 46);
			label2.TabIndex = 0;
			label2.Text = "TorqueDev can insert the \"dbgSetParameters\" automatically into your main.cs file" +
				" when debugging is executed.  If you would rather take care of inserting this yo" +
				"urself, you can choose to do so.";
			// 
			// optAutoDbg
			// 
			this.optAutoDbg.AutoSize = true;
			this.optAutoDbg.Checked = true;
			this.optAutoDbg.Location = new System.Drawing.Point(36, 49);
			this.optAutoDbg.Name = "optAutoDbg";
			this.optAutoDbg.Size = new System.Drawing.Size(160, 18);
			this.optAutoDbg.TabIndex = 1;
			this.optAutoDbg.Text = "Enable \'OneClick\' Debugging";
			this.optAutoDbg.UseVisualStyleBackColor = true;
			this.optAutoDbg.CheckedChanged += new System.EventHandler(this.optAutoDbg_CheckedChanged);
			// 
			// lblMainCs
			// 
			this.lblMainCs.AutoSize = true;
			this.lblMainCs.Location = new System.Drawing.Point(71, 76);
			this.lblMainCs.Name = "lblMainCs";
			this.lblMainCs.Size = new System.Drawing.Size(64, 14);
			this.lblMainCs.TabIndex = 2;
			this.lblMainCs.Text = "Main.cs file:";
			// 
			// txtMainCS
			// 
			this.txtMainCS.Location = new System.Drawing.Point(141, 73);
			this.txtMainCS.Name = "txtMainCS";
			this.txtMainCS.Size = new System.Drawing.Size(270, 20);
			this.txtMainCS.TabIndex = 3;
			// 
			// cmdBrowseMainCs
			// 
			this.cmdBrowseMainCs.Location = new System.Drawing.Point(417, 72);
			this.cmdBrowseMainCs.Name = "cmdBrowseMainCs";
			this.cmdBrowseMainCs.Size = new System.Drawing.Size(75, 23);
			this.cmdBrowseMainCs.TabIndex = 4;
			this.cmdBrowseMainCs.Text = "Browse";
			this.cmdBrowseMainCs.UseVisualStyleBackColor = true;
			this.cmdBrowseMainCs.Click += new System.EventHandler(this.cmdBrowseMainCs_Click);
			// 
			// optNonAutoDbg
			// 
			this.optNonAutoDbg.AutoSize = true;
			this.optNonAutoDbg.Location = new System.Drawing.Point(36, 121);
			this.optNonAutoDbg.Name = "optNonAutoDbg";
			this.optNonAutoDbg.Size = new System.Drawing.Size(193, 18);
			this.optNonAutoDbg.TabIndex = 1;
			this.optNonAutoDbg.Text = "Do not enable \'OneClick\' debugging";
			this.optNonAutoDbg.UseVisualStyleBackColor = true;
			// 
			// cmdPrevious
			// 
			this.cmdPrevious.Enabled = false;
			this.cmdPrevious.Location = new System.Drawing.Point(260, 314);
			this.cmdPrevious.Name = "cmdPrevious";
			this.cmdPrevious.Size = new System.Drawing.Size(75, 23);
			this.cmdPrevious.TabIndex = 7;
			this.cmdPrevious.Text = "◄ &Previous";
			this.cmdPrevious.UseVisualStyleBackColor = true;
			this.cmdPrevious.Click += new System.EventHandler(this.cmdPrevious_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Location = new System.Drawing.Point(440, 314);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(75, 23);
			this.cmdCancel.TabIndex = 6;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdNext
			// 
			this.cmdNext.Location = new System.Drawing.Point(341, 314);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(75, 23);
			this.cmdNext.TabIndex = 5;
			this.cmdNext.Text = "&Next ►";
			this.cmdNext.UseVisualStyleBackColor = true;
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// pnlStep2
			// 
			this.pnlStep2.Controls.Add(this.txtDebugParams);
			this.pnlStep2.Controls.Add(this.txtDebugPort);
			this.pnlStep2.Controls.Add(this.cmdBrowseEngine);
			this.pnlStep2.Controls.Add(this.txtDebugPasswd);
			this.pnlStep2.Controls.Add(this.txtDebugExe);
			this.pnlStep2.Controls.Add(this.label8);
			this.pnlStep2.Controls.Add(this.label7);
			this.pnlStep2.Controls.Add(this.label6);
			this.pnlStep2.Controls.Add(this.label5);
			this.pnlStep2.Controls.Add(label4);
			this.pnlStep2.Location = new System.Drawing.Point(12, 81);
			this.pnlStep2.Name = "pnlStep2";
			this.pnlStep2.Size = new System.Drawing.Size(503, 226);
			this.pnlStep2.TabIndex = 8;
			this.pnlStep2.Visible = false;
			this.pnlStep2.VisibleChanged += new System.EventHandler(this.pnlStep2_VisibleChanged);
			// 
			// label4
			// 
			label4.Location = new System.Drawing.Point(0, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(503, 57);
			label4.TabIndex = 0;
			label4.Text = resources.GetString("label4.Text");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 14);
			this.label5.TabIndex = 1;
			this.label5.Text = "Game Engine Executable:";
			// 
			// txtDebugExe
			// 
			this.txtDebugExe.Location = new System.Drawing.Point(166, 58);
			this.txtDebugExe.Name = "txtDebugExe";
			this.txtDebugExe.Size = new System.Drawing.Size(238, 20);
			this.txtDebugExe.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 14);
			this.label6.TabIndex = 1;
			this.label6.Text = "Debug Password:";
			// 
			// txtDebugPasswd
			// 
			this.txtDebugPasswd.Location = new System.Drawing.Point(166, 87);
			this.txtDebugPasswd.MaxLength = 32;
			this.txtDebugPasswd.Name = "txtDebugPasswd";
			this.txtDebugPasswd.Size = new System.Drawing.Size(157, 20);
			this.txtDebugPasswd.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 14);
			this.label7.TabIndex = 1;
			this.label7.Text = "Debug Port:";
			// 
			// cmdBrowseEngine
			// 
			this.cmdBrowseEngine.Location = new System.Drawing.Point(417, 57);
			this.cmdBrowseEngine.Name = "cmdBrowseEngine";
			this.cmdBrowseEngine.Size = new System.Drawing.Size(75, 23);
			this.cmdBrowseEngine.TabIndex = 3;
			this.cmdBrowseEngine.Text = "Browse";
			this.cmdBrowseEngine.UseVisualStyleBackColor = true;
			this.cmdBrowseEngine.Click += new System.EventHandler(this.cmdBrowseEngine_Click);
			// 
			// txtDebugPort
			// 
			this.txtDebugPort.Location = new System.Drawing.Point(166, 119);
			this.txtDebugPort.Mask = "00000";
			this.txtDebugPort.Name = "txtDebugPort";
			this.txtDebugPort.PromptChar = ' ';
			this.txtDebugPort.Size = new System.Drawing.Size(48, 20);
			this.txtDebugPort.TabIndex = 4;
			this.txtDebugPort.Text = "8777";
			this.txtDebugPort.ValidatingType = typeof(int);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(31, 151);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(99, 14);
			this.label8.TabIndex = 1;
			this.label8.Text = "Debug Parameters:";
			// 
			// txtDebugParams
			// 
			this.txtDebugParams.Location = new System.Drawing.Point(166, 148);
			this.txtDebugParams.Name = "txtDebugParams";
			this.txtDebugParams.Size = new System.Drawing.Size(326, 20);
			this.txtDebugParams.TabIndex = 5;
			// 
			// frmDebugWizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 343);
			this.Controls.Add(this.pnlStep1);
			this.Controls.Add(this.pnlStep2);
			this.Controls.Add(this.cmdPrevious);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.pnlTop);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDebugWizard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Debug Wizard";
			this.Load += new System.EventHandler(this.frmDebugWizard_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlStep1.ResumeLayout(false);
			this.pnlStep1.PerformLayout();
			this.pnlStep2.ResumeLayout(false);
			this.pnlStep2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlStep1;
		private System.Windows.Forms.Label lblMainCs;
		private System.Windows.Forms.RadioButton optAutoDbg;
		private System.Windows.Forms.Button cmdBrowseMainCs;
		private System.Windows.Forms.TextBox txtMainCS;
		private System.Windows.Forms.RadioButton optNonAutoDbg;
		private System.Windows.Forms.Button cmdPrevious;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Panel pnlStep2;
		private System.Windows.Forms.TextBox txtDebugExe;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmdBrowseEngine;
		private System.Windows.Forms.TextBox txtDebugPasswd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox txtDebugPort;
		private System.Windows.Forms.TextBox txtDebugParams;
		private System.Windows.Forms.Label label8;
	}
}