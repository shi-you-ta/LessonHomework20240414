Imports System
Imports System.Runtime.InteropServices

Module MainModule
    Sub Main(args As String())
        '①月、旧月名を表示する
        'Class1型のインスタンスを生成
        Dim obj1 As New Class1()
        obj1.MonthDisplay()
        '改行
        Console.WriteLine()

        '②数値を入力し、符号によって異なる戻り値を取得
        Console.WriteLine("数値を2回入力して下さい。")
        '入力された文字列型数値を変数に格納
        Dim input1 As String = Console.ReadLine
        Dim input2 As String = Console.ReadLine

        Try
            '入力された文字列型数値を整数型に変換
            Dim num1 As Integer = Convert.ToInt32(input1)
            Dim num2 As Integer = Convert.ToInt32(input2)
            Dim substruct As Integer
            'Class2型のインスタンスを生成
            Dim obj2 As New Class2()
            'num1とnum2とsubstructを引数にしてSubstructメソッドを実行
            '結果をoutcomeに格納
            Dim outcome = obj2.Substruct(num1, num2, substruct)
            Console.WriteLine(outcome)
        Catch ex As Exception
            '例外処理
            Console.WriteLine("不適切な入力が行われました。" & vbCrLf &
                              "再度数値を入力して下さい。")
        End Try
        '改行
        Console.WriteLine()

        '③プロパティの実行結果
        'コンソールへの日付入力を促す
        Console.WriteLine("任意の日付を例に倣って入力して下さい。" & vbCrLf &
                          "（例）2024/04/14")
        'コンソールへ入力した文字列を変数に格納
        Dim inputDate = Console.ReadLine()

        Try
            '入力を日付型に変換する
            Dim realDate = Date.Parse(inputDate)
            'Class3型のインスタンスを生成
            Dim obj3 As New Class3()
            '今日の日付をDateMonthプロパティで取得
            obj3.DateMonth = realDate
            'DateMonthプロパティ値（今日の日付）を表示する。
            Console.WriteLine("今日の日付は、" & obj3.DateMonth & "です。")
            'realDateの月を旧月名で表示する。
            Console.WriteLine("入力した日付の月の旧月名は" & obj3.GetMonthName() & "です。")
        Catch ex As Exception
            Console.WriteLine("文字列を日付に変換出来ませんでした。")
        End Try
        '改行
        Console.WriteLine()

        '④作業中のディレクトリを表示する
        'Class4型のインスタンスを生成する
        Dim obj4 As New Class4()
        '変数にGetCurrentDirectoryメソッドで取得したパスを格納
        Dim path As String = obj4.GetCurrentDirectory()
        'コンソールに表示する
        Console.WriteLine("作業中ディレクトリ:{0}", path)
    End Sub
End Module
