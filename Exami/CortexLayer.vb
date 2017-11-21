Imports Exami

Public Module CortexLayer

    ''' <summary>
    ''' Four walls. One table. Or more... and that's the point of this class: 
    ''' Represent a room with a way to get all real places and modify them
    ''' </summary>
    Public Class Room
        ' I swap them every fucking single time.......
        Private ROW_AXE = 0
        Private COL_AXE = 1

        Public name As String = ""

        ''' <summary>
        ''' A 2D array of all the possible places, a place that exists is represented by True.
        ''' A virtual place, which doesn't exists is either Nothing or False.
        ''' Do not manipulate this array directly, but use provided public functions to do so.
        ''' </summary>
        ''' <remarks>The first axe is the row and the second the column.</remarks>
        Public availablePlaces(,) As Boolean

        ' Create a new room

        Protected Sub New()

        End Sub
        ''' <summary>
        ''' Create a new empty room with all places unavailable.
        ''' </summary>
        ''' <param name="rowNb">Number of rows</param>
        ''' <param name="colNb">Number of columns</param>
        Public Sub New(rowNb As Byte, colNb As Byte)
            ReDim availablePlaces(rowNb - 1, colNb - 1)
        End Sub
        ''' <summary>
        ''' Create a room from a 2D-array of booleans.
        ''' </summary>
        ''' <param name="availables">A 2D-array of boolean representing the availaibility of a desktop.</param>
        Public Sub New(availables As Boolean(,))
            Me.availablePlaces = availables
        End Sub

        ''' <summary>
        ''' Create a new empty named room with all places unavailable.
        ''' </summary>
        ''' <param name="rowNb">Number of rows</param>
        ''' <param name="colNb">Number of columns</param>
        Public Sub New(rowNb As Byte, colNb As Byte, name As String)
            Me.New(rowNb, colNb)
            Me.name = name
        End Sub
        ''' <summary>
        ''' Create a named room from a 2D-array of booleans.
        ''' </summary>
        ''' <param name="availables">A 2D-array of boolean representing the availaibility of a desktop.</param>
        Public Sub New(availables As Boolean(,), name As String)
            Me.New(availables)
            Me.name = name
        End Sub

        ' Get / Set one place

        ''' <summary>
        ''' Return the availability of a place.
        ''' </summary>
        ''' <param name="row">The row number of the place. Starts at 0.</param>
        ''' <param name="col">The colomn number of the place. Starts at 0.</param>
        ''' <returns>True is the place exists else False.</returns>
        Public Function GetAvailable(row As Byte, col As Byte) As Boolean
            Return availablePlaces(row, col)
        End Function
        ''' <summary>
        ''' Sets the availability of one place/table.
        ''' </summary>
        ''' <param name="row">The row of the table.</param>
        ''' <param name="col">The col of the table.</param>
        ''' <param name="value">A boolean representing the availaibility of the table.</param>
        Protected Overridable Sub SetAvailable(row As Byte, col As Byte, value As Boolean)
            availablePlaces(row, col) = value
        End Sub

        ' Sets or change the availability of a rectangle

        ''' <summary>
        ''' Set all the places in the given rectangle as available, aka the are real existing places.
        ''' All boundaries are included. The order doesn't matter
        ''' </summary>
        ''' <param name="row1">One vertical boundary of the rectangle.</param>
        ''' <param name="col1">An horizontal boundary of the rectangle</param>
        ''' <param name="row2">The second Y boundary.</param>
        ''' <param name="col2">The second X boundary.</param>
        Public Sub SetRectangle(value As Boolean, row1 As Byte, col1 As Byte, row2 As Byte, col2 As Byte)
            If Not VerifyBox(row1, col1, row2, col2) Then
                Throw New ArgumentException("The box is not inside the room")
            End If

            For col = col1 To col2
                For row = row1 To row2
                    SetAvailable(row, col, value)
                Next
            Next

        End Sub
        ''' <summary>
        ''' Set all the places in the given rectangle as available, aka the are real existing places.
        ''' All boundaries are included. The order doesn't matter.
        ''' A return value indicates wether the set is successful or not.
        ''' </summary>
        ''' <param name="row1">One vertical boundary of the rectangle.</param>
        ''' <param name="col1">An horizontal boundary of the rectangle</param>
        ''' <param name="row2">The second Y boundary.</param>
        ''' <param name="col2">The second X boundary.</param>
        ''' <returns>True if it worked, else False.</returns>
        Public Function TrySetRectange(value As Boolean, row1 As Byte, col1 As Byte, row2 As Byte, col2 As Byte) As Boolean
            Try
                SetRectangle(value, row1, col1, row2, col2)
            Catch ex As ArgumentException
                Return False
            End Try
            Return True
        End Function

        ''' <summary>
        ''' Change the availability state of each place in the given rectangle.
        ''' All boundaries are included. The order doesn't matter.
        ''' </summary>
        ''' <param name="row1">One vertical boundary of the rectangle.</param>
        ''' <param name="col1">An horizontal boundary of the rectangle</param>
        ''' <param name="row2">The second Y boundary.</param>
        ''' <param name="col2">The second X boundary.</param>
        Public Sub ChangeAvailaible(row1 As Byte, col1 As Byte, row2 As Byte, col2 As Byte)
            If Not VerifyBox(row1, col1, row2, col2) Then
                Return
            End If

            For col = col1 To col2
                For row = row1 To row2
                    SetAvailable(row, col, Not availablePlaces(row, col))
                Next
            Next

        End Sub
        ''' <summary>
        ''' Change the availability state of each place in the given rectangle.
        ''' All boundaries are included. The order doesn't matter.
        ''' A return value indicates wether the change as succesfull of not.
        ''' </summary>
        ''' <param name="row1">One vertical boundary of the rectangle.</param>
        ''' <param name="col1">An horizontal boundary of the rectangle</param>
        ''' <param name="row2">The second Y boundary.</param>
        ''' <param name="col2">The second X boundary.</param>
        ''' <returns>True if the change worked else false.</returns>
        Public Function TryChangeAvailaible(row1 As Byte, col1 As Byte, row2 As Byte, col2 As Byte) As Boolean
            Try
                ChangeAvailaible(row1, col1, row2, col2)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        ' Verify boxes to change rectangles

        ''' <summary>
        ''' Verify that the boundaries given for a rectangle to change availabilities are valid : in the bounds
        ''' Flips the values of boundaries in order to have them in the right order (aka 1 \lt 2)
        ''' </summary>
        ''' <returns>The validity of the rect</returns>
        Public Function VerifyBox(ByRef row1 As Byte, ByRef col1 As Byte,
                                   ByRef row2 As Byte, ByRef col2 As Byte) As Boolean

            Dim ErrorMessage = "Fail, x1=" & row1.ToString & " y1=" & col1.ToString & " x2=" & row2.ToString & " y2=" & col2.ToString

            If IsNothing(row1) Or IsNothing(row2) Or IsNothing(col1) Or IsNothing(col2) Then
                Return False
            End If

            Dim temp As Byte

            ' swap coordinates to always have row1 < row2
            If row2 < row1 Then
                temp = row2
                row2 = row1
                row1 = temp
            End If

            ' swap coordinates to always have col1 < coly2
            If col2 < col1 Then
                temp = col1
                col1 = col2
                col2 = temp
            End If

            ' Verify that the rectangle is a sub rectangle of availablePlaces
            ' Vertcally
            If row1 < 0 Or row2 > availablePlaces.GetUpperBound(ROW_AXE) Then
                MsgBox("X  " & ErrorMessage)
                Return False
            End If

            ' Horizontaly
            If col1 < 0 Or col2 > availablePlaces.GetUpperBound(COL_AXE) Then
                MsgBox("Y  " & ErrorMessage)
                Return False
            End If

            Return True
        End Function

        ' Convert the array into 1 dimensional things

        ''' <summary>
        ''' Get an array of all the real places in the room, sorted by column then by row.
        ''' </summary>
        ''' <returns>An array of places.</returns>
        Public Function GetPlaces1DArray() As Place()
            Dim placesArray(availablePlaces.Length) As Place
            Dim numberOfPlaces As Short = -1

            For col = 0 To availablePlaces.GetUpperBound(COL_AXE)
                For row = 0 To availablePlaces.GetUpperBound(ROW_AXE)
                    If availablePlaces(row, col) Then
                        numberOfPlaces += 1
                        placesArray(numberOfPlaces) = New Place(row, col, name)
                    End If
                Next
            Next

            ReDim Preserve placesArray(numberOfPlaces)

            Return placesArray
        End Function
        ''' <summary>
        ''' Get a string with all the places for debuging purposes
        ''' </summary>
        Public Function GetPlacesNames() As String
            Dim places = GetPlaces1DArray()
            Dim placesNames = ""
            Dim pos = 0

            For Each place In places
                placesNames += places(pos).ToString
                placesNames += Environment.NewLine
                pos += 1
            Next

            Return placesNames

        End Function

        ' Get the sizes of the Room

        ''' <summary>
        ''' Get the index of the last row of the room, aka the number of row - 1
        ''' </summary>
        Public ReadOnly Property LastRow() As Byte
            Get
                Return availablePlaces.GetUpperBound(0)
            End Get
        End Property
        ''' <summary>
        ''' Get the index of the last column of the room, aka the number of columns - 1
        ''' </summary>
        Public ReadOnly Property LastColumn() As Byte
            Get
                Return availablePlaces.GetUpperBound(1)
            End Get
        End Property

    End Class

    Public Class StudentGroup

        Public allStudents As List(Of Student)

        ''' <summary>
        ''' Create a new empty group.
        ''' </summary>
        Sub New()
            allStudents = New List(Of Student)
        End Sub
        ''' <summary>
        ''' Create a new group reading in files.
        ''' </summary>
        ''' <param name="svFilePaths">A list of files to read the students from.</param>
        Sub New(svFilePaths As String())
            Me.allStudents = DataAccessLayer.SV.GetAllStudents(svFilePaths)
        End Sub
        ''' <summary>
        ''' Create a new group from a list of students.
        ''' </summary>
        ''' <param name="students"></param>
        Sub New(students As List(Of Student))
            Me.allStudents = students
        End Sub

        ' Categorize Students

        ''' <summary>
        ''' This function return students classified by whatever we pass for <paramref name="key"/>.
        ''' </summary>
        ''' <typeparam name="T">The type of the key.</typeparam>
        ''' <param name="key">The function that returns the key ofr a given student</param>
        ''' <returns>A dict of all the students categorized by ...</returns>
        Private Function GetBy(Of T)(key As Func(Of Student, T)) As Dictionary(Of T, StudentGroup)

            ' The return dict 
            Dim byT = New Dictionary(Of T, List(Of Student))
            ' shortcut so I don't need to recalculate the key for a given student each time
            Dim studKey As T

            For Each stud In allStudents
                ' The category of the student
                studKey = key(stud)

                ' If the category is in the dict
                If byT.ContainsKey(studKey) Then
                    ' We jsut add the student in it
                    byT(studKey).Add(stud)
                Else
                    ' Or we create a new one for this student
                    byT.Add(studKey, New List(Of Student)({stud}))
                End If
            Next

            ' We convert the lists of students into StudentGroup to allow easier reuse after

            Dim returnDict = New Dictionary(Of T, StudentGroup)
            For Each groupKey In byT.Keys
                returnDict(groupKey) = New StudentGroup(byT(groupKey))
            Next

            Return returnDict

        End Function

        ''' <summary>
        ''' Get the students categorized by their subjects.
        ''' </summary>
        ''' <returns>A dict with the subject as key and a list of the students for the corresponding subject as values.</returns>
        Public Function GetStudentsBySubject() As Dictionary(Of String, StudentGroup)

            Return GetBy(Of String)(Function(s As Student) As String
                                        Return s.classUnit.subject
                                    End Function)

        End Function
        ''' <summary>
        ''' Get the students categorized by their classes.
        ''' </summary>
        ''' <returns>A dict with the ClassUnit as key and a list of the students for the corresponding class as values.</returns>
        Public Function GetStudentsByClass() As Dictionary(Of ClassUnit, StudentGroup)

            Return GetBy(Of ClassUnit)(Function(s As Student) As ClassUnit
                                           Return s.classUnit
                                       End Function)

        End Function
        ''' <summary>
        ''' Get the students categorized by their rooms.
        ''' </summary>
        ''' <returns>A dict with the room name as key and a list of the students for the corresponding room as values.</returns>
        Public Function GetStudentsByRoom() As Dictionary(Of String, StudentGroup)

            Return GetBy(Of String)(Function(s As Student) As String
                                        Return s.place.room
                                    End Function)

        End Function

        ''' <summary>
        ''' Separate the students by subject and/or class and/or room (in this order) depending on the <paramref name="groupBy"/>.
        ''' </summary>
        ''' <param name="groupBy"></param>
        ''' <returns></returns>
        Public Function Separate(groupBy As GroupBy) As List(Of StudentGroup)
            Dim groupList = {Me}
            Dim tempGroupList = New List(Of StudentGroup)

            ' If we want to separate the subjects
            If groupBy And GroupBy.Subject Then
                ' For each differnet group (there will be only one here but anyway
                For Each group In groupList
                    ' We add the sub groups to the temp list
                    tempGroupList.AddRange(group.GetStudentsBySubject().Values)
                Next

                ' And then we override the group with the subgroups
                groupList = tempGroupList.ToArray
                tempGroupList.Clear()
            End If

            If groupBy And GroupBy.Classe Then
                For Each group In groupList
                    tempGroupList.AddRange(group.GetStudentsByClass.Values)
                Next
                groupList = tempGroupList.ToArray
                tempGroupList.Clear()
            End If

            If groupBy And GroupBy.Room Then
                For Each group In groupList
                    tempGroupList.AddRange(group.GetStudentsByRoom.Values)
                Next
                groupList = tempGroupList.ToArray
                tempGroupList.Clear()
            End If

            Return groupList.ToList

        End Function

        ' Order students (or not)

        ''' <summary>
        ''' Sort the student of this group by... RANDOOOOOOOM. Yes, it is a way of sorting !
        ''' </summary>
        Public Sub Shuffle()


            Dim last As Integer = allStudents.Count - 1
            Dim tempList = New List(Of Student)(last + 1)
            Dim done(last) As Boolean
            Dim r As New Random(My.Computer.Clock.TickCount)
            Dim n As Integer

            For i As Integer = 0 To last
                Do
                    n = r.Next(last + 1)
                Loop Until Not done(n)
                ' We get a random elt that has not been moved
                done(n) = 1
                ' and put it in order the out list
                tempList.Add(allStudents(n))
            Next
            allStudents = tempList

        End Sub
        ''' <summary>
        ''' Sort the students of this group alphabetically (by family name).
        ''' </summary>
        Public Sub Sort()
            allStudents.Sort(New Comparison(Of Student)(Function(s1, s2)
                                                            If s1.familyName = s2.familyName Then
                                                                Return s1.firstName.CompareTo(s2.firstName)
                                                            Else
                                                                Return s1.familyName.CompareTo(s2.familyName)
                                                            End If
                                                        End Function))
        End Sub

        Public Sub SortByNum()
            allStudents.Sort(New Comparison(Of Student)(Function(s1, s2)
                                                            Return s1.studentNumber.CompareTo(s2.studentNumber)
                                                        End Function))
        End Sub
        ' Wrapping methods

        ''' <summary>
        ''' Get the number of students in this group.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Count As Integer
            Get
                Return allStudents.Count
            End Get
        End Property

        ' 

        Public Function GetNameAs(by As GroupBy) As String
            Dim parts = New List(Of String)

            If by And GroupBy.Subject Then
                parts.Add(allStudents(0).classUnit.subject)
            End If

            If by And GroupBy.Classe Then
                parts.Add(allStudents(0).classUnit.GetTeacherFullName)
            End If

            If by And GroupBy.Room Then
                parts.Add(allStudents(0).place.room)
            End If

            If parts.Count > 0 Then
                Return String.Join(" - ", parts)
            Else
                Return "All"
            End If
        End Function

        ''' <summary>
        ''' Get a shallow copy of the group
        ''' </summary>
        Public Function Copy() As StudentGroup
            Return New StudentGroup(Me.allStudents.GetRange(0, Me.Count))
        End Function
    End Class

    Public Class SubPlacement
        Public places As List(Of Place)
        Public students As StudentGroup
        Public name As String

        Sub New(places As List(Of Place), students As StudentGroup, name As String)
            Me.places = places
            Me.students = students
            Me.name = name
        End Sub

        Sub New(group As StudentGroup, name As String)
            Me.students = group

            Dim places = New List(Of Place)

            For Each stud In students.allStudents
                places.Add(stud.place)
            Next

            Me.name = name
        End Sub

    End Class

    ''' <summary>
    ''' This class represent a placement with mutiples classes and classrooms.
    ''' You can allocate the seats with (Try)MakePlacement. 
    ''' 
    ''' The placed students are stored in paires in .placeMapping as the Table sctructure
    ''' The students left alone without places are in the StudentGroup at .notPlaced
    ''' The places left are in the list .placesLeft
    ''' </summary>
    Public Class Placement

        ' The idea is to have all the students places in placesLeft and notPlaced at the begining 
        ' And then to make pairs of place / student and add them to the placedMapping
        ' in different ways (class by class, teacher by teacher, shuffled)...
        ' removing them as they are used/placed
        ' Then the user can get a representation of the placement in the way he wants

        <Flags()>
        Enum Order
            None
            ShuffleClass
        End Enum

        ''' <summary>
        ''' The array of all not placed students
        ''' </summary>
        Public students As StudentGroup
        ''' <summary>
        ''' The places that doesn't have students in them.
        ''' </summary>
        Public places As List(Of Place)

        Private svFilePaths As String()
        Private ddFilePaths As String()

        ' New 

        ''' <summary>
        ''' Create a new placement with two arrays of classes and classerooms.
        ''' The students are placed only if you call {Try)MakePlacement.
        ''' </summary>
        ''' <param name="svFilePaths">An array with the pathes to the sv files.</param>
        ''' <param name="ddFilePaths">An array of the pathes to the dd files.</param>
        Sub New(svFilePaths As String(), ddFilePaths As String())
            Me.ddFilePaths = ddFilePaths
            Me.svFilePaths = svFilePaths

            Me.students = New StudentGroup(svFilePaths)
            Me.places = DataAccessLayer.DD.LoadAllPlaces1D(ddFilePaths)
        End Sub
        ''' <summary>
        ''' Create a new placement.
        ''' </summary>
        ''' <param name="students">Group of not placed students</param>
        ''' <param name="places">List of not used places</param>
        Sub New(students As StudentGroup, places As List(Of Place))
            Me.students = students
            Me.places = places
        End Sub

        ' Make the placement

        ''' <summary>
        ''' Associate places to students
        ''' The place of a student can be now found at student.place
        ''' The order of places means nothing and the only way to know a place is the above.
        ''' </summary>
        Public Sub MakePlacement(Sort As SortBy, groupByClass As Boolean, snake As Boolean)

            ' We really want to have enough places
            If students.Count > places.Count Then
                Throw New OverflowException("There is more students than places")
            End If

            ' Sort everything
            Me.students.Sort()
            If snake Then
                Place.SnakeSort(places)
            Else
                Me.places.Sort()   ' The regular place sorting is top to back
            End If


            Dim GroupBy As GroupBy
            If groupByClass Then
                GroupBy = GroupBy.Subject Or GroupBy.Classe
            Else
                GroupBy = GroupBy.Subject
            End If

            ' We group the students as requiered and associate places 
            ' as we go

            Dim groups = Me.students.Separate(GroupBy)

            Dim pos = 0
            For Each group In groups
                Dim placesForThisGroup = places.GetRange(pos, group.Count)

                If Sort = SortBy.Name Then
                    ' Nothing to do, it's already sorded
                ElseIf Sort = SortBy.Number Then
                    group.SortByNum()
                ElseIf Sort = SortBy.Shuffle Then
                    Helper.Shuffle(placesForThisGroup)
                End If

                For groupPos = 0 To group.Count - 1
                    ' Asociate both
                    group.allStudents(groupPos).place = placesForThisGroup(groupPos)
                    placesForThisGroup(groupPos).student = group.allStudents(groupPos)
                    pos += 1
                Next
            Next

        End Sub
        ''' <summary>
        ''' Give the places left to the students that deosn't have one. 
        ''' A return value indicates wether it worked or not.
        ''' </summary>
        ''' <returns>True if the placement was effected else false.</returns>
        Public Function TryMakePlacement(sort As SortBy, groupByClass As Boolean, snake As Boolean) As Boolean
            Try
                MakePlacement(sort, groupByClass, snake)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        Function Reseted() As Placement
            Return New Placement(Me.students.Copy, Me.places.ToList())
        End Function
    End Class

End Module
