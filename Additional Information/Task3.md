Module module1
    Sub Main()
         For count = 0 To limit  'Task 3
            If (Status(count) = "SOLD") Then
                TotalFee = TotalFee + (MaxBid(count) * 90 / 100)
                Console.WriteLine(Buyer(count) & " Have Purchased " & Description(count))
                Console.WriteLine("Press Enter Key To Conitinue...")
                Console.ReadLine()
            End If
            
            If (count = limit) Then
                Console.WriteLine("Total Fee of all Item Sold: RS " & TotalFee)
                Console.WriteLine("Press Enter Key To Conitinue...")
                Console.ReadLine()
            End If
        Next
        
        For count = 0 To limit
                    If (Status(count) = "NOT SOLD") Then
                Console.WriteLine("Item " & Item(count) & " Have Not Reached The Reserved Price!")
                Console.WriteLine("Final Bids For " & Description(count) & ": " & MaxBid(count))
                Console.WriteLine("Press Enter Key To Continue...")
                Console.ReadLine()
                Console.WriteLine()
            End If
            
            If (NumBid(count) = 0) Then
                Console.WriteLine("Item " & Item(count) & ", " & Description(count) & " Have Received No Bids!")
                Console.WriteLine("Press Enter Key To Continue...")
                Console.ReadLine()
            End If
            
            If (Status(count) = "SOLD") Then
                NumSold = NumSold + 1
            End If
            
            If (MaxBid(count) < ReservePrice(count)) Then
                NumNotSold = NumNotSold + 1
            End If
            
            If (count = limit) Then
                Console.WriteLine(NumSold & " have been Sold!")
                Console.WriteLine(NumNotSold & " have not been sold!")
                Console.WriteLine()
            End Ifs
        Next
        Console.WriteLine("Press Enter Key To Terminate The Program...")
        Console.ReadKey()
    End Sub
End Module
