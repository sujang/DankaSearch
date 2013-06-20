Imports System.Data.SQLite
Imports System.Text

Public Class frmDetail

    Protected familyList As JiinDataDataSet.T_D_檀家DataTable

    Public Sub New(ByVal dankaRow As JiinDataDataSet.T_D_檀家Row)
        Call InitializeComponent()

        Me.T_D_檀家TableAdapter.Fill(Me.JiinDataDataSet.T_D_檀家)
        With Me.T_D_檀家BindingSource
            .Filter = String.Format("檀家番号 = {0}", dankaRow.檀家番号)
            .Position = 0
        End With

        Dim currentDanka As JiinDataDataSet.T_D_檀家Row = dankaRow
        Dim familyDankaNoList As List(Of Integer) = getFamilyDankaNoList(currentDanka.檀家番号)
        Dim familyDankaTable As New JiinDataDataSet.T_D_檀家DataTable
        Me.T_D_檀家TableAdapter.Fill(familyDankaTable)
        Dim sb As New StringBuilder
        sb.Append(" 檀家番号 IN (")
        Dim isFirst As Boolean = True
        For Each i As Integer In familyDankaNoList
            If Not isFirst Then
                sb.Append(", ")
            End If
            isFirst = False
            sb.Append(String.Format("{0}", i))
        Next
        sb.Append(")")


        Me.T_D_檀家DataGridView.DataSource = familyDankaTable.Select(sb.ToString)
    End Sub

    Private Function getFamilyDankaNoList(ByVal dankaNo As Integer) As List(Of Integer)
        Dim result As New List(Of Integer)

        Using Connection As New SQLiteConnection
            Dim Command As SQLiteCommand
            Dim reader As SQLiteDataReader

            '接続文字列を設定
            Connection.ConnectionString = "Version=3;Data Source=DankaRelation.db;New=False;Compress=True;"

            'オープン
            Connection.Open()

            'コマンド作成
            Command = Connection.CreateCommand

            'SQL作成
            Command.CommandText = String.Format("SELECT * FROM FAMILY WHERE ParentDankaNo = (SELECT ParentDankaNo FROM FAMILY WHERE DankaNo = {0});" _
                                                , dankaNo _
                                                )

            'SQL実行
            reader = Command.ExecuteReader

            Do Until Not reader.Read
                result.Add(reader.Item("DankaNo"))
                result.Add(reader.Item("ParentDankaNo"))
            Loop

            '破棄
            Command.Dispose()
            Connection.Close()
        End Using

        Return result
    End Function
End Class