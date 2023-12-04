Module rendezvous
    Public Structure rdv
        Dim code As Integer
        Dim dat As Date

    End Structure
    Public Classer(10) As rdv
    Dim nbr As Integer = 0
    Function ajout(r As rdv) As Boolean
        If nbr < Classe.Length Then
            Classer(nbr) = r
            nbr += 1
            Console.WriteLine("ajout")
            Return True
        Else
            Return False
        End If
    End Function
End Module
