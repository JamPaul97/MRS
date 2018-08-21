Imports System.IO
Imports System.Text
Imports System.Collections
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
        Return (DirectCast(f.Deserialize(s), Object))
        s.Close()
    End Function
End Class
