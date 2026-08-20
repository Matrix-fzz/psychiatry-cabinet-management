Imports System.Data
Imports System.Data.SqlClient
Public Class Resrever

    Private Sub cmdAjouter_Click(sender As System.Object, e As System.EventArgs) Handles cmdAjouter.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Reserver values ('" & TxtNumredezvouz.Text & "','" & ComboBoxEx1.SelectedValue & "','" & DateTimePicker1.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox(" le rendez-vous a été ajouter avec succes")

        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From Reserver  order by idrendezvous "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            RENDEZVOUS.DataGridViewX1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()

    End Sub

    Private Sub Resrever_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select distinct nom_patient , prenom_patient from Patient "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBoxEx1.Items.Add(dr.GetValue(0))

        End While
        dr.Close()
        cnx.Close()
    End Sub
End Class