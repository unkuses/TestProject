namespace TestSolution
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.dtmMain = new System.Windows.Forms.DateTimePicker();
      this.lbTimestampTest = new System.Windows.Forms.Label();
      this.lbTimestamp = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.MainView = new System.Windows.Forms.DataGridView();
      this.lbError = new System.Windows.Forms.Label();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.dtmMain, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lbTimestampTest, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lbTimestamp, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.MainView, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lbError, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.progressBar, 2, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // dtmMain
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.dtmMain, 2);
      this.dtmMain.Dock = System.Windows.Forms.DockStyle.Top;
      this.dtmMain.Location = new System.Drawing.Point(3, 3);
      this.dtmMain.Name = "dtmMain";
      this.dtmMain.Size = new System.Drawing.Size(172, 20);
      this.dtmMain.TabIndex = 0;
      // 
      // lbTimestampTest
      // 
      this.lbTimestampTest.AutoSize = true;
      this.lbTimestampTest.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbTimestampTest.Location = new System.Drawing.Point(3, 26);
      this.lbTimestampTest.Name = "lbTimestampTest";
      this.lbTimestampTest.Size = new System.Drawing.Size(100, 13);
      this.lbTimestampTest.TabIndex = 1;
      this.lbTimestampTest.Text = "Timestamp:";
      // 
      // lbTimestamp
      // 
      this.lbTimestamp.AutoSize = true;
      this.lbTimestamp.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbTimestamp.Location = new System.Drawing.Point(109, 26);
      this.lbTimestamp.Name = "lbTimestamp";
      this.lbTimestamp.Size = new System.Drawing.Size(66, 13);
      this.lbTimestamp.TabIndex = 2;
      this.lbTimestamp.Text = "lbTimestamp";
      // 
      // btnStart
      // 
      this.btnStart.AutoSize = true;
      this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnStart.Location = new System.Drawing.Point(3, 42);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(100, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      // 
      // MainView
      // 
      this.MainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableLayoutPanel1.SetColumnSpan(this.MainView, 3);
      this.MainView.Dock = System.Windows.Forms.DockStyle.Top;
      this.MainView.Location = new System.Drawing.Point(3, 71);
      this.MainView.Name = "MainView";
      this.MainView.Size = new System.Drawing.Size(794, 150);
      this.MainView.TabIndex = 4;
      // 
      // lbError
      // 
      this.lbError.AutoSize = true;
      this.lbError.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbError.Location = new System.Drawing.Point(109, 46);
      this.lbError.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
      this.lbError.Name = "lbError";
      this.lbError.Size = new System.Drawing.Size(66, 13);
      this.lbError.TabIndex = 5;
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(181, 42);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(100, 23);
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 6;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtmMain;
        private System.Windows.Forms.Label lbTimestampTest;
        private System.Windows.Forms.Label lbTimestamp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView MainView;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

