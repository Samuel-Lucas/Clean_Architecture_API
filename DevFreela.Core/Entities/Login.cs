namespace DevFreela.Core.Entities
{
    public class Login : MainEntity
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}