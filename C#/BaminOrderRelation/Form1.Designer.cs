namespace BaminOrderRelation
{
    partial class FrmBaminOrderRelationMain
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
            this.btnRegCallback = new System.Windows.Forms.Button();
            this.btnInitializeService = new System.Windows.Forms.Button();
            this.btnFinalizeService = new System.Windows.Forms.Button();
            this.btnSetDeliveryCompleted = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRegCallback
            // 
            this.btnRegCallback.Location = new System.Drawing.Point(12, 12);
            this.btnRegCallback.Name = "btnRegCallback";
            this.btnRegCallback.Size = new System.Drawing.Size(271, 43);
            this.btnRegCallback.TabIndex = 0;
            this.btnRegCallback.Text = "1. Callback 함수 등록";
            this.btnRegCallback.UseVisualStyleBackColor = true;
            this.btnRegCallback.Click += new System.EventHandler(this.btnRegCallback_Click);
            // 
            // btnInitializeService
            // 
            this.btnInitializeService.Location = new System.Drawing.Point(289, 12);
            this.btnInitializeService.Name = "btnInitializeService";
            this.btnInitializeService.Size = new System.Drawing.Size(271, 43);
            this.btnInitializeService.TabIndex = 1;
            this.btnInitializeService.Text = "2. 서비스 초기화";
            this.btnInitializeService.UseVisualStyleBackColor = true;
            this.btnInitializeService.Click += new System.EventHandler(this.btnInitializeService_Click);
            // 
            // btnFinalizeService
            // 
            this.btnFinalizeService.Location = new System.Drawing.Point(566, 12);
            this.btnFinalizeService.Name = "btnFinalizeService";
            this.btnFinalizeService.Size = new System.Drawing.Size(271, 43);
            this.btnFinalizeService.TabIndex = 2;
            this.btnFinalizeService.Text = "3. 서비스 종료";
            this.btnFinalizeService.UseVisualStyleBackColor = true;
            this.btnFinalizeService.Click += new System.EventHandler(this.btnFinalizeService_Click);
            // 
            // btnSetDeliveryCompleted
            // 
            this.btnSetDeliveryCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDeliveryCompleted.Location = new System.Drawing.Point(1567, 12);
            this.btnSetDeliveryCompleted.Name = "btnSetDeliveryCompleted";
            this.btnSetDeliveryCompleted.Size = new System.Drawing.Size(223, 43);
            this.btnSetDeliveryCompleted.TabIndex = 3;
            this.btnSetDeliveryCompleted.Text = "배달 완료";
            this.btnSetDeliveryCompleted.UseVisualStyleBackColor = true;
            this.btnSetDeliveryCompleted.Click += new System.EventHandler(this.btnSetDeliveryCompleted_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 81);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1778, 705);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order No";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GPS";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 200;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 792);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1778, 254);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // FrmBaminOrderRelationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 1058);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSetDeliveryCompleted);
            this.Controls.Add(this.btnFinalizeService);
            this.Controls.Add(this.btnInitializeService);
            this.Controls.Add(this.btnRegCallback);
            this.Name = "FrmBaminOrderRelationMain";
            this.Text = "BaminOrderRelation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegCallback;
        private System.Windows.Forms.Button btnInitializeService;
        private System.Windows.Forms.Button btnFinalizeService;
        private System.Windows.Forms.Button btnSetDeliveryCompleted;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

