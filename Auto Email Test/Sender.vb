Module Sender

    Sub Main()
        Dim Client As New System.Net.Mail.SmtpClient 'Create a new SmtpClient object to send from
        Console.WriteLine("Input Email address e.g. YourUserName@Email.com")
        Dim nAddress As String = Console.ReadLine() 'Read the inputed email address
        Dim nHost As String = ""
        If nAddress.Contains("gmail") = True Then 'It's a gmail address
            nHost = "smtp.gmail.com"
        ElseIf nAddress.Contains("hotmail") = True Then 'It's a hotmail address
            nHost = "smtp.live.com"
        End If
        If nHost <> "" Then 'The input was a valid address
            Console.WriteLine("Input Email Password e.g. MyEmailPassword123")
            Dim nPassword As String = Console.ReadLine() 'Read the inputed email password
            Client.Host = nHost 'Set the SMTP host of the user
            Client.Port = 25 'Set the port of the user
            Client.Credentials = New Net.NetworkCredential(nAddress, nPassword) 'Set the address and password
            Client.EnableSsl = True 'Encypt the connection
            '!!!!!Replace 'RECIPIENT' with the email address of the account recieving the email!!!!!
            Dim mail As New System.Net.Mail.MailMessage(nAddress, "RECIPIENT", "Auto Email Device", "Hello World!!!")
            Console.WriteLine("Sending, this might take a few moments...")
            Client.Send(mail)
            Console.WriteLine("Message was sent")
        Else 'The host was unknown
            Console.WriteLine(Environment.NewLine +
                              "Error : Address was not a Gmail or Hotmail account" + Environment.NewLine +
                              "Please use a valid Gmail or Hotmail account to send message.")
        End If
        Console.WriteLine(Environment.NewLine + "Press enter to exit...")
        Console.ReadLine() 'Wait for enter to be pressed
    End Sub

End Module
