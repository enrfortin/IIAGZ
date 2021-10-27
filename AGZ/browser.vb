Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace ssh
    <DesignerGenerated>
    Public Class browser
        Inherits Form
        Private components As IContainer

        Friend WithEvents Timer1 As Timer
        Friend WithEvents WebBrowser1 As WebBrowser


        Private Sub browser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.Timer1.Start()
        End Sub


        <System.Diagnostics.DebuggerStepThrough()>
        Public Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.WebBrowser1 = New WebBrowser()
            Me.Timer1 = New Timer(Me.components)
            Me.SuspendLayout()
            Me.WebBrowser1.Dock = DockStyle.Fill
            Me.WebBrowser1.Location = New Point(0, 0)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(1289, 608)
            Me.WebBrowser1.TabIndex = 0
            Me.WebBrowser1.Url = New Uri("mailto:admin@sifhn.com?Subject=Soporte%20Sistema%20Matricula", UriKind.Absolute)
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Color.White
            Me.ClientSize = New System.Drawing.Size(1289, 608)
            Me.Controls.Add(Me.WebBrowser1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "browser"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "https://sifhn.com"
            Me.WindowState = FormWindowState.Maximized
            Me.ResumeLayout(False)
        End Sub

        Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
            MyBase.Close()
        End Sub
    End Class
End Namespace