Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.SQLConn
Public Class Server_db
    Dim er As New error_message
    Dim appPath As String = Path.GetDirectoryName(Environment.SpecialFolder.ApplicationData)
    Dim savepath As String = appPath & "\Attendance\"
    Dim usCulture As CultureInfo = CultureInfo.GetCultureInfo("en-US")
    Private Sub saveData_Click(sender As Object, e As EventArgs) Handles saveData.Click
        If server.Text = String.Empty Then
            er.messageERROR("Invalid Server Address!")
        ElseIf user.Text = String.Empty Then
            er.messageERROR("Invalid Database User!")
        Else
            My.Settings.Server = server.Text
            My.Settings.User = user.Text
            My.Settings.Pass = pass.Text
            Application.Restart()
        End If

    End Sub

    Private Sub Server_db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        compose_journal.BackColor = Color.White
        compose_journal.ForeColor = Color.Black

        pcName.Text = My.Computer.Name
        hostname.Text = My.Settings.Server
        ipAddress.Text = System.Net.Dns.GetHostByName(hostname.Text).AddressList(0).ToString

        ListBox1.Items.Clear()
        If Not Directory.Exists(savepath) Then
            Directory.CreateDirectory(savepath)
        End If

        Dim addToList = From f In Directory.EnumerateFiles(savepath)
                        Let fileCreationTime = File.GetCreationTime(f)
                        Order By fileCreationTime
                        Select New ListViewItem(Path.GetFileName(f), f)

        Dim files As List(Of ListViewItem) = addToList.Reverse.ToList()

        For x As Integer = 0 To files.Count - 1
            Dim name As String = files.Item(x).ToString.Replace("ListViewItem: {", "").Replace(".log}", "")
            ListBox1.Items.Add(name)
        Next
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        server.Text = ""
        user.Text = ""
        pass.Text = ""
        Me.Close()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.SelectedIndex <> -1 Then
            Dim filename As String = ListBox1.SelectedItem.ToString & ".log"
            Dim filepath As String = savepath + filename
            Dim fs As New StreamReader(filepath)
            compose_journal.Text = My.Computer.FileSystem.ReadAllText(filepath)
            fs.Close()
        End If
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        If e.Index < 0 Then Return

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e = New DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State Xor DrawItemState.Selected, e.ForeColor, Color.FromArgb(224, 188, 231))
        End If

        e.DrawBackground()
        e.Graphics.DrawString(ListBox1.Items(e.Index).ToString, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles findBox.TextChanged
        compose_journal.SelectAll()
        compose_journal.SelectionBackColor = Color.White
        Dim len = findBox.Text.Length
        Dim pos = compose_journal.Find(findBox.Text, 0, RichTextBoxFinds.NoHighlight)
        While (pos >= 0)
            compose_journal.Select(pos, len)
            compose_journal.SelectionBackColor = Color.FromArgb(228, 158, 255)
            If pos + len >= compose_journal.Text.Length Then
                Exit While
            End If
            pos = compose_journal.Find(findBox.Text, pos + len, RichTextBoxFinds.NoHighlight)
        End While
        compose_journal.ScrollToCaret()
    End Sub
End Class