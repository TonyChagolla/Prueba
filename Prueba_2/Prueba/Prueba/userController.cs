using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
namespace Prueba
{
    class userController
    {
        private Conexion con = new Conexion("localhost", "examen", "examen", "prueba");


        public DataTable ObtenerTopTen()
        {
            return GetTopTen();
        }
        public DataTable ObtenerParaCSV()
        {
            return GetAllForCSV();
        }

        public bool AgregarUsuario(string login, string nombre, string paterno, string materno, float sueldo)
        {
            return AddNew(login, nombre, paterno, materno, sueldo);
        }

        public bool CambiarSueldo(string login, float sueldo)
        {
            return ChangeSalary(login, sueldo);
        }

        private DataTable GetTopTen()
        {
            string query = "SELECT TOP 10 [Login], Nombre, Paterno, Materno, Sueldo, FechaIngreso FROM USUARIOS u INNER JOIN EMPLEADOS e ON u.userId = e.userId";
            DataTable dt = con.ExecQuery(query);
            return dt;
        }

        private DataTable GetAllForCSV()
        {
            string query = "SELECT [Login], CONCAT(Nombre, ' ', Paterno, ' ', Materno) [Nombre Completo], Sueldo, FechaIngreso [Fecha Ingreso]"
                            + " FROM usuarios u inner join empleados e on e.userId = u.userId";
            DataTable dt = con.ExecQuery(query);
            return dt;
        }

        private bool AddNew(string login, string nombre, string paterno, string materno, float sueldo)
        {
            string query = "DECLARE @Last_id int; "
                            + " INSERT INTO usuarios([LOGIN], Nombre, Paterno, Materno) VALUES(@login, @Nombre, @Materno, @Paterno); "
                            + " SELECT @Last_id = SCOPE_IDENTITY(); "
                            + " insert into empleados(userId, sueldo, FechaIngreso) values(@Last_id, @Sueldo, GETDATE());";
            return con.AgregarUsuario(query, login, nombre, paterno, materno, sueldo);
        }

        private bool ChangeSalary(string login,  float sueldo)
        {
            string query = "UPDATE e SET Sueldo = @Sueldo FROM usuarios u  inner join empleados e on e.userId = u.userId WHERE [Login] = @Login;"
                           + " SELECT CASE WHEN @@ROWCOUNT >= 1 THEN CAST(1 as BIT) ELSE CAST (0 AS BIT) END resultado;";
            return con.ModificarSueldo(query, login, sueldo);
        }

    }
}
