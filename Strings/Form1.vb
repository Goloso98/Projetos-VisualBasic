Public Class Form1
    Private Sub txt_texto_input_TextChanged(sender As Object, e As EventArgs) Handles txt_texto_input.TextChanged
        cmb_primeiros.Maximum = Len(txt_texto_input.Text)
        cmb_ultimos.Maximum = Len(txt_texto_input.Text)
    End Sub

    Private Sub but_n_carateres_Click(sender As Object, e As EventArgs) Handles but_n_carateres.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            txt_texto_output.Text = Len(txt_texto_input.Text)
        End If
    End Sub

    Private Sub txt_contar_letra_TextChanged(sender As Object, e As EventArgs) Handles txt_contar_letra.TextChanged
        If Len(txt_contar_letra.Text) > 1 Then
            txt_contar_letra.Text = Mid(txt_contar_letra.Text, 1, 1)
            txt_texto_output.Text = "[INFO]" & vbCrLf & "só suporta uma letra!!!"
        End If
    End Sub

    Private Sub txt_letra_a_substituir_TextChanged(sender As Object, e As EventArgs) Handles txt_letra_a_substituir.TextChanged
        If Len(txt_letra_a_substituir.Text) > 1 Then
            txt_letra_a_substituir.Text = Mid(txt_letra_a_substituir.Text, 1, 1)
            txt_texto_output.Text = "[INFO]" & vbCrLf & "só suporta uma letra!!!"
        End If
    End Sub

    Private Sub txt_letra_a_substituir_por_TextChanged(sender As Object, e As EventArgs) Handles txt_letra_a_substituir_por.TextChanged
        If Len(txt_letra_a_substituir_por.Text) > 1 Then
            txt_letra_a_substituir_por.Text = Mid(txt_letra_a_substituir_por.Text, 1, 1)
            txt_texto_output.Text = "[INFO]" & vbCrLf & "só suporta uma letra!!!"
        End If
    End Sub

    Private Sub txt_letra_a_substituir_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_letra_a_substituir.MouseClick
        txt_texto_output.Text = "[INFO]" & vbCrLf & "letra a substituir:"
    End Sub

    Private Sub txt_letra_a_substituir_por_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_letra_a_substituir_por.MouseClick
        txt_texto_output.Text = "[INFO]" & vbCrLf & "letra a substituir:"
    End Sub

    Private Sub but_mostar_primeiros_Click(sender As Object, e As EventArgs) Handles but_mostar_primeiros.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            txt_texto_output.Text = Microsoft.VisualBasic.Left(txt_texto_input.Text, cmb_primeiros.Value)
        End If
    End Sub

    Private Sub but_mostar_ultimos_Click(sender As Object, e As EventArgs) Handles but_mostar_ultimos.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            txt_texto_output.Text = Microsoft.VisualBasic.Right(txt_texto_input.Text, cmb_ultimos.Value)
        End If
    End Sub

    Private Sub but_contar_letra_Click(sender As Object, e As EventArgs) Handles but_contar_letra.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            If ckb_maiuscula_letra.Checked Then
                txt_texto_output.Text = func_contar_letra(UCase(txt_texto_input.Text), UCase(txt_contar_letra.Text))
            Else
                txt_texto_output.Text = func_contar_letra(txt_texto_input.Text, txt_contar_letra.Text)
            End If

        End If
    End Sub

    Private Sub but_contar_letras_Click(sender As Object, e As EventArgs) Handles but_contar_letras.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            If ckb_maiuscula_letras.Checked Then
                txt_texto_output.Text = func_contar_letras(UCase(txt_texto_input.Text), UCase(txt_contar_letras.Text), ckb_mostar_soma_individual.Checked)
            Else
                txt_texto_output.Text = func_contar_letras(txt_texto_input.Text, txt_contar_letras.Text, ckb_mostar_soma_individual.Checked)
            End If

        End If
    End Sub

    Private Sub but_contar_vogais_Click(sender As Object, e As EventArgs) Handles but_contar_vogais.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            Dim soma As Integer
            soma = 0
            soma += func_contar_letra(UCase(txt_texto_input.Text), "A")
            soma += func_contar_letra(UCase(txt_texto_input.Text), "E")
            soma += func_contar_letra(UCase(txt_texto_input.Text), "I")
            soma += func_contar_letra(UCase(txt_texto_input.Text), "O")
            soma += func_contar_letra(UCase(txt_texto_input.Text), "U")
            txt_texto_output.Text = soma
        End If
    End Sub

    Private Sub but_substituir_letra_Click(sender As Object, e As EventArgs) Handles but_substituir_letra.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            txt_texto_output.Text = func_replace(txt_texto_input.Text, txt_letra_a_substituir.Text, txt_letra_a_substituir_por.Text)
        End If
    End Sub

    Private Sub but_trim_Click(sender As Object, e As EventArgs) Handles but_trim.Click

        If txt_texto_input.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio" & vbCrLf & "escreva algo"
        Else
            txt_texto_output.Text = func_trim(txt_texto_input.Text)
        End If
    End Sub

    Private Sub but_substituir_original_Click(sender As Object, e As EventArgs) Handles but_substituir_original.Click

        If txt_texto_output.Text = "" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "campo vazio"
        ElseIf Mid(txt_texto_output.Text, 1, 6) = "[INFO]" Then
            txt_texto_output.Text = "[INFO]" & vbCrLf & "proteção contra informação da aplicação."
        Else
            txt_texto_input.Text = txt_texto_output.Text
        End If
    End Sub

    Private Sub ckb_maiuscula_letra_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_maiuscula_letra.CheckedChanged
        txt_texto_output.Text = "[INFO]" & vbCrLf & "ignorar maiúscula ou minúscula"
    End Sub

    Private Sub ckb_maiuscula_letras_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_maiuscula_letras.CheckedChanged
        txt_texto_output.Text = "[INFO]" & vbCrLf & "ignorar maiúsculas ou minúsculas"
    End Sub
End Class
