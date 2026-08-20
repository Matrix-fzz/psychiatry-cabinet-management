<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdconnecter = New DevComponents.DotNetBar.ButtonX()
        Me.Txtmotdepasse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txtusername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdconnecter)
        Me.Panel1.Controls.Add(Me.Txtmotdepasse)
        Me.Panel1.Controls.Add(Me.Txtusername)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Location = New System.Drawing.Point(209, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 350)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(21, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mot de Passe :"
        '
        'cmdconnecter
        '
        Me.cmdconnecter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdconnecter.BackColor = System.Drawing.Color.AliceBlue
        Me.cmdconnecter.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdconnecter.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.cmdconnecter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdconnecter.Location = New System.Drawing.Point(174, 267)
        Me.cmdconnecter.Name = "cmdconnecter"
        Me.cmdconnecter.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(9)
        Me.cmdconnecter.Size = New System.Drawing.Size(164, 35)
        Me.cmdconnecter.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdconnecter.TabIndex = 5
        Me.cmdconnecter.Text = "connecter"
        '
        'Txtmotdepasse
        '
        Me.Txtmotdepasse.BackColor = System.Drawing.Color.AliceBlue
        '
        '
        '
        Me.Txtmotdepasse.Border.BorderBottomColor = System.Drawing.Color.Navy
        Me.Txtmotdepasse.Border.BorderBottomWidth = 5
        Me.Txtmotdepasse.Border.BorderColor = System.Drawing.Color.AliceBlue
        Me.Txtmotdepasse.Border.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2
        Me.Txtmotdepasse.Border.BorderGradientAngle = 180
        Me.Txtmotdepasse.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Txtmotdepasse.Border.Class = "TextBoxBorder"
        Me.Txtmotdepasse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtmotdepasse.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmotdepasse.Location = New System.Drawing.Point(174, 156)
        Me.Txtmotdepasse.Name = "Txtmotdepasse"
        Me.Txtmotdepasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtmotdepasse.Size = New System.Drawing.Size(267, 39)
        Me.Txtmotdepasse.TabIndex = 4
        '
        'Txtusername
        '
        Me.Txtusername.BackColor = System.Drawing.Color.AliceBlue
        '
        '
        '
        Me.Txtusername.Border.BorderBottomColor = System.Drawing.Color.Navy
        Me.Txtusername.Border.BorderBottomWidth = 5
        Me.Txtusername.Border.BorderColor = System.Drawing.Color.AliceBlue
        Me.Txtusername.Border.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2
        Me.Txtusername.Border.BorderGradientAngle = 180
        Me.Txtusername.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Txtusername.Border.Class = "TextBoxBorder"
        Me.Txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtusername.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(174, 102)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(267, 39)
        Me.Txtusername.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(171, 219)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(163, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Oblier le Mot de Passe ?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_nom_96
        Me.PictureBox1.Location = New System.Drawing.Point(383, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.PanelEx1.Controls.Add(Me.Button1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(892, 36)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Navy
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.BorderWidth = 0
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_x_48
        Me.Button1.Location = New System.Drawing.Point(852, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(186, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 67)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "AUTHENTIFICATION"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.pexels_felixmittermeier_956981
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Txtusername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Txtmotdepasse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmdconnecter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
