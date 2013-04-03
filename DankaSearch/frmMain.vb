Public Class frmMain

    Private Sub T_D_檀家BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_D_檀家BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JiinDataDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitForm()
        'Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
        'Me.T_D_過去帳TableAdapter.Fill(Me.JiinDataDataSet.T_D_過去帳)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'チェック処理
        Dim dankaNo As Integer
        If Integer.TryParse(Trim(Me.txtDankaNo.Text), dankaNo) = False Then
            MsgBox("檀家番号は数値で入力してください", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '檀家検索実行
        Dim row As JiinDataDataSet.T_D_檀家Row
        Me.T_D_檀家TableAdapter.Fill(JiinDataDataSet.T_D_檀家)
        row = JiinDataDataSet.T_D_檀家.FindBy檀家番号(dankaNo)

        'エラー判定
        If row Is Nothing Then
            MsgBox("該当する檀家データが見つかりません", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            SetDankaInfo(row)
        End If

        '過去帳検索
        Dim kakochoList() As JiinDataDataSet.T_D_過去帳Row
        kakochoList = row.GetT_D_過去帳Rows

        'エラー判定
        If kakochoList Is Nothing OrElse kakochoList.Length = 0 Then
            MsgBox("該当する檀家の過去帳が存在しません", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.T_D_過去帳DataGridView.DataSource = kakochoList
            Me.T_D_過去帳DataGridView.AutoResizeColumns()
        End If
    End Sub

    Private Sub InitForm()
        Me.txtDankaNo.Text = ""
        Me.lblName.Text = ""
        Me.lblKana.Text = ""
    End Sub

    Private Sub SetDankaInfo(ByVal row As JiinDataDataSet.T_D_檀家Row)
        If row Is Nothing Then Exit Sub

        Me.lblName.Text = row.戸主氏名
        Me.lblKana.Text = row.ふりがな

    End Sub

End Class
