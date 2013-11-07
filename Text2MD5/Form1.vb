Imports System
Imports System.Security.Cryptography
Imports System.Text

Module Example

    Dim DATA_SIZE As Object



    ' Hash an input string and return the hash as
    ' a 32 character hexadecimal string.
    Function getMd5Hash(ByVal input As String) As String
        ' Create a new instance of the MD5 object.
        Dim md5Hasher As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function


    ' Verify a hash against a string.
    Function verifyMd5Hash(ByVal input As String, ByVal hash As String) As Boolean
        ' Hash the input.
        Dim hashOfInput As String = getMd5Hash(input)

        ' Create a StringComparer an comare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
Public Class Form1

    Dim DATA_SIZE As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim source As String = TextBox1.Text
        Dim hash As String = getMd5Hash(source)
        TextBox1.Text = hash

    End Sub


    Private Function SHA1CryptoServiceProvider(p1 As String) As String
        Throw New NotImplementedException
    End Function

End Class