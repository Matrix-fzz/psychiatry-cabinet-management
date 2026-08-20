Imports System.Data
Imports System.Data.SqlClient
Public Class TRAITEMENT

    Private Sub TRAITEMENT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

  
    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from medicamen "
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox2.Items.Add(dr.GetValue(1))
            End While

        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub cmdajoumed_Click(sender As System.Object, e As System.EventArgs) Handles cmdajoumed.Click

    End Sub
End Class