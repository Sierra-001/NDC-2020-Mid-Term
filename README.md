# Important:
1. Read Prerequisite in Additional Information Folder.
2. Complete Source Code have been converted in a text format for mobile preview compatibility.
3. Seperated all task for better understanding.

# Some notes to considered:

1.line 57 in module1, add {Search <> 0 And} before {Search <> 1 And} if error appear for value 1 and 10 don't work.

2.line 64 in module1, decided to comment {Console.Clear()}.

3.line 79 in module1 {Console.WriteLine("Your Bid Must Be Higher Than The Maximum Bid")} rarely displayed during testing.

-added reason below:
The statement check if the bid entered is greater than the maxbid which is by default 0 in the first run for all item, it will only display if the user have already enter a value which is greater than 0 in the first run for the same selected item.

-correction:
Added {Console.WriteLine("Your Bid Must Be Higher Than The Maximum Bid")} in line 76 so that it notify the user even on the first run.
