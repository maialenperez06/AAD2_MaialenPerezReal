Public Class Pelicula
    Private titulo As String
    Private anioEstreno As Integer
    Private duracionPelicula As Integer
    Private precio As Double
    Private sipnosis As String
    Private cantidadEntradas As Integer
    Private Imagen As Image

    Public Sub New(titulo As String, anioEstreno As Integer, duracionPelicula As Integer, precio As Double, sipnosis As String, cantidadEntradas As Integer, imagen As Image)
        Me.titulo = titulo
        Me.anioEstreno = anioEstreno
        Me.duracionPelicula = duracionPelicula
        Me.precio = precio
        Me.sipnosis = sipnosis
        Me.cantidadEntradas = cantidadEntradas
        Me.Imagen = imagen
    End Sub

    Public Property Ptitulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal value As String)
            titulo = value
        End Set
    End Property
    Public Property PanioEstreno() As Integer
        Get
            Return anioEstreno
        End Get
        Set(ByVal value As Integer)
            anioEstreno = value
        End Set
    End Property
    Public Property PduracionPelicula() As Integer
        Get
            Return duracionPelicula
        End Get
        Set(ByVal value As Integer)
            duracionPelicula = value
        End Set
    End Property
    Public Property Pprecio() As Double
        Get
            Return precio
        End Get
        Set(ByVal value As Double)
            precio = value
        End Set
    End Property
    Public Property Psipnosis() As String
        Get
            Return sipnosis
        End Get
        Set(ByVal value As String)
            sipnosis = value
        End Set
    End Property

    Public Property PcantidadEntradas() As Integer
        Get
            Return cantidadEntradas
        End Get
        Set(ByVal value As Integer)
            cantidadEntradas = value
        End Set
    End Property
    Public Property PImagen() As Image
        Get
            Return Imagen
        End Get
        Set(ByVal value As Image)
            Imagen = value
        End Set
    End Property
End Class
