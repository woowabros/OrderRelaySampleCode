object FrmBaminOrderRelationMain: TFrmBaminOrderRelationMain
  Left = 0
  Top = 0
  Caption = 'BaminOrderRelation'
  ClientHeight = 675
  ClientWidth = 1012
  Color = clBtnFace
  Font.Charset = ANSI_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = #45208#45588#48148#47480#44256#46357
  Font.Style = []
  OldCreateOrder = False
  DesignSize = (
    1012
    675)
  PixelsPerInch = 96
  TextHeight = 14
  object Memo1: TMemo
    Left = 16
    Top = 510
    Width = 980
    Height = 151
    Anchors = [akLeft, akRight, akBottom]
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -9
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    ScrollBars = ssVertical
    TabOrder = 0
  end
  object btnRegCallback: TButton
    Left = 16
    Top = 25
    Width = 145
    Height = 33
    Caption = '1. Callback '#54632#49688' '#46321#47197
    TabOrder = 1
    OnClick = btnRegCallbackClick
  end
  object btnInitializeService: TButton
    Left = 167
    Top = 25
    Width = 154
    Height = 33
    Caption = '2. '#49436#48708#49828' '#52488#44592#54868
    TabOrder = 2
    OnClick = btnInitializeServiceClick
  end
  object ListView1: TListView
    Left = 16
    Top = 64
    Width = 980
    Height = 440
    Anchors = [akLeft, akTop, akRight, akBottom]
    Columns = <
      item
        Caption = 'Order No'
        Width = 120
      end
      item
        Caption = 'Address'
        Width = 250
      end
      item
        Caption = 'GPS'
        Width = 200
      end
      item
        Caption = 'Status'
        Width = 70
      end>
    DoubleBuffered = True
    FlatScrollBars = True
    RowSelect = True
    ParentDoubleBuffered = False
    TabOrder = 3
    ViewStyle = vsReport
    OnClick = ListView1Click
  end
  object btnSetDeliveryCompleted: TButton
    Left = 860
    Top = 25
    Width = 136
    Height = 33
    Anchors = [akTop, akRight]
    Caption = #48176#45804' '#50756#47308
    TabOrder = 4
    OnClick = btnSetDeliveryCompletedClick
  end
  object btnFinalizeService: TButton
    Left = 327
    Top = 25
    Width = 154
    Height = 33
    Caption = '3. '#49436#48708#49828' '#51333#47308
    TabOrder = 5
    OnClick = btnFinalizeServiceClick
  end
end
