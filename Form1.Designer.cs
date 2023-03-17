
namespace RoundPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rpb1 = new RoundPictureBox.RPB();
            ((System.ComponentModel.ISupportInitialize)(this.rpb1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpb1
            // 
            this.rpb1.Image = ((System.Drawing.Image)(resources.GetObject("rpb1.Image")));
            this.rpb1.Location = new System.Drawing.Point(120, 53);
            this.rpb1.Name = "rpb1";
            this.rpb1.Size = new System.Drawing.Size(200, 262);
            this.rpb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpb1.TabIndex = 0;
            this.rpb1.TabStop = false;
            this.rpb1.Click += new System.EventHandler(this.rpb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 379);
            this.Controls.Add(this.rpb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rpb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RPB rpb1;
    }
}

