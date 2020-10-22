namespace HwpPrintManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axHwpCtrl1 = new AxHWPCONTROLLib.AxHwpCtrl();
            this.pathList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSortPrev = new System.Windows.Forms.Button();
            this.buttonSortNext = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axHwpCtrl1
            // 
            this.axHwpCtrl1.Enabled = true;
            this.axHwpCtrl1.Location = new System.Drawing.Point(338, 12);
            this.axHwpCtrl1.Name = "axHwpCtrl1";
            this.axHwpCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axHwpCtrl1.OcxState")));
            this.axHwpCtrl1.Size = new System.Drawing.Size(62, 17);
            this.axHwpCtrl1.TabIndex = 0;
            // 
            // pathList
            // 
            this.pathList.FormattingEnabled = true;
            this.pathList.HorizontalScrollbar = true;
            this.pathList.ItemHeight = 12;
            this.pathList.Location = new System.Drawing.Point(12, 12);
            this.pathList.Name = "pathList";
            this.pathList.Size = new System.Drawing.Size(544, 232);
            this.pathList.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(94, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(176, 256);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 5;
            this.buttonPrint.Text = "모두 인쇄";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSortPrev
            // 
            this.buttonSortPrev.Location = new System.Drawing.Point(257, 256);
            this.buttonSortPrev.Name = "buttonSortPrev";
            this.buttonSortPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonSortPrev.TabIndex = 6;
            this.buttonSortPrev.Text = "↑";
            this.buttonSortPrev.UseVisualStyleBackColor = true;
            this.buttonSortPrev.Click += new System.EventHandler(this.buttonSortPrev_Click);
            // 
            // buttonSortNext
            // 
            this.buttonSortNext.Location = new System.Drawing.Point(338, 256);
            this.buttonSortNext.Name = "buttonSortNext";
            this.buttonSortNext.Size = new System.Drawing.Size(75, 23);
            this.buttonSortNext.TabIndex = 7;
            this.buttonSortNext.Text = "↓";
            this.buttonSortNext.UseVisualStyleBackColor = true;
            this.buttonSortNext.Click += new System.EventHandler(this.buttonSortNext_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "역순 인쇄";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 289);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSortNext);
            this.Controls.Add(this.buttonSortPrev);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pathList);
            this.Controls.Add(this.axHwpCtrl1);
            this.Name = "Form1";
            this.Text = "한글 인쇄 매니저";
            ((System.ComponentModel.ISupportInitialize)(this.axHwpCtrl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxHWPCONTROLLib.AxHwpCtrl axHwpCtrl1;
        private System.Windows.Forms.ListBox pathList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSortPrev;
        private System.Windows.Forms.Button buttonSortNext;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

