using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.CodeDom;

namespace Exercise1and2
{
    // ***************** Exercise 1: Design a database connection *****************

    public abstract class DbConnection
    {
        private readonly string _connectionString;

        protected readonly TimeSpan _timeOut = TimeSpan.FromSeconds(5);
        protected readonly DateTime _timeIn;

        public DbConnection(string connectionString)
        {
            try
            {
                if (connectionString == null)
                {
                    throw new ArgumentNullException("No connection string provided. Please enter a connection string and try again.");
                }
                else
                {
                    _connectionString = connectionString;
                    _timeIn = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public abstract bool OpenConnection();
        public abstract void CloseConnection();

    }

    public class SqlConnection : DbConnection
    {
        private bool isConnected = false;
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override bool OpenConnection()
        {
            try
            {
                if(isConnected)
                {
                    throw new Exception("A connection is already established");
                }
                if (((DateTime.Now - _timeIn) <= _timeOut))
                {
                    Console.WriteLine("Open SQL Connection");
                    isConnected = true;
                }
                else
                {
                    throw new TimeoutException("Open Connection timed out. Please retry creating connection and open connection within required timeout limit");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return isConnected;
        }

        public override void CloseConnection()
        {
            try
            {
                if (isConnected)
                {
                    Console.WriteLine("Close SQL Connection");
                }
                else
                {
                    throw new Exception("No connection was established to close.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

    public class OracleConnection : DbConnection
    {
        private bool isConnected = false;
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override bool OpenConnection()
        {
            try
            {
                if (isConnected)
                {
                    throw new Exception("A connection is already established");
                }

                if (((DateTime.Now - _timeIn) <= _timeOut))
                {
                    Console.WriteLine("Open Oracle Connection");
                    isConnected = true;
                }
                else
                {
                    throw new TimeoutException("Open Connection timed out. Please retry creating connection and open connection within required timeout limit");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isConnected;
        }


        public override void CloseConnection()
        {
            try
            {
                if (isConnected)
                {
                    Console.WriteLine("Close Oracle Connection");
                }
                else
                {
                    throw new Exception("No connection was established to close.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    // ************************ Exercise 2: Design a database command ************************

    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;
        public DbCommand(DbConnection connection, string instruction)
        {
            ValidateConnectionInstruction(connection, instruction);
        }

        private void ValidateConnectionInstruction(DbConnection connection, string instruction)
        {
            try
            {
                if (connection == null)
                {
                    throw new ArgumentNullException("No connection is provided. Please provide a connection");
                }
                else if (instruction == null)
                {
                    throw new ArgumentNullException("No instruction string provided. Please add an instruction string and try again.");
                }
                else
                {
                    _connection = connection;
                    _instruction = instruction;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Execute()
        {
            if (_connection.OpenConnection())
            {
                Console.WriteLine("Instruction {0} running", _instruction);
                _connection.CloseConnection();

            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection sqlConnection = new SqlConnection("sqlconnect01");
            //Thread.Sleep(5000);
            //sqlConnection.OpenConnection();
            //sqlConnection.CloseConnection();

            //OracleConnection oracleConnection = new OracleConnection("oracleconnect01");

            //oracleConnection.OpenConnection();
            //oracleConnection.CloseConnection();

            //////////////////////////////////////

            //Exercise 2
            //DbCommand sqlCommand = new DbCommand(new SqlConnection("sqlConnection"), null);
            DbCommand sqlCommand = new DbCommand(new SqlConnection("sqlConnection"), "instruction01");            
            sqlCommand.Execute();

            DbCommand oracleCommand = new DbCommand(new OracleConnection(null), "instruction02");
            oracleCommand.Execute();


        }
    }
}
