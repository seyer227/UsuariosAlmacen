Public Class FAutorizadoresAlta
    Private Sub FAutorizadores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit() ' Esto cerrará toda la aplicación cuando FAutorizadores se cierre
    End Sub

    Private Sub AutorizadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AutorizadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._db_vdaDataSet)

    End Sub

    Private Sub FAutorizadoresAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_db_vdaDataSet.Entidades' Puede moverla o quitarla según sea necesario.
        Me.EntidadesTableAdapter.Fill(Me._db_vdaDataSet.Entidades)
        'TODO: esta línea de código carga datos en la tabla '_db_vdaDataSet.Areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me._db_vdaDataSet.Areas)
        'TODO: esta línea de código carga datos en la tabla '_db_vdaDataSet.Autorizadores' Puede moverla o quitarla según sea necesario.
        Actualiza()

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

        AutorizadoresDataGridView_SelectionChanged(Nothing, Nothing)

    End Sub

    Private Sub Actualiza()
        Me.AutorizadoresTableAdapter.Fill(Me._db_vdaDataSet.Autorizadores)
    End Sub


    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Form1.Show()
        Me.Hide() ' Oculta el Form1 en lugar de cerrarl
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        AutorizadoresBindingSource.AddNew()
        UsuarioTextBox.Focus()
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        AutorizadoresBindingSource.RemoveCurrent()
        AutorizadoresTableAdapter.Update(_db_vdaDataSet.Autorizadores)
        Actualiza()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' Verificar si el valor en UsuarioTextBox ya existe en la tabla
        Dim usuarioIngresado As String = UsuarioTextBox.Text.Trim()

        ' Obtener el registro actual que se está editando
        Dim currentRow As DataRowView = CType(AutorizadoresBindingSource.Current, DataRowView)

        ' Verificar si el registro es nuevo o si es una edición de un registro existente
        Dim esNuevoRegistro As Boolean = IsDBNull(currentRow("id")) OrElse String.IsNullOrEmpty(currentRow("id").ToString())

        ' Buscar si ya existe un registro con el mismo valor en la columna "Usuario" (excepto el que estamos editando)
        Dim usuarioExistente = _db_vdaDataSet.Autorizadores.AsEnumerable().
                           Where(Function(row) row.Field(Of String)("Usuario") = usuarioIngresado AndAlso
                                           row.Field(Of String)("id") <> currentRow("id").ToString())

        ' Si ya existe un usuario con el mismo nombre (y no es el que estamos editando), mostrar advertencia
        If usuarioExistente.Any() Then
            MessageBox.Show("El usuario '" & usuarioIngresado & "' ya existe. Por favor, ingrese otro usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Si es un nuevo registro, obtener el valor máximo de la columna "id" y asignar un nuevo id
        If esNuevoRegistro Then
            Dim maxId As Integer
            If _db_vdaDataSet.Autorizadores.Rows.Count > 0 Then
                ' Filtrar las filas que tengan un valor no nulo y un id numérico
                Dim validRows = _db_vdaDataSet.Autorizadores.AsEnumerable().
                            Where(Function(row) Not IsDBNull(row("id")) AndAlso IsNumeric(row("id")))

                If validRows.Any() Then
                    ' Obtener el valor numérico máximo del id
                    maxId = validRows.Max(Function(row) Convert.ToInt32(row.Field(Of String)("id")))
                Else
                    maxId = 0 ' Si todas las filas tienen valores nulos o no numéricos, empieza desde 0
                End If
            Else
                maxId = 0 ' Si no hay registros, empieza desde 0 o cualquier valor inicial
            End If

            ' Convertir el nuevo id a cadena sin ceros a la izquierda
            Dim newId As String = (maxId + 1).ToString()

            ' Asignar el nuevo valor de id sin ceros a la izquierda si es un nuevo registro
            currentRow("id") = newId
        End If

        ' Guardar los cambios
        AutorizadoresBindingSource.EndEdit()
        AutorizadoresTableAdapter.Update(_db_vdaDataSet.Autorizadores)
        Actualiza()
    End Sub



    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        AutorizadoresBindingSource.CancelEdit()
    End Sub

    Private Sub AutorizadoresDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles AutorizadoresDataGridView.SelectionChanged
        If AutorizadoresBindingSource.Current IsNot Nothing Then
            Dim currentRow As DataRowView = CType(AutorizadoresBindingSource.Current, DataRowView)

            ' Asegurarse de que los ComboBox tengan configurados ValueMember y DisplayMember
            If AreaComboBox.Items.Count > 0 AndAlso String.IsNullOrEmpty(AreaComboBox.ValueMember) Then
                AreaComboBox.DisplayMember = "Area" ' Campo que se mostrará
                AreaComboBox.ValueMember = "Area" ' Valor asociado
            End If

            If EntidadComboBox.Items.Count > 0 AndAlso String.IsNullOrEmpty(EntidadComboBox.ValueMember) Then
                EntidadComboBox.DisplayMember = "Entidad" ' Campo que se mostrará
                EntidadComboBox.ValueMember = "Entidad" ' Valor asociado
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

End Class