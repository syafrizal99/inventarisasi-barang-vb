﻿Imports System.Data.OleDb
Imports Test_Program.KoneksiDB

Public Class FormLogin

    Public NamaMhs As String

    Private Sub bMasuk_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) Handles bMasuk.Click

        'membukan koneksi ke database
        KoneksiDB.HubungkanDB()

        Dim CekAuth As OleDbDataReader
        Dim QuerySelect As New OleDbCommand
        Dim strNim As String = tbNim.Text
        Dim strKataSandi As String = tbKataSandi.Text

        Try
            'pastikan untuk Close() pada setiap ExecuteReader di jalankan
            'CekAuth.Close() => contoh
            QuerySelect.CommandType = CommandType.Text
            QuerySelect.CommandText = "SELECT * FROM tb_user WHERE nim ='" + strNim _
                + "' AND pass_mhs='" + strKataSandi + "'"
            QuerySelect.Connection = KoneksiDB.conn
            CekAuth = QuerySelect.ExecuteReader()

            If strNim = "" OrElse strKataSandi = "" Then
                MsgBox("nim atau kata sandi masing kosong ",
                       MsgBoxStyle.Exclamation, "Error Login")
            ElseIf CekAuth.HasRows = False Then
                MsgBox("nim dan password tidak cocok!! ",
                       MsgBoxStyle.Exclamation, "Error Login")
            Else
                CekAuth.Read()
                NamaMhs = CekAuth("nama_mhs").ToString()
                MsgBox("Login berhasil, Selamat datang " & CekAuth("nama_mhs").ToString() & _
                       "!", MsgBoxStyle.Information, "Successfull Login")
                FormBarang.Show()
                Me.Hide()
            End If
            CekAuth.Close()
        Catch ex As Exception
            MsgBox("Error" + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksiDB.HubungkanDB()
    End Sub

    'Hanya angka input
    Private Sub HanyaAngka(ByVal e)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbNim_KeyPress(ByVal sender As Object, ByVal e As  _
                               System.Windows.Forms.KeyPressEventArgs) Handles tbNim.KeyPress
        HanyaAngka(e)
    End Sub

    'Bersihakan form
    Public Sub bersihForm()
        tbKataSandi.Clear()
        tbNim.Clear()
        tbNim.Focus()
    End Sub
End Class