Module CortexLayer

    ''' <summary>
    ''' Represent a table where a student can seat. You know, the thing usually with four feets in wood or plastic !
    ''' </summary>
    Public Class Place
        Public row As Byte
        Public col As Byte

        Sub New(row As Byte, col As Byte)
            Me.row = row
            Me.col = col
        End Sub

        ''' <summary>
        ''' The table number as on the room plan on excel.
        ''' </summary>
        ''' <returns>The name string of the place.</returns>
        Public Overrides Function ToString() As String
            Dim colChar As Char = Chr(col + Asc("A"))
            Return String.Format("{0}{1}", colChar, row + 1)
        End Function
    End Class

    ''' <summary>
    ''' Four walls. One table. Or more... and that's the point of this class
    ''' Represent a room with a way to get all real places and modify them
    ''' </summary>
    Public Class Room
        ' I swap them every fucking single time.......
        Dim ROW_AXE = 0
        Dim COL_AXE = 1

        ''' <summary>
        ''' A 2D array of all the possible places, a place that exists is represented by True.
        ''' A virtual place, which doesn't exists is either Nothing or False.
        ''' Do not manipulate this array directly, but use provided public functions to do so.
        ''' </summary>
        ''' <remarks>The first axe is the row and the second the column.</remarks>
        Protected availablePlaces(,) As Boolean

        ' Create a new room

        ''' <summary>
        ''' Create a new empty room with all places unavailable.
        ''' </summary>
        ''' <param name="rowNb">Number of rows</param>
        ''' <param name="colNb">Number of columns</param>
        Public Sub New(Optional rowNb As Byte = 5, Optional colNb As Byte = 4)
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
                        placesArray(numberOfPlaces) = New Place(row, col)
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

    ''' <summary>
    ''' This class represent a placement with mutiples classes and classrooms.
    ''' </summary>
    Public Class Placement
        ''' <summary>
        ''' The array of all Student Values files used to make the placement.
        ''' </summary>
        Dim svFilePaths As String()
        ''' <summary>
        ''' The array of all Desktop Disposition of rooms used for this exam.
        ''' </summary>
        Dim ddFilePaths As String()

        ' New 

        ''' <summary>
        ''' Creates a new placement with no room/students.
        ''' You MUST add them before doing anything.
        ''' </summary>
        Sub New()
            svFilePaths = {}
            ddFilePaths = {}
        End Sub
        ''' <summary>
        ''' Creates a new placement with one room and one class
        ''' </summary>
        ''' <param name="svFilePath">The students sv file path</param>
        ''' <param name="ddFilePath">The room dd file path</param>
        Sub New(svFilePath As String, ddFilePath As String)
            Me.New({svFilePath}, {ddFilePath})
        End Sub
        ''' <summary>
        ''' Create a new placement with two arrays of classes and classerooms.
        ''' </summary>
        ''' <param name="svFilePaths">An array with the pathes to the sv files.</param>
        ''' <param name="ddFilePaths">An array of the pathes to the dd files.</param>
        Sub New(svFilePaths As String(), ddFilePaths As String())
            Me.svFilePaths = svFilePaths
            Me.ddFilePaths = ddFilePaths
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

        ' Get placement 

        ''' <summary>
        ''' Make the placement and return one string of all the places.
        ''' </summary>
        ''' <remarks>The files must exist or an exception will be raised.</remarks>
        ''' <seealso cref="TryGetPlacementString(String)"/>
        Public Function GetPlacementString() As String

            Dim placementString As String = ""

            For Each stud In GetPlacementArray()
                placementString += stud.place.ToString & " " & stud.ToString()
                placementString += Environment.NewLine
            Next

            Return placementString
        End Function
        ''' <summary>
        ''' Make the placement and get one string of all the places.
        ''' A return value indicates wether it worked or not.
        ''' </summary>
        ''' <returns>True if it worked, else False.</returns>
        ''' <seealso cref="GetPlacementString()"/>
        Public Function TryGetPlacementString(placementString As String) As Boolean
            Try
                placementString = GetPlacementString()
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

        ''' <summary>
        ''' Get an array of students with Student.place set to their place in the rooms
        ''' </summary>
        ''' <returns>An array of placed Students</returns>
        Public Function GetPlacementArray() As Student()

            Dim students As Student() = {}
            Dim places As Place() = {}

            ' We get a list of students from each file, and concatenate them every times
            For Each svPath In Me.svFilePaths
                students = students.Union(DataAccessLayer.SV.GetStudents(svPath)).ToArray
            Next

            ' Likewise a list of the tables
            For Each ddPath In ddFilePaths
                places = places.Union(DataAccessLayer.DD.LoadRoom(ddPath).GetPlaces1DArray).ToArray
            Next

            Dim placementArray(Math.Min(students.GetUpperBound(0), places.GetUpperBound(0))) As Student

            For pos = 0 To Math.Min(places.GetUpperBound(0), students.GetUpperBound(0))
                students(pos).place = places(pos)
                placementArray(pos) = students(pos)
            Next

            Return placementArray
        End Function
        ''' <summary>
        ''' Get an array of students with Students.place set to their place in the rooms.
        ''' A return value indicate wether it worked or not.
        ''' </summary>
        ''' <param name="students">The variable that will be the list of students.</param>
        ''' <returns>True if it worked, else False.</returns>
        Public Function TryGetPlacementArray(ByRef students As Student()) As Boolean
            Try
                students = GetPlacementArray()
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function
    End Class

End Module
