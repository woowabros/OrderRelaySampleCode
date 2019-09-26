Imports System.Runtime.InteropServices
Imports System.Text

Public Class FrmBaminOrderRelationMain

    Const S_OK As Integer = 0
    Const PT_PREPAYED As Integer = 0
    Const PT_MEET_CARD As Integer = 1
    Const PT_MEET_CASH As Integer = 2
    Const OS_NEW As Integer = 0
    Const OS_RECEIPT As Integer = 1
    Const OS_COMPLETED As Integer = 2
    Const OS_CANCELED As Integer = 3

    Const DS_RIDER_ASSIGNED As Integer = 0
    Const DS_PICKUP_COMPLETED As Integer = 1
    Const DS_DELIVERY_COMPLETED As Integer = 2

    Public Delegate Function TOnNewDeliveryFunc(
<MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal ARoadNameAddress As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal AAddress As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal AAddressDetail As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal APhoneNo As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal ALatitude As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal ALongitude As String,
<MarshalAs(UnmanagedType.LPWStr)> ByVal ATitle As String, ByVal AQuantity As Integer, ByVal AAmount As Integer, ByVal APaymentType As Integer,
<MarshalAs(UnmanagedType.LPWStr)> ByVal AMemo As String) As Boolean
    Public Delegate Sub TOnStatusChangedProc(
<MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String, ByVal AOrderStatus As Integer)
    Public Delegate Sub TOnDisconnectedProc()

    Public OnNewDeliveryProc As TOnNewDeliveryFunc
    Public OnStatusChangedProc As TOnStatusChangedProc
    Public OnDisconnectedProc As TOnDisconnectedProc



    <DllImport("BMOrderRelay.dll", EntryPoint:="InitializeService", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function InitializeService32(<MarshalAs(UnmanagedType.LPWStr)> ByVal ASignKey As String) As Integer

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="FinalizeService", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function FinalizeService32() As Integer

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="RegisterNewDeliveryFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterNewDeliveryFunction32(ByVal AEvent As TOnNewDeliveryFunc) As Boolean

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="RegisterStatusChangedFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterStatusChangedFunction32(ByVal AEvent As TOnStatusChangedProc) As Boolean

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="RegisterDisconnectedFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterDisconnectedFunction32(ByVal AEvent As TOnDisconnectedProc) As Boolean

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="SetDeliveryCompleted", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function SetDeliveryCompleted32(<MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String) As Boolean

    End Function
    <DllImport("BMOrderRelay.dll", EntryPoint:="UpdateDeliveryStatus", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function UpdateDeliveryStatus32(
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String,
                                                 ByVal ADeliveryStatus As Integer,
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal ARiderKey As String,
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal ARiderName As String,
                                                 ByVal ETA As Integer) As Boolean

    End Function

    <DllImport("BMOrderRelayx64.dll", EntryPoint:="InitializeService", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function InitializeService64(<MarshalAs(UnmanagedType.LPWStr)> ByVal ASignKey As String) As Integer

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="FinalizeService", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function FinalizeService64() As Integer

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="RegisterNewDeliveryFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterNewDeliveryFunction64(ByVal AEvent As TOnNewDeliveryFunc) As Boolean

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="RegisterStatusChangedFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterStatusChangedFunction64(ByVal AEvent As TOnStatusChangedProc) As Boolean

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="RegisterDisconnectedFunction", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function RegisterDisconnectedFunction64(ByVal AEvent As TOnDisconnectedProc) As Boolean

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="SetDeliveryCompleted", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function SetDeliveryCompleted64(<MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String) As Boolean

    End Function
    <DllImport("BMOrderRelayx64.dll", EntryPoint:="UpdateDeliveryStatus", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode)>
    Public Shared Function UpdateDeliveryStatus64(
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String,
                                                 ByVal ADeliveryStatus As Integer,
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal ARiderKey As String,
                                                 <MarshalAs(UnmanagedType.LPWStr)> ByVal ARiderName As String,
                                                 ByVal ETA As Integer) As Boolean

    End Function


    Public Shared Function InitializeService(ByVal ASignKey As String) As Integer
        If (Environment.Is64BitOperatingSystem = True) Then
            Return InitializeService64(ASignKey)
        Else
            Return InitializeService32(ASignKey)
        End If
    End Function

    Public Shared Function FinalizeService() As Integer
        If (Environment.Is64BitOperatingSystem = True) Then
            Return FinalizeService64()
        Else
            Return FinalizeService32()
        End If
    End Function

    Public Shared Function RegisterNewDeliveryFunction(ByVal AEvent As TOnNewDeliveryFunc) As Boolean
        If (Environment.Is64BitOperatingSystem = True) Then
            Return RegisterNewDeliveryFunction64(AEvent)
        Else
            Return RegisterNewDeliveryFunction32(AEvent)
        End If
    End Function

    Public Shared Function RegisterStatusChangedFunction(ByVal AEvent As TOnStatusChangedProc) As Boolean
        If (Environment.Is64BitOperatingSystem = True) Then
            Return RegisterStatusChangedFunction64(AEvent)
        Else
            Return RegisterStatusChangedFunction32(AEvent)
        End If
    End Function

    Public Shared Function RegisterDisconnectedFunction(ByVal AEvent As TOnDisconnectedProc) As Boolean
        If (Environment.Is64BitOperatingSystem = True) Then
            Return RegisterDisconnectedFunction64(AEvent)
        Else
            Return RegisterDisconnectedFunction32(AEvent)
        End If
    End Function

    <Obsolete("SetDeliveryCompleted is deprecated, please use UpdateDeliveryStatus instead.")>
    Public Shared Function SetDeliveryCompleted(ByVal AOrderNo As String) As Boolean
        If (Environment.Is64BitOperatingSystem = True) Then
            Return SetDeliveryCompleted64(AOrderNo)
        Else
            Return SetDeliveryCompleted32(AOrderNo)
        End If
    End Function

    Public Shared Function UpdateDeliveryStatus(ByVal AOrderNo As String, ByVal ADeliveryStatus As Integer, ByVal ARiderKey As String, ByVal ARiderName As String, ByVal ETA As Integer) As Boolean
        If (Environment.Is64BitOperatingSystem = True) Then
            Return UpdateDeliveryStatus64(AOrderNo, ADeliveryStatus, ARiderKey, ARiderName, ETA)
        Else
            Return UpdateDeliveryStatus32(AOrderNo, ADeliveryStatus, ARiderKey, ARiderName, ETA)
        End If
    End Function

    Public Sub New()
        InitializeComponent()
        OnNewDeliveryProc = AddressOf Me.OnNewDelivery
        OnStatusChangedProc = AddressOf Me.OnStatusChanged
        OnDisconnectedProc = AddressOf Me.OnDisconnected
    End Sub

    Public Function OnNewDelivery(
        <MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal ARoadNameAddress As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal AAddress As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal AAddressDetail As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal APhoneNo As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal ALatitude As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal ALongitude As String,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal ATitle As String, ByVal AQuantity As Integer, ByVal AAmount As Integer, ByVal APaymentType As Integer,
        <MarshalAs(UnmanagedType.LPWStr)> ByVal AMemo As String) As Boolean
        Return Invoke(New MethodInvoker(Function() As Boolean
                                            RichTextBox1.AppendText("[New Delivery]" & Environment.NewLine)
                                            RichTextBox1.AppendText("AOrderNo: " & AOrderNo & Environment.NewLine)
                                            RichTextBox1.AppendText("ARoadNameAddress: " & ARoadNameAddress & Environment.NewLine)
                                            RichTextBox1.AppendText("AAddress: " & AAddress & Environment.NewLine)
                                            RichTextBox1.AppendText("AAddressDetail: " & AAddressDetail & Environment.NewLine)
                                            RichTextBox1.AppendText("APhoneNo: " & APhoneNo & Environment.NewLine)
                                            RichTextBox1.AppendText("ALatitude: " & ALatitude & Environment.NewLine)
                                            RichTextBox1.AppendText("ALongitude: " & ALongitude & Environment.NewLine)
                                            RichTextBox1.AppendText("ATitle: " & ATitle & Environment.NewLine)
                                            RichTextBox1.AppendText("AQuantity: " & AQuantity & Environment.NewLine)
                                            RichTextBox1.AppendText("AAmount: " & AAmount & Environment.NewLine)
                                            RichTextBox1.AppendText("AAmount: " & AAmount & Environment.NewLine)
                                            RichTextBox1.AppendText("AMemo: " & AMemo & Environment.NewLine)

                                            Select Case APaymentType
                                                Case PT_PREPAYED
                                                    RichTextBox1.AppendText("PaymentType: 바로결제" & Environment.NewLine)
                                                Case PT_MEET_CARD
                                                    RichTextBox1.AppendText("PaymentType: 만나서 결제 카드" & Environment.NewLine)
                                                Case PT_MEET_CASH
                                                    RichTextBox1.AppendText("PaymentType: 만나서 결제 현금" & Environment.NewLine)
                                                Case Else
                                                    Console.WriteLine("Default case")
                                            End Select

                                            Dim addDelivery As Form2 = New Form2()
                                            addDelivery.tbOrderNo.Text = AOrderNo
                                            addDelivery.tbRoadName.Text = ARoadNameAddress
                                            addDelivery.tbAddress.Text = AAddress
                                            addDelivery.tbAddressDetail.Text = AAddressDetail
                                            addDelivery.tbPhoneNo.Text = APhoneNo
                                            addDelivery.tbLatitude.Text = ALatitude
                                            addDelivery.tbLongitude.Text = ALongitude
                                            addDelivery.tbTitle.Text = ATitle
                                            addDelivery.tbTotalAmount.Text = AAmount.ToString()
                                            addDelivery.tbTotalCount.Text = AQuantity.ToString()

                                            Select Case APaymentType
                                                Case PT_PREPAYED
                                                    addDelivery.rbPrepaid.Checked = True
                                                Case PT_MEET_CARD
                                                    addDelivery.rbMeetCard.Checked = True
                                                Case PT_MEET_CASH
                                                    addDelivery.rbMeetCash.Checked = True
                                                Case Else
                                                    Console.WriteLine("Default case")
                                            End Select

                                            Dim Res As DialogResult = addDelivery.ShowDialog(Me)

                                            If Res = DialogResult.OK Then
                                                Dim item As ListViewItem = New ListViewItem(AOrderNo)
                                                item.SubItems.Add(ARoadNameAddress & " " & AAddressDetail)
                                                item.SubItems.Add("바로결제")
                                                If addDelivery.rbPrepaid.Checked Then
                                                    item.SubItems.Add("'만나서 결제 카드")
                                                ElseIf addDelivery.rbMeetCard.Checked Then
                                                    item.SubItems.Add("만나서 결제 현금")
                                                End If
                                                ListView1.Items.Add(item)
                                            End If
                                            RichTextBox1.AppendText(AOrderNo.ToString + " " + ARoadNameAddress.ToString + AAddress.ToString + " " + AAddressDetail.ToString + vbCrLf)
                                            Return True
                                        End Function))

    End Function

    Public Sub OnStatusChanged(<MarshalAs(UnmanagedType.LPWStr)> ByVal AOrderNo As String, ByVal AOrderStatus As Integer)
        Invoke(New MethodInvoker(Sub()
                                     RichTextBox1.AppendText("StatusChanged: " & AOrderNo & " " & AOrderStatus & Environment.NewLine)

                                     For i As Integer = ListView1.Items.Count - 1 To 0

                                         If AOrderNo.Equals(ListView1.Items(i).Text) Then
                                             ListView1.Items.RemoveAt(i)
                                             Exit For
                                         End If
                                     Next
                                 End Sub))

    End Sub

    Public Sub OnDisconnected()
        Invoke(New MethodInvoker(Sub()
                                     RichTextBox1.AppendText("Disconnected!!!" & Environment.NewLine)
                                 End Sub))
    End Sub

    Private Sub BtnRegisterCallback_Click(sender As Object, e As EventArgs) Handles BtnRegisterCallback.Click
        If Not RegisterNewDeliveryFunction(OnNewDeliveryProc) Then MessageBox.Show("Error RegisterNewDeliveryFunction!")
        If Not RegisterStatusChangedFunction(OnStatusChangedProc) Then MessageBox.Show("Error RegisterStatusChangedFunction!")
        If Not RegisterDisconnectedFunction(OnDisconnectedProc) Then MessageBox.Show("Error RegisterDisconnectedFunction")
        RichTextBox1.AppendText("Register Callback Functions" & Environment.NewLine)
    End Sub

    Private Sub BtnInitializeService_Click(sender As Object, e As EventArgs) Handles BtnInitializeService.Click
        If InitializeService("hJTk2rWrfc6C1UEmk9Uvc2MGpUuOpEw3q8i1/4+EUcFObqlNhzCvVHFM") <> S_OK Then
            MessageBox.Show("InitializeService Failed")
        End If

        RichTextBox1.AppendText("Initialize Service" & Environment.NewLine)
    End Sub

    Private Sub BtnFinalizeService_Click(sender As Object, e As EventArgs) Handles BtnFinalizeService.Click
        If FinalizeService() <> S_OK Then
            MessageBox.Show("FinalizeService Failed")
        End If

        RichTextBox1.AppendText("Finalize Service" & Environment.NewLine)
    End Sub

    Private Sub btnUpdateDeliveryStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateDeliveryStatus.Click
        If ListView1.SelectedIndices.Count <= 0 Then
            Return
        End If

        Dim intselectedindex As Integer = ListView1.SelectedIndices(0)

        If intselectedindex >= 0 Then
            Dim text As String = ListView1.Items(intselectedindex).Text

            Dim changeRiderStatus As Form3 = New Form3()

            changeRiderStatus.tbOrderNo.Text = text

            Dim Res As DialogResult = changeRiderStatus.ShowDialog(Me)
            If Res = DialogResult.OK Then

                Dim DeliveryStatus As Integer = DS_RIDER_ASSIGNED
                If (changeRiderStatus.rbRiderAssigned.Checked = True) Then
                    DeliveryStatus = DS_RIDER_ASSIGNED
                ElseIf (changeRiderStatus.rbPickupCompleted.Checked = True) Then
                    DeliveryStatus = DS_PICKUP_COMPLETED
                ElseIf (changeRiderStatus.rbDeliveryCompleted.Checked = True) Then
                    DeliveryStatus = DS_DELIVERY_COMPLETED
                End If

                UpdateDeliveryStatus(changeRiderStatus.tbOrderNo.Text, DeliveryStatus, changeRiderStatus.tbRiderCode.Text, changeRiderStatus.tbRiderName.Text, Convert.ToInt32(changeRiderStatus.tbETA.Text))
            End If
        End If
    End Sub
End Class
