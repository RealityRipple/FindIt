Imports System.IO

Public Class ShellClipboardFormats
  Public Const CFSTR_SHELLIDLIST As String = "Shell IDList Array"
  Public Const CFSTR_SHELLIDLISTOFFSET As String = "Shell Object Offsets"
  Public Const CFSTR_NETRESOURCES As String = "Net Resource"
  Public Const CFSTR_FILEDESCRIPTORA As String = "FileGroupDescriptor"
  Public Const CFSTR_FILEDESCRIPTORW As String = "FileGroupDescriptorW"
  Public Const CFSTR_FILECONTENTS As String = "FileContents"
  Public Const CFSTR_FILENAMEA As String = "FileName"
  Public Const CFSTR_FILENAMEW As String = "FileNameW"
  Public Const CFSTR_PRINTERGROUP As String = "PrinterFreindlyName"
  Public Const CFSTR_FILENAMEMAPA As String = "FileNameMap"
  Public Const CFSTR_FILENAMEMAPW As String = "FileNameMapW"
  Public Const CFSTR_SHELLURL As String = "UniformResourceLocator"
  Public Const CFSTR_INETURLA As String = CFSTR_SHELLURL
  Public Const CFSTR_INETURLW As String = "UniformResourceLocatorW"
  Public Const CFSTR_PREFERREDDROPEFFECT As String = "Preferred DropEffect"
  Public Const CFSTR_PERFORMEDDROPEFFECT As String = "Performed DropEffect"
  Public Const CFSTR_PASTESUCCEEDED As String = "Paste Succeeded"
  Public Const CFSTR_INDRAGLOOP As String = "InShellDragLoop"
  Public Const CFSTR_DRAGCONTEXT As String = "DragContext"
  Public Const CFSTR_MOUNTEDVOLUME As String = "MountedVolume"
  Public Const CFSTR_PERSISTEDDATAOBJECT As String = "PersistedDataObject"
  Public Const CFSTR_TARGETCLSID As String = "TargetCLSID"
  Public Const CFSTR_LOGICALPERFORMEDDROPEFFECT As String = "Logical Performed DropEffect"
  Public Const CFSTR_AUTOPLAY_SHELLIDLISTS As String = "Autoplay Enumerated IDList Array"
End Class

Public Class ShellDataObject
  Inherits DataObject
  'This flag is used to prevent multiple callings to "GetData" when dropping in Explorer.
  'Private downloaded As Boolean = False
  'Public Overloads Overrides Function GetData(ByVal format As String) As Object
  '  Dim obj As Object = MyBase.GetData(format)
  '  Return obj
  'End Function
  Private Function InDragLoop() As Boolean
    Return (0 <> CInt(GetData(ShellClipboardFormats.CFSTR_INDRAGLOOP)))
  End Function
End Class