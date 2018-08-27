Imports System.IO
Imports System.Text
Imports System.Collections
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Public Class Server_Manager

    <Serializable()> Public Class server_object
        Public name As String
        Public folder As String
        Public version As String = "1.13"
        Public mode As String
        Public vanilla As Boolean = True
    End Class
    Public Sub saveServer(ByVal pFile As String, ByVal pClass As server_object)
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream(pFile, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, pClass)
        s.Close()
    End Sub
    Public Function loadServer(ByVal pFile As String)
        Dim f As Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim s As IO.Stream
        f = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        s = New IO.FileStream(pFile, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
        Dim a = (DirectCast(f.Deserialize(s), Object))
        s.Close()
        Return (a)
    End Function
    Public Shared Function getTextFromUrl(ByVal pURL As String)
        Try
            Dim address As String = pURL
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Return (reader.ReadToEnd)
        Catch ex As Exception
            Return (ex.Message)
        End Try

    End Function
End Class
