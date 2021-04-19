Module ModulosVarios
    Sub alternarColoFilasDatagridview(ByVal dgv As DataGridView)
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.AliceBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 68, 102)
            .EnableHeadersVisualStyles = False
        End With
    End Sub
End Module
