Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh.My
Imports ssh.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ssh
	<DesignerGenerated>
	Public Class Registro
		Inherits Form
		Private components As IContainer

		Private ReadOnly mytrans As MySqlTransaction

        Public tipousuario As Integer

        Public estadousuario As Integer

        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox


        Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox

        Friend WithEvents DateEdit1 As DateEdit




        Friend WithEvents PictureBox1 As PictureBox


        Friend WithEvents RadioButton1 As RadioButton

        Friend WithEvents RadioButton2 As RadioButton

        Friend WithEvents RadioButton3 As RadioButton

        Friend WithEvents RadioButton4 As RadioButton

        Friend WithEvents RadioButton5 As RadioButton

        Friend WithEvents RadioButton6 As RadioButton

        Friend WithEvents SeparatorControl1 As SeparatorControl

        Friend WithEvents SeparatorControl10 As SeparatorControl

        Friend WithEvents SeparatorControl11 As SeparatorControl

        Friend WithEvents SeparatorControl12 As SeparatorControl

        Friend WithEvents SeparatorControl13 As SeparatorControl

        Friend WithEvents SeparatorControl14 As SeparatorControl

        Friend WithEvents SeparatorControl15 As SeparatorControl

        Friend WithEvents SeparatorControl16 As SeparatorControl

        Friend WithEvents SeparatorControl17 As SeparatorControl

        Friend WithEvents SeparatorControl18 As SeparatorControl

        Friend WithEvents SeparatorControl2 As SeparatorControl

        Friend WithEvents SeparatorControl3 As SeparatorControl

        Friend WithEvents SeparatorControl4 As SeparatorControl

        Friend WithEvents SeparatorControl5 As SeparatorControl

        Friend WithEvents SeparatorControl6 As SeparatorControl

        Friend WithEvents SeparatorControl7 As SeparatorControl

        Friend WithEvents SeparatorControl8 As SeparatorControl

        Friend WithEvents SeparatorControl9 As SeparatorControl

        Friend WithEvents SimpleButton1 As SimpleButton


        Friend WithEvents SimpleButton2 As SimpleButton


        Friend WithEvents SimpleButton3 As SimpleButton


        Friend WithEvents TextBox1 As TextBox

        Friend WithEvents TextBox10 As TextBox


        Friend WithEvents TextBox11 As TextBox


        Friend WithEvents TextBox12 As TextBox


        Friend WithEvents TextBox13 As TextBox


        Friend WithEvents TextBox14 As TextBox


        Friend WithEvents TextBox15 As TextBox


        Friend WithEvents TextBox16 As TextBox


        Friend WithEvents TextBox17 As TextBox


        Friend WithEvents TextBox18 As TextBox


        Friend WithEvents TextBox19 As TextBox

        Friend WithEvents TextBox2 As TextBox


        Friend WithEvents TextBox20 As TextBox


        Friend WithEvents TextBox21 As TextBox


        Friend WithEvents TextBox22 As TextBox

        Friend WithEvents TextBox24 As TextBox

        Friend WithEvents TextBox25 As TextBox

        Friend WithEvents TextBox3 As TextBox


        Friend WithEvents TextBox4 As TextBox


        Friend WithEvents TextBox5 As TextBox


        Friend WithEvents TextBox6 As TextBox


        Friend WithEvents TextBox7 As TextBox


        Friend WithEvents TextBox8 As TextBox


        Friend WithEvents TextBox9 As TextBox




        Public Sub Buscarsiexiste()
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modulo_variables_globales.usuario, "ykvk8", False) <> 0) Then
                modulo_variables_globales.usuario = Me.TextBox3.Text
                Dim dataTable As System.Data.DataTable = modulo_variables_globales.Buscar2(modulo_variables_globales.usuario)
                If (dataTable.Rows.Count > 0) Then
                    Dim item As DataRow = dataTable.Rows(0)
                    modulo_variables_globales.usuario_verificar = Convert.ToString(RuntimeHelpers.GetObjectValue(item("identidadalumno")))
                    If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(modulo_variables_globales.usuario_verificar.ToLower(), Me.TextBox3.Text.ToLower(), False) = 0) Then
                        Interaction.MsgBox("el alumno ya existe", MsgBoxStyle.OkOnly, Nothing)
                        Me.SimpleButton1.Enabled = False
                        Me.Limpiar()
                        Me.TextBox2.Focus()
                    End If
                End If
            End If
        End Sub

        Private Sub ComboBox1Click(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.Click
            Me.ComboBox1.DroppedDown = True
        End Sub

        Private Sub ComboBox1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox1.KeyPress
            e.Handled = True
        End Sub

        Private Sub DateEdit1EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DateEdit1.EditValueChanged
            Try
                Dim dateTime As System.DateTime = Me.DateEdit1.DateTime
                Dim year As Integer = System.DateTime.Now.Year - dateTime.Year
                If (System.DateTime.Now.Subtract(dateTime.AddYears(year)).TotalDays >= 0) Then
                    modulo_variables_globales.edad = Convert.ToString(year)
                Else
                    modulo_variables_globales.edad = Convert.ToString(year - 1)
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub



        <System.Diagnostics.DebuggerStepThrough()>
        Public Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox13 = New System.Windows.Forms.GroupBox()
            Me.TextBox25 = New System.Windows.Forms.TextBox()
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.TextBox24 = New System.Windows.Forms.TextBox()
            Me.GroupBox11 = New System.Windows.Forms.GroupBox()
            Me.ComboBox2 = New System.Windows.Forms.ComboBox()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.TextBox22 = New System.Windows.Forms.TextBox()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.TextBox21 = New System.Windows.Forms.TextBox()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.TextBox20 = New System.Windows.Forms.TextBox()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.TextBox19 = New System.Windows.Forms.TextBox()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.RadioButton5 = New System.Windows.Forms.RadioButton()
            Me.RadioButton6 = New System.Windows.Forms.RadioButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.RadioButton3 = New System.Windows.Forms.RadioButton()
            Me.RadioButton4 = New System.Windows.Forms.RadioButton()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.RadioButton2 = New System.Windows.Forms.RadioButton()
            Me.RadioButton1 = New System.Windows.Forms.RadioButton()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.TextBox18 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl18 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.TextBox17 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl17 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.TextBox16 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl16 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TextBox15 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl15 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl12 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.TextBox14 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl14 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.TextBox11 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl11 = New DevExpress.XtraEditors.SeparatorControl()
            Me.LabelN = New System.Windows.Forms.Label()
            Me.TextBox10 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl10 = New DevExpress.XtraEditors.SeparatorControl()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl7 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.TextBox13 = New System.Windows.Forms.TextBox()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl13 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl8 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl9 = New DevExpress.XtraEditors.SeparatorControl()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl5 = New DevExpress.XtraEditors.SeparatorControl()
            Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox13.SuspendLayout()
            Me.GroupBox12.SuspendLayout()
            Me.GroupBox11.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.SeparatorControl18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.SeparatorControl13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label7
            '
            Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Location = New System.Drawing.Point(366, -2)
            Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(635, 56)
            Me.Label7.TabIndex = 61
            Me.Label7.Text = "Registro de nuevo alumno"
            '
            'GroupBox1
            '
            Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.GroupBox13)
            Me.GroupBox1.Controls.Add(Me.GroupBox12)
            Me.GroupBox1.Controls.Add(Me.GroupBox11)
            Me.GroupBox1.Controls.Add(Me.GroupBox10)
            Me.GroupBox1.Controls.Add(Me.GroupBox9)
            Me.GroupBox1.Controls.Add(Me.GroupBox8)
            Me.GroupBox1.Controls.Add(Me.GroupBox7)
            Me.GroupBox1.Controls.Add(Me.GroupBox6)
            Me.GroupBox1.Controls.Add(Me.GroupBox5)
            Me.GroupBox1.Controls.Add(Me.GroupBox4)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.Label20)
            Me.GroupBox1.Controls.Add(Me.TextBox18)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl18)
            Me.GroupBox1.Controls.Add(Me.Label19)
            Me.GroupBox1.Controls.Add(Me.TextBox17)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl17)
            Me.GroupBox1.Controls.Add(Me.Label18)
            Me.GroupBox1.Controls.Add(Me.TextBox16)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl16)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.TextBox15)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl15)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.TextBox12)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl12)
            Me.GroupBox1.Controls.Add(Me.Label15)
            Me.GroupBox1.Controls.Add(Me.TextBox14)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl14)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.TextBox11)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl11)
            Me.GroupBox1.Controls.Add(Me.LabelN)
            Me.GroupBox1.Controls.Add(Me.TextBox10)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl10)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.TextBox5)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl7)
            Me.GroupBox1.Controls.Add(Me.SimpleButton3)
            Me.GroupBox1.Controls.Add(Me.SimpleButton2)
            Me.GroupBox1.Controls.Add(Me.SimpleButton1)
            Me.GroupBox1.Controls.Add(Me.Label17)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Panel4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.TextBox13)
            Me.GroupBox1.Controls.Add(Me.TextBox9)
            Me.GroupBox1.Controls.Add(Me.TextBox8)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl13)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl8)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl9)
            Me.GroupBox1.Controls.Add(Me.TextBox7)
            Me.GroupBox1.Controls.Add(Me.TextBox6)
            Me.GroupBox1.Controls.Add(Me.TextBox4)
            Me.GroupBox1.Controls.Add(Me.TextBox3)
            Me.GroupBox1.Controls.Add(Me.TextBox2)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl2)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl3)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl4)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl5)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl6)
            Me.GroupBox1.Controls.Add(Me.TextBox1)
            Me.GroupBox1.Controls.Add(Me.SeparatorControl1)
            Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(21, 56)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.GroupBox1.Size = New System.Drawing.Size(1295, 642)
            Me.GroupBox1.TabIndex = 84
            Me.GroupBox1.TabStop = False
            '
            'GroupBox13
            '
            Me.GroupBox13.Controls.Add(Me.TextBox25)
            Me.GroupBox13.ForeColor = System.Drawing.Color.Black
            Me.GroupBox13.Location = New System.Drawing.Point(836, 503)
            Me.GroupBox13.Name = "GroupBox13"
            Me.GroupBox13.Size = New System.Drawing.Size(340, 41)
            Me.GroupBox13.TabIndex = 148
            Me.GroupBox13.TabStop = False
            Me.GroupBox13.Text = "Lugar de estudios anterior"
            '
            'TextBox25
            '
            Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox25.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox25.ForeColor = System.Drawing.Color.Black
            Me.TextBox25.Location = New System.Drawing.Point(8, 18)
            Me.TextBox25.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox25.MaxLength = 100
            Me.TextBox25.Name = "TextBox25"
            Me.TextBox25.Size = New System.Drawing.Size(324, 19)
            Me.TextBox25.TabIndex = 47
            '
            'GroupBox12
            '
            Me.GroupBox12.Controls.Add(Me.TextBox24)
            Me.GroupBox12.ForeColor = System.Drawing.Color.Black
            Me.GroupBox12.Location = New System.Drawing.Point(836, 456)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(340, 41)
            Me.GroupBox12.TabIndex = 147
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Ultimo año de estudio"
            '
            'TextBox24
            '
            Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox24.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox24.ForeColor = System.Drawing.Color.Black
            Me.TextBox24.Location = New System.Drawing.Point(8, 15)
            Me.TextBox24.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox24.MaxLength = 4
            Me.TextBox24.Name = "TextBox24"
            Me.TextBox24.Size = New System.Drawing.Size(324, 19)
            Me.TextBox24.TabIndex = 47
            '
            'GroupBox11
            '
            Me.GroupBox11.Controls.Add(Me.ComboBox2)
            Me.GroupBox11.ForeColor = System.Drawing.Color.Black
            Me.GroupBox11.Location = New System.Drawing.Point(836, 403)
            Me.GroupBox11.Name = "GroupBox11"
            Me.GroupBox11.Size = New System.Drawing.Size(340, 49)
            Me.GroupBox11.TabIndex = 146
            Me.GroupBox11.TabStop = False
            Me.GroupBox11.Text = "Grado Anterior"
            '
            'ComboBox2
            '
            Me.ComboBox2.ForeColor = System.Drawing.Color.Black
            Me.ComboBox2.FormattingEnabled = True
            Me.ComboBox2.Items.AddRange(New Object() {"Jardin", "Preparatoria", "1ro", "2do", "3ro", "4to", "5to", "6to", "7mo", "8vo", "9no", "IBCH", "IIBCH", "ICONTADURIA", "IICONTADURIA", "IIICONTADURIA", "IBTPI", "IIBTPI", "IIIBTPI"})
            Me.ComboBox2.Location = New System.Drawing.Point(4, 16)
            Me.ComboBox2.Name = "ComboBox2"
            Me.ComboBox2.Size = New System.Drawing.Size(332, 25)
            Me.ComboBox2.TabIndex = 0
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.TextBox22)
            Me.GroupBox10.ForeColor = System.Drawing.Color.Black
            Me.GroupBox10.Location = New System.Drawing.Point(836, 359)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(340, 41)
            Me.GroupBox10.TabIndex = 144
            Me.GroupBox10.TabStop = False
            Me.GroupBox10.Text = "Instituto Anterior"
            '
            'TextBox22
            '
            Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox22.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox22.ForeColor = System.Drawing.Color.Black
            Me.TextBox22.Location = New System.Drawing.Point(8, 15)
            Me.TextBox22.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox22.MaxLength = 100
            Me.TextBox22.Name = "TextBox22"
            Me.TextBox22.Size = New System.Drawing.Size(324, 19)
            Me.TextBox22.TabIndex = 47
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.TextBox21)
            Me.GroupBox9.ForeColor = System.Drawing.Color.Black
            Me.GroupBox9.Location = New System.Drawing.Point(434, 429)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox9.TabIndex = 145
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Municipio de nacimiento"
            '
            'TextBox21
            '
            Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox21.ForeColor = System.Drawing.Color.Black
            Me.TextBox21.Location = New System.Drawing.Point(8, 15)
            Me.TextBox21.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox21.MaxLength = 100
            Me.TextBox21.Name = "TextBox21"
            Me.TextBox21.Size = New System.Drawing.Size(324, 19)
            Me.TextBox21.TabIndex = 36
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.TextBox20)
            Me.GroupBox8.ForeColor = System.Drawing.Color.Black
            Me.GroupBox8.Location = New System.Drawing.Point(434, 385)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox8.TabIndex = 144
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Departamento de nacimiento"
            '
            'TextBox20
            '
            Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox20.ForeColor = System.Drawing.Color.Black
            Me.TextBox20.Location = New System.Drawing.Point(8, 15)
            Me.TextBox20.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox20.MaxLength = 100
            Me.TextBox20.Name = "TextBox20"
            Me.TextBox20.Size = New System.Drawing.Size(324, 19)
            Me.TextBox20.TabIndex = 35
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.TextBox19)
            Me.GroupBox7.ForeColor = System.Drawing.Color.Black
            Me.GroupBox7.Location = New System.Drawing.Point(836, 312)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(340, 41)
            Me.GroupBox7.TabIndex = 143
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Nacionalidad"
            '
            'TextBox19
            '
            Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox19.ForeColor = System.Drawing.Color.Black
            Me.TextBox19.Location = New System.Drawing.Point(8, 15)
            Me.TextBox19.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox19.MaxLength = 100
            Me.TextBox19.Name = "TextBox19"
            Me.TextBox19.Size = New System.Drawing.Size(324, 19)
            Me.TextBox19.TabIndex = 47
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.DateEdit1)
            Me.GroupBox6.ForeColor = System.Drawing.Color.Black
            Me.GroupBox6.Location = New System.Drawing.Point(836, 268)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox6.TabIndex = 142
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Fecha de nacimiento"
            '
            'DateEdit1
            '
            Me.DateEdit1.EditValue = Nothing
            Me.DateEdit1.Location = New System.Drawing.Point(32, 18)
            Me.DateEdit1.Name = "DateEdit1"
            Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit1.Size = New System.Drawing.Size(285, 20)
            Me.DateEdit1.TabIndex = 46
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.RadioButton5)
            Me.GroupBox5.Controls.Add(Me.RadioButton6)
            Me.GroupBox5.ForeColor = System.Drawing.Color.Black
            Me.GroupBox5.Location = New System.Drawing.Point(836, 217)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox5.TabIndex = 141
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Repitente"
            '
            'RadioButton5
            '
            Me.RadioButton5.AutoSize = True
            Me.RadioButton5.ForeColor = System.Drawing.Color.Black
            Me.RadioButton5.Location = New System.Drawing.Point(209, 16)
            Me.RadioButton5.Name = "RadioButton5"
            Me.RadioButton5.Size = New System.Drawing.Size(45, 21)
            Me.RadioButton5.TabIndex = 45
            Me.RadioButton5.TabStop = True
            Me.RadioButton5.Text = "No"
            Me.RadioButton5.UseVisualStyleBackColor = True
            '
            'RadioButton6
            '
            Me.RadioButton6.AutoSize = True
            Me.RadioButton6.ForeColor = System.Drawing.Color.Black
            Me.RadioButton6.Location = New System.Drawing.Point(44, 16)
            Me.RadioButton6.Name = "RadioButton6"
            Me.RadioButton6.Size = New System.Drawing.Size(35, 21)
            Me.RadioButton6.TabIndex = 44
            Me.RadioButton6.TabStop = True
            Me.RadioButton6.Text = "Si"
            Me.RadioButton6.UseVisualStyleBackColor = True
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.RadioButton3)
            Me.GroupBox4.Controls.Add(Me.RadioButton4)
            Me.GroupBox4.ForeColor = System.Drawing.Color.Black
            Me.GroupBox4.Location = New System.Drawing.Point(836, 166)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox4.TabIndex = 140
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Condicionado"
            '
            'RadioButton3
            '
            Me.RadioButton3.AutoSize = True
            Me.RadioButton3.ForeColor = System.Drawing.Color.Black
            Me.RadioButton3.Location = New System.Drawing.Point(209, 16)
            Me.RadioButton3.Name = "RadioButton3"
            Me.RadioButton3.Size = New System.Drawing.Size(45, 21)
            Me.RadioButton3.TabIndex = 43
            Me.RadioButton3.TabStop = True
            Me.RadioButton3.Text = "No"
            Me.RadioButton3.UseVisualStyleBackColor = True
            '
            'RadioButton4
            '
            Me.RadioButton4.AutoSize = True
            Me.RadioButton4.ForeColor = System.Drawing.Color.Black
            Me.RadioButton4.Location = New System.Drawing.Point(44, 16)
            Me.RadioButton4.Name = "RadioButton4"
            Me.RadioButton4.Size = New System.Drawing.Size(35, 21)
            Me.RadioButton4.TabIndex = 42
            Me.RadioButton4.TabStop = True
            Me.RadioButton4.Text = "Si"
            Me.RadioButton4.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.RadioButton2)
            Me.GroupBox3.Controls.Add(Me.RadioButton1)
            Me.GroupBox3.ForeColor = System.Drawing.Color.Black
            Me.GroupBox3.Location = New System.Drawing.Point(836, 116)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(340, 44)
            Me.GroupBox3.TabIndex = 138
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Sexo"
            '
            'RadioButton2
            '
            Me.RadioButton2.AutoSize = True
            Me.RadioButton2.ForeColor = System.Drawing.Color.Black
            Me.RadioButton2.Location = New System.Drawing.Point(209, 16)
            Me.RadioButton2.Name = "RadioButton2"
            Me.RadioButton2.Size = New System.Drawing.Size(89, 21)
            Me.RadioButton2.TabIndex = 41
            Me.RadioButton2.TabStop = True
            Me.RadioButton2.Text = "Femenino"
            Me.RadioButton2.UseVisualStyleBackColor = True
            '
            'RadioButton1
            '
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.ForeColor = System.Drawing.Color.Black
            Me.RadioButton1.Location = New System.Drawing.Point(44, 16)
            Me.RadioButton1.Name = "RadioButton1"
            Me.RadioButton1.Size = New System.Drawing.Size(90, 21)
            Me.RadioButton1.TabIndex = 40
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Masculino"
            Me.RadioButton1.UseVisualStyleBackColor = True
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.ForeColor = System.Drawing.Color.Black
            Me.Label20.Location = New System.Drawing.Point(433, 540)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(308, 17)
            Me.Label20.TabIndex = 137
            Me.Label20.Text = "Telefóno contacto de emergencia del alumno"
            Me.Label20.Visible = False
            '
            'TextBox18
            '
            Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox18.ForeColor = System.Drawing.Color.Black
            Me.TextBox18.Location = New System.Drawing.Point(436, 559)
            Me.TextBox18.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox18.MaxLength = 100
            Me.TextBox18.Name = "TextBox18"
            Me.TextBox18.Size = New System.Drawing.Size(346, 19)
            Me.TextBox18.TabIndex = 39
            Me.TextBox18.Text = "Telefóno contacto de emergencia del alumno"
            '
            'SeparatorControl18
            '
            Me.SeparatorControl18.Location = New System.Drawing.Point(438, 572)
            Me.SeparatorControl18.Name = "SeparatorControl18"
            Me.SeparatorControl18.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl18.TabIndex = 136
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.ForeColor = System.Drawing.Color.Black
            Me.Label19.Location = New System.Drawing.Point(433, 489)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(253, 17)
            Me.Label19.TabIndex = 134
            Me.Label19.Text = "Contacto de emergencia del alumno"
            Me.Label19.Visible = False
            '
            'TextBox17
            '
            Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox17.ForeColor = System.Drawing.Color.Black
            Me.TextBox17.Location = New System.Drawing.Point(436, 508)
            Me.TextBox17.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox17.MaxLength = 100
            Me.TextBox17.Name = "TextBox17"
            Me.TextBox17.Size = New System.Drawing.Size(273, 19)
            Me.TextBox17.TabIndex = 38
            Me.TextBox17.Text = "Contacto de emergencia del alumno"
            '
            'SeparatorControl17
            '
            Me.SeparatorControl17.Location = New System.Drawing.Point(438, 521)
            Me.SeparatorControl17.Name = "SeparatorControl17"
            Me.SeparatorControl17.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl17.TabIndex = 133
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Me.Label18.Location = New System.Drawing.Point(447, 226)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(187, 17)
            Me.Label18.TabIndex = 131
            Me.Label18.Text = "Telefóno madre del alumno"
            Me.Label18.Visible = False
            '
            'TextBox16
            '
            Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox16.ForeColor = System.Drawing.Color.Black
            Me.TextBox16.Location = New System.Drawing.Point(450, 245)
            Me.TextBox16.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox16.MaxLength = 100
            Me.TextBox16.Name = "TextBox16"
            Me.TextBox16.Size = New System.Drawing.Size(273, 19)
            Me.TextBox16.TabIndex = 33
            Me.TextBox16.Text = "Telefóno madre del alumno"
            '
            'SeparatorControl16
            '
            Me.SeparatorControl16.Location = New System.Drawing.Point(452, 258)
            Me.SeparatorControl16.Name = "SeparatorControl16"
            Me.SeparatorControl16.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl16.TabIndex = 130
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(450, 68)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(183, 17)
            Me.Label8.TabIndex = 128
            Me.Label8.Text = "Telefóno padre del alumno"
            Me.Label8.Visible = False
            '
            'TextBox15
            '
            Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox15.ForeColor = System.Drawing.Color.Black
            Me.TextBox15.Location = New System.Drawing.Point(453, 87)
            Me.TextBox15.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox15.MaxLength = 100
            Me.TextBox15.Name = "TextBox15"
            Me.TextBox15.Size = New System.Drawing.Size(273, 19)
            Me.TextBox15.TabIndex = 30
            Me.TextBox15.Text = "Telefóno padre del alumno"
            '
            'SeparatorControl15
            '
            Me.SeparatorControl15.Location = New System.Drawing.Point(455, 100)
            Me.SeparatorControl15.Name = "SeparatorControl15"
            Me.SeparatorControl15.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl15.TabIndex = 127
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(450, 173)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(279, 17)
            Me.Label6.TabIndex = 125
            Me.Label6.Text = "Lugar de trabajo de la madre del alumno"
            Me.Label6.Visible = False
            '
            'TextBox12
            '
            Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox12.ForeColor = System.Drawing.Color.Black
            Me.TextBox12.Location = New System.Drawing.Point(453, 192)
            Me.TextBox12.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox12.MaxLength = 100
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.Size = New System.Drawing.Size(313, 19)
            Me.TextBox12.TabIndex = 32
            Me.TextBox12.Text = "Lugar de trabajo de la madre del alumno"
            '
            'SeparatorControl12
            '
            Me.SeparatorControl12.Location = New System.Drawing.Point(444, 205)
            Me.SeparatorControl12.Name = "SeparatorControl12"
            Me.SeparatorControl12.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl12.TabIndex = 124
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.ForeColor = System.Drawing.Color.Black
            Me.Label15.Location = New System.Drawing.Point(448, 122)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(186, 17)
            Me.Label15.TabIndex = 122
            Me.Label15.Text = "Nombre madre del alumno"
            Me.Label15.Visible = False
            '
            'TextBox14
            '
            Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox14.ForeColor = System.Drawing.Color.Black
            Me.TextBox14.Location = New System.Drawing.Point(451, 141)
            Me.TextBox14.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox14.MaxLength = 100
            Me.TextBox14.Name = "TextBox14"
            Me.TextBox14.Size = New System.Drawing.Size(273, 19)
            Me.TextBox14.TabIndex = 31
            Me.TextBox14.Text = "Nombre madre del alumno"
            '
            'SeparatorControl14
            '
            Me.SeparatorControl14.Location = New System.Drawing.Point(453, 154)
            Me.SeparatorControl14.Name = "SeparatorControl14"
            Me.SeparatorControl14.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl14.TabIndex = 121
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(450, 19)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(262, 17)
            Me.Label5.TabIndex = 119
            Me.Label5.Text = "Lugar de trabajo del padre del alumno"
            Me.Label5.Visible = False
            '
            'TextBox11
            '
            Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox11.ForeColor = System.Drawing.Color.Black
            Me.TextBox11.Location = New System.Drawing.Point(453, 38)
            Me.TextBox11.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox11.MaxLength = 100
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Size = New System.Drawing.Size(291, 19)
            Me.TextBox11.TabIndex = 29
            Me.TextBox11.Text = "Lugar de trabajo del padre del alumno"
            '
            'SeparatorControl11
            '
            Me.SeparatorControl11.Location = New System.Drawing.Point(444, 51)
            Me.SeparatorControl11.Name = "SeparatorControl11"
            Me.SeparatorControl11.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl11.TabIndex = 118
            '
            'LabelN
            '
            Me.LabelN.AutoSize = True
            Me.LabelN.ForeColor = System.Drawing.Color.Black
            Me.LabelN.Location = New System.Drawing.Point(32, 468)
            Me.LabelN.Name = "LabelN"
            Me.LabelN.Size = New System.Drawing.Size(182, 17)
            Me.LabelN.TabIndex = 116
            Me.LabelN.Text = "Nombre padre del alumno"
            Me.LabelN.Visible = False
            '
            'TextBox10
            '
            Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox10.ForeColor = System.Drawing.Color.Black
            Me.TextBox10.Location = New System.Drawing.Point(35, 487)
            Me.TextBox10.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox10.MaxLength = 100
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.Size = New System.Drawing.Size(273, 19)
            Me.TextBox10.TabIndex = 28
            Me.TextBox10.Text = "Nombre padre del alumno"
            '
            'SeparatorControl10
            '
            Me.SeparatorControl10.Location = New System.Drawing.Point(37, 500)
            Me.SeparatorControl10.Name = "SeparatorControl10"
            Me.SeparatorControl10.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl10.TabIndex = 115
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(29, 292)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(239, 17)
            Me.Label1.TabIndex = 113
            Me.Label1.Text = "Lugar de trabajo padre/encargado"
            Me.Label1.Visible = False
            '
            'TextBox5
            '
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox5.ForeColor = System.Drawing.Color.Black
            Me.TextBox5.Location = New System.Drawing.Point(33, 316)
            Me.TextBox5.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox5.MaxLength = 300
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Size = New System.Drawing.Size(273, 19)
            Me.TextBox5.TabIndex = 25
            Me.TextBox5.Text = "Lugar de trabajo padre/encargado"
            '
            'SeparatorControl7
            '
            Me.SeparatorControl7.Location = New System.Drawing.Point(24, 328)
            Me.SeparatorControl7.Name = "SeparatorControl7"
            Me.SeparatorControl7.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl7.TabIndex = 111
            '
            'SimpleButton3
            '
            Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton3.Appearance.Options.UseFont = True
            Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
            Me.SimpleButton3.Location = New System.Drawing.Point(838, 594)
            Me.SimpleButton3.Name = "SimpleButton3"
            Me.SimpleButton3.Size = New System.Drawing.Size(340, 41)
            Me.SimpleButton3.TabIndex = 50
            Me.SimpleButton3.Text = "Actualizar"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton2.Appearance.Options.UseFont = True
            Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
            Me.SimpleButton2.Location = New System.Drawing.Point(1014, 547)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(164, 41)
            Me.SimpleButton2.TabIndex = 49
            Me.SimpleButton2.Text = "Cancelar"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton1.Appearance.Options.UseFont = True
            Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
            Me.SimpleButton1.Location = New System.Drawing.Point(838, 547)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(164, 41)
            Me.SimpleButton1.TabIndex = 48
            Me.SimpleButton1.Text = "Registrar"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Me.Label17.Location = New System.Drawing.Point(31, 411)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(275, 17)
            Me.Label17.TabIndex = 109
            Me.Label17.Text = "Número telefónico del padre/encargado"
            Me.Label17.Visible = False
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Me.Label16.Location = New System.Drawing.Point(30, 354)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(276, 17)
            Me.Label16.TabIndex = 108
            Me.Label16.Text = "Correo electronico del padre/encargado"
            Me.Label16.Visible = False
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.ForeColor = System.Drawing.Color.Black
            Me.Label14.Location = New System.Drawing.Point(28, 230)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(240, 17)
            Me.Label14.TabIndex = 104
            Me.Label14.Text = "Profesion u oficio padre/encargado"
            Me.Label14.Visible = False
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.ForeColor = System.Drawing.Color.Black
            Me.Label13.Location = New System.Drawing.Point(29, 182)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(206, 17)
            Me.Label13.TabIndex = 106
            Me.Label13.Text = "# Identidad padre/encargado"
            Me.Label13.Visible = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(29, 80)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(138, 17)
            Me.Label12.TabIndex = 105
            Me.Label12.Text = "# Identidad alumno"
            Me.Label12.Visible = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.ForeColor = System.Drawing.Color.Black
            Me.Label11.Location = New System.Drawing.Point(28, 132)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(251, 17)
            Me.Label11.TabIndex = 104
            Me.Label11.Text = "Nombre completo padre/encargado"
            Me.Label11.Visible = False
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(29, 36)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(183, 17)
            Me.Label10.TabIndex = 103
            Me.Label10.Text = "Nombre completo alumno"
            Me.Label10.Visible = False
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.DimGray
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Location = New System.Drawing.Point(17, 529)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(338, 69)
            Me.Panel4.TabIndex = 99
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(16, 2)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(297, 64)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "Nota." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El registro es almacenado directamente en el servidor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en la nube, los re" &
    "portes y cambios de estado de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "matricula deben ser controlados con esta aplicac" &
    "ion."
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(450, 278)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(254, 18)
            Me.Label3.TabIndex = 96
            Me.Label3.Text = "Dirección sugerida por el sistema"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.ComboBox1)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Location = New System.Drawing.Point(824, 19)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(411, 83)
            Me.GroupBox2.TabIndex = 94
            Me.GroupBox2.TabStop = False
            '
            'ComboBox1
            '
            Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ComboBox1.ForeColor = System.Drawing.Color.Black
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"Jardin", "Preparatoria", "1ro", "2do", "3ro", "4to", "5to", "6to", "7mo", "8vo", "9no", "IBCH", "IIBCH", "ICONTADURIA", "IICONTADURIA", "IIICONTADURIA", "IBTPI", "IIBTPI", "IIIBTPI"})
            Me.ComboBox1.Location = New System.Drawing.Point(12, 41)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(391, 25)
            Me.ComboBox1.TabIndex = 37
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(177, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(57, 20)
            Me.Label9.TabIndex = 102
            Me.Label9.Text = "Grado"
            '
            'TextBox13
            '
            Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox13.ForeColor = System.Drawing.Color.Black
            Me.TextBox13.Location = New System.Drawing.Point(454, 305)
            Me.TextBox13.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox13.MaxLength = 500
            Me.TextBox13.Multiline = True
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New System.Drawing.Size(273, 63)
            Me.TextBox13.TabIndex = 34
            Me.TextBox13.Text = "Altos de San José, Instituto Alfonso Guillén Zelaya, Tegucigalpa Honduras 11101"
            '
            'TextBox9
            '
            Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox9.ForeColor = System.Drawing.Color.Black
            Me.TextBox9.Location = New System.Drawing.Point(35, 433)
            Me.TextBox9.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox9.MaxLength = 150
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Size = New System.Drawing.Size(273, 19)
            Me.TextBox9.TabIndex = 27
            Me.TextBox9.Text = "Número telefónico"
            '
            'TextBox8
            '
            Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox8.ForeColor = System.Drawing.Color.Black
            Me.TextBox8.Location = New System.Drawing.Point(34, 378)
            Me.TextBox8.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox8.MaxLength = 100
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Size = New System.Drawing.Size(273, 19)
            Me.TextBox8.TabIndex = 26
            Me.TextBox8.Text = "Correo electronico (opcional)"
            '
            'SeparatorControl13
            '
            Me.SeparatorControl13.Location = New System.Drawing.Point(436, 373)
            Me.SeparatorControl13.Name = "SeparatorControl13"
            Me.SeparatorControl13.Size = New System.Drawing.Size(273, 19)
            Me.SeparatorControl13.TabIndex = 80
            '
            'SeparatorControl8
            '
            Me.SeparatorControl8.Location = New System.Drawing.Point(16, 389)
            Me.SeparatorControl8.Name = "SeparatorControl8"
            Me.SeparatorControl8.Size = New System.Drawing.Size(273, 19)
            Me.SeparatorControl8.TabIndex = 75
            '
            'SeparatorControl9
            '
            Me.SeparatorControl9.Location = New System.Drawing.Point(17, 446)
            Me.SeparatorControl9.Name = "SeparatorControl9"
            Me.SeparatorControl9.Size = New System.Drawing.Size(273, 19)
            Me.SeparatorControl9.TabIndex = 76
            '
            'TextBox7
            '
            Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox7.ForeColor = System.Drawing.Color.Black
            Me.TextBox7.Location = New System.Drawing.Point(32, 202)
            Me.TextBox7.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox7.MaxLength = 50
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.Size = New System.Drawing.Size(273, 19)
            Me.TextBox7.TabIndex = 23
            Me.TextBox7.Text = "# Identidad padre/encargado"
            '
            'TextBox6
            '
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.ForeColor = System.Drawing.Color.Black
            Me.TextBox6.Location = New System.Drawing.Point(31, 156)
            Me.TextBox6.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox6.MaxLength = 100
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Size = New System.Drawing.Size(273, 19)
            Me.TextBox6.TabIndex = 22
            Me.TextBox6.Text = "Nombre completo padre/encargado"
            '
            'TextBox4
            '
            Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox4.ForeColor = System.Drawing.Color.Black
            Me.TextBox4.Location = New System.Drawing.Point(32, 254)
            Me.TextBox4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox4.MaxLength = 300
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(273, 19)
            Me.TextBox4.TabIndex = 24
            Me.TextBox4.Text = "Profesion u oficio padre/encargado"
            '
            'TextBox3
            '
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.ForeColor = System.Drawing.Color.Black
            Me.TextBox3.Location = New System.Drawing.Point(32, 104)
            Me.TextBox3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox3.MaxLength = 50
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(273, 19)
            Me.TextBox3.TabIndex = 21
            Me.TextBox3.Text = "# Identidad alumno"
            '
            'TextBox2
            '
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.ForeColor = System.Drawing.Color.Black
            Me.TextBox2.Location = New System.Drawing.Point(32, 55)
            Me.TextBox2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox2.MaxLength = 100
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(273, 19)
            Me.TextBox2.TabIndex = 20
            Me.TextBox2.Text = "Nombre completo alumno"
            '
            'SeparatorControl2
            '
            Me.SeparatorControl2.Location = New System.Drawing.Point(23, 68)
            Me.SeparatorControl2.Name = "SeparatorControl2"
            Me.SeparatorControl2.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl2.TabIndex = 68
            '
            'SeparatorControl3
            '
            Me.SeparatorControl3.Location = New System.Drawing.Point(23, 118)
            Me.SeparatorControl3.Name = "SeparatorControl3"
            Me.SeparatorControl3.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl3.TabIndex = 69
            '
            'SeparatorControl4
            '
            Me.SeparatorControl4.Location = New System.Drawing.Point(23, 169)
            Me.SeparatorControl4.Name = "SeparatorControl4"
            Me.SeparatorControl4.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl4.TabIndex = 71
            '
            'SeparatorControl5
            '
            Me.SeparatorControl5.Location = New System.Drawing.Point(23, 216)
            Me.SeparatorControl5.Name = "SeparatorControl5"
            Me.SeparatorControl5.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl5.TabIndex = 72
            '
            'SeparatorControl6
            '
            Me.SeparatorControl6.Location = New System.Drawing.Point(23, 266)
            Me.SeparatorControl6.Name = "SeparatorControl6"
            Me.SeparatorControl6.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl6.TabIndex = 73
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Location = New System.Drawing.Point(32, 13)
            Me.TextBox1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.TextBox1.MaxLength = 20
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(264, 16)
            Me.TextBox1.TabIndex = 59
            Me.TextBox1.TabStop = False
            '
            'SeparatorControl1
            '
            Me.SeparatorControl1.Location = New System.Drawing.Point(23, 21)
            Me.SeparatorControl1.Name = "SeparatorControl1"
            Me.SeparatorControl1.Size = New System.Drawing.Size(291, 23)
            Me.SeparatorControl1.TabIndex = 62
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.Resources.close_x
            Me.PictureBox1.Location = New System.Drawing.Point(1259, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(57, 51)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 157
            Me.PictureBox1.TabStop = False
            '
            'Registro
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1342, 711)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label7)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Registro"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "registro"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox13.ResumeLayout(False)
            Me.GroupBox13.PerformLayout()
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.GroupBox11.ResumeLayout(False)
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.SeparatorControl18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.SeparatorControl13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        ''sadaqui va en codigo Friend WithEvents 
        Friend WithEvents GroupBox1 As GroupBox

        Friend WithEvents GroupBox10 As GroupBox

        Friend WithEvents GroupBox11 As GroupBox

        Friend WithEvents GroupBox12 As GroupBox

        Friend WithEvents GroupBox13 As GroupBox

        Friend WithEvents GroupBox2 As GroupBox

        Friend WithEvents GroupBox3 As GroupBox

        Friend WithEvents GroupBox4 As GroupBox

        Friend WithEvents GroupBox5 As GroupBox

        Friend WithEvents GroupBox6 As GroupBox

        Friend WithEvents GroupBox7 As GroupBox

        Friend WithEvents GroupBox8 As GroupBox

        Friend WithEvents GroupBox9 As GroupBox

        Friend WithEvents Label1 As Label

        Friend WithEvents Label10 As Label

        Friend WithEvents Label11 As Label

        Friend WithEvents Label12 As Label

        Friend WithEvents Label13 As Label

        Friend WithEvents Label14 As Label

        Friend WithEvents Label15 As Label

        Friend WithEvents Label16 As Label

        Friend WithEvents Label17 As Label

        Friend WithEvents Label18 As Label

        Friend WithEvents Label19 As Label

        Friend WithEvents Label20 As Label

        Friend WithEvents Label3 As Label

        Friend WithEvents Label4 As Label

        Friend WithEvents Label5 As Label

        Friend WithEvents Label6 As Label

        Friend WithEvents Label7 As Label

        Friend WithEvents Label8 As Label

        Friend WithEvents Label9 As Label

        Friend WithEvents LabelN As Label

        Friend WithEvents Panel4 As Panel


        Public Sub Limpiar()
            Me.TextBox2.Text = "Nombre completo alumno"
            Me.TextBox2.ForeColor = Color.Black
            Me.TextBox6.Text = "Nombre completo padre/encargado"
            Me.TextBox6.ForeColor = Color.Black
            Me.TextBox3.Text = "# Identidad alumno"
            Me.TextBox3.ForeColor = Color.Black
            Me.TextBox7.Text = "# Identidad padre/encargado"
            Me.TextBox7.ForeColor = Color.Black
            Me.TextBox4.Text = "Profesion u oficio padre/encargado"
            Me.TextBox4.ForeColor = Color.Black
            Me.TextBox8.Text = "Correo electronico (opcional)"
            Me.TextBox8.ForeColor = Color.Black
            Me.TextBox9.Text = "Número telefónico"
            Me.TextBox9.ForeColor = Color.Black
            Me.TextBox13.Text = "Altos de San José, Instituto Alfonso Guillén Zelaya, Tegucigalpa Honduras 11101"
            Me.TextBox13.ForeColor = Color.Black
            Me.ComboBox1.Text = ""
            Me.TextBox15.Text = "Lugar de trabajo padre/encargado"
            Me.TextBox5.ForeColor = Color.Black
            Me.TextBox10.Text = "Nombre padre del alumno"
            Me.TextBox10.ForeColor = Color.Black
            Me.TextBox11.Text = "Lugar de trabajo del padre del alumno"
            Me.TextBox11.ForeColor = Color.Black
            Me.TextBox15.Text = "Telefóno padre del alumno"
            Me.TextBox15.ForeColor = Color.Black
            Me.TextBox14.Text = "Nombre madre del alumno"
            Me.TextBox14.ForeColor = Color.Black
            Me.TextBox12.Text = "Lugar de trabajo de la madre del alumno"
            Me.TextBox12.ForeColor = Color.Black
            Me.TextBox16.Text = "Telefóno madre del alumno"
            Me.TextBox16.ForeColor = Color.Black
            Me.TextBox20.Text = ""
            Me.TextBox21.Text = ""
            Me.TextBox17.Text = "Contacto de emergencia del alumno"
            Me.TextBox17.ForeColor = Color.Black
            Me.TextBox18.Text = "Telefóno contacto de emergencia del alumno"
            Me.TextBox18.ForeColor = Color.Black
            Me.RadioButton1.Checked = False
            Me.RadioButton2.Checked = False
            Me.RadioButton3.Checked = False
            Me.RadioButton4.Checked = False
            Me.RadioButton5.Checked = False
            Me.RadioButton6.Checked = False
            Me.DateEdit1.EditValue = ""
            Me.TextBox19.Text = ""
            Me.TextBox5.Text = "Lugar de trabajo padre/encargado"
            Me.TextBox5.ForeColor = Color.Black
            Me.TextBox22.Text = ""
            Me.ComboBox2.Text = ""
            Me.TextBox24.Text = ""
            Me.TextBox25.Text = ""
        End Sub

        Private Sub PictureBox1Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
            MyBase.Close()
        End Sub

        Private Sub RegistrarusuarioLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'Me.SimpleButton1.Enabled = False
        End Sub

        Private Sub RegistroFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            Me.SimpleButton1.Visible = True
            Me.SimpleButton2.Visible = True
            Me.SimpleButton3.Visible = False
            Me.Limpiar()
            MyProject.Forms.Form1.Show()
        End Sub

        Private Sub RegistroMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
            Registro.Releasecapture()
            Registro.SendMessage(MyBase.Handle, 274, 61458, 0)
        End Sub

        <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
        Private Shared Sub Releasecapture()
        End Sub

        <DllImport("user32.dll", EntryPoint:="SendMessage")>
        Private Shared Sub SendMessage(ByVal hand As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)
        End Sub

        Private Sub SimpleButton1Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
            Dim str As String
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String = Nothing
            Dim str5 As String = Nothing
            Dim exception As System.Exception
            Me.Buscarsiexiste()
            Try
                If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar el grado a matricular el alumno", MsgBoxStyle.Information, Nothing)
                    Me.ComboBox1.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar el grado del año anterior de matricula", MsgBoxStyle.Information, Nothing)
                    Me.ComboBox2.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.DateEdit1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar la fehca de nacimiento del alumno", MsgBoxStyle.Information, Nothing)
                    Me.DateEdit1.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "Correo electronico (opcional)", False) <> 0 And Not modulo_variables_globales.validar_email(Strings.LCase(Me.TextBox8.Text))) Then
                    MessageBox.Show("Direccion de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com,  por favor seleccione un correo valido", "validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox20.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el departamento de nacimiento", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox20.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox21.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el municipio de nacimiento", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox21.[Select]()
                ElseIf (Not Me.RadioButton1.Checked And Not Me.RadioButton2.Checked) Then
                    Interaction.MsgBox("Por favor seleccione el sexo", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox3.[Select]()
                ElseIf (Not Me.RadioButton4.Checked And Not Me.RadioButton3.Checked) Then
                    Interaction.MsgBox("Por favor seleccione si es condicionado", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox4.[Select]()
                ElseIf (Not Me.RadioButton6.Checked And Not Me.RadioButton5.Checked) Then
                    Interaction.MsgBox("Por favor seleccione si es repitente", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox5.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.DateEdit1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione la fecha de nacimiento del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.DateEdit1.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox19.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione la nacionalidad", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox19.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "Nombre completo alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el nombre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox2.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox22.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el instituto de estudio anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox21.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione el grado de estudio anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.ComboBox2.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox24.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el ultimo año que estudio", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox24.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox25.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el lugar en donde se ubicaba el lugar de estudios anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox25.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "Nombre completo padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre completo padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox6.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "# Identidad alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el  # Identidad alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox3.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "# Identidad padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el # Identidad padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox7.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "Profesion u oficio padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese la Profesion u oficio padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox4.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "Lugar de trabajo padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox5.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "Número telefónico", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Número telefónico del padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox9.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "Nombre padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox10.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "Lugar de trabajo del padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo del padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox11.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "Telefóno padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Telefóno padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox15.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "Nombre madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox14.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "Lugar de trabajo de la madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo de la madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox12.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "Telefóno madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Telefóno madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox16.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "Contacto de emergencia del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Contacto de emergencia del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox17.[Select]()
                ElseIf (Not (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "Telefóno contacto de emergencia del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "", False) = 0)) Then

                    conexionmysql.Abrir_MYBD()
                    '  Dim mySqlTransaction0 As MySqlTransaction = conexionmysql.myconn.BeginTransaction()
                    Try
                        Try
                            Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand("insert into matricula2 (nombre,identidadalumno,idp,grado,profesion,padre,telefono,email,direccion, lugartrabajo, nombrepadre, lugartrabajopadre, telefonopadre, nombremadre, lugartrabajomadre, telefonomadre, deptonac, municipionac, emergencia, telefonoemergencia, sexo, condicionado, repitente, fechanac, nacionalidad, edad, modalidad, colegioanterior, cursoanterior, modalidadanterior, anioanterior, lugaranterior) values (@nombrealumno,@identidadalumno,@idp,@grado,@profesion,@padre,@telefono,@email,@direccion, @lugartrabajo, @nombrepadre, @lugartrabajopadre, @telefonopadre, @nombremadre, @lugartrabajomadre, @telefonomadre, @deptonac, @municipionac, @emergencia, @telefonoemergencia, @sexo, @condicionado, @repitente, @fechanac, @nacionalidad, @edad, @modalidad, @colegioanterior, @cursoanterior, @modalidadanterior, @anioanterior, @lugaranterior);", conexionmysql.myconn)
                            mySqlCommand.Parameters.AddWithValue("@nombrealumno", Me.TextBox2.Text)
                            mySqlCommand.Parameters.AddWithValue("@identidadalumno", Me.TextBox3.Text)
                            mySqlCommand.Parameters.AddWithValue("@idp", Me.TextBox7.Text)
                            mySqlCommand.Parameters.AddWithValue("@grado", Me.ComboBox1.Text)
                            mySqlCommand.Parameters.AddWithValue("@profesion", Me.TextBox4.Text)
                            mySqlCommand.Parameters.AddWithValue("@padre", Me.TextBox6.Text)
                            mySqlCommand.Parameters.AddWithValue("@lugartrabajo", Me.TextBox5.Text)
                            mySqlCommand.Parameters.AddWithValue("@telefono", Me.TextBox9.Text)
                            str = If(Not (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "", False) = 0), Me.TextBox8.Text, "Correo electronico (opcional)")
                            mySqlCommand.Parameters.AddWithValue("@email", str)
                            mySqlCommand.Parameters.AddWithValue("@direccion", Me.TextBox13.Text)
                            mySqlCommand.Parameters.AddWithValue("@nombrepadre", Me.TextBox10.Text)
                            mySqlCommand.Parameters.AddWithValue("@lugartrabajopadre", Me.TextBox11.Text)
                            mySqlCommand.Parameters.AddWithValue("@telefonopadre", Me.TextBox15.Text)
                            mySqlCommand.Parameters.AddWithValue("@nombremadre", Me.TextBox14.Text)
                            mySqlCommand.Parameters.AddWithValue("@lugartrabajomadre", Me.TextBox12.Text)
                            mySqlCommand.Parameters.AddWithValue("@telefonomadre", Me.TextBox16.Text)
                            mySqlCommand.Parameters.AddWithValue("@deptonac", Me.TextBox20.Text)
                            mySqlCommand.Parameters.AddWithValue("@municipionac", Me.TextBox21.Text)
                            mySqlCommand.Parameters.AddWithValue("@emergencia", Me.TextBox17.Text)
                            mySqlCommand.Parameters.AddWithValue("@telefonoemergencia", Me.TextBox18.Text)
                            str1 = If(Not Me.RadioButton1.Checked, "Femenino", "Masculino")
                            mySqlCommand.Parameters.AddWithValue("@sexo", str1)
                            str2 = If(Not Me.RadioButton4.Checked, "No", "Si")
                            mySqlCommand.Parameters.AddWithValue("@condicionado", str2)
                            str3 = If(Not Me.RadioButton6.Checked, "No", "Si")
                            mySqlCommand.Parameters.AddWithValue("@repitente", str3)
                            mySqlCommand.Parameters.AddWithValue("@fechanac", RuntimeHelpers.GetObjectValue(Me.DateEdit1.EditValue))
                            mySqlCommand.Parameters.AddWithValue("@nacionalidad", Me.TextBox19.Text)
                            mySqlCommand.Parameters.AddWithValue("@edad", modulo_variables_globales.edad)
                            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Jardin", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Preparatoria", False) = 0) Then
                                str4 = "JARDIN DE NIÑOS"
                            ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "1ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "2do", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "3ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "4to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "5to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "6to", False) = 0) Then
                                str4 = "ESCUELA"
                            ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "7mo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "8vo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "9no", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "ICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIIBTPI", False) = 0) Then
                                str4 = "COLEGIO"
                            End If
                            mySqlCommand.Parameters.AddWithValue("@modalidad", str4)
                            mySqlCommand.Parameters.AddWithValue("@colegioanterior", Me.TextBox22.Text)
                            mySqlCommand.Parameters.AddWithValue("@cursoanterior", Me.ComboBox2.Text)
                            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Jardin", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Preparatoria", False) = 0) Then
                                str5 = "JARDIN DE NIÑOS"
                            ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "1ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "2do", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "3ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "4to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "5to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "6to", False) = 0) Then
                                str5 = "ESCUELA"
                            ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "7mo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "8vo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "9no", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "ICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIIBTPI", False) = 0) Then
                                str5 = "COLEGIO"
                            End If
                            mySqlCommand.Parameters.AddWithValue("@modalidadanterior", str5)
                            mySqlCommand.Parameters.AddWithValue("@anioanterior", Me.TextBox24.Text)
                            mySqlCommand.Parameters.AddWithValue("@lugaranterior", Me.TextBox25.Text)
                            ' mySqlCommand.Transaction = CType(mySqlTransaction0, MySqlTransaction)
                            ' mySqlCommand.ExecuteNonQuery()
                            '  mySqlTransaction0.Commit()
                        Catch ex As Exception
                            'Interaction.MsgBox(ex.ToString)
                            'Dim exception1 As System.Exception = exception2
                            ' mySqlTransaction0.Rollback()
                            Interaction.MsgBox(String.Concat("ERROR AL REGISTRAR", ex.Message), DirectCast(Conversions.ToInteger(String.Concat(Conversions.ToString(16), ex.ToString())), MsgBoxStyle), "Manejo de datos")
                            'ProjectData.ClearProjectError()
                        End Try
                    Finally
                        conexionmysql.Cerrar_MYBD()
                        Interaction.MsgBox("EXITO AL REGISTRAR", MsgBoxStyle.Information, "Manejo de datos")
                    End Try
                    Try
                        Me.Limpiar()
                    Catch exception3 As System.Exception
                        ProjectData.SetProjectError(exception3)
                        exception = exception3
                        ProjectData.ClearProjectError()
                    End Try
                    Return
                Else
                    Interaction.MsgBox("Por favor ingrese el Telefóno contacto de emergencia del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox18.[Select]()
                End If
            Catch exception4 As Exception
                Interaction.MsgBox(exception4.ToString)
                Try
                    Me.Limpiar()
                Catch exception3 As System.Exception
                    Interaction.MsgBox(exception3.ToString)
                End Try
                Return
            End Try
        End Sub

        Private Sub SimpleButton2Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton2.Click
            Me.Limpiar()
            MyBase.Close()
        End Sub

        Private Sub SimpleButton3Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton3.Click
            Dim str As String
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String = Nothing
            Dim str5 As String = Nothing
            Dim exception As System.Exception
            Try
                If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar el grado a matricular el alumno", MsgBoxStyle.Information, Nothing)
                    Me.ComboBox1.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar el grado del año anterior de matricula", MsgBoxStyle.Information, Nothing)
                    Me.ComboBox2.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.DateEdit1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Debe de seleccionar la fehca de nacimiento del alumno", MsgBoxStyle.Information, Nothing)
                    Me.DateEdit1.Focus()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "Correo electronico (opcional)", False) <> 0 And Not modulo_variables_globales.validar_email(Strings.LCase(Me.TextBox8.Text))) Then
                    MessageBox.Show("Direccion de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com,  por favor seleccione un correo valido", "validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox20.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el departamento de nacimiento", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox20.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox21.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el municipio de nacimiento", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox21.[Select]()
                ElseIf (Not Me.RadioButton1.Checked And Not Me.RadioButton2.Checked) Then
                    Interaction.MsgBox("Por favor seleccione el sexo", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox3.[Select]()
                ElseIf (Not Me.RadioButton4.Checked And Not Me.RadioButton3.Checked) Then
                    Interaction.MsgBox("Por favor seleccione si es condicionado", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox4.[Select]()
                ElseIf (Not Me.RadioButton6.Checked And Not Me.RadioButton5.Checked) Then
                    Interaction.MsgBox("Por favor seleccione si es repitente", MsgBoxStyle.OkOnly, Nothing)
                    Me.GroupBox5.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.DateEdit1.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione la fecha de nacimiento del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.DateEdit1.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox19.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione la nacionalidad", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox19.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "Nombre completo alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el nombre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox2.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox22.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el instituto de estudio anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox22.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox2.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor seleccione el grado de estudio anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.ComboBox2.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox24.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el ultimo año que estudio", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox24.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox25.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el lugar en donde se ubicaba el lugar de estudios anterior", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox25.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "Nombre completo padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre completo padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox6.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "# Identidad alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el  # Identidad alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox3.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "# Identidad padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el # Identidad padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox7.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "Profesion u oficio padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese la Profesion u oficio padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox4.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "Lugar de trabajo padre/encargado", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox5.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "Número telefónico", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Número telefónico del padre/encargado", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox9.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "Nombre padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox10.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "Lugar de trabajo del padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo del padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox11.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "Telefóno padre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Telefóno padre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox15.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "Nombre madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Nombre madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox14.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "Lugar de trabajo de la madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Lugar de trabajo de la madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox12.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "Telefóno madre del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Telefóno madre del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox16.[Select]()
                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "Contacto de emergencia del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "", False) = 0) Then
                    Interaction.MsgBox("Por favor ingrese el Contacto de emergencia del alumno", MsgBoxStyle.OkOnly, Nothing)
                    Me.TextBox17.[Select]()
                ElseIf (Not (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "Telefóno contacto de emergencia del alumno", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "", False) = 0)) Then
                    Interaction.MsgBox("voy por aqui #1")

                    conexionmysql.Abrir_MYBD()
                    '  Dim MySqlTransaction1 As MySql.Data.MySqlClient.MySqlTransaction = conexionmysql.myconn.BeginTransaction()

                    Try
                            Try
                                Dim str6 As String = String.Concat("Update matricula2 set nombre=@nombrealumno, identidadalumno=@identidadalumno, idp=@idp, grado=@grado, profesion=@profesion, padre=@padre, telefono=@telefono, email=@email, direccion=@direccion, lugartrabajo=@lugartrabajo, nombrepadre=@nombrepadre, lugartrabajopadre=@lugartrabajopadre, telefonopadre=@telefonopadre, nombremadre=@nombremadre, lugartrabajomadre=@lugartrabajomadre, telefonomadre=@telefonomadre, fechanac=@fechanac, edad=@edad, sexo=@sexo, modalidad=@modalidad, nacionalidad=@nacionalidad, emergencia=@emergencia, telefonoemergencia=@telefonoemergencia, deptonac=@deptonac, municipionac=@municipionac, condicionado=@condicionado, repitente=@repitente, colegioanterior=@colegioanterior, cursoanterior=@cursoanterior, modalidadanterior=@modalidadanterior, anioanterior=@anioanterior, lugaranterior=@lugaranterior  where idmatricula =", Conversions.ToString(modulo_variables_globales.valor_del_cellclick), ";")
                                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(str6, conexionmysql.myconn)
                                mySqlCommand.Parameters.AddWithValue("@nombrealumno", Me.TextBox2.Text)
                                mySqlCommand.Parameters.AddWithValue("@identidadalumno", Me.TextBox3.Text)
                                mySqlCommand.Parameters.AddWithValue("@idp", Me.TextBox7.Text)
                                mySqlCommand.Parameters.AddWithValue("@grado", Me.ComboBox1.Text)
                                mySqlCommand.Parameters.AddWithValue("@profesion", Me.TextBox4.Text)
                                mySqlCommand.Parameters.AddWithValue("@padre", Me.TextBox6.Text)
                                mySqlCommand.Parameters.AddWithValue("@telefono", Me.TextBox9.Text)
                                str = If(Not (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "Correo electronico (opcional)", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "", False) = 0), Me.TextBox8.Text, "")
                                mySqlCommand.Parameters.AddWithValue("@email", str)
                                mySqlCommand.Parameters.AddWithValue("@direccion", Me.TextBox13.Text)
                                mySqlCommand.Parameters.AddWithValue("@lugartrabajo", Me.TextBox5.Text)
                                mySqlCommand.Parameters.AddWithValue("@nombrepadre", Me.TextBox10.Text)
                                mySqlCommand.Parameters.AddWithValue("@lugartrabajopadre", Me.TextBox11.Text)
                                mySqlCommand.Parameters.AddWithValue("@telefonopadre", Me.TextBox15.Text)
                                mySqlCommand.Parameters.AddWithValue("@nombremadre", Me.TextBox14.Text)
                                mySqlCommand.Parameters.AddWithValue("@lugartrabajomadre", Me.TextBox12.Text)
                                mySqlCommand.Parameters.AddWithValue("@telefonomadre", Me.TextBox16.Text)
                                mySqlCommand.Parameters.AddWithValue("@deptonac", Me.TextBox20.Text)
                                mySqlCommand.Parameters.AddWithValue("@municipionac", Me.TextBox21.Text)
                                mySqlCommand.Parameters.AddWithValue("@emergencia", Me.TextBox17.Text)
                                mySqlCommand.Parameters.AddWithValue("@telefonoemergencia", Me.TextBox18.Text)
                                str1 = If(Not Me.RadioButton1.Checked, "Femenino", "Masculino")
                                mySqlCommand.Parameters.AddWithValue("@sexo", str1)
                                str2 = If(Not Me.RadioButton4.Checked, "No", "Si")
                                mySqlCommand.Parameters.AddWithValue("@condicionado", str2)
                                str3 = If(Not Me.RadioButton6.Checked, "No", "Si")
                                mySqlCommand.Parameters.AddWithValue("@repitente", str3)
                                mySqlCommand.Parameters.AddWithValue("@fechanac", RuntimeHelpers.GetObjectValue(Me.DateEdit1.EditValue))
                                mySqlCommand.Parameters.AddWithValue("@nacionalidad", Me.TextBox19.Text)
                                mySqlCommand.Parameters.AddWithValue("@edad", modulo_variables_globales.edad)
                                If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Jardin", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Preparatoria", False) = 0) Then
                                    str4 = "JARDIN DE NIÑOS"
                                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "1ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "2do", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "3ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "4to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "5to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "6to", False) = 0) Then
                                    str4 = "ESCUELA"
                                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "7mo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "8vo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "9no", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "ICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIIBTPI", False) = 0) Then
                                    str4 = "COLEGIO"
                                End If
                                mySqlCommand.Parameters.AddWithValue("@modalidad", str4)
                                mySqlCommand.Parameters.AddWithValue("@colegioanterior", Me.TextBox22.Text)
                                mySqlCommand.Parameters.AddWithValue("@cursoanterior", Me.ComboBox2.Text)
                                If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Jardin", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "Preparatoria", False) = 0) Then
                                    str5 = "JARDIN DE NIÑOS"
                                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "1ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "2do", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "3ro", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "4to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "5to", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "6to", False) = 0) Then
                                    str5 = "ESCUELA"
                                ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "7mo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "8vo", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "9no", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBCH", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "ICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIICONTADURIA", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIBTPI", False) = 0 Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ComboBox1.Text, "IIIBTPI", False) = 0) Then
                                    str5 = "COLEGIO"
                                End If
                                mySqlCommand.Parameters.AddWithValue("@modalidadanterior", str5)
                                mySqlCommand.Parameters.AddWithValue("@anioanterior", Me.TextBox24.Text)
                                mySqlCommand.Parameters.AddWithValue("@lugaranterior", Me.TextBox25.Text)
                            '   mySqlCommand.Transaction = mySqlTransaction1
                            mySqlCommand.ExecuteNonQuery()
                            '   mySqlTransaction1.Commit()
                        Catch ex As Exception
                            '  mySqlTransaction1.Rollback()
                            Interaction.MsgBox(String.Concat("ERROR AL ACTUALIZAR", ex.Message, ex.ToString()), MsgBoxStyle.Critical, "Manejo de datos")
                            End Try
                        Finally
                            conexionmysql.Cerrar_MYBD()
                            Interaction.MsgBox("EXITO AL ACTUALIZAR", MsgBoxStyle.Information, "Manejo de datos")
                            Me.SimpleButton1.Visible = True
                            Me.SimpleButton2.Visible = True
                            Me.SimpleButton3.Visible = False
                        End Try
                        Try
                            Me.Limpiar()
                        Catch ex As System.Exception
                        End Try
                        Return
                        Else
                        Interaction.MsgBox("Por favor ingrese el Telefóno contacto de emergencia del alumno", MsgBoxStyle.OkOnly, Nothing)
                        Me.TextBox18.[Select]()
                End If
            Catch exception4 As System.Exception

                Try
                    Me.Limpiar()
                Catch exception3 As System.Exception

                End Try
                Return
            End Try

        End Sub

        Private Sub TextBox10Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox10.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "Nombre padre del alumno", False) = 0) Then
                Me.TextBox10.Text = ""
                Me.LabelN.Visible = True
                Me.TextBox10.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox10KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox10.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox11.Focus()
                Me.TextBox11.[Select]()
            End If
        End Sub

        Private Sub TextBox10Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox10.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "", False) = 0) Then
                Me.TextBox10.Text = "Nombre padre del alumno"
                Me.LabelN.Visible = False
                Me.TextBox10.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox10TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox10.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox10.Text, "Nombre padre del alumno", False) <> 0) Then
                Me.LabelN.Visible = True
            Else
                Me.LabelN.Visible = False
            End If
        End Sub

        Private Sub TextBox11Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox11.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "Lugar de trabajo del padre del alumno", False) = 0) Then
                Me.TextBox11.Text = ""
                Me.Label5.Visible = True
                Me.TextBox11.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox11KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox11.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox15.Focus()
                Me.TextBox15.[Select]()
            End If
        End Sub

        Private Sub TextBox11Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox11.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "", False) = 0) Then
                Me.TextBox11.Text = "Lugar de trabajo del padre del alumno"
                Me.Label5.Visible = False
                Me.TextBox11.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox11TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox11.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox11.Text, "Lugar de trabajo del padre del alumno", False) <> 0) Then
                Me.Label5.Visible = True
            Else
                Me.Label5.Visible = False
            End If
        End Sub

        Private Sub TextBox12Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox12.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "Lugar de trabajo de la madre del alumno", False) = 0) Then
                Me.TextBox12.Text = ""
                Me.Label6.Visible = True
                Me.TextBox12.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox12KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox12.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox16.Focus()
                Me.TextBox16.[Select]()
            End If
        End Sub

        Private Sub TextBox12Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox12.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "", False) = 0) Then
                Me.TextBox12.Text = "Lugar de trabajo de la madre del alumno"
                Me.Label6.Visible = False
                Me.TextBox12.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox12TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox12.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox12.Text, "Lugar de trabajo de la madre del alumno", False) <> 0) Then
                Me.Label6.Visible = True
            Else
                Me.Label6.Visible = False
            End If
        End Sub

        Private Sub TextBox13Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox13.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox13.Text, "Altos de San José, Instituto Alfonso Guillén Zelaya, Tegucigalpa Honduras 11101", False) = 0) Then
                Me.TextBox13.Text = ""
                Me.TextBox13.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox13KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox13.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox20.Focus()
                Me.TextBox20.[Select]()
            End If
        End Sub

        Private Sub TextBox13Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox13.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox13.Text, "", False) = 0) Then
                Me.TextBox13.Text = "Altos de San José, Instituto Alfonso Guillén Zelaya, Tegucigalpa Honduras 11101"
                Me.TextBox13.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox14Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox14.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "Nombre madre del alumno", False) = 0) Then
                Me.TextBox14.Text = ""
                Me.Label15.Visible = True
                Me.TextBox14.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox14KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox14.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox12.Focus()
                Me.TextBox12.[Select]()
            End If
        End Sub

        Private Sub TextBox14Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox14.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "", False) = 0) Then
                Me.TextBox14.Text = "Nombre madre del alumno"
                Me.Label15.Visible = False
                Me.TextBox14.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox14TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox14.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox14.Text, "Nombre madre del alumno", False) <> 0) Then
                Me.Label15.Visible = True
            Else
                Me.Label15.Visible = False
            End If
        End Sub

        Private Sub TextBox15Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox15.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "Telefóno padre del alumno", False) = 0) Then
                Me.TextBox15.Text = ""
                Me.Label8.Visible = True
                Me.TextBox15.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox15KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox15.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox14.Focus()
                Me.TextBox14.[Select]()
            End If
        End Sub

        Private Sub TextBox15Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox15.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "", False) = 0) Then
                Me.TextBox15.Text = "Telefóno padre del alumno"
                Me.Label8.Visible = False
                Me.TextBox15.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox15TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox15.TextChanged
            If (Me.TextBox15.Text.Length = 4) Then
                Me.TextBox15.Text = String.Concat(Me.TextBox15.Text, "-")
                Me.TextBox15.[Select](Me.TextBox15.Text.Length, 0)
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox15.Text, "Telefóno padre del alumno", False) <> 0) Then
                Me.Label8.Visible = True
            Else
                Me.Label8.Visible = False
            End If
        End Sub

        Private Sub TextBox16Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox16.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "Telefóno madre del alumno", False) = 0) Then
                Me.TextBox16.Text = ""
                Me.Label18.Visible = True
                Me.TextBox16.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox16KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox16.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox13.Focus()
                Me.TextBox13.[Select]()
            End If
        End Sub

        Private Sub TextBox16Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox16.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "", False) = 0) Then
                Me.TextBox16.Text = "Telefóno madre del alumno"
                Me.Label8.Visible = False
                Me.TextBox16.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox16TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox16.TextChanged
            If (Me.TextBox16.Text.Length = 4) Then
                Me.TextBox16.Text = String.Concat(Me.TextBox16.Text, "-")
                Me.TextBox16.[Select](Me.TextBox16.Text.Length, 0)
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox16.Text, "Telefóno madre del alumno", False) <> 0) Then
                Me.Label18.Visible = True
            Else
                Me.Label18.Visible = False
            End If
        End Sub

        Private Sub TextBox17Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox17.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "Contacto de emergencia del alumno", False) = 0) Then
                Me.TextBox17.Text = ""
                Me.Label19.Visible = True
                Me.TextBox17.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox17KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox17.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox18.Focus()
                Me.TextBox18.[Select]()
            End If
        End Sub

        Private Sub TextBox17Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox17.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "", False) = 0) Then
                Me.TextBox17.Text = "Contacto de emergencia del alumno"
                Me.Label19.Visible = False
                Me.TextBox17.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox17TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox17.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox17.Text, "Contacto de emergencia del alumno", False) <> 0) Then
                Me.Label19.Visible = True
            Else
                Me.Label19.Visible = False
            End If
        End Sub

        Private Sub TextBox18Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox18.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "Telefóno contacto de emergencia del alumno", False) = 0) Then
                Me.TextBox18.Text = ""
                Me.Label20.Visible = True
                Me.TextBox18.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox18KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox18.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox19.Focus()
                Me.TextBox19.[Select]()
            End If
        End Sub

        Private Sub TextBox18Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox18.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "", False) = 0) Then
                Me.TextBox18.Text = "Telefóno contacto de emergencia del alumno"
                Me.Label20.Visible = False
                Me.TextBox18.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox18TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox18.TextChanged
            If (Me.TextBox18.Text.Length = 4) Then
                Me.TextBox18.Text = String.Concat(Me.TextBox18.Text, "-")
                Me.TextBox18.[Select](Me.TextBox18.Text.Length, 0)
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox18.Text, "Telefóno contacto de emergencia del alumno", False) <> 0) Then
                Me.Label20.Visible = True
            Else
                Me.Label20.Visible = False
            End If
        End Sub

        Private Sub TextBox2Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "Nombre completo alumno", False) = 0) Then
                Me.TextBox2.Text = ""
                Me.Label10.Visible = True
                Me.TextBox2.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox2KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox2.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox3.Focus()
                Me.TextBox3.[Select]()
            End If
        End Sub

        Private Sub TextBox2KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox2.KeyUp
            Try
                Me.TextBox2.Text = Validacion_Caracteres.EliminarCaracteresRepetidos(Me.TextBox2.Text)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.TextBox2.[Select](Me.TextBox2.Text.Length, 0)
        End Sub

        Private Sub TextBox2Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "", False) = 0) Then
                Me.TextBox2.Text = "Nombre completo alumno"
                Me.Label10.Visible = False
                Me.TextBox2.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox2TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox2.Text, "Nombre completo alumno", False) <> 0) Then
                Me.Label10.Visible = True
            Else
                Me.Label10.Visible = False
            End If
        End Sub

        Private Sub TextBox20KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox20.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox21.Focus()
                Me.TextBox21.[Select]()
            End If
        End Sub

        Private Sub TextBox21KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox21.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox17.Focus()
                Me.TextBox17.[Select]()
            End If
        End Sub

        Private Sub TextBox3Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "# Identidad alumno", False) = 0) Then
                Me.TextBox3.Text = ""
                Me.Label12.Visible = True
                Me.TextBox3.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox3KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox3.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox6.Focus()
                Me.TextBox6.[Select]()
            End If
        End Sub

        Private Sub TextBox3KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox3.KeyPress
            Validacion_Caracteres.Validacion_numerica(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Private Sub TextBox3KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try
                Me.TextBox3.Text = Validacion_Caracteres.EliminarCaracteresRepetidos(Me.TextBox3.Text)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.TextBox3.[Select](Me.TextBox3.Text.Length, 0)
        End Sub

        Private Sub TextBox3Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "", False) = 0) Then
                Me.TextBox3.Text = "# Identidad alumno"
                Me.Label12.Visible = False
                Me.TextBox3.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox3TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox3.Text, "# Identidad alumno", False) <> 0) Then
                Me.Label12.Visible = True
            Else
                Me.Label12.Visible = False
            End If
        End Sub

        Private Sub TextBox4Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "Profesion u oficio padre/encargado", False) = 0) Then
                Me.TextBox4.Text = ""
                Me.Label14.Visible = True
                Me.TextBox4.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox4KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox4.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox5.Focus()
                Me.TextBox5.[Select]()
            End If
        End Sub

        Private Sub TextBox4Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "", False) = 0) Then
                Me.TextBox4.Text = "Profesion u oficio padre/encargado"
                Me.Label14.Visible = False
                Me.TextBox4.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox4TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox4.Text, "Profesion u oficio padre/encargado", False) <> 0) Then
                Me.Label14.Visible = True
            Else
                Me.Label14.Visible = False
            End If
        End Sub

        Private Sub TextBox5Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "Lugar de trabajo padre/encargado", False) = 0) Then
                Me.TextBox5.Text = ""
                Me.Label1.Visible = True
                Me.TextBox5.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox5KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox5.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox8.Focus()
                Me.TextBox8.[Select]()
            End If
        End Sub

        Private Sub TextBox5Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "", False) = 0) Then
                Me.TextBox5.Text = "Lugar de trabajo padre/encargado"
                Me.Label1.Visible = False
                Me.TextBox5.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox5TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox5.Text, "Lugar de trabajo padre/encargado", False) <> 0) Then
                Me.Label1.Visible = True
            Else
                Me.Label1.Visible = False
            End If
        End Sub

        Private Sub TextBox6Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "Nombre completo padre/encargado", False) = 0) Then
                Me.TextBox6.Text = ""
                Me.Label11.Visible = True
                Me.TextBox6.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox6KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox6.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox7.Focus()
                Me.TextBox7.[Select]()
            End If
        End Sub

        Private Sub TextBox6KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox6.KeyUp
            Try
                Me.TextBox6.Text = Validacion_Caracteres.EliminarCaracteresRepetidos(Me.TextBox6.Text)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.TextBox6.[Select](Me.TextBox6.Text.Length, 0)
        End Sub

        Private Sub TextBox6Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "", False) = 0) Then
                Me.TextBox6.Text = "Nombre completo padre/encargado"
                Me.Label11.Visible = False
                Me.TextBox6.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox6TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox6.Text, "Nombre completo padre/encargado", False) <> 0) Then
                Me.Label11.Visible = True
            Else
                Me.Label11.Visible = False
            End If
        End Sub

        Private Sub TextBox7Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox7.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "# Identidad padre/encargado", False) = 0) Then
                Me.TextBox7.Text = ""
                Me.Label13.Visible = True
                Me.TextBox7.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox7KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox7.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox4.Focus()
                Me.TextBox4.[Select]()
            End If
        End Sub

        Private Sub TextBox7KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox7.KeyPress
            Validacion_Caracteres.Validacion_numerica(RuntimeHelpers.GetObjectValue(sender), e)
        End Sub

        Private Sub TextBox7KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox7.KeyUp
            Try
                Me.TextBox7.Text = Validacion_Caracteres.EliminarCaracteresRepetidos(Me.TextBox7.Text)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
            Me.TextBox7.[Select](Me.TextBox7.Text.Length, 0)
        End Sub

        Private Sub TextBox7Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox7.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "", False) = 0) Then
                Me.TextBox7.Text = "# Identidad padre/encargado"
                Me.Label13.Visible = False
                Me.TextBox7.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox7TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox7.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox7.Text, "# Identidad padre/encargado", False) <> 0) Then
                Me.Label13.Visible = True
            Else
                Me.Label13.Visible = False
            End If
        End Sub

        Private Sub TextBox8Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "Correo electronico (opcional)", False) = 0) Then
                Me.TextBox8.Text = ""
                Me.Label16.Visible = True
                Me.TextBox8.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox8KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox8.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox9.Focus()
                Me.TextBox9.[Select]()
            End If
        End Sub

        Private Sub TextBox8Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "", False) = 0) Then
                Me.TextBox8.Text = "Correo electronico (opcional)"
                Me.Label16.Visible = False
                Me.TextBox8.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox8TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.TextChanged
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox8.Text, "Correo electronico (opcional)", False) <> 0) Then
                Me.Label16.Visible = True
            Else
                Me.Label16.Visible = False
            End If
        End Sub

        Private Sub TextBox9Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox9.Enter
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "Número telefónico", False) = 0) Then
                Me.TextBox9.Text = ""
                Me.Label17.Visible = True
                Me.TextBox9.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox9KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox9.KeyDown
            If (e.KeyData = Keys.[Return]) Then
                Me.TextBox10.Focus()
                Me.TextBox10.[Select]()
            End If
        End Sub

        Private Sub TextBox9KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox9.KeyPress
            Validacion_Caracteres.Validacion_numerica(RuntimeHelpers.GetObjectValue(sender), e)
            If (e.KeyChar = Convert.ToChar(8)) Then
                Me.TextBox9.[Select](Me.TextBox9.Text.Length, -2)
            End If
        End Sub

        Private Sub TextBox9Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox9.Leave
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "", False) = 0) Then
                Me.TextBox9.Text = "Número telefónico"
                Me.Label17.Visible = False
                Me.TextBox9.ForeColor = Color.Black
            End If
        End Sub

        Private Sub TextBox9TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox9.TextChanged
            If (Me.TextBox9.Text.Length = 4) Then
                Me.TextBox9.Text = String.Concat(Me.TextBox9.Text, "-")
                Me.TextBox9.[Select](Me.TextBox9.Text.Length, 0)
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextBox9.Text, "Número telefónico", False) <> 0) Then
                Me.Label17.Visible = True
            Else
                Me.Label17.Visible = False
            End If
        End Sub
    End Class
End Namespace