Imports System.Random

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

    Dim _debug_State As Boolean ' Dim Debug var

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Debug 
        _debug_State = True ' Set Debug State
        If _debug_State = True Then
            _debug_CloseBtn.Visible = True
        End If

        ' Set Form Fullscreen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize

    End Sub

    Private Sub _debug_CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _debug_CloseBtn.Click
        Me.Close()
    End Sub
End Class
