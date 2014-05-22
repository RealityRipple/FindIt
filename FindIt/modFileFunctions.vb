Imports System.Runtime.InteropServices
Module modFileFunctions
  <DllImport("shell32", CharSet:=CharSet.Auto, setlasterror:=True)>
  Private Function SHGetFileInfo(pszPath As String, dwFileAttributes As UInteger, ByRef psfi As SHFILEINFO, cbFileInfo As Integer, uFlags As UInteger) As IntPtr
  End Function
  <DllImport("shell32", CharSet:=CharSet.Auto, setlasterror:=True)>
  Private Function ShellExecuteEx(ByRef info As ShellExecuteInfo) As Integer
  End Function
  <DllImport("user32", SetLastError:=True, CharSet:=CharSet.Auto)>
  Private Function DestroyIcon(ByVal hWnd As IntPtr) As Boolean
  End Function
  Private Structure SHFILEINFO
    Public hIcon As IntPtr
    Public iIcon As Integer
    Public dwAttributes As UInteger
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)>
    Public szDisplayName As String
    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
    Public szTypeName As String
  End Structure
  Private Enum EShellGetFileInfoConstants
    SHGFI_ICON = &H100
    SHGFI_DISPLAYNAME = &H200
    SHGFI_TYPENAME = &H400
    SHGFI_ATTRIBUTES = &H800
    SHGFI_ICONLOCATION = &H1000
    SHGFI_EXETYPE = &H2000
    SHGFI_SYSICONINDEX = &H4000
    SHGFI_LINKOVERLAY = &H8000
    SHGFI_SELECTED = &H10000
    SHGFI_ATTR_SPECIFIED = &H20000
    SHGFI_LARGEICON = &H0
    SHGFI_SMALLICON = &H1
    SHGFI_OPENICON = &H2
    SHGFI_SHELLICONSIZE = &H4
    SHGFI_PIDL = &H8
    SHGFI_USEFILEATTRIBUTES = &H10
  End Enum
  Public Function GetFileIcon(sPath As String) As Icon
    Dim shInfo As New SHFILEINFO
    Dim hImgSmall As IntPtr = SHGetFileInfo(sPath, 0, shInfo, Marshal.SizeOf(shInfo), EShellGetFileInfoConstants.SHGFI_ICON Or EShellGetFileInfoConstants.SHGFI_SMALLICON)
    Try
      If shInfo.hIcon = 0 Then
        If IO.File.Exists(sPath) Then Return My.Resources.file
        If IO.Directory.Exists(sPath) Then Return My.Resources.folder
        Return My.Resources.Small
      End If
      Dim icoRet As Icon = Icon.FromHandle(shInfo.hIcon).Clone
      DestroyIcon(shInfo.hIcon)
      Return icoRet
    Catch ex As Exception
      If IO.File.Exists(sPath) Then Return My.Resources.file
      If IO.Directory.Exists(sPath) Then Return My.Resources.folder
      Return My.Resources.Small
    End Try
  End Function
Public Structure SHELLEXECUTEINFO
    Public cbSize As Integer
    Public fMask As Integer
    Public hwnd As IntPtr
    <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
    <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
    <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
    <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
    Dim nShow As Integer
    Dim hInstApp As IntPtr
    Dim lpIDList As IntPtr
    <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
    Public hkeyClass As IntPtr
    Public dwHotKey As Integer
    Public hIcon As IntPtr
    Public hProcess As IntPtr
  End Structure
  Private Const SEE_MASK_INVOKEIDLIST As Integer = &HC
  Private Const SEE_MASK_NOCLOSEPROCESS As Integer = &H40
  Private Const SEE_MASK_FLAG_NO_UI As Integer = &H400
  Public Function DisplayProperties(sPath As String) As Boolean
    Dim myInfo As New SHELLEXECUTEINFO
    With myInfo
      .fMask = SEE_MASK_FLAG_NO_UI Or SEE_MASK_NOCLOSEPROCESS Or SEE_MASK_INVOKEIDLIST
      .lpVerb = "properties"
      .lpFile = sPath
      .nShow = 1
      .hwnd = frmSearch.Handle
      .cbSize = Marshal.SizeOf(myInfo)
    End With
    Dim iRet As Integer = ShellExecuteEx(myInfo)
    Return iRet = 1
  End Function
End Module
