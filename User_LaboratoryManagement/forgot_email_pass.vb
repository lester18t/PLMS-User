Imports User_LaboratoryManagement.SQLConn
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class forgot_email_pass
    Dim er As New error_message
    Public Shared email_code As String
    Public Shared code_red As String
    Dim das As String
    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        Dim ser_code As New Random
        code_red = ser_code.Next(999999)
        email_code = emailbox.Text
        Dim sqlcommand As New MySqlCommand()
        With sqlcommand
            .CommandText = "SELECT * FROM accounts WHERE Umindanao_Account = @ac"
            .Parameters.AddWithValue("@ac", emailbox.Text)
            .Connection = SQLString
        End With
        Try
            ConnectSQL()
            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                While dataReader.Read
                    das = dataReader.GetString(8)
                End While

                If emailbox.Text = String.Empty Then
                    er.messageERROR("Input E-mail Address first!")
                ElseIf Not emailbox.Text.Equals(das) Then
                    er.messageERROR("Address not found on database!")
                Else
                    Try
                        loadbar.Visible = True
                        Dim Stmp_server As New SmtpClient
                        Dim e_mail As New MailMessage
                        Dim mess As String
                        mess = "Physics Laboratory Reservation"
                        Stmp_server.UseDefaultCredentials = False
                        Stmp_server.Credentials = New Net.NetworkCredential("umindanao.ph@gmail.com", "baste123")
                        Stmp_server.Port = 587
                        Stmp_server.EnableSsl = True
                        Stmp_server.Host = "smtp.gmail.com"
                        e_mail = New MailMessage
                        e_mail.From = New MailAddress("umindanao.ph@gmail.com")
                        e_mail.To.Add(email_code)
                        e_mail.IsBodyHtml = True
                        e_mail.Subject = mess
                        e_mail.Body = ("Your Security Code Here:" & vbCrLf & code_red)
                        Stmp_server.Send(e_mail)
                        emailbox.Text = ""
                        sercurity_code.Show()
                        Hide()

                    Catch ex As Exception
                        er.messageERROR(ex.Message)
                        loadbar.Visible = False
                    End Try
                End If

            End Using
        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try

    End Sub

    Private Sub forgot_email_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        emailbox.Text = ""
        Me.Close()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        emailbox.Text = ""
        Me.Close()
    End Sub
End Class