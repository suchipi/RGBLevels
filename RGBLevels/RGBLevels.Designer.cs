namespace RGBLevels
{
  partial class RGBBalance
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
      this.trackBarRed = new System.Windows.Forms.TrackBar();
      this.trackBarBlue = new System.Windows.Forms.TrackBar();
      this.trackBarGreen = new System.Windows.Forms.TrackBar();
      this.labelRed = new System.Windows.Forms.Label();
      this.labelGreen = new System.Windows.Forms.Label();
      this.labelBlue = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
      this.SuspendLayout();
      // 
      // trackBarRed
      // 
      this.trackBarRed.LargeChange = 15;
      this.trackBarRed.Location = new System.Drawing.Point(64, 12);
      this.trackBarRed.Maximum = 127;
      this.trackBarRed.Name = "trackBarRed";
      this.trackBarRed.Size = new System.Drawing.Size(260, 45);
      this.trackBarRed.SmallChange = 5;
      this.trackBarRed.TabIndex = 0;
      this.trackBarRed.TickFrequency = 15;
      this.trackBarRed.Value = 127;
      this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
      // 
      // trackBarBlue
      // 
      this.trackBarBlue.LargeChange = 15;
      this.trackBarBlue.Location = new System.Drawing.Point(64, 114);
      this.trackBarBlue.Maximum = 127;
      this.trackBarBlue.Name = "trackBarBlue";
      this.trackBarBlue.Size = new System.Drawing.Size(260, 45);
      this.trackBarBlue.SmallChange = 5;
      this.trackBarBlue.TabIndex = 2;
      this.trackBarBlue.TickFrequency = 15;
      this.trackBarBlue.Value = 127;
      this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
      // 
      // trackBarGreen
      // 
      this.trackBarGreen.LargeChange = 15;
      this.trackBarGreen.Location = new System.Drawing.Point(64, 63);
      this.trackBarGreen.Maximum = 127;
      this.trackBarGreen.Name = "trackBarGreen";
      this.trackBarGreen.Size = new System.Drawing.Size(260, 45);
      this.trackBarGreen.SmallChange = 5;
      this.trackBarGreen.TabIndex = 1;
      this.trackBarGreen.TickFrequency = 15;
      this.trackBarGreen.Value = 127;
      this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
      // 
      // labelRed
      // 
      this.labelRed.AutoSize = true;
      this.labelRed.Location = new System.Drawing.Point(22, 16);
      this.labelRed.Name = "labelRed";
      this.labelRed.Size = new System.Drawing.Size(27, 13);
      this.labelRed.TabIndex = 3;
      this.labelRed.Text = "Red";
      // 
      // labelGreen
      // 
      this.labelGreen.AutoSize = true;
      this.labelGreen.Location = new System.Drawing.Point(17, 67);
      this.labelGreen.Name = "labelGreen";
      this.labelGreen.Size = new System.Drawing.Size(36, 13);
      this.labelGreen.TabIndex = 4;
      this.labelGreen.Text = "Green";
      // 
      // labelBlue
      // 
      this.labelBlue.AutoSize = true;
      this.labelBlue.Location = new System.Drawing.Point(21, 118);
      this.labelBlue.Name = "labelBlue";
      this.labelBlue.Size = new System.Drawing.Size(28, 13);
      this.labelBlue.TabIndex = 5;
      this.labelBlue.Text = "Blue";
      // 
      // RGBBalance
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(336, 162);
      this.Controls.Add(this.labelBlue);
      this.Controls.Add(this.labelGreen);
      this.Controls.Add(this.labelRed);
      this.Controls.Add(this.trackBarGreen);
      this.Controls.Add(this.trackBarBlue);
      this.Controls.Add(this.trackBarRed);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "RGBBalance";
      this.Text = "RGB Levels";
      ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackBarRed;
    private System.Windows.Forms.TrackBar trackBarBlue;
    private System.Windows.Forms.TrackBar trackBarGreen;
    private System.Windows.Forms.Label labelRed;
    private System.Windows.Forms.Label labelGreen;
    private System.Windows.Forms.Label labelBlue;
  }
}

