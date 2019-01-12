Public Class ClsEntKaryawan
    Public id As String
    Public nama As String
    Public pass As String
    Public hak As String
    Public Property idkaryawan() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property namakaryawan() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property passwords() As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property
    Public Property hakakses() As String
        Get
            Return hak
        End Get
        Set(value As String)
            hak = value
        End Set
    End Property
End Class
