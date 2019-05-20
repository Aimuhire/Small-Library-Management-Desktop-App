Public Class UCStats
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub


    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        MainForm.HideAllExcept("LibraryApp.UCLogsList")
    End Sub

    Private Sub UCStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        Dim Stats As Dictionary(Of String, Integer) = DbSearcher.GetBookStats()

        lbltotalbooks.Text = Stats.Item("totalBooks")
        lbllatereturns.Text = Stats.Item("lateReturns")
        lblborrowed.Text = Stats.Item("borrowed")

        Chart1.Series(0).LegendText = "Total"
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(0).Points.DataBindXY({"Total"}, {Stats.Item("totalBooks")})

        Chart1.Series(1).LegendText = "Borrowed"
        Chart1.Series(1).IsValueShownAsLabel = True
        Chart1.Series(1).Points.DataBindXY({"Borrowed"}, {Stats.Item("borrowed")})


        Chart1.Series(2).LegendText = "Late Returns"
        Chart1.Series(2).IsValueShownAsLabel = True
        Chart1.Series(2).Points.DataBindXY({"Late Returns"}, {Stats.Item("lateReturns")})
    End Sub





End Class





