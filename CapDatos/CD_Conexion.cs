using System.Data.SqlClient;
using System.Data;
public class CD_Conexion
{
    private SqlConnection Conexion = new SqlConnection("Server=(local);DataBase= Practica;Integrated Security=true");

    public SqlConnection AbrirConexion()
    {
        if (Conexion.State == ConnectionState.Closed)
            Conexion.Open();
        return Conexion;
    }

    public SqlConnection CerrarConexion()
    {
        if (Conexion.State == ConnectionState.Open)
            Conexion.Close();
        return Conexion;
    }
}