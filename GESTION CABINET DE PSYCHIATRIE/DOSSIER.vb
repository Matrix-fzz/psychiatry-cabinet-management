Imports System.Data
Imports System.Data.SqlClient
Public Class DOSSIER

    Private Sub cmdNouveau_Click(sender As System.Object, e As System.EventArgs) Handles cmdNouveau.Click
        CODOSSIER.Show()
        CODOSSIER.cmdenregistrer.Visible = False
    End Sub

    Private Sub cmdModifier_Click(sender As System.Object, e As System.EventArgs) Handles cmdModifier.Click
        CODOSSIER.Show()
        CODOSSIER.cmdnouveau.Visible = False
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")

        cnx.Open()

        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = " SELECT * FROM dossier "
        cmd1.Connection = cnx
        dr = cmd1.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            BS.DataSource = t

            DataGridViewX1.DataSource = BS
        Else
            MsgBox("aucun resultat trouve")
        End If
        dr.Close()

        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM dossier "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            CODOSSIER.Txtiddossier.DataBindings.Add(New Binding("text", BS, "iddossier"))
            CODOSSIER.ComboBoxEx1.DataBindings.Add(New Binding("text", BS, "idpatient"))
            CODOSSIER.ComboBoxEx2.DataBindings.Add(New Binding("text", BS, "idtraitement"))
            CODOSSIER.DateTimePicker1.DataBindings.Add(New Binding("text", BS, "date_de_création"))
            CODOSSIER.DateTimePicker2.DataBindings.Add(New Binding("text", BS, "dernièremiseàjour"))
            CODOSSIER.TxtComment.DataBindings.Add(New Binding("text", BS, "commentaires"))
        Else
            MsgBox("Aucun Resultat trouve ")
        End If
        dr.Close()
        cnx.Close()

    End Sub

    Private Sub DOSSIER_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT iddossier ,nom_patient, prenom_patient,cin, date_de_création, dernièremiseàjour, commentaires FROM DOSSIER JOIN PATIENT ON dossier.idpatient = patient.idpatient order by iddossier "
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
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT type_malade,type_traitement,nom_traitement,durée_traitement,date_début,date_fin,seinces,status_etat_actuel,analyse, notes FROM DOSSIER JOIN PATIENT  ON DOSSIER.idpatient = PATIENT.idpatient JOIN TRAITEMENT  ON PATIENT.idpatient = TRAITEMENT.idpatient order by iddossier "
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX2.DataSource = t
            Else
                MsgBox("base de donnees vide ")
            End If

        End If
        dr.Close()
        cnx.Close()
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select idmedicament,nommédicament from medicamen order by idmedicament"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX3.DataSource = t
            Else
                MsgBox("base de donnees vide ")
            End If

        End If
        dr.Close()
        cnx.Close()
        TxtNompatient.Visible = False
        Txtcinp.Visible = False
        Txtnumdossier.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TxtNompatient.Visible = False
            Txtcinp.Visible = False
            Txtnumdossier.Visible = True
        Else
            TxtNompatient.Visible = False
            Txtcinp.Visible = False
            Txtnumdossier.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TxtNompatient.Visible = True
            Txtcinp.Visible = False
            Txtnumdossier.Visible = False
        Else
            TxtNompatient.Visible = False
            Txtcinp.Visible = False
            Txtnumdossier.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TxtNompatient.Visible = False
            Txtcinp.Visible = True
            Txtnumdossier.Visible = False
        Else
            TxtNompatient.Visible = False
            Txtcinp.Visible = False
            Txtnumdossier.Visible = False
        End If
    End Sub

    Private Sub Txtnumdossier_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtnumdossier.TextChanged
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        ' view dossier'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT nom_patient, prenom_patient,cin, date_de_création, dernièremiseàjour, commentaires FROM DOSSIER JOIN PATIENT ON dossier.idpatient = patient.idpatient where iddossier='" & Trim(Txtnumdossier.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX1.Refresh()
                DataGridViewX1.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
        'view traitement'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT iddossier,type_malade,type_traitement,nom_traitement,durée_traitement,date_début,date_fin,seinces,status_etat_actuel,analyse, notes FROM DOSSIER JOIN PATIENT  ON DOSSIER.idpatient = PATIENT.idpatient JOIN TRAITEMENT  ON PATIENT.idpatient = TRAITEMENT.idpatient WHERE  iddossier='" & Trim(Txtnumdossier.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX2.Refresh()
                DataGridViewX2.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
        'view medicament'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT nommédicament FROM DOSSIER JOIN TRAITEMENT ON DOSSIER.idtraitement = TRAITEMENT.idtraitement JOIN MEDICAMEN ON TRAITEMENT.idmedicament = MEDICAMEN.idmedicament WHERE  iddossier='" & Trim(Txtnumdossier.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX3.Refresh()
                DataGridViewX3.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub TxtNompatient_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNompatient.TextChanged
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT iddossier ,nom_patient, prenom_patient,cin, date_de_création, dernièremiseàjour, commentaires FROM DOSSIER JOIN PATIENT ON dossier.idpatient = patient.idpatient where nom_patient ='" & Trim(TxtNompatient.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX1.Refresh()
                DataGridViewX1.DataSource = t
            End If
        Else
         

        End If
        dr.Close()
        cnx.Close()
        'view traitement'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT iddossier,type_malade,type_traitement,nom_traitement,durée_traitement,date_début,date_fin,seinces,status_etat_actuel,analyse, notes FROM DOSSIER JOIN PATIENT  ON DOSSIER.idpatient = PATIENT.idpatient JOIN TRAITEMENT  ON PATIENT.idpatient = TRAITEMENT.idpatient WHERE  nom_patient='" & Trim(TxtNompatient.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX2.Refresh()
                DataGridViewX2.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
        'view medic'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT  nommédicament FROM PATIENT JOIN DOSSIER  ON Patient.idpatient = Dossier.idpatient JOIN TRAITEMENT  ON Dossier.idtraitement = Traitement.idtraitement JOIN MEDICAMEN  ON Traitement.idmedicament = MEDICAMEN.idmedicament WHERE  nom_patient='" & Trim(TxtNompatient.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX3.Refresh()
                DataGridViewX3.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub Txtcinp_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtcinp.TextChanged
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT iddossier ,nom_patient, prenom_patient,cin, date_de_création, dernièremiseàjour, commentaires FROM DOSSIER JOIN PATIENT ON dossier.idpatient = patient.idpatient where cin ='" & Trim(Txtcinp.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX1.Refresh()
                DataGridViewX1.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
        'view traitement'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT iddossier,type_malade,type_traitement,nom_traitement,durée_traitement,date_début,date_fin,seinces,status_etat_actuel,analyse, notes FROM DOSSIER JOIN PATIENT  ON DOSSIER.idpatient = PATIENT.idpatient JOIN TRAITEMENT  ON PATIENT.idpatient = TRAITEMENT.idpatient WHERE cin ='" & Trim(Txtcinp.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX2.Refresh()
                DataGridViewX2.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
        'view medic'
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " SELECT  nommédicament FROM PATIENT JOIN DOSSIER  ON Patient.idpatient = Dossier.idpatient JOIN TRAITEMENT  ON Dossier.idtraitement = Traitement.idtraitement JOIN MEDICAMEN  ON Traitement.idmedicament = MEDICAMEN.idmedicament WHERE cin ='" & Trim(Txtcinp.Text) & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim t As New DataTable
                t.Load(dr)
                DataGridViewX3.Refresh()
                DataGridViewX3.DataSource = t
            Else


            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub


 
    Private Sub cmdRetour_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

End Class