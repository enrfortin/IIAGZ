Imports Microsoft.VisualBasic.ApplicationServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace ssh.My
	<EditorBrowsable(EditorBrowsableState.Never)>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase
		<DebuggerStepThrough>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyBase.IsSingleInstance = True
			MyBase.EnableVisualStyles = True
			MyBase.SaveMySettingsOnExit = True
			MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		<DebuggerHidden>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		<STAThread>
		Friend Shared Sub Main(ByVal Args As String())
			Try
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
            Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

        Private Sub SetCompatibleTextRenderingDefault(useCompatibleTextRendering As Boolean)
            Throw New NotImplementedException()
        End Sub

        <DebuggerStepThrough>
        Protected Overrides Sub OnCreateMainForm()
			MyBase.MainForm = MyProject.Forms.Form1
		End Sub
	End Class
End Namespace