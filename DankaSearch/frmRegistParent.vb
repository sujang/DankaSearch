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
        Using conn As SQLiteConnection = SQLiteUtil.getConnection()
            Dim cmd As SQLiteCommand

            'オープン
            conn.Open()

            'コマンド作成
            cmd = conn.CreateCommand

            '存在チェック
            cmd.CommandText = String.Format("SELECT COUNT(*) FROM FAMILY WHERE DankaNo = {0}", Me.檀家番号Label1.Text)
            Dim count As Integer = cmd.ExecuteScalar
            If count > 0 Then
                MsgBox("既に登録されています")
                Exit Sub
            End If

            'SQL作成
            cmd.CommandText = String.Format("INSERT INTO FAMILY (DankaNo, ParentDankaNo) VALUES({0},{1});" _
                                                , Me.檀家番号Label1.Text _
                                                , Me.cmbDanka.SelectedValue _
                                                )

            'SQL実行
            Dim result As Integer = cmd.ExecuteNonQuery

            If result > 0 Then
                MsgBox("登録されました")
            End If

            '破棄
            cmd.Dispose()
            conn.Close()
        End Using

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmRegistParent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call setDropDownList()
    End Sub
End Class