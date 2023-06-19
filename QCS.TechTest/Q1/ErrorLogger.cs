namespace QCS.TechTest.Q1
{
    public class ErrorLogger : Logger
    {
        public void LogError(Exception e)
        {
            var message = $"Error {e.Message} occurred at: {DateTime.UtcNow}";
            base.Log(message);
        }
    }
}
