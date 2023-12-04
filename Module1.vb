Module patient
    Public Structure pat
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
    End Structure
    Public Classe(10) As pat
    Dim nbr As Integer = 0
    Function ajouter(p As pat) As Boolean
        If nbr < Classe.Length Then
            Classe(nbr) = p
            nbr += 1
            Console.WriteLine("ajout")
            Return True
        Else
            Return False
        End If
    End Function
End Module
