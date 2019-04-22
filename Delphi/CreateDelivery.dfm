object FrmCreateDelivery: TFrmCreateDelivery
  Left = 0
  Top = 0
  Caption = 'Create Delivery'
  ClientHeight = 414
  ClientWidth = 370
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poOwnerFormCenter
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
    Width = 55
    Height = 13
    Caption = 'Road Name'
  end
  object Label3: TLabel
    Left = 16
    Top = 81
    Width = 39
    Height = 13
    Caption = 'Address'
  end
  object Label4: TLabel
    Left = 16
    Top = 108
    Width = 69
    Height = 13
    Caption = 'Address Detail'
  end
  object Label5: TLabel
    Left = 16
    Top = 135
    Width = 46
    Height = 13
    Caption = 'Phone No'
  end
  object Label6: TLabel
    Left = 16
    Top = 162
    Width = 39
    Height = 13
    Caption = 'Latitude'
  end
  object Label7: TLabel
    Left = 16
    Top = 189
    Width = 47
    Height = 13
    Caption = 'Longitude'
  end
  object Label8: TLabel
    Left = 16
    Top = 216
    Width = 20
    Height = 13
    Caption = 'Title'
  end
  object Label9: TLabel
    Left = 16
    Top = 243
    Width = 64
    Height = 13
    Caption = 'Total Amount'
  end
  object Label10: TLabel
    Left = 16
    Top = 270
    Width = 56
    Height = 13
    Caption = 'Total Count'
  end
  object edOrderNo: TEdit
    Left = 104
    Top = 24
    Width = 250
    Height = 21
    Enabled = False
    TabOrder = 0
  end
  object edRoadNameAddress: TEdit
    Left = 104
    Top = 51
    Width = 250
    Height = 21
    TabOrder = 1
  end
  object edAddress: TEdit
    Left = 104
    Top = 78
    Width = 250
    Height = 21
    TabOrder = 2
  end
  object edAddressDetail: TEdit
    Left = 104
    Top = 105
    Width = 250
    Height = 21
    TabOrder = 3
  end
  object edPhoneNo: TEdit
    Left = 104
    Top = 132
    Width = 250
    Height = 21
    TabOrder = 4
  end
  object edLatitude: TEdit
    Left = 104
    Top = 159
    Width = 250
    Height = 21
    TabOrder = 5
  end
  object edLongitude: TEdit
    Left = 104
    Top = 186
    Width = 250
    Height = 21
    TabOrder = 6
  end
  object BitBtn1: TBitBtn
    Left = 104
    Top = 380
    Width = 129
    Height = 25
    Kind = bkOK
    NumGlyphs = 2
    TabOrder = 7
  end
  object edTitle: TEdit
    Left = 104
    Top = 213
    Width = 250
    Height = 21
    TabOrder = 8
  end
  object edAmount: TEdit
    Left = 104
    Top = 240
    Width = 250
    Height = 21
    Alignment = taRightJustify
    Enabled = False
    TabOrder = 9
  end
  object edQuantity: TEdit
    Left = 104
    Top = 267
    Width = 250
    Height = 21
    Alignment = taRightJustify
    Enabled = False
    TabOrder = 10
  end
  object rgPaymentType: TRadioGroup
    Left = 16
    Top = 294
    Width = 338
    Height = 59
    Caption = 'Payment Type'
    Columns = 3
    Items.Strings = (
      #48148#47196#44208#51228
      #47564#45208#49436' '#52852#46300
      #47564#45208#49436' '#54788#44552)
    TabOrder = 11
  end
end
