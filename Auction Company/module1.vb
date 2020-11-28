Module module1
    Sub Main()
        Dim ReservePrice(9), NumBids(9), HighestBids(9), search, TempBids, index, limit As Integer
        Dim Item(9), Description(9), decision, BuyID(limit) As String

        For index = 0 To 2
            Console.Write("Enter Item " & index + 1 & " Name :")
            Item(index) = Console.ReadLine
            Console.Write("Enter " & Item(index) & " Description :")
            Description(index) = Console.ReadLine
            Console.Write("Enter Reserved Price For " & Item(index) & " :")
            ReservePrice(index) = Console.ReadLine
            NumBids(index) = 0
            HighestBids(index) = 0
            Console.Clear()
        Next
        'Console.WriteLine()
        Do
            For index = 0 To 2
                Console.WriteLine("Item " & index + 1 & ": " & Item(index))
            Next
            Console.WriteLine()
            'Console.WriteLine("do you want to place a bids y/n")
            Console.Write("Enter The Item ID For More Details : ")
            search = Console.ReadLine
            For index = 0 To 2
                If (search = index + 1) Then
                    Console.WriteLine("Item " & index + 1 & ": " & Item(index))
                    Console.WriteLine(Item(index) & " Description :" & Description(index))
                    Console.WriteLine(Item(index) & " Reserve Price : " & ReservePrice(index))
                    Console.WriteLine("Current Bids: " & NumBids(index))
                    Console.WriteLine("Highest Bids: " & HighestBids(index))
                    Console.WriteLine()
                    'If (index = 9) Then
                    '    Console.WriteLine("press enter to exit!")
                    'End If
                    Console.WriteLine("Do You Want To Place a Bids? y/n")
                    decision = Console.ReadLine
                    If ((decision = "y") Or (decision = "Y")) Then
                        Console.Write("Enter Buyer ID : ")
                        BuyID(limit) = Console.ReadLine
                        Console.Write("Enter Bids For " & Item(index) & " :")
                        TempBids = Console.ReadLine
                        If (TempBids > HighestBids(index)) Then
                            HighestBids(index) = TempBids
                            NumBids(index) = NumBids(index) + 1
                            Console.Clear()
                            Console.WriteLine("Information For Item " & Item(index) & " have been changed!")
                        End If
                    End If
                End If
            Next
            For index = 0 To 2
                Console.WriteLine("Item " & index + 1 & ": " & Item(index))
                Console.WriteLine(Item(index) & " Description :" & Description(index))
                Console.WriteLine(Item(index) & " Reserve Price : " & ReservePrice(index))
                Console.WriteLine("Current Bids: " & NumBids(index))
                Console.WriteLine("Highest Bids: " & HighestBids(index))
                Console.WriteLine()
            Next
            Console.WriteLine()
            Console.WriteLine("press any key to continue...")
            Console.ReadKey()
            Console.Clear()
            Console.WriteLine("You you want to continue? y/n")
            decision = Console.ReadLine
        Loop Until ((decision = "n") Or (decision = "N"))
        Console.ReadKey()
    End Sub
End Module