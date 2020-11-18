Imports System
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Namespace UserNameInfo
    <Cmdlet(VerbsCommon.Get, "UserNameInfo")>
    Public Class UserNameInfoCommand
        Inherits PSCmdlet

        Private _Name As String()
        <Parameter(Position:=0, Mandatory:=True,
        ValueFromPipeline:=True,
        ValueFromPipelineByPropertyName:=True),
        ValidateNotNullOrEmpty()>
        Public Property Name() As String() '
            Get
                Return _Name
            End Get
            Set(ByVal value As String())
                _Name = value
            End Set
        End Property

        Protected Overrides Sub ProcessRecord()
            Dim user As New UserNameInfoClass.UserNameInfo(String.Join(" ", _Name))
            ' Benutzernamen rückwärts ausgeben
            user.Reverse()
            WriteObject(user)
        End Sub
    End Class
End Namespace