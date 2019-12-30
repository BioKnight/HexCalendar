<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.lblSunday = New System.Windows.Forms.Label()
        Me.lblMonday = New System.Windows.Forms.Label()
        Me.lblTuesday = New System.Windows.Forms.Label()
        Me.lblWednesday = New System.Windows.Forms.Label()
        Me.lblThursday = New System.Windows.Forms.Label()
        Me.lblFriday = New System.Windows.Forms.Label()
        Me.lblSaturday = New System.Windows.Forms.Label()
        Me.lbl_Month = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSunday
        '
        Me.lblSunday.BackColor = System.Drawing.Color.Transparent
        Me.lblSunday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSunday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSunday.Location = New System.Drawing.Point(3, 34)
        Me.lblSunday.Name = "lblSunday"
        Me.lblSunday.Size = New System.Drawing.Size(163, 30)
        Me.lblSunday.TabIndex = 0
        Me.lblSunday.Text = "Sunday"
        Me.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonday
        '
        Me.lblMonday.BackColor = System.Drawing.Color.Transparent
        Me.lblMonday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonday.Location = New System.Drawing.Point(163, 34)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(160, 30)
        Me.lblMonday.TabIndex = 1
        Me.lblMonday.Text = "Monday"
        Me.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTuesday
        '
        Me.lblTuesday.BackColor = System.Drawing.Color.Transparent
        Me.lblTuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuesday.Location = New System.Drawing.Point(323, 34)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(160, 30)
        Me.lblTuesday.TabIndex = 2
        Me.lblTuesday.Text = "Tuesday"
        Me.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWednesday
        '
        Me.lblWednesday.BackColor = System.Drawing.Color.Transparent
        Me.lblWednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWednesday.Location = New System.Drawing.Point(483, 34)
        Me.lblWednesday.Name = "lblWednesday"
        Me.lblWednesday.Size = New System.Drawing.Size(160, 30)
        Me.lblWednesday.TabIndex = 3
        Me.lblWednesday.Text = "Wednesday"
        Me.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThursday
        '
        Me.lblThursday.BackColor = System.Drawing.Color.Transparent
        Me.lblThursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThursday.Location = New System.Drawing.Point(643, 34)
        Me.lblThursday.Name = "lblThursday"
        Me.lblThursday.Size = New System.Drawing.Size(160, 30)
        Me.lblThursday.TabIndex = 4
        Me.lblThursday.Text = "Thursday"
        Me.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFriday
        '
        Me.lblFriday.BackColor = System.Drawing.Color.Transparent
        Me.lblFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriday.Location = New System.Drawing.Point(803, 34)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(160, 30)
        Me.lblFriday.TabIndex = 5
        Me.lblFriday.Text = "Friday"
        Me.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaturday
        '
        Me.lblSaturday.BackColor = System.Drawing.Color.Transparent
        Me.lblSaturday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaturday.Location = New System.Drawing.Point(963, 34)
        Me.lblSaturday.Name = "lblSaturday"
        Me.lblSaturday.Size = New System.Drawing.Size(160, 30)
        Me.lblSaturday.TabIndex = 6
        Me.lblSaturday.Text = "Saturday"
        Me.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Month
        '
        Me.lbl_Month.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Month.Location = New System.Drawing.Point(103, 1)
        Me.lbl_Month.Name = "lbl_Month"
        Me.lbl_Month.Size = New System.Drawing.Size(776, 30)
        Me.lbl_Month.TabIndex = 7
        Me.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(3, -1)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(34, 32)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1080, -1)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(34, 32)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'nudYear
        '
        Me.nudYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudYear.Location = New System.Drawing.Point(885, 1)
        Me.nudYear.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 30)
        Me.nudYear.TabIndex = 11
        Me.nudYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 806)
        Me.ControlBox = False
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lbl_Month)
        Me.Controls.Add(Me.lblSaturday)
        Me.Controls.Add(Me.lblFriday)
        Me.Controls.Add(Me.lblThursday)
        Me.Controls.Add(Me.lblWednesday)
        Me.Controls.Add(Me.lblTuesday)
        Me.Controls.Add(Me.lblMonday)
        Me.Controls.Add(Me.lblSunday)
        Me.MaximumSize = New System.Drawing.Size(1144, 824)
        Me.MinimumSize = New System.Drawing.Size(1144, 824)
        Me.Name = "frm_Main"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSunday As Label
    Friend WithEvents lblMonday As Label
    Friend WithEvents lblTuesday As Label
    Friend WithEvents lblWednesday As Label
    Friend WithEvents lblThursday As Label
    Friend WithEvents lblFriday As Label
    Friend WithEvents lblSaturday As Label
    Friend WithEvents lbl_Month As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents nudYear As NumericUpDown
End Class
