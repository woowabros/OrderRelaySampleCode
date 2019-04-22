<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBaminOrderRelationMain
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRegisterCallback = New System.Windows.Forms.Button()
        Me.BtnInitializeService = New System.Windows.Forms.Button()
        Me.BtnFinalizeService = New System.Windows.Forms.Button()
        Me.BtnSetDeliveryCompleted = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 57)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1887, 763)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Order No"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address"
        Me.ColumnHeader2.Width = 400
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GPS"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 150
        '
        'BtnRegisterCallback
        '
        Me.BtnRegisterCallback.Location = New System.Drawing.Point(12, 12)
        Me.BtnRegisterCallback.Name = "BtnRegisterCallback"
        Me.BtnRegisterCallback.Size = New System.Drawing.Size(262, 39)
        Me.BtnRegisterCallback.TabIndex = 1
        Me.BtnRegisterCallback.Text = "1. Callback 함수 등록"
        Me.BtnRegisterCallback.UseVisualStyleBackColor = True
        '
        'BtnInitializeService
        '
        Me.BtnInitializeService.Location = New System.Drawing.Point(280, 12)
        Me.BtnInitializeService.Name = "BtnInitializeService"
        Me.BtnInitializeService.Size = New System.Drawing.Size(262, 39)
        Me.BtnInitializeService.TabIndex = 2
        Me.BtnInitializeService.Text = "2. 서비스 초기화"
        Me.BtnInitializeService.UseVisualStyleBackColor = True
        '
        'BtnFinalizeService
        '
        Me.BtnFinalizeService.Location = New System.Drawing.Point(580, 12)
        Me.BtnFinalizeService.Name = "BtnFinalizeService"
        Me.BtnFinalizeService.Size = New System.Drawing.Size(307, 39)
        Me.BtnFinalizeService.TabIndex = 3
        Me.BtnFinalizeService.Text = "3. 서비스 종료"
        Me.BtnFinalizeService.UseVisualStyleBackColor = True
        '
        'BtnSetDeliveryCompleted
        '
        Me.BtnSetDeliveryCompleted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSetDeliveryCompleted.Location = New System.Drawing.Point(1637, 12)
        Me.BtnSetDeliveryCompleted.Name = "BtnSetDeliveryCompleted"
        Me.BtnSetDeliveryCompleted.Size = New System.Drawing.Size(262, 39)
        Me.BtnSetDeliveryCompleted.TabIndex = 4
        Me.BtnSetDeliveryCompleted.Text = "배달 완료"
        Me.BtnSetDeliveryCompleted.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 826)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1887, 183)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'FrmBaminOrderRelationMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1911, 1021)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnSetDeliveryCompleted)
        Me.Controls.Add(Me.BtnFinalizeService)
        Me.Controls.Add(Me.BtnInitializeService)
        Me.Controls.Add(Me.BtnRegisterCallback)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FrmBaminOrderRelationMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BtnRegisterCallback As Button
    Friend WithEvents BtnInitializeService As Button
    Friend WithEvents BtnFinalizeService As Button
    Friend WithEvents BtnSetDeliveryCompleted As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
