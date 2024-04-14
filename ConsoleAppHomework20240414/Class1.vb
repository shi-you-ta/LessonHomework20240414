Public Class Class1
    'Dictionary型のフィールドを宣言/初期化
    Dim dicMonth As New Dictionary(Of Integer, String) From {
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

    'For Each...NextでKeyとValueを取得し、コンソールに表示させるメソッド
    Public Sub MonthDisplay()
        'ディクショナリのキーが6もしくは12の場合
        '★を末尾に追加してコンソール出力する
        For Each item In dicMonth
            If item.Key = 6 Or item.Key = 12 Then
                Console.WriteLine("[{0}:{1}]" & "★", item.Key, item.Value)
            Else
                Console.WriteLine("[{0}:{1}]", item.Key, item.Value)
            End If
        Next
    End Sub
End Class
