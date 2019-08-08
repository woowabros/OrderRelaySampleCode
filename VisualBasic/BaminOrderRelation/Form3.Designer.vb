<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tbETA = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.gbDeliveryStatus = New System.Windows.Forms.GroupBox()
        Me.rbDeliveryCompleted = New System.Windows.Forms.RadioButton()
        Me.rbPickupCompleted = New System.Windows.Forms.RadioButton()
        Me.rbRiderAssigned = New System.Windows.Forms.RadioButton()
        Me.tbRiderName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbRiderCode = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.gbDeliveryStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(31, 382)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(581, 41)
        Me.btnOk.TabIndex = 32
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'tbETA
        '
        Me.tbETA.Location = New System.Drawing.Point(162, 174)
        Me.tbETA.Name = "tbETA"
        Me.tbETA.Size = New System.Drawing.Size(450, 28)
        Me.tbETA.TabIndex = 31
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 177)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(59, 18)
        Me.label4.TabIndex = 30
        Me.label4.Text = "E.T.A."
        '
        'gbDeliveryStatus
        '
        Me.gbDeliveryStatus.Controls.Add(Me.rbDeliveryCompleted)
        Me.gbDeliveryStatus.Controls.Add(Me.rbPickupCompleted)
        Me.gbDeliveryStatus.Controls.Add(Me.rbRiderAssigned)
        Me.gbDeliveryStatus.Location = New System.Drawing.Point(31, 235)
        Me.gbDeliveryStatus.Name = "gbDeliveryStatus"
        Me.gbDeliveryStatus.Size = New System.Drawing.Size(581, 125)
        Me.gbDeliveryStatus.TabIndex = 29
        Me.gbDeliveryStatus.TabStop = False
        Me.gbDeliveryStatus.Text = "배송상태"
        '
        'rbDeliveryCompleted
        '
        Me.rbDeliveryCompleted.AutoSize = True
        Me.rbDeliveryCompleted.Location = New System.Drawing.Point(19, 83)
        Me.rbDeliveryCompleted.Name = "rbDeliveryCompleted"
        Me.rbDeliveryCompleted.Size = New System.Drawing.Size(267, 22)
        Me.rbDeliveryCompleted.TabIndex = 2
        Me.rbDeliveryCompleted.Text = "고객님께 배달 완료했습니다."
        Me.rbDeliveryCompleted.UseVisualStyleBackColor = True
        '
        'rbPickupCompleted
        '
        Me.rbPickupCompleted.AutoSize = True
        Me.rbPickupCompleted.Location = New System.Drawing.Point(19, 55)
        Me.rbPickupCompleted.Name = "rbPickupCompleted"
        Me.rbPickupCompleted.Size = New System.Drawing.Size(225, 22)
        Me.rbPickupCompleted.TabIndex = 1
        Me.rbPickupCompleted.Text = "배달이 시작되었습니다."
        Me.rbPickupCompleted.UseVisualStyleBackColor = True
        '
        'rbRiderAssigned
        '
        Me.rbRiderAssigned.AutoSize = True
        Me.rbRiderAssigned.Checked = True
        Me.rbRiderAssigned.Location = New System.Drawing.Point(19, 27)
        Me.rbRiderAssigned.Name = "rbRiderAssigned"
        Me.rbRiderAssigned.Size = New System.Drawing.Size(243, 22)
        Me.rbRiderAssigned.TabIndex = 0
        Me.rbRiderAssigned.TabStop = True
        Me.rbRiderAssigned.Text = "라이더가 배정되었습니다."
        Me.rbRiderAssigned.UseVisualStyleBackColor = True
        '
        'tbRiderName
        '
        Me.tbRiderName.Location = New System.Drawing.Point(162, 122)
        Me.tbRiderName.Name = "tbRiderName"
        Me.tbRiderName.Size = New System.Drawing.Size(450, 28)
        Me.tbRiderName.TabIndex = 28
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(28, 125)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(101, 18)
        Me.label3.TabIndex = 27
        Me.label3.Text = "Rider Name"
        '
        'tbRiderCode
        '
        Me.tbRiderCode.Location = New System.Drawing.Point(162, 73)
        Me.tbRiderCode.Name = "tbRiderCode"
        Me.tbRiderCode.Size = New System.Drawing.Size(450, 28)
        Me.tbRiderCode.TabIndex = 26
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 76)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 18)
        Me.label2.TabIndex = 25
        Me.label2.Text = "Rider Code"
        '
        'tbOrderNo
        '
        Me.tbOrderNo.Location = New System.Drawing.Point(162, 26)
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(450, 28)
        Me.tbOrderNo.TabIndex = 24
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 18)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Order No"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 440)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.tbETA)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.gbDeliveryStatus)
        Me.Controls.Add(Me.tbRiderName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbRiderCode)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbOrderNo)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.gbDeliveryStatus.ResumeLayout(False)
        Me.gbDeliveryStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnOk As Button
    Public WithEvents tbETA As TextBox
    Private WithEvents label4 As Label
    Private WithEvents gbDeliveryStatus As GroupBox
    Public WithEvents rbDeliveryCompleted As RadioButton
    Public WithEvents rbPickupCompleted As RadioButton
    Public WithEvents rbRiderAssigned As RadioButton
    Public WithEvents tbRiderName As TextBox
    Private WithEvents label3 As Label
    Public WithEvents tbRiderCode As TextBox
    Private WithEvents label2 As Label
    Public WithEvents tbOrderNo As TextBox
    Private WithEvents label1 As Label
End Class
