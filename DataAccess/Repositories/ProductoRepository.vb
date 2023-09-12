Imports MySql.Data.MySqlClient
Public Class ProductoRepository

    Inherits MasterRepository
    Implements IProductoRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()

        selectAll = "SELECT * FROM producto"
        insert = "INSERT INTO producto (productNumber, name, price) VALUES (@productNumber,@name,@price)"
        update = "UPDATE producto SET  productNumber=@productNumber,name=@name,price=@price WHERE product_Id=@product_Id"
        delete = "DELETE FROM producto WHERE product_Id=@product_Id"

    End Sub

    Public Function GetAll() As IEnumerable(Of Producto) Implements iGenericRepository(Of Producto).GetAll

        Dim resulTable = ExecuteRender(selectAll)
        Dim listProduct = New List(Of Producto)

        'este código está extrayendo datos de una tabla de base de datos y los agrego a la lista listProduct
        For Each item As DataRow In resulTable.Rows

            listProduct.Add(New Producto With {
            .product_Id = item(0),
            .productNumber = item(1),
            .name = item(2),
            .price = item(3)
            })

        Next

        Return listProduct

    End Function

    Public Function Add(entity As Producto) As Integer Implements iGenericRepository(Of Producto).Add

        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@productNumber", entity.productNumber))
        parameters.Add(New MySqlParameter("@name", entity.name))
        parameters.Add(New MySqlParameter("@price", entity.price))



        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Producto) As Integer Implements iGenericRepository(Of Producto).Edit

        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@product_Id", entity.product_Id))
        parameters.Add(New MySqlParameter("@productNumber", entity.productNumber))
        parameters.Add(New MySqlParameter("@name", entity.name))
        parameters.Add(New MySqlParameter("@price", entity.price))

        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements iGenericRepository(Of Producto).Remove
        parameters = New List(Of MySqlParameter)
        parameters.Add(New MySqlParameter("@product_Id", id))

        Return ExecuteNonQuery(delete)
    End Function
End Class
