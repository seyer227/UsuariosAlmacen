<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAutorizadoresAlta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim EntidadLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim CentroCostoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.AutorizadoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._db_vdaDataSet = New UsuariosAlmacen._db_vdaDataSet()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.EntidadComboBox = New System.Windows.Forms.ComboBox()
        Me.EntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.CentroCostoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizadoresTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.AutorizadoresTableAdapter()
        Me.TableAdapterManager = New UsuariosAlmacen._db_vdaDataSetTableAdapters.TableAdapterManager()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.AreasTableAdapter()
        Me.EntidadesTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.EntidadesTableAdapter()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        EntidadLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CentroCostoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.AutorizadoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutorizadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._db_vdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(24, 208)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(102, 29)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "Usuario:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AreaLabel.Location = New System.Drawing.Point(584, 208)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(69, 29)
        AreaLabel.TabIndex = 5
        AreaLabel.Text = "Area:"
        '
        'EntidadLabel
        '
        EntidadLabel.AutoSize = True
        EntidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EntidadLabel.Location = New System.Drawing.Point(552, 263)
        EntidadLabel.Name = "EntidadLabel"
        EntidadLabel.Size = New System.Drawing.Size(101, 29)
        EntidadLabel.TabIndex = 7
        EntidadLabel.Text = "Entidad:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(1312, 208)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(94, 29)
        CorreoLabel.TabIndex = 13
        CorreoLabel.Text = "Correo:"
        '
        'CentroCostoLabel
        '
        CentroCostoLabel.AutoSize = True
        CentroCostoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CentroCostoLabel.Location = New System.Drawing.Point(1248, 263)
        CentroCostoLabel.Name = "CentroCostoLabel"
        CentroCostoLabel.Size = New System.Drawing.Size(160, 29)
        CentroCostoLabel.TabIndex = 15
        CentroCostoLabel.Text = "Centro Costo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(16, 263)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 17
        NombreLabel.Text = "Nombre:"
        '
        'AutorizadoresDataGridView
        '
        Me.AutorizadoresDataGridView.AllowUserToAddRows = False
        Me.AutorizadoresDataGridView.AllowUserToDeleteRows = False
        Me.AutorizadoresDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutorizadoresDataGridView.AutoGenerateColumns = False
        Me.AutorizadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutorizadoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.AutorizadoresDataGridView.DataSource = Me.AutorizadoresBindingSource
        Me.AutorizadoresDataGridView.Location = New System.Drawing.Point(8, 359)
        Me.AutorizadoresDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AutorizadoresDataGridView.Name = "AutorizadoresDataGridView"
        Me.AutorizadoresDataGridView.ReadOnly = True
        Me.AutorizadoresDataGridView.RowHeadersWidth = 51
        Me.AutorizadoresDataGridView.RowTemplate.Height = 24
        Me.AutorizadoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutorizadoresDataGridView.Size = New System.Drawing.Size(2320, 586)
        Me.AutorizadoresDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Entidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Entidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NumeroWhatsaspp"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NumeroWhatsaspp"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GrupoWhatsaspp"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GrupoWhatsaspp"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CentroCosto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CentroCosto"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'AutorizadoresBindingSource
        '
        Me.AutorizadoresBindingSource.DataMember = "Autorizadores"
        Me.AutorizadoresBindingSource.DataSource = Me._db_vdaDataSet
        '
        '_db_vdaDataSet
        '
        Me._db_vdaDataSet.DataSetName = "_db_vdaDataSet"
        Me._db_vdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(144, 199)
        Me.UsuarioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(151, 38)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "Area", True))
        Me.AreaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(680, 199)
        Me.AreaComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(552, 39)
        Me.AreaComboBox.TabIndex = 6
        '
        'EntidadComboBox
        '
        Me.EntidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "Entidad", True))
        Me.EntidadComboBox.DataSource = Me.EntidadesBindingSource
        Me.EntidadComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntidadComboBox.FormattingEnabled = True
        Me.EntidadComboBox.Location = New System.Drawing.Point(680, 254)
        Me.EntidadComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EntidadComboBox.Name = "EntidadComboBox"
        Me.EntidadComboBox.Size = New System.Drawing.Size(552, 39)
        Me.EntidadComboBox.TabIndex = 8
        '
        'EntidadesBindingSource
        '
        Me.EntidadesBindingSource.DataMember = "Entidades"
        Me.EntidadesBindingSource.DataSource = Me._db_vdaDataSet
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "Correo", True))
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(1432, 199)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(424, 38)
        Me.CorreoTextBox.TabIndex = 14
        '
        'CentroCostoTextBox
        '
        Me.CentroCostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "CentroCosto", True))
        Me.CentroCostoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CentroCostoTextBox.Location = New System.Drawing.Point(1432, 256)
        Me.CentroCostoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CentroCostoTextBox.Name = "CentroCostoTextBox"
        Me.CentroCostoTextBox.Size = New System.Drawing.Size(192, 38)
        Me.CentroCostoTextBox.TabIndex = 16
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutorizadoresBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(144, 256)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(392, 38)
        Me.NombreTextBox.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(580, 32)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Administrador de Autorizadores para VDA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UsuariosAlmacen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(72, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(2367, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.IrAToolStripMenuItem.Text = "Administrar.."
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AutorizadoresTableAdapter
        '
        Me.AutorizadoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreasTableAdapter = Nothing
        Me.TableAdapterManager.AutorizadoresTableAdapter = Me.AutorizadoresTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EntidadesTableAdapter = Nothing
        Me.TableAdapterManager.UnidadMedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UsuariosAlmacen._db_vdaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "Areas"
        Me.AreasBindingSource.DataSource = Me._db_vdaDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'EntidadesTableAdapter
        '
        Me.EntidadesTableAdapter.ClearBeforeFill = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(904, 71)
        Me.BNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(184, 71)
        Me.BNuevo.TabIndex = 30
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(1112, 71)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(184, 71)
        Me.BGuardar.TabIndex = 31
        Me.BGuardar.Text = "Guardar "
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(1312, 71)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(184, 71)
        Me.BCancelar.TabIndex = 32
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(1504, 71)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(184, 71)
        Me.BEliminar.TabIndex = 33
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'FAutorizadoresAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2367, 967)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaComboBox)
        Me.Controls.Add(EntidadLabel)
        Me.Controls.Add(Me.EntidadComboBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(CentroCostoLabel)
        Me.Controls.Add(Me.CentroCostoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.AutorizadoresDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FAutorizadoresAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAutorizadoresAlta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AutorizadoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutorizadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._db_vdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _db_vdaDataSet As _db_vdaDataSet
    Friend WithEvents AutorizadoresBindingSource As BindingSource
    Friend WithEvents AutorizadoresTableAdapter As _db_vdaDataSetTableAdapters.AutorizadoresTableAdapter
    Friend WithEvents TableAdapterManager As _db_vdaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutorizadoresDataGridView As DataGridView
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents AreaComboBox As ComboBox
    Friend WithEvents EntidadComboBox As ComboBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents CentroCostoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreasBindingSource As BindingSource
    Friend WithEvents AreasTableAdapter As _db_vdaDataSetTableAdapters.AreasTableAdapter
    Friend WithEvents EntidadesBindingSource As BindingSource
    Friend WithEvents EntidadesTableAdapter As _db_vdaDataSetTableAdapters.EntidadesTableAdapter
    Friend WithEvents BNuevo As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
