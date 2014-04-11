namespace MontyHallProblem
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
      this.nudIts = new System.Windows.Forms.NumericUpDown();
      this.btnGo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblStick = new System.Windows.Forms.Label();
      this.lblSwap = new System.Windows.Forms.Label();
      this.bgwDo = new System.ComponentModel.BackgroundWorker();
      this.lblStickPerc = new System.Windows.Forms.Label();
      this.lblSwapPerc = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nudIts)).BeginInit();
      this.SuspendLayout();
      // 
      // nudIts
      // 
      this.nudIts.Location = new System.Drawing.Point(13, 13);
      this.nudIts.Name = "nudIts";
      this.nudIts.Size = new System.Drawing.Size(75, 20);
      this.nudIts.TabIndex = 0;
      this.nudIts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudIts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(13, 40);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 1;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(94, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "x 1000";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Swap";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(121, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Stick";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(241, 75);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Total";
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Location = new System.Drawing.Point(241, 99);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(0, 13);
      this.lblTotal.TabIndex = 8;
      // 
      // lblStick
      // 
      this.lblStick.AutoSize = true;
      this.lblStick.Location = new System.Drawing.Point(121, 99);
      this.lblStick.Name = "lblStick";
      this.lblStick.Size = new System.Drawing.Size(0, 13);
      this.lblStick.TabIndex = 7;
      // 
      // lblSwap
      // 
      this.lblSwap.AutoSize = true;
      this.lblSwap.Location = new System.Drawing.Point(12, 99);
      this.lblSwap.Name = "lblSwap";
      this.lblSwap.Size = new System.Drawing.Size(0, 13);
      this.lblSwap.TabIndex = 6;
      // 
      // bgwDo
      // 
      this.bgwDo.WorkerReportsProgress = true;
      this.bgwDo.WorkerSupportsCancellation = true;
      this.bgwDo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDo_DoWork);
      this.bgwDo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDo_ProgressChanged);
      this.bgwDo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDo_RunWorkerCompleted);
      // 
      // lblStickPerc
      // 
      this.lblStickPerc.AutoSize = true;
      this.lblStickPerc.Location = new System.Drawing.Point(121, 127);
      this.lblStickPerc.Name = "lblStickPerc";
      this.lblStickPerc.Size = new System.Drawing.Size(0, 13);
      this.lblStickPerc.TabIndex = 10;
      // 
      // lblSwapPerc
      // 
      this.lblSwapPerc.AutoSize = true;
      this.lblSwapPerc.Location = new System.Drawing.Point(12, 127);
      this.lblSwapPerc.Name = "lblSwapPerc";
      this.lblSwapPerc.Size = new System.Drawing.Size(0, 13);
      this.lblSwapPerc.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 175);
      this.Controls.Add(this.lblStickPerc);
      this.Controls.Add(this.lblSwapPerc);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.lblStick);
      this.Controls.Add(this.lblSwap);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.nudIts);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.nudIts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nudIts;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblStick;
    private System.Windows.Forms.Label lblSwap;
    private System.ComponentModel.BackgroundWorker bgwDo;
    private System.Windows.Forms.Label lblStickPerc;
    private System.Windows.Forms.Label lblSwapPerc;
  }
}

