<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.btnProductos = New FontAwesome.Sharp.IconButton()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
        Me.btnCompras = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logo = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Minimisar = New FontAwesome.Sharp.IconPictureBox()
        Me.Agrandar = New FontAwesome.Sharp.IconPictureBox()
        Me.Salir = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrandar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(183, 529)
        Me.PanelMenu.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        Me.btnSalir.IconColor = System.Drawing.Color.White
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.IconSize = 32
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSalir.Size = New System.Drawing.Size(183, 60)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Cerrar Sesion"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.btnProductos.IconColor = System.Drawing.Color.White
        Me.btnProductos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProductos.IconSize = 32
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 327)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProductos.Size = New System.Drawing.Size(183, 60)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.btnVentas.IconColor = System.Drawing.Color.White
        Me.btnVentas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVentas.IconSize = 32
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 267)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVentas.Size = New System.Drawing.Size(183, 60)
        Me.btnVentas.TabIndex = 4
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnCompras
        '
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnCompras.IconColor = System.Drawing.Color.White
        Me.btnCompras.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCompras.IconSize = 32
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 207)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCompras.Size = New System.Drawing.Size(183, 60)
        Me.btnCompras.TabIndex = 3
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnClientes.IconColor = System.Drawing.Color.White
        Me.btnClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClientes.IconSize = 32
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 147)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnClientes.Size = New System.Drawing.Size(183, 60)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 87)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(183, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(183, 47)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(731, 482)
        Me.PanelDesktop.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(208, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'Logo
        '
        Me.Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logo.FlatAppearance.BorderSize = 0
        Me.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logo.ForeColor = System.Drawing.Color.White
        Me.Logo.IconChar = FontAwesome.Sharp.IconChar.House
        Me.Logo.IconColor = System.Drawing.Color.White
        Me.Logo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Logo.IconSize = 32
        Me.Logo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Logo.Location = New System.Drawing.Point(0, 0)
        Me.Logo.Name = "Logo"
        Me.Logo.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Logo.Size = New System.Drawing.Size(183, 60)
        Me.Logo.TabIndex = 2
        Me.Logo.Text = "Home"
        Me.Logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logo.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Logo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 87)
        Me.Panel3.TabIndex = 0
        '
        'IconTitle
        '
        Me.IconTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconTitle.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconTitle.IconColor = System.Drawing.Color.White
        Me.IconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconTitle.Location = New System.Drawing.Point(10, 6)
        Me.IconTitle.Name = "IconTitle"
        Me.IconTitle.Size = New System.Drawing.Size(32, 32)
        Me.IconTitle.TabIndex = 0
        Me.IconTitle.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(51, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(45, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Home"
        '
        'Minimisar
        '
        Me.Minimisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Minimisar.ForeColor = System.Drawing.Color.Silver
        Me.Minimisar.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.Minimisar.IconColor = System.Drawing.Color.Silver
        Me.Minimisar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Minimisar.IconSize = 24
        Me.Minimisar.Location = New System.Drawing.Point(665, 3)
        Me.Minimisar.Name = "Minimisar"
        Me.Minimisar.Size = New System.Drawing.Size(24, 25)
        Me.Minimisar.TabIndex = 3
        Me.Minimisar.TabStop = False
        '
        'Agrandar
        '
        Me.Agrandar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Agrandar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Agrandar.ForeColor = System.Drawing.Color.Silver
        Me.Agrandar.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.Agrandar.IconColor = System.Drawing.Color.Silver
        Me.Agrandar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Agrandar.IconSize = 24
        Me.Agrandar.Location = New System.Drawing.Point(686, 3)
        Me.Agrandar.Name = "Agrandar"
        Me.Agrandar.Size = New System.Drawing.Size(24, 25)
        Me.Agrandar.TabIndex = 4
        Me.Agrandar.TabStop = False
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Salir.ForeColor = System.Drawing.Color.Silver
        Me.Salir.IconChar = FontAwesome.Sharp.IconChar.X
        Me.Salir.IconColor = System.Drawing.Color.Silver
        Me.Salir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Salir.IconSize = 24
        Me.Salir.Location = New System.Drawing.Point(707, 3)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(24, 25)
        Me.Salir.TabIndex = 5
        Me.Salir.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.Salir)
        Me.PanelTitle.Controls.Add(Me.Agrandar)
        Me.PanelTitle.Controls.Add(Me.Minimisar)
        Me.PanelTitle.Controls.Add(Me.lblTitle)
        Me.PanelTitle.Controls.Add(Me.IconTitle)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(183, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(731, 47)
        Me.PanelTitle.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 529)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrandar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProductos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCompras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Logo As FontAwesome.Sharp.IconButton
    Friend WithEvents IconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Minimisar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Agrandar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Salir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelTitle As Panel
End Class
