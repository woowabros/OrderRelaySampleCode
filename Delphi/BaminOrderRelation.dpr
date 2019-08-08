program BaminOrderRelation;

uses
  Vcl.Forms,
  BaminOrderRelationMain in 'BaminOrderRelationMain.pas' {FrmBaminOrderRelationMain},
  CreateDelivery in 'CreateDelivery.pas' {FrmCreateDelivery},
  ChangeDeliveryStatus in 'ChangeDeliveryStatus.pas' {FrmChangeDeliveryStatus};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TFrmBaminOrderRelationMain, FrmBaminOrderRelationMain);
  Application.CreateForm(TFrmCreateDelivery, FrmCreateDelivery);
  Application.CreateForm(TFrmChangeDeliveryStatus, FrmChangeDeliveryStatus);
  Application.Run;
end.
