namespace mRemoteNG.UI.TaskDialog
{
  partial class frmTaskDialog
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
      if (disposing)
      {
        if(components != null)
            components.Dispose();
        if(_mainInstructionFont != null)
            _mainInstructionFont.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskDialog));
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bt1 = new mRemoteNG.UI.Controls.Base.NGButton();
            this.bt2 = new mRemoteNG.UI.Controls.Base.NGButton();
            this.bt3 = new mRemoteNG.UI.Controls.Base.NGButton();
            this.cbVerify = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.lbShowHideDetails = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbFooter = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.imgFooter = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCommandButtons = new System.Windows.Forms.Panel();
            this.pnlMainInstruction = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lbContent = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.pnlExpandedInfo = new System.Windows.Forms.Panel();
            this.lbExpandedInfo = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFooter)).BeginInit();
            this.pnlMainInstruction.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlExpandedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(8, 8);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(32, 32);
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.bt1);
            this.pnlButtons.Controls.Add(this.bt2);
            this.pnlButtons.Controls.Add(this.bt3);
            this.pnlButtons.Controls.Add(this.cbVerify);
            this.pnlButtons.Controls.Add(this.lbShowHideDetails);
            this.pnlButtons.Controls.Add(this.panel2);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 301);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(464, 58);
            this.pnlButtons.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1._mice = mRemoteNG.UI.Controls.Base.NGButton.MouseState.HOVER;
            this.bt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt1.Location = new System.Drawing.Point(218, 8);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "bt1";
            // 
            // bt2
            // 
            this.bt2._mice = mRemoteNG.UI.Controls.Base.NGButton.MouseState.HOVER;
            this.bt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt2.Location = new System.Drawing.Point(299, 8);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "bt2";
            // 
            // bt3
            // 
            this.bt3._mice = mRemoteNG.UI.Controls.Base.NGButton.MouseState.HOVER;
            this.bt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt3.Location = new System.Drawing.Point(380, 8);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "bt3";
            // 
            // cbVerify
            // 
            this.cbVerify._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.cbVerify.AutoSize = true;
            this.cbVerify.Location = new System.Drawing.Point(13, 34);
            this.cbVerify.Name = "cbVerify";
            this.cbVerify.Size = new System.Drawing.Size(147, 17);
            this.cbVerify.TabIndex = 4;
            this.cbVerify.Text = "Don\'t ask me this again";
            this.cbVerify.Visible = false;
            // 
            // lbShowHideDetails
            // 
            this.lbShowHideDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbShowHideDetails.ImageIndex = 3;
            this.lbShowHideDetails.ImageList = this.imageList1;
            this.lbShowHideDetails.Location = new System.Drawing.Point(8, 6);
            this.lbShowHideDetails.Name = "lbShowHideDetails";
            this.lbShowHideDetails.Size = new System.Drawing.Size(94, 23);
            this.lbShowHideDetails.TabIndex = 3;
            this.lbShowHideDetails.Text = "        Show details";
            this.lbShowHideDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbShowHideDetails.Click += new System.EventHandler(this.lbDetails_Click);
            this.lbShowHideDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDetails_MouseDown);
            this.lbShowHideDetails.MouseEnter += new System.EventHandler(this.lbDetails_MouseEnter);
            this.lbShowHideDetails.MouseLeave += new System.EventHandler(this.lbDetails_MouseLeave);
            this.lbShowHideDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbDetails_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow_up_bw.bmp");
            this.imageList1.Images.SetKeyName(1, "arrow_up_color.bmp");
            this.imageList1.Images.SetKeyName(2, "arrow_up_color_pressed.bmp");
            this.imageList1.Images.SetKeyName(3, "arrow_down_bw.bmp");
            this.imageList1.Images.SetKeyName(4, "arrow_down_color.bmp");
            this.imageList1.Images.SetKeyName(5, "arrow_down_color_pressed.bmp");
            this.imageList1.Images.SetKeyName(6, "green_arrow.bmp");
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 1);
            this.panel2.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lbFooter);
            this.pnlFooter.Controls.Add(this.imgFooter);
            this.pnlFooter.Controls.Add(this.panel5);
            this.pnlFooter.Controls.Add(this.panel3);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooter.Location = new System.Drawing.Point(0, 359);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(464, 36);
            this.pnlFooter.TabIndex = 2;
            // 
            // lbFooter
            // 
            this.lbFooter.Location = new System.Drawing.Point(30, 11);
            this.lbFooter.Name = "lbFooter";
            this.lbFooter.Size = new System.Drawing.Size(409, 15);
            this.lbFooter.TabIndex = 4;
            this.lbFooter.Text = "lbFooter";
            // 
            // imgFooter
            // 
            this.imgFooter.Location = new System.Drawing.Point(8, 10);
            this.imgFooter.Name = "imgFooter";
            this.imgFooter.Size = new System.Drawing.Size(16, 16);
            this.imgFooter.TabIndex = 4;
            this.imgFooter.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 1);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 1);
            this.panel3.TabIndex = 1;
            // 
            // pnlCommandButtons
            // 
            this.pnlCommandButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommandButtons.Location = new System.Drawing.Point(0, 202);
            this.pnlCommandButtons.Name = "pnlCommandButtons";
            this.pnlCommandButtons.Size = new System.Drawing.Size(464, 99);
            this.pnlCommandButtons.TabIndex = 4;
            // 
            // pnlMainInstruction
            // 
            this.pnlMainInstruction.Controls.Add(this.imgMain);
            this.pnlMainInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainInstruction.Location = new System.Drawing.Point(0, 0);
            this.pnlMainInstruction.Name = "pnlMainInstruction";
            this.pnlMainInstruction.Size = new System.Drawing.Size(464, 41);
            this.pnlMainInstruction.TabIndex = 1;
            this.pnlMainInstruction.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainInstruction_Paint);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lbContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 41);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(464, 30);
            this.pnlContent.TabIndex = 2;
            // 
            // lbContent
            // 
            this.lbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContent.Location = new System.Drawing.Point(50, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(409, 19);
            this.lbContent.TabIndex = 0;
            this.lbContent.Text = "lbContent";
            // 
            // pnlExpandedInfo
            // 
            this.pnlExpandedInfo.Controls.Add(this.lbExpandedInfo);
            this.pnlExpandedInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpandedInfo.Location = new System.Drawing.Point(0, 71);
            this.pnlExpandedInfo.Name = "pnlExpandedInfo";
            this.pnlExpandedInfo.Size = new System.Drawing.Size(464, 30);
            this.pnlExpandedInfo.TabIndex = 10;
            // 
            // lbExpandedInfo
            // 
            this.lbExpandedInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExpandedInfo.Location = new System.Drawing.Point(50, 0);
            this.lbExpandedInfo.Name = "lbExpandedInfo";
            this.lbExpandedInfo.Size = new System.Drawing.Size(409, 19);
            this.lbExpandedInfo.TabIndex = 0;
            this.lbExpandedInfo.Text = "lbExpandedInfo";
            // 
            // pnlRadioButtons
            // 
            this.pnlRadioButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRadioButtons.Location = new System.Drawing.Point(0, 101);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(464, 101);
            this.pnlRadioButtons.TabIndex = 3;
            // 
            // frmTaskDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 593);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlCommandButtons);
            this.Controls.Add(this.pnlRadioButtons);
            this.Controls.Add(this.pnlExpandedInfo);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMainInstruction);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaskDialog";
            this.Shown += new System.EventHandler(this.frmTaskDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFooter)).EndInit();
            this.pnlMainInstruction.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlExpandedInfo.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgMain;
    private Controls.Base.NGLabel lbContent;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.PictureBox imgFooter;
    private Controls.Base.NGLabel lbFooter;
    private System.Windows.Forms.ImageList imageList1;
    private Controls.Base.NGLabel lbShowHideDetails;
    private System.Windows.Forms.Panel pnlCommandButtons;
    private Controls.Base.NGCheckBox cbVerify;
    private System.Windows.Forms.Panel pnlMainInstruction;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.Panel pnlExpandedInfo;
    private Controls.Base.NGLabel lbExpandedInfo;
    private System.Windows.Forms.Panel pnlRadioButtons;
    private Controls.Base.NGButton bt1;
    private Controls.Base.NGButton bt2;
    private Controls.Base.NGButton bt3;
  }
}