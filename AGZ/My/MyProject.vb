Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports ssh
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ssh.My
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName>
	Friend Module MyProject
		Private ReadOnly m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer)

		Private ReadOnly m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication)

		Private ReadOnly m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User)

		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)

		Private ReadOnly m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)

		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As Microsoft.VisualBasic.ApplicationServices.User
			<DebuggerHidden>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		Sub New()
			MyProject.m_ComputerObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()
			MyProject.m_AppObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()
			MyProject.m_UserObjectProvider = New MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User)()
			MyProject.m_MyFormsObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()
			MyProject.m_MyWebServicesObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()
		End Sub

		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			<ThreadStatic>
			Private Shared m_FormBeingCreated As Hashtable

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_browserx As browser

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_buscarx As buscar

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_buscar_fichax As buscar_ficha

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_contratosx As contratos

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_Cyf3x As Cyf3

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_ficha_matriculax As ficha_matricula

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_Form1x As Form1

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratobchx As formcontratobch

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratocuartox As formcontratocuarto

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratoCYFx As formcontratoCYF

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratocyf2x As formcontratocyf2

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratodiezinformaticax As formcontratodiezinformatica

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratodoceinformaticax As formcontratodoceinformatica

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratojardinx As formcontratojardin

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratonovenox As formcontratonoveno

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratooctavox As formcontratooctavo

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratooncebchx As formcontratooncebch

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratoonceinformaticax As formcontratoonceinformatica

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratopreparatotiax As formcontratopreparatotia

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratoprimerox As formcontratoprimero

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratoquintox As formcontratoquinto

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratosegundox As formcontratosegundo

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratoseptimox As formcontratoseptimo

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratosextox As formcontratosexto

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_formcontratotercerox As formcontratotercero

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_listadox As listado

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_Registrox As Registro

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_todos_registrosx As todos_registros

            Public Property browserx As browser
                <DebuggerHidden>
                Get
                    Me.m_browser = MyProject.MyForms.Create__Instance__(Of browser)(Me.m_browser)
                    Return Me.m_browser
                End Get
                <DebuggerHidden>
                Set(ByVal value As browser)
                    If (value IsNot Me.m_browser) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of browser)(Me.m_browser)
                    End If
                End Set
            End Property

            Public Property buscarx As buscar
				<DebuggerHidden>
				Get
					Me.m_buscar = MyProject.MyForms.Create__Instance__(Of buscar)(Me.m_buscar)
					Return Me.m_buscar
				End Get
				<DebuggerHidden>
				Set(ByVal value As buscar)
                    If (value IsNot Me.m_buscar) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of buscar)(Me.m_buscar)
                    End If
                End Set
			End Property

            Public Property buscar_fichax As buscar_ficha
                <DebuggerHidden>
                Get
                    Me.m_buscar_ficha = MyProject.MyForms.Create__Instance__(Of buscar_ficha)(Me.m_buscar_ficha)
                    Return Me.m_buscar_ficha
                End Get
                <DebuggerHidden>
                Set(ByVal value As buscar_ficha)
                    If (value IsNot Me.m_buscar_ficha) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of buscar_ficha)(Me.m_buscar_ficha)
                    End If
                End Set
            End Property

            Public Property contratosx As contratos
                <DebuggerHidden>
                Get
                    Me.m_contratos = MyProject.MyForms.Create__Instance__(Of contratos)(Me.m_contratos)
                    Return Me.m_contratos
                End Get
                <DebuggerHidden>
                Set(ByVal value As contratos)
                    If (value IsNot Me.m_contratos) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of contratos)(Me.m_contratos)
                    End If
                End Set
            End Property

            Public Property Cyf3x As Cyf3
                <DebuggerHidden>
                Get
                    Me.m_Cyf3 = MyProject.MyForms.Create__Instance__(Of Cyf3)(Me.m_Cyf3)
                    Return Me.m_Cyf3
                End Get
                <DebuggerHidden>
                Set(ByVal value As Cyf3)
                    If (value IsNot Me.m_Cyf3) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Cyf3)(Me.m_Cyf3)
                    End If
                End Set
            End Property

            Public Property ficha_matriculax As ficha_matricula
                <DebuggerHidden>
                Get
                    Me.m_ficha_matricula = MyProject.MyForms.Create__Instance__(Of ficha_matricula)(Me.m_ficha_matricula)
                    Return Me.m_ficha_matricula
                End Get
                <DebuggerHidden>
                Set(ByVal value As ficha_matricula)
                    If (value IsNot Me.m_ficha_matricula) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of ficha_matricula)(Me.m_ficha_matricula)
                    End If
                End Set
            End Property

            Public Property Form1x As Form1
                <DebuggerHidden>
                Get
                    Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
                    Return Me.m_Form1
                End Get
                <DebuggerHidden>
                Set(ByVal value As Form1)
                    If (value IsNot Me.m_Form1) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
                    End If
                End Set
            End Property

            Public Property formcontratobchx As formcontratobch
                <DebuggerHidden>
                Get
                    Me.m_formcontratobch = MyProject.MyForms.Create__Instance__(Of formcontratobch)(Me.m_formcontratobch)
                    Return Me.m_formcontratobch
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratobch)
                    If (value IsNot Me.m_formcontratobch) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratobch)(Me.m_formcontratobch)
                    End If
                End Set
            End Property

            Public Property formcontratocuartox As formcontratocuarto
                <DebuggerHidden>
                Get
                    Me.m_formcontratocuarto = MyProject.MyForms.Create__Instance__(Of formcontratocuarto)(Me.m_formcontratocuarto)
                    Return Me.m_formcontratocuarto
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratocuarto)
                    If (value IsNot Me.m_formcontratocuarto) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratocuarto)(Me.m_formcontratocuarto)
                    End If
                End Set
            End Property

            Public Property formcontratoCYFx As formcontratoCYF
                <DebuggerHidden>
                Get
                    Me.m_formcontratoCYF = MyProject.MyForms.Create__Instance__(Of formcontratoCYF)(Me.m_formcontratoCYF)
                    Return Me.m_formcontratoCYF
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratoCYF)
                    If (value IsNot Me.m_formcontratoCYF) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratoCYF)(Me.m_formcontratoCYF)
                    End If
                End Set
            End Property

            Public Property formcontratocyf2x As formcontratocyf2
                <DebuggerHidden>
                Get
                    Me.m_formcontratocyf2 = MyProject.MyForms.Create__Instance__(Of formcontratocyf2)(Me.m_formcontratocyf2)
                    Return Me.m_formcontratocyf2
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratocyf2)
                    If (value IsNot Me.m_formcontratocyf2) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratocyf2)(Me.m_formcontratocyf2)
                    End If
                End Set
            End Property

            Public Property formcontratodiezinformaticax As formcontratodiezinformatica
                <DebuggerHidden>
                Get
                    Me.m_formcontratodiezinformatica = MyProject.MyForms.Create__Instance__(Of formcontratodiezinformatica)(Me.m_formcontratodiezinformatica)
                    Return Me.m_formcontratodiezinformatica
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratodiezinformatica)
                    If (value IsNot Me.m_formcontratodiezinformatica) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratodiezinformatica)(Me.m_formcontratodiezinformatica)
                    End If
                End Set
            End Property

            Public Property formcontratodoceinformaticax As formcontratodoceinformatica
                <DebuggerHidden>
                Get
                    Me.m_formcontratodoceinformatica = MyProject.MyForms.Create__Instance__(Of formcontratodoceinformatica)(Me.m_formcontratodoceinformatica)
                    Return Me.m_formcontratodoceinformatica
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratodoceinformatica)
                    If (value IsNot Me.m_formcontratodoceinformatica) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratodoceinformatica)(Me.m_formcontratodoceinformatica)
                    End If
                End Set
            End Property

            Public Property formcontratojardinx As formcontratojardin
                <DebuggerHidden>
                Get
                    Me.m_formcontratojardin = MyProject.MyForms.Create__Instance__(Of formcontratojardin)(Me.m_formcontratojardin)
                    Return Me.m_formcontratojardin
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratojardin)
                    If (value IsNot Me.m_formcontratojardin) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratojardin)(Me.m_formcontratojardin)
                    End If
                End Set
            End Property

            Public Property formcontratonovenox As formcontratonoveno
                <DebuggerHidden>
                Get
                    Me.m_formcontratonoveno = MyProject.MyForms.Create__Instance__(Of formcontratonoveno)(Me.m_formcontratonoveno)
                    Return Me.m_formcontratonoveno
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratonoveno)
                    If (value IsNot Me.m_formcontratonoveno) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratonoveno)(Me.m_formcontratonoveno)
                    End If
                End Set
            End Property

            Public Property formcontratooctavox As formcontratooctavo
                <DebuggerHidden>
                Get
                    Me.m_formcontratooctavo = MyProject.MyForms.Create__Instance__(Of formcontratooctavo)(Me.m_formcontratooctavo)
                    Return Me.m_formcontratooctavo
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratooctavo)
                    If (value IsNot Me.m_formcontratooctavo) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratooctavo)(Me.m_formcontratooctavo)
                    End If
                End Set
            End Property

            Public Property formcontratooncebchx As formcontratooncebch
                <DebuggerHidden>
                Get
                    Me.m_formcontratooncebch = MyProject.MyForms.Create__Instance__(Of formcontratooncebch)(Me.m_formcontratooncebch)
                    Return Me.m_formcontratooncebch
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratooncebch)
                    If (value IsNot Me.m_formcontratooncebch) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratooncebch)(Me.m_formcontratooncebch)
                    End If
                End Set
            End Property

            Public Property formcontratoonceinformaticax As formcontratoonceinformatica
                <DebuggerHidden>
                Get
                    Me.m_formcontratoonceinformatica = MyProject.MyForms.Create__Instance__(Of formcontratoonceinformatica)(Me.m_formcontratoonceinformatica)
                    Return Me.m_formcontratoonceinformatica
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratoonceinformatica)
                    If (value IsNot Me.m_formcontratoonceinformatica) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratoonceinformatica)(Me.m_formcontratoonceinformatica)
                    End If
                End Set
            End Property

            Public Property formcontratopreparatotiax As formcontratopreparatotia
                <DebuggerHidden>
                Get
                    Me.m_formcontratopreparatotia = MyProject.MyForms.Create__Instance__(Of formcontratopreparatotia)(Me.m_formcontratopreparatotia)
                    Return Me.m_formcontratopreparatotia
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratopreparatotia)
                    If (value IsNot Me.m_formcontratopreparatotia) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratopreparatotia)(Me.m_formcontratopreparatotia)
                    End If
                End Set
            End Property

            Public Property formcontratoprimerox As formcontratoprimero
                <DebuggerHidden>
                Get
                    Me.m_formcontratoprimero = MyProject.MyForms.Create__Instance__(Of formcontratoprimero)(Me.m_formcontratoprimero)
                    Return Me.m_formcontratoprimero
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratoprimero)
                    If (value IsNot Me.m_formcontratoprimero) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratoprimero)(Me.m_formcontratoprimero)
                    End If
                End Set
            End Property

            Public Property formcontratoquintox As formcontratoquinto
                <DebuggerHidden>
                Get
                    Me.m_formcontratoquinto = MyProject.MyForms.Create__Instance__(Of formcontratoquinto)(Me.m_formcontratoquinto)
                    Return Me.m_formcontratoquinto
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratoquinto)
                    If (value IsNot Me.m_formcontratoquinto) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratoquinto)(Me.m_formcontratoquinto)
                    End If
                End Set
            End Property

            Public Property formcontratosegundox As formcontratosegundo
                <DebuggerHidden>
                Get
                    Me.m_formcontratosegundo = MyProject.MyForms.Create__Instance__(Of formcontratosegundo)(Me.m_formcontratosegundo)
                    Return Me.m_formcontratosegundo
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratosegundo)
                    If (value IsNot Me.m_formcontratosegundo) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratosegundo)(Me.m_formcontratosegundo)
                    End If
                End Set
            End Property

            Public Property formcontratoseptimox As formcontratoseptimo
                <DebuggerHidden>
                Get
                    Me.m_formcontratoseptimo = MyProject.MyForms.Create__Instance__(Of formcontratoseptimo)(Me.m_formcontratoseptimo)
                    Return Me.m_formcontratoseptimo
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratoseptimo)
                    If (value IsNot Me.m_formcontratoseptimo) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratoseptimo)(Me.m_formcontratoseptimo)
                    End If
                End Set
            End Property

            Public Property formcontratosextox As formcontratosexto
                <DebuggerHidden>
                Get
                    Me.m_formcontratosexto = MyProject.MyForms.Create__Instance__(Of formcontratosexto)(Me.m_formcontratosexto)
                    Return Me.m_formcontratosexto
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratosexto)
                    If (value IsNot Me.m_formcontratosexto) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratosexto)(Me.m_formcontratosexto)
                    End If
                End Set
            End Property

            Public Property formcontratotercerox As formcontratotercero
                <DebuggerHidden>
                Get
                    Me.m_formcontratotercero = MyProject.MyForms.Create__Instance__(Of formcontratotercero)(Me.m_formcontratotercero)
                    Return Me.m_formcontratotercero
                End Get
                <DebuggerHidden>
                Set(ByVal value As formcontratotercero)
                    If (value IsNot Me.m_formcontratotercero) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of formcontratotercero)(Me.m_formcontratotercero)
                    End If
                End Set
            End Property

            Public Property listadox As listado
                <DebuggerHidden>
                Get
                    Me.m_listado = MyProject.MyForms.Create__Instance__(Of listado)(Me.m_listado)
                    Return Me.m_listado
                End Get
                <DebuggerHidden>
                Set(ByVal value As listado)
                    If (value IsNot Me.m_listado) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of listado)(Me.m_listado)
                    End If
                End Set
            End Property

            Public Property Registrox As Registro
                <DebuggerHidden>
                Get
                    Me.m_Registro = MyProject.MyForms.Create__Instance__(Of Registro)(Me.m_Registro)
                    Return Me.m_Registro
                End Get
                <DebuggerHidden>
                Set(ByVal value As Registro)
                    If (value IsNot Me.m_Registro) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Registro)(Me.m_Registro)
                    End If
                End Set
            End Property

            Public Property todos_registrosx As todos_registros
                <DebuggerHidden>
                Get
                    Me.m_todos_registros = MyProject.MyForms.Create__Instance__(Of todos_registros)(Me.m_todos_registros)
                    Return Me.m_todos_registros
                End Get
                <DebuggerHidden>
                Set(ByVal value As todos_registros)
                    If (value IsNot Me.m_todos_registros) Then
                        If (value IsNot Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of todos_registros)(Me.m_todos_registros)
                    End If
                End Set
            End Property

            <DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub

			<DebuggerHidden>
			Private Shared Function Create__Instance__(Of T As {Form, New})(ByVal Instance As T) As T
				Dim t1 As T
				If (If(Instance Is Nothing, False, Not Instance.IsDisposed)) Then
					t1 = Instance
				Else
					If (MyProject.MyForms.m_FormBeingCreated Is Nothing) Then
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					ElseIf (MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))) Then
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Try
							t1 = Activator.CreateInstance(Of T)()
						Catch targetInvocationException As System.Reflection.TargetInvocationException When targetInvocationException.InnerException IsNot Nothing
							Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { targetInvocationException.InnerException.Message })
							Throw New InvalidOperationException(resourceString, targetInvocationException.InnerException)
						End Try
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return t1
			End Function

			<DebuggerHidden>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(ByVal o As Object) As Boolean
				Return Me.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return Me.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Shadows Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return Me.ToString()
			End Function
		End Class

		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub

			<DebuggerHidden>
			Private Shared Function Create__Instance__(Of T As New)(ByVal instance As T) As T
				Dim t1 As T
				t1 = If(instance IsNot Nothing, instance, Activator.CreateInstance(Of T)())
				Return t1
			End Function

			<DebuggerHidden>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(ByVal o As Object) As Boolean
				Return Me.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return Me.GetHashCode()
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Shadows Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return Me.ToString()
			End Function
		End Class

		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			<CompilerGenerated>
			<ThreadStatic>
			Private Shared m_ThreadStaticValue As T

			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden>
				Get
					If (MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing) Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub
		End Class
	End Module
End Namespace