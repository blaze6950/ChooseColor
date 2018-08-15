namespace ChooseColorExample
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
            this.chooseColor1 = new ChooseColor.ChooseColor();
            this.SuspendLayout();
            // 
            // chooseColor1
            // 
            this.chooseColor1.BlueChannel = 0;
            this.chooseColor1.ColorChoosed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseColor1.GreenChannel = 0;
            this.chooseColor1.Location = new System.Drawing.Point(87, 12);
            this.chooseColor1.Name = "chooseColor1";
            this.chooseColor1.RedChannel = 0;
            this.chooseColor1.Size = new System.Drawing.Size(268, 158);
            this.chooseColor1.TabIndex = 0;
            this.chooseColor1.ValueOfColorChanged += new System.EventHandler(this.chooseColor1_ValueOfColorChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 178);
            this.Controls.Add(this.chooseColor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ChooseColor.ChooseColor chooseColor1;
    }
}

