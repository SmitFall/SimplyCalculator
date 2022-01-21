'Fallon Smith
'RCET0265
'Spring 2022
'simple calculator
'https://github.com/SmitFall/SimplyCalculator/tree/5c5e064fe6ea03d41f75c00e83d43644a98336fd

Option Explicit On
Option Strict On
Module SimpleCalculator

    Sub Main()
        'asigning values
        Dim userResponse As String
        Dim firstNumber As String
        Dim secondNumber As String
        Dim result As Decimal

        'Choose operation
        Console.WriteLine("Please choose:
1: sum 
2: product")
        'Type in numbers that you want to use
        userResponse = Console.ReadLine()
        Console.WriteLine("Please type in a number")
        firstNumber = Console.ReadLine()

        Console.WriteLine("Please type in another number")
        secondNumber = Console.ReadLine()

        'Converting so they can be used in the math
        Dim A = CDec(firstNumber)
        Dim B = CDec(secondNumber)

        If userResponse = "1" Then
            result = A + B
            Console.WriteLine($"{A} + {B} = {result}")
            Console.ReadLine()
        ElseIf userResponse = "2" Then
            result = A * B
            Console.WriteLine($" {A} * {B} = {result}")
            Console.ReadLine()
        Else
            Console.WriteLine("That option is currently unavailable. please try again later")
            Console.ReadLine()
        End If

    End Sub

End Module
