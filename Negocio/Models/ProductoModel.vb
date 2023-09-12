Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class ProductoModel

    Private _product_Id As Integer
    Private _productNumber As String
    Private _name As String
    Private _price As String

    Private _State As EntityState

    Private productRepository As ProductoRepository

    Public Sub New()
        productRepository = New ProductoRepository
    End Sub


#Region "Getters y Setters"
    Public Property Product_Id As Integer
        Get
            Return _product_Id
        End Get
        Set(value As Integer)
            _product_Id = value
        End Set
    End Property

    <Required(ErrorMessage:="El campo number es obligatorio")>
    <RegularExpression("([0-9])+", ErrorMessage:="Solo se permite numeros")>
    <StringLength(3, MinimumLength:=3, ErrorMessage:="El campo debe ser de 3 digitos")>
    Public Property ProductNumber As String
        Get
            Return _productNumber
        End Get
        Set(value As String)
            _productNumber = value
        End Set
    End Property

    <Required(ErrorMessage:="El campo number es obligatorio")>
    <RegularExpression("^[a-zA-Z]+$", ErrorMessage:="Campo solo admite letras")>
    <StringLength(30, MinimumLength:=3)>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    <Required(ErrorMessage:="El campo number es obligatorio")>
    <RegularExpression("([0-9])+", ErrorMessage:="Solo se permite numeros")>
    Public Property Price As String
        Get
            Return _price
        End Get
        Set(value As String)
            _price = value
        End Set
    End Property

    Public Property State As EntityState
        Get
            Return _State
        End Get
        Set(value As EntityState)
            _State = value
        End Set
    End Property
#End Region

    'Methods

    Public Function GetAllProducts() As List(Of ProductoModel)

        Dim listProductDataModel = productRepository.GetAll()
        Dim listProductViewModel = New List(Of ProductoModel)

        For Each item As Producto In listProductDataModel

            listProductViewModel.Add(New ProductoModel With {
            .Product_Id = item.product_Id,
            .ProductNumber = item.productNumber,
            .Name = item.name,
            .Price = item.price
            })

        Next

        Return listProductViewModel


    End Function

    Public Function SaveChanges() As String

        Dim messages As String = Nothing

        Try

            Dim productDto As New Producto

            productDto.product_Id = Product_Id
            productDto.productNumber = ProductNumber
            productDto.name = Name
            productDto.price = Price

            Select Case State

                Case EntityState.Added
                    productRepository.Add(productDto)
                    messages = "Producto Agregado"

                Case EntityState.Modified
                    productRepository.Edit(productDto)
                    messages = "Producto Modificado"

                Case EntityState.Deleted
                    productRepository.Remove(Product_Id)
                    messages = "Producto Eliminado"

            End Select

            Return messages

        Catch ex As Exception

            messages = ex.ToString()

            Return messages

        End Try

    End Function

End Class
