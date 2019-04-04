Imports System
Imports System.Runtime.InteropServices
Module Musica_API
    Private Declare Function sndPlaySound Lib "WINMM.DLL" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal unsignedFlags As Int32) As Int32
    Private Const SND_LOOP As Integer = &H8
    Private Const SND_ASYNC As Integer = &H1
    Public Sub SndPlaySoundA_wrapper(ByVal path As String, Optional ByVal Looping As Boolean = False, Optional ByVal Async As Boolean = False)
        Dim flags As Long = 0
        If Looping = True Then flags = flags Or SND_LOOP
        If Async = True Then flags = flags Or SND_ASYNC
        sndPlaySound(path, flags)
    End Sub
End Module
