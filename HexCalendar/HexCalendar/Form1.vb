Public Class frm_Main
    Private strMonth As String
    Private strYear As String
    Private intDays As Integer
    Private intMonth As months
    Private intYear As Integer
    Private sizeLabel As New Size(120, 100)


    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        intYear = DateTime.Now.Year
        strYear = intYear.ToString

        intMonth = DateTime.Now.Month
        strMonth = Application.CurrentCulture.DateTimeFormat.GetMonthName(intMonth)

        intDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)

        lbl_Month.Text = strMonth
        nudYear.Value = intYear

        fillDays()

    End Sub
    Private Function tohex(number As Integer) As String
        'convert into hexadecimal 
        Dim hexString As String = Hex(number)
        Return hexString
    End Function
    Private Enum daysOfWeek As Integer
        Sunday = 1
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum
    Private Enum months As Integer
        January = 1
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        December
    End Enum
    Private Function checkStart() As daysOfWeek
        Dim day As DateTime = Convert.ToDateTime(strMonth + "/01/" + strYear)
        Return daysOfWeek.Parse(GetType(daysOfWeek), Application.CurrentCulture.Calendar.GetDayOfWeek(day).ToString())
    End Function
    Public Function getLastDayofMonth() As Integer
        Return Application.CurrentCulture.Calendar.GetDaysInMonth(strYear, DateTime.Now.Month)
    End Function
    Private Sub fillDays()
        Dim locStart As New Point(2, 53)
        Dim boolCountStart As Boolean = False
        Dim enmday As daysOfWeek = daysOfWeek.Parse(GetType(daysOfWeek), "Sunday")
        Dim intRow As Integer = 1
        Dim intDay As Integer = 1

        For intLblCount As Integer = 1 To (6 * 7)

            If enmday > 7 Then
                intRow += 1
                enmday = 1
            End If
            If intRow = 1 And checkStart() = enmday Then boolCountStart = True
            If boolCountStart Then
                'Me.Controls.Add(createlblDay(intDay, sizeLabel, New Point(locStart.X + (sizeLabel.Width * (enmday - 1)), locStart.Y + (sizeLabel.Height * (intRow - 1)))))
                Me.Controls.Add(createlblDay(tohex(intDay), sizeLabel, New Point(locStart.X + (sizeLabel.Width * (enmday - 1)), locStart.Y + (sizeLabel.Height * (intRow - 1)))))
                intDay += 1
                If intDay > intDays Then boolCountStart = False

            Else
                Me.Controls.Add(createlblDay(vbNullString, sizeLabel, New Point(locStart.X + (sizeLabel.Width * (enmday - 1)), locStart.Y + (sizeLabel.Height * (intRow - 1)))))
            End If

            enmday += 1
        Next
    End Sub
    Private Sub removeDays()
        Dim ctrlList As New List(Of Control)
        For Each ctrl As Control In Me.Controls
            If ctrl.Size = sizeLabel Then ctrlList.Add(ctrl)
        Next
        For Each ctrl In ctrlList
            Me.Controls.Remove(ctrl)
        Next
    End Sub
    Private Sub changeMonth(value As Integer)
        If intMonth = 12 And value = 1 Then
            intMonth = 1
            intYear += 1
        ElseIf intMonth = 1 And value = -1 Then
            intMonth = 12
            intYear -= 1
        Else
            intMonth += value
        End If

        strMonth = Application.CurrentCulture.DateTimeFormat.GetMonthName(intMonth)
        lbl_Month.Text = strMonth
        nudYear.Value = intYear
        intDays = DateTime.DaysInMonth(intYear, intMonth)
        strYear = intYear.ToString

        removeDays()
        fillDays()

    End Sub
    Private Sub changeYear(value As Integer)
        Try
            intYear = value
            strYear = intYear.ToString

            intDays = DateTime.DaysInMonth(intYear, intMonth)

            removeDays()
            fillDays()
        Catch ex As Exception

        End Try
    End Sub
    Private Function createlblDay(day As String, labelsize As Size, labellocation As Point) As Label
        Dim lbl As New Label
        If Not (day = vbNullString) Then lbl.Name = "Day_" & day
        lbl.Size = labelsize
        lbl.Location = labellocation
        lbl.Text = day
        lbl.BorderStyle = BorderStyle.FixedSingle
        lbl.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
        lbl.BackColor = Color.Transparent
        AddHandler lbl.KeyDown, AddressOf frm_Main_KeyDown
        AddHandler lbl.Click, AddressOf addCalendarEvent
        Return lbl
    End Function
    Private Sub frm_Main_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious.KeyDown, lbl_Month.KeyDown, nudYear.KeyDown, btnNext.KeyDown, lblSunday.KeyDown, lblMonday.KeyDown, lblTuesday.KeyDown, lblWednesday.KeyDown, lblThursday.KeyDown, lblFriday.KeyDown, lblSaturday.KeyDown
        If e.KeyCode = Keys.Escape Then End
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        changeMonth(-1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        changeMonth(1)
    End Sub
    Private Sub nudYear_ValueChanged(sender As Object, e As EventArgs) Handles nudYear.ValueChanged
        changeYear(sender.value)
    End Sub

    Private Sub addCalendarEvent(sender As Object, e As EventArgs)

    End Sub
End Class
