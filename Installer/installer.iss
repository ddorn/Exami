; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=Exami
AppVersion=2.4.0                                          
DefaultDirName={pf}\Exami
DefaultGroupName=Exami
UninstallDisplayIcon={app}\MyProg.exe
Compression=lzma2
SolidCompression=yes
OutputDir=C:\Users\diego\Documents\Programation\Exami\Installer\bin
SourceDir=C:\Users\diego\Documents\Programation\Exami\Exami\bin\Release

[Files]
Source: "Exami.exe"; DestDir: "{app}"
Source: "Logo.ico"; DestDir: "{app}"
Source: "UninstallLogo.ico"; DestDir: "{app}"

[Icons]
Name: "{group}\Exami\Exami"; Filename: "{app}\Exami.exe"; IconFilename: "{app}\Logo.ico" 
Name: "{group}\Exami\Uninstall"; Filename: "{uninstallexe}"; IconFilename: "{app}\UninstallLogo.ico"
Name: "{commondesktop}\Exami"; Filename: "{app}\Exami.exe"; IconFilename: "{app}\Logo.ico"

[Run]
Filename: {app}\Exami.exe; Description: Run Application; Flags: postinstall nowait skipifsilent

