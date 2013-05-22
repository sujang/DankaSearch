Public Class frmDetail

    Public Sub New(ByVal dankaRow As JiinDataDataSet.T_D_檀家Row)
        Call InitializeComponent()

        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)

        With Me.T_D_檀家BindingSource
            ''.Clear()
            '.Add(dankaRow)
            .Position = 0
        End With
    End Sub

    Private Sub frmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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