Public Class ClsEntSupplier
    Private id As String
    Private nama As String
    Private alamat As String
    Private no As String

    Public Property idsupplier() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property namasupplier() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property alamatsupplier() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property notelepon() As String
        Get
            Return no
        End Get
        Set(value As String)
            no = value
        End Set
    End Property

End Class
