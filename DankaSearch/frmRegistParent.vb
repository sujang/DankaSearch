Public Class frmRegistParent

    Private Sub T_D_檀家BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_D_檀家BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JiinDataDataSet)

    End Sub

    Private Sub frmRegistParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'JiinDataDataSet.T_D_檀家' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)

    End Sub
End Class