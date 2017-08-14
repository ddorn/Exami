Module DataAccessLayer

    ' Order : unitCode, studendNumber, familyName, firstName, secondName
    ' In an .sf file   : 0,  1,  2,  3,  4
    ' In a .vass file  : 0, 16, 18, 18, 19

    Enum SvKeys
        unitCode = 0
        studentNumber = 1
        familyName = 2
        firstName = 3
        secondName = 4
    End Enum

    Enum VassKeys
        unitCode = 0
        studentNumber = 16
        familyName = 17
        firstName = 18
        secondName = 19
    End Enum

    ''' <summary>
    ''' Me. Or anybody else that will pass their exam. Gut luck man !
    ''' </summary>
    Class Student
        Public familyName As String
        Public firstName As String
        Public secondName As String
        Public unitCode As String
        Public studentNumber As String
        Public place As Place

        Sub New(unitCode, studentNumber, familyName, firstName, secondName)
            With Me
                .unitCode = unitCode
                .studentNumber = studentNumber
                .familyName = familyName
                .firstName = firstName
                .secondName = secondName
            End With
        End Sub

        ' Parsing from .sv

        ''' <summary>
        ''' Create a Student object from a .sv file line.
        ''' </summary>
        ''' <param name="line">The .sv line to convert.</param>
        ''' <exception cref="ArgumentException">If line is empty or doesen't have sufficent values separated by kommas.</exception>
        ''' <exception cref="ArgumentNullException">If the line is Nothing.</exception>
        ''' <returns>A student representing the line.</returns>
        Public Shared Function ParseFromSv(line As String) As Student
            If line Is Nothing Then
                Throw New ArgumentNullException("The line cannot be Nothing")
            End If

            Dim fields = line.Split(",")
            If fields.Length <> 5 Then
                Throw New ArgumentException("There is not 5 values in the line, it is not a student.")
            End If

            Return New Student(fields(SvKeys.unitCode),
                               fields(SvKeys.studentNumber),
                               fields(SvKeys.familyName),
                               fields(SvKeys.firstName),
                               fields(SvKeys.secondName))
        End Function
        ''' <summary>
        ''' Create a Student object from a .sv file line. A return value indicates wether the convertion succeded or failed.
        ''' </summary>
        ''' <param name="line">The .sv line to convert.</param>
        ''' <returns>True if the convertion succeded, else False.</returns>
        Public Shared Function TryParseFormSv(line As String, ByRef student As Student) As Boolean
            Try
                student = ParseFromSv(line)
            Catch ex As ArgumentException
                Return False
            End Try
            Return True
        End Function

        ' Parsing form .vass

        ''' <summary>
        ''' Create a Student object from a .vass file line.
        ''' </summary>
        ''' <param name="line">The .vass line to convert.</param>
        ''' <exception cref="ArgumentException">If line is empty or doesen't have sufficent values separated by pipes (|).</exception>
        ''' <exception cref="ArgumentNullException">If the line is Nothing.</exception>
        ''' <returns>A student representing the line</returns>
        Public Shared Function ParseFromVass(line As String) As Student
            Dim fields As String()
            Dim returnString As String = ""

            ' We don't want any empty line !
            If line = "" Then
                Throw New ArgumentException("The line cannot by an empty string.")
            End If
            If line Is Nothing Then
                Throw New ArgumentNullException("The line cannot be nothing.")
            End If

            ' We separate the diferents f.ields
            fields = line.Split("|")

            ' We don't want a non value line (like the last ones of vass files)
            If fields.Length < 19 Then
                Throw New ArgumentException("The line doesn't represent a student.")
            End If


            Return New Student(fields(VassKeys.unitCode),
                               fields(VassKeys.studentNumber),
                               fields(VassKeys.familyName),
                               fields(VassKeys.firstName),
                               fields(VassKeys.secondName))
        End Function
        ''' <summary>
        ''' Create a Student object from a .vass file line. A return value indicates wether the convertion succeded or failed.
        ''' </summary>
        ''' <param name="line">The .vass line to convert.</param>
        ''' <returns>True if the convertion succeded, else False.</returns>
        Public Shared Function TryParseFromVass(line As String, ByRef student As Student) As Boolean
            Try
                student = ParseFromVass(line)
            Catch ex As ArgumentException
                Return False
            End Try
            Return True
        End Function

        ' Convert to .sv

        ''' <summary>
        ''' Convert a student to a .sv line fully representing him.
        ''' </summary>
        ''' <exception cref="ArgumentNullException">If not all atributes are set.</exception>
        ''' <returns>The .sv line.</returns>
        Function ToSvLine() As String
            Return String.Join(",", {unitCode, studentNumber, familyName, firstName, secondName})
        End Function

        ' Readable version

        ''' <summary>
        ''' Get a string with the family and first name of the student.
        ''' </summary>
        ''' <exception cref="ArgumentNullException">If familyName or firstName is Nothing</exception>
        Overrides Function ToString() As String
            Return String.Format("{0} {1}", familyName, firstName)
        End Function
    End Class


    ''' <summary>
    ''' A class to manipulate .sv files, extract, convert and save content
    ''' </summary>
    Class SV

        Private Sub New()
            ' Singleton
        End Sub

        ''' <summary>
        ''' Get an array of all the students present in a the selected .sv file
        ''' </summary>
        ''' <param name="svFilePath">The file to exctract students from</param>
        ''' <exception cref="IO.FileNotFoundException">The file does not exist.</exception>
        ''' <returns>The array of the students</returns>
        Shared Function GetStudents(svFilePath As String) As Student()
            ' What is not allowed to read ?
            If Not IO.File.Exists(svFilePath) Then
                Throw New IO.FileNotFoundException("The sv file must exist.")
            End If

            Dim pos As Short
            Dim lines As String() = IO.File.ReadAllLines(svFilePath)

            ' It is -2 because of the header and the last blank line
            Dim Students = New List(Of Student)(lines.Length - 2)
            Dim stud As Student

            ' -1 cos we skip the first line and then it is zero and it is aligned with the indices of Students
            pos = -1
            For Each line In lines
                ' We ignore the header and the last blanck line
                If pos <> -1 And pos <> lines.GetUpperBound(0) Then
                    'If we can parse the line
                    If Student.TryParseFormSv(line, stud) Then
                        ' We add it to the list
                        Students.Add(Student.ParseFromSv(line))
                    End If
                End If
                pos += 1
            Next

            Return Students.ToArray
        End Function
        ''' <summary>
        ''' Get an array of all the students present in a the selected .sv file.
        ''' A return value indicates wether the convertion succeded or failed.
        ''' </summary>
        ''' <param name="svFilePath">The file to exctract students from</param>
        ''' <param name="students">The student array where the students will be loaded.</param>
        ''' <returns>Wether the convertion succeded or failed.</returns>
        Shared Function TryGetStudents(svFilePath As String, ByRef students As Student()) As Boolean
            Try
                students = GetStudents(svFilePath)
            Catch ex As Exception
                Debug.WriteLine(String.Format("Unable to load students from {0}. Exception {1}", svFilePath.ToString, ex.ToString))
                Return False
            End Try
            Return True
        End Function

        ''' <summary>
        ''' Convert a .vass file into a .sv file
        ''' </summary>
        ''' <param name="vassFilePath">The path of the .vass file to convert</param>
        Shared Sub ConvertVassToSv(vassFilePath As String)
            ' We just change the extention
            Dim svFilePath = IO.Path.ChangeExtension(vassFilePath, ".sv")

            ' .sv file where we we put the cleaned data
            Dim svFile As IO.StreamWriter = IO.File.CreateText(svFilePath)

            ' The lines of the .vass file to convert
            Dim lines As String() = IO.File.ReadAllLines(vassFilePath)
            Dim student As Student

            For Each line As String In lines

                ' The supression of useless, empty and naughty lines is in the TryParse
                If Student.TryParseFromVass(line, student) Then
                    line = student.ToSvLine()
                    svFile.WriteLine(line)
                End If

            Next

            svFile.Close()
        End Sub
        ''' <summary>
        ''' Convert a .vass file into a .sv file.
        ''' A return value indicates wether the conversion succeded of not.
        ''' </summary>
        ''' <param name="vassFilePath">The path of the .vass file to convert</param>
        ''' <returns>True if it succedded False else.</returns>
        Shared Function TryConvertVassToSv(vassFilePath As String) As Boolean
            Try
                ConvertVassToSv(vassFilePath)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
    End Class


    ''' <summary>
    ''' A class to save and load rooms.
    ''' </summary>
    Class DD

        ''' <summary>
        ''' Save a room in a file. The inverse function is LoadRoom
        ''' </summary>
        ''' <param name="room">The Room to save</param>
        ''' <param name="ddFilePath">The file to save the room. You must have writting rights.</param>
        Public Shared Sub SaveRoom(room As Room, ddFilePath As String)
            Dim file As IO.StreamWriter

            file = IO.File.CreateText(ddFilePath)

            file.WriteLine(room.LastRow())
            file.WriteLine(room.LastColumn())

            For row = 0 To room.LastRow()
                For col = 0 To room.LastColumn()
                    If room.GetAvailable(row, col) Then
                        file.Write("1")
                    Else
                        file.Write("0")
                    End If
                Next
            Next

            file.Close()
        End Sub
        ''' <summary>
        ''' Save a room in a file. The inverse function is LoadRoom.
        ''' A return value indicates wether the saving succedded or not.
        ''' </summary>
        ''' <param name="room">The Room to save</param>
        ''' <param name="ddFilePath">The file to save the room. You must have writting rights.</param>
        ''' <returns>True if the room is saved, else False.</returns>
        Public Shared Function TrySaveRoom(room As Room, ddFilePath As String) As Boolean

            Try
                SaveRoom(room, ddFilePath)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function


        ''' <summary>
        ''' Loads a room from a file, the inverse function is SaveRoom
        ''' </summary>
        ''' <param name="ddFilePath">The file to load the room. The file must exist.</param>
        ''' <returns>The room that was in the file.</returns>
        Public Shared Function LoadRoom(ddFilePath As String) As Room

            Dim availables As Boolean(,)

            Dim file As IO.StreamReader
            file = IO.File.OpenText(ddFilePath)

            Dim maxRow As Byte
            Dim maxCol As Byte

            maxRow = file.ReadLine()
            maxCol = file.ReadLine()

            ReDim availables(maxRow, maxCol)

            For row = 0 To maxRow
                For col = 0 To maxCol

                    Dim value As Char = ChrW(file.Read())

                    If value = "1" Then
                        availables(row, col) = True
                    Else
                        availables(row, col) = False
                    End If
                Next
            Next
            file.Close()

            Return New Room(availables)
        End Function
        ''' <summary>
        ''' Loads a room from a file, the inverse function is SaveRoom
        ''' </summary>
        ''' <param name="ddFilePath">The file to load the room. The file must exist.</param>
        ''' <returns>The room that was in the file.</returns>
        Public Shared Function TryLoadRoom(ddFilePath As String, ByRef room As Room)
            Try
                room = LoadRoom(ddFilePath)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function

    End Class


    ''' <summary>
    ''' Some extra functions to acces files.
    ''' </summary>
    Class File

        ''' <summary>
        ''' Get an array of all files with a specific extention in a givem folder
        ''' </summary>
        ''' <param name="path">The path to the folder</param>
        ''' <param name="extention">The extention of files to return (ex: ".vass")</param>
        ''' <returns>An array of path strings to existing files</returns>
        Shared Function GetFilesWithExtension(path As String, extention As String) As String()
            Dim NamesArray = New List(Of String)
            Dim fullName As String

            For Each file In IO.Directory.EnumerateFiles(path)
                If IO.Path.GetExtension(file) = extention Then

                    fullName = IO.Path.Combine(path, file)
                    NamesArray.Add(fullName)
                End If
            Next

            Return NamesArray.ToArray

        End Function

        ''' <summary>
        ''' Get the validity of a file name. Aka it doesn't contains any invalid character and is not nothing.
        ''' </summary>
        ''' <param name="fileName">The file name to check</param>
        ''' <returns>True if it is valid else False</returns>
        Shared Function IsValidFileName(fileName As String) As Boolean
            If fileName Is Nothing Then
                Return False
            End If

            For Each ch In IO.Path.GetInvalidFileNameChars
                If fileName.Contains(ch) Then
                    Return False
                End If
            Next

            For Each ch In IO.Path.GetInvalidPathChars
                If fileName.Contains(ch) Then
                    Return False
                End If
            Next

            Return True
        End Function
    End Class


End Module
