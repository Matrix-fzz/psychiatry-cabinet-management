Imports System.Data
Imports System.Data.SqlClient

Public Class GESTIONPATIENTS

    Dim WithEvents BS As New BindingSource
    Private Sub GESTIONPATIENTS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Patient order by cin "
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridView1.DataSource = t
            Else
                MsgBox("base de donnees vide ")
            End If

        End If
        dr.Close()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Patient"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetValue(3))
        End While
        dr.Close()
        cnx.Close()


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        COPATIENT.Show()
        COPATIENT.cmdenregistrer.Visible = False
    End Sub

    Private Sub cmdactualiser_Click(sender As System.Object, e As System.EventArgs) Handles cmdactualiser.Click


        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From Patient  order by idPatient "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            DataGridView1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()

    End Sub

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Patient where cin ='" & Trim(ComboBox1.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridView1.Refresh()
                DataGridView1.DataSource = t
            Else
                MsgBox("aucun resultat trouve ")
            End If
        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub Cmdmodifier_Click(sender As System.Object, e As System.EventArgs) Handles Cmdmodifier.Click
        COPATIENT.Show()
        COPATIENT.cmdAjouter.Visible = False
        cnx.Open()

        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = " SELECT * FROM Patient "
        cmd1.Connection = cnx
        dr = cmd1.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            BS.DataSource = t

            DataGridView1.DataSource = BS
        Else
            MsgBox("aucun resultat trouve")
        End If
        dr.Close()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Patient "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            COPATIENT.Txtidpatient.DataBindings.Add(New Binding("text", BS, "idpatient"))
            COPATIENT.TxtNomp.DataBindings.Add(New Binding("text", BS, "nom_patient"))
            COPATIENT.Txtprenomp.DataBindings.Add(New Binding("text", BS, "prenom_patient"))
            COPATIENT.Txtcin.DataBindings.Add(New Binding("text", BS, "cin"))
            COPATIENT.DateTimePicker1.DataBindings.Add(New Binding("text", BS, "datenaissance_patient"))
            COPATIENT.ComboBox1.DataBindings.Add(New Binding("text", BS, "genre_patient"))
            COPATIENT.Txtadressp.DataBindings.Add(New Binding("text", BS, "tele_patient"))
            COPATIENT.Txtelep.DataBindings.Add(New Binding("text", BS, "cin"))
            COPATIENT.Txtemailp.DataBindings.Add(New Binding("text", BS, "email_patient"))
            COPATIENT.Txtantmed.DataBindings.Add(New Binding("text", BS, "antecedent_Medicaux_patient"))
            COPATIENT.Txtdaig.DataBindings.Add(New Binding("text", BS, "diagnostic"))
            COPATIENT.ComboBox2.DataBindings.Add(New Binding("text", BS, "assurance_Medical_patient"))
            COPATIENT.ComboBox3.DataBindings.Add(New Binding("text", BS, "assurance_santé"))
            COPATIENT.ComboBox4.DataBindings.Add(New Binding("text", BS, "historique_des_traitements"))
            COPATIENT.ComboBox5.DataBindings.Add(New Binding("text", BS, "antécédents_médicaux_familiaux"))
            COPATIENT.Txtpaiement.DataBindings.Add(New Binding("text", BS, "paiement"))
        Else
            MsgBox("Aucun Resultat trouve ")
        End If
        dr.Close()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Patient "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetValue(1))
        End While


        dr.Close()
        cnx.Close()
    End Sub

    Private Sub Cmdsupprimer_Click(sender As System.Object, e As System.EventArgs) Handles Cmdsupprimer.Click
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from patient where cin ='" & ComboBox1.Text & "'"
            cmd.Connection = cnx
            cmd.ExecuteReader()
        Else
            MsgBox("echec d connexion")
        End If
        dr.Close()
        cnx.Close()

        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from patient"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            DataGridView1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()


    End Sub
End Class