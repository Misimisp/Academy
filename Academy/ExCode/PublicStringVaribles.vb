Module PublicStringVaribles
    'ID DATA
    Public Function StudentID(sa As String, da As String) As Integer
        StudentID = GenerateID(sa, da)
        Return StudentID
    End Function

    Public Function StaffID(sa As String, da As String) As Integer
        StaffID = GenerateID(sa, da)
        Return StaffID
    End Function


    'sTRING DATAT
    Public Function LoginLoginA(sa As TextBox, da As TextBox) As String
        LoginLoginA = "SELECT * FROM AcadaLogin WHERE (Username = '" & sa.Text & "') AND ([Password] = '" & da.Text & "')"
        Return LoginLoginA
    End Function

    Public Function LoginLoginS(txt As TextBox)
        LoginLoginS = "SELECT * FROM AcadaStudent WHERE (Matric_No = '" & txt.Text & "')"
        Return LoginLoginS
    End Function

    'COUNT DATA


    'INDEX  DATA



End Module
