using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor.Models
{
    public class TrabajadorProxy
    {
        public int COMP_Codigo { get; set; }
        public int Id_Trabajador { get; set; }
        public string Tipo_trabajador { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        public string Entidad_Bancaria { get; set; }
        public string CarnetIESS { get; set; }
        public string Direccion { get; set; }
        public string Telefono_Fijo { get; set; }
        public string Telefono_Movil { get; set; }
        public string Genero { get; set; }
        public string Nro_Cuenta_Bancaria { get; set; }
        public string Codigo_Categoria_Ocupacion { get; set; }
        public string Ocupacion { get; set; }
        public string Centro_Costos { get; set; }
        public string Nivel_Salarial { get; set; }
        public string EstadoTrabajador { get; set; }
        public string Tipo_Contrato { get; set; }
        public string Tipo_Cese { get; set; }
        public string EstadoCivil { get; set; }
        public string TipodeComision { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCese { get; set; }
        public string PeriododeVacaciones { get; set; }
        public DateTime FechaReingreso { get; set; }
        public DateTime Fecha_Ult_Actualizacion { get; set; }
        public string EsReingreso { get; set; }
        public object BancoCTA_CTE { get; set; }
        public string Tipo_Cuenta { get; set; }
        public int RSV_Indem_Acumul { get; set; }
        public int Ao_Ult_Rsva_Indemni { get; set; }
        public int Mes_Ult_Rsva_Indemni { get; set; }
        public string FormaCalculo13ro { get; set; }
        public string FormaCalculo14ro { get; set; }
        public int BoniComplementaria { get; set; }
        public int BoniEspecial { get; set; }
        public int Remuneracion_Minima { get; set; }
        public int CuotaCuentaCorriente { get; set; }
        public string Fondo_Reserva { get; set; }
        public object Mensaje { get; set; }

        public string ObtenerCalculoDecimo13()
        {
            if (FormaCalculo13ro == "0")
            {
                return "Mensual";
            }
            else if (FormaCalculo13ro == "1")
            {
                return "Acumulada";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerCalculoDecimo14()
        {
            if (FormaCalculo14ro == "0")
            {
                return "Mensual";
            }
            else if (FormaCalculo14ro == "1")
            {
                return "Acumulada";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoTrabajador()
        {
            if (Tipo_trabajador == "1")
            {
                return "Administrativo";
            }
            else if (Tipo_trabajador == "2")
            {
                return "Comisionista";
            }
            else if (Tipo_trabajador == "3")
            {
                return "Comisionista Mixto";
            }
            else if (Tipo_trabajador == "4")
            {
                return "Docente";
            }
            else if (Tipo_trabajador == "5")
            {
                return "Servicios";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoCese()
        {
            if (Tipo_Cese == "1")
            {
                return "Renuncia_Voluntaria";
            }
            else if (Tipo_Cese == "2")
            {
                return "Reduccion_Personal";
            }
            else if (Tipo_Cese == "3")
            {
                return "Renuncia_Exigida";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }


        public string ObtenerTipoGenero()
        {
            if (Genero == "F")
            {
                return "Femenino";
            }
            else if (Genero == "M")
            {
                return "Masculino";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoOcupacion()
        {
            if (Ocupacion == "1")
            {
                return "Administrativo";
            }
            else if (Ocupacion == "2")
            {
                return "Operaciones";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoCentroCostos()
        {
            if (Centro_Costos == "0")
            {
                return "Centro0";
            }
            else if (Centro_Costos == "1")
            {
                return "Centro";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoNivelSalarial()
        {
            if (Nivel_Salarial == "1")
            {
                return "ALTO";
            }
            else if (Nivel_Salarial == "2")
            {
                return "MEDIO";
            }
            else if (Nivel_Salarial == "3")
            {
                return "BAJO";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoEstadoTrabajador()
        {
            if (EstadoTrabajador == "*")
            {
                return "Cesado";
            }
            else if (EstadoTrabajador == "V")
            {
                return "Vacaciones";
            }
            else if (EstadoTrabajador == "A")
            {
                return "Activo";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoContrato()
        {
            if (Tipo_Contrato == "1")
            {
                return "Indefinido";
            }
            else if (Tipo_Contrato == "2")
            {
                return "Obra_Cierta";
            }
            else if (Tipo_Contrato == "3")
            {
                return "Jornada_Parcial_Permanente";
            }
            else if (Tipo_Contrato == "4")
            {
                return "Evento_Continuo";
            }
            else if (Tipo_Contrato == "5")
            {
                return "Evento_Discontinuo";
            }
            else if (Tipo_Contrato == "6")
            {
                return "De_Temporada";
            }
            else if (Codigo_Categoria_Ocupacion == "7")
            {
                return "De_Aprendizaje";
            }
            else if (Codigo_Categoria_Ocupacion == "8")
            {
                return "De_Destajo";
            }
            else if (Codigo_Categoria_Ocupacion == "9")
            {
                return "Entre_Artesanos_Operarios";
            }
            else if (Codigo_Categoria_Ocupacion == "10")
            {
                return "Servicios_Domésticos";
            }


            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerCategoriaOcupacional()
        {
            if (Codigo_Categoria_Ocupacion == "1")
            {
                return "TRABAJADOR";
            }
            else if (Codigo_Categoria_Ocupacion == "2")
            {
                return "EMPLEADOR";
            }
            else if (Codigo_Categoria_Ocupacion == "3")
            {
                return "SERVICIOS PROFESIONALES";
            }
            else if (Codigo_Categoria_Ocupacion == "4")
            {
                return "PERSONAL RELIGIOSO";
            }
            else if (Codigo_Categoria_Ocupacion == "5")
            {
                return "AUTORIDADES Y DIRECTIVOS";
            }
            else if (Codigo_Categoria_Ocupacion == "6")
            {
                return "PROFESORES";
            }
            else if (Codigo_Categoria_Ocupacion == "7")
            {
                return "PERSONAL DE APOYO O AUXILIAR";
            }
            else if (Codigo_Categoria_Ocupacion == "8")
            {
                return "PERSONAL DE SERVICIO";
            }
            else if (Codigo_Categoria_Ocupacion == "9")
            {
                return "PERSONAL DE CONTABILIDAD";
            }
            else if (Codigo_Categoria_Ocupacion == "10")
            {
                return "PERSONAL DE MANTENIMIENTO";
            }
            else if (Codigo_Categoria_Ocupacion == "11")
            {
                return "PERSONAL DE SECRETARIA";
            }
            else if (Codigo_Categoria_Ocupacion == "12")
            {
                return "PERSONAL DE CONSEJERIA";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoEstadoCivil()
        {
            if (EstadoCivil == "1")
            {
                return "Soltero";
            }
            else if (EstadoCivil == "2")
            {
                return "Casado";
            }
            else if (EstadoCivil == "3")
            {
                return "Divorciado";
            }
            else if (EstadoCivil == "4")
            {
                return "Viudo";
            }
            else if (EstadoCivil == "5")
            {
                return "Unión_Libre";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoComision()
        {
            if (TipodeComision == "H")
            {
                return "Chofer";
            }
            else if (TipodeComision == "N")
            {
                return "Vendedor";
            }
            else if (TipodeComision == "O")
            {
                return "Cobrador";
            }
            else if (TipodeComision == "C")
            {
                return "Cajero";
            }
            else if (TipodeComision == "J")
            {
                return "Jefe Tienda";
            }
            else if (TipodeComision == "")
            {
                return "Otros";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoVacaciones()
        {
            if (PeriododeVacaciones == "1")
            {
                return "5 días";
            }
            else if (PeriododeVacaciones == "2")
            {
                return "15 días";
            }
            else if (PeriododeVacaciones == "3")
            {
                return "30 días";
            }
            else if (PeriododeVacaciones == "4")
            {
                return "45 días";
            }
            else if (PeriododeVacaciones == "5")
            {
                return "60 días";
            }
            else if (PeriododeVacaciones == "6")
            {
                return "Indefinido";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoReingreso()
        {
            if (EsReingreso == "1")
            {
                return "Si";
            }
            else if (EsReingreso == "0")
            {
                return "No";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoCuenta()
        {
            if (Tipo_Cuenta == "1")
            {
                return "Ahorros";
            }
            else if (Tipo_Cuenta == "2")
            {
                return "Corriente";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

        public string ObtenerTipoFondoReserva()
        {
            if (Fondo_Reserva == "M")
            {
                return "Mensual";
            }
            else if (Fondo_Reserva == "A")
            {
                return "Acumulada";
            }

            return string.Empty; // O retorna un valor por defecto si no se cumple ninguna condición
        }

    }
}
