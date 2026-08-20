<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RENDEZVOUS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cmdchercher = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdsupprimer = New DevComponents.DotNetBar.ButtonX()
        Me.cmdreserver = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(611, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 41)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "GESTION DES RENDEZ-VOUS"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1942, 290)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.DarkBlue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Cyan
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left
        Me.PanelEx1.Style.BorderWidth = 0
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 91
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.appointment
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(469, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Label3)
        Me.PanelEx2.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx2.Controls.Add(Me.cmdchercher)
        Me.PanelEx2.Controls.Add(Me.TextBox1)
        Me.PanelEx2.Controls.Add(Me.Label2)
        Me.PanelEx2.Controls.Add(Me.cmdsupprimer)
        Me.PanelEx2.Controls.Add(Me.cmdreserver)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 290)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1942, 812)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Cyan
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.RoyalBlue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left
        Me.PanelEx2.Style.BorderWidth = 0
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(643, 632)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(626, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "* Pour reserver un rendez-vous  ajouter premierement le patient "
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
        Me.DataGridViewX1.Location = New System.Drawing.Point(178, 144)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowTemplate.Height = 24
        Me.DataGridViewX1.Size = New System.Drawing.Size(1495, 485)
        Me.DataGridViewX1.TabIndex = 8
        '
        'cmdchercher
        '
        Me.cmdchercher.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_chercher_38
        Me.cmdchercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdchercher.Location = New System.Drawing.Point(636, 54)
        Me.cmdchercher.Name = "cmdchercher"
        Me.cmdchercher.Size = New System.Drawing.Size(84, 47)
        Me.cmdchercher.TabIndex = 7
        Me.cmdchercher.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(410, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 27)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "chercher un rendez-vous :"
        '
        'cmdsupprimer
        '
        Me.cmdsupprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdsupprimer.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdsupprimer.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.cmdsupprimer.Location = New System.Drawing.Point(1469, 46)
        Me.cmdsupprimer.Name = "cmdsupprimer"
        Me.cmdsupprimer.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.cmdsupprimer.Size = New System.Drawing.Size(191, 44)
        Me.cmdsupprimer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdsupprimer.TabIndex = 4
        Me.cmdsupprimer.Text = "Supprimer"
        '
        'cmdreserver
        '
        Me.cmdreserver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdreserver.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdreserver.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.cmdreserver.Location = New System.Drawing.Point(1223, 46)
        Me.cmdreserver.Name = "cmdreserver"
        Me.cmdreserver.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.cmdreserver.Size = New System.Drawing.Size(191, 44)
        Me.cmdreserver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdreserver.TabIndex = 3
        Me.cmdreserver.Text = "Reserver"
        '
        'RENDEZVOUS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RENDEZVOUS"
        Me.Text = "RENDEZVOUS"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cmdsupprimer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdreserver As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdchercher As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
