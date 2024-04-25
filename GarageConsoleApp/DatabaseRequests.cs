using Npgsql;

namespace GarageConsoleApp;

/// <summary>
/// Класс DatabaseRequests
/// содержит методы для отправки запросов к БД
/// </summary>
public static class DatabaseRequests
{
    public static void GetTypeCarQuery()
    {
        var querySql = "SELECT * FROM type_car";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Название: {reader[1]}");
        }
    }
    public static void AddTypeCarQuery(string name)
    {
        var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    public static void AddDriverQuery(string firstName, string lastName, DateTime birthdate)
    {
        var querySql = $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{birthdate}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    public static void GetDriverQuery()
    {
        var querySql = "SELECT * FROM driver";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
        }
    }
    public static void AddRightsCategoryQuery(string name)
    {
        var querySql = $"INSERT INTO rights_category(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    public static void AddDriverRightsCategoryQuery(int driver, int rightsCategory)
    {
        var querySql = $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ({driver}, {rightsCategory})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void GetDriverRightsCategoryQuery(int driver)
    {
        var querySql = "SELECT dr.first_name, dr.last_name, rc.name " +
                       "FROM driver_rights_category " +
                       "INNER JOIN driver dr on driver_rights_category.id_driver = dr.id " +
                       "INNER JOIN rights_category rc on rc.id = driver_rights_category.id_rights_category " +
                       $"WHERE dr.id = {driver};";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
        }
    }
    public static void GetCarQuery()
    {
        var query = "SELECT * FROM car";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]}, Название: {reader[2]}, Номер: {reader[3]}, Тип автомобиля: {reader[1]}");
        }
    }
    public static void AddCarQuery(int idTypeCar, string name, string stateNumber, int numPassengers)
    {
        var query = $"INSERT INTO car (id_type_car, name, state_number, number_passengers) VALUES ({idTypeCar}, '{name}', '{stateNumber}', {numPassengers})";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    public static void GetRouteQuery()
    {
        var query = "SELECT * FROM route";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]}, ID водителя: {reader[1]}, ID автомобиля: {reader[2]}, ID маршрута: {reader[3]}, Количество пассажиров: {reader[4]}");
        }
    }
    public static void AddRouteQuery(int driverId, int carId, int itineraryId, int numPassengers)
    {
        var query = $"INSERT INTO route (id_driver, id_car, id_itinerary, number_passengers) VALUES ({driverId}, {carId}, {itineraryId}, {numPassengers})";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    public static void GetItineraryQuery()
    {
        var query = "SELECT * FROM itinerary";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());;
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]}, Название маршрута: {reader[1]}");
        }
    }
    public static void AddItineraryQuery(string name)
    {
        var query = $"INSERT INTO itinerary (name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(query, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
}