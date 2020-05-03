
Public Class Form1

    Dim numA, numB, numC As Double

    Dim p1, p2, delta As Double



    Private Sub btnResolver_Click(sender As Object, e As EventArgs) Handles btnResolver.Click

        lblResultado1.Text = ""
        lblResultado2.Text = ""


        numA = Val(txtA.Text)
        numB = Val(txtB.Text)
        numC = Val(txtC.Text)

        delta = numB ^ 2 - 4 * numA * numC

        If delta > 0 Then

            p1 = (-(numB) + (delta) ^ (1 / 2)) / (2 * numA)
            p2 = (-(numB) - (delta) ^ (1 / 2)) / (2 * numA)
            lblRaiz1.Visible = True
            lblResultado1.Text = p1
            lblRaiz2.Visible = True
            lblResultado2.Text = p2

        ElseIf delta < 0 Then
            lblRaiz1.Visible = False
            lblResultado2.Text = "Sin Raices Reales"

        Else

            p1 = (-(numB) / (2 * numA))
            lblRaiz1.Visible = True
            lblRaiz2.Visible = False
            lblResultado1.Text = p1
            lblResultado2.Text = "Raiz doble"

        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Text = "a"
        txtB.Text = "b"
        txtC.Text = "c"
        lblResultado1.Text = ""
        lblResultado2.Text = ""
        lblRaiz1.Visible = False
        lblRaiz2.Visible = False
    End Sub

End Class
