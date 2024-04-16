Public Class Class2
    '引数を3つ取るFunctionメソッド
    Public Function Substruct(ByVal n1 As Integer, ByVal n2 As Integer, ByRef result As Integer) As Integer
        '計算結果をresultに代入
        result = n1 - n2
        'resultを変数に代入
        Dim resultEvaluation = result
        '結果がプラス値なら1、0なら0、マイナス値なら-1をresultへ格納
        Select Case resultEvaluation
            Case > 0
                resultEvaluation = 1
            Case = 0
                resultEvaluation = 0
            Case < 0
                resultEvaluation = -1
        End Select
        '戻り値としてresultを返す
        Return resultEvaluation
    End Function

End Class
