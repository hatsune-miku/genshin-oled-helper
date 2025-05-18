namespace GenshinOledHelper
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartOverlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxScreenWidthScale = new System.Windows.Forms.TextBox();
            this.textBoxScreenHeightScale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartOverlay
            // 
            this.buttonStartOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartOverlay.Location = new System.Drawing.Point(356, 257);
            this.buttonStartOverlay.Name = "buttonStartOverlay";
            this.buttonStartOverlay.Size = new System.Drawing.Size(136, 45);
            this.buttonStartOverlay.TabIndex = 0;
            this.buttonStartOverlay.Text = "开始(&S)";
            this.buttonStartOverlay.UseVisualStyleBackColor = true;
            this.buttonStartOverlay.Click += new System.EventHandler(this.buttonStartOverlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "UID 区域内容";
            // 
            // textBoxUid
            // 
            this.textBoxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUid.Location = new System.Drawing.Point(282, 75);
            this.textBoxUid.Name = "textBoxUid";
            this.textBoxUid.Size = new System.Drawing.Size(210, 35);
            this.textBoxUid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "屏幕宽度 / 3840px = ";
            // 
            // textBoxScreenWidthScale
            // 
            this.textBoxScreenWidthScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScreenWidthScale.Location = new System.Drawing.Point(282, 136);
            this.textBoxScreenWidthScale.Name = "textBoxScreenWidthScale";
            this.textBoxScreenWidthScale.Size = new System.Drawing.Size(210, 35);
            this.textBoxScreenWidthScale.TabIndex = 4;
            this.textBoxScreenWidthScale.Text = "1";
            // 
            // textBoxScreenHeightScale
            // 
            this.textBoxScreenHeightScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScreenHeightScale.Location = new System.Drawing.Point(282, 177);
            this.textBoxScreenHeightScale.Name = "textBoxScreenHeightScale";
            this.textBoxScreenHeightScale.Size = new System.Drawing.Size(210, 35);
            this.textBoxScreenHeightScale.TabIndex = 7;
            this.textBoxScreenHeightScale.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "屏幕宽度 / 2160px = ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 344);
            this.Controls.Add(this.textBoxScreenHeightScale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxScreenWidthScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartOverlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenshinOLEDHelper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartOverlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxScreenWidthScale;
        private System.Windows.Forms.TextBox textBoxScreenHeightScale;
        private System.Windows.Forms.Label label5;
    }
}

