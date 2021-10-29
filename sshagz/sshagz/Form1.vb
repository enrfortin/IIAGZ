Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports Microsoft.VisualBasic.CompilerServices
Imports Renci.SshNet
Imports ssh.My
Imports ssh.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ssh
	<DesignerGenerated>
	Public Class Form1
		Inherits Form
		Private components As IContainer



        Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
            Get
                Dim style As System.Windows.Forms.CreateParams = MyBase.CreateParams
                style.Style = style.Style Or 131072
                style.Style = style.Style Or 64
                Return style
            End Get
        End Property



        Private Sub CerrarElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles Cerrar.ElementClick
            Application.Exit()
        End Sub

        <DebuggerNonUserCode>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If (If(Not disposing, False, Me.components IsNot Nothing)) Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private Sub Form1FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If (MessageBox.Show("¿Realmente desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes) Then
                e.Cancel = True
            Else
                Try
                    Module1.portForwarded.Stop()
                    Module1.sshClient.Disconnect()
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                End Try
                Application.Exit()
            End If
        End Sub

        Private Sub Form1Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            conexionmysql.ssh()
        End Sub

        Private Sub Form1MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
            Releasecapture()
            SendMessage(MyBase.Handle, 274, 61458, 0)
        End Sub





        <System.Diagnostics.DebuggerStepThrough()>
            Public Sub InitializeComponent()
            Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemFrame1 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
            Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemFrame2 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
            Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemFrame3 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
            Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
            Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
            Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
            Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
            Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
            Me.TileGroup4 = New DevExpress.XtraEditors.TileGroup()
            Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
            Me.TileItem7 = New DevExpress.XtraEditors.TileItem()
            Me.TileItem6 = New DevExpress.XtraEditors.TileItem()
            Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
            Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
            Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
            Me.NavButton3 = New DevExpress.XtraBars.Navigation.NavButton()
            Me.Cerrar = New DevExpress.XtraBars.Navigation.NavButton()
            Me.SuspendLayout()
            '
            'TileControl1
            '
            Me.TileControl1.BackColor = System.Drawing.Color.Transparent
            Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
            Me.TileControl1.Groups.Add(Me.TileGroup2)
            Me.TileControl1.Groups.Add(Me.TileGroup4)
            Me.TileControl1.ItemSize = 180
            Me.TileControl1.Location = New System.Drawing.Point(61, 121)
            Me.TileControl1.MaxId = 20
            Me.TileControl1.Name = "TileControl1"
            Me.TileControl1.Size = New System.Drawing.Size(946, 434)
            Me.TileControl1.TabIndex = 0
            Me.TileControl1.Text = "TileControl1"
            '
            'TileGroup2
            '
            Me.TileGroup2.Items.Add(Me.TileItem5)
            Me.TileGroup2.Items.Add(Me.TileItem2)
            Me.TileGroup2.Items.Add(Me.TileItem4)
            Me.TileGroup2.Name = "TileGroup2"
            '
            'TileItem5
            '
            Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrange
            Me.TileItem5.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem5.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem5.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem5.AppearanceItem.Normal.Options.UseFont = True
            Me.TileItem5.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            Me.TileItem5.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollLeft
            TileItemElement1.Image = Global.Resources.man
            TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            TileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            TileItemElement1.Text = "Agregar registro online"
            TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
            Me.TileItem5.Elements.Add(TileItemElement1)
            TileItemElement2.Image = Global.Resources.man
            TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            TileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            TileItemElement2.Text = "Agregar registro online"
            TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
            TileItemFrame1.Elements.Add(TileItemElement2)
            TileItemFrame1.Image = Global.Resources.man
            Me.TileItem5.Frames.Add(TileItemFrame1)
            Me.TileItem5.Id = 9
            Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
            Me.TileItem5.Name = "TileItem5"
            '
            'TileItem2
            '
            Me.TileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Peru
            Me.TileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem2.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem2.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gainsboro
            Me.TileItem2.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
            Me.TileItem2.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem2.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem2.AppearanceItem.Normal.Options.UseFont = True
            Me.TileItem2.AppearanceItem.Normal.Options.UseForeColor = True
            TileItemElement3.Image = Global.Resources.audit
            TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
            TileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
            TileItemElement3.Text = "Buscar registro"
            TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
            Me.TileItem2.Elements.Add(TileItemElement3)
            Me.TileItem2.Id = 1
            Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem2.Name = "TileItem2"
            Me.TileItem2.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always
            '
            'TileItem4
            '
            Me.TileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.Purple
            Me.TileItem4.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem4.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem4.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem4.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem4.AppearanceItem.Normal.Options.UseFont = True
            TileItemElement4.Image = Global.Resources.man
            TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
            TileItemElement4.Text = "Editar registro alumno"
            Me.TileItem4.Elements.Add(TileItemElement4)
            Me.TileItem4.Id = 12
            Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem4.Name = "TileItem4"
            '
            'TileGroup4
            '
            Me.TileGroup4.Items.Add(Me.TileItem1)
            Me.TileGroup4.Items.Add(Me.TileItem7)
            Me.TileGroup4.Items.Add(Me.TileItem6)
            Me.TileGroup4.Items.Add(Me.TileItem3)
            Me.TileGroup4.Name = "TileGroup4"
            '
            'TileItem1
            '
            Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem1.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem1.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black
            Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem1.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem1.AppearanceItem.Normal.Options.UseFont = True
            Me.TileItem1.AppearanceItem.Normal.Options.UseForeColor = True
            TileItemElement5.Image = Global.Resources.contrato
            TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
            TileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
            TileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
            TileItemElement5.Text = "Contratos de servicio"
            TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
            Me.TileItem1.Elements.Add(TileItemElement5)
            Me.TileItem1.Id = 6
            Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem1.Name = "TileItem1"
            '
            'TileItem7
            '
            Me.TileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TileItem7.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem7.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem7.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem7.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem7.AppearanceItem.Normal.Options.UseFont = True
            Me.TileItem7.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade
            Me.TileItem7.CurrentFrameIndex = 1
            TileItemElement6.Image = Global.Resources.siflogopng2
            TileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
            TileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None
            TileItemElement6.Text = "Contactar soporte"
            TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
            Me.TileItem7.Elements.Add(TileItemElement6)
            TileItemElement7.Image = Global.Resources.email
            TileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
            TileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None
            TileItemElement7.Text = "Contactar soporte"
            TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
            TileItemFrame2.Elements.Add(TileItemElement7)
            TileItemFrame2.Image = Global.Resources.email
            TileItemElement8.Image = Global.Resources.siflogopng2
            TileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
            TileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None
            TileItemElement8.Text = "Contactar soporte"
            TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
            TileItemFrame3.Elements.Add(TileItemElement8)
            TileItemFrame3.Image = Global.Resources.siflogopng2
            Me.TileItem7.Frames.Add(TileItemFrame2)
            Me.TileItem7.Frames.Add(TileItemFrame3)
            Me.TileItem7.Id = 14
            Me.TileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem7.Name = "TileItem7"
            '
            'TileItem6
            '
            Me.TileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem6.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem6.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem6.AppearanceItem.Normal.Options.UseFont = True
            TileItemElement9.Image = Global.Resources.kyc
            TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
            TileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            TileItemElement9.Text = "Ver listado de matricula"
            Me.TileItem6.Elements.Add(TileItemElement9)
            Me.TileItem6.Id = 18
            Me.TileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem6.Name = "TileItem6"
            '
            'TileItem3
            '
            Me.TileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.LightCoral
            Me.TileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black
            Me.TileItem3.AppearanceItem.Normal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TileItem3.AppearanceItem.Normal.Options.UseBackColor = True
            Me.TileItem3.AppearanceItem.Normal.Options.UseBorderColor = True
            Me.TileItem3.AppearanceItem.Normal.Options.UseFont = True
            TileItemElement10.Image = Global.Resources.document
            TileItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            TileItemElement10.Text = "Ver ficha de matricula"
            Me.TileItem3.Elements.Add(TileItemElement10)
            Me.TileItem3.Id = 19
            Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            Me.TileItem3.Name = "TileItem3"
            '
            'TileNavPane1
            '
            Me.TileNavPane1.Appearance.BackColor = System.Drawing.Color.DarkOrange
            Me.TileNavPane1.Appearance.Options.UseBackColor = True
            Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
            Me.TileNavPane1.Buttons.Add(Me.NavButton2)
            Me.TileNavPane1.Buttons.Add(Me.NavButton3)
            Me.TileNavPane1.Buttons.Add(Me.Cerrar)
            '
            'TileNavCategory1
            '
            Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
            Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
            Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
            '
            '
            '
            Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            Me.TileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
            Me.TileNavPane1.Location = New System.Drawing.Point(0, 0)
            Me.TileNavPane1.Name = "TileNavPane1"
            Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
            Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
            Me.TileNavPane1.Size = New System.Drawing.Size(1050, 40)
            Me.TileNavPane1.TabIndex = 2
            Me.TileNavPane1.Text = "TileNavPane1"
            '
            'NavButton2
            '
            Me.NavButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.NavButton2.Appearance.Options.UseBackColor = True
            Me.NavButton2.Caption = "Menú principal "
            Me.NavButton2.IsMain = True
            Me.NavButton2.Name = "NavButton2"
            Me.NavButton2.Visible = False
            '
            'NavButton3
            '
            Me.NavButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
            Me.NavButton3.Caption = "Minimizar"
            Me.NavButton3.Name = "NavButton3"
            '
            'Cerrar
            '
            Me.Cerrar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
            Me.Cerrar.Appearance.Image = Global.Resources.close
            Me.Cerrar.Appearance.Options.UseImage = True
            Me.Cerrar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Cerrar.AppearanceHovered.Options.UseBackColor = True
            Me.Cerrar.AppearanceSelected.Image = Global.Resources.close_x
            Me.Cerrar.AppearanceSelected.Options.UseImage = True
            Me.Cerrar.Caption = "Cerrar"
            Me.Cerrar.Name = "Cerrar"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.BackgroundImage = Global.Resources.windows_8_1_wallpaper_remodeled_wallpaper_preview
            Me.ClientSize = New System.Drawing.Size(1050, 567)
            Me.Controls.Add(Me.TileNavPane1)
            Me.Controls.Add(Me.TileControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MATRICULA AGZ"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
        Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
        Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
        Friend WithEvents TileItem5 As TileItem
        Friend WithEvents TileItem2 As TileItem
        Friend WithEvents TileItem4 As TileItem
        Friend WithEvents TileItem1 As TileItem
        Friend WithEvents TileItem7 As TileItem
        Friend WithEvents TileItem6 As TileItem
        Friend WithEvents TileItem3 As TileItem
        Friend WithEvents TileGroup4 As DevExpress.XtraEditors.TileGroup
        Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
        Friend WithEvents NavButton3 As DevExpress.XtraBars.Navigation.NavButton
        Friend WithEvents Cerrar As DevExpress.XtraBars.Navigation.NavButton


        Private Sub NavButton3ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles NavButton3.ElementClick
            MyBase.WindowState = FormWindowState.Minimized
        End Sub

        <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
        Private Shared Sub Releasecapture()
        End Sub

        <DllImport("user32.dll", EntryPoint:="SendMessage")>
        Private Shared Sub SendMessage(ByVal hand As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)

        End Sub

        Private Sub TileItem1ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem1.ItemClick
            MyProject.Forms.contratos.Show()
        End Sub

        Private Sub TileItem2ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem2.ItemClick
            MyProject.Forms.buscar.Show()
        End Sub

        Private Sub TileItem3ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem3.ItemClick
            MyProject.Forms.buscar_ficha.Show()
        End Sub

        Private Sub TileItem4ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem4.ItemClick
            MyProject.Forms.listado.Show()
        End Sub

        Private Sub TileItem5ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem5.ItemClick
            MyProject.Forms.Registro.Limpiar()
            MyProject.Forms.Registro.Show()
            MyProject.Forms.Registro.Label7.Text = "Registro de nuevo alumno"
            MyProject.Forms.Registro.SimpleButton3.Visible = False
            'MessageBox.Show(conexionmysql.myconn.State.ToString)
        End Sub

        Private Sub TileItem6ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem6.ItemClick
            MyProject.Forms.todos_registros.Show()
        End Sub

        Private Sub TileItem7ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles TileItem7.ItemClick
            MyProject.Forms.browser.Show()
        End Sub

        Private Sub TileNavPane1MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TileNavPane1.MouseMove
            Releasecapture()
            SendMessage(MyBase.Handle, 274, 61458, 0)
        End Sub



    End Class
End Namespace