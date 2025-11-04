// See https://aka.ms/new-console-template for more information
using MultiSensors;
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");

// test out the classes!

List<SensorBase> sensors = new List<SensorBase>();

SensorTemperature sensorTemperature = new SensorTemperature();
SensorTemperature sensorTemperature2 = new SensorTemperature();
SensorWind wind = new SensorWind();
SensorWind wind2 = new SensorWind();

sensors.Add(sensorTemperature);
sensors.Add(sensorTemperature2);
sensors.Add(wind);
sensors.Add(wind2);

foreach (SensorBase sensor in sensors)
{
    sensor.Read();
}