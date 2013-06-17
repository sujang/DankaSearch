Public Class frmRegistParent

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

    Private Sub setDropDownList()
        With Me.cmbDanka
            .DataSource = Me.JiinDataDataSet.T_D_檀家
            .DisplayMember = "DisplayName"
            .ValueMember = Me.JiinDataDataSet.T_D_檀家.檀家番号Column.ColumnName
        End With
    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        'TODO: 登録処理
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRegistParent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call setDropDownList()
    End Sub
End Class