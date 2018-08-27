<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server_New_Dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Server_New_Dialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LabelHelp1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.LabelFolder = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboMode = New System.Windows.Forms.ComboBox()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.ComboVanilla = New System.Windows.Forms.ComboBox()
        Me.ComboSpigot = New System.Windows.Forms.ComboBox()
        Me.ComboCraftBukkit = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 297)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'LabelHelp1
        '
        Me.LabelHelp1.AutoSize = True
        Me.LabelHelp1.Location = New System.Drawing.Point(22, 9)
        Me.LabelHelp1.Name = "LabelHelp1"
        Me.LabelHelp1.Size = New System.Drawing.Size(348, 91)
        Me.LabelHelp1.TabIndex = 1
        Me.LabelHelp1.Text = resources.GetString("LabelHelp1.Text")
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(22, 131)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(76, 13)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Server's Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(25, 147)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(344, 20)
        Me.txtName.TabIndex = 3
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(25, 188)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.ReadOnly = True
        Me.txtFolder.Size = New System.Drawing.Size(263, 20)
        Me.txtFolder.TabIndex = 5
        '
        'LabelFolder
        '
        Me.LabelFolder.AutoSize = True
        Me.LabelFolder.Location = New System.Drawing.Point(22, 172)
        Me.LabelFolder.Name = "LabelFolder"
        Me.LabelFolder.Size = New System.Drawing.Size(77, 13)
        Me.LabelFolder.TabIndex = 4
        Me.LabelFolder.Text = "Server's Folder"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(294, 185)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Server's Mode"
        '
        'ComboMode
        '
        Me.ComboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMode.FormattingEnabled = True
        Me.ComboMode.Items.AddRange(New Object() {"Vanilla", "Spigot", "CraftBukkit"})
        Me.ComboMode.Location = New System.Drawing.Point(25, 227)
        Me.ComboMode.Name = "ComboMode"
        Me.ComboMode.Size = New System.Drawing.Size(344, 21)
        Me.ComboMode.TabIndex = 8
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(24, 251)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(83, 13)
        Me.LabelVersion.TabIndex = 9
        Me.LabelVersion.Text = "Server's Version"
        '
        'ComboVanilla
        '
        Me.ComboVanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboVanilla.FormattingEnabled = True
        Me.ComboVanilla.Location = New System.Drawing.Point(25, 267)
        Me.ComboVanilla.Name = "ComboVanilla"
        Me.ComboVanilla.Size = New System.Drawing.Size(344, 21)
        Me.ComboVanilla.TabIndex = 10
        '
        'ComboSpigot
        '
        Me.ComboSpigot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSpigot.FormattingEnabled = True
        Me.ComboSpigot.Location = New System.Drawing.Point(25, 267)
        Me.ComboSpigot.Name = "ComboSpigot"
        Me.ComboSpigot.Size = New System.Drawing.Size(344, 21)
        Me.ComboSpigot.TabIndex = 11
        '
        'ComboCraftBukkit
        '
        Me.ComboCraftBukkit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCraftBukkit.FormattingEnabled = True
        Me.ComboCraftBukkit.Location = New System.Drawing.Point(25, 267)
        Me.ComboCraftBukkit.Name = "ComboCraftBukkit"
        Me.ComboCraftBukkit.Size = New System.Drawing.Size(344, 21)
        Me.ComboCraftBukkit.TabIndex = 12
        '
        'Server_New_Dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(390, 338)
        Me.Controls.Add(Me.ComboCraftBukkit)
        Me.Controls.Add(Me.ComboSpigot)
        Me.Controls.Add(Me.ComboVanilla)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.ComboMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.LabelFolder)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelHelp1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Server_New_Dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Server"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelHelp1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtFolder As TextBox
    Friend WithEvents LabelFolder As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboMode As ComboBox
    Friend WithEvents LabelVersion As Label
    Friend WithEvents ComboVanilla As ComboBox
    Friend WithEvents ComboSpigot As ComboBox
    Friend WithEvents ComboCraftBukkit As ComboBox
End Class
