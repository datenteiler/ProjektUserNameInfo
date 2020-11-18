Public Class UserNameInfo
    Private userNameValue As String

    Public Sub New(UserName As String)
        Me.UserName = UserName
    End Sub

    Public Property UserName() As String
        Get
            Return userNameValue
        End Get
        Set(ByVal Value As String)
            userNameValue = Value
        End Set
    End Property

    Public Sub Reverse()
        ' Den Username rückwärts ausgeben
        Dim charArray As Char() = userNameValue.ToCharArray()
        Array.Reverse(charArray)
        userNameValue = charArray
        ' Alle Buchstaben klein schreiben
        userNameValue = userNameValue.ToLower
        ' Den ersten wieder groß schreiben, wenn alles rückwärts ist
        userNameValue = userNameValue(0).ToString.ToUpper & userNameValue.Substring(1)
    End Sub

End Class