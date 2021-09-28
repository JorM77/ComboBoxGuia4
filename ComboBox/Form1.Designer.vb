<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComboBox))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.CBOCARRERA = New System.Windows.Forms.ComboBox()
        Me.CBOCURSOS = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVLISTADO = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVLISTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNIVERSIDAD UDB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ALUMNO :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CARRERA :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CURSOS :"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(83, 52)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(185, 20)
        Me.TXTNOMBRE.TabIndex = 4
        '
        'CBOCARRERA
        '
        Me.CBOCARRERA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCARRERA.FormattingEnabled = True
        Me.CBOCARRERA.Items.AddRange(New Object() {"SELECCIONE UNA CARRERA", "SISTEMAS", "CONTABILIDAD", "DISEÑO"})
        Me.CBOCARRERA.Location = New System.Drawing.Point(83, 108)
        Me.CBOCARRERA.Name = "CBOCARRERA"
        Me.CBOCARRERA.Size = New System.Drawing.Size(185, 21)
        Me.CBOCARRERA.TabIndex = 5
        '
        'CBOCURSOS
        '
        Me.CBOCURSOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOCURSOS.FormattingEnabled = True
        Me.CBOCURSOS.Location = New System.Drawing.Point(83, 159)
        Me.CBOCURSOS.Name = "CBOCURSOS"
        Me.CBOCURSOS.Size = New System.Drawing.Size(185, 21)
        Me.CBOCURSOS.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(252, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "REGISTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DGVLISTADO
        '
        Me.DGVLISTADO.AllowUserToDeleteRows = False
        Me.DGVLISTADO.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVLISTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLISTADO.Location = New System.Drawing.Point(15, 261)
        Me.DGVLISTADO.Name = "DGVLISTADO"
        Me.DGVLISTADO.RowHeadersVisible = False
        Me.DGVLISTADO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVLISTADO.Size = New System.Drawing.Size(371, 189)
        Me.DGVLISTADO.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(274, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(401, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVLISTADO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBOCURSOS)
        Me.Controls.Add(Me.CBOCARRERA)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "ComboBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ComboBox"
        CType(Me.DGVLISTADO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents CBOCARRERA As System.Windows.Forms.ComboBox
    Friend WithEvents CBOCURSOS As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVLISTADO As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
