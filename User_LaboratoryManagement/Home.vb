
Imports User_LaboratoryManagement.SQLConn
Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.User_Attendance
Imports User_LaboratoryManagement.view_item
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.ComponentModel

Public Class Home
    Dim suc As New Success
    Dim suc1 As New Success
    Dim err1 As New error_message
    Dim x As Integer = 255
    Dim shad As Integer = 40
    Public Shared activeAccount As String
    Public Shared active_mail As String
    Dim appPath As String = Path.GetDirectoryName(Environment.SpecialFolder.ApplicationData)
    Dim savePath As String = appPath & "\Attendance\"
    Dim usCulture As CultureInfo = CultureInfo.GetCultureInfo("en-US")
    Public Shared pass1 As String
    Public Shared idpass As String
    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Dim request As New request_Item

        activeAccount = idbox.Text
        Dim sqlcommand As New MySqlCommand()
        With sqlcommand
            .CommandText = "SELECT * FROM accounts WHERE ID = @id and Password = @pass"
            .Parameters.AddWithValue("@id", activeAccount)
            .Parameters.AddWithValue("@pass", pwbox.Text)
            .Connection = SQLString
        End With
        Try

            ConnectSQL()
            Using dataReader As MySqlDataReader = sqlcommand.ExecuteReader
                Dim da As String = ""
                Dim ds As String = ""
                Dim dy As String = ""
                While dataReader.Read
                    dy = dataReader.GetString(0)
                    da = dataReader.GetString(5)
                    ds = dataReader.GetString(8)
                End While

                If Not idbox.Text().Equals(dy) Then
                    err1.messageERROR("ID not found on database!")
                ElseIf idbox.Text = String.Empty Then
                    err1.messageERROR("Invalid Credential!")
                ElseIf pwbox.Text = String.Empty Then
                    err1.messageERROR("Incorrect Password!")
                Else
                    dataReader.Close()
                    idpass = activeAccount
                    pass1 = SearchData("Password", "accounts", "ID", idpass)
                    request.Dock = DockStyle.Fill
                    User_Attendance.MainPanel.Controls.Clear()
                    User_Attendance.MainPanel.Controls.Add(request)
                    PrintData(request.view_Inventory, "SELECT ID, Name, Quantity FROM inventory")
                    Dim theDate As DateTime = System.DateTime.Now
                    request.User_req.Text = SearchData("ID", "accounts", "ID", activeAccount)
                    User_Attendance.name_user.Text = String.Format("Welcome {0}, {1}!", SearchData("LastName", "accounts", "ID", activeAccount), SearchData("FirstName", "accounts", "ID", activeAccount))
                    request.MetroTabControl1.SelectedTab = request.MetroTabPage1
                    active_mail = ds
                    User_Attendance.name_user.Visible = True
                    idbox.Text = ""
                    pwbox.Text = ""
                    User_Attendance.ToolStripMenuItem1.Visible = True
                    User_Attendance.LogoutToolStripMenuItem1.Visible = True

                    Using sqlcommands As New MySqlCommand()
                        Dim dataAdapter As New MySqlDataAdapter
                        Dim dataTable As New DataTable

                        With sqlcommands
                            .CommandText = "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item WHERE UserID= @id"
                            .Parameters.AddWithValue("@id", activeAccount)
                            .Connection = SQLString
                        End With

                        Try
                            dataAdapter.SelectCommand = sqlcommands
                            dataTable.Clear()
                            dataAdapter.Fill(dataTable)
                            request.borrowed.DataSource = dataTable
                        Catch ex As Exception
                            err1.messageERROR(ex.Message)
                        End Try
                    End Using
                End If
            End Using
        Catch ex As Exception
            err1.messageERROR(ex.Message)
        End Try

    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view_item.WindowState = FormWindowState.Minimized
        view_item.Show()
        view_item.Hide()
        dateNow.Text = Date.Now.ToString("dddd, dd-MMMM yyyy hh:mm:ss")
        PrintData(attendance_table, "SELECT No, Name, Time_In,Time_Out FROM attendance")
        User_Attendance.forgot_ac.Visible = True
        PrintData(lab_sched, "SELECT Code,startTime,endTime,Mon,Tue,Wed,Thu,Fri,Sat,State,DateToUse FROM schedules")
        idbox.Select()
        attendance_table.Sort(attendance_table.Columns(2), ListSortDirection.Descending)
    End Sub
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Dim filename As String = String.Format("{0}.log", DateTime.Now.ToString("ddd - MMM dd yyyy", usCulture))

        If idbox.Text = String.Empty Or pwbox.Text = String.Empty Then
            err1.messageERROR("Invalid Credential!")
        Else
            Dim check_acc As String = SearchData("ID", "accounts", "ID", idbox.Text)
            Dim check_pass As String = SearchData("Password", "accounts", "ID", idbox.Text)

            If Not idbox.Text.Equals(check_acc) Then
                err1.messageERROR("ID not found on database!")
            ElseIf Not pwbox.Text.Equals(check_pass) Then
                err1.messageERROR("Incorrect Password!")
            Else


                Dim acct As String = SearchData("FirstName", "accounts", "ID", idbox.Text) + " " + SearchData("LastName", "accounts", "ID", idbox.Text)
                Dim acctNo = Function() As String
                                 Dim dataAdapter As New MySqlDataAdapter
                                 Dim dataTable As New DataTable
                                 Dim sqlcomm As New MySqlCommand
                                 Dim id As String = ""
                                 ConnectSQL()
                                 sqlcomm.CommandText = "SELECT No, Time_Out FROM attendance WHERE ID = " & idbox.Text
                                 sqlcomm.Connection = SQLString
                                 dataAdapter.SelectCommand = sqlcomm
                                 dataTable.Clear()
                                 dataAdapter.Fill(dataTable)
                                 For Each row As DataRow In dataTable.Rows
                                     If IsDBNull(row("Time_Out")) Then
                                         id = row("No")
                                         Exit For
                                     End If
                                 Next
                                 Return id
                             End Function


                If Not acct = "" Then

                    If Not Directory.Exists(savePath) Then
                        Directory.CreateDirectory(savePath)
                    End If
                    'Reset attendance DB
                    If Not File.Exists(savePath + filename) Then
                        Using sqlcommand As New MySqlCommand
                            ConnectSQL()
                            sqlcommand.CommandText = "TRUNCATE attendance"
                            sqlcommand.Connection = SQLString
                            sqlcommand.ExecuteNonQuery()
                        End Using
                    End If

                    If acctNo() = "" Then

                        Using sqlcommand As New MySqlCommand
                            With sqlcommand
                                ConnectSQL()
                                .CommandText = "INSERT INTO attendance (ID, Name, Time_In) values (@id, @name, @timeIn)"
                                .Parameters.AddWithValue("@id", idbox.Text)
                                .Parameters.AddWithValue("@name", acct)
                                .Parameters.AddWithValue("@timeIn", DateTime.Now.ToString("HH:mm:ss"))
                                .Connection = SQLString
                                .ExecuteNonQuery()


                                notifPanel.Visible = True
                                GunaLabel1.Text = "LOGIN SUCCESS!"
                                x = 255
                                shad = 40
                                fade_out_timer.Start()
                            End With
                        End Using
                        'Saving to log file
                        Using sw As StreamWriter = File.AppendText(savePath + filename)
                            Dim str As String = String.Format("[{0}] Logged In    - {1} - {2}",
                                                              DateTime.Now.ToString("hh:mm:ss tt"),
                                                              idbox.Text,
                                                              acct)
                            sw.WriteLine(str.ToString)
                        End Using
                    Else
                        Using sqlcommand As New MySqlCommand
                            With sqlcommand
                                ConnectSQL()
                                .CommandText = "UPDATE attendance SET Time_Out = @tOut WHERE No = @no"
                                .Parameters.AddWithValue("@tOut", DateTime.Now.ToString("HH:mm:ss"))
                                .Parameters.AddWithValue("@no", acctNo())
                                .Connection = SQLString
                                .ExecuteNonQuery()

                                notifPanel.Visible = True
                                GunaLabel1.Text = "LOGOUT SUCCESS!"
                                x = 255
                                shad = 40
                                fade_out_timer.Start()
                            End With
                        End Using
                        'Saving to log file
                        Using sw As StreamWriter = File.AppendText(savePath + filename)
                            Dim str As String = String.Format("[{0}] Logged Out - {1} - {2}",
                                                              DateTime.Now.ToString("hh:mm:ss tt"),
                                                              idbox.Text,
                                                              acct)
                            sw.WriteLine(str.ToString)
                        End Using


                    End If
                Else
                    err1.messageERROR("Account not Found on Database!")
                End If
                idbox.Text = ""
                pwbox.Text = ""

                date_time_MouseClick(sender, Nothing)
                idbox.Select()
            End If
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeNow.Text = Date.Now.ToString("h:mm:ss tt", usCulture)
        dateNow.Text = Date.Now.ToString("dddd, dd MMMM yyyy", usCulture)
    End Sub

    Private Sub date_time_MouseClick(sender As Object, e As MouseEventArgs) Handles dateNow.MouseClick
        PrintData(attendance_table, "SELECT No, Name, Time_In,Time_Out FROM attendance")
        attendance_table.Sort(attendance_table.Columns(0), ListSortDirection.Descending)
    End Sub

    Private Sub search_item_TextChanged(sender As Object, e As EventArgs) Handles search_item.TextChanged
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable


            With sqlcommand
                .CommandText = "SELECT Code,startTime,endTime,Mon,Tue,Wed,Thu,Fri,Sat,State,DateToUse FROM schedules"
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                lab_sched.DataSource = dataTable
            Catch ex As Exception
                err1.messageERROR(ex.Message)
            End Try

            Dim view As New DataView(dataTable)
            view.RowFilter = String.Format("Convert(Code,'System.String') Like '%{0}%'", search_item.Text)
            lab_sched.DataSource = view
        End Using
    End Sub

    Private Sub search_item_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_item.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub Fade_OUT(sender As Object, e As EventArgs) Handles fade_out_timer.Tick
        If x >= 0 Then
            notifPanel.BaseColor = Color.FromArgb(x, notifPanel.BaseColor)
            x = x - 1
        Else
            fade_out_timer.Stop()
        End If

        If shad >= 0 And (x Mod 5 = 0 Or x <= 10) Then
            notifPanel.ShadowDepth = shad
            shad = shad - 1
        End If
    End Sub

    Private Sub idbox_KeyDown(sender As Object, e As KeyEventArgs) Handles idbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pwbox_KeyDown(sender As Object, e As KeyEventArgs) Handles pwbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GunaGradientButton1_Click(sender, e)
            e.Handled = True
        End If
    End Sub
End Class
