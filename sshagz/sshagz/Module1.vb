Imports Microsoft.VisualBasic.CompilerServices
Imports Renci.SshNet
Imports System


Friend Module Module1
		Public connInfo As PasswordConnectionInfo

		Public sshClient As Renci.SshNet.SshClient

		Public portForwarded As ForwardedPortLocal

		Sub New()
			Module1.connInfo = New PasswordConnectionInfo("premium128.web-hosting.com", 21098, "chrilyhd", "q7UvjqFs3Wkx")
			Module1.sshClient = New Renci.SshNet.SshClient(Module1.connInfo)
			Module1.portForwarded = New ForwardedPortLocal("127.0.0.1", 3314, "127.0.0.1", 3306)
		End Sub
	End Module
