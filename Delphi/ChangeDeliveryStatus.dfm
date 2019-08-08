object FrmChangeDeliveryStatus: TFrmChangeDeliveryStatus
  Left = 0
  Top = 0
  Caption = #48176#49569#49345#53468' '#48320#44221
  ClientHeight = 310
  ClientWidth = 371
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 27
    Width = 44
    Height = 13
    Caption = 'Order No'
  end
  object Label2: TLabel
    Left = 16
    Top = 54
    Width = 53
    Height = 13
    Caption = 'Rider Code'
  end
  object Label3: TLabel
    Left = 16
    Top = 81
    Width = 55
    Height = 13
    Caption = 'Rider Name'
  end
  object Label4: TLabel
    Left = 16
    Top = 108
    Width = 31
    Height = 13
    Caption = 'E.T.A.'
  end
  object edOrderNo: TEdit
    Left = 104
    Top = 24
    Width = 250
    Height = 21
    Enabled = False
    TabOrder = 0
  end
  object edRiderCode: TEdit
    Left = 104
    Top = 51
    Width = 250
    Height = 21
    TabOrder = 1
  end
  object edRiderName: TEdit
    Left = 104
    Top = 78
    Width = 250
    Height = 21
    TabOrder = 2
  end
  object seETA: TSpinEdit
    Left = 104
    Top = 105
    Width = 250
    Height = 22
    MaxValue = 0
    MinValue = 0
    TabOrder = 3
    Value = 0
  end
  object rgDeliveryStatus: TRadioGroup
    Left = 16
    Top = 144
    Width = 338
    Height = 113
    Caption = #48176#49569#49345#53468
    ItemIndex = 0
    Items.Strings = (
      #46972#51060#45908#44032' '#48176#51221#46104#50632#49845#45768#45796'.'
      #48176#45804#51060' '#49884#51089#46104#50632#49845#45768#45796'.'
      #44256#44061#45784#44760' '#48176#45804' '#50756#47308#54664#49845#45768#45796'.')
    TabOrder = 4
  end
  object BitBtn1: TBitBtn
    Left = 121
    Top = 276
    Width = 129
    Height = 25
    Kind = bkOK
    NumGlyphs = 2
    TabOrder = 5
  end
end
