Imports Microsoft.Win32

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search",
            "AllowCortana", Nothing) < 1 Then
            Label1.Text = "Cortana Disabled"
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        Else
            Label1.Text = "Cortana Enabled"
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Cortana Enabled"
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", 1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Cortana Disabled"
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", 0)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click

    End Sub

    Private Sub SourceCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SourceCodeToolStripMenuItem.Click
        Dim webAddress As String = "https://github.com/Takua95/Regedit-Cortana/blob/master/CortanaRegedit/Form1.vb"
        Process.Start(webAddress)
    End Sub

    Private Sub UserLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLicenseToolStripMenuItem.Click
        MsgBox("Don't Sue Me.")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("It Enables/Disables Cortana")
    End Sub
End Class
