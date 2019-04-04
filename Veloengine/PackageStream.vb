Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Namespace PackageLoader
    Public Class PackageStream
        Implements IDisposable

        Private disposed As Boolean

        Private fileStream As FileStream

        Private Const FILENAME_MAX As Integer = 260

        Private Const HEADERSIZE As Integer = 268

        Private fileHeaders As IDictionary(Of String, FileHeader)

        Public ReadOnly Property ContainedFiles() As IEnumerable(Of String)
            Get
                Return Me.fileHeaders.Keys
            End Get
        End Property

        Public Property Count() As Integer

        Public Property FileMajorVersion() As Integer

        Public Property FileMinorVersion() As Integer

        Public Sub New(path As String)
            Me.fileStream = New FileStream(path, FileMode.Open)
            Me.fileHeaders = New Dictionary(Of String, FileHeader)()
            Me.ReadHeader()
        End Sub

        Public Function GetContainedFileLength(filename As String) As Integer
            Return Me.fileHeaders(filename).length
        End Function

        Public Function GetContainedFileStream(filename As String) As HostedStream
            Dim fileHeader As FileHeader = Me.fileHeaders(filename)
            Return New HostedStream(Me.fileStream, fileHeader)
        End Function

        Private Sub ReadHeader()
            Me.fileStream.Seek(-12L, SeekOrigin.[End])
            Dim binaryReader As BinaryReader = New BinaryReader(Me.fileStream)
            Me.Count = binaryReader.ReadInt32()
            Me.FileMajorVersion = binaryReader.ReadInt32()
            Me.FileMinorVersion = binaryReader.ReadInt32()
            Me.fileStream.Seek(CLng((-12 - Me.Count * 268)), SeekOrigin.[End])
            For i As Integer = 0 To Me.Count - 1
                Dim array As Byte() = New Byte(259) {}
                Me.fileStream.Read(array, 0, 260)
                Dim text As String = Encoding.ASCII.GetString(array)
                text = text.Substring(0, text.IndexOf(vbNullChar))
                Me.fileHeaders.Add(text, New FileHeader() With {.filename = text, .offset = binaryReader.ReadInt32(), .length = binaryReader.ReadInt32()})
            Next
            Me.fileStream.Seek(0L, SeekOrigin.Begin)
        End Sub

        Public Sub Dispose()
            Me.Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Me.disposed Then
                Return
            End If
            If disposing Then
                Me.fileStream.Dispose()
                Me.fileHeaders.Clear()
            End If
            Me.disposed = True
        End Sub

        Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
            'Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
