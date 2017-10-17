!include "MUI2.nsh"

Name "Last.fm2Wallpaper"
OutFile "Last.fm2Wallpaper1.0.0.exe"

InstallDir "$APPDATA\Last.fm2Wallpaper"

InstallDirRegKey HKCU "Software\Lastfm2Wallpaper" "Install_Dir"

!define UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\Lastfm2Wallpaper"

RequestExecutionLevel admin

!define MUI_HEADERIMAGE
	!define MUI_HEADERIMAGE_BITMAP "header.bmp"
	!define MUI_HEADERIMAGE_BITMAP_STRETCH NoStretchNoCrop
	!define MUI_HEADERIMAGE_RIGHT
!define MUI_FINISHPAGE_RUN "$INSTDIR\Last.fm2Wallpaper.exe"
!define MUI_WELCOMEFINISHPAGE_BITMAP "wizard.bmp"
!define MUI_UNWELCOMEFINISHPAGE_BITMAP "wizard.bmp"
!define MUI_ICON "install.ico"
;!define MUI_BGCOLOR "6DEEFF"
!define MUI_ABORTWARNING

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "License.txt"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

!insertmacro MUI_LANGUAGE "English" 

Section
	SetOutPath $INSTDIR
	
	File Newtonsoft.Json.dll
	File Last.fm2Wallpaper.exe
	CreateDirectory $INSTDIR\icons
	File /oname=icons\VisualElements_70.png icons\VisualElements_70.png
	File /oname=icons\VisualElements_150.png icons\VisualElements_150.png
	File Last.fm2Wallpaper.visualelementsmanifest.xml
	
	WriteRegStr HKLM SOFTWARE\Lastfm2Wallpaper "Install_Dir" "$INSTDIR"

	WriteRegStr HKLM "${UNINST_KEY}" "DisplayName" "Last.FM2Wallpapr"
	WriteRegStr HKLM "${UNINST_KEY}" "DisplayVersion" "1.0.0"
	WriteRegStr HKLM "${UNINST_KEY}" "Publisher" "Ari Hanan"
	WriteRegStr HKLM "${UNINST_KEY}" "DisplayIcon" "$\"$INSTDIR\Last.fm2Wallpaper.exe$\""
	WriteRegStr HKLM "${UNINST_KEY}" "InstallLocation" "$\"$INSTDIR$\""
	WriteRegStr HKLM "${UNINST_KEY}" "URLInfoAbout" '"https://github.com/AriHanan/Last.fm2Wallpaper"'
	WriteRegStr HKLM "${UNINST_KEY}" "EstimatedSize" 11857
	WriteRegStr HKLM "${UNINST_KEY}" "Comments" '"Display album art and song info as your wallpaper using last.fm data."'
	WriteRegStr HKLM "${UNINST_KEY}" "UninstallString" "$\"$INSTDIR\uninstall.exe$\""
	WriteRegDWORD HKLM "${UNINST_KEY}" "NoModify" 1
	WriteRegDWORD HKLM "${UNINST_KEY}" "NoRepair" 1
	
	WriteUninstaller $INSTDIR\uninstall.exe
	
	CreateShortCut "$SMPROGRAMS\Last.fm2Wallpaper.lnk" "$INSTDIR\Last.fm2Wallpaper.exe" "" "$INSTDIR\Last.fm2Wallpaper.exe" 0
	CreateShortCut "$DESKTOP\Last.fm2Wallpaper.lnk" "$INSTDIR\Last.fm2Wallpaper.exe" "" "$INSTDIR\Last.fm2Wallpaper.exe" 0
	CreateShortCut "$SMSTARTUP\Last.fm2Wallpaper.lnk" "$INSTDIR\Last.fm2Wallpaper.exe" "" "$INSTDIR\Last.fm2Wallpaper.exe" 0
SectionEnd
	
Section "Uninstall"
	DeleteRegKey HKLM "${UNINST_KEY}"
	DeleteRegKey HKLM SOFTWARE\Lastfm2Wallpaper
	
	/*
	Delete $INSTDIR\uninstaller.exe
	
	Delete $INSTDIR\Newtonsoft.Json.dll
	Delete $INSTDIR\Last.fm2Wallpaper.exe
	Delete $INSTDIR\Last.fm2Wallpaper.visualelementsmanifest.xml
	RMDir /r $INSTDIR\icons
	RMDir /r $INSTDIR\temp
	Delete $INSTDIR\savefile
	Delete $INSTDIR\key_save
	*/
	
	RMDir /r /REBOOTOK $INSTDIR
	
	Delete /REBOOTOK $SMPROGRAMS\Last.fm2Wallpaper.lnk
	Delete /REBOOTOK $DESKTOP\Last.fm2Wallpaper.lnk
	Delete /REBOOTOK $SMSTARTUP\Last.fm2Wallpaper.lnk
SectionEnd

Function .onInit
	InitPluginsDir
	File /oname=$PLUGINSDIR\splash.bmp "splash.bmp"
	advsplash::show 3000 600 400 0XFFFFFF $PLUGINSDIR\splash

	Pop $0

	Delete $PLUGINSDIR\splash.bmp
FunctionEnd