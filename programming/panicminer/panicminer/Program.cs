#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace panicminer
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// Unless I'm running parallel this shouldn't even be edited
    /// as far as i'm aware, that would be "good" code.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
