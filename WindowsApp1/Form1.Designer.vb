<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.LblFirstname = New System.Windows.Forms.Label()
        Me.LblLastname = New System.Windows.Forms.Label()
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.ChkNewsletter = New System.Windows.Forms.CheckBox()
        Me.ChkMailinglist = New System.Windows.Forms.CheckBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.RdoFulltime = New System.Windows.Forms.RadioButton()
        Me.RdoParttime = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblFirstname
        '
        Me.LblFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFirstname.ForeColor = System.Drawing.Color.Blue
        Me.LblFirstname.Location = New System.Drawing.Point(12, 26)
        Me.LblFirstname.Name = "LblFirstname"
        Me.LblFirstname.Size = New System.Drawing.Size(106, 28)
        Me.LblFirstname.TabIndex = 0
        Me.LblFirstname.Text = "First Name :"
        '
        'LblLastname
        '
        Me.LblLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastname.ForeColor = System.Drawing.Color.Blue
        Me.LblLastname.Location = New System.Drawing.Point(12, 78)
        Me.LblLastname.Name = "LblLastname"
        Me.LblLastname.Size = New System.Drawing.Size(96, 18)
        Me.LblLastname.TabIndex = 0
        Me.LblLastname.Text = "Last Name :"
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Location = New System.Drawing.Point(100, 28)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(138, 20)
        Me.TxtFirstname.TabIndex = 1
        Me.TxtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtLastname
        '
        Me.TxtLastname.Location = New System.Drawing.Point(100, 76)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(137, 20)
        Me.TxtLastname.TabIndex = 2
        Me.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkNewsletter
        '
        Me.ChkNewsletter.AutoSize = True
        Me.ChkNewsletter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNewsletter.Location = New System.Drawing.Point(146, 122)
        Me.ChkNewsletter.Name = "ChkNewsletter"
        Me.ChkNewsletter.Size = New System.Drawing.Size(91, 21)
        Me.ChkNewsletter.TabIndex = 5
        Me.ChkNewsletter.Text = "NewLetter"
        Me.ChkNewsletter.UseVisualStyleBackColor = True
        '
        'ChkMailinglist
        '
        Me.ChkMailinglist.AutoSize = True
        Me.ChkMailinglist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMailinglist.Location = New System.Drawing.Point(146, 145)
        Me.ChkMailinglist.Name = "ChkMailinglist"
        Me.ChkMailinglist.Size = New System.Drawing.Size(97, 21)
        Me.ChkMailinglist.TabIndex = 6
        Me.ChkMailinglist.Text = "Mailing List"
        Me.ChkMailinglist.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(244, 26)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 28)
        Me.BtnPrint.TabIndex = 7
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(244, 78)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 30)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "&Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(244, 137)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(75, 29)
        Me.BtnQuit.TabIndex = 9
        Me.BtnQuit.Text = "&Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'RdoFulltime
        '
        Me.RdoFulltime.AutoSize = True
        Me.RdoFulltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoFulltime.Location = New System.Drawing.Point(15, 121)
        Me.RdoFulltime.Name = "RdoFulltime"
        Me.RdoFulltime.Size = New System.Drawing.Size(83, 21)
        Me.RdoFulltime.TabIndex = 3
        Me.RdoFulltime.TabStop = True
        Me.RdoFulltime.Text = "Full Time"
        Me.RdoFulltime.UseVisualStyleBackColor = True
        '
        'RdoParttime
        '
        Me.RdoParttime.AutoSize = True
        Me.RdoParttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoParttime.Location = New System.Drawing.Point(15, 144)
        Me.RdoParttime.Name = "RdoParttime"
        Me.RdoParttime.Size = New System.Drawing.Size(88, 21)
        Me.RdoParttime.TabIndex = 4
        Me.RdoParttime.TabStop = True
        Me.RdoParttime.Text = "Part-Time"
        Me.RdoParttime.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(15, 184)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(304, 82)
        Me.lblResult.TabIndex = 7
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BtnQuit
        Me.ClientSize = New System.Drawing.Size(347, 287)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.RdoParttime)
        Me.Controls.Add(Me.RdoFulltime)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.ChkMailinglist)
        Me.Controls.Add(Me.ChkNewsletter)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.LblLastname)
        Me.Controls.Add(Me.LblFirstname)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Learning To Program In VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFirstname As Label
    Friend WithEvents LblLastname As Label
    Friend WithEvents TxtFirstname As TextBox
    Friend WithEvents TxtLastname As TextBox
    Friend WithEvents ChkNewsletter As CheckBox
    Friend WithEvents ChkMailinglist As CheckBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnQuit As Button
    Friend WithEvents RdoFulltime As RadioButton
    Friend WithEvents RdoParttime As RadioButton
    Friend WithEvents lblResult As Label
End Class
