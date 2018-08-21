Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Server_New_Dialog
    Dim vanillaURL As New List(Of details)
    Dim spigotURL As New List(Of details)
    Dim bukkitURL As New List(Of details)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Server_New_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vanillaSTR As String
        Dim spigotSTR As String
        Dim bukkitSTR As String

    End Sub
End Class
Public Class details
    Public version As String
    Public url As String
End Class

