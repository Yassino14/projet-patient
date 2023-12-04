<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.dgv_2 = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_rdv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.btn_ch = New System.Windows.Forms.Button()
        Me.btn_ann = New System.Windows.Forms.Button()
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_2
        '
        Me.dgv_2.BackgroundColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.date_rdv})
        Me.dgv_2.Location = New System.Drawing.Point(338, 60)
        Me.dgv_2.Name = "dgv_2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_2.Size = New System.Drawing.Size(303, 130)
        Me.dgv_2.TabIndex = 0
        '
        'Code
        '
        Me.Code.HeaderText = "Code_Rdv"
        Me.Code.Name = "Code"
        '
        'date_rdv
        '
        Me.date_rdv.HeaderText = "Date_Rdv"
        Me.date_rdv.Name = "date_rdv"
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(521, 240)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(91, 29)
        Me.btn_retour.TabIndex = 1
        Me.btn_retour.Text = "Retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(364, 221)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(85, 25)
        Me.txt_code.TabIndex = 3
        '
        'btn_ch
        '
        Me.btn_ch.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ch.Location = New System.Drawing.Point(364, 262)
        Me.btn_ch.Name = "btn_ch"
        Me.btn_ch.Size = New System.Drawing.Size(106, 29)
        Me.btn_ch.TabIndex = 4
        Me.btn_ch.Text = "Chercher"
        Me.btn_ch.UseVisualStyleBackColor = True
        '
        'btn_ann
        '
        Me.btn_ann.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ann.Location = New System.Drawing.Point(364, 297)
        Me.btn_ann.Name = "btn_ann"
        Me.btn_ann.Size = New System.Drawing.Size(113, 29)
        Me.btn_ann.TabIndex = 5
        Me.btn_ann.Text = "Supprimer"
        Me.btn_ann.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_ann)
        Me.Controls.Add(Me.btn_ch)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.dgv_2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_2 As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents date_rdv As DataGridViewTextBoxColumn
    Friend WithEvents btn_retour As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents btn_ch As Button
    Friend WithEvents btn_ann As Button
End Class
