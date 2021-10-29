Imports Renci.SshNet
Module Module1

    Public connInfo As New Renci.SshNet.PasswordConnectionInfo("premium128.web-hosting.com", 21098, "chrilyhd", "q7UvjqFs3Wkx")
    Public sshClient As New Renci.SshNet.SshClient(connInfo)
    Public portForwarded As New ForwardedPortLocal("127.0.0.1", 3314, "127.0.0.1", 3306)


End Module

