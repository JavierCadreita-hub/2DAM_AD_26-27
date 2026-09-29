using System;
using System.Collections.Generic;
using System.Linq;

namespace _02LinqPersonas.Models
{
    public class ProvinciasEnRepositorio
    {
        /// <summary>
        /// Diccionario que almacena las provincias, asociadas a su matrícula provincial como clave.
        /// </summary>
        private Dictionary<string, Provincia> provincias { get; set; }

        public ProvinciasEnRepositorio()
        {
            provincias = ObtenerProvincias();
        }

        /// <summary>
        /// Devuelve todas las provincias almacenadas.
        /// </summary>
        public IEnumerable<Provincia> GetProvincias()
        {
            return null;
        }

        /// <summary>
        /// Devuelve las provincias cuyo nombre comienza por la cadena especificada.
        /// </summary>
        /// <param name="nombre">Texto inicial para filtrar el nombre de la provincia.</param>
        public IEnumerable<Provincia> GetProvinciasComienzanPor(string? nombre)
        {
           return null;
        }

        /// <summary>
        /// Devuelve una provincia según su identificador (matrícula provincial).
        /// </summary>
        /// <param name="id">Identificador de la provincia (ej: "NA", "M", "B").</param>
        /// <returns>La provincia encontrada o null si no existe.</returns>
        public Provincia? GetProvinciaPorId(string id)
        {
            
                return null;
            
        }
        /// <summary>
        /// Carga y devuelve las provincias de España indexadas por su matrícula provincial.
        /// </summary>
        private static Dictionary<string, Provincia> ObtenerProvincias()
        {
            var provincias = new List<Provincia>
            {
                new Provincia("C", "A Coruña"),
                new Provincia("VI", "Álava"),
                new Provincia("AB", "Albacete"),
                new Provincia("A", "Alicante"),
                new Provincia("AL", "Almería"),
                new Provincia("O", "Asturias"),
                new Provincia("AV", "Ávila"),
                new Provincia("BA", "Badajoz"),
                new Provincia("PM", "Baleares"),
                new Provincia("B", "Barcelona"),
                new Provincia("BU", "Burgos"),
                new Provincia("CC", "Cáceres"),
                new Provincia("CA", "Cádiz"),
                new Provincia("S", "Cantabria"),
                new Provincia("CS", "Castellón"),
                new Provincia("CE", "Ceuta"),
                new Provincia("CR", "Ciudad Real"),
                new Provincia("CO", "Córdoba"),
                new Provincia("CU", "Cuenca"),
                new Provincia("GI", "Girona"),
                new Provincia("GR", "Granada"),
                new Provincia("GU", "Guadalajara"),
                new Provincia("SS", "Guipúzcoa"),
                new Provincia("H", "Huelva"),
                new Provincia("HU", "Huesca"),
                new Provincia("J", "Jaén"),
                new Provincia("LO", "La Rioja"),
                new Provincia("GC", "Las Palmas"),
                new Provincia("LE", "León"),
                new Provincia("L", "Lleida"),
                new Provincia("LU", "Lugo"),
                new Provincia("M", "Madrid"),
                new Provincia("MA", "Málaga"),
                new Provincia("ML", "Melilla"),
                new Provincia("MU", "Murcia"),
                new Provincia("NA", "Navarra"),
                new Provincia("OR", "Ourense"),
                new Provincia("P", "Palencia"),
                new Provincia("PO", "Pontevedra"),
                new Provincia("SA", "Salamanca"),
                new Provincia("TF", "Santa Cruz de Tenerife"),
                new Provincia("SG", "Segovia"),
                new Provincia("SE", "Sevilla"),
                new Provincia("SO", "Soria"),
                new Provincia("T", "Tarragona"),
                new Provincia("TE", "Teruel"),
                new Provincia("TO", "Toledo"),
                new Provincia("V", "Valencia"),
                new Provincia("VA", "Valladolid"),
                new Provincia("BI", "Vizcaya"),
                new Provincia("ZA", "Zamora"),
                new Provincia("Z", "Zaragoza")
            };

            return provincias.ToDictionary(p => p.Id, p => p);
        }
    }
}
