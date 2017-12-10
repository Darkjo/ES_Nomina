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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MarcadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioDeSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1.Location = New System.Drawing.Point(693, 172)
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
        Me.Label2.Location = New System.Drawing.Point(693, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 95)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcadoToolStripMenuItem, Me.InicioDeSesiónToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.AdminToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.SalirStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(114, 642)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MarcadoToolStripMenuItem
        '
        Me.MarcadoToolStripMenuItem.Image = CType(resources.GetObject("MarcadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MarcadoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MarcadoToolStripMenuItem.Name = "MarcadoToolStripMenuItem"
        Me.MarcadoToolStripMenuItem.Size = New System.Drawing.Size(101, 72)
        Me.MarcadoToolStripMenuItem.Text = "Marcado"
        Me.MarcadoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InicioDeSesiónToolStripMenuItem
        '
        Me.InicioDeSesiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem})
        Me.InicioDeSesiónToolStripMenuItem.Image = CType(resources.GetObject("InicioDeSesiónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioDeSesiónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InicioDeSesiónToolStripMenuItem.Name = "InicioDeSesiónToolStripMenuItem"
        Me.InicioDeSesiónToolStripMenuItem.Size = New System.Drawing.Size(101, 72)
        Me.InicioDeSesiónToolStripMenuItem.Text = "Catálogos"
        Me.InicioDeSesiónToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.IniciarToolStripMenuItem.Text = "Usuarios"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloAdminToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Image = CType(resources.GetObject("ConsultaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(101, 72)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        Me.ConsultaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ReporteToolStripMenuItem.Image = CType(resources.GetObject("ReporteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReporteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(101, 72)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        Me.ReporteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(108, 72)
        Me.AdminToolStripMenuItem.Text = "Admin"
        Me.AdminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.CerrarSesionToolStripMenuItem.Image = CType(resources.GetObject("CerrarSesionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarSesionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(108, 72)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        Me.CerrarSesionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirStripMenuItem1
        '
        Me.SalirStripMenuItem1.Image = CType(resources.GetObject("SalirStripMenuItem1.Image"), System.Drawing.Image)
        Me.SalirStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirStripMenuItem1.Name = "SalirStripMenuItem1"
        Me.SalirStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirStripMenuItem1.Size = New System.Drawing.Size(108, 72)
        Me.SalirStripMenuItem1.Text = "Salir"
        Me.SalirStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
