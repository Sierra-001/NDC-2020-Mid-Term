Module module1
    Sub Main()
        Dim MaxBid(limit), TempBid As Double    'Task 2
        Dim NumBid(limit), Search, TotalFee, NumSold, NumNotSold As Integer
        Dim decision As Char
        Dim Buyer(limit), BuyID, Status(limit) As String
        Console.Clear()

        For count = 0 To limit
            'Console.WriteLine("Item Number= " & ItemNumbers(count) & " ItemDescription = " & ProductDescription(count) & " Max Bid = " & MaxBid(count) & " No. of Bids= " & NumBid(count))
            Console.WriteLine("Item " & Item(count))
            Console.WriteLine("Description :" & Description(count))
            Console.WriteLine("Maximum Bid : " & MaxBid(count))
            Console.WriteLine("Number of Bids : " & NumBid(count))
            Console.WriteLine()
        Next

        Console.WriteLine("Do you want to bid? Y/N")
        decision = Console.ReadLine
        Console.Clear()
        Do
            Console.WriteLine("Please Enter your Buyer ID Number")
            BuyID = Console.ReadLine
            Console.Clear()

            For count = 0 To limit
                'Console.WriteLine("ITEM # " & ItemNumbers(count) & " ItemDescription =" & ProductDescription(count) & " Max Bid =" & MaxBid(count) & " No. of Bids= " & NumBid(count) & " ::Status = " & ItemStatus(count))
                Console.WriteLine("Item " & Item(count))
                Console.WriteLine("Description :" & Description(count))
                Console.WriteLine("Maximum Bid : " & MaxBid(count))
                Console.WriteLine("Number of Bids : " & NumBid(count))
                Console.WriteLine("Item Status : " & Status(count))
                Console.WriteLine()
            Next

            Console.WriteLine("Please Enter The Item Number You Want To Bid")
            Search = Console.ReadLine
            Console.Clear()
            Do
                If Not (Search >= 1 And Search <= 10) Then
                    Console.WriteLine()
                    Console.WriteLine("ERROR! , Item Number Is Outside Range! , Please Enter A New Valid Item Number From 1 To " & (limit + 1))
                    Search = Console.ReadLine()
                End If
            Loop While (Search <> 1 And Search <> 2 And Search <> 3 And Search <> 4 And Search <> 5 And Search <> 6 And Search <> 7 And Search <> 8 And Search <> 9 And Search <> 10)
            'Search <> 0 And
            Search = Search - 1
            NumBid(Search) = NumBid(Search) + 1
            Console.WriteLine("Current Highest Bid is Rs " & MaxBid(Search))
            Console.WriteLine("Please Enter Bid You Want To Place")
            TempBid = Console.ReadLine
            'Console.Clear()

            If (TempBid >= MaxBid(Search)) Then
                MaxBid(Search) = TempBid
                If MaxBid(Search) >= ReservePrice(Search) Then
                    Buyer(Search) = BuyID
                    Status(Search) = "SOLD"
                    Console.WriteLine("Congrats You WON BID, Item Sold To :" & BuyID)
                Else
                    Status(Search) = "NOT SOLD"
                    If (Status(Search) = "NOT SOLD") Then
                        Console.WriteLine("Your Bid Must Be Higher Than The Maximum Bid")
                    End If
                End If
            Else
                'This Is in case the user type less than 0 for the first run or have type less than the previous maximum bid entered!
                'this will rarely show since the if statement check togother if the value is equal and not greater alone, in case it
                'was supposed to show it must bid higher then remove the equal operator And do another if statement seperately!
                Console.WriteLine("Your Bid Must Be Higher Than The Maximum Bid")
            End If

            Console.WriteLine("Press Enter Key To Continue...")
            Console.ReadLine()
            Console.Clear()
            Console.WriteLine("Do You Want To Bid Again? Y/N")
            decision = Console.ReadLine
            Console.Clear()
        Loop While UCase(decision) = ("Y")
        'While UCase(decision) = ("Y")
        '    Console.WriteLine("Please Enter your Buyer ID Number")
        '    BuyID = Console.ReadLine
        '    Console.Clear()

        '    For count = 0 To limit
        '        'Console.WriteLine("ITEM # " & ItemNumbers(count) & " ItemDescription =" & ProductDescription(count) & " Max Bid =" & MaxBid(count) & " No. of Bids= " & NumBid(count) & " ::Status = " & ItemStatus(count))
        '        Console.WriteLine("Item " & Item(count))
        '        Console.WriteLine("Description :" & Description(count))
        '        Console.WriteLine("Maximum Bid : " & MaxBid(count))
        '        Console.WriteLine("Number of Bids : " & NumBid(count))
        '        Console.WriteLine("Item Status : " & Status(count))
        '        Console.WriteLine()
        '    Next

        '    Console.WriteLine("Please Enter the Item Number you want to bid")
        '    Search = Console.ReadLine - 1
        '    Console.Clear()

        '    'While Search <> 0 And Search <> 1 And Search <> 2 And Search <> 3 And Search <> 4 And Search <> 5 And Search <> 6 And Search <> 7 And Search <> 8 And Search <> 9
        '    '    Console.WriteLine()
        '    '    Console.WriteLine("ERROR! , Item Number Is Outside Range! , Please Enter A New Valid Item Number From 1 To " & (limit + 1))
        '    '    Search = Console.ReadLine()
        '    'End While

        '    NumBid(Search) = NumBid(Search) + 1
        '    Console.WriteLine("Current Highest Bid is RS " & MaxBid(Search))
        '    Console.WriteLine("Please Enter Bid you want to place")
        '    TempBid = Console.ReadLine
        '    Console.Clear()

        '    If TempBid >= MaxBid(Search) Then
        '        MaxBid(Search) = TempBid
        '        If MaxBid(Search) >= ReservePrice(Search) Then
        '            Buyer(Search) = BuyID
        '            Status(Search) = "SOLD"
        '            Console.WriteLine("Congrats You WON BID, Item sold to :" & BuyID)
        '        Else
        '            Status(Search) = "NOT SOLD"
        '        End If
        '    Else
        '        Console.WriteLine("Your Bid must be higher than the maximum Bid")
        '    End If

        '    Console.WriteLine("Press Any Key To Continue...")
        '    Console.ReadLine()
        '    Console.Clear()
        '    Console.WriteLine("Do you want to bid again? Y/N")
        '    decision = Console.ReadLine
        '    Console.Clear()
        'End While
        Console.ReadKey()
    End Sub
End Module