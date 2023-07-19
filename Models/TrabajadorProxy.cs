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
        public int PeriododeVacaciones { get; set; }
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


    }
}
