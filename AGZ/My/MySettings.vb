Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace ssh.My
	<CompilerGenerated>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")>
	Friend NotInheritable Class MySettings
		Inherits ApplicationSettingsBase
		Private Shared defaultInstance As MySettings

		Private Shared addedHandler As Boolean

		Private Shared addedHandlerLockObject As Object

		<ApplicationScopedSetting>
		<DebuggerNonUserCode>
		<DefaultSettingValue("sshhostname=premium128.web-hosting.com;sshpassword=q7UvjqFs3Wkx;sshusername=chrilyhd;server=127.0.0.1;user id=chrilyhd_sifagz;password=H7aSK-$6jXKB;sshport=21098;database=chrilyhd_matriculaagz")>
		<SpecialSetting(SpecialSetting.ConnectionString)>
		Public ReadOnly Property chrilyhd_matriculaagzConnectionString As String
			Get
				Return Conversions.ToString(Me("chrilyhd_matriculaagzConnectionString"))
			End Get
		End Property

		<ApplicationScopedSetting>
		<DebuggerNonUserCode>
		<DefaultSettingValue("server=127.0.0.1;user id=root;password=password123;database=colegioagz")>
		<SpecialSetting(SpecialSetting.ConnectionString)>
		Public ReadOnly Property colegioagzConnectionString As String
			Get
				Return Conversions.ToString(Me("colegioagzConnectionString"))
			End Get
		End Property

		Public ReadOnly Shared Property [Default] As MySettings
			Get
				If (Not MySettings.addedHandler) Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					Dim flag As Boolean = False
					Try
						Monitor.Enter(obj, flag)
						If (Not MySettings.addedHandler) Then
							AddHandler MyProject.Application.Shutdown,  New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
							MySettings.addedHandler = True
						End If
					Finally
						If (flag) Then
							Monitor.[Exit](obj)
						End If
					End Try
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		Shared Sub New()
			MySettings.defaultInstance = DirectCast(SettingsBase.Synchronized(New MySettings()), MySettings)
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(New Object())
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		<DebuggerNonUserCode>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
			If (MyProject.Application.SaveMySettingsOnExit) Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub
	End Class
End Namespace