using System.Text;

namespace MiniPersonelTakip.Helpers
{
    public static class ExceptionHelper
    {
        public static string GetFullMessage(Exception ex)
        {
            var sb = new StringBuilder();
            var current = ex;
            var index = 1;

            while (current != null)
            {
                sb.AppendLine($"[{index}] {current.Message}");
                current = current.InnerException;
                index++;
            }

            return sb.ToString();
        }
    }
}