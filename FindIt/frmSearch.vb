﻿Public Class frmSearch

  Private FoundArray As Collections.Generic.List(Of String)
  Private Cancelled As Boolean = False
  Private animVal As Integer = 1
  Private sortView As listviewcolumnsorter

#Region "Form Events"


  Private Sub frmSearch_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    Try
      Dim sPath As String = Command()

      If String.IsNullOrEmpty(sPath) Then
        cmbDrive.Drive = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Substring(0, 1).ToUpper & ":"
        lstDir.Path = cmbDrive.Drive.Substring(0, 1).ToUpper & ":\"
      Else
        If IO.Directory.Exists(sPath) Then
          cmbDrive.Drive = sPath.Substring(0, 1).ToUpper & ":"
          lstDir.Path = sPath
        ElseIf IO.File.Exists(sPath) Then
          cmbDrive.Drive = sPath.Substring(0, 1).ToUpper & ":"
          lstDir.Path = IO.Path.GetDirectoryName(sPath)
        Else
          cmbDrive.Drive = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Substring(0, 1).ToUpper & ":"
          lstDir.Path = cmbDrive.Drive.Substring(0, 1).ToUpper & ":\"
        End If
      End If
    Catch ex As Exception
      cmbDrive.Drive = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Substring(0, 1).ToUpper & ":"
      lstDir.Path = cmbDrive.Drive.Substring(0, 1).ToUpper & ":\"
    End Try
    If My.Computer.Registry.ClassesRoot.OpenSubKey("Folder\shell\FindIt\command") Is Nothing OrElse String.IsNullOrEmpty(My.Computer.Registry.ClassesRoot.OpenSubKey("Folder\shell\FindIt\command").GetValue("", Nothing)) Then
      My.Computer.Registry.ClassesRoot.CreateSubKey("Folder\shell\FindIt\command")
      My.Computer.Registry.ClassesRoot.OpenSubKey("Folder\shell\FindIt\command", True).SetValue("", """" & Application.ExecutablePath & """ %1")
    End If
    pnlFileName.Height = 40
    pnlFileContents.Height = 20
    pnlFileDate.Height = 20
    optAround.Checked = True
    dtFileDate.Value = Today
    pnlFileSize.Height = 20
    cmbSizeCompare.SelectedIndex = 1
    cmbFileSizeScale.SelectedIndex = 0
    pnlResults.Visible = False
    pnlFindIt.RowStyles(2).SizeType = SizeType.Absolute
    pnlFindIt.RowStyles(2).Height = 0
    Me.MinimumSize = New Size(575, 220)
    Me.Size = Me.MinimumSize
    txtFileName.Focus()
    sortView = New ListViewColumnSorter
    lvResults.ListViewItemSorter = sortView
  End Sub

  Private Sub frmSearch_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
    lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
  End Sub

  Private Sub frmSearch_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
    lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
  End Sub

  Private Sub frmSearch_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelled = True
  End Sub
#End Region

#Region "Inputs"
#Region "File Name"
  Private Sub chkFileName_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFileName.CheckedChanged
    If chkFileName.Checked Then
      txtFileName.Visible = True
      Do Until pnlFileName.Height >= 40
        pnlFileName.Height += 1
        Application.DoEvents()
      Loop
      txtFileName.Focus()
    Else
      Do Until pnlFileName.Height <= 20
        pnlFileName.Height -= 1
        Application.DoEvents()
      Loop
      txtFileName.Visible = False
    End If
  End Sub
#End Region

#Region "File Contents"
  Private Sub chkFileContents_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFileContents.CheckedChanged
    If chkFileContents.Checked Then
      txtFileContents.Visible = True
      Do Until pnlFileContents.Height >= 40
        pnlFileContents.Height += 1
        Application.DoEvents()
      Loop
      txtFileContents.Focus()
    Else
      Do Until pnlFileContents.Height <= 20
        pnlFileContents.Height -= 1
        Application.DoEvents()
      Loop
      txtFileContents.Visible = False
    End If
  End Sub
#End Region

#Region "File Date"
  Private Sub optBefore_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optBefore.CheckedChanged
    dtFileDate.Focus()
  End Sub

  Private Sub optAround_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAround.CheckedChanged
    dtFileDate.Focus()
  End Sub

  Private Sub optAfter_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optAfter.CheckedChanged
    dtFileDate.Focus()
  End Sub

  Private Sub chkFileDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFileDate.CheckedChanged
    If chkFileDate.Checked Then
      pnlFileDateList.Visible = True
      Do Until pnlFileDate.Height >= 120
        pnlFileDate.Height += 1
        Application.DoEvents()
      Loop
      dtFileDate.Focus()
    Else
      Do Until pnlFileDate.Height <= 20
        pnlFileDate.Height -= 1
        Application.DoEvents()
      Loop
      pnlFileDateList.Visible = False
    End If
  End Sub
#End Region

#Region "File Size"
  Private Sub chkFileSize_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFileSize.CheckedChanged
    If chkFileSize.Checked Then
      pnlFileSizeList.Visible = True
      Do Until pnlFileSize.Height >= 50
        pnlFileSize.Height += 1
        Application.DoEvents()
      Loop
      txtFileSizeValue.Focus()
    Else
      Do Until pnlFileSize.Height <= 20
        pnlFileSize.Height -= 1
        Application.DoEvents()
      Loop
      pnlFileSizeList.Visible = False
    End If
  End Sub
#End Region

#Region "Search Directory"
  Private Sub cmbDrive_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDrive.SelectedIndexChanged
    Try
      lstDir.Path = cmbDrive.Drive.Substring(0, 1).ToUpper & ":\"
      lstDir.Enabled = True
      lstDir.Focus()
    Catch ex As Exception
      lstDir.Path = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Substring(0, 1).ToUpper & ":"
      lstDir.Enabled = False
    End Try

  End Sub
#End Region

  Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
    If cmdFind.Text = "&Find >>" Then
      Cancelled = False
      If Not chkFileName.Checked And Not chkFileContents.Checked And Not chkFileSize.Checked And Not chkFileDate.Checked Then
        chkFileName.Focus()
        Beep()
        Exit Sub
      Else
        If chkFileName.Checked AndAlso String.IsNullOrEmpty(txtFileName.Text) Then
          txtFileName.Focus()
          Beep()
          Exit Sub
        End If
        If chkFileContents.Checked AndAlso String.IsNullOrEmpty(txtFileContents.Text) Then
          txtFileContents.Focus()
          Beep()
          Exit Sub
        End If
        pnlResults.Visible = True
        lvResults.Items.Clear()
        If pnlFindIt.RowStyles(2).SizeType = SizeType.Absolute Then
          lvResults.ContextMenu = mnuFile
          pnlFindIt.RowStyles(0).SizeType = SizeType.Absolute
          pnlFindIt.RowStyles(0).Height = 151
          pnlFindIt.RowStyles(2).SizeType = SizeType.Percent
          pnlFindIt.RowStyles(2).Height = 100
          lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
          Me.Height += 150
          Me.MinimumSize = New Size(575, 400)
        End If
        Dim args As New FindEventArgs(lstDir.Path,
                                      IIf(chkFileName.Checked, txtFileName.Text, Nothing),
                                      IIf(chkFileContents.Checked, txtFileContents.Text, Nothing),
                                      IIf(chkFileDate.Checked,
                                        IIf(optBefore.Checked, FindEventArgs.DateComparisons.Earlier,
                                          IIf(optAfter.Checked, FindEventArgs.DateComparisons.Later, FindEventArgs.DateComparisons.Near)
                                        ), FindEventArgs.DateComparisons.None
                                      ),
                                      IIf(chkFileDate.Checked, dtFileDate.Value.Date, New Date(1970, 1, 1)),
                                      IIf(chkFileSize.Checked,
                                        IIf(cmbSizeCompare.SelectedIndex = 0, FindEventArgs.SizeComparisons.Greater,
                                            IIf(cmbSizeCompare.SelectedIndex = 1, FindEventArgs.SizeComparisons.Equal, FindEventArgs.SizeComparisons.Less)
                                        ), FindEventArgs.SizeComparisons.None),
                                      IIf(chkFileSize.Checked, txtFileSizeValue.Value, 0),
                                      IIf(cmbFileSizeScale.SelectedIndex = 0, FindEventArgs.SizeScales.Byte,
                                        IIf(cmbFileSizeScale.SelectedIndex = 1, FindEventArgs.SizeScales.KByte,
                                          IIf(cmbFileSizeScale.SelectedIndex = 2, FindEventArgs.SizeScales.MByte,
                                            IIf(cmbFileSizeScale.SelectedIndex = 3, FindEventArgs.SizeScales.GByte,
                                              IIf(cmbFileSizeScale.SelectedIndex = 4, FindEventArgs.SizeScales.TByte,
                                                IIf(cmbFileSizeScale.SelectedIndex = 5, FindEventArgs.SizeScales.PByte,
                                                  IIf(cmbFileSizeScale.SelectedIndex = 6, FindEventArgs.SizeScales.EByte, FindEventArgs.SizeScales.None)
                                                )
                                              )
                                            )
                                          )
                                        )
                                      ),
                                      chkFast.Checked
                                     )
        FoundArray = New Generic.List(Of String)
        SetEnabled(False)
        SetProgress("Beginning Search...")
        animVal = 1
        If (chkFast.Checked) Then
          tmrListUpdate.Enabled = True
          Dim findHandler = New EventHandler(Of FindEventArgs)(AddressOf FindFiles)
          findHandler.BeginInvoke(True, args, Nothing, Nothing)
        Else
          tmrListUpdate.Enabled = False
          FindFiles(False, args)
          If Not Cancelled Then lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
          SetEnabled(True)
          If Cancelled Then
            SetProgress("Search Stopped by User - " & lvResults.Items.Count & " Item" & IIf(lvResults.Items.Count = 1, "", "s") & " found")
          Else
            SetProgress("Search Complete - " & lvResults.Items.Count & " Item" & IIf(lvResults.Items.Count = 1, "", "s") & " found")
          End If
        End If
      End If
    Else
      Cancelled = True
      SetEnabled(True)
      SetProgress("Search Stopped by User - " & lvResults.Items.Count & " Item" & IIf(lvResults.Items.Count = 1, "", "s") & " found")
    End If
  End Sub
#End Region

#Region "Search Functions"
  Private Class FindEventArgs
    Inherits EventArgs

    Public Enum DateComparisons
      None
      Earlier
      Near
      Later
    End Enum

    Public Enum SizeComparisons
      None
      Less
      Equal
      Greater
    End Enum

    Public Enum SizeScales
      None
      [Byte]
      KByte
      MByte
      GByte
      TByte
      PByte
      EByte
    End Enum

    Public sFromDir As String
    Public sFileName As String
    Public sFileContents As String
    Public bFileDateCompare As DateComparisons
    Public dFileDateVal As Date
    Public bFileSizeCompare As SizeComparisons
    Public iFileSizeVal As Integer
    Public iFileSizeScale As SizeScales
    Public bFast As Boolean

    Public Sub New(FromDir As String, fName As String, fContents As String, fDateCompare As DateComparisons, fDateVal As Date, fSizeCompare As SizeComparisons, fSizeVal As Integer, fSizeScale As SizeScales, fFast As Boolean)
      sFromDir = FromDir
      sFileName = fName
      sFileContents = fContents
      bFileDateCompare = fDateCompare
      dFileDateVal = fDateVal
      bFileSizeCompare = fSizeCompare
      iFileSizeVal = fSizeVal
      iFileSizeScale = fSizeScale
      bFast = fFast
    End Sub
  End Class

  Private Sub FindFiles(sender As Object, e As FindEventArgs)
    Dim sFileList() As String
    Try
      sFileList = My.Computer.FileSystem.GetFiles(e.sFromDir).ToArray
    Catch ex As Exception
      sFileList = {}
    End Try
    For Each FilePath In sFileList
      Dim bAdd As Boolean = False
      If (Not String.IsNullOrEmpty(e.sFileName)) Then
        If IO.Path.GetFileName(FilePath).ToLower.Contains(e.sFileName.ToLower) Then
          bAdd = True
        End If
      End If

      If Not String.IsNullOrEmpty(e.sFileContents) Then
        If e.bFast Then
          SetProgVal("Searching in " & FilePath)
        Else
          SetProgress("Searching in " & FilePath)
        End If
        Using ioFile As New IO.FileStream(FilePath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
          Using ioRead As New IO.BinaryReader(ioFile, System.Text.Encoding.GetEncoding("latin1"))
            Dim sPercent As String = "0%"
            Do While ioRead.BaseStream.Position < ioRead.BaseStream.Length


              Dim cChr As Char = ioRead.ReadChar
              If Cancelled Then Exit Sub
              If Char.ToLower(cChr) = Char.ToLower(e.sFileContents(0)) Then
                Dim iToRead As Integer = e.sFileContents.Length - 1
                If ioRead.BaseStream.Length - ioRead.BaseStream.Position < iToRead Then iToRead = ioRead.BaseStream.Length - ioRead.BaseStream.Position
                Dim bTmp() As Byte = ioRead.ReadBytes(iToRead)
                Dim c As String = System.Text.Encoding.GetEncoding("latin1").GetString(bTmp)
                Dim sTest As String = cChr & c
                If Cancelled Then Exit Sub
                If e.sFileContents.ToLower = sTest.ToLower Then
                  bAdd = True
                End If
                If Not e.bFast Then
                  If Not sPercent = FormatPercent(ioRead.BaseStream.Position / ioRead.BaseStream.Length, 0, TriState.False, TriState.False, TriState.False) Then
                    sPercent = FormatPercent(ioRead.BaseStream.Position / ioRead.BaseStream.Length, 0, TriState.False, TriState.False, TriState.False)
                    SetProgress("Searching in " & FilePath & " (" & sPercent & ")")
                    Application.DoEvents()
                    If Cancelled Then Exit Sub
                  End If
                End If
              End If
            Loop
          End Using
        End Using
      End If

      If (e.iFileSizeVal > 0 And Not e.bFileSizeCompare = FindEventArgs.SizeComparisons.None) Then
        Dim mySize As Int64 = New IO.FileInfo(FilePath).Length
        Dim FindSize As Int64 = e.iFileSizeVal
        Dim iScale As Int64 = 1
        Select Case e.iFileSizeScale
          Case FindEventArgs.SizeScales.KByte : iScale = 1024L
          Case FindEventArgs.SizeScales.MByte : iScale = 1024L * 1024L
          Case FindEventArgs.SizeScales.GByte : iScale = 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.TByte : iScale = 1024L * 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.PByte : iScale = 1024L * 1024L * 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.EByte : iScale = 1024L * 1024L * 1024L * 1024L * 1024L * 1024L
        End Select
        FindSize *= iScale
        If e.bFileSizeCompare = FindEventArgs.SizeComparisons.Less Then
          If mySize < FindSize Then bAdd = True
        ElseIf e.bFileSizeCompare = FindEventArgs.SizeComparisons.Greater Then
          If mySize > FindSize Then bAdd = True
        ElseIf e.bFileSizeCompare = FindEventArgs.SizeComparisons.Equal Then
          If Math.Abs(mySize - FindSize) < iScale Then bAdd = True
        End If
      End If

      If (Not e.dFileDateVal.Year = 1970 And Not e.bFileDateCompare = FindEventArgs.DateComparisons.None) Then
        Dim myDate As Date = New IO.FileInfo(FilePath).LastWriteTime
        If e.bFileDateCompare = FindEventArgs.DateComparisons.Earlier Then
          If DateDiff(DateInterval.Minute, myDate, e.dFileDateVal) > 0 Then bAdd = True

        ElseIf e.bFileDateCompare = FindEventArgs.DateComparisons.Later Then
          If DateDiff(DateInterval.Minute, myDate, e.dFileDateVal) < 0 Then bAdd = True
        ElseIf e.bFileDateCompare = FindEventArgs.DateComparisons.Near Then
          If Math.Abs(DateDiff(DateInterval.Day, myDate, e.dFileDateVal)) < 7 Then bAdd = True
        End If
      End If


      If bAdd Then
        AddToFound(False, New FindEventArgs(Nothing, FilePath, Nothing, FindEventArgs.DateComparisons.None, New Date(1970, 1, 1), FindEventArgs.SizeComparisons.None, 0, FindEventArgs.SizeScales.None, e.bFast))
        If Not e.bFast Then
          If Not Cancelled Then lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
          Application.DoEvents()
          If Cancelled Then Exit Sub
        End If
      End If
    Next
    Dim sFolderList() As String
    Try
      sFolderList = My.Computer.FileSystem.GetDirectories(e.sFromDir).ToArray
    Catch ex As Exception
      sFolderList = {}
    End Try
    For Each FolderPath In sFolderList
      If e.bFast Then
        SetProgVal("Searching in " & FolderPath)
      Else
        SetProgress("Searching in " & FolderPath)
      End If

      Dim bAdd As Boolean = False
      If (Not String.IsNullOrEmpty(e.sFileName)) Then
        If IO.Path.GetFileName(FolderPath).ToLower.Contains(e.sFileName.ToLower) Then
          bAdd = True
        End If
      End If
      If (e.iFileSizeVal > 0 And Not e.bFileSizeCompare = FindEventArgs.SizeComparisons.None) Then
        Dim mySize As Int64 = GetDirSize(FolderPath)
        Dim FindSize As Int64 = e.iFileSizeVal
        Dim iScale As Int64 = 1
        Select Case e.iFileSizeScale
          Case FindEventArgs.SizeScales.KByte : iScale = 1024L
          Case FindEventArgs.SizeScales.MByte : iScale = 1024L * 1024L
          Case FindEventArgs.SizeScales.GByte : iScale = 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.TByte : iScale = 1024L * 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.PByte : iScale = 1024L * 1024L * 1024L * 1024L * 1024L
          Case FindEventArgs.SizeScales.EByte : iScale = 1024L * 1024L * 1024L * 1024L * 1024L * 1024L
        End Select
        FindSize *= iScale
        If e.bFileSizeCompare = FindEventArgs.SizeComparisons.Less Then
          If mySize < FindSize Then bAdd = True
        ElseIf e.bFileSizeCompare = FindEventArgs.SizeComparisons.Greater Then
          If mySize > FindSize Then bAdd = True
        ElseIf e.bFileSizeCompare = FindEventArgs.SizeComparisons.Equal Then
          If Math.Abs(mySize - FindSize) < iScale Then bAdd = True
        End If
      End If

      If (Not e.dFileDateVal.Year = 1970 And Not e.bFileDateCompare = FindEventArgs.DateComparisons.None) Then
        Dim myDate As Date = New IO.DirectoryInfo(FolderPath).LastWriteTime
        If e.bFileDateCompare = FindEventArgs.DateComparisons.Earlier Then
          If DateDiff(DateInterval.Minute, myDate, e.dFileDateVal) > 0 Then bAdd = True

        ElseIf e.bFileDateCompare = FindEventArgs.DateComparisons.Later Then
          If DateDiff(DateInterval.Minute, myDate, e.dFileDateVal) < 0 Then bAdd = True
        ElseIf e.bFileDateCompare = FindEventArgs.DateComparisons.Near Then
          If Math.Abs(DateDiff(DateInterval.Day, myDate, e.dFileDateVal)) < 7 Then bAdd = True
        End If
      End If


      If bAdd Then
        AddToFound(False, New FindEventArgs(Nothing, FolderPath, Nothing, FindEventArgs.DateComparisons.None, New Date(1970, 1, 1), FindEventArgs.SizeComparisons.None, 0, FindEventArgs.SizeScales.None, e.bFast))
        If Not e.bFast Then
          If Not Cancelled Then lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
          Application.DoEvents()
          If Cancelled Then Exit Sub
        End If
      End If


      If Cancelled Then Exit Sub
      FindFiles(False, New FindEventArgs(FolderPath, e.sFileName, e.sFileContents, e.bFileDateCompare, e.dFileDateVal, e.bFileSizeCompare, e.iFileSizeVal, e.iFileSizeScale, e.bFast))
      If Not e.bFast Then Application.DoEvents()
    Next
    If (sender = True) Then
      Me.Invoke(New EventHandler(AddressOf tmrListUpdate_Tick))
      SetEnabled(True)
      SetProgress("Search Complete - " & lvResults.Items.Count & " Item" & IIf(lvResults.Items.Count = 1, "", "s") & " found")
    End If

  End Sub

  Private Sub AddToFound(sender As Object, e As FindEventArgs)
    If Me.InvokeRequired Then
      Me.Invoke(New EventHandler(AddressOf AddToFound), sender, e)
    Else
      If e.bFast Then
        If FoundArray IsNot Nothing Then FoundArray.Add(e.sFileName)
      Else
        AddFileToList(e.sFileName)
      End If
    End If
  End Sub

  Private Sub AddFileToList(sPath As String)
    Dim lvItem As New ListViewItem(IO.Path.GetFileName(sPath))
    If IO.File.Exists(sPath) Then
      Dim fInfo As New IO.FileInfo(sPath)
      lvItem.SubItems.Add(ByteSize(fInfo.Length))
      lvItem.SubItems.Add(fInfo.LastWriteTime.ToString("g"))
      Dim sDir As String = IO.Path.GetDirectoryName(sPath)
      If Not sDir.EndsWith(IO.Path.DirectorySeparatorChar) Then sDir &= IO.Path.DirectorySeparatorChar
      lvItem.SubItems.Add(sDir)
      lvItem.ToolTipText = IO.Path.GetFileName(sPath) & vbNewLine &
                           "Size: " & ByteSize(fInfo.Length) & vbNewLine &
                           "Created: " & fInfo.CreationTime.ToString("g") & vbNewLine &
                           "Modified: " & fInfo.LastWriteTime.ToString("g") & vbNewLine &
                           "Attributes: " & IIf(String.IsNullOrEmpty(fInfo.Attributes.ToString("F")), "None", fInfo.Attributes.ToString("F")) & vbNewLine &
                           "Location: " & sDir
    Else
      Dim dInfo As New IO.DirectoryInfo(sPath)
      lvItem.SubItems.Add(ByteSize(getdirsize(sPath)))
      lvItem.SubItems.Add(dInfo.LastWriteTime.ToString("g"))
      Dim sDir As String = IO.Path.GetDirectoryName(sPath)
      If Not sDir.EndsWith(IO.Path.DirectorySeparatorChar) Then sDir &= IO.Path.DirectorySeparatorChar
      lvItem.SubItems.Add(sDir)
      lvItem.ToolTipText = IO.Path.GetFileName(sPath) & vbNewLine &
                           "Size: " & ByteSize(getdirsize(sPath)) & vbNewLine &
                           "Created: " & dInfo.CreationTime.ToString("g") & vbNewLine &
                           "Modified: " & dInfo.LastWriteTime.ToString("g") & vbNewLine &
                           "Attributes: " & IIf(String.IsNullOrEmpty(dInfo.Attributes.ToString("F")), "None", dInfo.Attributes.ToString("F")) & vbNewLine &
                           "Location: " & sDir
    End If
    lvResults.SmallImageList = Nothing
    Dim key As String = IO.Path.GetExtension(sPath)
    Using md5 As New Security.Cryptography.HMACMD5
      key = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.GetEncoding("latin1").GetBytes(sPath)))
    End Using
    lvItem.ImageKey = key
    If Not imlIcons.Images.ContainsKey(key) Then imlIcons.Images.Add(key, GetFileIcon(sPath))

    lvResults.SmallImageList = imlIcons
    lvResults.Items.Add(lvItem)


  End Sub

  Private Sub tmrListUpdate_Tick(sender As System.Object, e As System.EventArgs) Handles tmrListUpdate.Tick
    If sender Is Me Then
      SetProgress("Completing Search...")
      Application.DoEvents()
    End If
    If FoundArray IsNot Nothing AndAlso FoundArray.Count > 0 Then
      For I As Integer = FoundArray.Count - 1 To 0 Step -1
        AddFileToList(FoundArray(I))
        FoundArray.RemoveAt(I)
      Next
      lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
    End If
    If Not lblStatus.Text = sProgressVal Then lblStatus.Text = sProgressVal
  End Sub

  Private Sub tmrSearchAnim_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSearchAnim.Tick
    Select Case animVal
      Case 1 : lblImage.Image = My.Resources.Search_01
      Case 2 : lblImage.Image = My.Resources.Search_02
      Case 3 : lblImage.Image = My.Resources.Search_03
      Case 4 : lblImage.Image = My.Resources.Search_04
      Case 5 : lblImage.Image = My.Resources.Search_05
      Case 6 : lblImage.Image = My.Resources.Search_06
      Case 7 : lblImage.Image = My.Resources.Search_07
      Case 8 : lblImage.Image = My.Resources.Search_08
      Case 9 : lblImage.Image = My.Resources.Search_09
      Case 10 : lblImage.Image = My.Resources.Search_10
      Case 11 : lblImage.Image = My.Resources.Search_11
      Case 12 : lblImage.Image = My.Resources.Search_12
      Case 13 : lblImage.Image = My.Resources.Search_13
      Case 14 : lblImage.Image = My.Resources.Search_14
      Case 15 : lblImage.Image = My.Resources.Search_15
      Case 16 : lblImage.Image = My.Resources.Search_16
      Case 17 : lblImage.Image = My.Resources.Search_17
      Case 18 : lblImage.Image = My.Resources.Search_18
      Case 19 : lblImage.Image = My.Resources.Search_19
      Case 20 : lblImage.Image = My.Resources.Search_20
      Case 21 : lblImage.Image = My.Resources.Search_21
      Case 22 : lblImage.Image = My.Resources.Search_22
      Case Else : lblImage.Image = Nothing
    End Select

    animVal += 1
    If animVal > 22 Then animVal = 1
  End Sub
#End Region

#Region "Results"
  Private Sub lvResults_AfterLabelEdit(sender As Object, e As System.Windows.Forms.LabelEditEventArgs) Handles lvResults.AfterLabelEdit
    If String.IsNullOrEmpty(e.Label) Then
      e.CancelEdit = True
      Exit Sub
    End If
    Dim item As ListViewItem = lvResults.Items(e.Item)
    Dim sPath As String = item.SubItems(3).Text & item.Text
    Dim sNewPath As String = item.SubItems(3).Text & e.Label
    If MsgBox("Are you sure you want to rename " & item.Text & " to " & e.Label & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.ApplicationModal, "FindIt") = MsgBoxResult.Yes Then
      If IO.Directory.Exists(sPath) Then
        Try
          IO.Directory.Move(sPath, sNewPath)
        Catch ex As Exception
          MsgBox("Failed to rename directory """ & sPath & """ as """ & e.Label & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
          e.CancelEdit = True
        End Try
      ElseIf IO.File.Exists(sPath) Then
        Try
          IO.File.Move(sPath, sNewPath)
        Catch ex As Exception
          MsgBox("Failed to rename file """ & sPath & """ as """ & e.Label & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
          e.CancelEdit = True
        End Try
      Else
        MsgBox("Unable to find """ & sPath & """!", MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal, "FindIt")
        e.CancelEdit = True
      End If
    Else
      e.CancelEdit = True
    End If
  End Sub

  Private Sub lvResults_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvResults.ColumnClick
    If e.Column = sortView.SortColumn Then
      If sortView.Order = SortOrder.Ascending Then
        sortView.Order = SortOrder.Descending
      Else
        sortView.Order = SortOrder.Ascending
      End If
    Else
      sortView.SortColumn = e.Column
      sortView.Order = SortOrder.Ascending
    End If
    lvResults.Columns(0).Text = "File Name"
    lvResults.Columns(1).Text = "Size"
    lvResults.Columns(2).Text = "Date"
    lvResults.Columns(3).Text = "Path"
    If Not sortView.Order = SortOrder.None Then
      If e.Column = 1 Or e.Column = 2 Then
        lvResults.Columns(e.Column).Text = IIf(sortView.Order = SortOrder.Ascending, "↑", "↓") & " " & lvResults.Columns(e.Column).Text
      Else
        lvResults.Columns(e.Column).Text &= " " & IIf(sortView.Order = SortOrder.Ascending, "↑", "↓")
      End If
    End If
    lvResults.Sort()
  End Sub

  Private Sub lvResults_ColumnWidthChanged(sender As Object, e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lvResults.ColumnWidthChanged
    If Not e.ColumnIndex = 3 Then lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
  End Sub

  Private Sub lvResults_ColumnWidthChanging(sender As Object, e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lvResults.ColumnWidthChanging
    If Not e.ColumnIndex = 3 Then lvResults.Columns(3).Width = lvResults.DisplayRectangle.Width - lvResults.Columns(2).Width - lvResults.Columns(1).Width - lvResults.Columns(0).Width
  End Sub

  Private Sub lvResults_DoubleClick(sender As Object, e As System.EventArgs) Handles lvResults.DoubleClick
    mnuOpen.PerformClick()
  End Sub

  Private Sub lvResults_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvResults.KeyUp
    If e.KeyCode = Keys.Delete Then
      mnuDelete.PerformClick()
    ElseIf e.KeyCode = Keys.F2 Then
      mnuRename.PerformClick()
    ElseIf e.KeyCode = Keys.A And ((e.Modifiers And Keys.Control) = Keys.Control) Then
      For Each item As ListViewItem In lvResults.Items
        item.Selected = True
      Next
    End If
  End Sub

#Region "Context Menu"
  Private Sub mnuOpen_Click(sender As System.Object, e As System.EventArgs) Handles mnuOpen.Click
    If lvResults.SelectedItems.Count = 0 Then Exit Sub
    For Each item As ListViewItem In lvResults.SelectedItems
      Dim sPath As String = item.SubItems(3).Text & item.Text
      If IO.File.Exists(sPath) Then
        Try
          Process.Start(sPath)
        Catch ex As Exception
          MsgBox("Failed to run """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
        End Try
      ElseIf IO.Directory.Exists(sPath) Then
        Try
          Process.Start("explorer.exe", sPath)
        Catch ex As Exception
          MsgBox("Failed to open directory """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
        End Try
      End If
    Next
  End Sub

  Private Sub mnuOpenFolder_Click(sender As System.Object, e As System.EventArgs) Handles mnuOpenFolder.Click
    If lvResults.SelectedItems.Count = 0 Then Exit Sub
    For Each item As ListViewItem In lvResults.SelectedItems
      Dim sDir As String = item.SubItems(3).Text
      Dim sPath As String = sDir & item.Text
      If IO.Directory.Exists(sDir) Then
        Try
          Process.Start("explorer.exe", "/select," & sPath)
        Catch ex As Exception
          MsgBox("Failed to open directory """ & sDir & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
        End Try
      End If
    Next
  End Sub

  Private Sub mnuRename_Click(sender As System.Object, e As System.EventArgs) Handles mnuRename.Click
    If lvResults.SelectedItems.Count = 0 Then Exit Sub
    If lvResults.SelectedItems.Count = 1 Then
      lvResults.SelectedItems(0).BeginEdit()
    Else
      MsgBox("You can only rename one file at a time!", MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal, "FindIt")
    End If
  End Sub

  Private Sub mnuDelete_Click(sender As System.Object, e As System.EventArgs) Handles mnuDelete.Click
    If lvResults.SelectedItems.Count = 0 Then Exit Sub
    If lvResults.SelectedItems.Count = 1 Then
      Dim sPath As String = lvResults.SelectedItems(0).SubItems(3).Text & lvResults.SelectedItems(0).Text
      If MsgBox("Are you sure you want to delete """ & lvResults.SelectedItems(0).Text & """?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.ApplicationModal, "FindIt") = MsgBoxResult.Yes Then
        If IO.File.Exists(sPath) Then
          Try
            My.Computer.FileSystem.DeleteFile(sPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            lvResults.Items.Remove(lvResults.SelectedItems(0))
          Catch ex As Exception
            MsgBox("Failed to delete file """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
          End Try
        ElseIf IO.Directory.Exists(sPath) Then
          Try
            My.Computer.FileSystem.DeleteDirectory(sPath, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            lvResults.Items.Remove(lvResults.SelectedItems(0))
          Catch ex As Exception
            MsgBox("Failed to delete directory """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
          End Try
        End If
      End If
    Else
      If MsgBox("Are you sure you want to delete these " & lvResults.SelectedItems.Count & " files?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.ApplicationModal, "FindIt") = MsgBoxResult.Yes Then
        For Each item As ListViewItem In lvResults.SelectedItems
          Dim sPath As String = item.SubItems(3).Text & item.Text
          If IO.File.Exists(sPath) Then
            Try
              My.Computer.FileSystem.DeleteFile(sPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
              lvResults.Items.Remove(item)
            Catch ex As Exception
              MsgBox("Failed to delete file """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
            End Try
          ElseIf IO.Directory.Exists(sPath) Then
            Try
              My.Computer.FileSystem.DeleteDirectory(sPath, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
              lvResults.Items.Remove(item)
            Catch ex As Exception
              MsgBox("Failed to delete directory """ & sPath & """." & vbNewLine & ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, "FindIt")
            End Try
          End If
        Next
      End If
    End If
    SetProgress("Search Complete - " & lvResults.Items.Count & " Item" & IIf(lvResults.Items.Count = 1, "", "s") & " found")
  End Sub

  Private Sub mnuProperties_Click(sender As System.Object, e As System.EventArgs) Handles mnuProperties.Click
    If lvResults.SelectedItems.Count = 0 Then Exit Sub
    If lvResults.SelectedItems.Count = 1 Then
      Dim sPath As String = lvResults.SelectedItems(0).SubItems(3).Text & lvResults.SelectedItems(0).Text
      DisplayProperties(sPath)
    Else
      For Each item As ListViewItem In lvResults.SelectedItems
        Dim sPath As String = item.SubItems(3).Text & item.Text
        DisplayProperties(sPath)
      Next
    End If
  End Sub
#End Region
#End Region

#Region "Functions"
  Private Delegate Sub SetEnabledInvoker(bEnabled As Boolean)
  Private Sub SetEnabled(bEnabled As Boolean)
    If Me.InvokeRequired Then
      Try
        Me.Invoke(New SetEnabledInvoker(AddressOf SetEnabled), bEnabled)
      Catch ex As Exception

      End Try
    Else
      chkFileName.Enabled = bEnabled
      txtFileName.Enabled = bEnabled

      chkFileContents.Enabled = bEnabled
      txtFileContents.Enabled = bEnabled

      chkFileSize.Enabled = bEnabled
      cmbSizeCompare.Enabled = bEnabled
      txtFileSizeValue.Enabled = bEnabled
      cmbFileSizeScale.Enabled = bEnabled

      chkFileDate.Enabled = bEnabled
      optBefore.Enabled = bEnabled
      optAround.Enabled = bEnabled
      optAfter.Enabled = bEnabled
      dtFileDate.Enabled = bEnabled

      cmbDrive.Enabled = bEnabled
      lstDir.Enabled = bEnabled
      chkFast.Enabled = bEnabled
      If bEnabled Then
        tmrSearchAnim.Enabled = False
        lblImage.Image = Nothing
        cmdFind.Text = "&Find >>"
        tmrListUpdate.Enabled = False
      Else
        tmrSearchAnim.Enabled = True
        cmdFind.Text = "&Stop Search"
      End If
    End If
  End Sub

  Private Delegate Sub SetProgressInvoker(sStatus As String)
  Private Sub SetProgress(sStatus As String)
    If Me.InvokeRequired Then
      Try
        Me.Invoke(New SetProgressInvoker(AddressOf SetProgress), sStatus)
      Catch ex As Exception

      End Try
    Else
      sProgressVal = sStatus
      lblStatus.Text = sStatus
    End If
  End Sub
  Private sProgressVal As String
  Private Sub SetProgVal(sStatus As String)
    If Me.InvokeRequired Then
      Try
        Me.Invoke(New SetProgressInvoker(AddressOf SetProgVal), sStatus)
      Catch ex As Exception

      End Try
    Else
      sProgressVal = sStatus
    End If
  End Sub

  Private Function ByteSize(InBytes As UInt64) As String
    If InBytes >= 1000 Then
      If InBytes / 1024 >= 1000 Then
        If InBytes / 1024 / 1024 >= 1000 Then
          If InBytes / 1024 / 1024 / 1024 >= 1000 Then
            If InBytes / 1024 / 1024 / 1024 / 1024 >= 1000 Then
              If InBytes / 1024 / 1024 / 1024 / 1024 / 1024 >= 1000 Then
                Return Format((InBytes) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024, "0.##") & " EB"
              Else
                Return Format((InBytes) / 1024 / 1024 / 1024 / 1024 / 1024, "0.##") & " PB"
              End If
            Else
              Return Format((InBytes) / 1024 / 1024 / 1024 / 1024, "0.##") & " TB"
            End If
          Else
            Return Format((InBytes) / 1024 / 1024 / 1024, "0.##") & " GB"
          End If
        Else
          Return Format((InBytes) / 1024 / 1024, "0.##") & " MB"
        End If
      Else
        Return Format((InBytes) / 1024, "0.#") & " KB"
      End If
    Else
      Return InBytes & " B"
    End If
  End Function

  Private Function GetDirSize(sPath As String) As UInt64
    Dim mySize As UInt64 = 0
    Try
      If IO.Directory.Exists(sPath) Then
        For Each sDir As String In IO.Directory.GetDirectories(sPath)
          mySize += GetDirSize(sDir)
        Next
        For Each sFile As String In IO.Directory.GetFiles(sPath)
          mySize += New IO.FileInfo(sFile).Length
        Next
        Return mySize
      Else
        Return 0
      End If
    Catch ex As Exception
      Return 0
    End Try
  End Function

  ''' <summary>
  ''' This class is an implementation of the 'IComparer' interface.
  ''' </summary>
  Public Class ListViewColumnSorter
    Implements IComparer
    ''' <summary>
    ''' Specifies the column to be sorted
    ''' </summary>
    Private ColumnToSort As Integer
    ''' <summary>
    ''' Specifies the order in which to sort (i.e. 'Ascending').
    ''' </summary>
    Private OrderOfSort As SortOrder
    ''' <summary>
    ''' Case insensitive comparer object
    ''' </summary>
    Private ObjectCompare As CaseInsensitiveComparer

    ''' <summary>
    ''' Class constructor.  Initializes various elements
    ''' </summary>
    Public Sub New()
      ' Initialize the column to '0'
      ColumnToSort = 0

      ' Initialize the sort order to 'none'
      OrderOfSort = SortOrder.None

      ' Initialize the CaseInsensitiveComparer object
      ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    ''' <summary>
    ''' This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
    ''' </summary>
    ''' <param name="x">First object to be compared</param>
    ''' <param name="y">Second object to be compared</param>
    ''' <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
      Dim compareResult As Integer
      Dim listviewX As ListViewItem, listviewY As ListViewItem

      ' Cast the objects to be compared to ListViewItem objects
      listviewX = DirectCast(x, ListViewItem)
      listviewY = DirectCast(y, ListViewItem)

      ' Compare the two items
      compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text, listviewY.SubItems(ColumnToSort).Text)

      ' Calculate correct return value based on object comparison
      If OrderOfSort = SortOrder.Ascending Then
        ' Ascending sort is selected, return normal result of compare operation
        Return compareResult
      ElseIf OrderOfSort = SortOrder.Descending Then
        ' Descending sort is selected, return negative result of compare operation
        Return (-compareResult)
      Else
        ' Return '0' to indicate they are equal
        Return 0
      End If
    End Function

    ''' <summary>
    ''' Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
    ''' </summary>
    Public Property SortColumn() As Integer
      Get
        Return ColumnToSort
      End Get
      Set(value As Integer)
        ColumnToSort = value
      End Set
    End Property

    ''' <summary>
    ''' Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
    ''' </summary>
    Public Property Order() As SortOrder
      Get
        Return OrderOfSort
      End Get
      Set(value As SortOrder)
        OrderOfSort = value
      End Set
    End Property

  End Class
#End Region
End Class