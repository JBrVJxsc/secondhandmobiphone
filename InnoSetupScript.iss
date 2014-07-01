; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "�ֻ����׹���ϵͳ"
#define MyAppVersion "1.0"
#define MyAppPublisher "ͨ���п���������"
#define MyAppURL "http://www.keerqin.gov.cn/weibanju/keqgongan/"
#define MyAppExeName "MobilePhoneLoader.exe"
#define IsExternal ""
#define FrameworkFileName "dotNetFx40_Full_x86_x64.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
AppId={{C287F022-D62D-4E5B-8C0F-CCDE57DE7F73}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes
Uninstallable=noDefaultDirName={pf}\�ֻ����׹���ϵͳ


[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Windows\Fonts\msyh.ttf"; DestDir: "{fonts}"; FontInstall: "΢���ź�"; Flags: onlyifdoesntexist uninsneveruninstall     
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\MobilePhoneLoader.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\MobilePhone.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\MobilePhoneLibrary.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\LumiSoft.Net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.XtraWizard.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.XtraNavBar.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.XtraLayout.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.XtraEditors.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.XtraBars.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.Utils.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.Printing.v12.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.Data.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\DevExpress.BonusSkins.v12.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\lib\Db.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\WorkSpace\SecondHandMobilePhone\FrameWorkInstallPrepare.bat"; DestDir: "{tmp}"; Flags: ignoreversion {#IsExternal}; Check: NF
Source: "E:\Software\Coding\{#FrameworkFileName}"; DestDir: "{tmp}"; Flags: ignoreversion {#IsExternal}; Check: NF
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Run]
Filename: {tmp}\FrameWorkInstallPrepare.bat; WorkingDir: {tmp}; Flags: skipifdoesntexist; StatusMsg: "����׼����װ..."
Filename: {tmp}\{#FrameworkFileName}; Parameters: "/q:a /c:""install /l /q /norestart /ChainingPackage FullX64Bootstrapper"""; WorkingDir: {tmp}; Flags: skipifdoesntexist; StatusMsg: "���ڰ�װ.Net FrameWork����ͨ����ҪһЩʱ�䣬�����ĵȴ�..."
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -remgroup ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "��������..."
Filename: {win}\Microsoft.NET\Framework\v4.0.30319\CasPol.exe; Parameters: "-q -machine -addgroup 1.2 -url ""file://{app}/*"" FullTrust -name ""{#MyAppName}"""; WorkingDir: {tmp}; Flags: skipifdoesntexist runhidden; StatusMsg: "��������..."       
Filename: {app}\MobilePhoneLoader.exe; Description: "�����ֻ����׹���ϵͳ"; Flags: postinstall

[Tasks]
; ע��: ����������Զ����ɵ������ַ� "�������ϴ���ͼ��" �� "���ͼ��" ���������Ҫ�Ļ�������Խ��䷭��Ϊ����һ�����ԡ�                           
Name: "desktopicon"; Description: "�������ϴ���ͼ��(&D)"; GroupDescription: "���ͼ�꣺"         

[Icons] 
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\MobilePhoneLoader.exe"; Tasks:desktopicon ; WorkingDir: "{app}" 

[Code]

//����Ƿ���Ҫ��װ.Net Framework������True��False��
function NF(): boolean;
var
  success: boolean;
  install: cardinal;
begin
  success := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Install', install);
  Result := (success and (install = 1) = false);
end;

//�Թ���ӭ���档
function ShouldSkipPage(PageID: Integer): Boolean;  
begin  
  if PageID=wpWelcome then  
    Result := true;  
  if PageID=wpSelectProgramGroup then
    Result := true;
end;