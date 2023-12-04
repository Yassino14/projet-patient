<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_coder = New System.Windows.Forms.TextBox()
        Me.dtp_r = New System.Windows.Forms.DateTimePicker()
        Me.btn_ret = New System.Windows.Forms.Button()
        Me.btn_annul = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rendez-vous"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code"
        '
        'txt_coder
        '
        Me.txt_coder.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_coder.Location = New System.Drawing.Point(375, 121)
        Me.txt_coder.Name = "txt_coder"
        Me.txt_coder.Size = New System.Drawing.Size(92, 27)
        Me.txt_coder.TabIndex = 2
        '
        'dtp_r
        '
        Me.dtp_r.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_r.Location = New System.Drawing.Point(248, 185)
        Me.dtp_r.Name = "dtp_r"
        Me.dtp_r.Size = New System.Drawing.Size(353, 31)
        Me.dtp_r.TabIndex = 3
        '
        'btn_ret
        '
        Me.btn_ret.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ret.Location = New System.Drawing.Point(516, 239)
        Me.btn_ret.Name = "btn_ret"
        Me.btn_ret.Size = New System.Drawing.Size(85, 37)
        Me.btn_ret.TabIndex = 4
        Me.btn_ret.Text = "Return"
        Me.btn_ret.UseVisualStyleBackColor = True
        '
        'btn_annul
        '
        Me.btn_annul.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annul.Location = New System.Drawing.Point(382, 239)
        Me.btn_annul.Name = "btn_annul"
        Me.btn_annul.Size = New System.Drawing.Size(85, 37)
        Me.btn_annul.TabIndex = 5
        Me.btn_annul.Text = "Reset"
        Me.btn_annul.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(260, 239)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(85, 37)
        Me.btn_valider.TabIndex = 6
        Me.btn_valider.Text = "Submit"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annul)
        Me.Controls.Add(Me.btn_ret)
        Me.Controls.Add(Me.dtp_r)
        Me.Controls.Add(Me.txt_coder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_coder As TextBox
    Friend WithEvents dtp_r As DateTimePicker
    Friend WithEvents btn_ret As Button
    Friend WithEvents btn_annul As Button
    Friend WithEvents btn_valider As Button
End Class
