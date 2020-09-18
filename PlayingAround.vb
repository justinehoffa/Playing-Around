Module PlayingAround

    Sub Main()
        LoadArray()

        Console.Read()
    End Sub

    Sub LoadArray()
        Dim count As Integer
        Dim values(4, 19) As Integer
        For row = 0 To 19
            For column = 0 To 4
                Console.Write($"({row},{column})")
                count += 1
                values(column, row) = count
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
