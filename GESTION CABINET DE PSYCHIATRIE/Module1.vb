Imports System.Data
Imports System.Data.SqlClient


Module Module1
    Public cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
    Public cmd, cmd1 As New SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public WithEvents BS, BS1 As New BindingSource
End Module
