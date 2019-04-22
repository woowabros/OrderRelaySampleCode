<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMeetCash = New System.Windows.Forms.RadioButton()
        Me.rbMeetCard = New System.Windows.Forms.RadioButton()
        Me.rbPrepaid = New System.Windows.Forms.RadioButton()
        Me.tbTotalCount = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tbLongitude = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbLatitude = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tbPhoneNo = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbAddressDetail = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbRoadName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(31, 649)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(581, 41)
        Me.btnOk.TabIndex = 43
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbMeetCash)
        Me.groupBox1.Controls.Add(Me.rbMeetCard)
        Me.groupBox1.Controls.Add(Me.rbPrepaid)
        Me.groupBox1.Location = New System.Drawing.Point(31, 522)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(581, 106)
        Me.groupBox1.TabIndex = 42
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Payment Type"
        '
        'rbMeetCash
        '
        Me.rbMeetCash.AutoSize = True
        Me.rbMeetCash.Location = New System.Drawing.Point(388, 49)
        Me.rbMeetCash.Name = "rbMeetCash"
        Me.rbMeetCash.Size = New System.Drawing.Size(165, 22)
        Me.rbMeetCash.TabIndex = 2
        Me.rbMeetCash.Text = "만나서결제 현금"
        Me.rbMeetCash.UseVisualStyleBackColor = True
        '
        'rbMeetCard
        '
        Me.rbMeetCard.AutoSize = True
        Me.rbMeetCard.Location = New System.Drawing.Point(194, 49)
        Me.rbMeetCard.Name = "rbMeetCard"
        Me.rbMeetCard.Size = New System.Drawing.Size(165, 22)
        Me.rbMeetCard.TabIndex = 1
        Me.rbMeetCard.Text = "만나서결제 카드"
        Me.rbMeetCard.UseVisualStyleBackColor = True
        '
        'rbPrepaid
        '
        Me.rbPrepaid.AutoSize = True
        Me.rbPrepaid.Checked = True
        Me.rbPrepaid.Location = New System.Drawing.Point(29, 49)
        Me.rbPrepaid.Name = "rbPrepaid"
        Me.rbPrepaid.Size = New System.Drawing.Size(105, 22)
        Me.rbPrepaid.TabIndex = 0
        Me.rbPrepaid.TabStop = True
        Me.rbPrepaid.Text = "바로결제"
        Me.rbPrepaid.UseVisualStyleBackColor = True
        '
        'tbTotalCount
        '
        Me.tbTotalCount.Location = New System.Drawing.Point(162, 470)
        Me.tbTotalCount.Name = "tbTotalCount"
        Me.tbTotalCount.Size = New System.Drawing.Size(450, 28)
        Me.tbTotalCount.TabIndex = 41
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(28, 473)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(101, 18)
        Me.label10.TabIndex = 40
        Me.label10.Text = "Total Count"
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Location = New System.Drawing.Point(162, 419)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.Size = New System.Drawing.Size(450, 28)
        Me.tbTotalAmount.TabIndex = 39
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(28, 422)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(116, 18)
        Me.label9.TabIndex = 38
        Me.label9.Text = "Total Amount"
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(162, 369)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(450, 28)
        Me.tbTitle.TabIndex = 37
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(28, 372)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(39, 18)
        Me.label8.TabIndex = 36
        Me.label8.Text = "Title"
        '
        'tbLongitude
        '
        Me.tbLongitude.Location = New System.Drawing.Point(162, 323)
        Me.tbLongitude.Name = "tbLongitude"
        Me.tbLongitude.Size = New System.Drawing.Size(450, 28)
        Me.tbLongitude.TabIndex = 35
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(28, 326)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(86, 18)
        Me.label7.TabIndex = 34
        Me.label7.Text = "Longitude"
        '
        'tbLatitude
        '
        Me.tbLatitude.Location = New System.Drawing.Point(162, 275)
        Me.tbLatitude.Name = "tbLatitude"
        Me.tbLatitude.Size = New System.Drawing.Size(450, 28)
        Me.tbLatitude.TabIndex = 33
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(28, 278)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(70, 18)
        Me.label6.TabIndex = 32
        Me.label6.Text = "Latitude"
        '
        'tbPhoneNo
        '
        Me.tbPhoneNo.Location = New System.Drawing.Point(162, 222)
        Me.tbPhoneNo.Name = "tbPhoneNo"
        Me.tbPhoneNo.Size = New System.Drawing.Size(450, 28)
        Me.tbPhoneNo.TabIndex = 31
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(28, 225)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 18)
        Me.label5.TabIndex = 30
        Me.label5.Text = "Phone No"
        '
        'tbAddressDetail
        '
        Me.tbAddressDetail.Location = New System.Drawing.Point(162, 174)
        Me.tbAddressDetail.Name = "tbAddressDetail"
        Me.tbAddressDetail.Size = New System.Drawing.Size(450, 28)
        Me.tbAddressDetail.TabIndex = 29
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(28, 177)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(124, 18)
        Me.label4.TabIndex = 28
        Me.label4.Text = "Address Detail"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(162, 124)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(450, 28)
        Me.tbAddress.TabIndex = 27
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(28, 127)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 18)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Address"
        '
        'tbRoadName
        '
        Me.tbRoadName.Location = New System.Drawing.Point(162, 75)
        Me.tbRoadName.Name = "tbRoadName"
        Me.tbRoadName.Size = New System.Drawing.Size(450, 28)
        Me.tbRoadName.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 78)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 18)
        Me.label2.TabIndex = 24
        Me.label2.Text = "Road Name"
        '
        'tbOrderNo
        '
        Me.tbOrderNo.Location = New System.Drawing.Point(162, 28)
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(450, 28)
        Me.tbOrderNo.TabIndex = 23
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(28, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 18)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Order No"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 724)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.tbTotalCount)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.tbTotalAmount)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.tbLongitude)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.tbLatitude)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.tbPhoneNo)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tbAddressDetail)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbRoadName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbOrderNo)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnOk As Button
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents rbMeetCash As RadioButton
    Public WithEvents rbMeetCard As RadioButton
    Public WithEvents rbPrepaid As RadioButton
    Public WithEvents tbTotalCount As TextBox
    Private WithEvents label10 As Label
    Public WithEvents tbTotalAmount As TextBox
    Private WithEvents label9 As Label
    Public WithEvents tbTitle As TextBox
    Private WithEvents label8 As Label
    Public WithEvents tbLongitude As TextBox
    Private WithEvents label7 As Label
    Public WithEvents tbLatitude As TextBox
    Private WithEvents label6 As Label
    Public WithEvents tbPhoneNo As TextBox
    Private WithEvents label5 As Label
    Public WithEvents tbAddressDetail As TextBox
    Private WithEvents label4 As Label
    Public WithEvents tbAddress As TextBox
    Private WithEvents label3 As Label
    Public WithEvents tbRoadName As TextBox
    Private WithEvents label2 As Label
    Public WithEvents tbOrderNo As TextBox
    Private WithEvents label1 As Label
End Class
