Imports System.Data
Imports System.Data.SqlClient
Public Class INSCRIPTION
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rep As String
        rep = MsgBox("Voulez vous vraiment quitter", vbYesNo)
        If rep = vbYes Then
            Application.Exit()
        Else
            Me.Show()


        End If
    End Sub

    Private Sub cmdinscrire_Click(sender As System.Object, e As System.EventArgs) Handles cmdinscrire.Click

        Dim cnx As New SqlConnection("Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True")
        cnx.Open()
        If cnx.State = ConnectionState.Open Then
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Utilisateur values ('" & Txtnom.Text & "','" & Txtprenom.Text & "','" & Txtemail.Text & "','" & ComboBoxEx1.SelectedValue & "','" & Txtmotdepasse.Text & "')"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            MsgBox(" l'inscription de  " & Txtnom.Text & Txtprenom.Text & "    a  été ajouter avec succes")
        Else
            MsgBox("echec de connexion")
        End If
        dr.Close()
        cnx.Close()
    End Sub

    Private Sub INSCRIPTION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBoxEx1.Items.Add("Docteur")
        ComboBoxEx1.Items.Add("Secretaire")
        ComboBoxEx1.Items.Add("Stagiaire")
    End Sub
End Class