Module Module1
    Sub Main()
        ' Feel free to use this.
        ' Set the background color of the console to black
        Console.BackgroundColor = ConsoleColor.Black

        ' Set the text color to white for better visibility
        Console.ForegroundColor = ConsoleColor.White

        ' Get the command from the user
        Do
            ' Process the command
            Dim output As String = ProcessCommand()

            ' Display the output only if it's not empty
            If Not String.IsNullOrEmpty(output) Then
                ' Display the command and output
                Console.WriteLine("/" & output)
            Else
                ' Display a message for commands with no specific output
                Console.WriteLine("No specific output for this command.")
            End If

            ' Reset the console colors
            Console.ResetColor()

        Loop While True
    End Sub

    Private Function ProcessCommand() As String
        ' Customize this function to implement your command processing logic
        Dim command As String = Console.ReadLine()

        Dim tokens As String() = command.Split(" "c)
        ' Get the command from the user

        Select Case tokens(0).ToLower()
            Case "hello"
                Return "Hello!"
            Case "time"
                Return "Current time: " & DateTime.Now.ToString("HH:mm:ss")
            Case "about"
                Return "0.737 pre-release - Developed by redx"
            Case "write"
                ' Join the arguments (excluding the "print" part) and return as the output
                Return String.Join(" ", tokens.Skip(1))
            Case Else
                Return String.Empty ' Return an empty string for unknown commands

        End Select
    End Function
End Module
