
Public Class Class4
    '作業中ディレクトリをフルパスで取得するメソッドを定義する
    Public Function GetCurrentDirectory() As String
        '作業中ディレクトリのパスを戻り値として返す
        Return System.IO.Directory.GetCurrentDirectory()
    End Function
End Class
