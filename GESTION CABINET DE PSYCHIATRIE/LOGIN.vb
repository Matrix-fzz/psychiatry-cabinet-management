Public Class LOGIN

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rep As String
        rep = MsgBox("Voulez vous vraiment quitter", vbYesNo)
        If rep = vbYes Then
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub


    Private Sub cmdconnecter_Click(sender As System.Object, e As System.EventArgs) Handles cmdconnecter.Click
        cnx.ConnectionString = "Data Source=.;Initial Catalog=CABINETPSYCHAITRE;Integrated Security=True"
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * From UTILISATEUR"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr(1) = Txtusername.Text And dr(2) = Txtmotdepasse.Text Then
                MsgBox("MOT DE PASSE CORRECT VOUS AVEZ ACCESS")
                Menu1.Show()
                Me.Hide()
            Else
                MsgBox("UTILISATEUR OU MOT DE PASSE INCORRECT ")
            End If
        End If
        dr.Close()
        cnx.Close()

    End Sub
End Class