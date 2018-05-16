Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Dim readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\Windwos Search", "AllowCortana", Nothing)
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

    Private Function Registry_Read(Key_Path, Key_Name) As VariantType

        On Error Resume Next

        Dim Registry As Object

        Registry = CreateObject("WScript.Shell")

        Registry_Read = Registry.RegRead(Key_Path & Key_Name)

    End Function

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

    ''Private Sub Test()
    ''  MsgBox(Registry_Read("HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\", "W2kVersion"))
    ''End Sub
End Class
