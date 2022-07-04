Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.Home
Imports User_LaboratoryManagement.SQLConn
Public Class my_account
    Dim suc As New Success
    Dim er As New error_message
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
    End Sub

    Private Sub my_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        oldpass.Select()
    End Sub

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click

        If Not oldpass.Text.Equals(pass1) Then
            er.messageERROR("Incorrect Password!")
        ElseIf Not newpass.Text.Equals(repass.Text) Then
            er.messageERROR("Password not match!")
        Else
            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE accounts SET Password = @pass WHERE ID = @id "
                    .Parameters.AddWithValue("@id", idpass)
                    .Parameters.AddWithValue("@pass", newpass.Text)
                    .Connection = SQLString

                End With
                Try
                    ConnectSQL()
                    sqlcommand.ExecuteNonQuery()
                    suc.messageSuccess("Changed Successfully")
                    oldpass.Text = ""
                    newpass.Text = ""
                    repass.Text = ""
                    Me.Close()
                Catch ex As Exception
                    er.messageERROR(ex.Message)
                End Try
            End Using
        End If
    End Sub
End Class