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
        Me.menuMarcado = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoCivilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloAdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcionSalir = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMarcado, Me.menuCatalogos, Me.menuConsultas, Me.menuReportes, Me.menuAdmin, Me.cerrarSesion, Me.opcionSalir})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(114, 644)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMarcado
        '
        Me.menuMarcado.Enabled = False
        Me.menuMarcado.Image = CType(resources.GetObject("menuMarcado.Image"), System.Drawing.Image)
        Me.menuMarcado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuMarcado.Name = "menuMarcado"
        Me.menuMarcado.Size = New System.Drawing.Size(101, 72)
        Me.menuMarcado.Text = "Marcado"
        Me.menuMarcado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuCatalogos
        '
        Me.menuCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentoToolStripMenuItem, Me.CiudadToolStripMenuItem, Me.PuestoToolStripMenuItem, Me.EstadoCivilToolStripMenuItem})
        Me.menuCatalogos.Enabled = False
        Me.menuCatalogos.Image = CType(resources.GetObject("menuCatalogos.Image"), System.Drawing.Image)
        Me.menuCatalogos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuCatalogos.Name = "menuCatalogos"
        Me.menuCatalogos.Size = New System.Drawing.Size(101, 72)
        Me.menuCatalogos.Text = "Catálogos"
        Me.menuCatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'CiudadToolStripMenuItem
        '
        Me.CiudadToolStripMenuItem.Name = "CiudadToolStripMenuItem"
        Me.CiudadToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CiudadToolStripMenuItem.Text = "Ciudad"
        '
        'PuestoToolStripMenuItem
        '
        Me.PuestoToolStripMenuItem.Name = "PuestoToolStripMenuItem"
        Me.PuestoToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PuestoToolStripMenuItem.Text = "Puesto"
        '
        'EstadoCivilToolStripMenuItem
        '
        Me.EstadoCivilToolStripMenuItem.Name = "EstadoCivilToolStripMenuItem"
        Me.EstadoCivilToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.EstadoCivilToolStripMenuItem.Text = "Estado Civil"
        '
        'menuConsultas
        '
        Me.menuConsultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloAdminToolStripMenuItem})
        Me.menuConsultas.Enabled = False
        Me.menuConsultas.Image = CType(resources.GetObject("menuConsultas.Image"), System.Drawing.Image)
        Me.menuConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuConsultas.Name = "menuConsultas"
        Me.menuConsultas.Size = New System.Drawing.Size(101, 72)
        Me.menuConsultas.Text = "Consulta"
        Me.menuConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SoloAdminToolStripMenuItem
        '
        Me.SoloAdminToolStripMenuItem.Name = "SoloAdminToolStripMenuItem"
        Me.SoloAdminToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SoloAdminToolStripMenuItem.Text = "Solo admin"
        '
        'menuReportes
        '
        Me.menuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoloAdminToolStripMenuItem1})
        Me.menuReportes.Enabled = False
        Me.menuReportes.Image = CType(resources.GetObject("menuReportes.Image"), System.Drawing.Image)
        Me.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuReportes.Name = "menuReportes"
        Me.menuReportes.Size = New System.Drawing.Size(101, 72)
        Me.menuReportes.Text = "Reporte"
        Me.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SoloAdminToolStripMenuItem1
        '
        Me.SoloAdminToolStripMenuItem1.Name = "SoloAdminToolStripMenuItem1"
        Me.SoloAdminToolStripMenuItem1.Size = New System.Drawing.Size(181, 26)
        Me.SoloAdminToolStripMenuItem1.Text = "Solo admin"
        '
        'menuAdmin
        '
        Me.menuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeUsuarioToolStripMenuItem, Me.CambioDeContraseñaToolStripMenuItem, Me.RespaldoToolStripMenuItem})
        Me.menuAdmin.Enabled = False
        Me.menuAdmin.Image = CType(resources.GetObject("menuAdmin.Image"), System.Drawing.Image)
        Me.menuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuAdmin.Name = "menuAdmin"
        Me.menuAdmin.Size = New System.Drawing.Size(101, 72)
        Me.menuAdmin.Text = "Admin"
        Me.menuAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RespaldoToolStripMenuItem
        '
        Me.RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        Me.RespaldoToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.RespaldoToolStripMenuItem.Text = "Respaldo BD"
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
        'cerrarSesion
        '
        Me.cerrarSesion.Image = CType(resources.GetObject("cerrarSesion.Image"), System.Drawing.Image)
        Me.cerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cerrarSesion.Name = "cerrarSesion"
        Me.cerrarSesion.Size = New System.Drawing.Size(101, 72)
        Me.cerrarSesion.Text = "Cerrar Sesion"
        Me.cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'opcionSalir
        '
        Me.opcionSalir.Image = CType(resources.GetObject("opcionSalir.Image"), System.Drawing.Image)
        Me.opcionSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.opcionSalir.Name = "opcionSalir"
        Me.opcionSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.opcionSalir.Size = New System.Drawing.Size(101, 72)
        Me.opcionSalir.Text = "Salir"
        Me.opcionSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 644)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
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
    Friend WithEvents menuCatalogos As ToolStripMenuItem
    Friend WithEvents menuReportes As ToolStripMenuItem
    Friend WithEvents menuConsultas As ToolStripMenuItem
    Friend WithEvents menuMarcado As ToolStripMenuItem
    Friend WithEvents menuAdmin As ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloAdminToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CambioDeContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cerrarSesion As ToolStripMenuItem
    Friend WithEvents opcionSalir As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoCivilToolStripMenuItem As ToolStripMenuItem
End Class
