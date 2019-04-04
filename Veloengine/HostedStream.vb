Imports System
Imports System.IO

Namespace PackageLoader
    Public Class HostedStream
        Inherits Stream

        Private fileStream As FileStream

        Private header As FileHeader

        Private currentLogicalOffset As Long

        Public Overrides ReadOnly Property CanRead() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property CanSeek() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property CanWrite() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property Length() As Long
            Get
                Return CLng(Me.header.length)
            End Get
        End Property

        Public Overrides Property Position() As Long
            Get
                Return Me.currentLogicalOffset
            End Get
            Set(value As Long)
                If Me.currentLogicalOffset < 0L Then
                    Throw New ArgumentOutOfRangeException()
                End If
                If Me.currentLogicalOffset < CLng(Me.header.length) Then
                    Me.currentLogicalOffset = value
                    Return
                End If
                Throw New ArgumentOutOfRangeException()
            End Set
        End Property

        Friend Sub New(fileStream As FileStream, ByRef header As FileHeader)
            Me.fileStream = fileStream
            Me.header = header
            Me.currentLogicalOffset = 0L
        End Sub

        Public Overrides Function Read(buffer As Byte(), offset As Integer, count As Integer) As Integer
            If Me.currentLogicalOffset + CLng(count) <= CLng(Me.header.length) Then
                Dim obj As FileStream = Me.fileStream
                SyncLock obj
                    Me.fileStream.Seek(Me.currentLogicalOffset + CLng(Me.header.offset), SeekOrigin.Begin)
                    Dim num As Integer = Me.fileStream.Read(buffer, offset, count)
                    Me.currentLogicalOffset += CLng(num)
                    Return num
                End SyncLock
            End If
            Throw New ArgumentOutOfRangeException()
        End Function

        Public Overrides Function Seek(offset As Long, origin As SeekOrigin) As Long
            Select Case origin
                Case SeekOrigin.Begin
                    If offset >= CLng(Me.header.length) OrElse offset < 0L Then
                        Throw New ArgumentOutOfRangeException()
                    End If
                    Me.currentLogicalOffset = offset
                Case SeekOrigin.Current
                    If Me.currentLogicalOffset + offset > CLng(Me.header.length) OrElse Me.currentLogicalOffset + offset < 0L Then
                        Throw New ArgumentOutOfRangeException()
                    End If
                    Me.currentLogicalOffset += offset
                Case SeekOrigin.[End]
                    If CLng(Me.header.length) + offset >= CLng(Me.header.length) OrElse CLng(Me.header.length) + offset < 0L Then
                        Throw New ArgumentOutOfRangeException()
                    End If
                    Me.currentLogicalOffset = CLng(Me.header.length) + offset
                Case Else
                    Throw New ArgumentException()
            End Select
            Return Me.currentLogicalOffset
        End Function

        Public Overrides Sub Flush()
            Throw New NotSupportedException()
        End Sub

        Public Overrides Sub SetLength(value As Long)
            Throw New NotSupportedException()
        End Sub

        Public Overrides Sub Write(buffer As Byte(), offset As Integer, count As Integer)
            Throw New NotSupportedException()
        End Sub
    End Class
End Namespace
