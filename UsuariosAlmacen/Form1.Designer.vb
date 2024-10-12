<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim TipoUsuarioLabel As System.Windows.Forms.Label
        Dim EntidadLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim CentroCostoLabel As System.Windows.Forms.Label
        Dim AlmacenesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NumeroWhatsAppLabel As System.Windows.Forms.Label
        Dim GrupoWhatsAppLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._db_vdaDataSet = New UsuariosAlmacen._db_vdaDataSet()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoUsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.EntidadComboBox = New System.Windows.Forms.ComboBox()
        Me.BGuardad = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.CentroCostoTextBox = New System.Windows.Forms.TextBox()
        Me.AlmacenesTextBox = New System.Windows.Forms.TextBox()
        Me.AutorizadorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IrAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutrorizadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AutorizadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumeroWhatsAppTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoWhatsAppTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txbuscar = New System.Windows.Forms.TextBox()
        Me.Bbuscar = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New UsuariosAlmacen._db_vdaDataSetTableAdapters.TableAdapterManager()
        Me.AutorizadoresTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.AutorizadoresTableAdapter()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.AreasTableAdapter()
        Me.EntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntidadesTableAdapter = New UsuariosAlmacen._db_vdaDataSetTableAdapters.EntidadesTableAdapter()
        UsuarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        TipoUsuarioLabel = New System.Windows.Forms.Label()
        EntidadLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        CentroCostoLabel = New System.Windows.Forms.Label()
        AlmacenesLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NumeroWhatsAppLabel = New System.Windows.Forms.Label()
        GrupoWhatsAppLabel = New System.Windows.Forms.Label()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._db_vdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AutorizadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(469, 208)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(102, 29)
        UsuarioLabel.TabIndex = 2
        UsuarioLabel.Text = "Usuario:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(24, 208)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(107, 29)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        AddHandler NombreLabel.Click, AddressOf Me.NombreLabel_Click
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(832, 256)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(142, 29)
        ContraseñaLabel.TabIndex = 6
        ContraseñaLabel.Text = "Contraseña:"
        '
        'TipoUsuarioLabel
        '
        TipoUsuarioLabel.AutoSize = True
        TipoUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoUsuarioLabel.Location = New System.Drawing.Point(840, 304)
        TipoUsuarioLabel.Name = "TipoUsuarioLabel"
        TipoUsuarioLabel.Size = New System.Drawing.Size(109, 29)
        TipoUsuarioLabel.TabIndex = 8
        TipoUsuarioLabel.Text = "Permiso:"
        '
        'EntidadLabel
        '
        EntidadLabel.AutoSize = True
        EntidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EntidadLabel.Location = New System.Drawing.Point(472, 264)
        EntidadLabel.Name = "EntidadLabel"
        EntidadLabel.Size = New System.Drawing.Size(101, 29)
        EntidadLabel.TabIndex = 11
        EntidadLabel.Text = "Entidad:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(24, 264)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(94, 29)
        CorreoLabel.TabIndex = 16
        CorreoLabel.Text = "Correo:"
        AddHandler CorreoLabel.Click, AddressOf Me.CorreoLabel_Click
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AreaLabel.Location = New System.Drawing.Point(856, 360)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(69, 29)
        AreaLabel.TabIndex = 18
        AreaLabel.Text = "Area:"
        '
        'CentroCostoLabel
        '
        CentroCostoLabel.AutoSize = True
        CentroCostoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CentroCostoLabel.Location = New System.Drawing.Point(832, 208)
        CentroCostoLabel.Name = "CentroCostoLabel"
        CentroCostoLabel.Size = New System.Drawing.Size(160, 29)
        CentroCostoLabel.TabIndex = 20
        CentroCostoLabel.Text = "Centro Costo:"
        '
        'AlmacenesLabel
        '
        AlmacenesLabel.AutoSize = True
        AlmacenesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlmacenesLabel.Location = New System.Drawing.Point(8, 357)
        AlmacenesLabel.Name = "AlmacenesLabel"
        AlmacenesLabel.Size = New System.Drawing.Size(138, 29)
        AlmacenesLabel.TabIndex = 21
        AlmacenesLabel.Text = "Almacenes:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(24, 312)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(135, 29)
        Label1.TabIndex = 24
        Label1.Text = "Autorizador"
        '
        'NumeroWhatsAppLabel
        '
        NumeroWhatsAppLabel.AutoSize = True
        NumeroWhatsAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroWhatsAppLabel.Location = New System.Drawing.Point(1128, 256)
        NumeroWhatsAppLabel.Name = "NumeroWhatsAppLabel"
        NumeroWhatsAppLabel.Size = New System.Drawing.Size(102, 25)
        NumeroWhatsAppLabel.TabIndex = 28
        NumeroWhatsAppLabel.Text = "Whatsapp"
        '
        'GrupoWhatsAppLabel
        '
        GrupoWhatsAppLabel.AutoSize = True
        GrupoWhatsAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrupoWhatsAppLabel.Location = New System.Drawing.Point(1128, 208)
        GrupoWhatsAppLabel.Name = "GrupoWhatsAppLabel"
        GrupoWhatsAppLabel.Size = New System.Drawing.Size(123, 29)
        GrupoWhatsAppLabel.TabIndex = 30
        GrupoWhatsAppLabel.Text = "GrupoWA:"
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(23, 416)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.RowHeadersWidth = 51
        Me.UsuariosDataGridView.RowTemplate.Height = 24
        Me.UsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(1720, 355)
        Me.UsuariosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TipoUsuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TipoUsuario"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Entidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Entidad"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NumeroWhatsApp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NumeroWhatsApp"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GrupoWhatsApp"
        Me.DataGridViewTextBoxColumn9.HeaderText = "GrupoWhatsApp"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CentroCosto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CentroCosto"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Autorizador"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Autorizador"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Almacenes"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Almacenes"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 450
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me._db_vdaDataSet
        '
        '_db_vdaDataSet
        '
        Me._db_vdaDataSet.DataSetName = "_db_vdaDataSet"
        Me._db_vdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(560, 201)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(256, 38)
        Me.UsuarioTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(136, 201)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(327, 38)
        Me.NombreTextBox.TabIndex = 5
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(960, 248)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(160, 38)
        Me.ContraseñaTextBox.TabIndex = 11
        '
        'TipoUsuarioComboBox
        '
        Me.TipoUsuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "TipoUsuario", True))
        Me.TipoUsuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoUsuarioComboBox.FormattingEnabled = True
        Me.TipoUsuarioComboBox.Location = New System.Drawing.Point(960, 296)
        Me.TipoUsuarioComboBox.Name = "TipoUsuarioComboBox"
        Me.TipoUsuarioComboBox.Size = New System.Drawing.Size(280, 39)
        Me.TipoUsuarioComboBox.TabIndex = 14
        '
        'BNuevo
        '
        Me.BNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BNuevo.Location = New System.Drawing.Point(1264, 88)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(168, 72)
        Me.BNuevo.TabIndex = 3
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'EntidadComboBox
        '
        Me.EntidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Entidad", True))
        Me.EntidadComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntidadComboBox.FormattingEnabled = True
        Me.EntidadComboBox.Location = New System.Drawing.Point(560, 256)
        Me.EntidadComboBox.Name = "EntidadComboBox"
        Me.EntidadComboBox.Size = New System.Drawing.Size(256, 39)
        Me.EntidadComboBox.TabIndex = 10
        '
        'BGuardad
        '
        Me.BGuardad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BGuardad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardad.Location = New System.Drawing.Point(1096, 88)
        Me.BGuardad.Name = "BGuardad"
        Me.BGuardad.Size = New System.Drawing.Size(160, 72)
        Me.BGuardad.TabIndex = 2
        Me.BGuardad.Text = "Guardar"
        Me.BGuardad.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BEliminar.Location = New System.Drawing.Point(1440, 88)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(160, 72)
        Me.BEliminar.TabIndex = 4
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BCancelar.Location = New System.Drawing.Point(936, 88)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(152, 72)
        Me.BCancelar.TabIndex = 1
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Correo", True))
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(136, 256)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(328, 38)
        Me.CorreoTextBox.TabIndex = 9
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Area", True))
        Me.AreaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(952, 352)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(288, 39)
        Me.AreaComboBox.TabIndex = 16
        '
        'CentroCostoTextBox
        '
        Me.CentroCostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "CentroCosto", True))
        Me.CentroCostoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CentroCostoTextBox.Location = New System.Drawing.Point(960, 200)
        Me.CentroCostoTextBox.Name = "CentroCostoTextBox"
        Me.CentroCostoTextBox.Size = New System.Drawing.Size(160, 38)
        Me.CentroCostoTextBox.TabIndex = 7
        '
        'AlmacenesTextBox
        '
        Me.AlmacenesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Almacenes", True))
        Me.AlmacenesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmacenesTextBox.Location = New System.Drawing.Point(136, 352)
        Me.AlmacenesTextBox.Name = "AlmacenesTextBox"
        Me.AlmacenesTextBox.Size = New System.Drawing.Size(680, 38)
        Me.AlmacenesTextBox.TabIndex = 15
        '
        'AutorizadorComboBox
        '
        Me.AutorizadorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorizadorComboBox.FormattingEnabled = True
        Me.AutorizadorComboBox.ItemHeight = 31
        Me.AutorizadorComboBox.Location = New System.Drawing.Point(136, 304)
        Me.AutorizadorComboBox.Name = "AutorizadorComboBox"
        Me.AutorizadorComboBox.Size = New System.Drawing.Size(680, 39)
        Me.AutorizadorComboBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(609, 39)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Administrador de Usuarios para VDA"
        '
        'IrAToolStripMenuItem
        '
        Me.IrAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutrorizadoresToolStripMenuItem})
        Me.IrAToolStripMenuItem.Name = "IrAToolStripMenuItem"
        Me.IrAToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.IrAToolStripMenuItem.Text = "Administrar.."
        '
        'AutrorizadoresToolStripMenuItem
        '
        Me.AutrorizadoresToolStripMenuItem.Name = "AutrorizadoresToolStripMenuItem"
        Me.AutrorizadoresToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.AutrorizadoresToolStripMenuItem.Text = "Autrorizadores"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(114, 28)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NumeroWhatsAppTextBox
        '
        Me.NumeroWhatsAppTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "NumeroWhatsApp", True))
        Me.NumeroWhatsAppTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroWhatsAppTextBox.Location = New System.Drawing.Point(1240, 248)
        Me.NumeroWhatsAppTextBox.Name = "NumeroWhatsAppTextBox"
        Me.NumeroWhatsAppTextBox.Size = New System.Drawing.Size(176, 37)
        Me.NumeroWhatsAppTextBox.TabIndex = 12
        '
        'GrupoWhatsAppTextBox
        '
        Me.GrupoWhatsAppTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "GrupoWhatsApp", True))
        Me.GrupoWhatsAppTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoWhatsAppTextBox.Location = New System.Drawing.Point(1240, 200)
        Me.GrupoWhatsAppTextBox.Name = "GrupoWhatsAppTextBox"
        Me.GrupoWhatsAppTextBox.Size = New System.Drawing.Size(176, 37)
        Me.GrupoWhatsAppTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UsuariosAlmacen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(40, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Txbuscar
        '
        Me.Txbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Txbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txbuscar.Location = New System.Drawing.Point(944, 40)
        Me.Txbuscar.Name = "Txbuscar"
        Me.Txbuscar.Size = New System.Drawing.Size(312, 34)
        Me.Txbuscar.TabIndex = 33
        '
        'Bbuscar
        '
        Me.Bbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbuscar.Location = New System.Drawing.Point(1272, 32)
        Me.Bbuscar.Name = "Bbuscar"
        Me.Bbuscar.Size = New System.Drawing.Size(160, 44)
        Me.Bbuscar.TabIndex = 34
        Me.Bbuscar.Text = "Buscar"
        Me.Bbuscar.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreasTableAdapter = Nothing
        Me.TableAdapterManager.AutorizadoresTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EntidadesTableAdapter = Nothing
        Me.TableAdapterManager.UnidadMedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UsuariosAlmacen._db_vdaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'AutorizadoresTableAdapter
        '
        Me.AutorizadoresTableAdapter.ClearBeforeFill = True
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
        'EntidadesBindingSource
        '
        Me.EntidadesBindingSource.DataMember = "Entidades"
        Me.EntidadesBindingSource.DataSource = Me._db_vdaDataSet
        '
        'EntidadesTableAdapter
        '
        Me.EntidadesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1775, 790)
        Me.Controls.Add(Me.Bbuscar)
        Me.Controls.Add(Me.Txbuscar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(GrupoWhatsAppLabel)
        Me.Controls.Add(Me.GrupoWhatsAppTextBox)
        Me.Controls.Add(NumeroWhatsAppLabel)
        Me.Controls.Add(Me.NumeroWhatsAppTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.AutorizadorComboBox)
        Me.Controls.Add(AlmacenesLabel)
        Me.Controls.Add(Me.AlmacenesTextBox)
        Me.Controls.Add(CentroCostoLabel)
        Me.Controls.Add(Me.CentroCostoTextBox)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaComboBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardad)
        Me.Controls.Add(EntidadLabel)
        Me.Controls.Add(Me.EntidadComboBox)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(TipoUsuarioLabel)
        Me.Controls.Add(Me.TipoUsuarioComboBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios Almacen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._db_vdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AutorizadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _db_vdaDataSet As _db_vdaDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As _db_vdaDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As _db_vdaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents TipoUsuarioComboBox As ComboBox
    Friend WithEvents BNuevo As Button
    Friend WithEvents EntidadComboBox As ComboBox
    Friend WithEvents BGuardad As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents AreaComboBox As ComboBox
    Friend WithEvents CentroCostoTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents AlmacenesTextBox As TextBox
    Friend WithEvents AutorizadoresTableAdapter As _db_vdaDataSetTableAdapters.AutorizadoresTableAdapter
    Friend WithEvents AutorizadoresBindingSource As BindingSource
    Friend WithEvents AutorizadorComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IrAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutrorizadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AreasBindingSource As BindingSource
    Friend WithEvents AreasTableAdapter As _db_vdaDataSetTableAdapters.AreasTableAdapter
    Friend WithEvents EntidadesBindingSource As BindingSource
    Friend WithEvents EntidadesTableAdapter As _db_vdaDataSetTableAdapters.EntidadesTableAdapter
    Friend WithEvents NumeroWhatsAppTextBox As TextBox
    Friend WithEvents GrupoWhatsAppTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txbuscar As TextBox
    Friend WithEvents Bbuscar As Button
End Class
