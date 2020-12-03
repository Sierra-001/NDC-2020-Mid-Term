Module Module1

    Sub Main()
        'TASK 1
        Const NumItems As Integer = 10
        Dim ItemNumbers(NumItems), ReservePrice(NumItems) As Integer
        Dim ProductDescription(NumItems) As String
        For count = 1 To NumItems
            ItemNumbers(count) = count 'Automatically gives a unique itemnumber
            Console.WriteLine("ITEM-" & ItemNumbers(count))
            Console.WriteLine("Please Enter Description for the Product")
            ProductDescription(count) = Console.ReadLine
            Console.WriteLine("Please Enter the Reserve Price for the Product")
            ReservePrice(count) = Console.ReadLine
        Next
        Console.Clear()
        Dim MaxBid(NumItems), BidPrice As Decimal
        Dim NumBid(NumItems), Number As Integer
        Dim Choice As Char
        Dim Buyer(NumItems), BuyerNumber, ItemStatus(NumItems) As String
        Console.WriteLine("..................................................................")
        For count = 1 To NumItems
            Console.WriteLine("Item Number= " & ItemNumbers(count) & " ItemDescription = " & ProductDescription(count) & " Max Bid = " & MaxBid(count) & " No. of Bids= " & NumBid(count))
        Next
        Console.WriteLine("For Bidding Press Y, else Press N")
        Choice = Console.ReadLine
        While UCase(Choice) = ("Y")
            Console.WriteLine("Please Enter your Buyer Number")
            BuyerNumber = Console.ReadLine
            Console.WriteLine("............................................................")
            For count = 1 To NumItems
                Console.WriteLine("ITEM # " & ItemNumbers(count) & " ItemDescription =" & ProductDescription(count) & " Max Bid =" & MaxBid(count) & " No. of Bids= " & NumBid(count) & " ::Status = " & ItemStatus(count))
            Next
            Console.WriteLine("Please Enter the Item Number of Product you want to bid")
            Number = Console.ReadLine
            While Number <> 1 And Number <> 2 And Number <> 3 And Number <> 4 And Number <> 5 And Number <> 6 And Number <> 7 And Number <> 8 And Number <> 9 And Number <> 10
                Console.WriteLine("ERROR,ItemNumbers dont match, enter valid Item Number")
                Number = Console.ReadLine()
            End While
            NumBid(Number) = NumBid(Number) + 1
            Console.WriteLine("Current Highest Bid is $" & MaxBid(Number))
            Console.WriteLine("Please Enter Bid you want to place")
            BidPrice = Console.ReadLine
            If BidPrice >= MaxBid(Number) Then
                MaxBid(Number) = BidPrice
                If MaxBid(Number) >= ReservePrice(Number) Then
                    Buyer(Number) = BuyerNumber
                    ItemStatus(Number) = "***SOLD***"
                    Console.WriteLine("Congrats You WON BID, Item sold to:" & BuyerNumber)
                Else
                    ItemStatus(Number) = " ----NOT SOLD---- "
                End If
            Else
                Console.WriteLine("Your Bid must be higher than the maximum Bid")
            End If
            Console.WriteLine(" BID AGAIN Press Y, else Press N")
            Choice = Console.ReadLine
        End While
    End Sub

End Module
