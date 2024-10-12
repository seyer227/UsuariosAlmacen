Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Actualiza()
        'TODO: esta línea de código carga datos en la tabla '_db_vdaDataSet.Entidades' Puede moverla o quitarla según sea necesario.
        Me.EntidadesTableAdapter.Fill(Me._db_vdaDataSet.Entidades)
        'TODO: esta línea de código carga datos en la tabla '_db_vdaDataSet.Areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me._db_vdaDataSet.Areas)
        ' Cargar datos en las tablas
        Me.AutorizadoresTableAdapter.Fill(Me._db_vdaDataSet.Autorizadores)
        ' Cargar nombres de autorizadores en el ComboBox
        Dim dt As New DataTable()
        dt = Me._db_vdaDataSet.Autorizadores

        AutorizadorComboBox.DataSource = dt
        AutorizadorComboBox.DisplayMember = "Nombre" ' Campo que se mostrará
        AutorizadorComboBox.ValueMember = "Usuario"      ' Valor asociado

        Dim dt2 As New DataTable()
        dt2 = Me._db_vdaDataSet.Areas

        AreaComboBox.DataSource = dt2
        AreaComboBox.DisplayMember = "Area" ' Campo que se mostrará
        AreaComboBox.ValueMember = "Area"      ' Valor asociado

        Dim dt3 As New DataTable()
        dt3 = Me._db_vdaDataSet.Entidades

        EntidadComboBox.DataSource = dt3
        EntidadComboBox.DisplayMember = "Entidad" ' Campo que se mostrará
        EntidadComboBox.ValueMember = "Entidad"      ' Valor asociado


        ' Añadir los valores al ComboBox TipoUsuario
        TipoUsuarioComboBox.Items.Add(New KeyValuePair(Of String, Integer)("Solicitante", 1))
        TipoUsuarioComboBox.Items.Add(New KeyValuePair(Of String, Integer)("Autorizador", 2))
        TipoUsuarioComboBox.Items.Add(New KeyValuePair(Of String, Integer)("Jefe de Almacen", 3))
        TipoUsuarioComboBox.Items.Add(New KeyValuePair(Of String, Integer)("Almacenista", 4))
        TipoUsuarioComboBox.Items.Add(New KeyValuePair(Of String, Integer)("Autorizador EPP", 10))

        ' Mostrar solo el texto en el ComboBox
        TipoUsuarioComboBox.DisplayMember = "Key"
        TipoUsuarioComboBox.ValueMember = "Value"
        UsuariosDataGridView_SelectionChanged(Nothing, Nothing)
    End Sub


    Private Sub Actualiza()
        Me.UsuariosTableAdapter.Fill(Me._db_vdaDataSet.Usuarios)
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        UsuariosBindingSource.AddNew()
        UsuarioTextBox.Focus()

        ' Limpiar el ComboBox de Autorizador al agregar un nuevo usuario
        AutorizadorComboBox.SelectedIndex = -1  ' O bien: AutorizadorComboBox.SelectedValue = Nothing
    End Sub


    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        UsuariosBindingSource.RemoveCurrent()
        UsuariosTableAdapter.Update(_db_vdaDataSet.Usuarios)
        Actualiza()
    End Sub

    Function Completo() As Boolean
        If UsuarioTextBox.Text = "" Then
            MsgBox("El campo 'Usuario' es obligatorio.")
            Return False
        ElseIf NombreTextBox.Text = "" Then
            MsgBox("El campo 'Nombre' es obligatorio.")
            Return False
        ElseIf ContraseñaTextBox.Text = "" Then
            MsgBox("El campo 'Contraseña' es obligatorio.")
            Return False
        ElseIf CorreoTextBox.Text = "" Then
            MsgBox("El campo 'Correo' es obligatorio.")
            Return False
        ElseIf CentroCostoTextBox.Text = "" Then
            MsgBox("El campo 'Centro de Costos' es obligatorio.")
            Return False
        ElseIf String.IsNullOrEmpty(TipoUsuarioComboBox.Text) Then
            MsgBox("Debe seleccionar un tipo de usuario.")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub BGuardad_Click(sender As Object, e As EventArgs) Handles BGuardad.Click
        If Completo() Then
            Try
                Dim tipoUsuario As Integer

                ' Obtener el tipo de usuario
                If IsNumeric(TipoUsuarioComboBox.Text) Then
                    tipoUsuario = Convert.ToInt32(TipoUsuarioComboBox.Text)
                Else
                    Dim selectedPair As KeyValuePair(Of String, Integer) =
                    CType(TipoUsuarioComboBox.SelectedItem, KeyValuePair(Of String, Integer))

                    tipoUsuario = selectedPair.Value
                End If

                ' Asignar el valor de TipoUsuario al registro actual
                CType(UsuariosBindingSource.Current, DataRowView)("TipoUsuario") = tipoUsuario

                ' Procesar el autorizador seleccionado
                Dim autorizadorID As String = CStr(AutorizadorComboBox.SelectedValue) ' Asegúrate de que sea un string
                CType(UsuariosBindingSource.Current, DataRowView)("Autorizador") = autorizadorID

                ' Procesar los valores de AlmacenesTextBox
                Dim almacenes As String = AlmacenesTextBox.Text

                ' Formatear los valores de almacenes
                Dim almacenesFormateados As String = FormatearAlmacenes(almacenes)

                ' Asignar los valores formateados al registro actual
                CType(UsuariosBindingSource.Current, DataRowView)("Almacenes") = almacenesFormateados

                ' Guardar los cambios
                UsuariosBindingSource.EndEdit()
                UsuariosTableAdapter.Update(_db_vdaDataSet.Usuarios)
                Actualiza()
            Catch ex As Exception
                MsgBox("Error al guardar el registro: " & ex.Message)
            End Try
        End If
    End Sub


    ' Función para formatear los almacenes
    Private Function FormatearAlmacenes(almacenes As String) As String
        Try
            ' Separar los valores por coma
            Dim valores As String() = almacenes.Split(","c)

            ' Formatear cada valor si no tiene comillas simples
            Dim valoresFormateados As New List(Of String)()

            For Each valor In valores
                ' Quitar espacios en blanco, si los hay
                valor = valor.Trim()

                ' Verificar si el valor ya tiene comillas simples
                If valor.StartsWith("'") AndAlso valor.EndsWith("'") Then
                    ' Si ya tiene comillas, dejarlo tal cual
                    valoresFormateados.Add(valor)
                Else
                    ' Si no tiene comillas, agregar ceros a la izquierda y comillas simples
                    If IsNumeric(valor) Then
                        valor = valor.PadLeft(5, "0"c)
                        valoresFormateados.Add("'" & valor & "'")
                    Else
                        MsgBox("El valor '" & valor & "' no es un número válido.")
                        Return String.Empty
                    End If
                End If
            Next

            ' Unir los valores formateados con comas
            Return String.Join(",", valoresFormateados)

        Catch ex As Exception
            MsgBox("Error al formatear los almacenes: " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        UsuariosBindingSource.CancelEdit()
    End Sub

    Private Sub UsuariosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UsuariosDataGridView.SelectionChanged
        If UsuariosBindingSource.Current IsNot Nothing Then
            Dim currentRow As DataRowView = CType(UsuariosBindingSource.Current, DataRowView)

            ' Autorizador ComboBox
            If Not IsDBNull(currentRow("Autorizador")) Then
                Dim autorizadorID As String = CStr(currentRow("Autorizador"))
                If AutorizadorComboBox.Items.Count > 0 Then
                    Try
                        AutorizadorComboBox.SelectedValue = autorizadorID
                    Catch ex As Exception
                        MsgBox("Error al seleccionar autorizador: " & ex.Message)
                    End Try
                End If
            Else
                AutorizadorComboBox.SelectedIndex = -1 ' Limpiar selección si es DBNull
            End If

            ' Area ComboBox
            If Not IsDBNull(currentRow("Area")) Then
                Dim areaID As String = CStr(currentRow("Area"))
                If AreaComboBox.Items.Count > 0 Then
                    Try
                        AreaComboBox.SelectedValue = areaID
                    Catch ex As Exception
                        MsgBox("Error al seleccionar área: " & ex.Message)
                    End Try
                End If
            Else
                AreaComboBox.SelectedIndex = -1 ' Limpiar selección si es DBNull
            End If

            ' Entidad ComboBox
            If Not IsDBNull(currentRow("Entidad")) Then
                Dim entidadID As String = CStr(currentRow("Entidad"))
                If EntidadComboBox.Items.Count > 0 Then
                    Try
                        EntidadComboBox.SelectedValue = entidadID
                    Catch ex As Exception
                        MsgBox("Error al seleccionar entidad: " & ex.Message)
                    End Try
                End If
            Else
                EntidadComboBox.SelectedIndex = -1 ' Limpiar selección si es DBNull
            End If
        End If
    End Sub

    Private Sub AutrorizadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutrorizadoresToolStripMenuItem.Click
        FAutorizadoresAlta.Show()
        Me.Hide() ' Oculta el Form1 en lugar de cerrarlo
    End Sub

    Private Sub CorreoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CorreoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CorreoTextBox.TextChanged

    End Sub

    Private Sub NombreLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged

    End Sub

    Private Sub Bbuscar_Click(sender As Object, e As EventArgs) Handles Bbuscar.Click
        Dim filtro As String = Txbuscar.Text.Trim()

        ' Verificar si el campo de búsqueda no está vacío
        If filtro <> "" Then
            ' Crear el filtro para el BindingSource que se está utilizando en el DataGridView
            ' Suponiendo que quieres buscar en el campo 'Usuario' o 'Nombre', puedes ajustar los campos según tu estructura
            UsuariosBindingSource.Filter = String.Format("Usuario LIKE '%{0}%' OR Nombre LIKE '%{0}%'", filtro)
        Else
            ' Si el campo está vacío, mostrar todos los registros
            UsuariosBindingSource.Filter = ""
        End If
    End Sub

End Class
