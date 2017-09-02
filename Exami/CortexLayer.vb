Imports Exami

Public Module CortexLayer

    ''' <summary>
    ''' Represent a table where a student can seat. You know, the thing usually with four feets in wood or plastic !
    ''' </summary>
    Public Class Place
        Implements IComparable(Of Place)

        Public row As Byte
        Public col As Byte
        Public room As String = ""

        Sub New(row As Byte, col As Byte)
            Me.row = row
            Me.col = col
        End Sub

        Sub New(row As Byte, col As Byte, room As String)
            Me.row = row
            Me.col = col
            Me.room = room
        End Sub

        ''' <summary>
        ''' The table number as on the room plan on excel.
        ''' </summary>
        ''' <returns>The name string of the place.</returns>
        Public Overrides Function ToString() As String
            Dim colChar As Char = Chr(col + Asc("A"))
            Return String.Format("{0}{1}", colChar, row + 1)
        End Function

        Public Function CompareTo(other As Place) As Integer Implements IComparable(Of Place).CompareTo
            If room <> other.room Then
                Return room.CompareTo(other.room)
            End If

            If col <> other.col Then
                Return col.CompareTo(other.col)
            End If

            Return row.CompareTo(other.row)
        End Function
    End Class

    ''' <summary>
    ''' Four walls. One table. Or more... and that's the point of this class
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
        Protected availablePlaces(,) As Boolean

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
            ' The two arrays have the same size now.
            ReDim availablePlaces(availables.GetUpperBound(0), availables.GetUpperBound(1))

            For row = 0 To availables.GetUpperBound(0)
                For col = 0 To availables.GetUpperBound(1)
                    SetAvailable(row, col, availables(row, col))
                Next
            Next

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
                                                                Return s1.firstName <= s2.firstName
                                                            Else
                                                                Return s1.familyName <= s2.familyName
                                                            End If
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

    End Class

    Public Structure Table
        Public place As Place
        Public student As Student

        Sub New(student As Student, place As Place)
            Me.place = place
            Me.student = student
        End Sub
        Sub New(place As Place, student As Student)
            Me.place = place
            Me.student = student
        End Sub
    End Structure



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
        ''' The array of all placed students. They will have their .place set.
        ''' </summary>
        Public placedMapping As List(Of Table)
        ''' <summary>
        ''' The array of all not placed students
        ''' </summary>
        Public notPlaced As StudentGroup
        ''' <summary>
        ''' The places that doesn't have students in them.
        ''' </summary>
        Public placesLeft As List(Of Place)

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

            Me.Reset()
        End Sub
        ''' <summary>
        ''' Reloads all the students and places from the files and put them all as not placed/occupied
        ''' </summary>
        Public Sub Reset()
            Me.placedMapping = New List(Of Table)
            Me.notPlaced = New StudentGroup(svFilePaths)
            Me.placesLeft = DataAccessLayer.DD.LoadAllPlaces1D(ddFilePaths)
        End Sub

        ' Make the placement

        ''' <summary>
        ''' Give the places left to the students that deosn't have one
        ''' </summary>
        Public Sub MakePlacement(Optional order As Order = Order.None)

            Dim studentOverFlow = New List(Of Student)

            SortPlacesByRoom()

            ' For each subject in non placed students
            For Each subject In notPlaced.GetStudentsBySubject.Values

                ' For each class in each subject
                For Each clss In subject.GetStudentsByClass.Values

                    ' We shuffle or sort the class if we want
                    If order.HasFlag(Order.ShuffleClass) Then
                        clss.Shuffle()
                    Else
                        clss.Sort()
                    End If

                    ' We place each student 
                    For Each stud In clss.allStudents

                        ' If all places are used, add the guy in the loosers
                        If placesLeft.Count = 0 Then
                            studentOverFlow.Add(stud)
                        Else
                            ' We take the first place in the list and remove it from the unused ones
                            Dim place = placesLeft(0)
                            placesLeft.RemoveAt(0)

                            ' We add the pair to the placed list
                            placedMapping.Add(New Table(stud, place))
                        End If
                    Next
                Next
            Next

            notPlaced = New StudentGroup(studentOverFlow)

        End Sub
        ''' <summary>
        ''' Give the places left to the students that deosn't have one. 
        ''' A return value indicates wether it worked or not.
        ''' </summary>
        ''' <returns>True if the placement was effected else false.</returns>
        Public Function TryMakePlacement(Optional order As Order = Order.None) As Boolean
            Try
                MakePlacement(order)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        ' Get placement representations

        ''' <summary>
        ''' Get a string version of the full placement without any header or separations. Just a bare list of places and their students 
        ''' The placement must be already made. Call (Try)MakePlacement to do it.
        ''' </summary>
        ''' <remarks>The files must exist or an exception will be raised.</remarks>
        Public Function GetPlacementString() As String

            Dim placementString As String = ""

            For Each table In placedMapping
                placementString += table.place.ToString & " " & table.student.ToString()
                placementString += Environment.NewLine
            Next

            Return placementString
        End Function
        Public Function GetPlacementFormatedString() As String
            Dim placementStr As String = ""
            Dim room As String = "Salomé <3"
            Dim subject As String = "Diegooo :*"
            Dim teacher As String = "Joshhhh :D"

            For Each table In placedMapping

                'If there is a changement of category

                If room <> table.place.room Then
                    room = table.place.room
                    placementStr += Environment.NewLine & String.Format("   {0}   ", room) & Environment.NewLine & Environment.NewLine
                End If
                If subject <> table.student.classUnit.subject Then
                    subject = table.student.classUnit.subject
                    placementStr += Environment.NewLine & String.Format("  {0}  ", subject) & Environment.NewLine & Environment.NewLine
                End If
                If teacher <> table.student.classUnit.GetTeacherFullName Then
                    teacher = table.student.classUnit.GetTeacherFullName
                    placementStr += String.Format(" {0} ", teacher) & Environment.NewLine
                End If

                placementStr += table.place.ToString & " " & table.student.ToString & Environment.NewLine

            Next

            Return placementStr

        End Function

        ' Sort Places

        ''' <summary>
        ''' Sorts placesLeft so places of the same room are together
        ''' </summary>
        Public Sub SortPlacesByRoom()
            Dim mapping = New Dictionary(Of String, List(Of Place))

            For Each p In placesLeft
                If mapping.ContainsKey(p.room) Then
                    mapping(p.room).Add(p)
                Else
                    mapping(p.room) = New List(Of Place)({p})
                End If
            Next

            ' We reintialise the places
            placesLeft = New List(Of Place)

            ' Add add each room one by one
            For Each key In mapping.Keys
                Dim places = mapping(key)
                places.Sort()
                placesLeft.AddRange(places)
            Next

        End Sub

        ' Save

        ''' <summary>
        ''' Save a human readable copy of the placement.
        ''' </summary>
        ''' <param name="filePath"></param>
        Sub Save(filePath As String)
            IO.File.WriteAllText(filePath, GetPlacementString())
        End Sub
        ''' <summary>
        ''' Save a human readable copy of the placement.
        ''' </summary>
        ''' <param name="filePath"></param>
        Public Function TrySave(filePath As String) As Boolean
            Try
                Save(filePath)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        ' Get all students

        ''' <summary>
        ''' Get all the students in a 1D list. You can not suppose they are sorted, either by class or by name or by number of hair.
        ''' </summary>
        ''' <returns>A list of the students in every sv file of the Placement.</returns>
        Public Function GetAllStudents() As List(Of Student)
            Dim allStudents = New List(Of Student)

            For Each table In placedMapping
                allStudents.Add(table.student)
            Next
            allStudents.AddRange(notPlaced)

            Return allStudents

        End Function

    End Class

End Module
