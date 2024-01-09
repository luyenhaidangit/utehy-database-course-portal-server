namespace UTEHY.DatabaseCoursePortal.Api.Helpers
{
    public static class StringHelper
    {
        private static Random random = new Random();

        public static string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
