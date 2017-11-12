Imports System.Text.RegularExpressions

Public Class AddStudentForm

    Private classes As Dictionary(Of String, ClassUnit)

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        If VerifyFirstName() And VerifyLastName() And VerifyStudentNumber() And VerifyClass() Then
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function VerifyFirstName() Handles FirstNameTextBox.LostFocus, FirstNameTextBox.TextChanged
        Dim valid

        If FirstNameTextBox.Text = "" Then
            valid = False
            FirstNameFailButton.Tag = "You need to enter a first name."
        ElseIf FirstNameTextBox.Text.Contains(",") Then
            valid = False
            FirstNameFailButton.Tag = "The name cannot contain any komma "",""."
        Else
            valid = True
        End If

        If valid Then
            FirstNameTextBox.ForeColor = Color.Black
            FirstNameFailButton.Visible = False
        Else
            FirstNameTextBox.ForeColor = Color.Red
            FirstNameFailButton.Visible = True
        End If

        Return valid

    End Function

    Private Sub FirstNameFailButton_Click(sender As Object, e As EventArgs) Handles FirstNameFailButton.Click
        MsgBox(FirstNameFailButton.Tag)
    End Sub

    Private Function VerifyLastName() As Boolean Handles LastNameTextBox.LostFocus, LastNameTextBox.TextChanged
        Dim valid

        If LastNameTextBox.Text = "" Then
            valid = False
            LastNameFailButton.Tag = "You need to enter a last name."
        ElseIf LastNameTextBox.Text.Contains(",") Then
            valid = False
            LastNameFailButton.Tag = "The name cannot contain any komma "",""."
        Else
            valid = True
        End If

        If valid Then
            LastNameTextBox.ForeColor = Color.Black
            LastNameFailButton.Visible = False
        Else
            LastNameTextBox.ForeColor = Color.Red
            LastNameFailButton.Visible = True
        End If

        Return valid

    End Function

    Private Sub LastNameFailButton_Click(sender As Object, e As EventArgs) Handles LastNameFailButton.Click
        MsgBox(LastNameFailButton.Tag)
    End Sub

    Private Function VerifyStudentNumber() As Boolean Handles StudentNumberTextBox.LostFocus, StudentNumberTextBox.TextChanged
        Dim valid = Regex.Match(StudentNumberTextBox.Text, "^[0-9]{8}[AEFGJLRTWX]$", RegexOptions.None).Success

        If valid Then
            StudentNumberTextBox.ForeColor = Color.Black
            StudentNumberFailButton.Visible = False
        Else
            StudentNumberTextBox.ForeColor = Color.Red
            StudentNumberFailButton.Visible = True
            StudentNumberFailButton.Tag = "The student number has 8 digits and one letter in ""AEFGJLRTWX""."
        End If

        Return valid

    End Function

    Private Sub StudentNumberFailButton_Click(sender As Object, e As EventArgs) Handles StudentNumberFailButton.Click
        MsgBox(StudentNumberFailButton.Tag)
    End Sub

    Public Sub SetPlacement(placement As Placement)

        Me.StudentNumberTextBox.Text = ""
        Me.LastNameTextBox.Text = ""
        Me.FirstNameTextBox.Text = ""
        Me.ClassComboBox.Text = ""

        Me.ClassFailButton.Visible = False
        Me.FirstNameFailButton.Visible = False
        Me.LastNameFailButton.Visible = False
        Me.StudentNumberFailButton.Visible = False

        ' Setting classes
        Dim classes As List(Of ClassUnit) = placement.students.GetStudentsByClass().Keys.ToList

        ' Add a class without a teacher for each subject if not already present
        For Each subj In placement.students.GetStudentsBySubject.Keys
            Dim defaultclass = New ClassUnit("", "", "", "", "", "", subj)
            If Not classes.Contains(defaultclass) Then
                classes.Add(defaultclass)
            End If
        Next

        Me.classes = New Dictionary(Of String, ClassUnit)
        For Each cls In classes
            Me.classes(cls.ToString) = cls
        Next

        Dim classesNames = Me.classes.Keys.ToList

        Me.ClassComboBox.Items.Clear()
        Me.ClassComboBox.Items.AddRange(classesNames.ToArray)

    End Sub

    ''' <summary>
    ''' Return the student entered while the form was open.
    ''' Considers that all data exists and is valid.
    ''' </summary>
    Public Function GetStudent() As Student
        Return New Student(StudentNumberTextBox.Text, LastNameTextBox.Text, FirstNameTextBox.Text, "", classes(ClassComboBox.Text))
    End Function

    Private Function VerifyClass() As Boolean Handles ClassComboBox.SelectedIndexChanged, ClassComboBox.LostFocus
        Dim valid = classes.ContainsKey(ClassComboBox.Text)

        If valid Then
            ClassComboBox.ForeColor = Color.Black
            ClassFailButton.Visible = False
        Else
            ClassComboBox.ForeColor = Color.Red
            ClassFailButton.Visible = True
        End If

        Return valid
    End Function

    Private Sub ClassFailButton_Click(sender As Object, e As EventArgs) Handles ClassFailButton.Click
        MsgBox(ClassFailButton.Tag)
    End Sub
End Class