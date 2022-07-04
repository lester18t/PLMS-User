Imports User_LaboratoryManagement.SQLConn
Imports User_LaboratoryManagement.Home
Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.User_Attendance
Imports System.ComponentModel

Public Class User_Attendance
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Public Sub User_Attendace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim re As New request_Item
        re.MetroTabControl1.SelectedTab = re.MetroTabPage1
        PrintData(re.view_Inventory, "SELECT ID, Name, Quantity FROM inventory")
        Dim home As New Home
        home.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(home)
        Dim theDate As DateTime = System.DateTime.Now
        home.dateNow.Text = theDate.ToString("hh:mm dddd, dd MMMM yyyy")
        'name_user.Text = String.Format("Welcome {0}, {1}!", SearchData("LastName", "accounts", "ID", activeAccount), SearchData("FirstName", "accounts", "ID", activeAccount))
        home.MetroTabControl1.SelectedTab = home.MetroTabPage1
        PrintData(home.attendance_table, "SELECT No, Name, Time_In,Time_Out FROM attendance")
        home.attendance_table.Sort(home.attendance_table.Columns(0), ListSortDirection.Descending)

    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles umbutton.Click
        Me.ContextTop.Show(Me.umbutton, Me.umbutton.PointToClient(Cursor.Position))
    End Sub



    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Dim dialog As DialogResult
        Dim exit_view As New view_item
        dialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            Dim home As New Home
            PrintData(home.attendance_table, "SELECT No, Name, Time_In,Time_Out FROM attendance")
            home.Dock = DockStyle.Fill
            MainPanel.Controls.Clear()
            MainPanel.Controls.Add(home)
            ToolStripMenuItem1.Visible = False
            LogoutToolStripMenuItem1.Visible = False
            name_user.Visible = False

            view_item.Close()
        Else
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim dialog As DialogResult
        Dim exit_view As New view_item
        dialog = MessageBox.Show("Are you sure you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem1.Click
        Admin_db.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        my_account.ShowDialog()
    End Sub

    Private Sub ForgotPassowrdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles forgot_ac.Click
        forgot_email_pass.ShowDialog()

    End Sub
End Class