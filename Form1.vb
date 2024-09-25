Public Class Form1

    Dim doc_Font As New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)
    Dim lblEscribeTemperatura As New Label()
    Dim txtTemperaturaInput As New TextBox()
    Dim lblTemp1 As New Label()
    Dim btnIntercalar As New Button()
    Dim lblTemp2 As New Label()
    Dim lblResultado As New Label
    Dim btnConvertir As New Button()
    Dim lblOutputResultado As New Label
    Dim lblOutputTipoInfo As New Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblEscribeTemperatura.Dock = DockStyle.Fill
        lblEscribeTemperatura.Text = "Escriba la Temperatura: "
        lblEscribeTemperatura.AutoSize = True
        lblEscribeTemperatura.Left = 0
        lblEscribeTemperatura.Top = 240
        lblEscribeTemperatura.Font = doc_Font

        txtTemperaturaInput.Left = 160
        txtTemperaturaInput.Font = doc_Font
        lblEscribeTemperatura.Controls.Add(txtTemperaturaInput)
        AddHandler txtTemperaturaInput.KeyPress, AddressOf txtTemperaturaInput_KeyPress


        TablaController.Controls.Add(lblEscribeTemperatura, 0, 0)

        lblTemp1.Text = "ºF"
        lblTemp1.AutoSize = True
        lblTemp1.Font = doc_Font
        TablaController.Controls.Add(lblTemp1, 1, 0)

        btnIntercalar.Text = "Alternar"
        btnIntercalar.BackColor = System.Drawing.Color.FromArgb(0, 196, 196, 249)
        btnIntercalar.AutoSize = True
        btnIntercalar.Font = doc_Font
        TablaController.Controls.Add(btnIntercalar, 2, 0)
        AddHandler btnIntercalar.Click, AddressOf btnAlternar_Click

        lblTemp2.Text = "ºC"
        lblTemp2.AutoSize = True
        lblTemp2.Font = doc_Font
        TablaController.Controls.Add(lblTemp2, 3, 0)

        lblResultado.Text = "Resultado: "
        lblResultado.AutoSize = True
        lblResultado.Font = doc_Font
        PanelResultado.Controls.Add(lblResultado)

        lblOutputResultado.Text = ""
        lblOutputResultado.AutoSize = True
        lblOutputResultado.Font = doc_Font
        PanelOutputResult.Controls.Add(lblOutputResultado)

        btnConvertir.Text = "Convertir"
        btnConvertir.BackColor = System.Drawing.Color.FromArgb(0, 196, 196, 249)
        btnConvertir.AutoSize = True
        btnConvertir.Font = doc_Font
        PanelBuscar.Controls.Add(btnConvertir)
        AddHandler btnConvertir.Click, AddressOf btnConvertir_Click

        lblOutputTipoInfo.Text = "ºC"
        lblOutputTipoInfo.AutoSize = True
        lblOutputTipoInfo.Font = doc_Font
        PanelInfoGrados.Controls.Add(lblOutputTipoInfo)

    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs)
        Try
            Dim temperatura As Double = CDbl(txtTemperaturaInput.Text)
            If lblTemp1.Text.Contains("C") Then
                lblOutputResultado.Text = ((temperatura * 9 / 5) + 32).ToString("N2")
            Else
                lblOutputResultado.Text = ((temperatura - 32) * 5 / 9).ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show("Por favor, introduce un valor numérico válido.")
        End Try
    End Sub


    Private Sub btnAlternar_Click(sender As Object, e As EventArgs)
        Dim txt1 As String = lblTemp1.Text
        Dim txt2 As String = lblTemp2.Text

        lblOutputTipoInfo.Text = txt1
        lblOutputResultado.Text = ""

        lblTemp1.Text = txt2
        lblTemp2.Text = txt1

    End Sub


    Private Sub txtTemperaturaInput_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Permitir dígitos, retroceso y el carácter de coma o punto decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub


End Class