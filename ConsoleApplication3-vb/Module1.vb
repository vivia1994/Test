Imports Microsoft.Office.Interop.Excel

Module Module1

    Sub Main()
       Dim s as String
        s = (New Microsoft.Office.Interop.Excel.Application().Workbooks.Open("C:\Users\vlei002\Desktop\UT Gap Report.xlsm").Worksheets(1)).Name

        Console.WriteLine(s)
        Console.ReadKey()
    End Sub

End Module
