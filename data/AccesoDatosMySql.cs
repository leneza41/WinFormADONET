using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormADONET.data
{
    class AccesoDatosMySql : IDisposable
    {
        MySqlConnection _connection;
        MySqlCommand _command;
        MySqlDataReader _reader;
        MySqlDataAdapter _adapter;
        private bool disposedValue;

        private void inicializarCommand(string query, Dictionary<string, object> prmts)
        {
            _command = new MySqlCommand(query, _connection);
            if (prmts != null && prmts.Count > 0)
            {
                foreach (var prm in prmts)
                {
                    _command.Parameters.AddWithValue(prm.Key, prm.Value);
                }
            }
        }

        public DataTable queryTable(string query, Dictionary<string, object> prmts)
        {

            inicializarCommand(query, prmts);
            _adapter = new MySqlDataAdapter(_command);
            var dataTable = new DataTable();
            _adapter.Fill(dataTable);
            return dataTable;
        }

        public int ejecutarSentencia(string sentenciaSQL, Dictionary<string, object> pmts)
        {

            if (_connection == null)
            {
                throw new InvalidOperationException("La conexión no está inicializada.");
            }
            inicializarCommand(sentenciaSQL, pmts);

            return _command.ExecuteNonQuery();
        }

        public async Task<int> ejecutarSentenciaAsync(string sentenciaSQL, Dictionary<string, object> pmts)
        {

            if (_connection == null)
            {
                throw new InvalidOperationException("La conexión no está inicializada.");
            }
            inicializarCommand(sentenciaSQL, pmts);

            var tareaA = _command.ExecuteNonQueryAsync();

            return await tareaA; // Espera a que se complete la tarea asincrónica
        }

        public MySqlDataReader ejecutarQuery(string consulta, Dictionary<string, object> pmts)
        {

            inicializarCommand(consulta, pmts);
            return _command.ExecuteReader();
        }

        public AccesoDatosMySql(string host, string db,
            string user, string password, int port)
        {

            //string connectionString = 
            //    $"Server={host};Database={db};User ID={user};" +
            //    $"Password={password};" +
            //    $"Port={port};";


            MySqlConnectionStringBuilder builderConnString =
                new MySqlConnectionStringBuilder();

            builderConnString.Server = host;
            builderConnString.Database = db;
            builderConnString.UserID = user;
            builderConnString.Password = password;
            builderConnString.Port = (uint)port;

            var otraCAdena =
                builderConnString.ConnectionString;
            _connection = new MySqlConnection(otraCAdena);
            _connection.Open();

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                    if (_reader != null)
                    {
                        _reader.Close();
                        _reader.Dispose();
                        _reader = null;
                    }
                    if (_command != null)
                    {
                        _command.Dispose();
                        _command = null;
                    }
                    if (_adapter != null)
                    {
                        _adapter.Dispose();
                        _adapter = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Close();
                        _connection.Dispose();
                        _connection = null;
                    }
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~AccesoDatosMySql()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
