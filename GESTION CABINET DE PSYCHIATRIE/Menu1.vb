Public Class Menu1

    Private Sub cmdrv_Click(sender As System.Object, e As System.EventArgs) Handles cmdrv.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New RENDEZVOUS With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()




    End Sub

    Private Sub cmdp_Click(sender As System.Object, e As System.EventArgs) Handles cmdp.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New GESTIONPATIENTS With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()

    End Sub

    Private Sub cmdt_Click(sender As System.Object, e As System.EventArgs) Handles cmdt.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New TRAITEMENT With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub cmdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdd.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New DOSSIER With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub cmdmed_Click(sender As System.Object, e As System.EventArgs) Handles cmdmed.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New GESTIONMEDICAMENT With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()

    End Sub

    Private Sub cmdfin_Click(sender As System.Object, e As System.EventArgs) Handles cmdfin.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New GESTIONFINNANCE With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()

    End Sub

    Private Sub cmddoc_Click(sender As System.Object, e As System.EventArgs) Handles cmddoc.Click
        'this is to close already opened forms
        While Me.Panelmeddle.Controls.Count > 0
            Me.Panelmeddle.Controls(0).Dispose()
        End While
        'this for opoen form inside panel

        Dim nf As New DOCUMENT With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panelmeddle.Controls.Add(nf)
        nf.Show()

    End Sub

    Private Sub cmdmove_Click(sender As System.Object, e As System.EventArgs) Handles cmdmove.Click
        'animation button <3
        If Panelleft.Width > 55 Then
            TimerPannelReduce.Enabled = True
        Else
            TimerPannelincrease.Enabled = True
        End If
    End Sub

    Private Sub TimerPannelReduce_Tick(sender As System.Object, e As System.EventArgs) Handles TimerPannelReduce.Tick
        If Panelleft.Width > 55 Then
            Panelleft.Width -= 5
        Else
            TimerPannelReduce.Enabled = False

        End If
    End Sub

    Private Sub TimerPannelincrease_Tick(sender As System.Object, e As System.EventArgs) Handles TimerPannelincrease.Tick
        If Panelleft.Width < 204 Then
            Panelleft.Width += 5
        Else
            TimerPannelincrease.Enabled = False

        End If
    End Sub

    Private Sub Panelleft_SizeChanged(sender As System.Object, e As System.EventArgs) Handles Panelleft.SizeChanged
        If Panelleft.Width < 100 Then
            cmdrv.Text = ""
            cmdt.Text = ""
            cmdp.Text = ""
            cmdd.Text = ""
            cmdmed.Text = ""
            cmddoc.Text = ""
            cmdfin.Text = ""
            cmddec.Text = ""
        Else
            cmdrv.Text = "RENDEZ-VOUS"
            cmdt.Text = "TRAITEMENTS"
            cmdp.Text = "PATIENT"
            cmdd.Text = "DOSSIER"
            cmddoc.Text = "DOCUMENTS"
            cmdmed.Text = "MEDICAMENTS"
            cmdfin.Text = "FINNANCE"
            cmddec.Text = "DECONNECTER"
        End If

    End Sub


End Class