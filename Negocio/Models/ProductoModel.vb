Imports DataAccess
Imports System.ComponentModel.DataAnnotations

Public Class ProductoModel

    Private _product_Id As Integer
    Private _productNumber As Integer
    Private _name As String
    Private _price As Integer

    Private productRepository As IProductoRepository

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
    Public Property ProductNumber As Integer
        Get
            Return _productNumber
        End Get
        Set(value As Integer)
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
    Public Property Price As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
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



End Class
