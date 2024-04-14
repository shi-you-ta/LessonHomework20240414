Public Class Class3
    'date型のフィールド
    Private _dateMonth As Date

    '日付型のプロパティ
    Public Property DateMonth As Date
        Get
            'そのまま取得
            Return _dateMonth
        End Get
        Set(value As Date)
            'フィールドへ日付データを格納する
            _dateMonth = value
        End Set
    End Property

    'Class1で定義したDictionary型のValueで返すGetプロシージャだけをもつプロパティ
    Public ReadOnly Property GetMonthName() As String
        Get
            'プロパティ値参照時にGetプロシージャ呼び出す
            'Returnでフィールド値を呼び出し元に返す
            '日付データの月を変数に代入する
            Dim month As Integer = _dateMonth.Month
            Dim monthNames As New Dictionary(Of Integer, String) From {
                        {1, "睦月"},
                        {2, "如月"},
                        {3, "弥生"},
                        {4, "卯月"},
                        {5, "皐月"},
                        {6, "水無月"},
                        {7, "文月"},
                        {8, "葉月"},
                        {9, "長月"},
                        {10, "神無月"},
                        {11, "霜月"},
                        {12, "師走"}
                        }
            'もしmonthがmonthNamesのKeyに存在する場合
            'キーに対応する値を取り出す
            If monthNames.ContainsKey(month) Then
                Return monthNames(month)
            Else
                Return "問題が発生しました。"
            End If

        End Get

    End Property

End Class
