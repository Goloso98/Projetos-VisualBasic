<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_texto_input = New System.Windows.Forms.TextBox()
        Me.txt_texto_output = New System.Windows.Forms.TextBox()
        Me.but_n_carateres = New System.Windows.Forms.Button()
        Me.but_mostar_primeiros = New System.Windows.Forms.Button()
        Me.but_mostar_ultimos = New System.Windows.Forms.Button()
        Me.cmb_primeiros = New System.Windows.Forms.NumericUpDown()
        Me.cmb_ultimos = New System.Windows.Forms.NumericUpDown()
        Me.but_contar_letra = New System.Windows.Forms.Button()
        Me.txt_contar_letra = New System.Windows.Forms.TextBox()
        Me.but_contar_vogais = New System.Windows.Forms.Button()
        Me.but_substituir_letra = New System.Windows.Forms.Button()
        Me.but_contar_letras = New System.Windows.Forms.Button()
        Me.txt_contar_letras = New System.Windows.Forms.TextBox()
        Me.ckb_mostar_soma_individual = New System.Windows.Forms.CheckBox()
        Me.txt_letra_a_substituir = New System.Windows.Forms.TextBox()
        Me.txt_letra_a_substituir_por = New System.Windows.Forms.TextBox()
        Me.but_trim = New System.Windows.Forms.Button()
        Me.but_substituir_original = New System.Windows.Forms.Button()
        Me.ckb_maiuscula_letra = New System.Windows.Forms.CheckBox()
        Me.ckb_maiuscula_letras = New System.Windows.Forms.CheckBox()
        CType(Me.cmb_primeiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ultimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_texto_input
        '
        Me.txt_texto_input.Location = New System.Drawing.Point(12, 12)
        Me.txt_texto_input.Multiline = True
        Me.txt_texto_input.Name = "txt_texto_input"
        Me.txt_texto_input.Size = New System.Drawing.Size(184, 166)
        Me.txt_texto_input.TabIndex = 0
        Me.txt_texto_input.Text = "Input Text"
        '
        'txt_texto_output
        '
        Me.txt_texto_output.Location = New System.Drawing.Point(12, 184)
        Me.txt_texto_output.Multiline = True
        Me.txt_texto_output.Name = "txt_texto_output"
        Me.txt_texto_output.ReadOnly = True
        Me.txt_texto_output.Size = New System.Drawing.Size(184, 155)
        Me.txt_texto_output.TabIndex = 0
        '
        'but_n_carateres
        '
        Me.but_n_carateres.Location = New System.Drawing.Point(286, 12)
        Me.but_n_carateres.Name = "but_n_carateres"
        Me.but_n_carateres.Size = New System.Drawing.Size(125, 30)
        Me.but_n_carateres.TabIndex = 1
        Me.but_n_carateres.Text = "Contar Carateres"
        Me.but_n_carateres.UseVisualStyleBackColor = True
        '
        'but_mostar_primeiros
        '
        Me.but_mostar_primeiros.Location = New System.Drawing.Point(286, 48)
        Me.but_mostar_primeiros.Name = "but_mostar_primeiros"
        Me.but_mostar_primeiros.Size = New System.Drawing.Size(125, 43)
        Me.but_mostar_primeiros.TabIndex = 1
        Me.but_mostar_primeiros.Text = "Mostrar Primeiros"
        Me.but_mostar_primeiros.UseVisualStyleBackColor = True
        '
        'but_mostar_ultimos
        '
        Me.but_mostar_ultimos.Location = New System.Drawing.Point(286, 97)
        Me.but_mostar_ultimos.Name = "but_mostar_ultimos"
        Me.but_mostar_ultimos.Size = New System.Drawing.Size(125, 30)
        Me.but_mostar_ultimos.TabIndex = 1
        Me.but_mostar_ultimos.Text = "Mostrar Últimos"
        Me.but_mostar_ultimos.UseVisualStyleBackColor = True
        '
        'cmb_primeiros
        '
        Me.cmb_primeiros.Location = New System.Drawing.Point(202, 69)
        Me.cmb_primeiros.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.cmb_primeiros.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmb_primeiros.Name = "cmb_primeiros"
        Me.cmb_primeiros.Size = New System.Drawing.Size(78, 22)
        Me.cmb_primeiros.TabIndex = 3
        Me.cmb_primeiros.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmb_ultimos
        '
        Me.cmb_ultimos.Location = New System.Drawing.Point(202, 105)
        Me.cmb_ultimos.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.cmb_ultimos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmb_ultimos.Name = "cmb_ultimos"
        Me.cmb_ultimos.Size = New System.Drawing.Size(78, 22)
        Me.cmb_ultimos.TabIndex = 3
        Me.cmb_ultimos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'but_contar_letra
        '
        Me.but_contar_letra.Location = New System.Drawing.Point(286, 133)
        Me.but_contar_letra.Name = "but_contar_letra"
        Me.but_contar_letra.Size = New System.Drawing.Size(125, 30)
        Me.but_contar_letra.TabIndex = 1
        Me.but_contar_letra.Text = "Contar Letra"
        Me.but_contar_letra.UseVisualStyleBackColor = True
        '
        'txt_contar_letra
        '
        Me.txt_contar_letra.Location = New System.Drawing.Point(202, 141)
        Me.txt_contar_letra.Name = "txt_contar_letra"
        Me.txt_contar_letra.Size = New System.Drawing.Size(54, 22)
        Me.txt_contar_letra.TabIndex = 2
        '
        'but_contar_vogais
        '
        Me.but_contar_vogais.Location = New System.Drawing.Point(286, 238)
        Me.but_contar_vogais.Name = "but_contar_vogais"
        Me.but_contar_vogais.Size = New System.Drawing.Size(125, 30)
        Me.but_contar_vogais.TabIndex = 1
        Me.but_contar_vogais.Text = "Contar Vogais"
        Me.but_contar_vogais.UseVisualStyleBackColor = True
        '
        'but_substituir_letra
        '
        Me.but_substituir_letra.Location = New System.Drawing.Point(286, 274)
        Me.but_substituir_letra.Name = "but_substituir_letra"
        Me.but_substituir_letra.Size = New System.Drawing.Size(125, 30)
        Me.but_substituir_letra.TabIndex = 1
        Me.but_substituir_letra.Text = "Substituir Letra"
        Me.but_substituir_letra.UseVisualStyleBackColor = True
        '
        'but_contar_letras
        '
        Me.but_contar_letras.Location = New System.Drawing.Point(286, 169)
        Me.but_contar_letras.Name = "but_contar_letras"
        Me.but_contar_letras.Size = New System.Drawing.Size(125, 30)
        Me.but_contar_letras.TabIndex = 1
        Me.but_contar_letras.Text = "Contar Letras"
        Me.but_contar_letras.UseVisualStyleBackColor = True
        '
        'txt_contar_letras
        '
        Me.txt_contar_letras.Location = New System.Drawing.Point(202, 177)
        Me.txt_contar_letras.Name = "txt_contar_letras"
        Me.txt_contar_letras.Size = New System.Drawing.Size(54, 22)
        Me.txt_contar_letras.TabIndex = 2
        '
        'ckb_mostar_soma_individual
        '
        Me.ckb_mostar_soma_individual.AutoSize = True
        Me.ckb_mostar_soma_individual.Location = New System.Drawing.Point(281, 205)
        Me.ckb_mostar_soma_individual.Name = "ckb_mostar_soma_individual"
        Me.ckb_mostar_soma_individual.Size = New System.Drawing.Size(130, 21)
        Me.ckb_mostar_soma_individual.TabIndex = 4
        Me.ckb_mostar_soma_individual.Text = "Mostar por letra"
        Me.ckb_mostar_soma_individual.UseVisualStyleBackColor = True
        '
        'txt_letra_a_substituir
        '
        Me.txt_letra_a_substituir.Location = New System.Drawing.Point(202, 282)
        Me.txt_letra_a_substituir.Name = "txt_letra_a_substituir"
        Me.txt_letra_a_substituir.Size = New System.Drawing.Size(36, 22)
        Me.txt_letra_a_substituir.TabIndex = 5
        '
        'txt_letra_a_substituir_por
        '
        Me.txt_letra_a_substituir_por.Location = New System.Drawing.Point(244, 282)
        Me.txt_letra_a_substituir_por.Name = "txt_letra_a_substituir_por"
        Me.txt_letra_a_substituir_por.Size = New System.Drawing.Size(36, 22)
        Me.txt_letra_a_substituir_por.TabIndex = 5
        '
        'but_trim
        '
        Me.but_trim.Location = New System.Drawing.Point(285, 310)
        Me.but_trim.Name = "but_trim"
        Me.but_trim.Size = New System.Drawing.Size(125, 30)
        Me.but_trim.TabIndex = 1
        Me.but_trim.Text = "Trim"
        Me.but_trim.UseVisualStyleBackColor = True
        '
        'but_substituir_original
        '
        Me.but_substituir_original.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.but_substituir_original.Location = New System.Drawing.Point(417, 12)
        Me.but_substituir_original.Name = "but_substituir_original"
        Me.but_substituir_original.Size = New System.Drawing.Size(42, 328)
        Me.but_substituir_original.TabIndex = 7
        Me.but_substituir_original.Text = "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "b" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "g" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "n" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l"
        Me.but_substituir_original.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.but_substituir_original.UseVisualStyleBackColor = True
        '
        'ckb_maiuscula_letra
        '
        Me.ckb_maiuscula_letra.AutoSize = True
        Me.ckb_maiuscula_letra.Location = New System.Drawing.Point(262, 146)
        Me.ckb_maiuscula_letra.Name = "ckb_maiuscula_letra"
        Me.ckb_maiuscula_letra.Size = New System.Drawing.Size(18, 17)
        Me.ckb_maiuscula_letra.TabIndex = 8
        Me.ckb_maiuscula_letra.UseVisualStyleBackColor = True
        '
        'ckb_maiuscula_letras
        '
        Me.ckb_maiuscula_letras.AutoSize = True
        Me.ckb_maiuscula_letras.Location = New System.Drawing.Point(262, 181)
        Me.ckb_maiuscula_letras.Name = "ckb_maiuscula_letras"
        Me.ckb_maiuscula_letras.Size = New System.Drawing.Size(18, 17)
        Me.ckb_maiuscula_letras.TabIndex = 8
        Me.ckb_maiuscula_letras.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 351)
        Me.Controls.Add(Me.ckb_maiuscula_letras)
        Me.Controls.Add(Me.ckb_maiuscula_letra)
        Me.Controls.Add(Me.but_substituir_original)
        Me.Controls.Add(Me.but_trim)
        Me.Controls.Add(Me.txt_letra_a_substituir_por)
        Me.Controls.Add(Me.txt_letra_a_substituir)
        Me.Controls.Add(Me.ckb_mostar_soma_individual)
        Me.Controls.Add(Me.cmb_ultimos)
        Me.Controls.Add(Me.cmb_primeiros)
        Me.Controls.Add(Me.txt_contar_letras)
        Me.Controls.Add(Me.txt_contar_letra)
        Me.Controls.Add(Me.but_substituir_letra)
        Me.Controls.Add(Me.but_contar_vogais)
        Me.Controls.Add(Me.but_contar_letras)
        Me.Controls.Add(Me.but_contar_letra)
        Me.Controls.Add(Me.but_mostar_ultimos)
        Me.Controls.Add(Me.but_mostar_primeiros)
        Me.Controls.Add(Me.but_n_carateres)
        Me.Controls.Add(Me.txt_texto_output)
        Me.Controls.Add(Me.txt_texto_input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.cmb_primeiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ultimos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_texto_input As TextBox
    Friend WithEvents txt_texto_output As TextBox
    Friend WithEvents but_n_carateres As Button
    Friend WithEvents but_mostar_primeiros As Button
    Friend WithEvents but_mostar_ultimos As Button
    Friend WithEvents cmb_primeiros As NumericUpDown
    Friend WithEvents cmb_ultimos As NumericUpDown
    Friend WithEvents but_contar_letra As Button
    Friend WithEvents txt_contar_letra As TextBox
    Friend WithEvents but_contar_vogais As Button
    Friend WithEvents but_substituir_letra As Button
    Friend WithEvents but_contar_letras As Button
    Friend WithEvents txt_contar_letras As TextBox
    Friend WithEvents ckb_mostar_soma_individual As CheckBox
    Friend WithEvents txt_letra_a_substituir As TextBox
    Friend WithEvents txt_letra_a_substituir_por As TextBox
    Friend WithEvents but_trim As Button
    Friend WithEvents but_substituir_original As Button
    Friend WithEvents ckb_maiuscula_letra As CheckBox
    Friend WithEvents ckb_maiuscula_letras As CheckBox
End Class
