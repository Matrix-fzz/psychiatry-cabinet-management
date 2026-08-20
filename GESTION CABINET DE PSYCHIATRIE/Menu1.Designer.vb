<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Paneltopleft = New System.Windows.Forms.Panel()
        Me.cmdmove = New System.Windows.Forms.Button()
        Me.Panelleft = New System.Windows.Forms.Panel()
        Me.cmdfin = New System.Windows.Forms.Button()
        Me.cmdmed = New System.Windows.Forms.Button()
        Me.cmddoc = New System.Windows.Forms.Button()
        Me.cmdd = New System.Windows.Forms.Button()
        Me.cmdt = New System.Windows.Forms.Button()
        Me.cmdp = New System.Windows.Forms.Button()
        Me.cmdrv = New System.Windows.Forms.Button()
        Me.Panellefttop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmddec = New System.Windows.Forms.Button()
        Me.TimerPannelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPannelincrease = New System.Windows.Forms.Timer(Me.components)
        Me.Paneltop = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panelmeddle = New System.Windows.Forms.Panel()
        Me.Paneltopleft.SuspendLayout()
        Me.Panelleft.SuspendLayout()
        Me.Panellefttop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(521, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "APPLIACTION DU GESTION D'UN CABINET"
        '
        'Paneltopleft
        '
        Me.Paneltopleft.BackColor = System.Drawing.Color.MidnightBlue
        Me.Paneltopleft.Controls.Add(Me.cmdmove)
        Me.Paneltopleft.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltopleft.Location = New System.Drawing.Point(0, 0)
        Me.Paneltopleft.Name = "Paneltopleft"
        Me.Paneltopleft.Size = New System.Drawing.Size(273, 62)
        Me.Paneltopleft.TabIndex = 2
        '
        'cmdmove
        '
        Me.cmdmove.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdmove.FlatAppearance.BorderSize = 0
        Me.cmdmove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdmove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdmove.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_menu_48
        Me.cmdmove.Location = New System.Drawing.Point(197, 0)
        Me.cmdmove.Name = "cmdmove"
        Me.cmdmove.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.cmdmove.Size = New System.Drawing.Size(76, 62)
        Me.cmdmove.TabIndex = 0
        Me.cmdmove.UseVisualStyleBackColor = True
        '
        'Panelleft
        '
        Me.Panelleft.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panelleft.Controls.Add(Me.cmdfin)
        Me.Panelleft.Controls.Add(Me.cmdmed)
        Me.Panelleft.Controls.Add(Me.cmddoc)
        Me.Panelleft.Controls.Add(Me.cmdd)
        Me.Panelleft.Controls.Add(Me.cmdt)
        Me.Panelleft.Controls.Add(Me.cmdp)
        Me.Panelleft.Controls.Add(Me.cmdrv)
        Me.Panelleft.Controls.Add(Me.Panellefttop)
        Me.Panelleft.Controls.Add(Me.Paneltopleft)
        Me.Panelleft.Controls.Add(Me.cmddec)
        Me.Panelleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelleft.Location = New System.Drawing.Point(0, 0)
        Me.Panelleft.MinimumSize = New System.Drawing.Size(45, 0)
        Me.Panelleft.Name = "Panelleft"
        Me.Panelleft.Size = New System.Drawing.Size(273, 1055)
        Me.Panelleft.TabIndex = 1
        '
        'cmdfin
        '
        Me.cmdfin.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdfin.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdfin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdfin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdfin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdfin.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfin.ForeColor = System.Drawing.Color.Thistle
        Me.cmdfin.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_tirelire_481
        Me.cmdfin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdfin.Location = New System.Drawing.Point(0, 701)
        Me.cmdfin.Name = "cmdfin"
        Me.cmdfin.Size = New System.Drawing.Size(273, 65)
        Me.cmdfin.TabIndex = 30
        Me.cmdfin.Text = "FINANCE"
        Me.cmdfin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdfin.UseVisualStyleBackColor = False
        '
        'cmdmed
        '
        Me.cmdmed.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdmed.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdmed.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdmed.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdmed.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmed.ForeColor = System.Drawing.Color.Thistle
        Me.cmdmed.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_pilule_emoji_48
        Me.cmdmed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdmed.Location = New System.Drawing.Point(0, 636)
        Me.cmdmed.Name = "cmdmed"
        Me.cmdmed.Size = New System.Drawing.Size(273, 65)
        Me.cmdmed.TabIndex = 29
        Me.cmdmed.Text = "MEDICAMENTS"
        Me.cmdmed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdmed.UseVisualStyleBackColor = False
        '
        'cmddoc
        '
        Me.cmddoc.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmddoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmddoc.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmddoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmddoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmddoc.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddoc.ForeColor = System.Drawing.Color.Thistle
        Me.cmddoc.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_dossier_48
        Me.cmddoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddoc.Location = New System.Drawing.Point(0, 571)
        Me.cmddoc.Name = "cmddoc"
        Me.cmddoc.Size = New System.Drawing.Size(273, 65)
        Me.cmddoc.TabIndex = 28
        Me.cmddoc.Text = "DOCUMENTS"
        Me.cmddoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddoc.UseVisualStyleBackColor = False
        '
        'cmdd
        '
        Me.cmdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdd.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdd.ForeColor = System.Drawing.Color.Thistle
        Me.cmdd.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_documents_48
        Me.cmdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdd.Location = New System.Drawing.Point(0, 506)
        Me.cmdd.Name = "cmdd"
        Me.cmdd.Size = New System.Drawing.Size(273, 65)
        Me.cmdd.TabIndex = 27
        Me.cmdd.Text = "DOSSIER"
        Me.cmdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdd.UseVisualStyleBackColor = False
        '
        'cmdt
        '
        Me.cmdt.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdt.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdt.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdt.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdt.ForeColor = System.Drawing.Color.Thistle
        Me.cmdt.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_traitement_48
        Me.cmdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdt.Location = New System.Drawing.Point(0, 441)
        Me.cmdt.Name = "cmdt"
        Me.cmdt.Size = New System.Drawing.Size(273, 65)
        Me.cmdt.TabIndex = 26
        Me.cmdt.Text = "TRAITEMENTS"
        Me.cmdt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdt.UseVisualStyleBackColor = False
        '
        'cmdp
        '
        Me.cmdp.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdp.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdp.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdp.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdp.ForeColor = System.Drawing.Color.Thistle
        Me.cmdp.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_utilisateur_48
        Me.cmdp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdp.Location = New System.Drawing.Point(0, 376)
        Me.cmdp.Name = "cmdp"
        Me.cmdp.Size = New System.Drawing.Size(273, 65)
        Me.cmdp.TabIndex = 25
        Me.cmdp.Text = "PATIENT"
        Me.cmdp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdp.UseVisualStyleBackColor = False
        '
        'cmdrv
        '
        Me.cmdrv.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmdrv.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdrv.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmdrv.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmdrv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdrv.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrv.ForeColor = System.Drawing.Color.Thistle
        Me.cmdrv.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_calendrier_48
        Me.cmdrv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdrv.Location = New System.Drawing.Point(0, 311)
        Me.cmdrv.Name = "cmdrv"
        Me.cmdrv.Size = New System.Drawing.Size(273, 65)
        Me.cmdrv.TabIndex = 24
        Me.cmdrv.Text = "RENDEZ-VOUS"
        Me.cmdrv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdrv.UseVisualStyleBackColor = False
        '
        'Panellefttop
        '
        Me.Panellefttop.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panellefttop.Controls.Add(Me.PictureBox1)
        Me.Panellefttop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panellefttop.Location = New System.Drawing.Point(0, 62)
        Me.Panellefttop.Name = "Panellefttop"
        Me.Panellefttop.Size = New System.Drawing.Size(273, 249)
        Me.Panellefttop.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.brain
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(34, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmddec
        '
        Me.cmddec.BackColor = System.Drawing.Color.Red
        Me.cmddec.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmddec.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.cmddec.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.cmddec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmddec.Font = New System.Drawing.Font("Corbel", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddec.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmddec.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_exit_32
        Me.cmddec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddec.Location = New System.Drawing.Point(0, 995)
        Me.cmddec.Name = "cmddec"
        Me.cmddec.Size = New System.Drawing.Size(273, 60)
        Me.cmddec.TabIndex = 7
        Me.cmddec.Text = "DECONNECTER"
        Me.cmddec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddec.UseVisualStyleBackColor = False
        '
        'TimerPannelReduce
        '
        Me.TimerPannelReduce.Interval = 30
        '
        'TimerPannelincrease
        '
        Me.TimerPannelincrease.Interval = 30
        '
        'Paneltop
        '
        Me.Paneltop.BackColor = System.Drawing.Color.MidnightBlue
        Me.Paneltop.Controls.Add(Me.Button4)
        Me.Paneltop.Controls.Add(Me.Button1)
        Me.Paneltop.Controls.Add(Me.Label1)
        Me.Paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltop.Location = New System.Drawing.Point(273, 0)
        Me.Paneltop.Name = "Paneltop"
        Me.Paneltop.Size = New System.Drawing.Size(1651, 62)
        Me.Paneltop.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_info_48
        Me.Button4.Location = New System.Drawing.Point(1523, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 62)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_nom_48
        Me.Button1.Location = New System.Drawing.Point(1587, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 62)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panelmeddle
        '
        Me.Panelmeddle.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources._1323165__1_
        Me.Panelmeddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panelmeddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelmeddle.Location = New System.Drawing.Point(273, 0)
        Me.Panelmeddle.MinimumSize = New System.Drawing.Size(35, 0)
        Me.Panelmeddle.Name = "Panelmeddle"
        Me.Panelmeddle.Size = New System.Drawing.Size(1651, 1055)
        Me.Panelmeddle.TabIndex = 3
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Paneltop)
        Me.Controls.Add(Me.Panelmeddle)
        Me.Controls.Add(Me.Panelleft)
        Me.IsMdiContainer = True
        Me.Name = "Menu1"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Paneltopleft.ResumeLayout(False)
        Me.Panelleft.ResumeLayout(False)
        Me.Panellefttop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneltop.ResumeLayout(False)
        Me.Paneltop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Paneltopleft As System.Windows.Forms.Panel
    Friend WithEvents cmdmove As System.Windows.Forms.Button
    Friend WithEvents Panelleft As System.Windows.Forms.Panel
    Friend WithEvents cmddec As System.Windows.Forms.Button
    Friend WithEvents Panelmeddle As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panellefttop As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPannelReduce As System.Windows.Forms.Timer
    Friend WithEvents TimerPannelincrease As System.Windows.Forms.Timer
    Friend WithEvents cmdfin As System.Windows.Forms.Button
    Friend WithEvents cmdmed As System.Windows.Forms.Button
    Friend WithEvents cmddoc As System.Windows.Forms.Button
    Friend WithEvents cmdd As System.Windows.Forms.Button
    Friend WithEvents cmdt As System.Windows.Forms.Button
    Friend WithEvents cmdp As System.Windows.Forms.Button
    Friend WithEvents cmdrv As System.Windows.Forms.Button
    Friend WithEvents Paneltop As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
