'Owen Fujii
'RCET 2265
'Spring 2024
'SayYourName
'https://github.com/Masaharu41/SayMyName.git

Option Explicit On
Option Strict On
Module SayMyName

    Sub Main()
        Dim userName As String
        Console.Write("What is your name?")
        Console.WriteLine()
        userName = Console.ReadLine()
        Console.Write($"Pleasure to meet you {userName}")

        Console.Read()
    End Sub

End Module
