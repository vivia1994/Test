Option Strict
Module Module1

    Sub Main()
        Dim dec As Decimal
        'Dim per As pe
        dec = 1
        '小数保留后两位
        dec = CDec(String.Format("{0:N2}", 1.335))
        dec = CDec((1.335).ToString("#.##"))
        Dim tempTable As DataTable
        Dim result = From groupDt In From w In tempTable.AsEnumerable()Group w By w("Domain")New With { _
	Key .Domain = groupDt.Key, _
	Key .Sum = groupDt.Sum(Function(r) Decimal.Parse(r("Count").ToString())) _
}
        ''小数转换成百分数
        'Console.WriteLine(string.Format("{0:P}", Convert.ToDecimal(0.24583.ToString)))      '（默认保留百分的两位小数）
        'Console.WriteLine(Convert.ToDecimal("0.23335555555555").ToString("P", new System.Globalization.NumberFormatInfo()))
        'Console.WriteLine(dec)

        dec = 00300329877
        Console.WriteLine(Right(dec.ToString, 9))
        Console.ReadKey()
    End Sub
   ' Public Sub Main()
   '   Dim lines() As String = { "This is the first line.", _
   '                             "This is the second line." }
   '   ' Output the lines using the default newline sequence.
   '   Console.WriteLine("With the default new line characters:")
   '   Console.WriteLine()
   '   For Each line As String In lines
   '      Console.WriteLine(line)
   '   Next
   '   Console.WriteLine()

   '   ' Redefine the newline characters to double space.
   '   Console.Out.NewLine = vbCrLf + "___________"
   '   ' Output the lines using the new newline sequence.
   '   Console.WriteLine("With redefined new line characters:")
   '   Console.WriteLine()
   '   For Each line As String In lines
   '      Console.WriteLine(line)
   '   Next
   '     Console.Read()
   'End Sub
End Module
