Imports System.IO
Public Class SudukoSolver

    Dim Quad1(2, 2) As Integer
    Dim Quad2(2, 2) As Integer
    Dim Quad3(2, 2) As Integer
    Dim Quad4(2, 2) As Integer
    Dim Quad5(2, 2) As Integer
    Dim Quad6(2, 2) As Integer
    Dim Quad7(2, 2) As Integer
    Dim Quad8(2, 2) As Integer
    Dim Quad9(2, 2) As Integer
    Dim Startarray(80) As Integer
    Dim AnswersFound As Integer
    Dim SudokuFile As StreamWriter
    Dim SDKTxt As String

    Private Sub SudukoSolver_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refreshData()
        printData()
        Randomize()
        'SudokuFile = New StreamWriter("C:\Sudoku.txt")
        Dim i As Integer
        For i = 0 To 80
            Startarray(i) = 0
        Next
        Timer1.Enabled = True
        Timer1.Interval = 60000

        For Each c As Control In Panel1.Controls
            If TypeOf (c) Is TextBox Then
                AddHandler c.LostFocus, AddressOf TextBox1_LostFocus
            End If
        Next


    End Sub




    Sub fillStartArray()
        Startarray(0) = TextBox1.Text
        Startarray(1) = TextBox2.Text
        Startarray(2) = TextBox3.Text
        Startarray(3) = TextBox4.Text
        Startarray(4) = TextBox5.Text
        Startarray(5) = TextBox6.Text
        Startarray(6) = TextBox7.Text
        Startarray(7) = TextBox8.Text
        Startarray(8) = TextBox9.Text

        Startarray(9) = TextBox10.Text
        Startarray(10) = TextBox11.Text
        Startarray(11) = TextBox12.Text
        Startarray(12) = TextBox13.Text
        Startarray(13) = TextBox14.Text
        Startarray(14) = TextBox15.Text
        Startarray(15) = TextBox16.Text
        Startarray(16) = TextBox17.Text
        Startarray(17) = TextBox18.Text


        Startarray(18) = TextBox19.Text
        Startarray(19) = TextBox20.Text
        Startarray(20) = TextBox21.Text
        Startarray(21) = TextBox22.Text
        Startarray(22) = TextBox23.Text
        Startarray(23) = TextBox24.Text
        Startarray(24) = TextBox25.Text
        Startarray(25) = TextBox26.Text
        Startarray(26) = TextBox27.Text

        Startarray(27) = TextBox28.Text
        Startarray(28) = TextBox29.Text
        Startarray(29) = TextBox30.Text
        Startarray(30) = TextBox31.Text
        Startarray(31) = TextBox32.Text
        Startarray(32) = TextBox33.Text
        Startarray(33) = TextBox34.Text
        Startarray(34) = TextBox35.Text
        Startarray(35) = TextBox36.Text

        Startarray(36) = TextBox37.Text
        Startarray(37) = TextBox38.Text
        Startarray(38) = TextBox39.Text
        Startarray(39) = TextBox40.Text
        Startarray(40) = TextBox41.Text
        Startarray(41) = TextBox42.Text
        Startarray(42) = TextBox43.Text
        Startarray(43) = TextBox44.Text
        Startarray(44) = TextBox45.Text


        Startarray(45) = TextBox46.Text
        Startarray(46) = TextBox47.Text
        Startarray(47) = TextBox48.Text
        Startarray(48) = TextBox49.Text
        Startarray(49) = TextBox50.Text
        Startarray(50) = TextBox51.Text
        Startarray(51) = TextBox52.Text
        Startarray(52) = TextBox53.Text
        Startarray(53) = TextBox54.Text


        Startarray(54) = TextBox55.Text
        Startarray(55) = TextBox56.Text
        Startarray(56) = TextBox57.Text
        Startarray(57) = TextBox58.Text
        Startarray(58) = TextBox59.Text
        Startarray(59) = TextBox60.Text
        Startarray(60) = TextBox61.Text
        Startarray(61) = TextBox62.Text
        Startarray(62) = TextBox63.Text

        Startarray(63) = TextBox64.Text
        Startarray(64) = TextBox65.Text
        Startarray(65) = TextBox66.Text
        Startarray(66) = TextBox67.Text
        Startarray(67) = TextBox68.Text
        Startarray(68) = TextBox69.Text
        Startarray(69) = TextBox70.Text
        Startarray(70) = TextBox71.Text
        Startarray(71) = TextBox72.Text


        Startarray(72) = TextBox73.Text
        Startarray(73) = TextBox74.Text
        Startarray(74) = TextBox75.Text
        Startarray(75) = TextBox76.Text
        Startarray(76) = TextBox77.Text
        Startarray(77) = TextBox78.Text
        Startarray(78) = TextBox79.Text
        Startarray(79) = TextBox80.Text
        Startarray(80) = TextBox81.Text

    End Sub
    Sub fillQuad()
        Quad1(0, 0) = Startarray(0)
        Quad1(0, 1) = Startarray(1)
        Quad1(0, 2) = Startarray(2)
        Quad2(0, 0) = Startarray(3)
        Quad2(0, 1) = Startarray(4)
        Quad2(0, 2) = Startarray(5)
        Quad3(0, 0) = Startarray(6)
        Quad3(0, 1) = Startarray(7)
        Quad3(0, 2) = Startarray(8)

        Quad1(1, 0) = Startarray(9)
        Quad1(1, 1) = Startarray(10)
        Quad1(1, 2) = Startarray(11)
        Quad2(1, 0) = Startarray(12)
        Quad2(1, 1) = Startarray(13)
        Quad2(1, 2) = Startarray(14)
        Quad3(1, 0) = Startarray(15)
        Quad3(1, 1) = Startarray(16)
        Quad3(1, 2) = Startarray(17)


        Quad1(2, 0) = Startarray(18)
        Quad1(2, 1) = Startarray(19)
        Quad1(2, 2) = Startarray(20)
        Quad2(2, 0) = Startarray(21)
        Quad2(2, 1) = Startarray(22)
        Quad2(2, 2) = Startarray(23)
        Quad3(2, 0) = Startarray(24)
        Quad3(2, 1) = Startarray(25)
        Quad3(2, 2) = Startarray(26)


        Quad4(0, 0) = Startarray(27)
        Quad4(0, 1) = Startarray(28)
        Quad4(0, 2) = Startarray(29)
        Quad5(0, 0) = Startarray(30)
        Quad5(0, 1) = Startarray(31)
        Quad5(0, 2) = Startarray(32)
        Quad6(0, 0) = Startarray(33)
        Quad6(0, 1) = Startarray(34)
        Quad6(0, 2) = Startarray(35)

        Quad4(1, 0) = Startarray(36)
        Quad4(1, 1) = Startarray(37)
        Quad4(1, 2) = Startarray(38)
        Quad5(1, 0) = Startarray(39)
        Quad5(1, 1) = Startarray(40)
        Quad5(1, 2) = Startarray(41)
        Quad6(1, 0) = Startarray(42)
        Quad6(1, 1) = Startarray(43)
        Quad6(1, 2) = Startarray(44)


        Quad4(2, 0) = Startarray(45)
        Quad4(2, 1) = Startarray(46)
        Quad4(2, 2) = Startarray(47)
        Quad5(2, 0) = Startarray(48)
        Quad5(2, 1) = Startarray(49)
        Quad5(2, 2) = Startarray(50)
        Quad6(2, 0) = Startarray(51)
        Quad6(2, 1) = Startarray(52)
        Quad6(2, 2) = Startarray(53)


        Quad7(0, 0) = Startarray(54)
        Quad7(0, 1) = Startarray(55)
        Quad7(0, 2) = Startarray(56)
        Quad8(0, 0) = Startarray(57)
        Quad8(0, 1) = Startarray(58)
        Quad8(0, 2) = Startarray(59)
        Quad9(0, 0) = Startarray(60)
        Quad9(0, 1) = Startarray(61)
        Quad9(0, 2) = Startarray(62)

        Quad7(1, 0) = Startarray(63)
        Quad7(1, 1) = Startarray(64)
        Quad7(1, 2) = Startarray(65)
        Quad8(1, 0) = Startarray(66)
        Quad8(1, 1) = Startarray(67)
        Quad8(1, 2) = Startarray(68)
        Quad9(1, 0) = Startarray(69)
        Quad9(1, 1) = Startarray(70)
        Quad9(1, 2) = Startarray(71)


        Quad7(2, 0) = Startarray(72)
        Quad7(2, 1) = Startarray(73)
        Quad7(2, 2) = Startarray(74)
        Quad8(2, 0) = Startarray(75)
        Quad8(2, 1) = Startarray(76)
        Quad8(2, 2) = Startarray(77)
        Quad9(2, 0) = Startarray(78)
        Quad9(2, 1) = Startarray(79)
        Quad9(2, 2) = Startarray(80)

    End Sub

    Sub refreshData()
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 2
                Quad1(i, j) = 0
                Quad2(i, j) = 0
                Quad3(i, j) = 0
                Quad4(i, j) = 0
                Quad5(i, j) = 0
                Quad6(i, j) = 0
                Quad7(i, j) = 0
                Quad8(i, j) = 0
                Quad9(i, j) = 0
            Next
        Next
        'For i = 0 To 80
        '    Startarray(i) = 0
        'Next
    End Sub

    Sub printData()
        TextBox1.Text = Quad1(0, 0)
        TextBox2.Text = Quad1(0, 1)
        TextBox3.Text = Quad1(0, 2)
        TextBox4.Text = Quad2(0, 0)
        TextBox5.Text = Quad2(0, 1)
        TextBox6.Text = Quad2(0, 2)
        TextBox7.Text = Quad3(0, 0)
        TextBox8.Text = Quad3(0, 1)
        TextBox9.Text = Quad3(0, 2)
        TextBox10.Text = Quad1(1, 0)
        TextBox11.Text = Quad1(1, 1)
        TextBox12.Text = Quad1(1, 2)
        TextBox13.Text = Quad2(1, 0)
        TextBox14.Text = Quad2(1, 1)
        TextBox15.Text = Quad2(1, 2)
        TextBox16.Text = Quad3(1, 0)
        TextBox17.Text = Quad3(1, 1)
        TextBox18.Text = Quad3(1, 2)
        TextBox19.Text = Quad1(2, 0)
        TextBox20.Text = Quad1(2, 1)
        TextBox21.Text = Quad1(2, 2)
        TextBox22.Text = Quad2(2, 0)
        TextBox23.Text = Quad2(2, 1)
        TextBox24.Text = Quad2(2, 2)
        TextBox25.Text = Quad3(2, 0)
        TextBox26.Text = Quad3(2, 1)
        TextBox27.Text = Quad3(2, 2)


        TextBox28.Text = Quad4(0, 0)
        TextBox29.Text = Quad4(0, 1)
        TextBox30.Text = Quad4(0, 2)
        TextBox31.Text = Quad5(0, 0)
        TextBox32.Text = Quad5(0, 1)
        TextBox33.Text = Quad5(0, 2)
        TextBox34.Text = Quad6(0, 0)
        TextBox35.Text = Quad6(0, 1)
        TextBox36.Text = Quad6(0, 2)
        TextBox37.Text = Quad4(1, 0)
        TextBox38.Text = Quad4(1, 1)
        TextBox39.Text = Quad4(1, 2)
        TextBox40.Text = Quad5(1, 0)
        TextBox41.Text = Quad5(1, 1)
        TextBox42.Text = Quad5(1, 2)
        TextBox43.Text = Quad6(1, 0)
        TextBox44.Text = Quad6(1, 1)
        TextBox45.Text = Quad6(1, 2)
        TextBox46.Text = Quad4(2, 0)
        TextBox47.Text = Quad4(2, 1)
        TextBox48.Text = Quad4(2, 2)
        TextBox49.Text = Quad5(2, 0)
        TextBox50.Text = Quad5(2, 1)
        TextBox51.Text = Quad5(2, 2)
        TextBox52.Text = Quad6(2, 0)
        TextBox53.Text = Quad6(2, 1)
        TextBox54.Text = Quad6(2, 2)


        TextBox55.Text = Quad7(0, 0)
        TextBox56.Text = Quad7(0, 1)
        TextBox57.Text = Quad7(0, 2)
        TextBox58.Text = Quad8(0, 0)
        TextBox59.Text = Quad8(0, 1)
        TextBox60.Text = Quad8(0, 2)
        TextBox61.Text = Quad9(0, 0)
        TextBox62.Text = Quad9(0, 1)
        TextBox63.Text = Quad9(0, 2)
        TextBox64.Text = Quad7(1, 0)
        TextBox65.Text = Quad7(1, 1)
        TextBox66.Text = Quad7(1, 2)
        TextBox67.Text = Quad8(1, 0)
        TextBox68.Text = Quad8(1, 1)
        TextBox69.Text = Quad8(1, 2)
        TextBox70.Text = Quad9(1, 0)
        TextBox71.Text = Quad9(1, 1)
        TextBox72.Text = Quad9(1, 2)
        TextBox73.Text = Quad7(2, 0)
        TextBox74.Text = Quad7(2, 1)
        TextBox75.Text = Quad7(2, 2)
        TextBox76.Text = Quad8(2, 0)
        TextBox77.Text = Quad8(2, 1)
        TextBox78.Text = Quad8(2, 2)
        TextBox79.Text = Quad9(2, 0)
        TextBox80.Text = Quad9(2, 1)
        TextBox81.Text = Quad9(2, 2)

        SDKTxt = vbCrLf + vbCrLf + TextBox1.Text + "," + TextBox2.Text + "," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text + "," + TextBox6.Text + "," + TextBox7.Text + "," + TextBox8.Text + "," + TextBox9.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox10.Text + "," + TextBox11.Text + "," + TextBox12.Text + "," + TextBox13.Text + "," + TextBox14.Text + "," + TextBox15.Text + "," + TextBox16.Text + "," + TextBox17.Text + "," + TextBox18.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox19.Text + "," + TextBox20.Text + "," + TextBox21.Text + "," + TextBox22.Text + "," + TextBox23.Text + "," + TextBox24.Text + "," + TextBox25.Text + "," + TextBox26.Text + "," + TextBox27.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox28.Text + "," + TextBox29.Text + "," + TextBox30.Text + "," + TextBox31.Text + "," + TextBox32.Text + "," + TextBox33.Text + "," + TextBox34.Text + "," + TextBox35.Text + "," + TextBox36.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox37.Text + "," + TextBox38.Text + "," + TextBox39.Text + "," + TextBox40.Text + "," + TextBox41.Text + "," + TextBox42.Text + "," + TextBox43.Text + "," + TextBox44.Text + "," + TextBox45.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox46.Text + "," + TextBox47.Text + "," + TextBox48.Text + "," + TextBox49.Text + "," + TextBox50.Text + "," + TextBox51.Text + "," + TextBox52.Text + "," + TextBox53.Text + "," + TextBox54.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox55.Text + "," + TextBox56.Text + "," + TextBox57.Text + "," + TextBox58.Text + "," + TextBox59.Text + "," + TextBox60.Text + "," + TextBox61.Text + "," + TextBox62.Text + "," + TextBox63.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox64.Text + "," + TextBox65.Text + "," + TextBox66.Text + "," + TextBox67.Text + "," + TextBox68.Text + "," + TextBox69.Text + "," + TextBox70.Text + "," + TextBox71.Text + "," + TextBox72.Text + vbCrLf
        SDKTxt = SDKTxt + TextBox73.Text + "," + TextBox74.Text + "," + TextBox75.Text + "," + TextBox76.Text + "," + TextBox77.Text + "," + TextBox78.Text + "," + TextBox79.Text + "," + TextBox80.Text + "," + TextBox81.Text + vbCrLf
        Console.WriteLine(SDKTxt)





    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim val As Integer
        Dim ret As Boolean
        Dim Starttime As DateTime = Now
        Dim ts As TimeSpan

        ' Format and display the TimeSpan value.

        'SudokuFile = New StreamWriter("C:\Sudoku.csv")

        'For i As Integer = 1 To 10
        'refreshData()
        fillStartArray()
        fillQuad()
        ret = createGrid()
        val = 0
        For Each c As Control In Panel1.Controls
            If TypeOf (c) Is TextBox Then
                If (c.Text = "0") Then
                    c.ForeColor = Color.Red
                End If
            End If
        Next
        While (ret = False)
            printData()

            Application.DoEvents()

            fillQuad()
            ret = createGrid()
            'val = val + 1
            'Label1.Text = val.ToString()
            ts = Now - Starttime
            Label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        End While
        printData()
        'SudokuFile.Write(SDKTxt)
        'Next
        'SudokuFile.Close()


    End Sub
    Function stillValid(ByVal Quad(,) As Integer, ByVal QuadII(,) As Integer, ByVal QuadIII(,) As Integer, ByVal QuadIV(,) As Integer, ByVal QuadV(,) As Integer, ByVal i As Integer, ByVal j As Integer) As Boolean
        Dim val As Integer
        Dim solveable As Boolean
        Dim k, l As Integer
        For val = 1 To 9
            solveable = True
            For k = 0 To 2
                If (QuadII(i, k) = val) Then
                    solveable = False
                End If
                If (QuadIII(i, k) = val) Then
                    solveable = False
                End If

            Next

            For l = 0 To 2
                If (QuadIV(l, j) = val) Then
                    solveable = False
                End If
                If (QuadV(l, j) = val) Then
                    solveable = False
                End If

            Next

            For k = 0 To 2
                For l = 0 To 2
                    If Quad(k, l) = val Then
                        solveable = False
                    End If
                Next
            Next
            If solveable = True Then
                Return True
            End If


        Next

        Return False
    End Function

    Function isvalid(ByVal Quad(,) As Integer, ByVal QuadII(,) As Integer, ByVal QuadIII(,) As Integer, ByVal QuadIV(,) As Integer, ByVal QuadV(,) As Integer, ByVal i As Integer, ByVal j As Integer, ByVal val As Integer) As Boolean
        Dim k, l As Integer
        For k = 0 To 2
            If (QuadII(i, k) = val) Then
                Return False
            End If
            If (QuadIII(i, k) = val) Then
                Return False
            End If

        Next

        For l = 0 To 2
            If (QuadIV(l, j) = val) Then
                Return False
            End If
            If (QuadV(l, j) = val) Then
                Return False
            End If

        Next

        For k = 0 To 2
            For l = 0 To 2
                If Quad(k, l) = val Then
                    Return False
                End If
            Next
        Next

        Return True

    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'printData()
        'Application.DoEvents()

    End Sub
    Function createGrid() As Boolean
        Dim i, j As Integer
        Dim val As Integer
        Dim ret As Boolean
        For i = 0 To 2
            For j = 0 To 2
                If (Quad1(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, i, j, val)
                        If stillValid(Quad1, Quad2, Quad3, Quad4, Quad7, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad1(i, j) = val
                End If

                If (Quad2(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, i, j, val)
                        If stillValid(Quad2, Quad1, Quad3, Quad5, Quad8, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad2(i, j) = val
                End If

                If (Quad3(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, i, j, val)
                        If stillValid(Quad3, Quad2, Quad1, Quad6, Quad9, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad3(i, j) = val
                End If

                If (Quad4(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, i, j, val)
                        If stillValid(Quad4, Quad5, Quad6, Quad1, Quad7, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad4(i, j) = val
                End If

                If (Quad5(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, i, j, val)
                        If stillValid(Quad5, Quad4, Quad6, Quad2, Quad8, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad5(i, j) = val
                End If

                If (Quad6(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, i, j, val)
                        If stillValid(Quad6, Quad4, Quad5, Quad3, Quad9, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad6(i, j) = val
                End If

                If (Quad7(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, i, j, val)
                        If stillValid(Quad7, Quad8, Quad9, Quad1, Quad4, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad7(i, j) = val
                End If

                If (Quad8(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, i, j, val)
                        If stillValid(Quad8, Quad7, Quad9, Quad2, Quad5, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad8(i, j) = val

                End If

                If (Quad9(i, j) = 0) Then
                    val = CInt(Int((9 * Rnd()) + 1))
                    ret = isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, i, j, val)
                    While (ret = False)
                        val = CInt(Int((9 * Rnd()) + 1))
                        ret = isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, i, j, val)
                        If stillValid(Quad9, Quad7, Quad8, Quad3, Quad6, i, j) = False Then
                            Return False
                        End If
                    End While
                    Quad9(i, j) = val
                End If



            Next

        Next
        Return True
    End Function



    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click
        refreshData()
        printData()
        For Each c As Control In Panel1.Controls
            If TypeOf (c) Is TextBox Then
                c.ForeColor = Color.Black
            End If
        Next
        Label1.Text = ""
    End Sub


    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim but As TextBox = CType(sender, TextBox)
        Select Case but.Text
            Case "0"
            Case "1"
            Case "2"
            Case "3"
            Case "4"
            Case "5"
            Case "6"
            Case "7"
            Case "8"
            Case "9"
                Return
            Case Else

                'but.SelectAll()
                but.Focus()
                but.SelectionStart = 0
                but.SelectionLength = Len(but.Text)
        End Select

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        Dim i, j As Integer
        Dim Starttime As DateTime = Now
        Dim ts As TimeSpan
        fillStartArray()
        fillQuad()
        For Each c As Control In Panel1.Controls
            If TypeOf (c) Is TextBox Then
                If (c.Text = "0") Then
                    c.ForeColor = Color.Red
                End If
            End If
        Next
        AnswersFound = 1
        While (SOLVED() = False And AnswersFound > 0)
            AnswersFound = 0
            For i = 0 To 2
                For j = 0 To 2
                    If (Quad1(i, j) = 0) Then
                        Quad1(i, j) = GetNum(Quad1, Quad2, Quad3, Quad4, Quad7, i, j)
                    End If

                    If (Quad2(i, j) = 0) Then
                        Quad2(i, j) = GetNum(Quad2, Quad1, Quad3, Quad5, Quad8, i, j)
                    End If

                    If (Quad3(i, j) = 0) Then
                        Quad3(i, j) = GetNum(Quad3, Quad2, Quad1, Quad6, Quad9, i, j)
                    End If

                    If (Quad4(i, j) = 0) Then
                        Quad4(i, j) = GetNum(Quad4, Quad5, Quad6, Quad1, Quad7, i, j)
                    End If

                    If (Quad5(i, j) = 0) Then
                        Quad5(i, j) = GetNum(Quad5, Quad4, Quad6, Quad2, Quad8, i, j)
                    End If

                    If (Quad6(i, j) = 0) Then
                        Quad6(i, j) = GetNum(Quad6, Quad4, Quad5, Quad3, Quad9, i, j)

                    End If

                    If (Quad7(i, j) = 0) Then
                        Quad7(i, j) = GetNum(Quad7, Quad8, Quad9, Quad1, Quad4, i, j)
                    End If

                    If (Quad8(i, j) = 0) Then
                        Quad8(i, j) = GetNum(Quad8, Quad7, Quad9, Quad2, Quad5, i, j)
                    End If

                    If (Quad9(i, j) = 0) Then
                        Quad9(i, j) = GetNum(Quad9, Quad7, Quad8, Quad3, Quad6, i, j)
                    End If
                    printData()
                    Application.DoEvents()
                    ts = Now - Starttime
                    Label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)

                Next
            Next
            solvebyGrids()


            SolvebyLines()
            Application.DoEvents()
            ts = Now - Starttime
            Label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
        End While
        
        If SOLVED() = False Then
            Label1.Text = "About to Use Brute Force"
            Application.DoEvents()
            System.Threading.Thread.Sleep(10000)
            Dim ret As Boolean
            fillStartArray()
            fillQuad()
            ret = createGrid()
            While (ret = False)
                printData()

                Application.DoEvents()

                fillQuad()
                ret = createGrid()
                ts = Now - Starttime
                Label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
            End While
            printData()


        End If

        printData()
        ts = Now - Starttime
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _
        ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10)
    End Sub
    Function GetNum(ByVal Quad(,) As Integer, ByVal QuadII(,) As Integer, ByVal QuadIII(,) As Integer, ByVal QuadIV(,) As Integer, ByVal QuadV(,) As Integer, ByVal i As Integer, ByVal j As Integer) As Integer
        Dim ans As Integer = 0
        Dim count As Integer = 0
        Dim arr(9) As Integer
        For x As Integer = 1 To 9
            If (findOneAnswer(Quad, QuadII, QuadIII, QuadIV, QuadV, i, j, x)) Then
                arr(count) = x
                count = count + 1
                ans = x
            End If
        Next

        If (count = 1) Then
            AnswersFound = AnswersFound + 1
            Return ans
        Else
            Return 0
        End If

    End Function
    Function SOLVED() As Boolean
        Dim i, j As Integer
        For i = 0 To 2
            For j = 0 To 2
                If (Quad1(i, j) = 0) Then
                    Return False
                End If

                If (Quad2(i, j) = 0) Then
                    Return False
                End If

                If (Quad3(i, j) = 0) Then
                    Return False
                End If

                If (Quad4(i, j) = 0) Then
                    Return False
                End If

                If (Quad5(i, j) = 0) Then
                    Return False
                End If

                If (Quad6(i, j) = 0) Then
                    Return False

                End If

                If (Quad7(i, j) = 0) Then
                    Return False
                End If

                If (Quad8(i, j) = 0) Then
                    Return False
                End If

                If (Quad9(i, j) = 0) Then
                    Return False
                End If


            Next
        Next
        Return True

    End Function
    Function findOneAnswer(ByVal Quad(,) As Integer, ByVal QuadII(,) As Integer, ByVal QuadIII(,) As Integer, ByVal QuadIV(,) As Integer, ByVal QuadV(,) As Integer, ByVal i As Integer, ByVal j As Integer, ByVal val As Integer) As Integer
        Dim solveable As Boolean
        Dim k, l As Integer
        'dim ans as Integer = 

        solveable = True
        For k = 0 To 2
            If (QuadII(i, k) = val) Then
                solveable = False
            End If
            If (QuadIII(i, k) = val) Then
                solveable = False
            End If

        Next

        For l = 0 To 2
            If (QuadIV(l, j) = val) Then
                solveable = False
            End If
            If (QuadV(l, j) = val) Then
                solveable = False
            End If

        Next

        For k = 0 To 2
            For l = 0 To 2
                If Quad(k, l) = val Then
                    solveable = False
                End If
            Next
        Next
        If solveable = True Then
            Return True
        End If



        Return False
    End Function
    Function SolvebyLines() As Boolean
        Dim grid(8) As Integer
        grid(0) = Quad1(0, 0)
        grid(1) = Quad1(1, 0)
        grid(2) = Quad1(2, 0)
        grid(3) = Quad4(0, 0)
        grid(4) = Quad4(1, 0)
        grid(5) = Quad4(2, 0)
        grid(6) = Quad7(0, 0)
        grid(7) = Quad7(1, 0)
        grid(8) = Quad7(2, 0)
        Dim missing(8) As Integer
        Dim count As Integer = 0
        Dim possibles As Integer
        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(0, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(1, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(2, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(0, 0) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(1, 0) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(2, 0) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(0, 0) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(1, 0) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(2, 0) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(0, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, missing(i)) Then
                            Quad1(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad1(1, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, missing(i)) Then
                            Quad1(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad1(2, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, missing(i)) Then
                            Quad1(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad4(0, 0) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, missing(i)) Then
                            Quad4(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad4(1, 0) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, missing(i)) Then
                            Quad4(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad4(2, 0) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, missing(i)) Then
                            Quad4(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad7(0, 0) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, missing(i)) Then
                            Quad7(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad7(1, 0) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, missing(i)) Then
                            Quad7(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad7(2, 0) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, missing(i)) Then
                            Quad7(2, 0) = missing(i)
                        End If
                    End If
                End If
            Next

        End If

        'Line 2
        grid(0) = Quad1(0, 1)
        grid(1) = Quad1(1, 1)
        grid(2) = Quad1(2, 1)
        grid(3) = Quad4(0, 1)
        grid(4) = Quad4(1, 1)
        grid(5) = Quad4(2, 1)
        grid(6) = Quad7(0, 1)
        grid(7) = Quad7(1, 1)
        grid(8) = Quad7(2, 1)
        count = 0
        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(0, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(1, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(2, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(0, 1) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(1, 1) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(2, 1) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(0, 1) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(1, 1) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(2, 1) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(0, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, missing(i)) Then
                            Quad1(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad1(1, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, missing(i)) Then
                            Quad1(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad1(2, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, missing(i)) Then
                            Quad1(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad4(0, 1) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, missing(i)) Then
                            Quad4(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad4(1, 1) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, missing(i)) Then
                            Quad4(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad4(2, 1) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, missing(i)) Then
                            Quad4(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad7(0, 1) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, missing(i)) Then
                            Quad7(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad7(1, 1) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, missing(i)) Then
                            Quad7(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad7(2, 1) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, missing(i)) Then
                            Quad7(2, 1) = missing(i)
                        End If
                    End If
                End If
            Next

        End If

        'Line 3
        grid(0) = Quad1(0, 2)
        grid(1) = Quad1(1, 2)
        grid(2) = Quad1(2, 2)
        grid(3) = Quad4(0, 2)
        grid(4) = Quad4(1, 2)
        grid(5) = Quad4(2, 2)
        grid(6) = Quad7(0, 2)
        grid(7) = Quad7(1, 2)
        grid(8) = Quad7(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(0, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(1, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(2, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(0, 2) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(1, 2) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad4(2, 2) = 0) Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(0, 2) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(1, 2) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad7(2, 2) = 0) Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(0, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, missing(i)) Then
                            Quad1(0, 2) = missing(i)
                        End If
                    End If
                    If (Quad1(1, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, missing(i)) Then
                            Quad1(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad1(2, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, missing(i)) Then
                            Quad1(2, 2) = missing(i)
                        End If
                    End If
                    If (Quad4(0, 2) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, missing(i)) Then
                            Quad4(0, 2) = missing(i)
                        End If
                    End If
                    If (Quad4(1, 2) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, missing(i)) Then
                            Quad4(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad4(2, 2) = 0) Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, missing(i)) Then
                            Quad4(2, 2) = missing(i)
                        End If
                    End If
                    If (Quad7(0, 2) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, missing(i)) Then
                            Quad7(0, 2) = missing(i)
                        End If
                    End If
                    If (Quad7(1, 2) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, missing(i)) Then
                            Quad7(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad7(2, 2) = 0) Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, missing(i)) Then
                            Quad7(2, 2) = missing(i)
                        End If
                    End If
                End If
            Next

        End If

        'Line(4)
        grid(0) = Quad2(0, 0)
        grid(1) = Quad2(1, 0)
        grid(2) = Quad2(2, 0)
        grid(3) = Quad5(0, 0)
        grid(4) = Quad5(1, 0)
        grid(5) = Quad5(2, 0)
        grid(6) = Quad8(0, 0)
        grid(7) = Quad8(1, 0)
        grid(8) = Quad8(2, 0)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad2(0, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad5(0, 0) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(1, 0) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(2, 0) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad8(0, 0) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(1, 0) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(2, 0) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If


                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad2(0, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, missing(i)) Then
                            Quad2(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, missing(i)) Then
                            Quad2(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, missing(i)) Then
                            Quad2(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad5(0, 0) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, missing(i)) Then
                            Quad5(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad5(1, 0) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, missing(i)) Then
                            Quad5(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad5(2, 0) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, missing(i)) Then
                            Quad5(2, 0) = missing(i)
                        End If
                    End If

                    If (Quad8(0, 0) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, missing(i)) Then
                            Quad8(0, 0) = missing(i)
                        End If
                    End If

                    If (Quad8(1, 0) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, missing(i)) Then
                            Quad8(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad8(2, 0) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, missing(i)) Then
                            Quad8(2, 0) = missing(i)
                        End If
                    End If

                End If
            Next

        End If




        'Line 5
        grid(0) = Quad2(0, 1)
        grid(1) = Quad2(1, 1)
        grid(2) = Quad2(2, 1)
        grid(3) = Quad5(0, 1)
        grid(4) = Quad5(1, 1)
        grid(5) = Quad5(2, 1)
        grid(6) = Quad8(0, 1)
        grid(7) = Quad8(1, 1)
        grid(8) = Quad8(2, 1)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad2(0, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad5(0, 1) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(1, 1) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(2, 1) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad8(0, 1) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(1, 1) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(2, 1) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If


                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad2(0, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, missing(i)) Then
                            Quad2(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, missing(i)) Then
                            Quad2(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, missing(i)) Then
                            Quad2(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad5(0, 1) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, missing(i)) Then
                            Quad5(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad5(1, 1) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, missing(i)) Then
                            Quad5(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad5(2, 1) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, missing(i)) Then
                            Quad5(2, 1) = missing(i)
                        End If
                    End If

                    If (Quad8(0, 1) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, missing(i)) Then
                            Quad8(0, 1) = missing(i)
                        End If
                    End If

                    If (Quad8(1, 1) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, missing(i)) Then
                            Quad8(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad8(2, 1) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, missing(i)) Then
                            Quad8(2, 1) = missing(i)
                        End If
                    End If

                End If
            Next

        End If


        'Line 6
        grid(0) = Quad2(0, 2)
        grid(1) = Quad2(1, 2)
        grid(2) = Quad2(2, 2)
        grid(3) = Quad5(0, 2)
        grid(4) = Quad5(1, 2)
        grid(5) = Quad5(2, 2)
        grid(6) = Quad8(0, 2)
        grid(7) = Quad8(1, 2)
        grid(8) = Quad8(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next


        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad2(0, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad5(0, 2) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(1, 2) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad5(2, 2) = 0) Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad8(0, 2) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(1, 2) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad8(2, 2) = 0) Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If


                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad2(0, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, missing(i)) Then
                            Quad2(0, 2) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, missing(i)) Then
                            Quad2(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, missing(i)) Then
                            Quad2(2, 2) = missing(i)
                        End If
                    End If
                    If (Quad5(0, 2) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, missing(i)) Then
                            Quad5(0, 2) = missing(i)
                        End If
                    End If
                    If (Quad5(1, 2) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, missing(i)) Then
                            Quad5(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad5(2, 2) = 0) Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, missing(i)) Then
                            Quad5(2, 2) = missing(i)
                        End If
                    End If

                    If (Quad8(0, 2) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, missing(i)) Then
                            Quad8(0, 2) = missing(i)
                        End If
                    End If

                    If (Quad8(1, 2) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, missing(i)) Then
                            Quad8(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad8(2, 2) = 0) Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, missing(i)) Then
                            Quad8(2, 2) = missing(i)
                        End If
                    End If

                End If
            Next

        End If




    End Function
    Function solvebyGrids() As Boolean
        If SOLVED() Then
            Return True
        End If

        Dim grid(8) As Integer
        grid(0) = Quad1(0, 0)
        grid(1) = Quad1(0, 1)
        grid(2) = Quad1(0, 2)
        grid(3) = Quad2(0, 0)
        grid(4) = Quad2(0, 1)
        grid(5) = Quad2(0, 2)
        grid(6) = Quad3(0, 0)
        grid(7) = Quad3(0, 1)
        grid(8) = Quad3(0, 2)
        Dim missing(8) As Integer
        Dim count As Integer = 0
        Dim possibles As Integer



        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(0, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(0, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(0, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(0, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(0, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(0, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(0, 0) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(0, 1) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(0, 2) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(0, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, missing(i)) Then
                            Quad1(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad1(0, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, missing(i)) Then
                            Quad1(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad1(0, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, missing(i)) Then
                            Quad1(0, 2) = missing(i)
                        End If
                    End If

                    If (Quad2(0, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, missing(i)) Then
                            Quad2(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad2(0, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, missing(i)) Then
                            Quad2(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad2(0, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, missing(i)) Then
                            Quad2(0, 2) = missing(i)
                        End If
                    End If

                    If (Quad3(0, 0) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 0, missing(i)) Then
                            Quad3(0, 0) = missing(i)
                        End If
                    End If
                    If (Quad3(0, 1) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 1, missing(i)) Then
                            Quad3(0, 1) = missing(i)
                        End If
                    End If
                    If (Quad3(0, 2) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 2, missing(i)) Then
                            Quad3(0, 2) = missing(i)
                        End If
                    End If
                End If
            Next

        End If


        'Line 2
        grid(0) = Quad1(1, 0)
        grid(1) = Quad1(1, 1)
        grid(2) = Quad1(1, 2)
        grid(3) = Quad2(1, 0)
        grid(4) = Quad2(1, 1)
        grid(5) = Quad2(1, 2)
        grid(6) = Quad3(1, 0)
        grid(7) = Quad3(1, 1)
        grid(8) = Quad3(1, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(1, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(1, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(1, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(1, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If

                If (Quad3(1, 0) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(1, 1) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(1, 2) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(1, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, missing(i)) Then
                            Quad1(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad1(1, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, missing(i)) Then
                            Quad1(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad1(1, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, missing(i)) Then
                            Quad1(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, missing(i)) Then
                            Quad2(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, missing(i)) Then
                            Quad2(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad2(1, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, missing(i)) Then
                            Quad2(1, 2) = missing(i)
                        End If
                    End If
                    If (Quad3(1, 0) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 0, missing(i)) Then
                            Quad3(1, 0) = missing(i)
                        End If
                    End If
                    If (Quad3(1, 1) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 1, missing(i)) Then
                            Quad3(1, 1) = missing(i)
                        End If
                    End If
                    If (Quad3(1, 2) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 2, missing(i)) Then
                            Quad3(1, 2) = missing(i)
                        End If
                    End If
                End If
            Next

        End If

        'Line 3
        grid(0) = Quad1(2, 0)
        grid(1) = Quad1(2, 1)
        grid(2) = Quad1(2, 2)
        grid(3) = Quad2(2, 0)
        grid(4) = Quad2(2, 1)
        grid(5) = Quad2(2, 2)
        grid(6) = Quad3(2, 0)
        grid(7) = Quad3(2, 1)
        grid(8) = Quad3(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If (Quad1(2, 0) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(2, 1) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad1(2, 2) = 0) Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 0) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 1) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad2(2, 2) = 0) Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(2, 0) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(2, 1) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If (Quad3(2, 2) = 0) Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If (Quad1(2, 0) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, missing(i)) Then
                            Quad1(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad1(2, 1) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, missing(i)) Then
                            Quad1(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad1(2, 2) = 0) Then
                        If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, missing(i)) Then
                            Quad1(2, 2) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 0) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, missing(i)) Then
                            Quad2(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 1) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, missing(i)) Then
                            Quad2(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad2(2, 2) = 0) Then
                        If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, missing(i)) Then
                            Quad2(2, 2) = missing(i)
                        End If
                    End If
                    If (Quad3(2, 0) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 0, missing(i)) Then
                            Quad3(2, 0) = missing(i)
                        End If
                    End If
                    If (Quad3(2, 1) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 1, missing(i)) Then
                            Quad3(2, 1) = missing(i)
                        End If
                    End If
                    If (Quad3(2, 2) = 0) Then
                        If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 2, missing(i)) Then
                            Quad3(2, 2) = missing(i)
                        End If
                    End If
                End If
            Next

        End If

        'Line 4
        grid(0) = Quad4(0, 0)
        grid(1) = Quad4(0, 1)
        grid(2) = Quad4(0, 2)
        grid(3) = Quad5(0, 0)
        grid(4) = Quad5(0, 1)
        grid(5) = Quad5(0, 2)
        grid(6) = Quad6(0, 0)
        grid(7) = Quad6(0, 1)
        grid(8) = Quad6(0, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad4(0, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(0, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(0, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(0, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(0, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(0, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(0, 0) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(0, 1) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(0, 2) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad4(0, 0) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, missing(i)) Then
                            Quad4(0, 0) = missing(i)
                        End If
                    End If
                    If Quad4(0, 1) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, missing(i)) Then
                            Quad4(0, 1) = missing(i)
                        End If
                    End If
                    If Quad4(0, 2) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, missing(i)) Then
                            Quad4(0, 2) = missing(i)
                        End If
                    End If
                    If Quad5(0, 0) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, missing(i)) Then
                            Quad5(0, 0) = missing(i)
                        End If
                    End If
                    If Quad5(0, 1) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, missing(i)) Then
                            Quad5(0, 1) = missing(i)
                        End If
                    End If
                    If Quad5(0, 2) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, missing(i)) Then
                            Quad5(0, 2) = missing(i)
                        End If
                    End If
                    If Quad6(0, 0) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 0, missing(i)) Then
                            Quad6(0, 0) = missing(i)
                        End If
                    End If
                    If Quad6(0, 1) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 1, missing(i)) Then
                            Quad6(0, 1) = missing(i)
                        End If
                    End If
                    If Quad6(0, 2) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 2, missing(i)) Then
                            Quad6(0, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If

        'line 5
        grid(0) = Quad4(1, 0)
        grid(1) = Quad4(1, 1)
        grid(2) = Quad4(1, 2)
        grid(3) = Quad5(1, 0)
        grid(4) = Quad5(1, 1)
        grid(5) = Quad5(1, 2)
        grid(6) = Quad6(1, 0)
        grid(7) = Quad6(1, 1)
        grid(8) = Quad6(1, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad4(1, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(1, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(1, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 0) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 1) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 2) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad4(1, 0) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, missing(i)) Then
                            Quad4(1, 0) = missing(i)
                        End If
                    End If
                    If Quad4(1, 1) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, missing(i)) Then
                            Quad4(1, 1) = missing(i)
                        End If
                    End If
                    If Quad4(1, 2) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, missing(i)) Then
                            Quad4(1, 2) = missing(i)
                        End If
                    End If
                    If Quad5(1, 0) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, missing(i)) Then
                            Quad5(1, 0) = missing(i)
                        End If
                    End If
                    If Quad5(1, 1) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, missing(i)) Then
                            Quad5(1, 1) = missing(i)
                        End If
                    End If
                    If Quad5(1, 2) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, missing(i)) Then
                            Quad5(1, 2) = missing(i)
                        End If
                    End If
                    If Quad6(1, 0) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 0, missing(i)) Then
                            Quad6(1, 0) = missing(i)
                        End If
                    End If
                    If Quad6(1, 1) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 1, missing(i)) Then
                            Quad6(1, 1) = missing(i)
                        End If
                    End If
                    If Quad6(1, 2) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 2, missing(i)) Then
                            Quad6(1, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If

        'Line6
        grid(0) = Quad4(2, 0)
        grid(1) = Quad4(2, 1)
        grid(2) = Quad4(2, 2)
        grid(3) = Quad5(2, 0)
        grid(4) = Quad5(2, 1)
        grid(5) = Quad5(2, 2)
        grid(6) = Quad6(2, 0)
        grid(7) = Quad6(2, 1)
        grid(8) = Quad6(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad4(2, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(2, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(2, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 0) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 1) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 2) = 0 Then
                    If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad4(2, 0) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, missing(i)) Then
                            Quad4(2, 0) = missing(i)
                        End If
                    End If
                    If Quad4(2, 1) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, missing(i)) Then
                            Quad4(2, 1) = missing(i)
                        End If
                    End If
                    If Quad4(2, 2) = 0 Then
                        If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, missing(i)) Then
                            Quad4(2, 2) = missing(i)
                        End If
                    End If
                    If Quad5(2, 0) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, missing(i)) Then
                            Quad5(2, 0) = missing(i)
                        End If
                    End If
                    If Quad5(2, 1) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, missing(i)) Then
                            Quad5(2, 1) = missing(i)
                        End If
                    End If
                    If Quad5(2, 2) = 0 Then
                        If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, missing(i)) Then
                            Quad5(2, 2) = missing(i)
                        End If
                    End If
                    If Quad6(2, 0) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 0, missing(i)) Then
                            Quad6(2, 0) = missing(i)
                        End If
                    End If
                    If Quad6(2, 1) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 1, missing(i)) Then
                            Quad6(2, 1) = missing(i)
                        End If
                    End If
                    If Quad6(2, 2) = 0 Then
                        If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 2, missing(i)) Then
                            Quad6(2, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If

        'Line 7
        grid(0) = Quad7(0, 0)
        grid(1) = Quad7(0, 1)
        grid(2) = Quad7(0, 2)
        grid(3) = Quad8(0, 0)
        grid(4) = Quad8(0, 1)
        grid(5) = Quad8(0, 2)
        grid(6) = Quad9(0, 0)
        grid(7) = Quad9(0, 1)
        grid(8) = Quad9(0, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad7(0, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(0, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(0, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(0, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(0, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(0, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(0, 0) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(0, 1) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(0, 2) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad7(0, 0) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, missing(i)) Then
                            Quad7(0, 0) = missing(i)
                        End If
                    End If
                    If Quad7(0, 1) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, missing(i)) Then
                            Quad7(0, 1) = missing(i)
                        End If
                    End If
                    If Quad7(0, 2) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, missing(i)) Then
                            Quad7(0, 2) = missing(i)
                        End If
                    End If
                    If Quad8(0, 0) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, missing(i)) Then
                            Quad8(0, 0) = missing(i)
                        End If
                    End If
                    If Quad8(0, 1) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, missing(i)) Then
                            Quad8(0, 1) = missing(i)
                        End If
                    End If
                    If Quad8(0, 2) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, missing(i)) Then
                            Quad8(0, 2) = missing(i)
                        End If
                    End If
                    If Quad9(0, 0) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 0, missing(i)) Then
                            Quad9(0, 0) = missing(i)
                        End If
                    End If
                    If Quad9(0, 1) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 1, missing(i)) Then
                            Quad9(0, 1) = missing(i)
                        End If
                    End If
                    If Quad9(0, 2) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 2, missing(i)) Then
                            Quad9(0, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If

        'Line 8
        grid(0) = Quad7(1, 0)
        grid(1) = Quad7(1, 1)
        grid(2) = Quad7(1, 2)
        grid(3) = Quad8(1, 0)
        grid(4) = Quad8(1, 1)
        grid(5) = Quad8(1, 2)
        grid(6) = Quad9(1, 0)
        grid(7) = Quad9(1, 1)
        grid(8) = Quad9(1, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad7(1, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(1, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(1, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 0) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 1) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 2) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad7(1, 0) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, missing(i)) Then
                            Quad7(1, 0) = missing(i)
                        End If
                    End If
                    If Quad7(1, 1) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, missing(i)) Then
                            Quad7(1, 1) = missing(i)
                        End If
                    End If
                    If Quad7(1, 2) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, missing(i)) Then
                            Quad7(1, 2) = missing(i)
                        End If
                    End If
                    If Quad8(1, 0) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, missing(i)) Then
                            Quad8(1, 0) = missing(i)
                        End If
                    End If
                    If Quad8(1, 1) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, missing(i)) Then
                            Quad8(1, 1) = missing(i)
                        End If
                    End If
                    If Quad8(1, 2) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, missing(i)) Then
                            Quad8(1, 2) = missing(i)
                        End If
                    End If
                    If Quad9(1, 0) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 0, missing(i)) Then
                            Quad9(1, 0) = missing(i)
                        End If
                    End If
                    If Quad9(1, 1) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 1, missing(i)) Then
                            Quad9(1, 1) = missing(i)
                        End If
                    End If
                    If Quad9(1, 2) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 2, missing(i)) Then
                            Quad9(1, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If

        'Line 9
        grid(0) = Quad7(2, 0)
        grid(1) = Quad7(2, 1)
        grid(2) = Quad7(2, 2)
        grid(3) = Quad8(2, 0)
        grid(4) = Quad8(2, 1)
        grid(5) = Quad8(2, 2)
        grid(6) = Quad9(2, 0)
        grid(7) = Quad9(2, 1)
        grid(8) = Quad9(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 1 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad7(2, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(2, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(2, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 0) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 1) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 2) = 0 Then
                    If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    AnswersFound = 1
                    If Quad7(2, 0) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, missing(i)) Then
                            Quad7(2, 0) = missing(i)
                        End If
                    End If
                    If Quad7(2, 1) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, missing(i)) Then
                            Quad7(2, 1) = missing(i)
                        End If
                    End If
                    If Quad7(2, 2) = 0 Then
                        If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, missing(i)) Then
                            Quad7(2, 2) = missing(i)
                        End If
                    End If
                    If Quad8(2, 0) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, missing(i)) Then
                            Quad8(2, 0) = missing(i)
                        End If
                    End If
                    If Quad8(2, 1) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, missing(i)) Then
                            Quad8(2, 1) = missing(i)
                        End If
                    End If
                    If Quad8(2, 2) = 0 Then
                        If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, missing(i)) Then
                            Quad8(2, 2) = missing(i)
                        End If
                    End If
                    If Quad9(2, 0) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 0, missing(i)) Then
                            Quad9(2, 0) = missing(i)
                        End If
                    End If
                    If Quad9(2, 1) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 1, missing(i)) Then
                            Quad9(2, 1) = missing(i)
                        End If
                    End If
                    If Quad9(2, 2) = 0 Then
                        If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 2, missing(i)) Then
                            Quad9(2, 2) = missing(i)
                        End If
                    End If

                End If
            Next
        End If




    End Function
    Function FindMultipleNum(ByVal Quad(,) As Integer, ByVal QuadII(,) As Integer, ByVal QuadIII(,) As Integer, ByVal QuadIV(,) As Integer, ByVal QuadV(,) As Integer, ByVal i As Integer, ByVal j As Integer, ByRef arr() As Integer, ByVal countvals As Integer) As Integer
        Dim ans As Integer = 0
        Dim count As Integer = 0
        For x As Integer = 0 To countvals - 1
            If (findOneAnswer(Quad, QuadII, QuadIII, QuadIV, QuadV, i, j, arr(x))) Then
                'arr(count) = x
                count = count + 1
                ans = x
            End If
        Next

        If (count = 1) Then
            AnswersFound = AnswersFound + 1
            Return ans
        Else
            Return 0
        End If
    End Function
    '/ <summary>
    '
    '/ </summary>
    Function SolvebyQuads() As Boolean
        If SOLVED() Then
            Return True
        End If
        Dim grid(8) As Integer
        grid(0) = Quad1(0, 0)
        grid(1) = Quad1(0, 1)
        grid(2) = Quad1(0, 2)
        grid(3) = Quad1(1, 0)
        grid(4) = Quad1(1, 1)
        grid(5) = Quad1(1, 2)
        grid(6) = Quad1(2, 0)
        grid(7) = Quad1(2, 1)
        grid(8) = Quad1(2, 2)

        Dim missing(8) As Integer
        Dim count As Integer = 0
        Dim possibles As Integer



        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad1(0, 0) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(0, 1) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(0, 2) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(1, 0) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(1, 1) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(1, 2) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(2, 0) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(2, 1) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad1(2, 2) = 0 Then
                    If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 1)
                End If
            Next
        End If

        grid(0) = Quad2(0, 0)
        grid(1) = Quad2(0, 1)
        grid(2) = Quad2(0, 2)
        grid(3) = Quad2(1, 0)
        grid(4) = Quad2(1, 1)
        grid(5) = Quad2(1, 2)
        grid(6) = Quad2(2, 0)
        grid(7) = Quad2(2, 1)
        grid(8) = Quad2(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad2(0, 0) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(0, 1) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(0, 2) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(1, 0) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(1, 1) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(1, 2) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(2, 0) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(2, 1) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad2(2, 2) = 0 Then
                    If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 2)
                End If
            Next
        End If
        'Quad 3
        grid(0) = Quad3(0, 0)
        grid(1) = Quad3(0, 1)
        grid(2) = Quad3(0, 2)
        grid(3) = Quad3(1, 0)
        grid(4) = Quad3(1, 1)
        grid(5) = Quad3(1, 2)
        grid(6) = Quad3(2, 0)
        grid(7) = Quad3(2, 1)
        grid(8) = Quad3(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad3(0, 0) = 0 Then
                    If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(0, 1) = 0 Then
                    If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(0, 2) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(1, 0) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(1, 1) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(1, 2) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(2, 0) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(2, 1) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad3(2, 2) = 0 Then
                    If isvalid(Quad3, Quad1, Quad2, Quad6, Quad9, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 3)
                End If
            Next
        End If
        'Quad 4
        grid(0) = Quad4(0, 0)
        grid(1) = Quad4(0, 1)
        grid(2) = Quad4(0, 2)
        grid(3) = Quad4(1, 0)
        grid(4) = Quad4(1, 1)
        grid(5) = Quad4(1, 2)
        grid(6) = Quad4(2, 0)
        grid(7) = Quad4(2, 1)
        grid(8) = Quad4(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad4(0, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(0, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(0, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(1, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(1, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(1, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(2, 0) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(2, 1) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad4(2, 2) = 0 Then
                    If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 4)
                End If
            Next
        End If
        'Quad 5
        grid(0) = Quad5(0, 0)
        grid(1) = Quad5(0, 1)
        grid(2) = Quad5(0, 2)
        grid(3) = Quad5(1, 0)
        grid(4) = Quad5(1, 1)
        grid(5) = Quad5(1, 2)
        grid(6) = Quad5(2, 0)
        grid(7) = Quad5(2, 1)
        grid(8) = Quad5(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad5(0, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(0, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(0, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(1, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 0) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 1) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad5(2, 2) = 0 Then
                    If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 5)
                End If
            Next
        End If
        'Quad 6
        grid(0) = Quad6(0, 0)
        grid(1) = Quad6(0, 1)
        grid(2) = Quad6(0, 2)
        grid(3) = Quad6(1, 0)
        grid(4) = Quad6(1, 1)
        grid(5) = Quad6(1, 2)
        grid(6) = Quad6(2, 0)
        grid(7) = Quad6(2, 1)
        grid(8) = Quad6(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad6(0, 0) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(0, 1) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(0, 2) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 0) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 1) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(1, 2) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 0) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 1) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad6(2, 2) = 0 Then
                    If isvalid(Quad6, Quad5, Quad4, Quad3, Quad9, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 6)
                End If
            Next
        End If
        'Quad 7
        grid(0) = Quad7(0, 0)
        grid(1) = Quad7(0, 1)
        grid(2) = Quad7(0, 2)
        grid(3) = Quad7(1, 0)
        grid(4) = Quad7(1, 1)
        grid(5) = Quad7(1, 2)
        grid(6) = Quad7(2, 0)
        grid(7) = Quad7(2, 1)
        grid(8) = Quad7(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad7(0, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(0, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(0, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(1, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(1, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(1, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(2, 0) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(2, 1) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad7(2, 2) = 0 Then
                    If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 7)
                End If
            Next
        End If
        'Quad 8
        grid(0) = Quad8(0, 0)
        grid(1) = Quad8(0, 1)
        grid(2) = Quad8(0, 2)
        grid(3) = Quad8(1, 0)
        grid(4) = Quad8(1, 1)
        grid(5) = Quad8(1, 2)
        grid(6) = Quad8(2, 0)
        grid(7) = Quad8(2, 1)
        grid(8) = Quad8(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad8(0, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(0, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(0, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(1, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 0) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 1) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad8(2, 2) = 0 Then
                    If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 8)
                End If
            Next
        End If
        'Quad 9
        grid(0) = Quad9(0, 0)
        grid(1) = Quad9(0, 1)
        grid(2) = Quad9(0, 2)
        grid(3) = Quad9(1, 0)
        grid(4) = Quad9(1, 1)
        grid(5) = Quad9(1, 2)
        grid(6) = Quad9(2, 0)
        grid(7) = Quad9(2, 1)
        grid(8) = Quad9(2, 2)
        count = 0

        For i As Integer = 1 To 9
            If (grid(0) = i Or grid(1) = i Or grid(2) = i Or grid(3) = i Or grid(4) = i Or grid(5) = i Or grid(6) = i Or grid(7) = i Or grid(8) = i) Then
            Else
                missing(count) = i
                count = count + 1
            End If
        Next

        If count > 0 Then
            For i As Integer = 0 To count - 1
                possibles = 0
                If Quad9(0, 0) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 0, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(0, 1) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 0, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(0, 2) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 0, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 0) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 1, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 1) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 1, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(1, 2) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 1, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 0) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 2, 0, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 1) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 2, 1, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If Quad9(2, 2) = 0 Then
                    If isvalid(Quad9, Quad8, Quad7, Quad3, Quad6, 2, 2, missing(i)) Then
                        possibles = possibles + 1
                    End If
                End If
                If possibles = 1 Then
                    PlaceinGrid(missing(i), 9)
                End If
            Next
        End If
    End Function
    Sub PlaceinGrid(ByVal k As Integer, ByVal quad As Integer)
        AnswersFound = AnswersFound + 1
        If quad = 1 Then
            If Quad1(0, 0) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 0, k) Then
                    Quad1(0, 0) = k
                    Return
                End If
            End If
            If Quad1(0, 1) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 1, k) Then
                    Quad1(0, 1) = k
                    Return
                End If
            End If
            If Quad1(0, 2) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 0, 2, k) Then
                    Quad1(0, 2) = k
                    Return
                End If
            End If
            If Quad1(1, 0) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 0, k) Then
                    Quad1(1, 0) = k
                    Return
                End If
            End If
            If Quad1(1, 1) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 1, k) Then
                    Quad1(1, 1) = k
                    Return
                End If
            End If
            If Quad1(1, 2) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 1, 2, k) Then
                    Quad1(1, 2) = k
                    Return
                End If
            End If
            If Quad1(2, 0) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 0, k) Then
                    Quad1(2, 0) = k
                    Return
                End If
            End If
            If Quad1(2, 1) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 1, k) Then
                    Quad1(2, 1) = k
                    Return
                End If
            End If
            If Quad1(2, 2) = 0 Then
                If isvalid(Quad1, Quad2, Quad3, Quad4, Quad7, 2, 2, k) Then
                    Quad1(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 2 Then
            If Quad2(0, 0) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 0, k) Then
                    Quad2(0, 0) = k
                    Return
                End If
            End If
            If Quad2(0, 1) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 1, k) Then
                    Quad2(0, 1) = k
                    Return
                End If
            End If
            If Quad2(0, 2) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 0, 2, k) Then
                    Quad2(0, 2) = k
                    Return
                End If
            End If
            If Quad2(1, 0) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 0, k) Then
                    Quad2(1, 0) = k
                    Return
                End If
            End If
            If Quad2(1, 1) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 1, k) Then
                    Quad2(1, 1) = k
                    Return
                End If
            End If
            If Quad2(1, 2) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 1, 2, k) Then
                    Quad2(1, 2) = k
                    Return
                End If
            End If
            If Quad2(2, 0) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 0, k) Then
                    Quad2(2, 0) = k
                    Return
                End If
            End If
            If Quad2(2, 1) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 1, k) Then
                    Quad2(2, 1) = k
                    Return
                End If
            End If
            If Quad2(2, 2) = 0 Then
                If isvalid(Quad2, Quad1, Quad3, Quad5, Quad8, 2, 2, k) Then
                    Quad1(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 3 Then
            If Quad3(0, 0) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 0, 0, k) Then
                    Quad3(0, 0) = k
                    Return
                End If
            End If
            If Quad3(0, 1) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 0, 1, k) Then
                    Quad3(0, 1) = k
                    Return
                End If
            End If
            If Quad3(0, 2) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 0, 2, k) Then
                    Quad3(0, 2) = k
                    Return
                End If
            End If
            If Quad3(1, 0) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 1, 0, k) Then
                    Quad3(1, 0) = k
                    Return
                End If
            End If
            If Quad3(1, 1) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 1, 1, k) Then
                    Quad3(1, 1) = k
                    Return
                End If
            End If
            If Quad3(1, 2) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 1, 2, k) Then
                    Quad3(1, 2) = k
                    Return
                End If
            End If
            If Quad3(2, 0) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 2, 0, k) Then
                    Quad3(2, 0) = k
                    Return
                End If
            End If
            If Quad3(2, 1) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 2, 1, k) Then
                    Quad3(2, 1) = k
                    Return
                End If
            End If
            If Quad3(2, 2) = 0 Then
                If isvalid(Quad3, Quad2, Quad1, Quad6, Quad9, 2, 2, k) Then
                    Quad3(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 4 Then
            If Quad4(0, 0) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 0, k) Then
                    Quad4(0, 0) = k
                    Return
                End If
            End If
            If Quad4(0, 1) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 1, k) Then
                    Quad4(0, 1) = k
                    Return
                End If
            End If
            If Quad4(0, 2) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 0, 2, k) Then
                    Quad4(0, 2) = k
                    Return
                End If
            End If
            If Quad4(1, 0) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 0, k) Then
                    Quad4(1, 0) = k
                    Return
                End If
            End If
            If Quad4(1, 1) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 1, k) Then
                    Quad4(1, 1) = k
                    Return
                End If
            End If
            If Quad4(1, 2) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 1, 2, k) Then
                    Quad4(1, 2) = k
                    Return
                End If
            End If
            If Quad4(2, 0) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 0, k) Then
                    Quad4(2, 0) = k
                    Return
                End If
            End If
            If Quad4(2, 1) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 1, k) Then
                    Quad4(2, 1) = k
                    Return
                End If
            End If
            If Quad4(2, 2) = 0 Then
                If isvalid(Quad4, Quad5, Quad6, Quad1, Quad7, 2, 2, k) Then
                    Quad4(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 5 Then
            If Quad5(0, 0) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 0, k) Then
                    Quad5(0, 0) = k
                    Return
                End If
            End If
            If Quad5(0, 1) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 1, k) Then
                    Quad5(0, 1) = k
                    Return
                End If
            End If
            If Quad5(0, 2) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 0, 2, k) Then
                    Quad5(0, 2) = k
                    Return
                End If
            End If
            If Quad5(1, 0) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 0, k) Then
                    Quad5(1, 0) = k
                    Return
                End If
            End If
            If Quad5(1, 1) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 1, k) Then
                    Quad5(1, 1) = k
                    Return
                End If
            End If
            If Quad5(1, 2) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 1, 2, k) Then
                    Quad5(1, 2) = k
                    Return
                End If
            End If
            If Quad5(2, 0) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 0, k) Then
                    Quad5(2, 0) = k
                    Return
                End If
            End If
            If Quad5(2, 1) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 1, k) Then
                    Quad5(2, 1) = k
                    Return
                End If
            End If
            If Quad5(2, 2) = 0 Then
                If isvalid(Quad5, Quad4, Quad6, Quad2, Quad8, 2, 2, k) Then
                    Quad5(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 6 Then
            If Quad6(0, 0) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 0, k) Then
                    Quad6(0, 0) = k
                    Return
                End If
            End If
            If Quad6(0, 1) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 1, k) Then
                    Quad6(0, 1) = k
                    Return
                End If
            End If
            If Quad6(0, 2) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 0, 2, k) Then
                    Quad6(0, 2) = k
                    Return
                End If
            End If
            If Quad6(1, 0) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 0, k) Then
                    Quad6(1, 0) = k
                    Return
                End If
            End If
            If Quad6(1, 1) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 1, k) Then
                    Quad5(1, 1) = k
                    Return
                End If
            End If
            If Quad6(1, 2) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 1, 2, k) Then
                    Quad6(1, 2) = k
                    Return
                End If
            End If
            If Quad6(2, 0) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 0, k) Then
                    Quad6(2, 0) = k
                    Return
                End If
            End If
            If Quad6(2, 1) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 1, k) Then
                    Quad6(2, 1) = k
                    Return
                End If
            End If
            If Quad6(2, 2) = 0 Then
                If isvalid(Quad6, Quad4, Quad5, Quad3, Quad9, 2, 2, k) Then
                    Quad6(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 7 Then
            If Quad7(0, 0) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 0, k) Then
                    Quad7(0, 0) = k
                    Return
                End If
            End If
            If Quad7(0, 1) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 1, k) Then
                    Quad7(0, 1) = k
                    Return
                End If
            End If
            If Quad7(0, 2) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 0, 2, k) Then
                    Quad7(0, 2) = k
                    Return
                End If
            End If
            If Quad7(1, 0) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 0, k) Then
                    Quad7(1, 0) = k
                    Return
                End If
            End If
            If Quad7(1, 1) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 1, k) Then
                    Quad7(1, 1) = k
                    Return
                End If
            End If
            If Quad7(1, 2) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 1, 2, k) Then
                    Quad7(1, 2) = k
                    Return
                End If
            End If
            If Quad7(2, 0) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 0, k) Then
                    Quad7(2, 0) = k
                    Return
                End If
            End If
            If Quad7(2, 1) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 1, k) Then
                    Quad7(2, 1) = k
                    Return
                End If
            End If
            If Quad7(2, 2) = 0 Then
                If isvalid(Quad7, Quad8, Quad9, Quad1, Quad4, 2, 2, k) Then
                    Quad7(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 8 Then
            If Quad8(0, 0) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 0, k) Then
                    Quad8(0, 0) = k
                    Return
                End If
            End If
            If Quad8(0, 1) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 1, k) Then
                    Quad8(0, 1) = k
                    Return
                End If
            End If
            If Quad8(0, 2) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 0, 2, k) Then
                    Quad8(0, 2) = k
                    Return
                End If
            End If
            If Quad8(1, 0) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 0, k) Then
                    Quad8(1, 0) = k
                    Return
                End If
            End If
            If Quad8(1, 1) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 1, k) Then
                    Quad8(1, 1) = k
                    Return
                End If
            End If
            If Quad8(1, 2) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 1, 2, k) Then
                    Quad8(1, 2) = k
                    Return
                End If
            End If
            If Quad8(2, 0) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 0, k) Then
                    Quad8(2, 0) = k
                    Return
                End If
            End If
            If Quad8(2, 1) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 1, k) Then
                    Quad8(2, 1) = k
                    Return
                End If
            End If
            If Quad8(2, 2) = 0 Then
                If isvalid(Quad8, Quad7, Quad9, Quad2, Quad5, 2, 2, k) Then
                    Quad8(2, 2) = k
                    Return
                End If
            End If
        ElseIf quad = 9 Then
            If Quad9(0, 0) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 0, k) Then
                    Quad9(0, 0) = k
                    Return
                End If
            End If
            If Quad9(0, 1) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 1, k) Then
                    Quad9(0, 1) = k
                    Return
                End If
            End If
            If Quad9(0, 2) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 0, 2, k) Then
                    Quad9(0, 2) = k
                    Return
                End If
            End If
            If Quad9(1, 0) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 0, k) Then
                    Quad9(1, 0) = k
                    Return
                End If
            End If
            If Quad9(1, 1) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 1, k) Then
                    Quad9(1, 1) = k
                    Return
                End If
            End If
            If Quad9(1, 2) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 1, 2, k) Then
                    Quad9(1, 2) = k
                    Return
                End If
            End If
            If Quad9(2, 0) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 0, k) Then
                    Quad9(2, 0) = k
                    Return
                End If
            End If
            If Quad9(2, 1) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 1, k) Then
                    Quad9(2, 1) = k
                    Return
                End If
            End If
            If Quad9(2, 2) = 0 Then
                If isvalid(Quad9, Quad7, Quad8, Quad3, Quad6, 2, 2, k) Then
                    Quad9(2, 2) = k
                    Return
                End If
            End If

        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()



        TextBox1.TabIndex = 1
        TextBox2.TabIndex = 2
        TextBox3.TabIndex = 3
        TextBox4.TabIndex = 4
        TextBox5.TabIndex = 5
        TextBox6.TabIndex = 6
        TextBox7.TabIndex = 7
        TextBox8.TabIndex = 8
        TextBox9.TabIndex = 9


        TextBox10.TabIndex = 10
        TextBox11.TabIndex = 11
        TextBox12.TabIndex = 12
        TextBox13.TabIndex = 13
        TextBox14.TabIndex = 14
        TextBox15.TabIndex = 15
        TextBox16.TabIndex = 16
        TextBox17.TabIndex = 17
        TextBox18.TabIndex = 18

        TextBox19.TabIndex = 19
        TextBox20.TabIndex = 20
        TextBox21.TabIndex = 21
        TextBox22.TabIndex = 22
        TextBox23.TabIndex = 23
        TextBox24.TabIndex = 24
        TextBox25.TabIndex = 25
        TextBox26.TabIndex = 26
        TextBox27.TabIndex = 27

        TextBox28.TabIndex = 28
        TextBox29.TabIndex = 29
        TextBox30.TabIndex = 30
        TextBox31.TabIndex = 31
        TextBox32.TabIndex = 32
        TextBox33.TabIndex = 33
        TextBox34.TabIndex = 34
        TextBox35.TabIndex = 35
        TextBox36.TabIndex = 36


        TextBox37.TabIndex = 37
        TextBox38.TabIndex = 38
        TextBox39.TabIndex = 39
        TextBox40.TabIndex = 40
        TextBox41.TabIndex = 41
        TextBox42.TabIndex = 42
        TextBox43.TabIndex = 43
        TextBox44.TabIndex = 44
        TextBox45.TabIndex = 45

        TextBox46.TabIndex = 46
        TextBox46.TabIndex = 47
        TextBox48.TabIndex = 48
        TextBox49.TabIndex = 49
        TextBox50.TabIndex = 50
        TextBox51.TabIndex = 51
        TextBox52.TabIndex = 52
        TextBox53.TabIndex = 53
        TextBox54.TabIndex = 54


        TextBox55.TabIndex = 55
        TextBox56.TabIndex = 56
        TextBox57.TabIndex = 57
        TextBox58.TabIndex = 58
        TextBox59.TabIndex = 59
        TextBox60.TabIndex = 60
        TextBox61.TabIndex = 61
        TextBox62.TabIndex = 62
        TextBox63.TabIndex = 63


        TextBox64.TabIndex = 64
        TextBox65.TabIndex = 65
        TextBox66.TabIndex = 66
        TextBox67.TabIndex = 67
        TextBox68.TabIndex = 68
        TextBox69.TabIndex = 69
        TextBox70.TabIndex = 70
        TextBox71.TabIndex = 71
        TextBox72.TabIndex = 72

        TextBox73.TabIndex = 73
        TextBox74.TabIndex = 74
        TextBox75.TabIndex = 75
        TextBox76.TabIndex = 76
        TextBox77.TabIndex = 77
        TextBox78.TabIndex = 78
        TextBox79.TabIndex = 79
        TextBox80.TabIndex = 80
        TextBox81.TabIndex = 81



        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        TextBox1.Text = 1
        TextBox3.Text = 5
        TextBox5.Text = 4
        TextBox7.Text = 9
        TextBox11.Text = 4
        TextBox14.Text = 1
        TextBox15.Text = 3
        TextBox18.Text = 7
        TextBox21.Text = 3
        TextBox24.Text = 9
        TextBox26.Text = 1
        TextBox27.Text = 6

        TextBox29.Text = 3
        TextBox31.Text = 2
        TextBox33.Text = 4
        TextBox34.Text = 7
        TextBox35.Text = 9
        TextBox38.Text = 1
        TextBox44.Text = 2
        TextBox47.Text = 7
        TextBox48.Text = 2
        TextBox49.Text = 9
        TextBox51.Text = 1
        TextBox53.Text = 6

        TextBox55.Text = 2
        TextBox56.Text = 5
        TextBox58.Text = 3
        TextBox61.Text = 1

        TextBox64.Text = 3
        TextBox67.Text = 4
        TextBox68.Text = 5
        TextBox71.Text = 7

        TextBox75.Text = 4
        TextBox77.Text = 2
        TextBox79.Text = 5
        TextBox81.Text = 9




    End Sub
End Class
