Public Class Dashboard
    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ImageCheckBox1.CheckedChanged
        If Guna2ImageCheckBox1.Checked Then
            pnlSide.Width = 52
            Guna2HtmlLabel3.Visible = False

        Else
            pnlSide.Width = 195
            Guna2HtmlLabel3.Visible = True
        End If

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            Me.BackColor = Color.FromArgb(69, 69, 69)
            pnlSide.FillColor = Color.FromArgb(255, 96, 0)
            pnlSide.FillColor2 = Color.FromArgb(255, 96, 0)
            Guna2HtmlLabel3.ForeColor = Color.FromName("black")
        Else
            Me.BackColor = Color.FromKnownColor(KnownColor.Control)
            pnlSide.FillColor = Color.FromName("white")
            pnlSide.FillColor2 = Color.FromName("white")
            Guna2HtmlLabel3.ForeColor = Color.FromArgb(255, 96, 0)

        End If
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        End
    End Sub
End Class