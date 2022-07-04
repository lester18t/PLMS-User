Imports MySql.Data.MySqlClient
Public Class SQLConn
    Public Shared SQLString As New MySqlConnection("Server = " & My.Settings.Server & "; Database = project_lab; Uid = " & My.Settings.User & "; Password = " & My.Settings.Pass & ";")
    Public Shared rr As New error_message

    Shared Sub ConnectSQL()
        Try
            If SQLString.State = ConnectionState.Closed Then
                SQLString.Open()
            End If

        Catch ex As Exception
            rr.messageERROR(ex.Message)
        End Try
    End Sub
    Shared Sub PrintData(tbl As DataGridView, cmd As String)
        Using sqlcommand As New MySqlCommand()
            Dim dataAdapter As New MySqlDataAdapter
            Dim dataTable As New DataTable

            With sqlcommand
                .CommandText = cmd
                .Connection = SQLString
            End With

            Try
                dataAdapter.SelectCommand = sqlcommand
                dataTable.Clear()
                dataAdapter.Fill(dataTable)
                tbl.DataSource = dataTable
                tbl.Refresh()
            Catch ex As Exception
                rr.messageERROR(ex.Message)
            End Try
        End Using
    End Sub
    Shared Function SearchData(itemToSearch As String, tbl As String, whereToSearch As String, value As String) As String
        Using sqlComm As New MySqlCommand
            Dim dataAdapt As New MySqlDataAdapter
            Dim dataset As New DataSet
            Dim result As String = ""
            With sqlComm
                .CommandText = "SELECT " & itemToSearch & " FROM " & tbl & " WHERE " & whereToSearch & " = " & value
                .Connection = SQLString
            End With

            Try
                dataAdapt.SelectCommand = sqlComm
                dataAdapt.Fill(dataset)
                result = dataset.Tables(0).Rows(0).Item(0).ToString

            Catch ex As Exception
                rr.messageERROR(ex.Message)
            End Try

            Return result
        End Using
    End Function
    Shared Sub DeleteData(tableName As String, columnName As String, id As String)
        Using sqlcommand As New MySqlCommand()
            With sqlcommand
                .CommandText = "DELETE FROM " & tableName & " WHERE " & columnName & " = @id"
                .Parameters.AddWithValue("@id", id)
                .Connection = SQLString
            End With
            Try
                sqlcommand.ExecuteNonQuery()
            Catch ex As Exception
                rr.messageERROR(ex.Message)
            End Try
        End Using
    End Sub
End Class
