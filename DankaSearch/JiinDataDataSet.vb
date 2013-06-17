Partial Class JiinDataDataSet
    Partial Class T_D_檀家Row
        Public ReadOnly Property DisplayName() As String
            Get
                Return String.Format("{0}({1})", Me.檀家番号, Me.戸主氏名)
            End Get
        End Property

    End Class

End Class
