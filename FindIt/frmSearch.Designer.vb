<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
    Me.pnlFindIt = New System.Windows.Forms.TableLayoutPanel()
    Me.pnlOptions = New System.Windows.Forms.GroupBox()
    Me.pnlOptionList = New System.Windows.Forms.TableLayoutPanel()
    Me.pnlFileSize = New System.Windows.Forms.GroupBox()
    Me.pnlFileSizeList = New System.Windows.Forms.TableLayoutPanel()
    Me.cmbSizeCompare = New System.Windows.Forms.ComboBox()
    Me.txtFileSizeValue = New System.Windows.Forms.NumericUpDown()
    Me.cmbFileSizeScale = New System.Windows.Forms.ComboBox()
    Me.chkFileSize = New System.Windows.Forms.CheckBox()
    Me.pnlFileName = New System.Windows.Forms.GroupBox()
    Me.txtFileName = New System.Windows.Forms.TextBox()
    Me.chkFileName = New System.Windows.Forms.CheckBox()
    Me.pnlFileContents = New System.Windows.Forms.GroupBox()
    Me.txtFileContents = New System.Windows.Forms.TextBox()
    Me.chkFileContents = New System.Windows.Forms.CheckBox()
    Me.pnlFileDate = New System.Windows.Forms.GroupBox()
    Me.pnlFileDateList = New System.Windows.Forms.TableLayoutPanel()
    Me.optBefore = New System.Windows.Forms.RadioButton()
    Me.optAround = New System.Windows.Forms.RadioButton()
    Me.optAfter = New System.Windows.Forms.RadioButton()
    Me.dtFileDate = New System.Windows.Forms.DateTimePicker()
    Me.chkFileDate = New System.Windows.Forms.CheckBox()
    Me.cmdFind = New System.Windows.Forms.Button()
    Me.pnlDirectory = New System.Windows.Forms.GroupBox()
    Me.pnlDirectoryList = New System.Windows.Forms.TableLayoutPanel()
    Me.cmbDrive = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
    Me.lstDir = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
    Me.chkFast = New System.Windows.Forms.CheckBox()
    Me.pnlResults = New System.Windows.Forms.TableLayoutPanel()
    Me.lvResults = New System.Windows.Forms.ListView()
    Me.colFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colFileDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.colFilePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.sbState = New System.Windows.Forms.StatusStrip()
    Me.lblImage = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tmrListUpdate = New System.Windows.Forms.Timer(Me.components)
    Me.imlIcons = New System.Windows.Forms.ImageList(Me.components)
    Me.mnuFile = New System.Windows.Forms.ContextMenu()
    Me.mnuOpen = New System.Windows.Forms.MenuItem()
    Me.mnuOpenFolder = New System.Windows.Forms.MenuItem()
    Me.mnuSpace1 = New System.Windows.Forms.MenuItem()
    Me.mnuDelete = New System.Windows.Forms.MenuItem()
    Me.mnuRename = New System.Windows.Forms.MenuItem()
    Me.mnuSpace2 = New System.Windows.Forms.MenuItem()
    Me.mnuProperties = New System.Windows.Forms.MenuItem()
    Me.tmrSearchAnim = New System.Windows.Forms.Timer(Me.components)
    Me.chkFileNameCS = New System.Windows.Forms.CheckBox()
    Me.chkFileContentsCS = New System.Windows.Forms.CheckBox()
    Me.pnlFindIt.SuspendLayout()
    Me.pnlOptions.SuspendLayout()
    Me.pnlOptionList.SuspendLayout()
    Me.pnlFileSize.SuspendLayout()
    Me.pnlFileSizeList.SuspendLayout()
    CType(Me.txtFileSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlFileName.SuspendLayout()
    Me.pnlFileContents.SuspendLayout()
    Me.pnlFileDate.SuspendLayout()
    Me.pnlFileDateList.SuspendLayout()
    Me.pnlDirectory.SuspendLayout()
    Me.pnlDirectoryList.SuspendLayout()
    Me.pnlResults.SuspendLayout()
    Me.sbState.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlFindIt
    '
    Me.pnlFindIt.ColumnCount = 3
    Me.pnlFindIt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
    Me.pnlFindIt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.pnlFindIt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.pnlFindIt.Controls.Add(Me.pnlOptions, 0, 0)
    Me.pnlFindIt.Controls.Add(Me.cmdFind, 2, 1)
    Me.pnlFindIt.Controls.Add(Me.pnlDirectory, 1, 0)
    Me.pnlFindIt.Controls.Add(Me.chkFast, 1, 1)
    Me.pnlFindIt.Controls.Add(Me.pnlResults, 0, 2)
    Me.pnlFindIt.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlFindIt.Location = New System.Drawing.Point(0, 0)
    Me.pnlFindIt.Name = "pnlFindIt"
    Me.pnlFindIt.RowCount = 3
    Me.pnlFindIt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlFindIt.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlFindIt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
    Me.pnlFindIt.Size = New System.Drawing.Size(584, 471)
    Me.pnlFindIt.TabIndex = 0
    '
    'pnlOptions
    '
    Me.pnlOptions.Controls.Add(Me.pnlOptionList)
    Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlOptions.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlOptions.Location = New System.Drawing.Point(3, 3)
    Me.pnlOptions.Name = "pnlOptions"
    Me.pnlFindIt.SetRowSpan(Me.pnlOptions, 2)
    Me.pnlOptions.Size = New System.Drawing.Size(342, 165)
    Me.pnlOptions.TabIndex = 0
    Me.pnlOptions.TabStop = False
    Me.pnlOptions.Text = "Search Filter &Options"
    '
    'pnlOptionList
    '
    Me.pnlOptionList.AutoSize = True
    Me.pnlOptionList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.pnlOptionList.ColumnCount = 2
    Me.pnlOptionList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlOptionList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.pnlOptionList.Controls.Add(Me.pnlFileSize, 0, 2)
    Me.pnlOptionList.Controls.Add(Me.pnlFileName, 0, 0)
    Me.pnlOptionList.Controls.Add(Me.pnlFileContents, 0, 1)
    Me.pnlOptionList.Controls.Add(Me.pnlFileDate, 1, 0)
    Me.pnlOptionList.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlOptionList.Location = New System.Drawing.Point(3, 16)
    Me.pnlOptionList.Name = "pnlOptionList"
    Me.pnlOptionList.RowCount = 3
    Me.pnlOptionList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlOptionList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlOptionList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlOptionList.Size = New System.Drawing.Size(336, 146)
    Me.pnlOptionList.TabIndex = 0
    '
    'pnlFileSize
    '
    Me.pnlFileSize.Controls.Add(Me.pnlFileSizeList)
    Me.pnlFileSize.Controls.Add(Me.chkFileSize)
    Me.pnlFileSize.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileSize.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlFileSize.Location = New System.Drawing.Point(3, 93)
    Me.pnlFileSize.Name = "pnlFileSize"
    Me.pnlFileSize.Size = New System.Drawing.Size(162, 50)
    Me.pnlFileSize.TabIndex = 2
    Me.pnlFileSize.TabStop = False
    '
    'pnlFileSizeList
    '
    Me.pnlFileSizeList.ColumnCount = 3
    Me.pnlFileSizeList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.pnlFileSizeList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
    Me.pnlFileSizeList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
    Me.pnlFileSizeList.Controls.Add(Me.cmbSizeCompare, 0, 0)
    Me.pnlFileSizeList.Controls.Add(Me.txtFileSizeValue, 1, 0)
    Me.pnlFileSizeList.Controls.Add(Me.cmbFileSizeScale, 2, 0)
    Me.pnlFileSizeList.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileSizeList.Location = New System.Drawing.Point(3, 16)
    Me.pnlFileSizeList.Name = "pnlFileSizeList"
    Me.pnlFileSizeList.RowCount = 1
    Me.pnlFileSizeList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlFileSizeList.Size = New System.Drawing.Size(156, 28)
    Me.pnlFileSizeList.TabIndex = 1
    Me.pnlFileSizeList.Visible = False
    '
    'cmbSizeCompare
    '
    Me.cmbSizeCompare.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmbSizeCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbSizeCompare.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.cmbSizeCompare.FormattingEnabled = True
    Me.cmbSizeCompare.Items.AddRange(New Object() {">", "=", "<"})
    Me.cmbSizeCompare.Location = New System.Drawing.Point(3, 3)
    Me.cmbSizeCompare.Name = "cmbSizeCompare"
    Me.cmbSizeCompare.Size = New System.Drawing.Size(33, 21)
    Me.cmbSizeCompare.TabIndex = 0
    '
    'txtFileSizeValue
    '
    Me.txtFileSizeValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtFileSizeValue.Location = New System.Drawing.Point(42, 4)
    Me.txtFileSizeValue.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
    Me.txtFileSizeValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.txtFileSizeValue.Name = "txtFileSizeValue"
    Me.txtFileSizeValue.Size = New System.Drawing.Size(48, 20)
    Me.txtFileSizeValue.TabIndex = 1
    Me.txtFileSizeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtFileSizeValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'cmbFileSizeScale
    '
    Me.cmbFileSizeScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmbFileSizeScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbFileSizeScale.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.cmbFileSizeScale.FormattingEnabled = True
    Me.cmbFileSizeScale.Items.AddRange(New Object() {"Bytes", "KBytes", "MBytes", "GBytes", "TBytes", "PBytes", "EBytes"})
    Me.cmbFileSizeScale.Location = New System.Drawing.Point(96, 3)
    Me.cmbFileSizeScale.Name = "cmbFileSizeScale"
    Me.cmbFileSizeScale.Size = New System.Drawing.Size(57, 21)
    Me.cmbFileSizeScale.TabIndex = 2
    '
    'chkFileSize
    '
    Me.chkFileSize.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileSize.Location = New System.Drawing.Point(8, 0)
    Me.chkFileSize.Name = "chkFileSize"
    Me.chkFileSize.Size = New System.Drawing.Size(57, 18)
    Me.chkFileSize.TabIndex = 0
    Me.chkFileSize.Text = "File &Size"
    Me.chkFileSize.UseVisualStyleBackColor = True
    '
    'pnlFileName
    '
    Me.pnlFileName.Controls.Add(Me.chkFileNameCS)
    Me.pnlFileName.Controls.Add(Me.txtFileName)
    Me.pnlFileName.Controls.Add(Me.chkFileName)
    Me.pnlFileName.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileName.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlFileName.Location = New System.Drawing.Point(3, 3)
    Me.pnlFileName.Name = "pnlFileName"
    Me.pnlFileName.Size = New System.Drawing.Size(162, 39)
    Me.pnlFileName.TabIndex = 0
    Me.pnlFileName.TabStop = False
    '
    'txtFileName
    '
    Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtFileName.Location = New System.Drawing.Point(3, 16)
    Me.txtFileName.Name = "txtFileName"
    Me.txtFileName.Size = New System.Drawing.Size(110, 20)
    Me.txtFileName.TabIndex = 1
    '
    'chkFileName
    '
    Me.chkFileName.Checked = True
    Me.chkFileName.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkFileName.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileName.Location = New System.Drawing.Point(6, 0)
    Me.chkFileName.Name = "chkFileName"
    Me.chkFileName.Size = New System.Drawing.Size(142, 18)
    Me.chkFileName.TabIndex = 0
    Me.chkFileName.Text = "All or Part of the File &Name"
    '
    'pnlFileContents
    '
    Me.pnlFileContents.Controls.Add(Me.chkFileContentsCS)
    Me.pnlFileContents.Controls.Add(Me.txtFileContents)
    Me.pnlFileContents.Controls.Add(Me.chkFileContents)
    Me.pnlFileContents.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileContents.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlFileContents.Location = New System.Drawing.Point(3, 48)
    Me.pnlFileContents.Name = "pnlFileContents"
    Me.pnlFileContents.Size = New System.Drawing.Size(162, 39)
    Me.pnlFileContents.TabIndex = 1
    Me.pnlFileContents.TabStop = False
    '
    'txtFileContents
    '
    Me.txtFileContents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtFileContents.Location = New System.Drawing.Point(3, 16)
    Me.txtFileContents.Name = "txtFileContents"
    Me.txtFileContents.Size = New System.Drawing.Size(110, 20)
    Me.txtFileContents.TabIndex = 1
    Me.txtFileContents.Visible = False
    '
    'chkFileContents
    '
    Me.chkFileContents.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileContents.Location = New System.Drawing.Point(6, 0)
    Me.chkFileContents.Name = "chkFileContents"
    Me.chkFileContents.Size = New System.Drawing.Size(130, 18)
    Me.chkFileContents.TabIndex = 0
    Me.chkFileContents.Text = "Part of the File &Contents"
    Me.chkFileContents.UseVisualStyleBackColor = True
    '
    'pnlFileDate
    '
    Me.pnlFileDate.Controls.Add(Me.pnlFileDateList)
    Me.pnlFileDate.Controls.Add(Me.chkFileDate)
    Me.pnlFileDate.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileDate.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlFileDate.Location = New System.Drawing.Point(171, 3)
    Me.pnlFileDate.Name = "pnlFileDate"
    Me.pnlOptionList.SetRowSpan(Me.pnlFileDate, 3)
    Me.pnlFileDate.Size = New System.Drawing.Size(162, 117)
    Me.pnlFileDate.TabIndex = 3
    Me.pnlFileDate.TabStop = False
    '
    'pnlFileDateList
    '
    Me.pnlFileDateList.ColumnCount = 1
    Me.pnlFileDateList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlFileDateList.Controls.Add(Me.optBefore, 0, 0)
    Me.pnlFileDateList.Controls.Add(Me.optAround, 0, 1)
    Me.pnlFileDateList.Controls.Add(Me.optAfter, 0, 2)
    Me.pnlFileDateList.Controls.Add(Me.dtFileDate, 0, 3)
    Me.pnlFileDateList.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlFileDateList.Location = New System.Drawing.Point(3, 16)
    Me.pnlFileDateList.Name = "pnlFileDateList"
    Me.pnlFileDateList.RowCount = 4
    Me.pnlFileDateList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlFileDateList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlFileDateList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlFileDateList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlFileDateList.Size = New System.Drawing.Size(156, 98)
    Me.pnlFileDateList.TabIndex = 1
    Me.pnlFileDateList.Visible = False
    '
    'optBefore
    '
    Me.optBefore.AutoSize = True
    Me.optBefore.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.optBefore.Location = New System.Drawing.Point(3, 3)
    Me.optBefore.Name = "optBefore"
    Me.optBefore.Size = New System.Drawing.Size(62, 18)
    Me.optBefore.TabIndex = 0
    Me.optBefore.TabStop = True
    Me.optBefore.Text = "&Before"
    Me.optBefore.UseVisualStyleBackColor = True
    '
    'optAround
    '
    Me.optAround.AutoSize = True
    Me.optAround.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.optAround.Location = New System.Drawing.Point(3, 27)
    Me.optAround.Name = "optAround"
    Me.optAround.Size = New System.Drawing.Size(65, 18)
    Me.optAround.TabIndex = 1
    Me.optAround.TabStop = True
    Me.optAround.Text = "Aro&und"
    Me.optAround.UseVisualStyleBackColor = True
    '
    'optAfter
    '
    Me.optAfter.AutoSize = True
    Me.optAfter.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.optAfter.Location = New System.Drawing.Point(3, 51)
    Me.optAfter.Name = "optAfter"
    Me.optAfter.Size = New System.Drawing.Size(53, 18)
    Me.optAfter.TabIndex = 2
    Me.optAfter.TabStop = True
    Me.optAfter.Text = "&After"
    Me.optAfter.UseVisualStyleBackColor = True
    '
    'dtFileDate
    '
    Me.dtFileDate.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtFileDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
    Me.dtFileDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFileDate.Location = New System.Drawing.Point(3, 75)
    Me.dtFileDate.Name = "dtFileDate"
    Me.dtFileDate.Size = New System.Drawing.Size(150, 20)
    Me.dtFileDate.TabIndex = 3
    Me.dtFileDate.Value = New Date(2014, 4, 8, 0, 0, 0, 0)
    '
    'chkFileDate
    '
    Me.chkFileDate.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileDate.Location = New System.Drawing.Point(6, 0)
    Me.chkFileDate.Name = "chkFileDate"
    Me.chkFileDate.Size = New System.Drawing.Size(120, 18)
    Me.chkFileDate.TabIndex = 0
    Me.chkFileDate.Text = "File Modification &Date"
    Me.chkFileDate.UseVisualStyleBackColor = True
    '
    'cmdFind
    '
    Me.cmdFind.Anchor = System.Windows.Forms.AnchorStyles.Right
    Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdFind.Location = New System.Drawing.Point(501, 143)
    Me.cmdFind.Name = "cmdFind"
    Me.cmdFind.Size = New System.Drawing.Size(80, 25)
    Me.cmdFind.TabIndex = 2
    Me.cmdFind.Text = "&Find >>"
    Me.cmdFind.UseVisualStyleBackColor = True
    '
    'pnlDirectory
    '
    Me.pnlFindIt.SetColumnSpan(Me.pnlDirectory, 2)
    Me.pnlDirectory.Controls.Add(Me.pnlDirectoryList)
    Me.pnlDirectory.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.pnlDirectory.Location = New System.Drawing.Point(351, 3)
    Me.pnlDirectory.Name = "pnlDirectory"
    Me.pnlDirectory.Size = New System.Drawing.Size(230, 134)
    Me.pnlDirectory.TabIndex = 0
    Me.pnlDirectory.TabStop = False
    Me.pnlDirectory.Text = "Search Di&rectory"
    '
    'pnlDirectoryList
    '
    Me.pnlDirectoryList.ColumnCount = 1
    Me.pnlDirectoryList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlDirectoryList.Controls.Add(Me.cmbDrive, 0, 0)
    Me.pnlDirectoryList.Controls.Add(Me.lstDir, 0, 1)
    Me.pnlDirectoryList.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlDirectoryList.Location = New System.Drawing.Point(3, 16)
    Me.pnlDirectoryList.Name = "pnlDirectoryList"
    Me.pnlDirectoryList.RowCount = 2
    Me.pnlDirectoryList.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlDirectoryList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlDirectoryList.Size = New System.Drawing.Size(224, 115)
    Me.pnlDirectoryList.TabIndex = 2
    '
    'cmbDrive
    '
    Me.cmbDrive.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmbDrive.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.cmbDrive.FormattingEnabled = True
    Me.cmbDrive.Location = New System.Drawing.Point(3, 3)
    Me.cmbDrive.Name = "cmbDrive"
    Me.cmbDrive.Size = New System.Drawing.Size(218, 21)
    Me.cmbDrive.TabIndex = 0
    '
    'lstDir
    '
    Me.lstDir.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstDir.FormattingEnabled = True
    Me.lstDir.IntegralHeight = False
    Me.lstDir.Location = New System.Drawing.Point(3, 30)
    Me.lstDir.Name = "lstDir"
    Me.lstDir.Size = New System.Drawing.Size(218, 82)
    Me.lstDir.TabIndex = 1
    '
    'chkFast
    '
    Me.chkFast.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.chkFast.AutoSize = True
    Me.chkFast.Checked = True
    Me.chkFast.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkFast.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFast.Location = New System.Drawing.Point(351, 146)
    Me.chkFast.Name = "chkFast"
    Me.chkFast.Size = New System.Drawing.Size(83, 18)
    Me.chkFast.TabIndex = 1
    Me.chkFast.Text = "Find &it Fast"
    Me.chkFast.UseVisualStyleBackColor = True
    '
    'pnlResults
    '
    Me.pnlResults.ColumnCount = 1
    Me.pnlFindIt.SetColumnSpan(Me.pnlResults, 3)
    Me.pnlResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlResults.Controls.Add(Me.lvResults, 0, 0)
    Me.pnlResults.Controls.Add(Me.sbState, 0, 1)
    Me.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlResults.Location = New System.Drawing.Point(0, 171)
    Me.pnlResults.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlResults.Name = "pnlResults"
    Me.pnlResults.RowCount = 2
    Me.pnlResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.pnlResults.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.pnlResults.Size = New System.Drawing.Size(584, 300)
    Me.pnlResults.TabIndex = 4
    '
    'lvResults
    '
    Me.lvResults.AllowDrop = True
    Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFileName, Me.colFileSize, Me.colFileDate, Me.colFilePath})
    Me.pnlResults.SetColumnSpan(Me.lvResults, 3)
    Me.lvResults.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvResults.FullRowSelect = True
    Me.lvResults.LabelEdit = True
    Me.lvResults.Location = New System.Drawing.Point(3, 3)
    Me.lvResults.Name = "lvResults"
    Me.lvResults.ShowGroups = False
    Me.lvResults.ShowItemToolTips = True
    Me.lvResults.Size = New System.Drawing.Size(578, 272)
    Me.lvResults.TabIndex = 3
    Me.lvResults.UseCompatibleStateImageBehavior = False
    Me.lvResults.View = System.Windows.Forms.View.Details
    '
    'colFileName
    '
    Me.colFileName.Text = "File Name"
    Me.colFileName.Width = 150
    '
    'colFileSize
    '
    Me.colFileSize.Text = "Size"
    Me.colFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.colFileSize.Width = 75
    '
    'colFileDate
    '
    Me.colFileDate.Text = "Date"
    Me.colFileDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.colFileDate.Width = 120
    '
    'colFilePath
    '
    Me.colFilePath.Text = "Path"
    Me.colFilePath.Width = 220
    '
    'sbState
    '
    Me.sbState.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblImage, Me.lblStatus})
    Me.sbState.Location = New System.Drawing.Point(0, 278)
    Me.sbState.Name = "sbState"
    Me.sbState.Size = New System.Drawing.Size(584, 22)
    Me.sbState.TabIndex = 4
    '
    'lblImage
    '
    Me.lblImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.lblImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.lblImage.Name = "lblImage"
    Me.lblImage.Size = New System.Drawing.Size(0, 17)
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = False
    Me.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.lblStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.lblStatus.Size = New System.Drawing.Size(569, 17)
    Me.lblStatus.Spring = True
    Me.lblStatus.Text = "Idle."
    Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'tmrListUpdate
    '
    Me.tmrListUpdate.Interval = 500
    '
    'imlIcons
    '
    Me.imlIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imlIcons.ImageSize = New System.Drawing.Size(16, 16)
    Me.imlIcons.TransparentColor = System.Drawing.Color.Transparent
    '
    'mnuFile
    '
    Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen, Me.mnuOpenFolder, Me.mnuSpace1, Me.mnuDelete, Me.mnuRename, Me.mnuSpace2, Me.mnuProperties})
    '
    'mnuOpen
    '
    Me.mnuOpen.DefaultItem = True
    Me.mnuOpen.Index = 0
    Me.mnuOpen.Text = "&Open"
    '
    'mnuOpenFolder
    '
    Me.mnuOpenFolder.Index = 1
    Me.mnuOpenFolder.Text = "Open Containing &Folder..."
    '
    'mnuSpace1
    '
    Me.mnuSpace1.Index = 2
    Me.mnuSpace1.Text = "-"
    '
    'mnuDelete
    '
    Me.mnuDelete.Index = 3
    Me.mnuDelete.Text = "&Delete"
    '
    'mnuRename
    '
    Me.mnuRename.Index = 4
    Me.mnuRename.Text = "Rena&me"
    '
    'mnuSpace2
    '
    Me.mnuSpace2.Index = 5
    Me.mnuSpace2.Text = "-"
    '
    'mnuProperties
    '
    Me.mnuProperties.Index = 6
    Me.mnuProperties.Text = "P&roperties"
    '
    'tmrSearchAnim
    '
    '
    'chkFileNameCS
    '
    Me.chkFileNameCS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkFileNameCS.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileNameCS.Location = New System.Drawing.Point(119, 19)
    Me.chkFileNameCS.Name = "chkFileNameCS"
    Me.chkFileNameCS.Size = New System.Drawing.Size(37, 16)
    Me.chkFileNameCS.TabIndex = 2
    Me.chkFileNameCS.Text = "CS"
    Me.chkFileNameCS.UseVisualStyleBackColor = True
    '
    'chkFileContentsCS
    '
    Me.chkFileContentsCS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkFileContentsCS.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.chkFileContentsCS.Location = New System.Drawing.Point(119, 17)
    Me.chkFileContentsCS.Name = "chkFileContentsCS"
    Me.chkFileContentsCS.Size = New System.Drawing.Size(38, 19)
    Me.chkFileContentsCS.TabIndex = 1
    Me.chkFileContentsCS.Text = "CS"
    Me.chkFileContentsCS.UseVisualStyleBackColor = True
    '
    'frmSearch
    '
    Me.AcceptButton = Me.cmdFind
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(584, 471)
    Me.Controls.Add(Me.pnlFindIt)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Location = New System.Drawing.Point(128, 64)
    Me.MinimumSize = New System.Drawing.Size(575, 220)
    Me.Name = "frmSearch"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "FindIt"
    Me.pnlFindIt.ResumeLayout(False)
    Me.pnlFindIt.PerformLayout()
    Me.pnlOptions.ResumeLayout(False)
    Me.pnlOptions.PerformLayout()
    Me.pnlOptionList.ResumeLayout(False)
    Me.pnlFileSize.ResumeLayout(False)
    Me.pnlFileSizeList.ResumeLayout(False)
    CType(Me.txtFileSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlFileName.ResumeLayout(False)
    Me.pnlFileName.PerformLayout()
    Me.pnlFileContents.ResumeLayout(False)
    Me.pnlFileContents.PerformLayout()
    Me.pnlFileDate.ResumeLayout(False)
    Me.pnlFileDateList.ResumeLayout(False)
    Me.pnlFileDateList.PerformLayout()
    Me.pnlDirectory.ResumeLayout(False)
    Me.pnlDirectoryList.ResumeLayout(False)
    Me.pnlResults.ResumeLayout(False)
    Me.pnlResults.PerformLayout()
    Me.sbState.ResumeLayout(False)
    Me.sbState.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlFindIt As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents pnlDirectory As System.Windows.Forms.GroupBox
  Friend WithEvents pnlOptions As System.Windows.Forms.GroupBox
  Friend WithEvents pnlOptionList As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents pnlFileSize As System.Windows.Forms.GroupBox
  Friend WithEvents pnlFileSizeList As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents cmbSizeCompare As System.Windows.Forms.ComboBox
  Friend WithEvents txtFileSizeValue As System.Windows.Forms.NumericUpDown
  Friend WithEvents cmbFileSizeScale As System.Windows.Forms.ComboBox
  Friend WithEvents chkFileSize As System.Windows.Forms.CheckBox
  Friend WithEvents pnlFileName As System.Windows.Forms.GroupBox
  Friend WithEvents txtFileName As System.Windows.Forms.TextBox
  Friend WithEvents chkFileName As System.Windows.Forms.CheckBox
  Friend WithEvents pnlFileContents As System.Windows.Forms.GroupBox
  Friend WithEvents txtFileContents As System.Windows.Forms.TextBox
  Friend WithEvents chkFileContents As System.Windows.Forms.CheckBox
  Friend WithEvents pnlFileDate As System.Windows.Forms.GroupBox
  Friend WithEvents pnlFileDateList As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents optBefore As System.Windows.Forms.RadioButton
  Friend WithEvents optAround As System.Windows.Forms.RadioButton
  Friend WithEvents optAfter As System.Windows.Forms.RadioButton
  Friend WithEvents dtFileDate As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkFileDate As System.Windows.Forms.CheckBox
  Friend WithEvents cmdFind As System.Windows.Forms.Button
  Friend WithEvents lstDir As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
  Friend WithEvents cmbDrive As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
  Friend WithEvents pnlDirectoryList As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents chkFast As System.Windows.Forms.CheckBox
  Friend WithEvents tmrListUpdate As System.Windows.Forms.Timer
  Friend WithEvents pnlResults As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lvResults As System.Windows.Forms.ListView
  Friend WithEvents colFileName As System.Windows.Forms.ColumnHeader
  Friend WithEvents colFileSize As System.Windows.Forms.ColumnHeader
  Friend WithEvents colFileDate As System.Windows.Forms.ColumnHeader
  Friend WithEvents colFilePath As System.Windows.Forms.ColumnHeader
  Friend WithEvents sbState As System.Windows.Forms.StatusStrip
  Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents imlIcons As System.Windows.Forms.ImageList
  Friend WithEvents mnuFile As System.Windows.Forms.ContextMenu
  Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
  Friend WithEvents mnuOpenFolder As System.Windows.Forms.MenuItem
  Friend WithEvents mnuSpace1 As System.Windows.Forms.MenuItem
  Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
  Friend WithEvents mnuRename As System.Windows.Forms.MenuItem
  Friend WithEvents mnuSpace2 As System.Windows.Forms.MenuItem
  Friend WithEvents mnuProperties As System.Windows.Forms.MenuItem
  Friend WithEvents tmrSearchAnim As System.Windows.Forms.Timer
  Friend WithEvents lblImage As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents chkFileNameCS As System.Windows.Forms.CheckBox
  Friend WithEvents chkFileContentsCS As System.Windows.Forms.CheckBox

End Class
