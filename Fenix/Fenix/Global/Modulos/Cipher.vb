Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module Cipher

    'FUNCION DE ENCRIPTACION SHA512

    Public Function SHA512(ByVal UsrCHex As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(UsrCHex)
        Dim b As Byte()
        Dim c As New SHA512Managed

        b = c.ComputeHash(a)

        Dim d As String = Convert.ToBase64String(b)
        Dim z As Byte() = Convert.FromBase64String(d)

        Dim sb As New StringBuilder()
        For Each p As Byte In z
            sb.Append(p.ToString("X2"))
        Next
        Return sb.ToString()

    End Function

    'FUNCION DE ENCRIPTACION AES - 128 BITS

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Dim flujo As Boolean 'Si el estado es 1 Devuelve el Hash
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            flujo = True
        Catch ex As Exception
        End Try
        If flujo = True Then
            Return encrypted
        Else
            Return encrypted = "0"
        End If
    End Function

    'FUNCION DESCRIPTCION AES - 128 BITS

    Public Function AES_Decrypt(ByVal input As String, ByVal Pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = Nothing
        Dim flujo As Boolean
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            flujo = True
        Catch ex As Exception
        End Try
        If flujo = True Then
            Return decrypted
        Else
            Return decrypted = "0"
        End If
    End Function

    'FUNCION DE ENCRIPTACION AES - 256 BITS
    Public Function Encrypt(ByVal plainText As String, ByVal secretKey As String, ByVal SaltUser As String) As String
        Dim encryptedPassword As String = Nothing
        Using outputStream As MemoryStream = New MemoryStream()
            Dim algorithm As RijndaelManaged = getAlgorithm(secretKey, SaltUser)
            Using cryptoStream As CryptoStream = New CryptoStream(outputStream, algorithm.CreateEncryptor(), CryptoStreamMode.Write)
                Dim inputBuffer() As Byte = Encoding.Unicode.GetBytes(plainText)
                cryptoStream.Write(inputBuffer, 0, inputBuffer.Length)
                cryptoStream.FlushFinalBlock()
                encryptedPassword = Convert.ToBase64String(outputStream.ToArray())
            End Using
        End Using
        Return encryptedPassword
    End Function

    'FUNCION DE DESENCRIPTADO AES - 256 BITS
    Public Function Decrypt(ByVal encryptedBytes As String, ByVal secretKey As String, ByVal SaltUser As String) As String
        Dim plainText As String = Nothing
        Using inputStream As MemoryStream = New MemoryStream(Convert.FromBase64String(encryptedBytes))
            Dim algorithm As RijndaelManaged = getAlgorithm(secretKey, SaltUser)
            Using cryptoStream As CryptoStream = New CryptoStream(inputStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read)
                Dim outputBuffer(0 To CType(inputStream.Length - 1, Integer)) As Byte
                Dim readBytes As Integer = cryptoStream.Read(outputBuffer, 0, CType(inputStream.Length, Integer))
                plainText = Encoding.Unicode.GetString(outputBuffer, 0, readBytes)
            End Using
        End Using
        Return plainText
    End Function

    Public Function getAlgorithm(ByVal secretKey As String, salt As String) As RijndaelManaged
        Const keySize As Integer = 256

        Dim keyBuilder As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes(salt))
        Dim algorithm As RijndaelManaged = New RijndaelManaged()
        algorithm.KeySize = keySize
        algorithm.IV = keyBuilder.GetBytes(CType(algorithm.BlockSize / 8, Integer))
        algorithm.Key = keyBuilder.GetBytes(CType(algorithm.KeySize / 8, Integer))
        algorithm.Padding = PaddingMode.PKCS7
        Return algorithm
    End Function

End Module
