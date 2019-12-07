Imports MySql.Data.MySqlClient

Public Class formTelegApp

    'AUTOR: Breogán Beceiro
    'INICIO PROYECTO: 10/09/2019
    'FIN PROYECTO: ¿?
    'ÚLTIMA ACTUALIZACIÓN: 19/09/2019

    'APLICACIÓN DE GESTIÓN DE INVENTARIO.
    'Los requisitos funcionales y no funcionales se pueden consultar en el manual de la
    '  propia aplicación.

    'HAY QUE OPTIMIZAR EL CÓDIGO, ELIMINANDO ESTRUCTURAS REPETIDAS (COMO LAS CONEXIONES CON LA BASE DE DATOS) POR MEDIO DE FUNCIONES.
    'FALTA PROGRAMAR EL TRATAMIENTO DE UNA EXCEPCIÓN QUE SURJA AL INTRODUCIR UNA CADENA QUE SEA UNA RUTA NO VÁLIDA EN LA PESTAÑA 'Productos' (Region "Ver Datos
    '  del Producto"). HAY COMENTADO UN BLOQUE ElseIf QUE NO LO PROCESA ADECUADAMENTE.
    'FALTA OPTIMIZAR LOS MENSAJES QUE APARECEN EN LA PESTAÑA DE 'Profesorado' CUANDO SE METEN VALORES INCORRECTOS, PUES ÉSTOS PERMANECEN VISIBLES CUANDO LOS
    '  VALORES SON CORRECTOS.
    'FALTA PROCESAR LOS ERRORES QUE SE PRODUCEN CUANDO, EN LA PESTAÑA 'Envíos', SE PULSA EN EL BOTÓN SIN HABER SELECCIONADO UN PROFE NI UN TIPO DE PROYECTO.

    Dim datosConexion As String = "server=localhost; database=inventariotech; user=Breogan; password=4321; sslmode=none"
    Dim conexion As New MySql.Data.MySqlClient.MySqlConnection(datosConexion)

#Region "FormLoad"
    'Se carga el ListBox de la pestaña 'Registrar salida' con los nombres de los profesores registrados, se vacía el texto de los LABEL que notifican errores o
    '  acciones realizadas y se inhabilitan las cajas de texto en las que se muestran los datos de productos y profesores en las pestañas correspondientes.
    Private Sub formTelegApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadenaComando As String = "Select Nombre, Apellidos, Ubicacion FROM Profesorado ORDER BY Numero;"
        Dim comando As New MySqlCommand(cadenaComando, conexion)

        Dim DR As MySqlDataReader

        Dim DS As New DataSet
        Dim adaptador As MySqlDataAdapter

        Dim contador As Integer = 0

        Try
            conexion.Open()

            adaptador = New MySqlDataAdapter(comando)
            adaptador.Fill(DS)

            DR = comando.ExecuteReader

            While DR.Read
                lbxProfes.Items.Add(DS.Tables(0).Rows(contador).Item(0) & " " & DS.Tables(0).Rows(contador).Item(1))
                contador += 1
            End While

            DR.Close()
        Catch
            MessageBox.Show("No se ha podido conectar con la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            conexion.Close()
        End Try

        txtCodigoBarrasProducto.Enabled = False
        txtNombreProducto.Enabled = False
        txtDescripcionProducto.Enabled = False
        txtCaracteristicasProducto.Enabled = False
        imgProducto.Enabled = False
        txtDestino.Enabled = False
        txtNombreProfeLlegada.Enabled = False
        txtProcedencia.Enabled = False
        txtProyectoLlegada.Enabled = False
        lblConfirmaAlta.Text = ""
        lblConfirmaSalida.Text = ""
        lblConfirmaLlegada.Text = ""
        lblNombre.Text = ""
        lblApellidos.Text = ""
        lblTelefono.Text = ""
        lblCorreo.Text = ""
        lblUbicacion.Text = ""
    End Sub
#End Region

#Region "Ver Datos del Producto"
    'Muestra los datos del producto cuyo código se corresponda con el introducido en la caja de texto 'código':
    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatosProducto.Click
        'El código introducido en la caja de texto se almacena en la variable 'codigo':
        Dim codigo As String = txtCodigoProducto.Text

        Dim foto As Image
        Dim rutaFoto As String
        Dim noFoto As Image
        Dim rutaNoFoto As String

        'El orden de los elementos devueltos por la consulta lo marca la lista de selección; es decir, en este caso, la tabla
        '  productos tiene cinco campos (CodigoTech, CodigoFabricante, Nombre, Descripcion, Caracteristicas, Foto), si se quisieran recuperar
        '  todos esos campos, los índices serían 0, 1, 2, 3, 4 y 5; pero como en la lista de selección los campos son cuatro, los índices van
        '  del 0 al 4, siendo:
        '    Item(0)-> CodigoFabricante, Item(1)-> Nombre, Item(2)-> Descripcion, Item(3)-> Caracteristicas, Item(4)-> Foto.

        Dim cadenaComando As String = "Select CodigoFabricante, IFNULL(Nombre, 'No registrado'), IFNULL(Descripcion, 'No registrada'), IFNULL(Caracteristicas, 'No registradas'), IFNULL(Foto, 'No encontrada') FROM productos WHERE CodigoTech='" & codigo & "';"
        Dim comando As New MySqlCommand(cadenaComando, conexion)

        Dim adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim DS As New DataSet

        Try
            conexion.Open()

            'Se inicializa el objeto DataAdapter declarado en la línea 32:
            adaptador = New MySqlDataAdapter(comando)
            adaptador.Fill(DS)
        Catch
            MessageBox.Show("Error en la consulta.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

#Region "Salidas en TextBoxes"
        'Si el número de filas de la tabla obtenida de la consulta es igual a 0, significa que ésta no ha devuelto nada porque el código dado es incorrecto
        '  o no está registrado. En ese caso, se muestra el mensaje del MessageBox; de lo contrario, el flujo del programa trata los datos devueltos para
        '  mostrarlos en las cajas de texto (Region "Salidas en TextBoxes"):
        If DS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Código no registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If DS.Tables(0).Rows(0).Item(0) = "" Then
                txtCodigoBarrasProducto.Text = "No registrado"
            Else
                txtCodigoBarrasProducto.Text = DS.Tables(0).Rows(0).Item(0)
            End If
            txtNombreProducto.Text = DS.Tables(0).Rows(0).Item(1)
            txtDescripcionProducto.Text = DS.Tables(0).Rows(0).Item(2)
            txtCaracteristicasProducto.Text = DS.Tables(0).Rows(0).Item(3)

            'En rutaFoto se almacena la cadena de texto del campo 'Foto' de la tabla Productos que se corresponde con la ruta a la foto en el equipo.
            '  Si esa cadena es "No encontrada", por estar el campo en blanco, la imagen que se carga es la que se encuentra en la ruta almacenada en
            '  rutaNoFoto (un texto 'Imagen no encontrada' sobre un fondo blanco).
            'FALTA PROGRAMAR EL TRATAMIENTO DE UNA EXCEPCIÓN QUE SURJA AL INTRODUCIR UNA CADENA QUE SEA UNA RUTA NO VÁLIDA.
            rutaFoto = DS.Tables(0).Rows(0).Item(4)
            If rutaFoto = "No encontrada" Or rutaFoto = "" Then
                rutaNoFoto = "C:\Users\Breogan\Desktop\TelegApp\Imágenes\noFoto.png"
                noFoto = Image.FromFile(rutaNoFoto)
                imgProducto.Image = noFoto

            ElseIf rutaFoto Is Nothing Then
                'Si la ruta es Nothing, muestra la imagen 'Imagen no encontrada':
                rutaNoFoto = "C:\Users\Breogan\Desktop\TelegApp\Imágenes\noFoto.png"
                noFoto = Image.FromFile(rutaNoFoto)
                imgProducto.Image = noFoto

                'ElseIf Not rutaFoto.Substring(0, 2) = "C:\" Then
                '    'Si la ruta no comienza por 'C:\', la ruta no será válida (en la BBDD las rutas deben ser absolutas) y se mostrará la imagen 'Imagen no encontrada':
                '    rutaNoFoto = "C:\Users\Alumno\Desktop\TelegApp\noFoto.png"
                '    noFoto = Image.FromFile(rutaNoFoto)
                '    imgProducto.Image = noFoto

            Else
                'Si la ruta es válida, se carga la imagen:
                foto = Image.FromFile(rutaFoto)
                imgProducto.Image = foto
            End If

        End If
#End Region
    End Sub
#End Region

#Region "Alta Profesor/a"
    'Ingresa un nuevo profesor/a en la BBDD al pulsar en el botón 'Enviar' de la pantalla 'Profesorado' de la aplicación.
    Private Sub btnAltaProfe_Click(sender As Object, e As EventArgs) Handles btnAltaProfe.Click
        'Antes de hacer el ingreso, aparece una ventana emergente que pregunta al usuario si de verdad quiere hacerlo. Si su respuesta es sí,
        '  se conecta con la BBDD y ejecuta la consulta; si responde no, se cancela el alta y se cierra la ventana emergente.
        If MessageBox.Show("¿Seguro que quieres ingresar este profe?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim nombre As String = txtNombreProfe.Text
            Dim apellidos As String = txtApellidosProfe.Text
            Dim telefono As String = mskTelefono.Text
            Dim correo As String = txtCorreoProfe.Text
            Dim ubicacion As String = txtUbicacionProfe.Text

            If nombre = "" Then
                lblNombre.Text = "Campo obligatorio"
            ElseIf apellidos = "" Then
                lblApellidos.Text = "Campo obligatorio"
            ElseIf telefono.Length = 2 Or Not telefono.Length = 11 Then
                lblTelefono.Text = "Campo obligatorio"
            ElseIf correo = "" Then
                lblCorreo.Text = "Campo obligatorio"
            ElseIf compruebaCorreo(correo) = False Then
                lblCorreo.Text = "Introduce un correo válido"
            ElseIf ubicacion = "" Then
                lblUbicacion.Text = "Campo obligatorio"
            Else
                Dim cadenaComando As String = "INSERT INTO Profesorado(Nombre, Apellidos, Telefono, Correo, Ubicacion) VALUES ('" & nombre & "', '" & apellidos & "', '" & telefono & "', '" & correo & "', '" & ubicacion & "');"
                Dim comando As New MySqlCommand(cadenaComando, conexion)

                conexion.Open()

                If comando.ExecuteNonQuery() Then
                    lblConfirmaAlta.Text = "Ingreso efectuado con éxito."
                Else
                    MessageBox.Show("Error introduciendo los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                conexion.Close()
            End If
        End If
    End Sub
#End Region

#Region "Registrar Salida"
    'Ingresa en la BBDD el envío de un producto a un/a profesor/a.
    'El código del producto a enviar se introduce en la caja de texto correspondiente, y el número del profe se obtiene de una subconsulta en el comando INSERT.
    'En la interfaz se busca al profe por su nombre para no obligar a los empleados a conocer los números de identificación de cada uno de ellos.
    Private Sub btnRegistrarSalida_Click(sender As Object, e As EventArgs) Handles btnRegistrarSalida.Click

        'HAY QUE OBTENER EL numero DEL PROFE CUYO NOMBRE Y APELLIDOS SEAN LOS DEL INDICE SELECCIONADO EN EL ListBox, PERO HAY UN PROBLEMA DE PRECEDENCIA, PUES EN
        '  LA CONSULTA INSERT, SE UTILIZA EL DataSet ANTES DE QUE SE HAYAN VOLCADO EN ÉL LOS DATOS DE LA CONSULTA SELECT.

        'ACTUALIZACIÓN 18/09/2019: EL ORDEN DE PRECEDENCIA ESTÁ CORREGIDO Y LA CONSULTA SE CUBRE CON LOS DATOS CORRECTOS, SIN EMBARGO, NO LLEGA A EJECUTARSE, PUES
        '  SE GENERA UN ERROR QUE SALTA AL BLOQUE CATCH. EL ERROR PODRÍA ESTAR EN LA SINTAXIS DE LA CONSULTA, YA QUE SE TRATA DE UN INSERT QUE CONTIENE UN SELECT 
        '  EN LA LISTA DE INSERCIÓN.

        'ACTUALIZACIÓN 19/09/2019: La consulta está corregida y se ejecuta correctamente la inserción.

        Dim cadenaComandoINSERT As String
        Dim cadenaComandoSELECTCod As String
        Dim cadenaComandoSELECTNombre As String

        Dim comandoINSERT As MySqlCommand
        Dim comandoSELECTCod As MySqlCommand
        Dim comandoSELECTNombre As MySqlCommand

        Dim DSCod As New DataSet
        Dim DSNombre As New DataSet

        Dim adaptadorCod As MySqlDataAdapter
        Dim adaptadorNombre As MySqlDataAdapter

        cadenaComandoSELECTCod = "SELECT CodigoTech FROM Productos WHERE CodigoTech='" & txtCodigoTechEnvio.Text & "';"
        comandoSELECTCod = New MySqlCommand(cadenaComandoSELECTCod, conexion)

        adaptadorCod = New MySqlDataAdapter(comandoSELECTCod)
        adaptadorCod.Fill(DSCod)

        If MessageBox.Show("¿Estás seguro/a de que quieres registrar esta salida?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txtCodigoTechEnvio.Text = "" Then
                MessageBox.Show("Debes introducir el código del producto a enviar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf DSCod.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Código no registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cadenaComandoSELECTNombre = "SELECT Nombre, Apellidos, Numero FROM Profesorado;"
                comandoSELECTNombre = New MySqlCommand(cadenaComandoSELECTNombre, conexion)

                adaptadorNombre = New MySqlDataAdapter(comandoSELECTNombre)
                adaptadorNombre.Fill(DSNombre)

                cadenaComandoINSERT = "INSERT INTO Prestamos(Producto, CodigoProfe, FechaSalida, Proyecto) SELECT '" & txtCodigoTechEnvio.Text & "', `Numero`, '" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "', '" & lbxProyecto.SelectedItem.ToString & "' FROM Profesorado WHERE Nombre='" & DSNombre.Tables(0).Rows(lbxProfes.SelectedIndex).Item(0) & "' AND Apellidos='" & DSNombre.Tables(0).Rows(lbxProfes.SelectedIndex).Item(1) & "';"
                'SELECT '" & txtCodigoTechEnvio.Text & "', " & "SELECT Numero FROM Profesorado WHERE Nombre='" & DSNombre.Tables(0).Rows(lbxProfes.SelectedIndex).Item(0) & "' AND Apellidos='" & DSNombre.Tables(0).Rows(lbxProfes.SelectedIndex).Item(1) & "';, '" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "';', '" & lbxProyecto.SelectedItem.ToString & "';"

                comandoINSERT = New MySqlCommand(cadenaComandoINSERT, conexion)

                Try
                    conexion.Open()

                    comandoINSERT.ExecuteNonQuery()

                    lblConfirmaSalida.Text = "Envío registrado con éxito."
                Catch
                    MessageBox.Show("Error registrando la salida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conexion.Close()
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Registrar Llegada"
    'Registra la llegada de un producto introduciendo la presente fecha en el campo 'FechaLlegada' de la tabla 'Prestamos',
    '  comprobando antes que el código del producto se encuentra registrado en la propia tabla 'Préstamos' con el campo 'FechaLlegada'
    '  sin datos:
    Private Sub btnRegistrarLlegada_Click(sender As Object, e As EventArgs) Handles btnRegistrarLlegada.Click
        Dim cadenaComandoINSERT As String = "UPDATE Prestamos SET FechaLlegada='" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "' WHERE Producto='" & txtCodigoTechLlegada.Text & "';"
        Dim cadenaComandoSELECT As String = "SELECT * FROM Prestamos WHERE Producto='" & txtCodigoTechLlegada.Text & "' AND FechaLlegada IS NULL;"

        Dim comandoINSERT As New MySqlCommand(cadenaComandoINSERT, conexion)
        Dim comandoSELECT As New MySqlCommand(cadenaComandoSELECT, conexion)

        Dim adaptador As MySqlDataAdapter
        Dim DS As New DataSet

        adaptador = New MySqlDataAdapter(comandoSELECT)
        adaptador.Fill(DS)

        If txtCodigoTechLlegada.Text = "" Then
            MessageBox.Show("Debes introducir él código del producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf DS.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Código No registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                conexion.Open()

                comandoINSERT.ExecuteNonQuery()

                lblConfirmaLlegada.Text = "Llegada registrada."
            Catch
                MessageBox.Show("Error registrando la llegada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub
#End Region

#Region "Ver detalles del préstamo"
    'Muestra los datos de un préstamo asociado al código del producto prestado.
    'Los datos a mostrar son el nombre del profesor/a beneficiario/a, su ubicación y el proyecto para el cual se tramitó el préstamo.
    Private Sub btnVerDetallesLlegada_Click(sender As Object, e As EventArgs) Handles btnVerDetallesLlegada.Click
        Dim cadenaComandoDATOS As String = "SELECT Nombre, Apellidos, Ubicacion, Proyecto FROM Profesorado JOIN Prestamos ON Numero=CodigoProfe WHERE Producto='" & txtCodigoTechLlegada.Text & "' AND FechaLlegada IS NULL;"
        Dim cadenaComandoCODIGO As String = "SELECT * FROM Prestamos WHERE Producto='" & txtCodigoTechLlegada.Text & "' AND FechaLlegada IS NULL;"
        Dim comandoDatos As New MySqlCommand(cadenaComandoDATOS, conexion)
        Dim comandoCodigo As New MySqlCommand(cadenaComandoCODIGO, conexion)

        Dim DSDatos As New DataSet
        Dim DSCodigo As New DataSet

        Dim adaptadorDatos As New MySqlDataAdapter(comandoDatos)
        Dim adaptadorCodigo As New MySqlDataAdapter(comandoCodigo)

        adaptadorDatos.Fill(DSDatos)
        adaptadorCodigo.Fill(DSCodigo)

        Try
            conexion.Open()

            If txtCodigoTechLlegada.Text = "" Then
                MessageBox.Show("Introduce el código del producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf DSCodigo.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Este código no está asociado a ningún préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                txtNombreProfeLlegada.Text = DSDatos.Tables(0).Rows(0).Item(0) & " " & DSDatos.Tables(0).Rows(0).Item(1)
                txtProcedencia.Text = DSDatos.Tables(0).Rows(0).Item(2)
                txtProyectoLlegada.Text = DSDatos.Tables(0).Rows(0).Item(3)
            End If
        Catch
            MessageBox.Show("Error mostrando los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub
#End Region

#Region "Ver Productos Disponibles"
    Private Sub btnVerDisponibilidad_Click(sender As Object, e As EventArgs) Handles btnVerDisponibilidad.Click
        Dim cadenaComando As String = "SELECT CodigoTech, Nombre, Caracteristicas FROM Productos WHERE CodigoTech NOT IN (SELECT Producto FROM Prestamos WHERE FechaLlegada IS NULL);"
        Dim comando As New MySqlCommand(cadenaComando, conexion)

        Dim DS As New DataSet
        Dim adaptador As New MySqlDataAdapter(comando)
        dgvDisponibilidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        adaptador.Fill(DS)

        dgvDisponibilidad.DataSource = DS.Tables(0)
    End Sub
#End Region

#Region "Cambio de Item Seleccionado en lbxProfes"
    'Muestra la ubicación asociada a cada profesor/a en una caja de texto de sólo lectura al pulsar sobre el nombre de cada uno en la lista del ListBox:
    Private Sub listaUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxProfes.SelectedIndexChanged
        Dim cadenaComando As String = "SELECT Ubicacion FROM Profesorado;"
        Dim comando As New MySqlCommand(cadenaComando, conexion)

        Dim DS As New DataSet
        Dim adaptador As MySqlDataAdapter

        adaptador = New MySqlDataAdapter(comando)
        adaptador.Fill(DS)

        conexion.Open()

        txtDestino.Text = DS.Tables(0).Rows(lbxProfes.SelectedIndex).Item(0).ToString

        conexion.Close()
    End Sub
#End Region

#Region "Ventana Emergente de Cierre de Aplicación"
    'El siguiente procedimiento se ejecuta cuando se trata de cerrar la aplicación. Muestra una ventana emergente que pregunta 
    '  al usuario si quiere salir. Pulsando en 'Sí' la aplicación se cerrará y, pulsando en 'No', permanecerá abierta: 
    Private Sub CerrarTelegApp(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Seguro que quieres salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "Verificar E-Mail"
    ''' <summary>
    ''' Analiza una cadena de texto para determinar si se trata de un correo electrónico o no, según su formato.
    ''' </summary>
    ''' <param name="correo">La cadena de texto para analizar.</param>
    ''' <returns>TRUE si la cadena tiene formato de correo electrónico y FALSE, si no.</returns>
    Private Function compruebaCorreo(correo As String) As Boolean
        Dim expresion As System.Text.RegularExpressions.Regex
        Dim patron As String = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        expresion = New System.Text.RegularExpressions.Regex(patron)

        If Not expresion.IsMatch(correo) Then
            Return False
        End If

        Return True
    End Function
#End Region

End Class