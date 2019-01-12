Imports System.Data.OleDb
Imports RPL

Public Class ClsCtlPelanggan : Implements InfProses
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_pelanggan,6)) from pelanggan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "2" & Strings.Right("000000" & kodeakhir + 1, 6)
            Return baru

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from pelanggan where nama " _
                                       & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_pelanggan")
            Dim grid As New DataView(DTS.Tables("Cari_pelanggan"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from pelanggan " _
                               & " where id_pelanggan='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntPelanggan
        data = Ob
        CMD = New OleDbCommand("insert into pelanggan values('" & data.idpelanggan & "','" _
                               & data.namapelanggan & "','" & data.alamatpelanggan & "','" _
                               & data.no_hp & "','" & data.jeniskelamin & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from pelanggan", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_pelanggan")
            Dim grid As New DataView(DTS.Tables("Tabel_pelanggan"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntPelanggan
        data = Ob
        CMD = New OleDbCommand("update pelanggan set nama='" _
                               & data.namapelanggan & "',alamat='" & data.alamatpelanggan _
                               & "',no_hp ='" & data.no_hp _
                               & "',jeniskelamin ='" & data.jeniskelamin _
                               & "'where id_pelanggan='" & data.idpelanggan & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function cekPelangganDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("select count(id_pelanggan) from penjualan " _
                                       & "where id_pelanggan='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
