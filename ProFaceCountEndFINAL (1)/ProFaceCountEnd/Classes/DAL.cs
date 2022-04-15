using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;

namespace ProFaceCountEnd.Classes
{
    public class DAL
    {
        string connectionString = "Data Source=.;Initial Catalog=ProFaceCountEnd;Integrated Security=True";
        public BindingList<Sensor> Sensors = new BindingList<Sensor>();
        public List<SensorMeasurement> Measurements = new List<SensorMeasurement>();
        public BindingList<Location> Locations = new BindingList<Location>();
        public BindingList<Sensor> SensorOverview = new BindingList<Sensor>();
        public BindingList<SensorMeasurement> MeasurementOverview = new BindingList<SensorMeasurement>();


        public void CreateSensor(Sensor sensor, Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Sensor(Name, Description, LocationId) VALUES(@Name, @Description, @LocationId)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", sensor.Name);
                        command.Parameters.AddWithValue("@Description", sensor.Description);
                        command.Parameters.AddWithValue("@LocationId", location.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }
        public void FillSensorListFromDatabase()
        {
            Sensors.Clear();
            foreach (Location location in Locations)
            {
                location.Sensors.Clear();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
        
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Name, Description, LocationId FROM Sensor ORDER BY ID ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Sensor sensor = new Sensor(Int32.Parse(reader[0].ToString())
                                                        , reader[1].ToString()
                                                        , reader[2].ToString());
                            Sensors.Add(sensor);
                            foreach (Location location in Locations)
                            {
                                if (location.Id == Int32.Parse(reader[3].ToString()))
                                {
                                    location.ConnectSensorToLocation(sensor);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void DeleteSensor(Sensor sensor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM SensorMeasurement WHERE SensorId = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", sensor.Id);
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM Sensor WHERE Id = @Id";
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteSensorCascade(Sensor sensor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE Sensor WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", sensor.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateSensor(int id, string Name, string Description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Sensor SET Name = @Name, Description = @Description WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }

        }
        public void UpdateMeasurement(int Entryid, int PeopleIn, int PeopleOut, DateTime Timestamp)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE SensorReading SET People_in = @People_in, People_out = @People_out, TimeStamp = @TimeStamp WHERE EntryId = @EntryId";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EntryId", Entryid);
                        command.Parameters.AddWithValue("@People_in", PeopleIn);
                        command.Parameters.AddWithValue("@People_out", PeopleOut);
                        command.Parameters.AddWithValue("@TimeStamp", Timestamp);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }

        }
        public void DeleteMeasurement(SensorMeasurement measurement)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE SensorReading WHERE EntryId = @EntryId";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@EntryId", measurement.EntryId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void CreateLocation(Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Location(Name, MaxPersons) VALUES(@Name, @MaxPersons)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", location.Name);
                        command.Parameters.AddWithValue("@MaxPersons", location.MaxPersons);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }
        public void UpdateLocation(int id, string Name, int MaxPersons)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Location SET Name = @Name, MaxPersons = @MaxPersons WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@MaxPersons", MaxPersons);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }

        }
        public void DeleteLocationCascade(Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE Location WHERE Id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", location.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteLocations(Sensor sensor, Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Sensor WHERE LocationId = @LocationId";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LocationId", location.Id);
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM Location WHERE Id = @Id";
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void FillLocationListFromDatabase()
        {
            Locations.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Name, MaxPersons FROM Location ORDER BY ID ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Locations.Add(new Location(Int32.Parse(reader[0].ToString())
                                                        , reader[1].ToString()
                                                        , Int32.Parse(reader[2].ToString())));
                        }
                    }
                }
            }
        }
        public void FillMeasurementsFromDatabase()
        {
            Measurements.Clear();
            foreach (Sensor sensor in Sensors)
            {
                sensor.Measurements.Clear();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT EntryId, People_in, People_out, TimeStamp, SensorId FROM SensorReading ORDER BY EntryId";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            SensorMeasurement measurement = new SensorMeasurement(Int32.Parse(reader[0].ToString())
                                                        , Int32.Parse(reader[1].ToString())
                                                        , Int32.Parse(reader[2].ToString())
                                                        , DateTime.Parse(reader[3].ToString())
                                                        );
                            Measurements.Add(measurement);
                            foreach (Sensor sensor in Sensors)
                            {
                                if (sensor.Id == Int32.Parse(reader[4].ToString()))
                                {
                                    sensor.ConnectSensorMeasurementToSensor(measurement);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void SearchLocation(string Name)
        {
            //Sort & Search knop
            Locations.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Location WHERE Name = @Name";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Locations.Add(new Location(Int32.Parse(reader[0].ToString())
                                              , reader[1].ToString()
                                              , Int32.Parse(reader[2].ToString()) //Voor als het een int is: Int32.Parse(reader[3].ToString()
                                              ));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void SearchSensors(string Name)
        {
            //Sort & Search knop
            SensorOverview.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Sensor WHERE Name = @Name";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SensorOverview.Add(new Sensor(Int32.Parse(reader[0].ToString())
                                              , reader[1].ToString()
                                              , reader[2].ToString()
                                              ));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        

        public void FillSensorOverview()
        {
            SensorOverview.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Name, Description FROM Sensor ORDER BY ID ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SensorOverview.Add(new Sensor(Int32.Parse(reader[0].ToString())
                                                        , reader[1].ToString()
                                                        , reader[2].ToString()
                                                        
                                                        ));
                        }
                    }
                }
            }
        }
        public void FillMeasurementOverview()
        {
            MeasurementOverview.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT EntryId, People_in, People_out, TimeStamp FROM SensorReading ORDER BY EntryID ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MeasurementOverview.Add(new SensorMeasurement(Int32.Parse(reader[0].ToString())
                                                        , Int32.Parse(reader[1].ToString())
                                                        , Int32.Parse(reader[2].ToString())
                                                        , DateTime.Parse(reader[3].ToString())

                                                        ));
                        }
                    }
                }
            }
        }

    }
}
