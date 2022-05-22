Imports MySql.Data.MySqlClient
Module CRUDConnection
    Public Function connection() As MySqlConnection
        'Return New MySqlConnection("server=localhost;username=root;password=;database=barangay_household_system")
        Return New MySqlConnection("server=localhost;username=root;password=;database=brgydb")
    End Function
    Public connect As MySqlConnection = connection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub display_to_table(ByVal sql As String, ByVal dtgrid As Object)
        connect.Close()
        Try
            dt = New DataTable
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtgrid.datasource = dt
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub

    Public Sub create_data(ByVal sql As String)
        connect.Close()
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                connect.Close()
                If result = 0 Then
                    MessageBox.Show("Failed to add data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub update_data(ByVal sql As String)
        connect.Close()
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Failed to update data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                connect.Close()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub delete_data(ByVal sql As String)
        connect.Close()
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Failed to delete data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                connect.Close()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub log_in(ByVal sql As String)
        connect.Close()
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                connect.Close()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub search_data(ByVal sql As String, ByVal dtgrid As Object)
        connect.Close()
        Try
            dt = New DataTable
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtgrid.datasource = dt

            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            da.Dispose()
        End Try
    End Sub

    Public Sub fill_data(ByVal sql As String, ByVal dtgrid As Object)
        connect.Close()
        Try
            dt = New DataTable
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtgrid.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

