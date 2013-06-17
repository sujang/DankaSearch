Public Class frmDetail

    Public Sub New(ByVal dankaRow As JiinDataDataSet.T_D_檀家Row)
        Call InitializeComponent()

        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
        With Me.T_D_檀家BindingSource
            .Filter = String.Format("檀家番号 = {0}", dankaRow.檀家番号)
            ''.Clear()
            '.Add(dankaRow)
            .Position = 0
        End With
    End Sub

End Class