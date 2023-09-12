Imports Negocio
Public Class ProductosForm

    Dim productModel As New ProductoModel

    Public Sub cambiarColor()
        btnEditar.BackColor = Color.Black
    End Sub

    Public Sub GetListProdut()

        Try
            DataGridViewProductos.DataSource = productModel.GetAllProducts()
            DataGridViewProductos.Columns(4).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ProductosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListProdut()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        FormAgregarProducto.ShowDialog()


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If DataGridViewProductos.SelectedRows.Count > 0 Then

            productModel.Product_Id = DataGridViewProductos.CurrentRow.Cells(0).Value
            productModel.State = EntityState.Deleted
            Dim result = productModel.SaveChanges()
            MessageBox.Show(result)
            GetListProdut()


        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim formEditProduct As New FormAgregarProducto

        formEditProduct.txtCodigo.Text = DataGridViewProductos.CurrentRow.Cells(1).Value.ToString()
        formEditProduct.txtNombre.Text = DataGridViewProductos.CurrentRow.Cells(2).Value.ToString()
        formEditProduct.txtPrecio.Text = DataGridViewProductos.CurrentRow.Cells(3).Value.ToString()
        formEditProduct.ShowDialog()

    End Sub
End Class