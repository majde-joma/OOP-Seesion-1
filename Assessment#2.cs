namespace Proiect_2
{
    class MyCookieCollection
    {
        private Dictionary<string, string> _cookies = new Dictionary<string, string>();

        public string this[string name]
        {
            get
            {
                if (_cookies.ContainsKey(name))
                {
                    return _cookies[name];
                }
                return null;
            }
            set
            {
                _cookies[name] = value;
            }
        }

        public void PrintAllCookies()
        {
            foreach (var cookie in _cookies)
            {
                Console.WriteLine($"{cookie.Key}: {cookie.Value}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyCookieCollection cookies = new MyCookieCollection();

            cookies["username"] = "MaiHesham";
            cookies["theme"] = "dark";

            Console.WriteLine("Username: " + cookies["username"]);
            Console.WriteLine("Theme: " + cookies["theme"]);
            Console.WriteLine("Language: " + (cookies["language"] ?? "Not Set"));

            cookies.PrintAllCookies();

        }
    }
}
