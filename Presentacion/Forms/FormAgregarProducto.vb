Imports Negocio
Public Class FormAgregarProducto

    Dim productModel As New ProductoModel
    Dim formProducto As New ProductosForm()


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        productModel.State = EntityState.Added

        productModel.ProductNumber = txtCodigo.Text
        productModel.Name = txtNombre.Text
        productModel.Price = txtPrecio.Text

        Dim valid = New Validation(productModel).validate

        If valid = True Then
            Dim result = productModel.SaveChanges()
            MessageBox.Show(result)
            formProducto.GetListProdut()
            Restart()

        End If

    End Sub



    Private Sub Restart()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
    End Sub
End Class