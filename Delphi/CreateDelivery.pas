unit CreateDelivery;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons, Vcl.ExtCtrls;

type
  TFrmCreateDelivery = class(TForm)
    edOrderNo: TEdit;
    Label1: TLabel;
    edRoadNameAddress: TEdit;
    Label2: TLabel;
    edAddress: TEdit;
    Label3: TLabel;
    edAddressDetail: TEdit;
    Label4: TLabel;
    edPhoneNo: TEdit;
    Label5: TLabel;
    edLatitude: TEdit;
    Label6: TLabel;
    edLongitude: TEdit;
    Label7: TLabel;
    BitBtn1: TBitBtn;
    edTitle: TEdit;
    Label8: TLabel;
    edAmount: TEdit;
    Label9: TLabel;
    edQuantity: TEdit;
    Label10: TLabel;
    rgPaymentType: TRadioGroup;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FrmCreateDelivery: TFrmCreateDelivery;
   {
   AOrderNo, ARoadNameAddress, AAddress, AAddressDetail, APhoneNo: PWideChar;
  Latitude, Longitude: PWideChar; ATitle: PWideChar; AQuantity: Integer; AAmount, APaymentType
   }
implementation

{$R *.dfm}

end.
