Public Class UCLogsList
    Private Sub UCLogsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Logs As List(Of Dictionary(Of String, String)) = DbSearcher.GetAllLogs()

            PopulateDataGridView(Logs)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub PopulateDataGridView(ByVal logs As List(Of Dictionary(Of String, String)))
        Try



            dgvlogs.Rows.Clear()
            dgvlogs.ColumnCount = 8
            dgvlogs.Columns(0).Name = "#"
            dgvlogs.Columns(1).Name = "Action"
            dgvlogs.Columns(2).Name = "Book ID"
            dgvlogs.Columns(3).Name = "Reg Number"
            dgvlogs.Columns(4).Name = "Action Date"
            dgvlogs.Columns(5).Name = "Action By"
            dgvlogs.Columns(6).Name = "Old Data"
            dgvlogs.Columns(7).Name = "New Data"

            Dim logNumber As Integer = 1
            For Each log In logs

                Dim row As String() = {
                logNumber,
                log.Item("action"),
                log.Item("bookId"),
                log.Item("regNumber"),
                log.Item("actionDate"),
                log.Item("actionBy"),
                log.Item("oldData"),
                log.Item("newData")
                    }
                dgvlogs.Rows.Add(row)
                logNumber += 1

            Next
        Catch ex As Exception
            MessageBox.Show("Error: Could not load logs." & ex.Message)
        End Try
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

End Class
