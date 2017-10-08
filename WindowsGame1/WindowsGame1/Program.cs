using System;

namespace WindowsGame1
{
#if WINDOWS || XBOX
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// private string[]= new string[] { };;
        static void Main(string[] args)
        {
            bool runned = true;
            foreach (string a in args)
            {
                if (a.Contains("testmode"))
                {
                    using (Game1 game = new Game1(a))
                    {
                        game.Run();
                    }
                    runned = false;
                }

            }
            while (runned)
            {
                using (Game1 game = new Game1(""))
                {
                    game.Run();
                }
                runned = false;
            }
        }
    }
#endif
}

