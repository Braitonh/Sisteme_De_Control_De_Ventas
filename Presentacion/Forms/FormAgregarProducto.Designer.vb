<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAgregarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.Salir = New FontAwesome.Sharp.IconPictureBox()
        Me.Agrandar = New FontAwesome.Sharp.IconPictureBox()
        Me.Minimisar = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrandar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(16, 77)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(304, 23)
        Me.txtCodigo.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(16, 124)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(304, 23)
        Me.txtNombre.TabIndex = 1
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(16, 171)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(304, 23)
        Me.txtPrecio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Agregar Producto"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnGuardar.IconColor = System.Drawing.Color.White
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.IconSize = 35
        Me.btnGuardar.Location = New System.Drawing.Point(16, 220)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(304, 43)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel
        Me.btnCancelar.IconColor = System.Drawing.Color.White
        Me.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancelar.IconSize = 35
        Me.btnCancelar.Location = New System.Drawing.Point(16, 269)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(304, 43)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Salir.ForeColor = System.Drawing.Color.Silver
        Me.Salir.IconChar = FontAwesome.Sharp.IconChar.X
        Me.Salir.IconColor = System.Drawing.Color.Silver
        Me.Salir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Salir.IconSize = 18
        Me.Salir.Location = New System.Drawing.Point(305, 5)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(18, 18)
        Me.Salir.TabIndex = 11
        Me.Salir.TabStop = False
        '
        'Agrandar
        '
        Me.Agrandar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Agrandar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Agrandar.ForeColor = System.Drawing.Color.Silver
        Me.Agrandar.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.Agrandar.IconColor = System.Drawing.Color.Silver
        Me.Agrandar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Agrandar.IconSize = 18
        Me.Agrandar.Location = New System.Drawing.Point(284, 5)
        Me.Agrandar.Name = "Agrandar"
        Me.Agrandar.Size = New System.Drawing.Size(18, 18)
        Me.Agrandar.TabIndex = 10
        Me.Agrandar.TabStop = False
        '
        'Minimisar
        '
        Me.Minimisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Minimisar.ForeColor = System.Drawing.Color.Silver
        Me.Minimisar.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.Minimisar.IconColor = System.Drawing.Color.Silver
        Me.Minimisar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Minimisar.IconSize = 18
        Me.Minimisar.Location = New System.Drawing.Point(263, 5)
        Me.Minimisar.Name = "Minimisar"
        Me.Minimisar.Size = New System.Drawing.Size(18, 18)
        Me.Minimisar.TabIndex = 9
        Me.Minimisar.TabStop = False
        '
        'FormAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(333, 335)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Agrandar)
        Me.Controls.Add(Me.Minimisar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(900, 100)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormAgregarProducto"
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrandar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents Salir As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Agrandar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Minimisar As FontAwesome.Sharp.IconPictureBox
    Public WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Public WithEvents txtCodigo As TextBox
    Public WithEvents txtNombre As TextBox
    Public WithEvents txtPrecio As TextBox
End Class
