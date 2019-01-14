Public Class ClsEntBarang
    Private id As String
    Private nama As String
    Private hargabeli As Integer
    Private hargajual As Integer
    Private stok As Integer

    Public Property idbarang() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property namabarang() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property hargabeliBarang() As Integer
        Get
            Return hargabeli
        End Get
        Set(value As Integer)
            hargabeli = value
        End Set
    End Property
    Public Property hargajualBarang() As Integer
        Get
            Return hargajual
        End Get
        Set(value As Integer)
            hargajual = value
        End Set
    End Property
    Public Property stokBarang() As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property
End Class
