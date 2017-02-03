Option Explicit On
Imports System.Drawing
Imports System.Text
Public Class Form1
    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double

#Region "button calculator"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'cmd1
    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd1_MouseHover(sender As Object, e As EventArgs) Handles cmd1.MouseHover
        cmd1.Size = New System.Drawing.Point(32, 27)
        cmd1.BackColor = Color.Beige
        cmd1.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd1_MouseLeave(sender As Object, e As EventArgs) Handles cmd1.MouseLeave
        cmd1.Size = New System.Drawing.Point(30, 26)
        cmd1.BackColor = Color.DarkOrange
        cmd1.ForeColor = Color.Black
    End Sub

    'cmd0
    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd0_MouseHover(sender As Object, e As EventArgs) Handles cmd0.MouseHover
        cmd0.Size = New System.Drawing.Point(32, 27)
        cmd0.BackColor = Color.Beige
        cmd0.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd0_MouseLeave(sender As Object, e As EventArgs) Handles cmd0.MouseLeave
        cmd0.Size = New System.Drawing.Point(30, 26)
        cmd0.BackColor = Color.DarkOrange
        cmd0.ForeColor = Color.Black
    End Sub

    'cmdDemical
    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        If InStr(txtInput.Text, ".") > 0 Then
            Exit Sub
        Else
            txtInput.Text = txtInput.Text & "."
        End If
    End Sub
    Private Sub cmdDecimal_MouseHover(sender As Object, e As EventArgs) Handles cmdDecimal.MouseHover
        cmdDecimal.Size = New System.Drawing.Point(48, 25)
        cmdDecimal.ForeColor = Color.DarkBlue
        cmdDecimal.BackColor = Color.Beige

    End Sub
    Private Sub cmdDecimal_MouseLeave(sender As Object, e As EventArgs) Handles cmdDecimal.MouseLeave
        cmdDecimal.Size = New System.Drawing.Point(46, 23)
        cmdDecimal.ForeColor = Color.Black
        cmdDecimal.BackColor = Color.DarkOrange
    End Sub

    'cmdAdd
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "+"

    End Sub
    Private Sub cmdAdd_MouseHover(sender As Object, e As EventArgs) Handles cmdAdd.MouseHover
        cmdAdd.Size = New System.Drawing.Point(42, 25)
        cmdAdd.BackColor = Color.Beige
        cmdAdd.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmdAdd_MouseLeave(sender As Object, e As EventArgs) Handles cmdAdd.MouseLeave
        cmdAdd.Size = New System.Drawing.Point(40, 23)
        cmdAdd.BackColor = Color.DarkOrange
        cmdAdd.ForeColor = Color.Black
    End Sub

    'cmdSqrtRoot
    Private Sub cmdSqrtRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrtRoot.Click
        If txtInput.Text.Length <> 0 Then

            tmpValue = CType(txtInput.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            txtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If

    End Sub
    Private Sub cmdSqrtRoot_MouseHover1(sender As Object, e As EventArgs) Handles cmdSqrtRoot.MouseHover
        cmdSqrtRoot.Size = New System.Drawing.Point(48, 25)
        cmdSqrtRoot.ForeColor = Color.DarkBlue
        cmdSqrtRoot.BackColor = Color.Beige

    End Sub
    Private Sub cmdSqrtRoot_MouseLeave1(sender As Object, e As EventArgs) Handles cmdSqrtRoot.MouseLeave
        cmdSqrtRoot.Size = New System.Drawing.Point(46, 25)
        cmdSqrtRoot.ForeColor = Color.Black
        cmdSqrtRoot.BackColor = Color.DarkOrange

    End Sub


    'button23
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim Result As Double
        Operand2 = Val(txtInput.Text)

        'If [Operator] = "+" Then
        '    Result = Operand1 + Operand2
        'ElseIf [Operator] = "-" Then
        '    Result = Operand1 - Operand2
        'ElseIf [Operator] = "/" Then
        '    Result = Operand1 / Operand2
        'ElseIf [Operator] = "*" Then
        '    Result = Operand1 * Operand2
        'End If

        Select Case [Operator]
            Case "+"
                Result = Operand1 + Operand2
                txtInput.Text = Result.ToString()
            Case "-"
                Result = Operand1 - Operand2
                txtInput.Text = Result.ToString()
            Case "/"
                Result = Operand1 / Operand2
                txtInput.Text = Result.ToString()
            Case "*"
                Result = Operand1 * Operand2
                txtInput.Text = Result.ToString()
            Case "^"
                Result = Operand1 ^ Operand2
                txtInput.Text = Result.ToString()
            Case "%"
                Result = Operand1 * 1 / 100
                txtInput.Text = Result.ToString()


        End Select

        txtInput.Text = Result.ToString()

    End Sub
    Private Sub Button23_MouseHover(sender As Object, e As EventArgs) Handles Button23.MouseHover
        Button23.Size = New System.Drawing.Point(48, 25)
        Button23.ForeColor = Color.DarkBlue
        Button23.BackColor = Color.Beige

    End Sub
    Private Sub Button23_MouseLeave(sender As Object, e As EventArgs) Handles Button23.MouseLeave
        Button23.Size = New System.Drawing.Point(46, 23)
        Button23.ForeColor = Color.Black
        Button23.BackColor = Color.DarkOrange
    End Sub

    'button1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'اعلان عن متغير لوكل 
        Dim str As String
        Dim loc As Integer
        If txtInput.Text.Length > 0 Then
            str = txtInput.Text.Chars(txtInput.Text.Length - 1)
            If str = "." Then
            End If
            loc = txtInput.Text.Length
            txtInput.Text = txtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub
    Private Sub button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Size = New System.Drawing.Point(78, 27)
        Button1.BackColor = Color.Beige
        Button1.ForeColor = Color.DarkBlue
    End Sub
    Private Sub button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Size = New System.Drawing.Point(76, 25)
        Button1.BackColor = Color.DarkOrange
        Button1.ForeColor = Color.Black
    End Sub

    'cmdOff
    Private Sub cmdOFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOff.Click

        txtInput.Text = ""

    End Sub
    Private Sub CmdOff_MouseHover(sender As Object, e As EventArgs) Handles CmdOff.MouseHover
        CmdOff.Size = New System.Drawing.Point(48, 25)
        CmdOff.ForeColor = Color.DarkBlue
        CmdOff.BackColor = Color.Beige
    End Sub
    Private Sub CmdOff_MouseLeave(sender As Object, e As EventArgs) Handles CmdOff.MouseLeave
        CmdOff.Size = New System.Drawing.Point(46, 23)
        CmdOff.ForeColor = Color.Black
        CmdOff.BackColor = Color.DarkOrange
    End Sub

    'cmd ClearAll
    Private Sub CmdClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClearAll.Click
        txtInput.Text = ""

    End Sub
    Private Sub CmdClearAll_MouseHover(sender As Object, e As EventArgs) Handles CmdClearAll.MouseHover
        CmdClearAll.Size = New System.Drawing.Point(42, 25)
        CmdClearAll.ForeColor = Color.DarkBlue
        CmdClearAll.BackColor = Color.Beige
    End Sub
    Private Sub CmdClearAll_MouseLeave(sender As Object, e As EventArgs) Handles CmdClearAll.MouseLeave
        CmdClearAll.Size = New System.Drawing.Point(40, 23)
        CmdClearAll.ForeColor = Color.Black
        CmdClearAll.BackColor = Color.DarkOrange
    End Sub

    'cmd7
    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd7_MouseHover(sender As Object, e As EventArgs) Handles cmd7.MouseHover
        cmd7.Size = New System.Drawing.Point(32, 27)
        cmd7.BackColor = Color.Beige
        cmd7.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd7_MouseLeave(sender As Object, e As EventArgs) Handles cmd7.MouseLeave
        cmd7.Size = New System.Drawing.Point(30, 26)
        cmd7.BackColor = Color.DarkOrange
        cmd7.ForeColor = Color.Black
    End Sub

    'cmd8
    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd8_MouseHover(sender As Object, e As EventArgs) Handles cmd8.MouseHover
        cmd8.Size = New System.Drawing.Point(32, 27)
        cmd8.BackColor = Color.Beige
        cmd8.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd8_MouseLeave(sender As Object, e As EventArgs) Handles cmd8.MouseLeave
        cmd8.Size = New System.Drawing.Point(30, 26)
        cmd8.BackColor = Color.DarkOrange
        cmd8.ForeColor = Color.Black
    End Sub

    'cmd9
    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd9_MouseHover(sender As Object, e As EventArgs) Handles cmd9.MouseHover
        cmd9.Size = New System.Drawing.Point(32, 27)
        cmd9.BackColor = Color.Beige
        cmd9.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd9_MouseLeave(sender As Object, e As EventArgs) Handles cmd9.MouseLeave
        cmd9.Size = New System.Drawing.Point(30, 26)
        cmd9.BackColor = Color.DarkOrange
        cmd9.ForeColor = Color.Black
    End Sub

    'cmd4
    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd4_MouseHover(sender As Object, e As EventArgs) Handles cmd4.MouseHover
        cmd4.Size = New System.Drawing.Point(32, 27)
        cmd4.BackColor = Color.Beige
        cmd4.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd4_MouseLeave(sender As Object, e As EventArgs) Handles cmd4.MouseLeave
        cmd4.Size = New System.Drawing.Point(30, 26)
        cmd4.BackColor = Color.DarkOrange
        cmd4.ForeColor = Color.Black
    End Sub

    'cmd5
    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub
    Private Sub cmd5_MouseHover(sender As Object, e As EventArgs) Handles cmd5.MouseHover
        cmd5.Size = New System.Drawing.Point(32, 27)
        cmd5.BackColor = Color.Beige
        cmd5.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd5_MouseLeave(sender As Object, e As EventArgs) Handles cmd5.MouseLeave
        cmd5.Size = New System.Drawing.Point(30, 26)
        cmd5.BackColor = Color.DarkOrange
        cmd5.ForeColor = Color.Black
    End Sub

    'cmd6
    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub
    Private Sub cmd6_MouseHover(sender As Object, e As EventArgs) Handles cmd6.MouseHover
        cmd6.Size = New System.Drawing.Point(32, 27)
        cmd6.BackColor = Color.Beige
        cmd6.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd6_MouseLeave(sender As Object, e As EventArgs) Handles cmd6.MouseLeave
        cmd6.Size = New System.Drawing.Point(30, 26)
        cmd6.BackColor = Color.DarkOrange
        cmd6.ForeColor = Color.Black
    End Sub

    'cmd2
    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub
    Private Sub cmd2_MouseHover(sender As Object, e As EventArgs) Handles cmd2.MouseHover
        cmd2.Size = New System.Drawing.Point(32, 27)
        cmd2.BackColor = Color.Beige
        cmd2.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd2_MouseLeave(sender As Object, e As EventArgs) Handles cmd2.MouseLeave
        cmd2.Size = New System.Drawing.Point(30, 26)
        cmd2.BackColor = Color.DarkOrange
        cmd2.ForeColor = Color.Black
    End Sub

    'cmd3
    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub
    Private Sub cmd3_MouseHover(sender As Object, e As EventArgs) Handles cmd3.MouseHover
        cmd3.Size = New System.Drawing.Point(32, 27)
        cmd3.BackColor = Color.Beige
        cmd3.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmd3_MouseLeave(sender As Object, e As EventArgs) Handles cmd3.MouseLeave
        cmd3.Size = New System.Drawing.Point(30, 26)
        cmd3.BackColor = Color.DarkOrange
        cmd3.ForeColor = Color.Black
    End Sub

    'cmdDivide
    Private Sub cmdDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivide.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "/"

    End Sub
    Private Sub cmdDivide_MouseHover(sender As Object, e As EventArgs) Handles cmdDivide.MouseHover
        cmdDivide.Size = New System.Drawing.Point(42, 25)
        cmdDivide.ForeColor = Color.DarkBlue
        cmdDivide.BackColor = Color.Beige
    End Sub
    Private Sub cmdDivide_MouseLeave(sender As Object, e As EventArgs) Handles cmdDivide.MouseLeave
        cmdDivide.Size = New System.Drawing.Point(40, 23)
        cmdDivide.ForeColor = Color.Black
        cmdDivide.BackColor = Color.DarkOrange
    End Sub

    'cmdMUltiply
    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "*"
    End Sub
    Private Sub cmdMultiply_MouseHover(sender As Object, e As EventArgs) Handles cmdMultiply.MouseHover
        cmdMultiply.Size = New System.Drawing.Point(42, 25)
        cmdMultiply.ForeColor = Color.DarkBlue
        cmdMultiply.BackColor = Color.Beige
    End Sub
    Private Sub cmdMultiply_MouseLeave(sender As Object, e As EventArgs) Handles cmdMultiply.MouseLeave
        cmdMultiply.Size = New System.Drawing.Point(40, 23)
        cmdMultiply.ForeColor = Color.Black
        cmdMultiply.BackColor = Color.DarkOrange
    End Sub

    'cmdSubstraction
    Private Sub CmdSubstraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdsubstraction.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "-"
    End Sub
    Private Sub Cmdsubstraction_MouseLeave(sender As Object, e As EventArgs) Handles Cmdsubstraction.MouseLeave
        Cmdsubstraction.Size = New System.Drawing.Point(42, 25)
        Cmdsubstraction.ForeColor = Color.Black
        Cmdsubstraction.BackColor = Color.DarkOrange
    End Sub
    Private Sub Cmdsubstraction_MouseMove(sender As Object, e As MouseEventArgs) Handles Cmdsubstraction.MouseMove
        Cmdsubstraction.Size = New System.Drawing.Point(42, 25)
        Cmdsubstraction.ForeColor = Color.DarkBlue
        Cmdsubstraction.BackColor = Color.Beige
    End Sub


    'cmdPowerOf
    Private Sub CmdPowerOF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPowerOF.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "^"
    End Sub
    Private Sub CmdPowerOF_MouseHover(sender As Object, e As EventArgs) Handles CmdPowerOF.MouseHover
        CmdPowerOF.Size = New System.Drawing.Point(48, 25)
        CmdPowerOF.ForeColor = Color.DarkBlue
        CmdPowerOF.BackColor = Color.Beige
    End Sub
    Private Sub CmdPowerOF_MouseLeave(sender As Object, e As EventArgs) Handles CmdPowerOF.MouseLeave
        CmdPowerOF.Size = New System.Drawing.Point(46, 23)
        CmdPowerOF.ForeColor = Color.Black
        CmdPowerOF.BackColor = Color.DarkOrange

    End Sub

    'cmdInverse
    Private Sub CmdInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInverse.Click
        Dim convert As Single
        If txtInput.Text <> 0 Then
            convert = 1 / Val(txtInput.Text)
            txtInput.Text = convert

        End If
    End Sub
    Private Sub CmdInverse_MouseHover(sender As Object, e As EventArgs) Handles CmdInverse.MouseHover
        CmdInverse.Size = New System.Drawing.Point(34, 25)
        CmdInverse.BackColor = Color.Beige
        CmdInverse.ForeColor = Color.DarkBlue

    End Sub
    Private Sub CmdInverse_MouseLeave(sender As Object, e As EventArgs) Handles CmdInverse.MouseLeave
        CmdInverse.Size = New System.Drawing.Point(32, 23)
        CmdInverse.BackColor = Color.DarkOrange
        CmdInverse.ForeColor = Color.Black
    End Sub
    'cmdsign
    Private Sub Cmdsign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSign.Click
        txtInput.Text = -1 * txtInput.Text
    End Sub
    Private Sub cmdSign_MouseHover(sender As Object, e As EventArgs) Handles cmdSign.MouseHover
        cmdSign.Size = New System.Drawing.Point(34, 25)
        cmdSign.BackColor = Color.Beige
        cmdSign.ForeColor = Color.DarkBlue
    End Sub
    Private Sub cmdSign_MouseLeave(sender As Object, e As EventArgs) Handles cmdSign.MouseLeave
        cmdSign.Size = New System.Drawing.Point(32, 23)
        cmdSign.BackColor = Color.DarkOrange
        cmdSign.ForeColor = Color.Black
    End Sub
    'button 2 close programe
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Size = New System.Drawing.Point(48, 25)
        Button2.BackColor = Color.Beige
        Button2.ForeColor = Color.DarkBlue
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Size = New System.Drawing.Point(45, 23)
        Button2.BackColor = Color.DarkOrange
        Button2.ForeColor = Color.Black
    End Sub
#End Region








End Class
