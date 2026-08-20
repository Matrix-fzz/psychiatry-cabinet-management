Imports System.Data
Imports System.Data.SqlClient

Public Class COPATIENT
    Dim WithEvents BS As New BindingSource

    Private Sub cmdAjouter_Click(sender As System.Object, e As System.EventArgs) Handles cmdAjouter.Click
        Me.cmdenregistrer.Visible = False
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Patient   values ('" & TxtNomp.Text & "','" & Txtprenomp.Text & "','" & Txtcin.Text & "','" & DateTimePicker1.Value & "','" & ComboBox1.Text & "','" & Txtadressp.Text & "','" & Txtelep.Text & "','" & Txtemailp.Text & "','" & Txtantmed.Text & "','" & Txtdaig.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & Txtpaiement.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("le Patient " & TxtNomp.Text & "    a  été ajouter avec succes")
        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From Patient  order by idPatient "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            GESTIONPATIENTS.DataGridView1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()


        
    End Sub

    Private Sub COPATIENT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Homme")
        ComboBox1.Items.Add("Femme")

        ComboBox2.Items.Add("Oui")
        ComboBox2.Items.Add("Non")

        ComboBox3.Items.Add("Oui")
        ComboBox3.Items.Add("Non")

        ComboBox4.Items.Add("Oui")
        ComboBox4.Items.Add("Non")

        ComboBox5.Items.Add("Oui")
        ComboBox5.Items.Add("Non")
       
    End Sub

    Private Sub cmdenregistrer_Click(sender As System.Object, e As System.EventArgs) Handles cmdenregistrer.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
       
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " UPDATE patient SET nom_patient ='" & TxtNomp.Text & "', prenom_patient = '" & Txtprenomp.Text & "', cin ='" & Txtcin.Text & "', datenaissance_patient = '" & DateTimePicker1.Value & "' , genre_patient = '" & ComboBox1.Text & "', adress = '" & Txtadressp.Text & "', tele_patient = '" & Txtelep.Text & "', email_patient = '" & Txtemailp.Text & "', antecedent_medicaux_patient = '" & Txtantmed.Text & "'  , diagnostic = '" & Txtdaig.Text & "' , assurance_medical_patient = '" & ComboBox2.Text & "' , assurance_santé = '" & ComboBox3.Text & "', historique_des_traitements  = '" & ComboBox4.Text & "' , antécédents_médicaux_familiaux  = '" & ComboBox5.Text & "', paiement  = '" & Txtpaiement.Text & "' WHERE idpatient ='" & Txtidpatient.Text & " ' "
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("Operation de modification effectue ....!")
            dr.Close()

        End If

        dr.Close()
        cnx.Close()
    End Sub

    Private Sub cmdEffacer_Click(sender As System.Object, e As System.EventArgs) Handles cmdEffacer.Click
        TxtNomp.Clear()
        Txtprenomp.Clear()
        Txtcin.Clear()
        DateTimePicker1.Tag = 0
        ComboBox1.SelectedIndex = -1
        Txtadressp.Clear()
        Txtelep.Clear()
        Txtemailp.Clear()
        Txtantmed.Clear()
        Txtdaig.Clear()
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        Txtpaiement.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim rep As String
        rep = MsgBox("Voulez vous Annuler ?", vbYesNo)
        If rep = vbYes Then
            Me.Hide()

        Else
            Me.Show()
        End If
    End Sub
End Class