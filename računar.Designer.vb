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
        Me.btnOduzimanje = New System.Windows.Forms.Button()
        Me.btnDjeljenje = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnMnozenje = New System.Windows.Forms.Button()
        Me.btnPotencija = New System.Windows.Forms.Button()
        Me.btnCDjeljenje = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.lblOperator = New System.Windows.Forms.TextBox()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOduzimanje
        '
        Me.btnOduzimanje.BackColor = System.Drawing.Color.Black
        Me.btnOduzimanje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOduzimanje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOduzimanje.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnOduzimanje.Location = New System.Drawing.Point(89, 83)
        Me.btnOduzimanje.Name = "btnOduzimanje"
        Me.btnOduzimanje.Size = New System.Drawing.Size(75, 47)
        Me.btnOduzimanje.TabIndex = 0
        Me.btnOduzimanje.Text = "-"
        Me.btnOduzimanje.UseVisualStyleBackColor = False
        '
        'btnDjeljenje
        '
        Me.btnDjeljenje.BackColor = System.Drawing.Color.Black
        Me.btnDjeljenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDjeljenje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDjeljenje.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDjeljenje.Location = New System.Drawing.Point(89, 139)
        Me.btnDjeljenje.Name = "btnDjeljenje"
        Me.btnDjeljenje.Size = New System.Drawing.Size(75, 47)
        Me.btnDjeljenje.TabIndex = 1
        Me.btnDjeljenje.Text = "/"
        Me.btnDjeljenje.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Black
        Me.btnADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnADD.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnADD.Location = New System.Drawing.Point(8, 83)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(75, 47)
        Me.btnADD.TabIndex = 2
        Me.btnADD.Text = "+"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btnMnozenje
        '
        Me.btnMnozenje.BackColor = System.Drawing.Color.Black
        Me.btnMnozenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMnozenje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMnozenje.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMnozenje.Location = New System.Drawing.Point(8, 139)
        Me.btnMnozenje.Name = "btnMnozenje"
        Me.btnMnozenje.Size = New System.Drawing.Size(75, 47)
        Me.btnMnozenje.TabIndex = 3
        Me.btnMnozenje.Text = "*"
        Me.btnMnozenje.UseVisualStyleBackColor = False
        '
        'btnPotencija
        '
        Me.btnPotencija.BackColor = System.Drawing.Color.Black
        Me.btnPotencija.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPotencija.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPotencija.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnPotencija.Location = New System.Drawing.Point(89, 187)
        Me.btnPotencija.Name = "btnPotencija"
        Me.btnPotencija.Size = New System.Drawing.Size(75, 47)
        Me.btnPotencija.TabIndex = 4
        Me.btnPotencija.Text = "^"
        Me.btnPotencija.UseVisualStyleBackColor = False
        '
        'btnCDjeljenje
        '
        Me.btnCDjeljenje.BackColor = System.Drawing.Color.Black
        Me.btnCDjeljenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCDjeljenje.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCDjeljenje.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCDjeljenje.Location = New System.Drawing.Point(8, 187)
        Me.btnCDjeljenje.Name = "btnCDjeljenje"
        Me.btnCDjeljenje.Size = New System.Drawing.Size(75, 47)
        Me.btnCDjeljenje.TabIndex = 5
        Me.btnCDjeljenje.Text = "\"
        Me.btnCDjeljenje.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.Black
        Me.btnMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMod.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnMod.Location = New System.Drawing.Point(59, 240)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 47)
        Me.btnMod.TabIndex = 6
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(34, 286)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 47)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(365, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 47)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtOperand1
        '
        Me.txtOperand1.BackColor = System.Drawing.Color.Black
        Me.txtOperand1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperand1.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperand1.ForeColor = System.Drawing.Color.Red
        Me.txtOperand1.Location = New System.Drawing.Point(326, 97)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(114, 26)
        Me.txtOperand1.TabIndex = 9
        '
        'lblOperator
        '
        Me.lblOperator.BackColor = System.Drawing.Color.Black
        Me.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblOperator.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.ForeColor = System.Drawing.Color.Red
        Me.lblOperator.Location = New System.Drawing.Point(365, 139)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.ReadOnly = True
        Me.lblOperator.Size = New System.Drawing.Size(42, 19)
        Me.lblOperator.TabIndex = 10
        '
        'txtOperand2
        '
        Me.txtOperand2.BackColor = System.Drawing.Color.Black
        Me.txtOperand2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperand2.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperand2.ForeColor = System.Drawing.Color.Red
        Me.txtOperand2.Location = New System.Drawing.Point(326, 182)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(114, 26)
        Me.txtOperand2.TabIndex = 11
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Black
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDisplay.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisplay.Location = New System.Drawing.Point(298, 229)
        Me.lblDisplay.MaxLength = 327674600
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.ReadOnly = True
        Me.lblDisplay.Size = New System.Drawing.Size(142, 19)
        Me.lblDisplay.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Operand 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Oprand 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Operation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Operators"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mistral", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(130, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "SIMPLE CALCULATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(461, 358)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtOperand1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnCDjeljenje)
        Me.Controls.Add(Me.btnPotencija)
        Me.Controls.Add(Me.btnMnozenje)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.btnDjeljenje)
        Me.Controls.Add(Me.btnOduzimanje)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOduzimanje As Button
    Friend WithEvents btnDjeljenje As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnMnozenje As Button
    Friend WithEvents btnPotencija As Button
    Friend WithEvents btnCDjeljenje As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents lblOperator As TextBox
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents lblDisplay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
