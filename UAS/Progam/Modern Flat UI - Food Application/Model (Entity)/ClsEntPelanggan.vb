Public Class ClsEntPelanggan
    Private id As String
    Private nama As String
    Private alamat As String
    Private no As String
    Private jk As String

    Public Property idpelanggan() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property namapelanggan() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property alamatpelanggan() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property no_hp() As String
        Get
            Return no
        End Get
        Set(value As String)
            no = value
        End Set
    End Property
    Public Property jeniskelamin() As String
        Get
            Return jk
        End Get
        Set(value As String)
            jk = value
        End Set
    End Property
End Class
