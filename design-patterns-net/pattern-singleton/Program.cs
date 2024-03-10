using pattern_singleton.Data;

Config config1 = Config.GetInstance();
config1.SetHost("localhost");
config1.SetPort("8080");
Console.WriteLine(config1.ToString());

Config config2 = Config.GetInstance();
Console.WriteLine(config2.ToString());

