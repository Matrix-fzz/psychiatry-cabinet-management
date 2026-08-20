<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSCRIPTION
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtmotdepasse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtemail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtprenom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdinscrire = New DevComponents.DotNetBar.ButtonX()
        Me.Txtnom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(898, 160)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Navy
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Aqua
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.StyleMouseDown.BorderWidth = 0
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.PanelEx2.Controls.Add(Me.Button1)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(898, 36)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Black
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Navy
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.BorderWidth = 0
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_x_48
        Me.Button1.Location = New System.Drawing.Point(858, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.GESTION_CABINET_DE_PSYCHIATRIE.My.Resources.Resources.icons8_nom_96
        Me.PictureBox1.Location = New System.Drawing.Point(319, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboBoxEx1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Txtmotdepasse)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txtemail)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtprenom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdinscrire)
        Me.Panel1.Controls.Add(Me.Txtnom)
        Me.Panel1.Location = New System.Drawing.Point(175, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 457)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(25, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 28)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Mot de Passe  :"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBoxEx1.ItemHeight = 29
        Me.ComboBoxEx1.Location = New System.Drawing.Point(201, 260)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(267, 35)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.ComboBoxEx1.TabIndex = 19
        Me.ComboBoxEx1.WatermarkColor = System.Drawing.Color.Gray
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(25, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 28)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Type  :"
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
        Me.Txtmotdepasse.Location = New System.Drawing.Point(201, 321)
        Me.Txtmotdepasse.Name = "Txtmotdepasse"
        Me.Txtmotdepasse.Size = New System.Drawing.Size(267, 39)
        Me.Txtmotdepasse.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(25, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Email :"
        '
        'Txtemail
        '
        Me.Txtemail.BackColor = System.Drawing.Color.AliceBlue
        '
        '
        '
        Me.Txtemail.Border.BorderBottomColor = System.Drawing.Color.Navy
        Me.Txtemail.Border.BorderBottomWidth = 5
        Me.Txtemail.Border.BorderColor = System.Drawing.Color.AliceBlue
        Me.Txtemail.Border.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2
        Me.Txtemail.Border.BorderGradientAngle = 180
        Me.Txtemail.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Txtemail.Border.Class = "TextBoxBorder"
        Me.Txtemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtemail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtemail.Location = New System.Drawing.Point(201, 195)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(267, 39)
        Me.Txtemail.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(25, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Prenom :"
        '
        'Txtprenom
        '
        Me.Txtprenom.BackColor = System.Drawing.Color.AliceBlue
        '
        '
        '
        Me.Txtprenom.Border.BorderBottomColor = System.Drawing.Color.Navy
        Me.Txtprenom.Border.BorderBottomWidth = 5
        Me.Txtprenom.Border.BorderColor = System.Drawing.Color.AliceBlue
        Me.Txtprenom.Border.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2
        Me.Txtprenom.Border.BorderGradientAngle = 180
        Me.Txtprenom.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Txtprenom.Border.Class = "TextBoxBorder"
        Me.Txtprenom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtprenom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprenom.Location = New System.Drawing.Point(201, 130)
        Me.Txtprenom.Name = "Txtprenom"
        Me.Txtprenom.Size = New System.Drawing.Size(267, 39)
        Me.Txtprenom.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(25, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nom :"
        '
        'cmdinscrire
        '
        Me.cmdinscrire.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdinscrire.BackColor = System.Drawing.Color.AliceBlue
        Me.cmdinscrire.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cmdinscrire.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.cmdinscrire.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdinscrire.Location = New System.Drawing.Point(201, 398)
        Me.cmdinscrire.Name = "cmdinscrire"
        Me.cmdinscrire.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(9)
        Me.cmdinscrire.Size = New System.Drawing.Size(164, 35)
        Me.cmdinscrire.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.cmdinscrire.TabIndex = 5
        Me.cmdinscrire.Text = "S'inscrire"
        '
        'Txtnom
        '
        Me.Txtnom.BackColor = System.Drawing.Color.AliceBlue
        '
        '
        '
        Me.Txtnom.Border.BorderBottomColor = System.Drawing.Color.Navy
        Me.Txtnom.Border.BorderBottomWidth = 5
        Me.Txtnom.Border.BorderColor = System.Drawing.Color.AliceBlue
        Me.Txtnom.Border.BorderColorLightSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBarBackground2
        Me.Txtnom.Border.BorderGradientAngle = 180
        Me.Txtnom.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Txtnom.Border.Class = "TextBoxBorder"
        Me.Txtnom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txtnom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnom.Location = New System.Drawing.Point(201, 65)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(267, 39)
        Me.Txtnom.TabIndex = 3
        '
        'INSCRIPTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 730)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "INSCRIPTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INSCRIPTION"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdinscrire As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Txtnom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Txtmotdepasse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtemail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtprenom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
