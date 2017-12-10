<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioDeSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloAdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 95)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 95)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcadoToolStripMenuItem, Me.InicioDeSesiónToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.AdminToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.SalirStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioDeSesiónToolStripMenuItem
        '
        Me.InicioDeSesiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem})
        Me.InicioDeSesiónToolStripMenuItem.Name = "InicioDeSesiónToolStripMenuItem"
        Me.InicioDeSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.InicioDeSesiónToolStripMenuItem.Text = "Catalogos"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.IniciarToolStripMenuItem.Text = "Usuarios"
        '
        'MarcadoToolStripMenuItem
        '
        Me.MarcadoToolStripMenuItem.Name = "MarcadoToolStripMenuItem"
        Me.MarcadoToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.MarcadoToolStripMenuItem.Text = "Marcado"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloAdminToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'SoloAdminToolStripMenuItem
        '
        Me.SoloAdminToolStripMenuItem.Name = "SoloAdminToolStripMenuItem"
        Me.SoloAdminToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SoloAdminToolStripMenuItem.Text = "Solo admin"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloAdminToolStripMenuItem1})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'SoloAdminToolStripMenuItem1
        '
        Me.SoloAdminToolStripMenuItem1.Name = "SoloAdminToolStripMenuItem1"
        Me.SoloAdminToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.SoloAdminToolStripMenuItem1.Text = "Solo admin"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RespaldoToolStripMenuItem, Me.CambioDeContraseñaToolStripMenuItem, Me.GestionDeUsuarioToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'RespaldoToolStripMenuItem
        '
        Me.RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        Me.RespaldoToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.RespaldoToolStripMenuItem.Text = "Respaldo"
        '
        'CambioDeContraseñaToolStripMenuItem
        '
        Me.CambioDeContraseñaToolStripMenuItem.Name = "CambioDeContraseñaToolStripMenuItem"
        Me.CambioDeContraseñaToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña"
        '
        'GestionDeUsuarioToolStripMenuItem
        '
        Me.GestionDeUsuarioToolStripMenuItem.Name = "GestionDeUsuarioToolStripMenuItem"
        Me.GestionDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.GestionDeUsuarioToolStripMenuItem.Text = "Gestion de usuario"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirStripMenuItem1
        '
        Me.SalirStripMenuItem1.Name = "SalirStripMenuItem1"
        Me.SalirStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirStripMenuItem1.Size = New System.Drawing.Size(50, 24)
        Me.SalirStripMenuItem1.Text = "Salir"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 642)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioDeSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloAdminToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CambioDeContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirStripMenuItem1 As ToolStripMenuItem
End Class
