Module TemplateII
    'DataGridView Two Columns
    Public Sub FillDGConfigTwo(sa As String, da As String, dg As DataGridView)
        With dg
            .Rows.Clear()
            .ColumnCount = 2
            DGColumnName(sa, da, 0, 1, dg)
            DGColumnWidth(sa, da, 100, 250, dg)
            DGFunctions(dg)
        End With
    End Sub

    'DataGridView Three Columns
    Public Sub FillDGConfigThree(sa As String, da As String, ta As String, dg As DataGridView)
        With dg
            .Rows.Clear()
            .ColumnCount = 3
            DGColumnName(sa, da, 0, 1, dg)
            DGColumnName(ta, ta, 2, 2, dg)
            DGColumnWidth(sa, da, 100, 170, dg)
            DGColumnWidth(ta, ta, 170, 170, dg)
            DGFunctions(dg)
        End With
    End Sub

    'DataGridView four Columns
    Public Sub FillDGConfigFour(sa As String, da As String, ta As String, ma As String, dg As DataGridView)
        With dg
            .Rows.Clear()
            .ColumnCount = 4
            DGColumnName(sa, da, 0, 1, dg)
            DGColumnName(ta, ma, 2, 3, dg)
            DGColumnWidth(sa, da, 100, 140, dg)
            DGColumnWidth(ta, ma, 140, 140, dg)
            DGFunctions(dg)
        End With
    End Sub

    'DataGridView Eight Columns
    Public Sub FillDGConfigEight(sa As String, sa2 As String, sa3 As String, sa4 As String, sa5 As String, sa6 As String, sa7 As String, sa8 As String, dg As DataGridView)
        With dg
            .Rows.Clear()
            .ColumnCount = 8
            DGColumnName(sa, sa2, 0, 1, dg)
            DGColumnName(sa3, sa4, 2, 3, dg)
            DGColumnName(sa5, sa6, 4, 5, dg)
            DGColumnName(sa7, sa8, 6, 7, dg)
            DGColumnWidth(sa, sa2, 100, 100, dg)
            DGColumnWidth(sa3, sa4, 100, 100, dg)
            DGColumnWidth(sa5, sa6, 100, 100, dg)
            DGColumnWidth(sa7, sa8, 100, 100, dg)
            DGFunctions(dg)
        End With
    End Sub

    'DataGridView Column Properties
    Private Sub DGColumnName(sa As String, da As String, a1 As Integer, a2 As Integer, dg As DataGridView)
        With dg
            .Columns(a1).Name = sa
            .Columns(a2).Name = da
        End With
    End Sub

    'DataGridView Width Properties
    Private Sub DGColumnWidth(sa As String, da As String, a1 As Integer, a2 As Integer, dg As DataGridView)
        With dg
            .Columns(sa).Width = a1
            .Columns(da).Width = a2
        End With
    End Sub

    'DataGridView Main Properties
    Private Sub DGFunctions(dg As DataGridView)
        With dg
            .ForeColor = Color.Blue
            .GridColor = Color.White
            .RowHeadersVisible = False
            .ScrollBars = ScrollBars.Both
            .BackgroundColor = Color.White
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .BorderStyle = BorderStyle.Fixed3D
            .EnableHeadersVisualStyles = False
            .DefaultCellStyle.ForeColor = Color.Blue
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.Blue
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowHeadersDefaultCellStyle.ForeColor = Color.Blue
            .RowHeadersDefaultCellStyle.BackColor = Color.White
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
            .ColumnHeadersDefaultCellStyle.BackColor = Color.White
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Blue
            .RowHeadersDefaultCellStyle.SelectionForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        End With
    End Sub
End Module
