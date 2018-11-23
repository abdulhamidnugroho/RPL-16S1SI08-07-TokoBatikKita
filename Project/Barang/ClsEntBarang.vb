Public Class ClsEntBarang
    Private idbarang As String
    Private namabarang As String
    Private hargabeli As Integer
    Private hargajual As Integer
    Private jumlahstok As Integer

    Public Property idbarang() As String
        Get
            Return idbarang
        End Get
        Set(value As String)
            idbarang = value
        End Set
    End Property
    Public Property namabarang() As String
        Get
            Return namabarang
        End Get
        Set(value As String)
            namabarang = value
        End Set
    End Property
    Public Property hargabeli() As Integer
        Get
            Return hargabeli
        End Get
        Set(value As Integer)
            hargabeli = value
        End Set
    End Property
    Public Property hargajual() As Integer
        Get
            Return hargajual
        End Get
        Set(value As Integer)
            hargajual = value
        End Set
    End Property
    Public Property jumlahstok() As Integer
        Get
            Return jumlahstok
        End Get
        Set(value As Integer)
            jumlahstok = value
        End Set
    End Property
End Class
