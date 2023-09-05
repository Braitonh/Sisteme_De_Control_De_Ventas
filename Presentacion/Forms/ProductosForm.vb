Imports Negocio
Public Class ProductosForm

    Dim productModel As New ProductoModel

    Public Sub GetListProdut()

        Try
            DataGridViewProductos.DataSource = productModel.GetAllProducts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ProductosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetListProdut()
    End Sub
End Class