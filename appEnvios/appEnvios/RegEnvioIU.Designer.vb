<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegEnvioIU
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
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DbEnvios1 = New CmpEnvios.dbEnvios()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txTCI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTipoCarga = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbDestino = New System.Windows.Forms.ComboBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DbEnvios2 = New CmpEnvios.dbEnvios()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txTCIDestinatario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DbEnvios1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DbEnvios2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(132, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 20)
        Me.txtFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha del Envio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txTCI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 157)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CLIENTE"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios1, "VClientes.Direccion", True))
        Me.TextBox3.Location = New System.Drawing.Point(73, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(639, 20)
        Me.TextBox3.TabIndex = 9
        '
        'DbEnvios1
        '
        Me.DbEnvios1.DataSetName = "dbEnvios"
        Me.DbEnvios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios1, "VClientes.Telefono", True))
        Me.TextBox2.Location = New System.Drawing.Point(73, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(639, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios1, "VClientes.Cliente", True))
        Me.TextBox1.Location = New System.Drawing.Point(73, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(639, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Telefono :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txTCI
        '
        Me.txTCI.Location = New System.Drawing.Point(97, 28)
        Me.txTCI.Name = "txTCI"
        Me.txTCI.Size = New System.Drawing.Size(147, 20)
        Me.txTCI.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CI del Cliente :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tipo de Carga :"
        '
        'cbTipoCarga
        '
        Me.cbTipoCarga.DataSource = Me.DbEnvios1
        Me.cbTipoCarga.DisplayMember = "TTiposCarga.Nombre"
        Me.cbTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCarga.FormattingEnabled = True
        Me.cbTipoCarga.Location = New System.Drawing.Point(110, 214)
        Me.cbTipoCarga.Name = "cbTipoCarga"
        Me.cbTipoCarga.Size = New System.Drawing.Size(625, 21)
        Me.cbTipoCarga.TabIndex = 4
        Me.cbTipoCarga.ValueMember = "TTiposCarga.TipoID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Detalle de la Carga"
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(26, 263)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(701, 96)
        Me.txtDetalle.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Destino"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(516, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Costo del Envio (Bs)."
        '
        'cbDestino
        '
        Me.cbDestino.DataSource = Me.DbEnvios1
        Me.cbDestino.DisplayMember = "TDestinos.Nombre"
        Me.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDestino.FormattingEnabled = True
        Me.cbDestino.Location = New System.Drawing.Point(80, 374)
        Me.cbDestino.Name = "cbDestino"
        Me.cbDestino.Size = New System.Drawing.Size(422, 21)
        Me.cbDestino.TabIndex = 9
        Me.cbDestino.ValueMember = "TDestinos.DestinoID"
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios1, "TTarifas.Costo", True))
        Me.txtCosto.Location = New System.Drawing.Point(646, 374)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 10
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txTCIDestinatario)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 401)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(737, 157)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL DESTINATARIO"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios2, "VClientes.Direccion", True))
        Me.TextBox4.Location = New System.Drawing.Point(88, 113)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(639, 20)
        Me.TextBox4.TabIndex = 9
        '
        'DbEnvios2
        '
        Me.DbEnvios2.DataSetName = "dbEnvios"
        Me.DbEnvios2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios2, "VClientes.Telefono", True))
        Me.TextBox5.Location = New System.Drawing.Point(88, 84)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(639, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbEnvios2, "VClientes.Cliente", True))
        Me.TextBox6.Location = New System.Drawing.Point(88, 54)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(639, 20)
        Me.TextBox6.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Telefono "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Destinatario"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 20)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CONSULTAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txTCIDestinatario
        '
        Me.txTCIDestinatario.Location = New System.Drawing.Point(134, 25)
        Me.txTCIDestinatario.Name = "txTCIDestinatario"
        Me.txTCIDestinatario.Size = New System.Drawing.Size(147, 20)
        Me.txTCIDestinatario.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "CI del Destinatario  "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(627, 564)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "GUARDAR ENVIO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkRed
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(471, 564)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 41)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "CANCELAR REGISTRO"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RegEnvioIU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(773, 627)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.cbDestino)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbTipoCarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "RegEnvioIU"
        Me.Text = "Registro de los envios de carga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DbEnvios1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DbEnvios2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txTCI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DbEnvios1 As CmpEnvios.dbEnvios
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTipoCarga As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDestino As ComboBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txTCIDestinatario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DbEnvios2 As CmpEnvios.dbEnvios
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
