<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUserNameInfo
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InfoBox = New System.Windows.Forms.TextBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InfoBox
        '
        Me.InfoBox.Location = New System.Drawing.Point(24, 30)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(240, 20)
        Me.InfoBox.TabIndex = 0
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(24, 76)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "User"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'FormUserNameInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 126)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.InfoBox)
        Me.Name = "FormUserNameInfo"
        Me.Text = "Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoBox As TextBox
    Friend WithEvents btnInfo As Button

End Class
