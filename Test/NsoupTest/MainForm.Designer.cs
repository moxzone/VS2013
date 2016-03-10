namespace NsoupTest
{
    partial class MainForm
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
            this.btnGO = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.DGVbook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVbook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(605, 423);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(97, 39);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "button1";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(699, 461);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(11, 12);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "0";
            // 
            // DGVbook
            // 
            this.DGVbook.AllowUserToAddRows = false;
            this.DGVbook.AllowUserToDeleteRows = false;
            this.DGVbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVbook.Location = new System.Drawing.Point(12, 12);
            this.DGVbook.Name = "DGVbook";
            this.DGVbook.ReadOnly = true;
            this.DGVbook.RowTemplate.Height = 23;
            this.DGVbook.Size = new System.Drawing.Size(690, 405);
            this.DGVbook.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 474);
            this.Controls.Add(this.DGVbook);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnGO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView DGVbook;
    }
}

