namespace T4Helper
{
    public static class LabelHelper
    {
        public static string Render(string text)
        {
            return string.Format("<Label>{0}</Label>", text);
        }
    }
}
