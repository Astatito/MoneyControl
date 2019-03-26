Imports System.Threading

Public Class frmExcel

    Friend dgvExportar As DataGridView
    Friend ruta As String

    Dim valores As Object
    Dim app As Microsoft.Office.Interop.Excel.Application
    Dim libro As Microsoft.Office.Interop.Excel.Workbook
    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        txtUbicacion.Text = Config.RutaExcelPorDefecto
    End Sub

    Public Sub New(ByVal info As String)
        InitializeComponent()
        txtNombre.Text = info + "_" + DateTime.Today.Day.ToString + "-" + DateTime.Today.Month.ToString + "-" + DateTime.Today.Year.ToString
        txtUbicacion.Text = Config.RutaExcelPorDefecto
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf CargarVariables)
        thr.Start()
    End Sub

    'Evento Click del Botón Aceptar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ruta = txtUbicacion.Text + "\" + txtNombre.Text

        If dgvExportar.Rows.Count <> 0 Then
            Cursor.Current = Cursors.WaitCursor
            If CopiarDatos(ruta, dgvExportar) = True Then
                MessageBox.Show("Los datos se exportaron correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                MessageBox.Show("Se produjo un error al exportar los datos. Por favor, intente nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("La tabla está vacía y no hay datos para exportar. Por favor, revisa los datos e intenta nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    'Evento Click del Botón Buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        fbDialog.ShowDialog()
        txtUbicacion.Text = fbDialog.SelectedPath
    End Sub

    'Evento Click del Botón Cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Setear las variables necesarias para exportar a Excel
    Private Sub CargarVariables()
        valores = Reflection.Missing.Value
        app = New Microsoft.Office.Interop.Excel.Application
        app.Visible = False
        libro = app.Workbooks.Add(valores)
        hoja = libro.Sheets("Hoja1")

        btnAceptar.Enabled = True
        btnAceptar.Text = "Aceptar"
    End Sub

    'Copiar datos desde el DataGridView a una hoja de Excel
    Private Function CopiarDatos(ByVal nombreArchivo As String, ByRef dgv As DataGridView) As Boolean
        Try
            For k As Integer = 1 To dgv.Columns.Count
                hoja.Cells(1, k) = dgv.Columns(k - 1).HeaderText
            Next

            For i As Integer = 0 To (dgv.RowCount - 1)
                For j As Integer = 0 To (dgv.ColumnCount - 1)
                    hoja.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
                Next
            Next

            GuardarArchivo(nombreArchivo)

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Guardar el archivo y liberar las variables
    Private Sub GuardarArchivo(ByVal nombreArchivo As String)
        hoja.SaveAs(nombreArchivo)
        libro.Close()
        app.Quit()

        GC.Collect()
    End Sub
End Class