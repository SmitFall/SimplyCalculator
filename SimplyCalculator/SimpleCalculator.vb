'Fallon Smith
'RCET0265
'Spring 2022
'simple calculator
'

Option Explicit On
Option Strict On
Module SimpleCalculator

    Sub Main()
        Dim userResponse As String
        Dim firstNumber As String
        Dim secondNumber As String
        Dim result As Decimal
        Console.WriteLine("Please choose:
1: sum 
2: product")
        userResponse = Console.ReadLine()
        Console.WriteLine("Please type in a number")
        firstNumber = Console.ReadLine()

        Console.WriteLine("Please type in another number")
        secondNumber = Console.ReadLine()

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
