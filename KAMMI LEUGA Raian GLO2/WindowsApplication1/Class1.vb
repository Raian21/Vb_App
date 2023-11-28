Public Class Abonne
    Public Idnom As String
    Public Prenom As String
    Public Contact As String
    Public Email As String
    Public Numreabonnement As String

    Public Function Verifier() As Boolean
        Dim state As Boolean = True

        If Not IsNumeric(Me.Idnom) Then
            state = False
        End If
        If Not IsNumeric(Me.Prenom) Then
            state = False
        End If
        If Not IsNumeric(Me.Contact) Then
            state = False

        End If
        If Not IsNumeric(Me.Email) Then
            state = False

        End If

        If Not IsNumeric(Me.Numreabonnement) Then
            state = False

        End If
        Return state



    End Function




End Class
