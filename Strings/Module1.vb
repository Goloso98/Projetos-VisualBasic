Module Module1
    Function func_contar_letra(texto As String, letra As String) As Integer 'feito
        Dim tamanho As Integer
        Dim contador As Integer

        tamanho = Len(texto)
        contador = 0

        For pos = 1 To tamanho
            If Mid(texto, pos, 1) = letra Then
                contador += 1
            End If
        Next

        Return contador
    End Function

    Function func_contar_letras(texto As String, letras As String, mostar_soma_individual As Boolean) As String 'feito
        'SE "so_soma" --> mostra só soma mostra SENAO (valor detalhado) quantidade individual das letras
        Dim tamanho, tamanho2, contador As Integer
        Dim letra, texto2 As String

        tamanho = Len(texto)
        letras = func_tudodiferente(letras)
        tamanho2 = Len(letras)
        texto2 = ""

        For pos = 1 To tamanho2
            letra = Mid(letras, pos, 1)
            contador += func_contar_letra(texto, letra)
            texto2 += letra & " --> " & func_contar_letra(texto, letra) & vbCrLf

        Next
        texto2 += "Soma = " & contador

        If mostar_soma_individual = True Then
            Return texto2
        Else
            Return contador
        End If
    End Function

    Function func_trim(texto As String) As String 'feito
        Dim tamanho As Integer
        Dim texto2 As String

        texto = Trim(texto)
        tamanho = Len(texto)
        texto2 = ""

        For pos = 1 To tamanho
            If Mid(texto, pos, 1) <> " " Then
                texto2 += Mid(texto, pos, 1)
            ElseIf Mid(texto, pos, 1) = " " And Mid(texto, pos + 1, 1) <> " " Then
                texto2 += " "
            End If
        Next
        Return texto2
    End Function

    Function func_tudodiferente(texto As String) As String 'feito
        Dim tamanho As Integer
        Dim texto2 As String
        Dim tamanho2 As Integer
        Dim pos2 As Integer
        Dim contador As Integer

        tamanho = Len(texto)
        texto2 = ""

        For pos = 1 To tamanho
            tamanho2 = Len(texto2)
            pos2 = 1
            contador = 0

            While pos2 <= tamanho2 And contador >= 0
                If Mid(texto, pos, 1) = Mid(texto2, pos2, 1) Then
                    contador += 1
                End If
                pos2 += 1
            End While

            If contador = 0 Then
                texto2 += Mid(texto, pos, 1)
            End If

        Next

        Return texto2
    End Function

    Function func_replace(texto As String, letra_a_substituir As String, letra_a_substutuir_por As String) As String
        Dim tamanho As Integer
        Dim texto_output As String

        texto_output = ""
        tamanho = Len(texto)

        For pos = 1 To tamanho
            If UCase(Mid(texto, pos, 1)) = UCase(letra_a_substituir) Then
                texto_output += letra_a_substutuir_por
            Else
                texto_output += Mid(texto, pos, 1)
            End If
        Next

        Return texto_output
    End Function
End Module
