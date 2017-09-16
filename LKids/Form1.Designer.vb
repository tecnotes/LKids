<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._debug_CloseBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._math_equation = New System.Windows.Forms.Label()
        Me._mathResult_TxtBox = New System.Windows.Forms.TextBox()
        Me._checkout_Btn = New System.Windows.Forms.Button()
        Me._debug_Result = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_debug_CloseBtn
        '
        Me._debug_CloseBtn.Location = New System.Drawing.Point(13, 13)
        Me._debug_CloseBtn.Name = "_debug_CloseBtn"
        Me._debug_CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me._debug_CloseBtn.TabIndex = 0
        Me._debug_CloseBtn.Text = "Close"
        Me._debug_CloseBtn.UseVisualStyleBackColor = True
        Me._debug_CloseBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me._checkout_Btn)
        Me.Panel1.Controls.Add(Me._mathResult_TxtBox)
        Me.Panel1.Controls.Add(Me._math_equation)
        Me.Panel1.Location = New System.Drawing.Point(44, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 109)
        Me.Panel1.TabIndex = 1
        '
        '_math_equation
        '
        Me._math_equation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._math_equation.AutoSize = True
        Me._math_equation.Location = New System.Drawing.Point(307, 46)
        Me._math_equation.Name = "_math_equation"
        Me._math_equation.Size = New System.Drawing.Size(83, 13)
        Me._math_equation.TabIndex = 0
        Me._math_equation.Text = "_math_equation"
        '
        '_mathResult_TxtBox
        '
        Me._mathResult_TxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._mathResult_TxtBox.Location = New System.Drawing.Point(510, 43)
        Me._mathResult_TxtBox.Name = "_mathResult_TxtBox"
        Me._mathResult_TxtBox.Size = New System.Drawing.Size(47, 20)
        Me._mathResult_TxtBox.TabIndex = 1
        '
        '_checkout_Btn
        '
        Me._checkout_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._checkout_Btn.Location = New System.Drawing.Point(578, 40)
        Me._checkout_Btn.Name = "_checkout_Btn"
        Me._checkout_Btn.Size = New System.Drawing.Size(75, 23)
        Me._checkout_Btn.TabIndex = 2
        Me._checkout_Btn.Text = "Checkout!"
        Me._checkout_Btn.UseVisualStyleBackColor = True
        '
        '_debug_Result
        '
        Me._debug_Result.AutoSize = True
        Me._debug_Result.Location = New System.Drawing.Point(108, 18)
        Me._debug_Result.Name = "_debug_Result"
        Me._debug_Result.Size = New System.Drawing.Size(79, 13)
        Me._debug_Result.TabIndex = 2
        Me._debug_Result.Text = "_debug_Result"
        Me._debug_Result.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 518)
        Me.Controls.Add(Me._debug_Result)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._debug_CloseBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _debug_CloseBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents _checkout_Btn As System.Windows.Forms.Button
    Friend WithEvents _mathResult_TxtBox As System.Windows.Forms.TextBox
    Friend WithEvents _math_equation As System.Windows.Forms.Label
    Friend WithEvents _debug_Result As System.Windows.Forms.Label

End Class
