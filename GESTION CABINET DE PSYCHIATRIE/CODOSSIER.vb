Imports System.Data
Imports System.Data.SqlClient
Public Class CODOSSIER

    Private Sub CODOSSIERvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Patient"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBoxEx1.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
       
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Traitement"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBoxEx2.Items.Add(dr.GetValue(0))
        End While
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub cmdAjouter_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub cmdenregistrer_Click(sender As System.Object, e As System.EventArgs) Handles cmdenregistrer.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")

        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " UPDATE dossier SET idpatient ='" & ComboBoxEx1.Text & "', idtraitement ='" & ComboBoxEx2.Text & "' ,date_de_création ='" & DateTimePicker1.Value & "', dernièremiseàjour ='" & DateTimePicker2.Value & "',commentaires='" & TxtComment.Text & "' WHERE iddossier ='" & Txtiddossier.Text & " ' "
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("Operation de modification effectue ....!")
            dr.Close()

        End If

        dr.Close()
        cnx.Close()
    End Sub

    Private Sub cmdnouveau_Click(sender As System.Object, e As System.EventArgs) Handles cmdnouveau.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into dossier   values ('" & ComboBoxEx1.Text & "','" & ComboBoxEx2.Text & "' ,'" & DateTimePicker1.Value & "', '" & DateTimePicker2.Value & "','" & TxtComment.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("le Dossier a été ajouter avec succes")
        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From dossier  order by iddossier "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            DOSSIER.DataGridViewX1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()
    End Sub
End Class