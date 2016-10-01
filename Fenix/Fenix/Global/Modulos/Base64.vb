Module Base64
    Public Function Encode64(ByVal PlainText As String) As String
        Dim Base64Codigicado As String = Nothing
        Base64Codigicado = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(PlainText))
        Return Base64Codigicado
    End Function
    Public Function Decode64(ByVal Encodes As String) As String
        Dim Base64Decodificado As String = Nothing
        Base64Decodificado = New System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(Encodes))
        Return Base64Decodificado
    End Function
End Module
