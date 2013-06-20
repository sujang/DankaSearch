Imports System.Data.SQLite

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
        '登録処理
        Using Connection As New SQLiteConnection
            Dim Command As SQLiteCommand

            '接続文字列を設定
            Connection.ConnectionString = "Version=3;Data Source=DankaRelation.db;New=False;Compress=True;"

            'オープン
            Connection.Open()

            'コマンド作成
            Command = Connection.CreateCommand

            'SQL作成
            Command.CommandText = String.Format("INSERT INTO FAMILY (DankaNo, ParentDankaNo) VALUES({0},{1});" _
                                                , Me.檀家番号Label1.Text _
                                                , Me.cmbDanka.SelectedValue _
                                                )

            'SQL実行
            Dim count As Integer = Command.ExecuteNonQuery

            If count > 0 Then
                MsgBox("登録されました")
            End If

            '破棄
            Command.Dispose()
            Connection.Close()
        End Using

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRegistParent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call setDropDownList()
    End Sub
End Class