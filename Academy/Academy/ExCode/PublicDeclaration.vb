Imports System.Data.OleDb
Module PublicDeclaration
    '=============================================
    '           PUBLIC DECLARATIONS
    '=============================================

    Public drag As Boolean
    Public ac As New ACadaCode
    Public dt As New DataTable
    Public dr As OleDbDataReader
    Public con As OleDbConnection
    Public photo As New AcadaImage
    Public mousex, mousey, idIndex As Integer
    Public username, passkey, lname, mname, fname As String
    Public ConnString As String = My.Settings.Acada
End Module

Public Class ACadaCode
    Public login As New fxLogin

End Class

Public Class AcadaImage
    Public photo As Image = My.Resources.Photo
    Public tAdmin As Image = My.Resources.teacher
    Public student As Image = My.Resources.student

End Class