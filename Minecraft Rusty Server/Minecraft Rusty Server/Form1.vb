Imports System.IO
Imports Newtonsoft.Json
Imports System

Public Class Form1
    Dim Manager As New Server_Manager
    Dim url As String
    Dim version As String
    Dim mode As String
    Dim jarPath As String
    Dim folder As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim a As New Server_New_Dialog
        If a.ShowDialog = DialogResult.OK Then
            loadServer(a.fileURL)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim DLG As New OpenFileDialog
        DLG.Filter = ".mrs|*.mrs"
        If DLG.ShowDialog = DialogResult.OK Then
            loadServer(DLG.FileName)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub loadServer(ByVal pFile As String)
        Dim loaded As Server_Manager.server_object = Manager.loadServer(pFile)
        LabelName.Text = "Server Name : " & loaded.name
        LabelFolder.Text = "Server Folder : " & loaded.folder
        jarPath = loaded.folder & "server.jar"
        LabelVersion.Text = "Server Version : " & loaded.version
        version = loaded.version
        folder = loaded.folder
        LabelMode.Text = "Server Mode : " & loaded.mode
        mode = loaded.mode
        Select Case mode
            Case "Vanilla"
                Dim vanillaURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/VanillaJson.json"))
                For Each item In vanillaURL
                    If item.version = version Then
                        url = item.url
                    End If
                Next
            Case "Spigot"
                Dim spigotURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/SpigotJson.json"))
                For Each item In spigotURL
                    If item.version = version Then
                        url = item.url
                    End If
                Next
            Case "CraftBukkit"
                Dim bukkitURL = JsonConvert.DeserializeObject(Of List(Of details))(Server_Manager.getTextFromUrl("https://raw.githubusercontent.com/JamPaul97/MRS/master/Files/BukkitJson.Json"))
                For Each item In bukkitURL
                    If item.version = version Then
                        url = item.url
                    End If
                Next
        End Select
        If File.Exists(loaded.folder & "server.properties") Then
            LabelProperty.Text = "Properties File Found."
            LabelProperty.ForeColor = Color.Green
        Else
            LabelProperty.Text = "No properties file found"
            LabelProperty.ForeColor = Color.Red
        End If
        If File.Exists(loaded.folder & "server.jar") Then
            LabelServerJar.Text = "Server Jar File Found."
            LabelServerJar.ForeColor = Color.Green
        Else
            LabelServerJar.Text = "Server Jar File Not Found."
            LabelServerJar.ForeColor = Color.Red
        End If
        LoadedServer.Enabled = True
        BtnProperties.Visible = True
        BtnProperties.Enabled = True
        PanelUnloaded.Visible = False
    End Sub

    Private Sub btnDownloadJar_Click(sender As Object, e As EventArgs) Handles btnDownloadJar.Click
        If File.Exists(jarPath) Then
            If MessageBox.Show(Me, "There is a server.jar file already in folder. Do you want to redownload it?", "Download?", vbYesNo) = DialogResult.Yes Then
                Try
                    File.Delete(jarPath)
                    downloadJar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
        Else
            downloadJar()
        End If
    End Sub
    Private Sub downloadJar()
        Dim downloadMGR As New DownloadManager
        downloadMGR.url = url
        downloadMGR.filePath = jarPath
        If downloadMGR.ShowDialog = DialogResult.OK Then
            MsgBox("Server jar has been downloaded.")
        End If
    End Sub
    Public Sub loadProperties(ByVal pClass As Server_Properties_Class.properties_object)
        Dim window As New Server_Properties_Editor
        window.obj = pClass
        window.folder = folder
        If window.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnProperties_Click(sender As Object, e As EventArgs) Handles BtnProperties.Click
        If File.Exists(folder & "server.prop") Then
            Dim newPro As Server_Properties_Class.properties_object
            newPro = Server_Properties_Class.getObjectFromFile(folder & "server.prop")
            loadProperties(newPro)
        Else
            Dim newPro As Server_Properties_Class.properties_object
            newPro = Server_Properties_Class.getDefaultProperties
            loadProperties(newPro)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists(folder & "server.prop") Then
            Dim str = Server_Properties_Class.getPropertiesFile(Server_Properties_Class.getObjectFromFile(folder & "server.prop"))
            Server_Properties_Class.saveSTRtoFile(str, folder)
        Else
            Dim str = Server_Properties_Class.getPropertiesFile(Server_Properties_Class.getDefaultProperties())
            Server_Properties_Class.saveSTRtoFile(str, folder)
        End If
        If File.Exists(folder & "server.jar") Then
        Else
            downloadJar()
        End If
        My.Settings.Folder = folder
        My.Settings.Version = version
        If File.Exists(folder & "eula.txt") Then
            File.Delete(folder & "eula.txt")
            Dim str As String = "eula=true"
            File.WriteAllText(folder & "eula.txt", str)
        Else
            Dim str As String = "eula=true"
            File.WriteAllText(folder & "eula.txt", str)
        End If

        Server_Form.Show()
        Me.Dispose()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AsdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsdToolStripMenuItem.Click
        Dim ms As MineStat = New MineStat("127.0.0.1", 25565)
        Console.WriteLine("Minecraft server status of {0} on port {1}:", ms.Address, ms.Port)

        If ms.ServerUp Then
            Console.WriteLine("Server is online running version {0} with {1} out of {2} players.", ms.Version, ms.CurrentPlayers, ms.MaximumPlayers)
            Console.WriteLine("Message of the day: {0}", ms.Motd)
        Else
            Console.WriteLine("Server is offline!")
        End If
    End Sub
End Class
