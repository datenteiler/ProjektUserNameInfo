# Projekt UserNameInfo

Das Projekt UserNameInfo ist ein Beispiel-Projekt in VB.NET für Visual Studio 2019, um eine Windows-Anwendung zusammen mit einem PowerShell-Cmdlet zu bauen.

Das Projekt kann in Visual Studio geladen und erstellt werden. Am Ende hat man 3 .NET-Assemblies:

* Klasse mit Anwendungslogik: UserNameInfoClass\bin\Debug\netstandard2.0\UserNameInfoClass.dll
* Ausführbares Programm: UserNameInfo\bin\Debug\UserNameInfo.exe
* PowerShell Cmdlet: UserNameInfoCmdlet\bin\Debug\netstandard2.0\UserNameInfoCmdlet.dll

Cmdlet und ausführbares Programm erben von der Klasse mit der Anwendungslogik und können beide den Benutzernamen rückwärts ausgeben.

So hat man einmal eine Lösung für den Mitarbeiter im Helpdesk, der vielleicht nur bei einem  User, nämlich dem, der sich bei ihm meldet und fragt, wie sein Nutzername rückwärts lautet und ein Cmdlet für Administratoren, die mehrere Benutzernamen auf einmal verarbeiten müssen.
