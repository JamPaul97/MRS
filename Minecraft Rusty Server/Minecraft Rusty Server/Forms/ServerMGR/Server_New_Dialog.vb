Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.IO
Public Class Server_New_Dialog
    Public Shared fileURL As String
    Dim vanillaURL As New List(Of details)
    Dim spigotURL As New List(Of details)
    Dim bukkitURL As New List(Of details)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtName.Text = "" Then
            MsgBox("You have to select a valid name for the server.")
            Exit Sub
        End If
        Select Case ComboMode.SelectedItem
            Case "Vanilla"
                If ComboVanilla.SelectedIndex = -1 Then
                    MsgBox("You have to select a version for your server.")
                    Exit Sub
                End If
            Case "Spigot"
                If ComboSpigot.SelectedIndex = -1 Then
                    MsgBox("You have to select a version for your server.")
                    Exit Sub
                End If
            Case "CraftBukkit"
                If ComboCraftBukkit.SelectedIndex = -1 Then
                    MsgBox("You have to select a version for your server.")
                    Exit Sub
                End If
        End Select




        Dim newServer As New Server_Manager.server_object
        newServer.folder = txtFolder.Text
        newServer.name = txtName.Text
        newServer.mode = ComboMode.SelectedItem
        Select Case ComboMode.SelectedItem
            Case "Vanilla"
                newServer.version = ComboVanilla.SelectedItem
                newServer.vanilla = True
            Case "Spigot"
                newServer.version = ComboSpigot.SelectedItem
                newServer.vanilla = False
            Case "CraftBukkit"
                newServer.version = ComboCraftBukkit.SelectedItem
                newServer.vanilla = False
        End Select
        Dim mgr As New Server_Manager
        Dim DLG As New SaveFileDialog
        DLG.Filter = ".mrs|*.mrs"
        If DLG.ShowDialog = DialogResult.OK Then
            mgr.saveServer(DLG.FileName, newServer)
            fileURL = DLG.FileName
        Else
            MsgBox("You have to save a valid file.")
            Exit Sub
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Server_New_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vanillaURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/VanillaJson.json"))
        spigotURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/SpigotJson.json"))
        bukkitURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/BukkitJson.Json"))
        For Each item As details In vanillaURL
            ComboVanilla.Items.Add(item.version)
        Next
        For Each item As details In spigotURL
            ComboSpigot.Items.Add(item.version)
        Next
        For Each item As details In bukkitURL
            ComboCraftBukkit.Items.Add(item.version)
        Next
        ComboMode.SelectedItem = "Vanilla"
    End Sub

    Private Sub ComboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMode.SelectedIndexChanged
        ComboVanilla.Visible = False
        ComboSpigot.Visible = False
        ComboCraftBukkit.Visible = False
        ComboVanilla.SelectedIndex = -1
        ComboSpigot.SelectedIndex = -1
        ComboCraftBukkit.SelectedIndex = -1
        Select Case ComboMode.SelectedItem
            Case "Vanilla"
                ComboVanilla.Visible = True
            Case "Spigot"
                ComboSpigot.Visible = True
            Case "CraftBukkit"
                ComboCraftBukkit.Visible = True
        End Select
    End Sub

    Private Sub ComboVanilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboVanilla.SelectedIndexChanged
        For Each item In vanillaURL
            If item.version = ComboVanilla.SelectedItem Then
                Me.Text = item.url
            End If
        Next
    End Sub

    Private Sub ComboSpigot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSpigot.SelectedIndexChanged
        For Each item In spigotURL
            If item.version = ComboSpigot.SelectedItem Then
                Me.Text = item.url
            End If
        Next
    End Sub

    Private Sub ComboCraftBukkit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCraftBukkit.SelectedIndexChanged
        For Each item In bukkitURL
            If item.version = ComboCraftBukkit.SelectedItem Then
                Me.Text = item.url
            End If
        Next
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim folderDLG As New FolderBrowserDialog
        If folderDLG.ShowDialog = DialogResult.OK Then
            txtFolder.Text = folderDLG.SelectedPath & "\"
            If Directory.GetFiles(folderDLG.SelectedPath).Count > 0 Then
                MsgBox("The folder you have selected contains files. This may cause the server to be unusable. It is advised to select an empty folder.")
            End If
        End If
    End Sub
End Class
Public Class details
    Public version As String
    Public url As String
End Class

