unit ChangeDeliveryStatus;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls,
  Vcl.Samples.Spin, Vcl.Buttons;

type
  TFrmChangeDeliveryStatus = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    edOrderNo: TEdit;
    edRiderCode: TEdit;
    edRiderName: TEdit;
    Label4: TLabel;
    seETA: TSpinEdit;
    rgDeliveryStatus: TRadioGroup;
    BitBtn1: TBitBtn;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FrmChangeDeliveryStatus: TFrmChangeDeliveryStatus;

implementation

{$R *.dfm}

end.
