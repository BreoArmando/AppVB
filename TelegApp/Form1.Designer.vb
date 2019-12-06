<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTelegApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTelegApp))
        Me.tabTelegapp = New System.Windows.Forms.TabControl()
        Me.tabProductos = New System.Windows.Forms.TabPage()
        Me.imgProducto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVerDatosProducto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarrasProducto = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicasProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabProfesorado = New System.Windows.Forms.TabPage()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.mskTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblConfirmaAlta = New System.Windows.Forms.Label()
        Me.txtNombreProfe = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtApellidosProfe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUbicacionProfe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCorreoProfe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAltaProfe = New System.Windows.Forms.Button()
        Me.tabEnvios = New System.Windows.Forms.TabPage()
        Me.lbxProyecto = New System.Windows.Forms.ListBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbxProfes = New System.Windows.Forms.ListBox()
        Me.lblConfirmaSalida = New System.Windows.Forms.Label()
        Me.btnRegistrarSalida = New System.Windows.Forms.Button()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCodigoTechEnvio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabLlegadas = New System.Windows.Forms.TabPage()
        Me.lblConfirmaLlegada = New System.Windows.Forms.Label()
        Me.btnRegistrarLlegada = New System.Windows.Forms.Button()
        Me.btnVerDetallesLlegada = New System.Windows.Forms.Button()
        Me.txtNombreProfeLlegada = New System.Windows.Forms.TextBox()
        Me.txtProyectoLlegada = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtProcedencia = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCodigoTechLlegada = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnVerDisponibilidad = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvDisponibilidad = New System.Windows.Forms.DataGridView()
        Me.tabTelegapp.SuspendLayout()
        Me.tabProductos.SuspendLayout()
        CType(Me.imgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProfesorado.SuspendLayout()
        Me.tabEnvios.SuspendLayout()
        Me.tabLlegadas.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvDisponibilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTelegapp
        '
        Me.tabTelegapp.Controls.Add(Me.tabProductos)
        Me.tabTelegapp.Controls.Add(Me.tabProfesorado)
        Me.tabTelegapp.Controls.Add(Me.tabEnvios)
        Me.tabTelegapp.Controls.Add(Me.tabLlegadas)
        Me.tabTelegapp.Controls.Add(Me.TabPage5)
        Me.tabTelegapp.Location = New System.Drawing.Point(0, 1)
        Me.tabTelegapp.Name = "tabTelegapp"
        Me.tabTelegapp.SelectedIndex = 0
        Me.tabTelegapp.Size = New System.Drawing.Size(464, 506)
        Me.tabTelegapp.TabIndex = 0
        '
        'tabProductos
        '
        Me.tabProductos.Controls.Add(Me.imgProducto)
        Me.tabProductos.Controls.Add(Me.Label7)
        Me.tabProductos.Controls.Add(Me.btnVerDatosProducto)
        Me.tabProductos.Controls.Add(Me.Label6)
        Me.tabProductos.Controls.Add(Me.txtNombreProducto)
        Me.tabProductos.Controls.Add(Me.txtDescripcionProducto)
        Me.tabProductos.Controls.Add(Me.txtCodigoBarrasProducto)
        Me.tabProductos.Controls.Add(Me.txtCaracteristicasProducto)
        Me.tabProductos.Controls.Add(Me.txtCodigoProducto)
        Me.tabProductos.Controls.Add(Me.Label5)
        Me.tabProductos.Controls.Add(Me.Label4)
        Me.tabProductos.Controls.Add(Me.Label3)
        Me.tabProductos.Controls.Add(Me.Label2)
        Me.tabProductos.Controls.Add(Me.Label1)
        Me.tabProductos.Location = New System.Drawing.Point(4, 22)
        Me.tabProductos.Name = "tabProductos"
        Me.tabProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductos.Size = New System.Drawing.Size(456, 480)
        Me.tabProductos.TabIndex = 0
        Me.tabProductos.Text = "Productos"
        Me.tabProductos.UseVisualStyleBackColor = True
        '
        'imgProducto
        '
        Me.imgProducto.Location = New System.Drawing.Point(193, 329)
        Me.imgProducto.Name = "imgProducto"
        Me.imgProducto.Size = New System.Drawing.Size(213, 129)
        Me.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProducto.TabIndex = 16
        Me.imgProducto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Código Fabricante:"
        '
        'btnVerDatosProducto
        '
        Me.btnVerDatosProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDatosProducto.Location = New System.Drawing.Point(193, 99)
        Me.btnVerDatosProducto.Name = "btnVerDatosProducto"
        Me.btnVerDatosProducto.Size = New System.Drawing.Size(96, 29)
        Me.btnVerDatosProducto.TabIndex = 1
        Me.btnVerDatosProducto.Text = "Ver datos"
        Me.btnVerDatosProducto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Buscar producto:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(193, 209)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(213, 23)
        Me.txtNombreProducto.TabIndex = 11
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(193, 249)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(213, 23)
        Me.txtDescripcionProducto.TabIndex = 10
        '
        'txtCodigoBarrasProducto
        '
        Me.txtCodigoBarrasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarrasProducto.Location = New System.Drawing.Point(193, 169)
        Me.txtCodigoBarrasProducto.Name = "txtCodigoBarrasProducto"
        Me.txtCodigoBarrasProducto.Size = New System.Drawing.Size(213, 23)
        Me.txtCodigoBarrasProducto.TabIndex = 9
        '
        'txtCaracteristicasProducto
        '
        Me.txtCaracteristicasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicasProducto.Location = New System.Drawing.Point(193, 289)
        Me.txtCaracteristicasProducto.Name = "txtCaracteristicasProducto"
        Me.txtCaracteristicasProducto.Size = New System.Drawing.Size(213, 23)
        Me.txtCaracteristicasProducto.TabIndex = 7
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(193, 61)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(213, 23)
        Me.txtCodigoProducto.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Foto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Características:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'tabProfesorado
        '
        Me.tabProfesorado.Controls.Add(Me.lblUbicacion)
        Me.tabProfesorado.Controls.Add(Me.lblCorreo)
        Me.tabProfesorado.Controls.Add(Me.lblApellidos)
        Me.tabProfesorado.Controls.Add(Me.lblTelefono)
        Me.tabProfesorado.Controls.Add(Me.lblNombre)
        Me.tabProfesorado.Controls.Add(Me.mskTelefono)
        Me.tabProfesorado.Controls.Add(Me.lblConfirmaAlta)
        Me.tabProfesorado.Controls.Add(Me.txtNombreProfe)
        Me.tabProfesorado.Controls.Add(Me.Label13)
        Me.tabProfesorado.Controls.Add(Me.txtApellidosProfe)
        Me.tabProfesorado.Controls.Add(Me.Label12)
        Me.tabProfesorado.Controls.Add(Me.Label11)
        Me.tabProfesorado.Controls.Add(Me.txtUbicacionProfe)
        Me.tabProfesorado.Controls.Add(Me.Label10)
        Me.tabProfesorado.Controls.Add(Me.txtCorreoProfe)
        Me.tabProfesorado.Controls.Add(Me.Label9)
        Me.tabProfesorado.Controls.Add(Me.Label8)
        Me.tabProfesorado.Controls.Add(Me.btnAltaProfe)
        Me.tabProfesorado.Location = New System.Drawing.Point(4, 22)
        Me.tabProfesorado.Name = "tabProfesorado"
        Me.tabProfesorado.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfesorado.Size = New System.Drawing.Size(456, 480)
        Me.tabProfesorado.TabIndex = 1
        Me.tabProfesorado.Text = "Profesorado"
        Me.tabProfesorado.UseVisualStyleBackColor = True
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(190, 297)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(45, 13)
        Me.lblUbicacion.TabIndex = 19
        Me.lblUbicacion.Text = "Label29"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(190, 245)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(45, 13)
        Me.lblCorreo.TabIndex = 18
        Me.lblCorreo.Text = "Label28"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(190, 141)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(45, 13)
        Me.lblApellidos.TabIndex = 17
        Me.lblApellidos.Text = "Label27"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(190, 193)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(45, 13)
        Me.lblTelefono.TabIndex = 16
        Me.lblTelefono.Text = "Label26"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(190, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(45, 13)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Label25"
        '
        'mskTelefono
        '
        Me.mskTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTelefono.Location = New System.Drawing.Point(193, 167)
        Me.mskTelefono.Mask = "000-000-000"
        Me.mskTelefono.Name = "mskTelefono"
        Me.mskTelefono.Size = New System.Drawing.Size(79, 23)
        Me.mskTelefono.TabIndex = 2
        '
        'lblConfirmaAlta
        '
        Me.lblConfirmaAlta.AutoSize = True
        Me.lblConfirmaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmaAlta.Location = New System.Drawing.Point(189, 365)
        Me.lblConfirmaAlta.Name = "lblConfirmaAlta"
        Me.lblConfirmaAlta.Size = New System.Drawing.Size(206, 20)
        Me.lblConfirmaAlta.TabIndex = 14
        Me.lblConfirmaAlta.Text = "Ingreso efectuado con éxito"
        '
        'txtNombreProfe
        '
        Me.txtNombreProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProfe.Location = New System.Drawing.Point(193, 63)
        Me.txtNombreProfe.Name = "txtNombreProfe"
        Me.txtNombreProfe.Size = New System.Drawing.Size(213, 23)
        Me.txtNombreProfe.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Nombre:"
        '
        'txtApellidosProfe
        '
        Me.txtApellidosProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosProfe.Location = New System.Drawing.Point(193, 115)
        Me.txtApellidosProfe.Name = "txtApellidosProfe"
        Me.txtApellidosProfe.Size = New System.Drawing.Size(213, 23)
        Me.txtApellidosProfe.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Apellidos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Teléfono:"
        '
        'txtUbicacionProfe
        '
        Me.txtUbicacionProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacionProfe.Location = New System.Drawing.Point(193, 271)
        Me.txtUbicacionProfe.Name = "txtUbicacionProfe"
        Me.txtUbicacionProfe.Size = New System.Drawing.Size(213, 23)
        Me.txtUbicacionProfe.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Ubicación:"
        '
        'txtCorreoProfe
        '
        Me.txtCorreoProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoProfe.Location = New System.Drawing.Point(193, 219)
        Me.txtCorreoProfe.Name = "txtCorreoProfe"
        Me.txtCorreoProfe.Size = New System.Drawing.Size(213, 23)
        Me.txtCorreoProfe.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alta Profe:"
        '
        'btnAltaProfe
        '
        Me.btnAltaProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaProfe.Location = New System.Drawing.Point(331, 407)
        Me.btnAltaProfe.Name = "btnAltaProfe"
        Me.btnAltaProfe.Size = New System.Drawing.Size(75, 29)
        Me.btnAltaProfe.TabIndex = 5
        Me.btnAltaProfe.Text = "Enviar"
        Me.btnAltaProfe.UseVisualStyleBackColor = True
        '
        'tabEnvios
        '
        Me.tabEnvios.Controls.Add(Me.lbxProyecto)
        Me.tabEnvios.Controls.Add(Me.Label18)
        Me.tabEnvios.Controls.Add(Me.lbxProfes)
        Me.tabEnvios.Controls.Add(Me.lblConfirmaSalida)
        Me.tabEnvios.Controls.Add(Me.btnRegistrarSalida)
        Me.tabEnvios.Controls.Add(Me.txtDestino)
        Me.tabEnvios.Controls.Add(Me.Label17)
        Me.tabEnvios.Controls.Add(Me.txtCodigoTechEnvio)
        Me.tabEnvios.Controls.Add(Me.Label16)
        Me.tabEnvios.Controls.Add(Me.Label15)
        Me.tabEnvios.Controls.Add(Me.Label14)
        Me.tabEnvios.Location = New System.Drawing.Point(4, 22)
        Me.tabEnvios.Name = "tabEnvios"
        Me.tabEnvios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnvios.Size = New System.Drawing.Size(456, 480)
        Me.tabEnvios.TabIndex = 2
        Me.tabEnvios.Text = "Envíos"
        Me.tabEnvios.UseVisualStyleBackColor = True
        '
        'lbxProyecto
        '
        Me.lbxProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProyecto.FormattingEnabled = True
        Me.lbxProyecto.ItemHeight = 16
        Me.lbxProyecto.Items.AddRange(New Object() {"Extraescolar", "Campamento"})
        Me.lbxProyecto.Location = New System.Drawing.Point(193, 228)
        Me.lbxProyecto.Name = "lbxProyecto"
        Me.lbxProyecto.Size = New System.Drawing.Size(115, 36)
        Me.lbxProyecto.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 20)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Proyecto:"
        '
        'lbxProfes
        '
        Me.lbxProfes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxProfes.FormattingEnabled = True
        Me.lbxProfes.ItemHeight = 16
        Me.lbxProfes.Location = New System.Drawing.Point(193, 102)
        Me.lbxProfes.Name = "lbxProfes"
        Me.lbxProfes.Size = New System.Drawing.Size(213, 68)
        Me.lbxProfes.TabIndex = 1
        '
        'lblConfirmaSalida
        '
        Me.lblConfirmaSalida.AutoSize = True
        Me.lblConfirmaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmaSalida.Location = New System.Drawing.Point(221, 350)
        Me.lblConfirmaSalida.Name = "lblConfirmaSalida"
        Me.lblConfirmaSalida.Size = New System.Drawing.Size(190, 20)
        Me.lblConfirmaSalida.TabIndex = 18
        Me.lblConfirmaSalida.Text = "Envío registrado con éxito"
        '
        'btnRegistrarSalida
        '
        Me.btnRegistrarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarSalida.Location = New System.Drawing.Point(331, 407)
        Me.btnRegistrarSalida.Name = "btnRegistrarSalida"
        Me.btnRegistrarSalida.Size = New System.Drawing.Size(80, 29)
        Me.btnRegistrarSalida.TabIndex = 4
        Me.btnRegistrarSalida.Text = "Registrar"
        Me.btnRegistrarSalida.UseVisualStyleBackColor = True
        '
        'txtDestino
        '
        Me.txtDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestino.Location = New System.Drawing.Point(193, 189)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(213, 23)
        Me.txtDestino.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Destino:"
        '
        'txtCodigoTechEnvio
        '
        Me.txtCodigoTechEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTechEnvio.Location = New System.Drawing.Point(193, 63)
        Me.txtCodigoTechEnvio.Name = "txtCodigoTechEnvio"
        Me.txtCodigoTechEnvio.Size = New System.Drawing.Size(213, 23)
        Me.txtCodigoTechEnvio.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 20)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Nombre del profe:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Código del producto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(39, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 24)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Registrar Salida:"
        '
        'tabLlegadas
        '
        Me.tabLlegadas.Controls.Add(Me.lblConfirmaLlegada)
        Me.tabLlegadas.Controls.Add(Me.btnRegistrarLlegada)
        Me.tabLlegadas.Controls.Add(Me.btnVerDetallesLlegada)
        Me.tabLlegadas.Controls.Add(Me.txtNombreProfeLlegada)
        Me.tabLlegadas.Controls.Add(Me.txtProyectoLlegada)
        Me.tabLlegadas.Controls.Add(Me.Label21)
        Me.tabLlegadas.Controls.Add(Me.txtProcedencia)
        Me.tabLlegadas.Controls.Add(Me.Label22)
        Me.tabLlegadas.Controls.Add(Me.Label23)
        Me.tabLlegadas.Controls.Add(Me.txtCodigoTechLlegada)
        Me.tabLlegadas.Controls.Add(Me.Label20)
        Me.tabLlegadas.Controls.Add(Me.Label19)
        Me.tabLlegadas.Location = New System.Drawing.Point(4, 22)
        Me.tabLlegadas.Name = "tabLlegadas"
        Me.tabLlegadas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLlegadas.Size = New System.Drawing.Size(456, 480)
        Me.tabLlegadas.TabIndex = 3
        Me.tabLlegadas.Text = "Llegadas"
        Me.tabLlegadas.UseVisualStyleBackColor = True
        '
        'lblConfirmaLlegada
        '
        Me.lblConfirmaLlegada.AutoSize = True
        Me.lblConfirmaLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmaLlegada.Location = New System.Drawing.Point(266, 353)
        Me.lblConfirmaLlegada.Name = "lblConfirmaLlegada"
        Me.lblConfirmaLlegada.Size = New System.Drawing.Size(145, 20)
        Me.lblConfirmaLlegada.TabIndex = 29
        Me.lblConfirmaLlegada.Text = "Llegada registrada."
        '
        'btnRegistrarLlegada
        '
        Me.btnRegistrarLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarLlegada.Location = New System.Drawing.Point(331, 407)
        Me.btnRegistrarLlegada.Name = "btnRegistrarLlegada"
        Me.btnRegistrarLlegada.Size = New System.Drawing.Size(80, 29)
        Me.btnRegistrarLlegada.TabIndex = 2
        Me.btnRegistrarLlegada.Text = "Registrar"
        Me.btnRegistrarLlegada.UseVisualStyleBackColor = True
        '
        'btnVerDetallesLlegada
        '
        Me.btnVerDetallesLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetallesLlegada.Location = New System.Drawing.Point(303, 103)
        Me.btnVerDetallesLlegada.Name = "btnVerDetallesLlegada"
        Me.btnVerDetallesLlegada.Size = New System.Drawing.Size(103, 32)
        Me.btnVerDetallesLlegada.TabIndex = 1
        Me.btnVerDetallesLlegada.Text = "Ver Detalles"
        Me.btnVerDetallesLlegada.UseVisualStyleBackColor = True
        '
        'txtNombreProfeLlegada
        '
        Me.txtNombreProfeLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProfeLlegada.Location = New System.Drawing.Point(193, 192)
        Me.txtNombreProfeLlegada.Name = "txtNombreProfeLlegada"
        Me.txtNombreProfeLlegada.Size = New System.Drawing.Size(213, 23)
        Me.txtNombreProfeLlegada.TabIndex = 26
        '
        'txtProyectoLlegada
        '
        Me.txtProyectoLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProyectoLlegada.Location = New System.Drawing.Point(193, 272)
        Me.txtProyectoLlegada.Name = "txtProyectoLlegada"
        Me.txtProyectoLlegada.Size = New System.Drawing.Size(213, 23)
        Me.txtProyectoLlegada.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(23, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 20)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Proyecto:"
        '
        'txtProcedencia
        '
        Me.txtProcedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedencia.Location = New System.Drawing.Point(193, 230)
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.Size = New System.Drawing.Size(213, 23)
        Me.txtProcedencia.TabIndex = 23
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(23, 233)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 20)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Procedencia:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(23, 192)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(135, 20)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Nombre del profe:"
        '
        'txtCodigoTechLlegada
        '
        Me.txtCodigoTechLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTechLlegada.Location = New System.Drawing.Point(193, 63)
        Me.txtCodigoTechLlegada.Name = "txtCodigoTechLlegada"
        Me.txtCodigoTechLlegada.Size = New System.Drawing.Size(213, 23)
        Me.txtCodigoTechLlegada.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(23, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 20)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Código del producto:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(39, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(161, 24)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Registrar Llegada:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnVerDisponibilidad)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.dgvDisponibilidad)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(456, 480)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Disponibilidad"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnVerDisponibilidad
        '
        Me.btnVerDisponibilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDisponibilidad.Location = New System.Drawing.Point(328, 434)
        Me.btnVerDisponibilidad.Name = "btnVerDisponibilidad"
        Me.btnVerDisponibilidad.Size = New System.Drawing.Size(122, 29)
        Me.btnVerDisponibilidad.TabIndex = 6
        Me.btnVerDisponibilidad.Text = "Ver Disponibles"
        Me.btnVerDisponibilidad.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(39, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(235, 24)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Ver productos disponibles:"
        '
        'dgvDisponibilidad
        '
        Me.dgvDisponibilidad.AllowUserToAddRows = False
        Me.dgvDisponibilidad.AllowUserToDeleteRows = False
        Me.dgvDisponibilidad.AllowUserToResizeRows = False
        Me.dgvDisponibilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisponibilidad.Location = New System.Drawing.Point(6, 48)
        Me.dgvDisponibilidad.Name = "dgvDisponibilidad"
        Me.dgvDisponibilidad.ReadOnly = True
        Me.dgvDisponibilidad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvDisponibilidad.Size = New System.Drawing.Size(444, 380)
        Me.dgvDisponibilidad.TabIndex = 0
        '
        'formTelegApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 505)
        Me.Controls.Add(Me.tabTelegapp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formTelegApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelegApp"
        Me.tabTelegapp.ResumeLayout(False)
        Me.tabProductos.ResumeLayout(False)
        Me.tabProductos.PerformLayout()
        CType(Me.imgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProfesorado.ResumeLayout(False)
        Me.tabProfesorado.PerformLayout()
        Me.tabEnvios.ResumeLayout(False)
        Me.tabEnvios.PerformLayout()
        Me.tabLlegadas.ResumeLayout(False)
        Me.tabLlegadas.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dgvDisponibilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabTelegapp As TabControl
    Friend WithEvents tabProductos As TabPage
    Friend WithEvents tabProfesorado As TabPage
    Friend WithEvents tabEnvios As TabPage
    Friend WithEvents tabLlegadas As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerDatosProducto As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtCodigoBarrasProducto As TextBox
    Friend WithEvents txtCaracteristicasProducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents imgProducto As PictureBox
    Friend WithEvents txtNombreProfe As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtApellidosProfe As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUbicacionProfe As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCorreoProfe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAltaProfe As Button
    Friend WithEvents lblConfirmaAlta As Label
    Friend WithEvents mskTelefono As MaskedTextBox
    Friend WithEvents txtCodigoTechEnvio As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblConfirmaSalida As Label
    Friend WithEvents btnRegistrarSalida As Button
    Friend WithEvents lbxProfes As ListBox
    Friend WithEvents lbxProyecto As ListBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCodigoTechLlegada As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnRegistrarLlegada As Button
    Friend WithEvents btnVerDetallesLlegada As Button
    Friend WithEvents txtNombreProfeLlegada As TextBox
    Friend WithEvents txtProyectoLlegada As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtProcedencia As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblConfirmaLlegada As Label
    Friend WithEvents btnVerDisponibilidad As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents dgvDisponibilidad As DataGridView
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
End Class
