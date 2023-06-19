namespace QCS.TechTest.Q1
{
    public class CommandLogger : Logger
    {
        public void LogCommand(ICommand c)
        {
            var message = $"Command {c.GetType().FullName} with Id {c.Id} received at: {DateTime.UtcNow}";
            base.Log(message);
        }
    }
}
