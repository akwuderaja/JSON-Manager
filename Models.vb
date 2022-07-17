Public Class Models

    Class IndividualDifference
        Public Property furniId As Integer
        Public Property IndividualPercent As Double
    End Class

    Class jsonClass
        Public Property furniId As Integer
        Public Property buyPrice As Integer
        Public Property sellPrice As Integer
    End Class

    Class snapshots
        Public Property timestamp As Long
        Public Property cheapestPrice As Integer
        Public Property cheapestOfferId As Long
        Public Property averagePrice As Integer
        Public Property offerCount As Integer
        Public Property furniName As String
    End Class
End Class
