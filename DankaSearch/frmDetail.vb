Public Class frmDetail

    Public Sub New(ByVal dankaRow As JiinDataDataSet.T_D_檀家Row)
        Me.T_D_檀家BindingSource.Item(0) = dankaRow
        Me.T_D_檀家BindingSource.Position = 0
    End Sub
    Private Sub frmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'JiinDataDataSet.T_D_過去帳' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_D_過去帳TableAdapter.Fill(Me.JiinDataDataSet.T_D_過去帳)
        'TODO: このコード行はデータを 'JiinDataDataSet.T_D_檀家' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
        'TODO: このコード行はデータを 'JiinDataDataSet.T_D_檀家' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
        'TODO: このコード行はデータを 'JiinDataDataSet.T_D_檀家' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)

    End Sub

    Private Sub T_D_檀家BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_D_檀家BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JiinDataDataSet)

    End Sub

    Private Sub T_D_檀家BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_D_檀家BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JiinDataDataSet)

    End Sub

    Private Sub 檀家番号Label_Click(sender As Object, e As EventArgs)

    End Sub
End Class