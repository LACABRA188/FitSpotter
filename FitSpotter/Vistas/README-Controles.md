# Fichas técnicas de vistas

Todos los controles deben crearse manualmente desde el Diseñador Visual. En la ventana Propiedades, asigne exactamente los siguientes valores a `Name` y enlace los eventos indicados al método homónimo del code-behind.

| Vista | Controles y eventos |
|---|---|
| V1 Login | `txtUsuario`, `txtPassword`, `btnIngresar` (`Click`), `btnRegistrarSocio` (`Click`) |
| V2 Registro socio | `txtNombre`, `txtApellido`, `txtEmail`, `txtTelefono`, `txtUsuario`, `txtPassword`, `cboMembresia`, `btnGuardar` (`Click`); formulario: `Load` |
| V3 Dashboard socio | `lblBienvenida`, `lblEstadoCuota`, `btnMisRutinas` (`Click`), `btnReservarClase` (`Click`), `btnTienda`, `btnCerrarSesion` (`Click`); formulario: `Load` |
| V4 Mis rutinas | `lblObjetivo`, `lblPeriodo`, `dgvEjercicios`; formulario: `Load` |
| V5 Reserva de clases | `cboSucursal`, `dgvClases`, `btnReservar` (`Click`), `btnActualizar` (`Click`); formulario: `Load` |
| V6 Dashboard entrenador | `lblEntrenador`, `dgvSocios`, `dgvAgenda`, `btnCrearRutina` (`Click`), `btnEvaluacion`; formulario: `Load` |
| V7 Creador de rutinas | `cboSocio`, `txtObjetivo`, `dtpInicio`, `dtpFin`, `txtEjercicio`, `txtGrupoMuscular`, `nudSeries`, `nudRepeticiones`, `nudPeso`, `dgvEjercicios`, `btnAgregarEjercicio` (`Click`), `btnGuardarRutina` (`Click`); formulario: `Load` |
| V8 Dashboard administrador | `lblTotalSocios`, `lblCaja`, `lblStockBajo`, `btnCobrosVentas` (`Click`), `btnGestionClasesInventario` (`Click`); formulario: `Load` |
| V9 Cobro, facturación y tienda | `cboSocio`, `cboMetodoPago`, `cboSuplemento`, `nudCantidad`, `dgvCarrito`, `lblTotal`, `btnCobrarCuota` (`Click`), `btnAgregarProducto` (`Click`), `btnConfirmarVenta` (`Click`); formulario: `Load` |
| V10 Gestión de clases e inventario | `cboSucursal`, `cboEntrenador`, `txtNombreClase`, `dtpHorario`, `nudCupo`, `dgvClases`, `dgvEquipamiento`, `btnCrearClase` (`Click`), `btnMarcarDefectuoso` (`Click`); formulario: `Load` |

Los botones `btnTienda` y `btnEvaluacion` se dejan como puntos de extensión de UI porque el PDF los incorpora a sus flujos, pero no define vistas independientes para ellos.
