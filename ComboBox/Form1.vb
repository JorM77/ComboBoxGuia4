Public Class ComboBox

    Private Sub ComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOCARRERA.SelectedIndex = 0
        'CBOCARRERA.Items.Add("MARKETING")
        llenarColumnas()
    End Sub
    Private Sub llenarColumnas()
        DGVLISTADO.Columns.Add("nom", "Nombres")
        DGVLISTADO.Columns.Add("carrera", "Carrera")
        DGVLISTADO.Columns.Add("curso", "Cursos")

    End Sub

    Private Sub CBOCARRERA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOCARRERA.SelectedIndexChanged
        Dim POS As Integer
        POS = CBOCARRERA.SelectedIndex
        Select Case (POS)
            Case 0
            Case 1 : LLENAR_SISTEMAS()
            Case 2 : LLENAR_CONTABILIDAD()
            Case 3 : LLENAR_DISEÑO()
        End Select
    End Sub
    Private Sub LLENAR_SISTEMAS()
        CBOCURSOS.Items.Clear()
        CBOCURSOS.Items.Add("SEGURIDAD INFORMATICA")
        CBOCURSOS.Items.Add("PROGRAMACION")
        CBOCURSOS.Items.Add("REDES")
    End Sub
    Private Sub LLENAR_CONTABILIDAD()
        CBOCURSOS.Items.Clear()
        CBOCURSOS.Items.Add("CALCULO DIFERENCIAL")
        CBOCURSOS.Items.Add("CALCULO INTEGRAL")
        CBOCURSOS.Items.Add("CALCULO AVANZADO")
    End Sub
    Private Sub LLENAR_DISEÑO()
        CBOCURSOS.Items.Clear()
        CBOCURSOS.Items.Add("DISEÑO DE REDES")
        CBOCURSOS.Items.Add("DESARROLLO DE SOFWARE")
        CBOCURSOS.Items.Add("PROGRAMACION ESTRUCTURADA")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Pos As Integer
        Pos = DGVLISTADO.Rows.Count - 1
        DGVLISTADO.Rows.Add()
        DGVLISTADO.Rows(Pos).Cells(0).Value = TXTNOMBRE.Text
        DGVLISTADO.Rows(Pos).Cells(1).Value = CBOCARRERA.SelectedItem
        DGVLISTADO.Rows(Pos).Cells(2).Value = CBOCURSOS.SelectedItem
        LIMPIAR()
    End Sub
    Private Sub LIMPIAR()
        TXTNOMBRE.Text = ""
        TXTNOMBRE.Focus()
        CBOCARRERA.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
