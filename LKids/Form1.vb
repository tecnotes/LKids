Imports System.Random
Imports System.IO
Imports teHELPLib

Public Class Form1

    ' Protect Form from close
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Dim Min As Integer = 1 ' Min for Math Section
    Dim Max As Integer = 9 ' Max for Math Section
    Dim FirstDigit, SecondDigit, Result, Count_Tasks As Integer ' Digit Var for Math Section
    Dim AppVisible As Boolean ' Application Visible Var
    Dim _debug_State As Boolean ' Dim Debug var

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Debug 
        Try
            Dim _get_debug_State_FromINI As New teHELPLib.INIFile
            Dim Result As String
            Result = _get_debug_State_FromINI.GetValue("config.ini", "DEBUG")
            If Result = "1" Then
                _debug_State = True ' Set Debug State. Change to True if you need to Enable Debug Controls
                If _debug_State = True Then
                    _debug_CloseBtn.Visible = True
                    _debug_Result.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Set Form Fullscreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize

        ' Set Form Background
        SetFormBackground()

        ' Task Selection
        _task_Select()

    End Sub

    Private Sub _task_Select()

        'Math 
        Dim _task_number As New Random()
        Dim _task As Integer

        _task = _task_number.Next(1, 4 + 1)

        If _task = 1 Then
            math_multiplication() ' Умножение
        ElseIf _task = 2 Then
            math_addition() ' Сложение
        ElseIf _task = 3 Then
            math_divide() ' Деление
        ElseIf _task = 4 Then
            math_subtraction() ' Вычитание 
        End If
    End Sub

    Public Sub math_multiplication()
        Dim Generator As New System.Random()
        FirstDigit = Generator.Next(Min, Max + 1)
        SecondDigit = Generator.Next(Min, Max + 1)
        Result = FirstDigit * SecondDigit
        _math_equation.Text = FirstDigit & " X " & SecondDigit & " = "
        _debug_Result.Text = Result
    End Sub

    Public Sub math_addition()
        Dim Generator As New System.Random()
        FirstDigit = Generator.Next(1, 98 + 1) ' Limited by two-digit number
        SecondDigit = Generator.Next(1, 98 + 1) ' Limited by two_digit number
        Result = FirstDigit + SecondDigit
        _math_equation.Text = FirstDigit & " + " & SecondDigit & " = "
        _debug_Result.Text = Result
    End Sub

    Public Sub math_divide()
        Dim Generator As New System.Random()
        Dim Result_divide As Integer
        FirstDigit = Generator.Next(Min, Max + 1)
        SecondDigit = Generator.Next(Min, Max + 1)
        Result_divide = FirstDigit * SecondDigit
        Result = FirstDigit
        _math_equation.Text = Result_divide & " : " & SecondDigit & " = "
        _debug_Result.Text = Result
    End Sub

    Public Sub math_subtraction()
        Dim Generator As New System.Random()
        FirstDigit = Generator.Next(1, 98 + 1) ' Limited by two-digit number
        SecondDigit = Generator.Next(1, 98 + 1) ' Limited by two-digit number
        If FirstDigit > SecondDigit Then
            Result = FirstDigit - SecondDigit
            _math_equation.Text = FirstDigit & " - " & SecondDigit & " = "
        Else
            Result = SecondDigit - FirstDigit
            _math_equation.Text = SecondDigit & " - " & FirstDigit & " = "
        End If
        _debug_Result.Text = Result
    End Sub

    Private Sub SetFormBackground()
        Dim _imageName As String = GetRandomImageFilePath("img")
        Me.BackgroundImage = Image.FromFile(_imageName)
    End Sub

    Private Sub _debug_CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _debug_CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub _checkout_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _checkout_Btn.Click
        If _mathResult_TxtBox.Text = "" Then
            MsgBox("The answer can not be empty!")
        Else
            If _mathResult_TxtBox.Text <> Result Then
                MsgBox("Wrong Answer! Try Again!")
                _mathResult_TxtBox.Text = ""
            Else
                Me.Visible = False
                AppVisible = False
                _mathResult_TxtBox.Text = ""
                Threading.Thread.Sleep(600000) ' 10 minutes sleep
                'Threading.Thread.Sleep(1000) ' test

                Me.Visible = True
                AppVisible = True
                _task_Select()
            End If
        End If
    End Sub

    Public Function GetRandomImageFilePath(ByVal folderPath As String) As String
        Dim files() As String = Directory.GetFiles(folderPath, "*.png")
        Dim random As Random = New Random()
        Return files(random.Next(0, files.Length - 1))
    End Function

End Class
