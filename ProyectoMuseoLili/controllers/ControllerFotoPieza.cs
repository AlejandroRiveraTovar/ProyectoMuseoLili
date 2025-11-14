using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerFotoPieza
    {
        internal bool InsertNewFoto(FotoPieza objF)
        {
            string sql = $"INSERT INTO fotosPieza VALUES ({objF.UUIDFotoP1},'{objF.NombreFotoP}','{objF.ArchivoFotoP}','{objF.UUIDPieza_PFP1}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal FotoPieza BuscarFoto(int UUIDFotoP)
        {
            string sql = $"SELECT * FROM fotosPieza WHERE UUIDFotoP={UUIDFotoP};";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarFoto(sql);
        }
    }
}
