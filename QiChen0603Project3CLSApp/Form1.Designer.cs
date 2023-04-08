namespace QiChen0603Project3CLSApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSouece = new System.Windows.Forms.TabPage();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSource = new System.Windows.Forms.TextBox();
            this.textProcessedFile = new System.Windows.Forms.TextBox();
            this.optGenerateLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDest = new System.Windows.Forms.TextBox();
            this.lstEvents = new System.Windows.Forms.ListView();
            this.groupEventLog = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSouece.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupEventLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSouece);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(35, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSouece
            // 
            this.tabSouece.Controls.Add(this.optGenerateLog);
            this.tabSouece.Controls.Add(this.textProcessedFile);
            this.tabSouece.Controls.Add(this.textSource);
            this.tabSouece.Controls.Add(this.label2);
            this.tabSouece.Controls.Add(this.label1);
            this.tabSouece.ImageIndex = 0;
            this.tabSouece.Location = new System.Drawing.Point(8, 39);
            this.tabSouece.Name = "tabSouece";
            this.tabSouece.Padding = new System.Windows.Forms.Padding(3);
            this.tabSouece.Size = new System.Drawing.Size(521, 234);
            this.tabSouece.TabIndex = 0;
            this.tabSouece.Text = "Source Options";
            this.tabSouece.UseVisualStyleBackColor = true;
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.textDest);
            this.tabDest.Controls.Add(this.label3);
            this.tabDest.Controls.Add(this.groupEventLog);
            this.tabDest.ImageIndex = 1;
            this.tabDest.Location = new System.Drawing.Point(8, 39);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(521, 234);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "Destination Options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lADPJwY7XkGnpJfMpMyU_148_164.jpg");
            this.imageList1.Images.SetKeyName(1, "lADPJxuMVh5OpXDMjsyQ_144_142.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Processing,mobe source file to:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textSource
            // 
            this.textSource.Location = new System.Drawing.Point(233, 16);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(208, 35);
            this.textSource.TabIndex = 2;
            this.textSource.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textProcessedFile
            // 
            this.textProcessedFile.Location = new System.Drawing.Point(10, 107);
            this.textProcessedFile.Name = "textProcessedFile";
            this.textProcessedFile.Size = new System.Drawing.Size(465, 35);
            this.textProcessedFile.TabIndex = 3;
            // 
            // optGenerateLog
            // 
            this.optGenerateLog.AutoSize = true;
            this.optGenerateLog.Location = new System.Drawing.Point(10, 170);
            this.optGenerateLog.Name = "optGenerateLog";
            this.optGenerateLog.Size = new System.Drawing.Size(498, 28);
            this.optGenerateLog.TabIndex = 4;
            this.optGenerateLog.Text = "Generate evebt log for bad file format";
            this.optGenerateLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Directory";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textDest
            // 
            this.textDest.Location = new System.Drawing.Point(283, 0);
            this.textDest.Name = "textDest";
            this.textDest.Size = new System.Drawing.Size(213, 35);
            this.textDest.TabIndex = 1;
            // 
            // lstEvents
            // 
            this.lstEvents.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstEvents.HideSelection = false;
            this.lstEvents.Location = new System.Drawing.Point(16, 19);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(432, 141);
            this.lstEvents.TabIndex = 2;
            this.lstEvents.UseCompatibleStateImageBehavior = false;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvent_SelectedIndexChanged);
            // 
            // groupEventLog
            // 
            this.groupEventLog.Controls.Add(this.lstEvents);
            this.groupEventLog.Location = new System.Drawing.Point(6, 30);
            this.groupEventLog.Name = "groupEventLog";
            this.groupEventLog.Size = new System.Drawing.Size(504, 166);
            this.groupEventLog.TabIndex = 3;
            this.groupEventLog.TabStop = false;
            this.groupEventLog.Text = "Event Log";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(40, 196);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(172, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refrsh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(261, 196);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(171, 32);
            this.btnViewSummary.TabIndex = 4;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Refresh Log";
            this.tabControl1.ResumeLayout(false);
            this.tabSouece.ResumeLayout(false);
            this.tabSouece.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupEventLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSouece;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProcessedFile;
        private System.Windows.Forms.CheckBox optGenerateLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstEvents;
        private System.Windows.Forms.TextBox textDest;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupEventLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

