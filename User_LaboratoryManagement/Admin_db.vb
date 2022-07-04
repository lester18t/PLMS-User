Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.SQLConn
Public Class Admin_db
    Dim er As New error_message

    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        Dim sqlcommand As New MySqlCommand()
        With sqlcommand
            .CommandText = "SELECT * FROM accounts WHERE ID = @id and Password = @pass"
            .Parameters.AddWithValue("@id", idbox.Text)
            .Parameters.AddWithValue("@pass", pwbox.Text)
            .Connection = SQLString
        End With
        Try
            ConnectSQL()
            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                Dim da As String = ""
                Dim ds As String = ""
                While dataReader.Read
                    ds = dataReader.GetString(0)
                    da = dataReader.GetString(5)
                End While

                If Not idbox.Text().Equals(ds) Then
                    er.messageERROR("Invalid Credentials!")
                ElseIf (da.Equals("Admin")) Then
                    Server_db.ShowDialog()
                    idbox.Text = ""
                    pwbox.Text = ""
                    Me.Close()

                Else
                    er.messageERROR("Invalid Credentials!")
                End If

            End Using
        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        idbox.Text = ""
        pwbox.Text = ""
        Me.Close()
    End Sub



    Private Sub Admin_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub idbox_KeyDown(sender As Object, e As KeyEventArgs) Handles idbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class