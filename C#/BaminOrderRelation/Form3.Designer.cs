namespace BaminOrderRelation
{
    partial class Form3
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
            this.tbRiderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRiderCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbDeliveryStatus = new System.Windows.Forms.GroupBox();
            this.rbRiderAssigned = new System.Windows.Forms.RadioButton();
            this.rbPickupCompleted = new System.Windows.Forms.RadioButton();
            this.rbDeliveryCompleted = new System.Windows.Forms.RadioButton();
            this.tbETA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gbDeliveryStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRiderName
            // 
            this.tbRiderName.Location = new System.Drawing.Point(159, 123);
            this.tbRiderName.Name = "tbRiderName";
            this.tbRiderName.Size = new System.Drawing.Size(450, 28);
            this.tbRiderName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rider Name";
            // 
            // tbRiderCode
            // 
            this.tbRiderCode.Location = new System.Drawing.Point(159, 74);
            this.tbRiderCode.Name = "tbRiderCode";
            this.tbRiderCode.Size = new System.Drawing.Size(450, 28);
            this.tbRiderCode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rider Code";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(159, 27);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(450, 28);
            this.tbOrderNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order No";
            // 
            // gbDeliveryStatus
            // 
            this.gbDeliveryStatus.Controls.Add(this.rbDeliveryCompleted);
            this.gbDeliveryStatus.Controls.Add(this.rbPickupCompleted);
            this.gbDeliveryStatus.Controls.Add(this.rbRiderAssigned);
            this.gbDeliveryStatus.Location = new System.Drawing.Point(28, 236);
            this.gbDeliveryStatus.Name = "gbDeliveryStatus";
            this.gbDeliveryStatus.Size = new System.Drawing.Size(581, 125);
            this.gbDeliveryStatus.TabIndex = 12;
            this.gbDeliveryStatus.TabStop = false;
            this.gbDeliveryStatus.Text = "배송상태";
            // 
            // rbRiderAssigned
            // 
            this.rbRiderAssigned.AutoSize = true;
            this.rbRiderAssigned.Checked = true;
            this.rbRiderAssigned.Location = new System.Drawing.Point(19, 27);
            this.rbRiderAssigned.Name = "rbRiderAssigned";
            this.rbRiderAssigned.Size = new System.Drawing.Size(243, 22);
            this.rbRiderAssigned.TabIndex = 0;
            this.rbRiderAssigned.TabStop = true;
            this.rbRiderAssigned.Text = "라이더가 배정되었습니다.";
            this.rbRiderAssigned.UseVisualStyleBackColor = true;
            // 
            // rbPickupCompleted
            // 
            this.rbPickupCompleted.AutoSize = true;
            this.rbPickupCompleted.Location = new System.Drawing.Point(19, 55);
            this.rbPickupCompleted.Name = "rbPickupCompleted";
            this.rbPickupCompleted.Size = new System.Drawing.Size(225, 22);
            this.rbPickupCompleted.TabIndex = 1;
            this.rbPickupCompleted.Text = "배달이 시작되었습니다.";
            this.rbPickupCompleted.UseVisualStyleBackColor = true;
            // 
            // rbDeliveryCompleted
            // 
            this.rbDeliveryCompleted.AutoSize = true;
            this.rbDeliveryCompleted.Location = new System.Drawing.Point(19, 83);
            this.rbDeliveryCompleted.Name = "rbDeliveryCompleted";
            this.rbDeliveryCompleted.Size = new System.Drawing.Size(267, 22);
            this.rbDeliveryCompleted.TabIndex = 2;
            this.rbDeliveryCompleted.Text = "고객님께 배달 완료했습니다.";
            this.rbDeliveryCompleted.UseVisualStyleBackColor = true;
            // 
            // tbETA
            // 
            this.tbETA.Location = new System.Drawing.Point(159, 175);
            this.tbETA.Name = "tbETA";
            this.tbETA.Size = new System.Drawing.Size(450, 28);
            this.tbETA.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "E.T.A.";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(28, 383);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(581, 41);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 436);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbETA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbDeliveryStatus);
            this.Controls.Add(this.tbRiderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRiderCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gbDeliveryStatus.ResumeLayout(false);
            this.gbDeliveryStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbRiderName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbRiderCode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox gbDeliveryStatus;
        public System.Windows.Forms.RadioButton rbDeliveryCompleted;
        public System.Windows.Forms.RadioButton rbPickupCompleted;
        public System.Windows.Forms.RadioButton rbRiderAssigned;
        public System.Windows.Forms.TextBox tbETA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
    }
}