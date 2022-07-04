Imports User_LaboratoryManagement.SQLConn
Imports MySql.Data.MySqlClient
Imports User_LaboratoryManagement.request_Item

Public Class view_item

    Dim er As New error_message
    Dim suc As New Success
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub view_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub request_items_Click(sender As Object, e As EventArgs) Handles request_items.Click
        Try
            Dim requested As Boolean = False
            For Each row As DataGridViewRow In item_data.Rows
                Dim newQty As Integer = SearchData("Quantity", "inventory", "ID", row.Cells(1).Value) - row.Cells(4).Value
                Dim insCommand As New MySqlCommand
                Dim upCommand As New MySqlCommand

                ConnectSQL()
                If Not SearchData("ID", "accounts", "ID", borrower) = "" And newQty >= 0 Then
                    With insCommand
                        .CommandText = "INSERT INTO borrowed_item (UserID, Item_ID, Item_Name, Quantity, DateTime, Status) values (@userid, @item_ID, @item_name, @qty, @date, @stat)"
                        .Parameters.AddWithValue("@userid", borrower)
                        .Parameters.AddWithValue("@item_ID", row.Cells(1).Value)
                        .Parameters.AddWithValue("@item_name", row.Cells(2).Value)
                        .Parameters.AddWithValue("@qty", row.Cells(4).Value)
                        .Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"))
                        .Parameters.AddWithValue("@stat", "Pending")
                        .Connection = SQLString
                    End With

                    With upCommand
                        ConnectSQL()
                        .CommandText = "UPDATE inventory SET Quantity = @qty WHERE ID = @item_ID"
                        .Parameters.AddWithValue("@qty", newQty)
                        .Parameters.AddWithValue("@item_ID", row.Cells(1).Value)
                        .Connection = SQLString
                    End With

                    Try
                        ConnectSQL()
                        insCommand.ExecuteNonQuery()
                        upCommand.ExecuteNonQuery()
                        requested = True
                    Catch ex As Exception
                        er.messageERROR(ex.Message)
                    End Try
                Else
                    If newQty <= 0 Then
                        er.messageERROR("Item Not Available!")
                        Exit Sub
                    Else
                        er.messageERROR("Invalid!")
                        Exit Sub
                    End If
                End If
            Next

            If requested = True Then
                check_item.Checked = False
                suc.messageSuccess("Reserved!")
                Me.Close()
            Else
                check_item.Checked = False
                Me.Close()
            End If
        Catch ex As Exception
            er.messageERROR(ex.Message)
        End Try



    End Sub



    Private Sub GunaGradientCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientCircleButton1.Click
        Me.Hide()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        item_data.ClearSelection()
        For Each row As DataGridViewRow In item_data.Rows
            If row.Cells(0).Value.ToString = True Then
                row.Selected = True
            End If
        Next

        For Each row As DataGridViewRow In item_data.SelectedRows
            item_data.Rows.Remove(row)
        Next

        check_item.Checked = False
    End Sub

    Private Sub check_item_CheckedChanged(sender As Object, e As EventArgs) Handles check_item.CheckedChanged
        If check_item.Checked Then
            For Each row As DataGridViewRow In item_data.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In item_data.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub


End Class