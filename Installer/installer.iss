; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=Exami
AppVersion=2.3.0                                                  
DefaultDirName={pf}\Exami
DefaultGroupName=Exami
UninstallDisplayIcon={app}\MyProg.exe
Compression=lzma2
SolidCompression=yes
;OutputDir=userdocs:Inno Setup Examples Output
SourceDir=C:\Users\diego\Documents\Programation\Exami\Exami\bin\Release

[Files]
Source: "Exami.exe"; DestDir: "{app}"
Source: "Logo.ico"; DestDir: "{app}"
;Source: "Readme.txt"; DestDir: "{app}"; Flags: isreadme

[Icons]
Name: "{group}\Exami"; Filename: "{app}\Exami.exe"

