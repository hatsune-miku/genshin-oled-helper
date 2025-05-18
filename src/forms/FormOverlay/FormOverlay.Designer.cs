namespace GenshinOledHelper
{
    partial class FormOverlay
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
            this.components = new System.ComponentModel.Container();
            this.labelUid = new System.Windows.Forms.Label();
            this.timerViewSwitcher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelUid
            // 
            this.labelUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUid.ForeColor = System.Drawing.Color.DimGray;
            this.labelUid.Location = new System.Drawing.Point(0, 0);
            this.labelUid.Name = "labelUid";
            this.labelUid.Size = new System.Drawing.Size(799, 180);
            this.labelUid.TabIndex = 0;
            this.labelUid.Text = "UID：178134276";
            this.labelUid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerViewSwitcher
            // 
            this.timerViewSwitcher.Interval = 1000;
            this.timerViewSwitcher.Tick += new System.EventHandler(this.timerViewSwitcher_Tick);
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOverlay";
            this.ShowIcon = false;
            this.Text = "FormOverlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOverlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUid;
        private System.Windows.Forms.Timer timerViewSwitcher;
    }
}