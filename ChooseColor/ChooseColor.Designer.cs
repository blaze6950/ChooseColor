namespace ChooseColor
{
    partial class ChooseColor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPB = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(3, 3);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(104, 45);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.TickFrequency = 16;
            this.redTrackBar.ValueChanged += new System.EventHandler(this.redTrackBar_ValueChanged);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(3, 54);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(104, 45);
            this.greenTrackBar.TabIndex = 1;
            this.greenTrackBar.TickFrequency = 16;
            this.greenTrackBar.ValueChanged += new System.EventHandler(this.greenTrackBar_ValueChanged);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(3, 105);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(104, 45);
            this.blueTrackBar.TabIndex = 2;
            this.blueTrackBar.TickFrequency = 16;
            this.blueTrackBar.ValueChanged += new System.EventHandler(this.blueTrackBar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.colorPB);
            this.panel1.Controls.Add(this.redTrackBar);
            this.panel1.Controls.Add(this.blueTrackBar);
            this.panel1.Controls.Add(this.greenTrackBar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 152);
            this.panel1.TabIndex = 3;
            // 
            // colorPB
            // 
            this.colorPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPB.Location = new System.Drawing.Point(113, 3);
            this.colorPB.Name = "colorPB";
            this.colorPB.Size = new System.Drawing.Size(144, 144);
            this.colorPB.TabIndex = 3;
            this.colorPB.TabStop = false;
            this.colorPB.Click += new System.EventHandler(this.colorPB_MouseHover);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 2000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // ChooseColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ChooseColor";
            this.Size = new System.Drawing.Size(268, 158);
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox colorPB;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
