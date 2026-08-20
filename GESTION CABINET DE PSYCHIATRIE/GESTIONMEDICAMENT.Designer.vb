<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONMEDICAMENT
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdfermer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdAjouter = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtObservation = New System.Windows.Forms.TextBox()
        Me.TxtPosologie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDosageMed = New System.Windows.Forms.TextBox()
        Me.TxtformMed = New System.Windows.Forms.TextBox()
        Me.TxtfamilleMed = New System.Windows.Forms.TextBox()
        Me.TxtnomMed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Ivory
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(134, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdfermer)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmdAjouter)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox3.Location = New System.Drawing.Point(1191, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 120)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operations :"
        '
        'cmdfermer
        '
        Me.cmdfermer.BackColor = System.Drawing.Color.DarkOrchid
        Me.cmdfermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdfermer.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdfermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdfermer.Location = New System.Drawing.Point(241, 74)
        Me.cmdfermer.Name = "cmdfermer"
        Me.cmdfermer.Size = New System.Drawing.Size(162, 33)
        Me.cmdfermer.TabIndex = 7
        Me.cmdfermer.Text = "Fermer"
        Me.cmdfermer.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrchid
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(34, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrchid
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(241, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdAjouter
        '
        Me.cmdAjouter.BackColor = System.Drawing.Color.DarkOrchid
        Me.cmdAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAjouter.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAjouter.Location = New System.Drawing.Point(34, 30)
        Me.cmdAjouter.Name = "cmdAjouter"
        Me.cmdAjouter.Size = New System.Drawing.Size(162, 34)
        Me.cmdAjouter.TabIndex = 4
        Me.cmdAjouter.Text = "Ajouter"
        Me.cmdAjouter.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(345, 21)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Forme"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(186, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Famille"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label8.Location = New System.Drawing.Point(629, 921)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(703, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "* Pour choisir un Medicament, selectionnez la ligne dans la liste des Medicaments" & _
    ""
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(32, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nom"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox2.Location = New System.Drawing.Point(1191, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 98)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche Medicament"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(69, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TxtObservation
        '
        Me.TxtObservation.BackColor = System.Drawing.Color.Ivory
        Me.TxtObservation.Location = New System.Drawing.Point(762, 58)
        Me.TxtObservation.Multiline = True
        Me.TxtObservation.Name = "TxtObservation"
        Me.TxtObservation.Size = New System.Drawing.Size(226, 150)
        Me.TxtObservation.TabIndex = 11
        '
        'TxtPosologie
        '
        Me.TxtPosologie.BackColor = System.Drawing.Color.Ivory
        Me.TxtPosologie.Location = New System.Drawing.Point(510, 58)
        Me.TxtPosologie.Multiline = True
        Me.TxtPosologie.Name = "TxtPosologie"
        Me.TxtPosologie.Size = New System.Drawing.Size(226, 150)
        Me.TxtPosologie.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label5.Location = New System.Drawing.Point(722, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(390, 41)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GESTION MEDICAMENT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(765, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "OBSERVATION  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "POSOLOGIE USUELLE :"
        '
        'TxtDosageMed
        '
        Me.TxtDosageMed.BackColor = System.Drawing.Color.Ivory
        Me.TxtDosageMed.Location = New System.Drawing.Point(252, 181)
        Me.TxtDosageMed.Name = "TxtDosageMed"
        Me.TxtDosageMed.Size = New System.Drawing.Size(226, 27)
        Me.TxtDosageMed.TabIndex = 7
        '
        'TxtformMed
        '
        Me.TxtformMed.BackColor = System.Drawing.Color.Ivory
        Me.TxtformMed.Location = New System.Drawing.Point(252, 129)
        Me.TxtformMed.Name = "TxtformMed"
        Me.TxtformMed.Size = New System.Drawing.Size(226, 27)
        Me.TxtformMed.TabIndex = 6
        '
        'TxtfamilleMed
        '
        Me.TxtfamilleMed.BackColor = System.Drawing.Color.Ivory
        Me.TxtfamilleMed.Location = New System.Drawing.Point(252, 84)
        Me.TxtfamilleMed.Name = "TxtfamilleMed"
        Me.TxtfamilleMed.Size = New System.Drawing.Size(226, 27)
        Me.TxtfamilleMed.TabIndex = 5
        '
        'TxtnomMed
        '
        Me.TxtnomMed.BackColor = System.Drawing.Color.Ivory
        Me.TxtnomMed.Location = New System.Drawing.Point(252, 39)
        Me.TxtnomMed.Name = "TxtnomMed"
        Me.TxtnomMed.Size = New System.Drawing.Size(226, 27)
        Me.TxtnomMed.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FAMILLE DE MEDICAMENT :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOM DE MEDICAMENT :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtObservation)
        Me.GroupBox1.Controls.Add(Me.TxtPosologie)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtDosageMed)
        Me.GroupBox1.Controls.Add(Me.TxtformMed)
        Me.GroupBox1.Controls.Add(Me.TxtfamilleMed)
        Me.GroupBox1.Controls.Add(Me.TxtnomMed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox1.Location = New System.Drawing.Point(168, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1015, 224)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicament"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOSAGE DE MEDICAMENT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FORME DE MEDICAMNET:"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(168, 419)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowTemplate.Height = 24
        Me.DataGridViewX1.Size = New System.Drawing.Size(1459, 487)
        Me.DataGridViewX1.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_medical_jar_96__xxhdpi_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(600, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 92)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'GESTIONMEDICAMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GESTIONMEDICAMENT"
        Me.Text = "GESTIONMEDICAMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtObservation As System.Windows.Forms.TextBox
    Friend WithEvents TxtPosologie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDosageMed As System.Windows.Forms.TextBox
    Friend WithEvents TxtformMed As System.Windows.Forms.TextBox
    Friend WithEvents TxtfamilleMed As System.Windows.Forms.TextBox
    Friend WithEvents TxtnomMed As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdfermer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdAjouter As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
