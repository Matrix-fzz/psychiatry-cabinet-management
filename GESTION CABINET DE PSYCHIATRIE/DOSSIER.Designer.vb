<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOSSIER
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Txtcinp = New System.Windows.Forms.TextBox()
        Me.TxtNompatient = New System.Windows.Forms.TextBox()
        Me.Txtnumdossier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX3 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdactualiser = New System.Windows.Forms.Button()
        Me.cmdRetour = New System.Windows.Forms.Button()
        Me.cmdsupprimer = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Txtcinp)
        Me.GroupBox1.Controls.Add(Me.TxtNompatient)
        Me.GroupBox1.Controls.Add(Me.Txtnumdossier)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(175, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barre de recherche :"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(20, 111)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(131, 25)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Patient CNI :"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(20, 73)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 25)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Patient Nom :"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(157, 25)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Numero dossier :"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Txtcinp
        '
        Me.Txtcinp.BackColor = System.Drawing.Color.Ivory
        Me.Txtcinp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcinp.Location = New System.Drawing.Point(221, 111)
        Me.Txtcinp.Name = "Txtcinp"
        Me.Txtcinp.Size = New System.Drawing.Size(206, 27)
        Me.Txtcinp.TabIndex = 5
        '
        'TxtNompatient
        '
        Me.TxtNompatient.BackColor = System.Drawing.Color.Ivory
        Me.TxtNompatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNompatient.Location = New System.Drawing.Point(221, 73)
        Me.TxtNompatient.Name = "TxtNompatient"
        Me.TxtNompatient.Size = New System.Drawing.Size(206, 27)
        Me.TxtNompatient.TabIndex = 3
        '
        'Txtnumdossier
        '
        Me.Txtnumdossier.BackColor = System.Drawing.Color.Ivory
        Me.Txtnumdossier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnumdossier.Location = New System.Drawing.Point(221, 32)
        Me.Txtnumdossier.Name = "Txtnumdossier"
        Me.Txtnumdossier.Size = New System.Drawing.Size(206, 27)
        Me.Txtnumdossier.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(860, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 60)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GESTION DES DOSSIERS"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Location = New System.Drawing.Point(175, 407)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1513, 540)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Aquamarine
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.DarkCyan
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2
        Me.PanelEx1.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.PanelEx1.Style.BorderWidth = 0
        Me.PanelEx1.Style.CornerDiameter = 0
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 89
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Label2)
        Me.PanelEx3.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1026, 540)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Les Dossiers :"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(20, 63)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowTemplate.Height = 24
        Me.DataGridViewX1.Size = New System.Drawing.Size(980, 450)
        Me.DataGridViewX1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.DataGridViewX3)
        Me.PanelEx2.Controls.Add(Me.Label4)
        Me.PanelEx2.Controls.Add(Me.DataGridViewX2)
        Me.PanelEx2.Controls.Add(Me.Label3)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEx2.Location = New System.Drawing.Point(1032, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(481, 540)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'DataGridViewX3
        '
        Me.DataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX3.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX3.Location = New System.Drawing.Point(33, 327)
        Me.DataGridViewX3.Name = "DataGridViewX3"
        Me.DataGridViewX3.RowTemplate.Height = 24
        Me.DataGridViewX3.Size = New System.Drawing.Size(420, 186)
        Me.DataGridViewX3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "les medicaments donner:"
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(33, 63)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.RowTemplate.Height = 24
        Me.DataGridViewX2.Size = New System.Drawing.Size(420, 210)
        Me.DataGridViewX2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Informations du Traitement :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.patient__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(731, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'cmdactualiser
        '
        Me.cmdactualiser.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdactualiser.FlatAppearance.BorderSize = 0
        Me.cmdactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdactualiser.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmdactualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdactualiser.Location = New System.Drawing.Point(969, 281)
        Me.cmdactualiser.Name = "cmdactualiser"
        Me.cmdactualiser.Size = New System.Drawing.Size(159, 39)
        Me.cmdactualiser.TabIndex = 96
        Me.cmdactualiser.Text = "Actualiser"
        Me.cmdactualiser.UseVisualStyleBackColor = False
        '
        'cmdRetour
        '
        Me.cmdRetour.BackColor = System.Drawing.Color.DarkCyan
        Me.cmdRetour.FlatAppearance.BorderSize = 0
        Me.cmdRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRetour.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmdRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRetour.Location = New System.Drawing.Point(1528, 281)
        Me.cmdRetour.Name = "cmdRetour"
        Me.cmdRetour.Size = New System.Drawing.Size(158, 39)
        Me.cmdRetour.TabIndex = 95
        Me.cmdRetour.Text = "Retour"
        Me.cmdRetour.UseVisualStyleBackColor = False
        '
        'cmdsupprimer
        '
        Me.cmdsupprimer.BackColor = System.Drawing.Color.Red
        Me.cmdsupprimer.FlatAppearance.BorderSize = 0
        Me.cmdsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdsupprimer.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmdsupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdsupprimer.Location = New System.Drawing.Point(1344, 281)
        Me.cmdsupprimer.Name = "cmdsupprimer"
        Me.cmdsupprimer.Size = New System.Drawing.Size(158, 39)
        Me.cmdsupprimer.TabIndex = 94
        Me.cmdsupprimer.Text = "Supprimer"
        Me.cmdsupprimer.UseVisualStyleBackColor = False
        '
        'cmdModifier
        '
        Me.cmdModifier.BackColor = System.Drawing.Color.Orange
        Me.cmdModifier.FlatAppearance.BorderSize = 0
        Me.cmdModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModifier.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmdModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdModifier.Location = New System.Drawing.Point(1157, 279)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(158, 39)
        Me.cmdModifier.TabIndex = 93
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = False
        '
        'cmdNouveau
        '
        Me.cmdNouveau.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdNouveau.FlatAppearance.BorderSize = 0
        Me.cmdNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNouveau.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmdNouveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNouveau.Location = New System.Drawing.Point(784, 279)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(158, 39)
        Me.cmdNouveau.TabIndex = 92
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = False
        '
        'DOSSIER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.cmdactualiser)
        Me.Controls.Add(Me.cmdRetour)
        Me.Controls.Add(Me.cmdsupprimer)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DOSSIER"
        Me.Text = "DOSSIER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Txtcinp As System.Windows.Forms.TextBox
    Friend WithEvents TxtNompatient As System.Windows.Forms.TextBox
    Friend WithEvents Txtnumdossier As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX3 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdactualiser As System.Windows.Forms.Button
    Friend WithEvents cmdRetour As System.Windows.Forms.Button
    Friend WithEvents cmdsupprimer As System.Windows.Forms.Button
    Friend WithEvents cmdModifier As System.Windows.Forms.Button
    Friend WithEvents cmdNouveau As System.Windows.Forms.Button
End Class
