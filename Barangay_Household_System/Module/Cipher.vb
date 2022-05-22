Module Cipher
    Function Caesar_Cipher(ByVal Text As String, ByVal N As Integer, ByVal Encryption As Boolean)
        Dim Result As String = ""

        For Each c As Char In Text
            Dim x As Integer
            If Encryption Then
                x = Asc(c) + N
            Else
                x = Asc(c) + 26 - N
            End If

            If Char.IsLower(c) Then
                If x > Asc("z") Then
                    x -= 26
                End If
                Result += Chr(x)
            ElseIf Char.IsUpper(c) Then
                If x > Asc("Z") Then
                    x -= 26
                End If
                Result += Chr(x)
            Else
                Result += c
            End If

        Next

        Return Result
    End Function
End Module
