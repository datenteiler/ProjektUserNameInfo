Public Class FormUserNameInfo
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim user As New UserNameInfoClass.UserNameInfo(InfoBox.Text)
        ' Benutzernamen rückwärts ausgeben
        user.Reverse()
        MsgBox("Rückwärts: " & user.UserName, vbInformation)

    End Sub

    Private Sub FormUserNameInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class