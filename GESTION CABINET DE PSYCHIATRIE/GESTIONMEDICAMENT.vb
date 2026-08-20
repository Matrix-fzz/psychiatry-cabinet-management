Imports System.Data
Imports System.Data.SqlClient
Public Class GESTIONMEDICAMENT

    Dim WithEvents BS As New BindingSource
    Private Sub GESTIONMEDICAMENT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Medicamen"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)

                DataGridViewX1.DataSource = t
            Else
                MsgBox("base de donnees vide ")
            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub
    Private Sub cmdAjouter_Click(sender As System.Object, e As System.EventArgs) Handles cmdAjouter.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Medicamen values ('" & TxtnomMed.Text & "','" & TxtfamilleMed.Text & "','" & TxtformMed.Text & "','" & TxtDosageMed.Text & "','" & TxtPosologie.Text & "','" & TxtObservation.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("Medicament " & TxtnomMed.Text & "    a  été ajouter avec succes")
        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From Medicamen order by idmedicament "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            Me.DataGridViewX1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()
    End Sub

   
End Class