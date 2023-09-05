Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class MainForm

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)

        PanelMenu.Controls.Add(leftBorderBtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


    End Sub

    'Styles
#Region "Styles"
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)

        If senderBtn IsNot Nothing Then
            DisableButtton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(26, 25, 62)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'Current Form icon
            IconTitle.IconChar = currentBtn.IconChar
            IconTitle.IconColor = customColor

        End If

    End Sub

    Private Sub DisableButtton()
        'Button

        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(26, 25, 62)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If


    End Sub

    'Drag Form

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

#End Region



    'Methos
#Region "Methos"

    Private Sub OpenChildForm(childForm As Form)

        'Para abrir el formulario hijo
        If currentChildForm IsNot Nothing Then

            currentChildForm.Close()

        End If

        currentChildForm = childForm
        'fin

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()


    End Sub

    Private Sub ResetButton()

        DisableButtton()
        leftBorderBtn.Visible = False
        IconTitle.IconChar = IconChar.Home
        IconTitle.IconColor = Color.White
        lblTitle.ForeColor = Color.White
        lblTitle.Text = "Home"

    End Sub

#End Region


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColores.color1)
        lblTitle.ForeColor = RGBColores.color1
        lblTitle.Text = btnDashboard.Text
        OpenChildForm(New DashboardForm)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivateButton(sender, RGBColores.color2)
        lblTitle.ForeColor = RGBColores.color2
        lblTitle.Text = btnClientes.Text
        OpenChildForm(New DashboardForm)
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        ActivateButton(sender, RGBColores.color3)
        lblTitle.ForeColor = RGBColores.color3
        lblTitle.Text = btnCompras.Text
        OpenChildForm(New DashboardForm)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivateButton(sender, RGBColores.color4)
        lblTitle.ForeColor = RGBColores.color4
        lblTitle.Text = btnVentas.Text
        OpenChildForm(New DashboardForm)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        ActivateButton(sender, RGBColores.color5)
        lblTitle.ForeColor = RGBColores.color5
        lblTitle.Text = btnProductos.Text
        OpenChildForm(New ProductosForm)
    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click

        If currentChildForm IsNot Nothing Then

            currentChildForm.Close()

        End If

        ResetButton()

    End Sub

    Private Sub PanelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub

    Private Sub Agrandar_Click(sender As Object, e As EventArgs) Handles Agrandar.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Minimisar_Click(sender As Object, e As EventArgs) Handles Minimisar.Click
        WindowState = FormWindowState.Minimized
    End Sub


End Class