Module Module1

    Sub Main()
        Dim ReservePrice(9), index, NumBids(9), BuyNumID(9), SearchID As Integer
        Dim Description(9), itemNumberID(9) As String
        For index = 0 To 9
            Console.WriteLine("Enter The Item: ")
            itemNumberID(index) = CStr(Console.ReadLine)
            Console.WriteLine("Enter The Item Description: ")
            Description(index) = CStr(Console.ReadLine)
            Console.WriteLine("Enter The Reserved Price for " & itemNumberID(index) & " : ")
            ReservePrice(index) = CInt(Console.ReadLine)
            NumBids(index) = 0
            Console.Clear()
        Next
        For index = 0 To 9
            Console.WriteLine("Item Number " & index + 1 & ": " & itemNumberID(index))
            Console.WriteLine("Item Description " & index + 1 & ": " & Description(index))
            Console.WriteLine("Reserved Price of " & itemNumberID(index) & ": " & ReservePrice(index))
            Console.WriteLine()
        Next
        For index = 0 To 9
            Console.WriteLine(itemNumberID(index) & " : " & index + 1)
        Next
        Console.WriteLine("Enter an item number for detail: ")
        Console.Clear()
        SearchID = CInt(Console.ReadLine)
        For index = 0 To 9
            If SearchID = itemNumberID(index + 1) Then
                Console.WriteLine("Item Number : " & index + 1)
                Console.WriteLine("Item : " & itemNumberID(index))
                Console.WriteLine("Item Description : " & Description(index))
                Console.WriteLine("Reserved Price : " & ReservePrice(index))
                Console.WriteLine("Current Bids : " & NumBids(index))
                Console.ReadKey()
                Console.Clear()
            End If
        Next
        Console.ReadKey()

    End Sub

End Module