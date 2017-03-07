Public Class Form1
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 + Operand2

        lblOperator.Text = "+"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnOduzimanje_Click(sender As Object, e As EventArgs) Handles btnOduzimanje.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 - Operand2

        lblOperator.Text = "-"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnMnozenje_Click(sender As Object, e As EventArgs) Handles btnMnozenje.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 * Operand2

        lblOperator.Text = "*"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnDjeljenje_Click(sender As Object, e As EventArgs) Handles btnDjeljenje.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 / Operand2

        lblOperator.Text = "/"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnCDjeljenje_Click(sender As Object, e As EventArgs) Handles btnCDjeljenje.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 \ Operand2

        lblOperator.Text = "\"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnPotencija_Click(sender As Object, e As EventArgs) Handles btnPotencija.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 ^ Operand2

        lblOperator.Text = "^"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 Mod Operand2

        lblOperator.Text = "Mod"
        lblDisplay.Text = Result.ToString("N")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOperand1.Clear()
        txtOperand2.Clear()
        lblOperator.Text = ""
        lblDisplay.Text = ""

        txtOperand1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
