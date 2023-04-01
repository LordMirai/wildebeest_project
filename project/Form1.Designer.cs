namespace project
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
            this.bkgr = new System.Windows.Forms.PictureBox();
            this.hint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bkgr)).BeginInit();
            this.SuspendLayout();
            // 
            // bkgr
            // 
            this.bkgr.ErrorImage = null;
            this.bkgr.Image = ((System.Drawing.Image)(resources.GetObject("bkgr.Image")));
            this.bkgr.InitialImage = null;
            this.bkgr.Location = new System.Drawing.Point(0, 12);
            this.bkgr.Name = "bkgr";
            this.bkgr.Size = new System.Drawing.Size(575, 519);
            this.bkgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bkgr.TabIndex = 0;
            this.bkgr.TabStop = false;
            this.bkgr.Click += new System.EventHandler(this.bkgr_Click);
            // 
            // hint
            // 
            this.hint.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.Location = new System.Drawing.Point(12, 646);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(766, 98);
            this.hint.TabIndex = 1;
            this.hint.Text = "Hint:";
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 790);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.bkgr);
            this.Name = "Form1";
            this.Text = "Wildebeest Schach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bkgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label hint;

        public System.Windows.Forms.PictureBox bkgr;

        #endregion
    }
}