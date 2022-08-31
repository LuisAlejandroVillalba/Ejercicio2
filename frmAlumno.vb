Public Class frmAlumno
    Dim servicio As New ServiceReference1.WebService1SoapClient
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim CodAlum = txtCodAlumno.Text
        Dim Nombre = txtNombres.Text
        Dim Apellidos = txtApellidos.Text
        Dim LugarNac = txtLugarNac.Text
        Dim FechaNac As Date = CType(txtFechaNac.Text, Date)
        Dim CodEscuela = txtCodEscu.Text
        Dim Agrega = servicio.Agregar(CodAlum, Apellidos, Nombre, LugarNac, FechaNac, CodEscuela)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim CodAlum = txtCodAlumno.Text
        Dim Nombre = txtNombres.Text
        Dim Apellidos = txtApellidos.Text
        Dim LugarNac = txtLugarNac.Text
        Dim FechaNac As Date = CType(txtFechaNac.Text, Date)
        Dim CodEscuela = txtCodEscu.Text
        Dim Actualiza = servicio.ActualizarAlumno(CodAlum, Apellidos, Nombre, LugarNac, FechaNac, CodEscuela)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Codalum = txtCodAlumno.Text
        Dim Salida = servicio.EliminarAlumno(Codalum)

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim lista As DataSet = servicio.Listar()
        dgvAlumnos.DataSource = lista.Tables(0)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class