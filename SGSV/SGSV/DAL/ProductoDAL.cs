﻿using System.Data;

namespace SGSV.DAL
{
    class ProductoDAL : ClsDAL
    {
        #region Marca

        public static DataTable GetMarcas()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Marca", true).Tables[0];
        }

        public static DataTable GetMarcas(string nombre)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Marca", true, "@nombre", DALAux.GetValue(nombre)).Tables[0];
        }

        public static DataRow GetMarca(int idMarca)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Marca", true, "@idMarca", DALAux.GetValue(idMarca)).Tables[0].Rows[0];
        }

        public static void GuardarMarca(int idMarca, string nombre)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_Marca", true,
                "@idMarca", idMarca,
                "@nombre", DALAux.GetValue(nombre));
        }

        #endregion Marca

        #region TipoProducto

        public static DataTable GetTiposProducto()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoProducto", true).Tables[0];
        }

        public static DataTable GetTiposProducto(string nombre)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoProducto", true, "@nombre", DALAux.GetValue(nombre)).Tables[0];
        }

        public static DataRow GetTipoProducto(int idTipoProducto)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoProducto", true, "@idTipoProducto", DALAux.GetValue(idTipoProducto)).Tables[0].Rows[0];
        }

        public static void GuardarTipoProducto(int idTipoProducto, string nombre)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_TipoProducto", true,
                "@idTipoProducto", idTipoProducto,
                "@nombre", DALAux.GetValue(nombre));
        }

        #endregion TipoProducto

        #region Producto

        public static DataTable GetProductos()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Producto", true).Tables[0];
        }

        public static DataTable GetProductos(int idMarca, int idTipoProducto, string nombre, string observaciones)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Producto", true,
                "@idMarca", DALAux.GetValue(idMarca),
                "@idTipoProducto", DALAux.GetValue(idTipoProducto),
                "@nombre", DALAux.GetValue(nombre),
                "@observaciones", DALAux.GetValue(observaciones)).Tables[0];
        }

        public static DataRow GetProducto(int idProducto)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Producto", true, "@idProducto", DALAux.GetValue(idProducto)).Tables[0].Rows[0];
        }

        public static void GuardarProducto(int idProducto, int idMarca, int idTipoProducto, string nombre, string observaciones)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_Producto", true,
                "@idProducto", idProducto,
                "@idMarca", idMarca,
                "@idTipoProducto", idTipoProducto,
                "@nombre", nombre,
                "@observaciones", observaciones);
        }

        #endregion Producto
    }
}
