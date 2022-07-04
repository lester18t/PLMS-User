Imports User_LaboratoryManagement.User_Attendance
Imports User_LaboratoryManagement.SQLConn
Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.Home

Public Class request_Item
    Dim dbdata As New DataTable
    Dim userid As String
    Dim upDate_Id As String
    Dim vscroll1 As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Public Shared borrower As String
    Dim err As New error_message
    Dim suc As New Success

    'Public Shared ems As String
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property


    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles request_items.Click
        borrower = User_req.Text
        view_item.Show()
        view_item.WindowState = FormWindowState.Normal
    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles additem.Click
        If idbox.Text = String.Empty Then
            err.messageERROR("Select item first!")
        ElseIf Name_Item.Text = String.Empty Then
            err.messageERROR("Select item first!")
        ElseIf User_req.Text = String.Empty Then
            err.messageERROR("Invalid!")
        ElseIf quantitybox.Text = String.Empty Then
            err.messageERROR("Quantity must be more than 0!")
        ElseIf quantitybox.Text = 0 Then
            err.messageERROR("Quantity must be more than 0!")
        Else
            view_item.item_data.Rows.Add(New String() {False, idbox.Text, Name_Item.Text, User_req.Text, quantitybox.Text})
            suc.messageSuccess("Item Added!")
        End If
    End Sub

    Private Sub view_Inventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim selectedRow As DataGridViewRow
        Try
            selectedRow = view_Inventory.Rows(e.RowIndex)
            idbox.Text = selectedRow.Cells(0).Value.ToString
            Name_Item.Text = selectedRow.Cells(1).Value.ToString
        Catch ex As Exception
            err.messageERROR(ex.Message)
        End Try
    End Sub

    Private Sub search_item_TextChanged_1(sender As Object, e As EventArgs) Handles search_item.TextChanged
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable


            With sqlcommand
                .CommandText = "SELECT ID, Name, Quantity FROM inventory"
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                view_Inventory.DataSource = dataTable
            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try

            Dim view As New DataView(dataTable)

            If Id_radio.Checked = True Then
                view.RowFilter = String.Format("Convert(ID,'System.String') Like '%{0}%'", search_item.Text)
                view_Inventory.DataSource = view
            ElseIf name_radio.Checked = True Then
                view.RowFilter = String.Format("Name like '*" & search_item.Text & "*'", Me.search_item.Text)
                view_Inventory.DataSource = view
            End If

        End Using



    End Sub

    Private Sub GunaGradientButton4_MouseCaptureChanged_1(sender As Object, e As EventArgs) Handles GunaGradientButton4.MouseCaptureChanged
        Dim int As Integer = 1
        If quantitybox.Text = String.Empty Then

        ElseIf quantitybox.Text < 2 Then

        Else
            Integer.TryParse(quantitybox.Text, int)
            quantitybox.Text = int - 1
        End If
    End Sub

    Private Sub GunaGradientButton5_MouseCaptureChanged(sender As Object, e As EventArgs) Handles GunaGradientButton5.MouseCaptureChanged
        Dim int As Integer
        Integer.TryParse(quantitybox.Text, int)
        quantitybox.Text = (int + 1)
    End Sub


    Public Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged

        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable
            activeAccount = User_req.Text
            With sqlcommand
                ConnectSQL()
                .CommandText = "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item WHERE UserID= @id"
                .Parameters.AddWithValue("@id", User_req.Text)
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                borrowed.DataSource = dataTable
            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try
        End Using

    End Sub


    Public Sub MetroTabControl1_Click(sender As Object, e As EventArgs) Handles MetroTabControl1.Click

        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable
            activeAccount = User_req.Text
            With sqlcommand

                .CommandText = "SELECT UserID, Item_ID, Item_Name, Quantity, DateTime, Status FROM borrowed_item WHERE UserID= @id"
                .Parameters.AddWithValue("@id", User_req.Text)
                .Connection = SQLString
            End With
            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)

                borrowed.DataSource = dataTable

            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub MetroTabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles MetroTabControl1.MouseClick
        Dim Req As New request_Item
        PrintData(Req.view_Inventory, "SELECT ID, Name, Quantity FROM inventory")
    End Sub

    Private Sub view_Inventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles view_Inventory.CellClick
        Dim selectedRow As DataGridViewRow
        If e.RowIndex > -1 Then
            Try
                selectedRow = view_Inventory.Rows(e.RowIndex)
                idbox.Text = selectedRow.Cells(0).Value.ToString
                Name_Item.Text = selectedRow.Cells(1).Value.ToString
            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try
        End If
    End Sub

    Private Sub view_Inventory_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles view_Inventory.CellContentClick
        Dim selectedRow As DataGridViewRow
        If e.RowIndex > -1 Then
            Try
                selectedRow = view_Inventory.Rows(e.RowIndex)
                idbox.Text = selectedRow.Cells(0).Value.ToString
                Name_Item.Text = selectedRow.Cells(1).Value.ToString
            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try
        End If
    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles label222.Click
        PrintData(view_Inventory, "SELECT ID, Name, Quantity FROM inventory")
    End Sub


    Private Sub request_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User_Attendance.forgot_ac.Visible = False
    End Sub

    Private Sub quantitybox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantitybox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub search_item_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_item.KeyPress
        If Id_radio.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub quantitybox_TextChanged(sender As Object, e As EventArgs) Handles quantitybox.TextChanged
        If quantitybox.Text.Count > 0 And idbox.Text.Count > 0 Then
            Dim present_qty As Integer = CInt(SearchData("Quantity", "inventory", "ID", idbox.Text))
            If quantitybox.Text.Count = 0 Then
                quantitybox.Text = 0
                quantitybox.Select(quantitybox.Text.Length, 0)
            ElseIf quantitybox.Text > present_qty Then
                quantitybox.Text = present_qty
                quantitybox.Select(quantitybox.Text.Length, 0)
            End If
        End If
    End Sub

    Private Sub quantitybox_Leave(sender As Object, e As EventArgs) Handles quantitybox.Leave
        quantitybox.Text = quantitybox.Text.TrimStart("0"c)
        If quantitybox.Text = "" Then
            quantitybox.Text = 0
        End If
    End Sub

    Private Sub idbox_TextChanged(sender As Object, e As EventArgs) Handles idbox.TextChanged
        quantitybox.Text = 0
    End Sub

    Private Sub Id_radio_CheckedChanged(sender As Object, e As EventArgs) Handles Id_radio.CheckedChanged
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable


            With sqlcommand
                .CommandText = "SELECT ID, Name, Quantity FROM inventory"
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                view_Inventory.DataSource = dataTable
            Catch ex As Exception
                err.messageERROR(ex.Message)
            End Try

            Dim view As New DataView(dataTable)

            If Id_radio.Checked = True Then
                view.RowFilter = String.Format("Convert(ID,'System.String') Like '%{0}%'", search_item.Text)
                view_Inventory.DataSource = view
            ElseIf name_radio.Checked = True Then
                view.RowFilter = String.Format("Name like '*" & search_item.Text & "*'", Me.search_item.Text)
                view_Inventory.DataSource = view
            End If
        End Using
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Label1_Click(sender, e)
    End Sub
End Class
