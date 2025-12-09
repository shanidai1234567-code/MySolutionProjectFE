using ICloseToHelp;
using Model;
using System.Threading.Tasks;

namespace Test_With_Server
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyApi myApi = new MyApi();
            CityList cS = await myApi.GetAllCities();
            foreach (City c in cS)
            {
                Console.WriteLine($"{c}");
            }
        }
    }
}
