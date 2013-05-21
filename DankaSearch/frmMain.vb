Imports System.Data.OleDb

Public Class frmMain

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Me.txtDankaNo.Text = Me.txtDankaNo.Text & e.KeyValue
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Call InitForm()
            '初期表示するために一旦バインド停止
            Me.T_D_檀家BindingSource.SuspendBinding()
            Me.T_D_過去帳DataGridView.DataSource = Nothing

            Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
            Me.T_D_過去帳TableAdapter.Fill(Me.JiinDataDataSet.T_D_過去帳)

        Catch ex As OleDbException
            MsgBox(ex.Message)
            MsgBox("エラーが発生したため終了します")
            Me.Close()
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '初期表示するために一旦バインド停止
        Call InitForm()

        'チェック処理
        Dim dankaNo As Integer
        If Integer.TryParse(Trim(Me.txtDankaNo.Text), dankaNo) = False Then
            MsgBox("檀家番号は数値で入力してください", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '檀家検索実行
        Dim index As Integer = Me.T_D_檀家BindingSource.Find("檀家番号", dankaNo)
        If index < 0 Then
            MsgBox("指定された檀家番号は存在しません", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.T_D_檀家BindingSource.ResumeBinding()
        Me.T_D_過去帳DataGridView.DataSource = Me.T_D_過去帳BindingSource

        Me.T_D_檀家BindingSource.Position = index

        For Each ctrl As Control In Me.grpMenu.Controls
            ctrl.Enabled = Not Me.T_D_檀家BindingSource.IsBindingSuspended
        Next
    End Sub

    Private Sub InitForm()
        'Me.txtDankaNo.Text = ""
        'Me.lblName.Text = ""
        'Me.lblKana.Text = ""

        Me.T_D_檀家BindingSource.SuspendBinding()
        Me.T_D_過去帳DataGridView.DataSource = Nothing
    End Sub

    Private Sub SetDankaInfo(ByVal row As JiinDataDataSet.T_D_檀家Row)
        If row Is Nothing Then Exit Sub

        Me.lblName.Text = row.戸主氏名
        Me.lblKana.Text = row.ふりがな

    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        Dim row As JiinDataDataSet.T_D_檀家Row = DirectCast(DirectCast(Me.T_D_檀家BindingSource.Current, DataRowView).Row, JiinDataDataSet.T_D_檀家Row)
        Dim detail As Form = New frmDetail(row)
        detail.ShowDialog()
    End Sub
End Class
