using System.Diagnostics;

namespace TailwindWatcher
{
    public class TailwindUtils
    {
        /// <summary>
        /// Starts a process that watches for changes and rebuilds accordingly
        /// </summary>
        /// <param name="tailwindFullPath">The full path to your tailwind executeable</param>
        /// <param name="inputCssPath">The path to your input css from project root</param>
        /// <param name="outputCssPath">The path to your output css from wwwroot</param>
        public static void WatchTailwind(string tailwindFullPath, string inputCssPath, string outputCssPath)
        {
            try
            {
                var process = new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        FileName = tailwindFullPath,
                        Arguments = $"-i {inputCssPath} -o {outputCssPath}  --watch",
                        WindowStyle = ProcessWindowStyle.Normal,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                    }
                };

                bool started = process.Start();

                if (started)
                {
                    Console.WriteLine("Started TailwindCSS in watch-mode...");
                    process.WaitForExitAsync();
                }
                else
                {
                    Console.WriteLine("Failed to start TailwindCSS!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting TailwindCSS: {ex.Message}");
            }
        }
    }
}
