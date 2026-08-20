<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONFINNANCE
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMFsaliresec = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMAutre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtautretype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtidfac = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMFlocal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMFeau = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMFwifi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtMFelec = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdajouter = New DevComponents.DotNetBar.ButtonX()
        Me.cmdModifier = New DevComponents.DotNetBar.ButtonX()
        Me.Supprimer = New DevComponents.DotNetBar.ButtonX()
        Me.cmdenregsitre = New DevComponents.DotNetBar.ButtonX()
        Me.cmdclear = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton8.Location = New System.Drawing.Point(34, 468)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(63, 23)
        Me.RadioButton8.TabIndex = 13
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Tout"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 662)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = " Total :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.TxtMFsaliresec)
        Me.GroupBox7.Location = New System.Drawing.Point(36, 432)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(492, 73)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "salaire du secretaire :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Montant :"
        '
        'TxtMFsaliresec
        '
        Me.TxtMFsaliresec.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMFsaliresec.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMFsaliresec.Location = New System.Drawing.Point(207, 28)
        Me.TxtMFsaliresec.Name = "TxtMFsaliresec"
        Me.TxtMFsaliresec.Size = New System.Drawing.Size(204, 28)
        Me.TxtMFsaliresec.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridViewX1)
        Me.GroupBox6.Controls.Add(Me.RadioButton8)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.RadioButton5)
        Me.GroupBox6.Controls.Add(Me.RadioButton6)
        Me.GroupBox6.Controls.Add(Me.RadioButton4)
        Me.GroupBox6.Controls.Add(Me.RadioButton3)
        Me.GroupBox6.Controls.Add(Me.RadioButton2)
        Me.GroupBox6.Controls.Add(Me.RadioButton1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(1006, 206)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(707, 706)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Zone de chois "
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.DarkTurquoise
        Me.DataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewX1.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(206, 33)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowHeadersWidth = 60
        Me.DataGridViewX1.RowTemplate.Height = 24
        Me.DataGridViewX1.Size = New System.Drawing.Size(484, 608)
        Me.DataGridViewX1.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(506, 658)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(184, 27)
        Me.TextBox8.TabIndex = 11
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton5.Location = New System.Drawing.Point(34, 401)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(70, 23)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Autre"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton6.Location = New System.Drawing.Point(34, 331)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(150, 23)
        Me.RadioButton6.TabIndex = 4
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Salaire Sucretaire"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(34, 259)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 23)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Local"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(34, 187)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(63, 23)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "WIFI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(34, 120)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Eau"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(34, 55)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Electricite "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.TxtMAutre)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.Txtautretype)
        Me.GroupBox8.Location = New System.Drawing.Point(36, 524)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(492, 117)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Autre charge :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Montant :"
        '
        'TxtMAutre
        '
        Me.TxtMAutre.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMAutre.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMAutre.Location = New System.Drawing.Point(207, 30)
        Me.TxtMAutre.Name = "TxtMAutre"
        Me.TxtMAutre.Size = New System.Drawing.Size(204, 28)
        Me.TxtMAutre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type :"
        '
        'Txtautretype
        '
        Me.Txtautretype.BackColor = System.Drawing.SystemColors.Info
        Me.Txtautretype.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtautretype.Location = New System.Drawing.Point(207, 74)
        Me.Txtautretype.Name = "Txtautretype"
        Me.Txtautretype.Size = New System.Drawing.Size(204, 28)
        Me.Txtautretype.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Montant :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txtidfac)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 706)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les Facture :"
        '
        'Txtidfac
        '
        Me.Txtidfac.AutoSize = True
        Me.Txtidfac.Location = New System.Drawing.Point(200, 29)
        Me.Txtidfac.Name = "Txtidfac"
        Me.Txtidfac.Size = New System.Drawing.Size(0, 19)
        Me.Txtidfac.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(301, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 25)
        Me.DateTimePicker1.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxtMFlocal)
        Me.GroupBox5.Location = New System.Drawing.Point(36, 342)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(492, 73)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Facture du local:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Montant :"
        '
        'TxtMFlocal
        '
        Me.TxtMFlocal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMFlocal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMFlocal.Location = New System.Drawing.Point(207, 27)
        Me.TxtMFlocal.Name = "TxtMFlocal"
        Me.TxtMFlocal.Size = New System.Drawing.Size(204, 28)
        Me.TxtMFlocal.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtMFeau)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 73)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facture d'eau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Montant :"
        '
        'TxtMFeau
        '
        Me.TxtMFeau.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMFeau.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMFeau.Location = New System.Drawing.Point(207, 27)
        Me.TxtMFeau.Name = "TxtMFeau"
        Me.TxtMFeau.Size = New System.Drawing.Size(204, 28)
        Me.TxtMFeau.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtMFwifi)
        Me.GroupBox4.Location = New System.Drawing.Point(36, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(492, 73)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Facture du WIFI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Montant :"
        '
        'TxtMFwifi
        '
        Me.TxtMFwifi.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMFwifi.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMFwifi.Location = New System.Drawing.Point(207, 28)
        Me.TxtMFwifi.Name = "TxtMFwifi"
        Me.TxtMFwifi.Size = New System.Drawing.Size(204, 28)
        Me.TxtMFwifi.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtMFelec)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 73)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facture du Electricite"
        '
        'TxtMFelec
        '
        Me.TxtMFelec.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMFelec.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMFelec.Location = New System.Drawing.Point(207, 28)
        Me.TxtMFelec.Name = "TxtMFelec"
        Me.TxtMFelec.Size = New System.Drawing.Size(204, 28)
        Me.TxtMFelec.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(782, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(399, 41)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "GESTION DU FINNANCE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_connexion_en_tant_qu_utilisateur_96
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(651, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 123)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'cmdajouter
        '
        Me.cmdajouter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdajouter.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdajouter.FocusCuesEnabled = False
        Me.cmdajouter.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdajouter.ForeColor = System.Drawing.Color.AliceBlue
        Me.cmdajouter.Location = New System.Drawing.Point(796, 378)
        Me.cmdajouter.Name = "cmdajouter"
        Me.cmdajouter.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.cmdajouter.Size = New System.Drawing.Size(170, 59)
        Me.cmdajouter.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdajouter.TabIndex = 11
        Me.cmdajouter.Text = "Ajouter"
        '
        'cmdModifier
        '
        Me.cmdModifier.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdModifier.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdModifier.FocusCuesEnabled = False
        Me.cmdModifier.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifier.ForeColor = System.Drawing.Color.AliceBlue
        Me.cmdModifier.Location = New System.Drawing.Point(799, 550)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.cmdModifier.Size = New System.Drawing.Size(170, 59)
        Me.cmdModifier.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdModifier.TabIndex = 18
        Me.cmdModifier.Text = "Modifier"
        '
        'Supprimer
        '
        Me.Supprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Supprimer.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Supprimer.FocusCuesEnabled = False
        Me.Supprimer.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supprimer.ForeColor = System.Drawing.Color.AliceBlue
        Me.Supprimer.Location = New System.Drawing.Point(799, 638)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.Supprimer.Size = New System.Drawing.Size(170, 59)
        Me.Supprimer.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.Supprimer.TabIndex = 19
        Me.Supprimer.Text = "Supprimer"
        '
        'cmdenregsitre
        '
        Me.cmdenregsitre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdenregsitre.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdenregsitre.FocusCuesEnabled = False
        Me.cmdenregsitre.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdenregsitre.ForeColor = System.Drawing.Color.AliceBlue
        Me.cmdenregsitre.Location = New System.Drawing.Point(799, 375)
        Me.cmdenregsitre.Name = "cmdenregsitre"
        Me.cmdenregsitre.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.cmdenregsitre.Size = New System.Drawing.Size(170, 59)
        Me.cmdenregsitre.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdenregsitre.TabIndex = 20
        Me.cmdenregsitre.Text = "Enregistre"
        '
        'cmdclear
        '
        Me.cmdclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdclear.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdclear.FocusCuesEnabled = False
        Me.cmdclear.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.AliceBlue
        Me.cmdclear.Location = New System.Drawing.Point(799, 465)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.cmdclear.Size = New System.Drawing.Size(170, 59)
        Me.cmdclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdclear.TabIndex = 21
        Me.cmdclear.Text = "Effacer"
        '
        'GESTIONFINNANCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.cmdclear)
        Me.Controls.Add(Me.cmdenregsitre)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdajouter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GESTIONFINNANCE"
        Me.Text = "GESTIONFINNANCE"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMFsaliresec As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMAutre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtautretype As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMFlocal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMFeau As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMFwifi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMFelec As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdajouter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdModifier As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Supprimer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Txtidfac As System.Windows.Forms.Label
    Friend WithEvents cmdenregsitre As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdclear As DevComponents.DotNetBar.ButtonX
End Class
