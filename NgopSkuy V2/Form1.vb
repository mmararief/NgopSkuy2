﻿Imports System.Windows
Imports Guna.UI2.WinForms
Imports MySqlConnector
Public Class Form1
    Dim connectionString As String = "server=103.153.3.20;user id=webkadupa_ammar;password=Juken12345678;database=webkadupa_cafe"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Kata sandi harus diisi.")
            Return
        End If

        Dim sql As String = "SELECT * FROM users WHERE username =@username AND password=@password"
        Dim command As New MySqlCommand(sql, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Me.Hide()
                Dim home As New Home()
                home.Show()
            Else
                MessageBox.Show("Username atau kata sandi salah.")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin_Click(Me, EventArgs.Empty)
            e.Handled = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then

            txtPassword.PasswordChar = "●"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class
