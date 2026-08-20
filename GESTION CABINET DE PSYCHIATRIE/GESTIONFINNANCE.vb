Imports System.Data
Imports System.Data.SqlClient
Public Class GESTIONFINNANCE

    Private Sub GESTIONFINNANCE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmdenregsitre.Hide()

        
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select idfacture, date_charges from GESTIONFINNANCIER order by date_charges "
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


    Private Sub cmdajouter_Click(sender As System.Object, e As System.EventArgs) Handles cmdajouter.Click
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into GESTIONFINNANCIER   values ('" & DateTimePicker1.Value & "','" & TxtMFelec.Text & "','" & TxtMFeau.Text & "','" & TxtMFwifi.Text & "','" & TxtMFlocal.Text & "','" & TxtMFsaliresec.Text & "','" & TxtMAutre.Text & "','" & Txtautretype.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox("la Facture du Electricite  a  été ajouter avec succes")
            TxtMFelec.Clear()
            DateTimePicker1.Text = ""
            Txtidfac.Text = ""
            TxtMFeau.Clear()
            TxtMFwifi.Clear()
            TxtMFlocal.Clear()
            TxtMFsaliresec.Clear()
            TxtMAutre.Clear()
            Txtautretype.Clear()
        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * From GESTIONFINNANCIER  order by date_charges "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim t As New DataTable
            t.Load(dr)
            DataGridViewX1.Refresh()
            DataGridViewX1.DataSource = t
        Else
            MsgBox("aucun résultat trouvé")
        End If
        dr.Close()
        cnx.Close()

    End Sub

    Private Sub cmdModifier_Click(sender As System.Object, e As System.EventArgs) Handles cmdModifier.Click
        cmdajouter.Hide()
        cmdenregsitre.Show()
        cnx.Open()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = " SELECT * FROM GESTIONFINNANCIER ORDER BY idfacture"
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
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM GESTIONFINNANCIER "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Txtidfac.DataBindings.Add(New Binding("text", BS, "idfacture"))
            DateTimePicker1.DataBindings.Add(New Binding("text", BS, "date_charges"))
            TxtMFelec.DataBindings.Add(New Binding("text", BS, "facture_Electricité"))
            TxtMFeau.DataBindings.Add(New Binding("text", BS, "facture_eau"))
            TxtMFwifi.DataBindings.Add(New Binding("text", BS, "facture_WIFI"))
            TxtMFlocal.DataBindings.Add(New Binding("text", BS, "facture_Location"))
            TxtMFsaliresec.DataBindings.Add(New Binding("text", BS, "salaire_secrétaire"))
            TxtMAutre.DataBindings.Add(New Binding("text", BS, "autres"))
            Txtautretype.DataBindings.Add(New Binding("text", BS, "typeautre"))
            
        Else
            MsgBox("Aucun Resultat trouve ")
        End If
        dr.Close()
        cnx.Close()

   
    End Sub

    Private Sub cmdenregsitre_Click(sender As System.Object, e As System.EventArgs) Handles cmdenregsitre.Click
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")

        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = " UPDATE GESTIONFINNANCIER SET  date_charges = '" & DateTimePicker1.Value & "', facture_Electricité ='" & TxtMFelec.Text & "', facture_eau = '" & TxtMFeau.Text & "' , facture_WIFI = '" & TxtMFwifi.Text & "', facture_Location = '" & TxtMFlocal.Text & "',  salaire_secrétaire= '" & TxtMFsaliresec.Text & "', autres = '" & TxtMAutre.Text & "', typeautre = '" & Txtautretype.Text & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            While dr.Read
                Txtidfac.Text = dr.GetValue(0)
            End While
            MsgBox("Operation de modification effectue ....!")
            cmdenregsitre.Hide()
            cmdajouter.Show()

        End If
        dr.Close()
        cnx.Close()

        TxtMFelec.Clear()
        DateTimePicker1.Text = ""
        Txtidfac.Text = ""
        TxtMFeau.Clear()
        TxtMFwifi.Clear()
        TxtMFlocal.Clear()
        TxtMFsaliresec.Clear()
        TxtMAutre.Clear()
        Txtautretype.Clear()
    End Sub

    Private Sub cmdclear_Click(sender As System.Object, e As System.EventArgs) Handles cmdclear.Click
        TxtMFelec.Clear()
        DateTimePicker1.Text = ""
        Txtidfac.Text = ""
        TxtMFeau.Clear()
        TxtMFwifi.Clear()
        TxtMFlocal.Clear()
        TxtMFsaliresec.Clear()
        TxtMAutre.Clear()
        Txtautretype.Clear()

    End Sub

    Private Sub GroupBox6_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox6.Enter
      
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")

        cnx.Open()
        If RadioButton1.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select facture_Electricité, date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t

                End If

            End If
        End If
        dr.Close()
        cnx.Close()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")

        cnx.Open()
        If RadioButton2.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select facture_eau, date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t

                End If

            End If
        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If RadioButton3.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select facture_WIFI, date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t
                End If
            End If
        End If

        dr.Close()
        cnx.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged

            Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
            cnx.Open()
        If RadioButton4.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select facture_Location, date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t
                End If

            End If
        End If
        dr.Close()
        cnx.Close()
    End Sub
 

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If RadioButton5.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select salaire_secrétaire , date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t

                End If
            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If RadioButton6.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select typeautre,autres , date_charges from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t

                End If
            End If

        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If RadioButton8.Checked = True Then

            If cnx.State = ConnectionState.Open Then
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select date_charges,facture_Electricité,facture_eau, facture_WIFI,facture_Location,salaire_secrétaire,typeautre,autres from GESTIONFINNANCIER order by date_charges "
                cmd.Connection = cnx
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    Dim t As New DataTable
                    t.Load(dr)
                    DataGridViewX1.Refresh()
                    DataGridViewX1.DataSource = t

                End If

            End If
        End If
        dr.Close()
        cnx.Close()
    End Sub
End Class