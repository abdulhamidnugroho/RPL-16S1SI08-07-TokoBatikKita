Imports System.Data.OleDb

Public Class FormLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("Data Login belum Lengkap")
            Exit Sub
        Else


            CMD = New OleDbCommand("select * from karyawan where nama='" & txt_username.Text & "' and passwords='" & txt_password.Text & "'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader
            DTR.Read()
            If DTR.HasRows Then
                Me.Close()
                Call Hak()

                If FormUtama.lbl_hakAkses.Text <> "OWNER" Then
                    Call Terbuka2()

                Else
                    Call Terbuka()

                End If

            Else
                MsgBox("Username atau Password salah")
            End If
        End If
    End Sub
    Sub Hak()
        FormUtama.lbl_id.Text = DTR.Item("ID_KARYAWAN")
        FormUtama.lbl_nama.Text = DTR.Item("NAMA")
        FormUtama.lbl_hakAkses.Text = DTR.Item("HAK_AKSES")


        'FormPenjualan.cmb_iduser.Text = DTR.Item("ID_KARYAWAN")
        'FormPenjualan.txt_username.Text = DTR.Item("NAMA")




    End Sub
    Sub Terbuka()
        FormUtama.btnBarang.Visible = True
        FormUtama.btnPelanggan.Visible = True
        FormUtama.btnSupplier.Visible = True
        FormUtama.btnKaryawan.Visible = True
        FormUtama.btnPenjualan.Visible = True
        FormUtama.BtnPembelian.Visible = True
        FormUtama.BtnOperasional.Visible = True
        FormUtama.BtnLaporan.Visible = True
        FormUtama.BtnLogout.Visible = True

        FormUtama.BtnLogin.Visible = False
        FormUtama.BtnExit.Visible = False

    End Sub
    Sub Terbuka2()
        FormUtama.btnBarang.Visible = True
        FormUtama.btnPelanggan.Visible = True
        FormUtama.btnSupplier.Visible = True
        FormUtama.btnKaryawan.Visible = False
        FormUtama.btnPenjualan.Visible = True
        FormUtama.BtnPembelian.Visible = True
        FormUtama.BtnOperasional.Visible = True
        FormUtama.BtnLaporan.Visible = False
        FormUtama.BtnLogout.Visible = True

        FormUtama.BtnLogin.Visible = False
        FormUtama.BtnExit.Visible = False
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_username.Focus()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMD = New OleDbCommand("select * from Karyawan wHere HAK_AKSES='OWNER'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
