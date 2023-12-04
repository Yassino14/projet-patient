<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.RendezvouzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRENDRERDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AFFICHAGEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Yellow
        Me.MenuStrip1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem, Me.AffichageToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'AjoutToolStripMenuItem
        '
        Me.AjoutToolStripMenuItem.Name = "AjoutToolStripMenuItem"
        Me.AjoutToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AjoutToolStripMenuItem.Text = "Ajout"
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        Me.AffichageToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AffichageToolStripMenuItem.Text = "Affichage"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.MenuStrip2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RendezvouzToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'RendezvouzToolStripMenuItem
        '
        Me.RendezvouzToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRENDRERDVToolStripMenuItem, Me.AFFICHAGEToolStripMenuItem1})
        Me.RendezvouzToolStripMenuItem.Name = "RendezvouzToolStripMenuItem"
        Me.RendezvouzToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RendezvouzToolStripMenuItem.Text = "Rendez-vouz"
        '
        'PRENDRERDVToolStripMenuItem
        '
        Me.PRENDRERDVToolStripMenuItem.Name = "PRENDRERDVToolStripMenuItem"
        Me.PRENDRERDVToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PRENDRERDVToolStripMenuItem.Text = "PRENDRE RDV"
        '
        'AFFICHAGEToolStripMenuItem1
        '
        Me.AFFICHAGEToolStripMenuItem1.Name = "AFFICHAGEToolStripMenuItem1"
        Me.AFFICHAGEToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.AFFICHAGEToolStripMenuItem1.Text = "AFFICHAGE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AffichageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents RendezvouzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRENDRERDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AFFICHAGEToolStripMenuItem1 As ToolStripMenuItem
End Class
