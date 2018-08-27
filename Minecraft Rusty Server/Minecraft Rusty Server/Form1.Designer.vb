<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadedServer = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnProperties = New System.Windows.Forms.Button()
        Me.btnDownloadJar = New System.Windows.Forms.Button()
        Me.LabelServerJar = New System.Windows.Forms.Label()
        Me.LabelProperty = New System.Windows.Forms.Label()
        Me.LabelMode = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelFolder = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.PanelUnloaded = New System.Windows.Forms.Panel()
        Me.AsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.LoadedServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.AsdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(346, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'LoadedServer
        '
        Me.LoadedServer.Controls.Add(Me.Button1)
        Me.LoadedServer.Controls.Add(Me.BtnProperties)
        Me.LoadedServer.Controls.Add(Me.btnDownloadJar)
        Me.LoadedServer.Controls.Add(Me.LabelServerJar)
        Me.LoadedServer.Controls.Add(Me.LabelProperty)
        Me.LoadedServer.Controls.Add(Me.LabelMode)
        Me.LoadedServer.Controls.Add(Me.LabelVersion)
        Me.LoadedServer.Controls.Add(Me.LabelFolder)
        Me.LoadedServer.Controls.Add(Me.LabelName)
        Me.LoadedServer.Enabled = False
        Me.LoadedServer.Location = New System.Drawing.Point(12, 27)
        Me.LoadedServer.Name = "LoadedServer"
        Me.LoadedServer.Size = New System.Drawing.Size(324, 246)
        Me.LoadedServer.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Start Server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnProperties
        '
        Me.BtnProperties.Location = New System.Drawing.Point(118, 93)
        Me.BtnProperties.Name = "BtnProperties"
        Me.BtnProperties.Size = New System.Drawing.Size(106, 23)
        Me.BtnProperties.TabIndex = 8
        Me.BtnProperties.Text = "Server Properties"
        Me.BtnProperties.UseVisualStyleBackColor = True
        '
        'btnDownloadJar
        '
        Me.btnDownloadJar.Location = New System.Drawing.Point(6, 93)
        Me.btnDownloadJar.Name = "btnDownloadJar"
        Me.btnDownloadJar.Size = New System.Drawing.Size(106, 23)
        Me.btnDownloadJar.TabIndex = 6
        Me.btnDownloadJar.Text = "Download Server"
        Me.btnDownloadJar.UseVisualStyleBackColor = True
        '
        'LabelServerJar
        '
        Me.LabelServerJar.AutoSize = True
        Me.LabelServerJar.Location = New System.Drawing.Point(3, 77)
        Me.LabelServerJar.Name = "LabelServerJar"
        Me.LabelServerJar.Size = New System.Drawing.Size(39, 13)
        Me.LabelServerJar.TabIndex = 5
        Me.LabelServerJar.Text = "Label1"
        '
        'LabelProperty
        '
        Me.LabelProperty.AutoSize = True
        Me.LabelProperty.Location = New System.Drawing.Point(3, 64)
        Me.LabelProperty.Name = "LabelProperty"
        Me.LabelProperty.Size = New System.Drawing.Size(39, 13)
        Me.LabelProperty.TabIndex = 4
        Me.LabelProperty.Text = "Label1"
        '
        'LabelMode
        '
        Me.LabelMode.AutoSize = True
        Me.LabelMode.Location = New System.Drawing.Point(3, 38)
        Me.LabelMode.Name = "LabelMode"
        Me.LabelMode.Size = New System.Drawing.Size(39, 13)
        Me.LabelMode.TabIndex = 3
        Me.LabelMode.Text = "Label1"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(3, 51)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(39, 13)
        Me.LabelVersion.TabIndex = 2
        Me.LabelVersion.Text = "Label1"
        '
        'LabelFolder
        '
        Me.LabelFolder.AutoSize = True
        Me.LabelFolder.Location = New System.Drawing.Point(3, 25)
        Me.LabelFolder.Name = "LabelFolder"
        Me.LabelFolder.Size = New System.Drawing.Size(39, 13)
        Me.LabelFolder.TabIndex = 1
        Me.LabelFolder.Text = "Label1"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(3, 12)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(39, 13)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Label1"
        '
        'PanelUnloaded
        '
        Me.PanelUnloaded.Location = New System.Drawing.Point(12, 27)
        Me.PanelUnloaded.Name = "PanelUnloaded"
        Me.PanelUnloaded.Size = New System.Drawing.Size(324, 246)
        Me.PanelUnloaded.TabIndex = 7
        '
        'AsdToolStripMenuItem
        '
        Me.AsdToolStripMenuItem.Name = "AsdToolStripMenuItem"
        Me.AsdToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.AsdToolStripMenuItem.Text = "asd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 285)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LoadedServer)
        Me.Controls.Add(Me.PanelUnloaded)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minecraft Rusty Server"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.LoadedServer.ResumeLayout(False)
        Me.LoadedServer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadedServer As Panel
    Friend WithEvents LabelMode As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelFolder As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelProperty As Label
    Friend WithEvents LabelServerJar As Label
    Friend WithEvents btnDownloadJar As Button
    Friend WithEvents PanelUnloaded As Panel
    Friend WithEvents BtnProperties As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AsdToolStripMenuItem As ToolStripMenuItem
End Class
