Imports User_LaboratoryManagement.SQLConn
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports User_LaboratoryManagement.forgot_email_pass
Public Class newpass
    Dim er As New error_message
    Dim suc As New Success
    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If Not newpassword.Text.Equals(repass.Text) Then
            er.messageERROR("Password not match!")
        ElseIf newpassword.Text = String.Empty Then
            er.messageERROR("Invalid Password!")
        ElseIf repass.Text = String.Empty Then
            er.messageERROR("Invalid Password!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE accounts SET Password = @pass WHERE Umindanao_Account = @ac "
                    .Parameters.AddWithValue("@ac", email_code)
                    .Parameters.AddWithValue("@pass", newpassword.Text)
                    .Connection = SQLString
                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    suc.messageSuccess("Changed Successfully")
                    newpassword.Text = ""
                    repass.Text = ""
                    Me.Close()
                Catch ex As Exception
                    er.messageERROR(ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub newpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class