Module Module1

    Sub Main()
        Console.WriteLine("請輸入數值個數:")
        Dim size As Integer = Console.ReadLine()
        Dim i As Integer = 0
        Dim numberArray(size - 1) As Integer
        Console.WriteLine("請輸入數值:")
        For i = 0 To size - 1
            Console.WriteLine("第 {0} 個", i + 1)
            numberArray(i) = Console.ReadLine()
        Next
        Console.WriteLine()
        Console.WriteLine("Max: {0}", GetMax(numberArray))
        Console.WriteLine("Min: {0}", GetMin(numberArray))
        Console.ReadLine()
    End Sub

    Function GetMax(ByVal ParamArray numberArray() As Integer) As Integer

        Dim max As Integer = numberArray(0)

        For i As Integer = 0 To UBound(numberArray)
            If numberArray(i) > max Then
                max = numberArray(i)
            End If
        Next
        Return max
    End Function
    Function GetMin(ByVal ParamArray numberArray() As Integer) As Integer

        Dim min As Integer = numberArray(0)

        For i As Integer = 0 To UBound(numberArray)
            If numberArray(i) < min Then
                min = numberArray(i)
            End If
        Next
        Return min
    End Function
End Module