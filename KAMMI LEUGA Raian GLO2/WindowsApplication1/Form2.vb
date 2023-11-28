Public Class Form2
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelprenom.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles labelemail.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub labelvalider_Click(sender As Object, e As EventArgs) Handles labelvalider.Click

        Dim verif As New Abonne()

        verif.Idnom = labelnom.Text
        verif.Prenom = labelprenom.Text
        verif.Contact = labelcontact.Text
        verif.Email = labelemail.Text
        verif.Numreabonnement = Labelreabonnement.Text


        If verif.Verifier() = True Then

            Form4.DataGridView1.Rows.Add(verif.Idnom, verif.Prenom, verif.Contact, verif.Email, verif.Numreabonnement)

            Form4.Show()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class