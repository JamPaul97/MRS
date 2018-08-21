Public Class File_Manager

    Public Class whitelist_object
            Public uuid As String
            Public name As String
        End Class
        Public Class banned_players_object
            Public uuid As String
            Public name As String
            Public created As String
            Public source As String
            Public expires As String
            Public reason As String
        End Class
        Public Class banned_ip_object
            Public ip As String
            Public created As String
            Public source As String
            Public expires As String
            Public reason As String
        End Class
        Public Class ops_object
            Public uuid As String
            Public name As String
            Public level As Integer
            Public BypassPlayerLimit As Boolean
        End Class

End Class

