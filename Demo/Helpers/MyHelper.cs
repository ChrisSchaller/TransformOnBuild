using System.Linq;

namespace Helpers
{
    public static class MyHelper
    {
        public static string Greet(string name)
        {
            return string.Format("Hello {0}!", name);
        }
    }
}