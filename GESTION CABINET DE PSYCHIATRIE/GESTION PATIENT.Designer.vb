<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONPATIENTS
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cmdsupprimer = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Cmdmodifier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdactualiser = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.MintCream
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(880, 219)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 39)
        Me.Button4.TabIndex = 82
        Me.Button4.Text = "Ajouter"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(216, 226)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 25)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "CIN Patient :"
        '
        'Cmdsupprimer
        '
        Me.Cmdsupprimer.BackColor = System.Drawing.Color.Red
        Me.Cmdsupprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmdsupprimer.FlatAppearance.BorderSize = 0
        Me.Cmdsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmdsupprimer.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdsupprimer.ForeColor = System.Drawing.Color.MintCream
        Me.Cmdsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmdsupprimer.Location = New System.Drawing.Point(1392, 219)
        Me.Cmdsupprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmdsupprimer.Name = "Cmdsupprimer"
        Me.Cmdsupprimer.Size = New System.Drawing.Size(152, 39)
        Me.Cmdsupprimer.TabIndex = 81
        Me.Cmdsupprimer.Text = "Supprimer"
        Me.Cmdsupprimer.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(357, 222)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 33)
        Me.ComboBox1.TabIndex = 79
        '
        'Cmdmodifier
        '
        Me.Cmdmodifier.BackColor = System.Drawing.Color.Orange
        Me.Cmdmodifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmdmodifier.FlatAppearance.BorderSize = 0
        Me.Cmdmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmdmodifier.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdmodifier.ForeColor = System.Drawing.Color.MintCream
        Me.Cmdmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmdmodifier.Location = New System.Drawing.Point(1232, 219)
        Me.Cmdmodifier.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmdmodifier.Name = "Cmdmodifier"
        Me.Cmdmodifier.Size = New System.Drawing.Size(152, 39)
        Me.Cmdmodifier.TabIndex = 80
        Me.Cmdmodifier.Text = "Modifier"
        Me.Cmdmodifier.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(711, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 41)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "GESTION PATIENT"
        '
        'cmdactualiser
        '
        Me.cmdactualiser.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdactualiser.FlatAppearance.BorderSize = 0
        Me.cmdactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdactualiser.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdactualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdactualiser.Location = New System.Drawing.Point(1053, 218)
        Me.cmdactualiser.Name = "cmdactualiser"
        Me.cmdactualiser.Size = New System.Drawing.Size(152, 39)
        Me.cmdactualiser.TabIndex = 90
        Me.cmdactualiser.Text = "Actualiser"
        Me.cmdactualiser.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(82, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1634, 501)
        Me.DataGridView1.TabIndex = 91
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_chercher_381
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(606, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 42)
        Me.Button1.TabIndex = 84
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.patient1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(581, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.MintCream
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1552, 219)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 39)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "Retour"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GESTIONPATIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1924, 1028)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdactualiser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Cmdsupprimer)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cmdmodifier)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GESTIONPATIENTS"
        Me.Text = "GESTION_PATIENT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cmdsupprimer As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cmdmodifier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdactualiser As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
