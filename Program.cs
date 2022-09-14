using DBInteraction;
public class Program
{
    public static void Main()
    {
        ZeissDevicesContext context = new ZeissDevicesContext();
        Device device = new Device() {  Name = "DeviceA", Price = (decimal)4.12 };
        Device device1 = new Device() {  Name = "DeviceB", Price = (decimal)8.12 };
        Device device2 = new Device() {  Name = "DeviceC", Price = (decimal)4.37 };
        Device device3 = new Device() {  Name = "DeviceD", Price = (decimal)10.00 };
        context.Devices.Add(device);
        context.Devices.Add(device1);
        context.Devices.Add(device2);
        context.Devices.Add(device3);
        context.SaveChanges();
        foreach(var devicex in context.Devices)
        {
            Console.WriteLine(devicex.Name);
        }
    }
}