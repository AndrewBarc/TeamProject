﻿Public Class Transaction
    Private _TDate As String

    Public Property TDate() As String
        Get
            Return _TDate
        End Get
        Set(ByVal Value As String)
            _TDate = Value
        End Set
    End Property

    Private _TAmount As Integer

    Public Property TAmount() As Integer
        Get
            Return _TAmount
        End Get
        Set(ByVal Value As Integer)
            _TAmount = Value
        End Set
    End Property

    Private _TDescription As String

    Public Property TDescription() As String
        Get
            Return _TDescription
        End Get
        Set(ByVal Value As String)
            _TDescription = Value
        End Set
    End Property

End Class