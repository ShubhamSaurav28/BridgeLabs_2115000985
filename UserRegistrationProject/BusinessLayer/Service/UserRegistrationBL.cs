using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _repositoryLayer;

        public UserRegistrationBL()
        {
            _repositoryLayer = new UserRegistrationRL();
        }

        public string RegistrationBL(string username, string password)
        {
            var (storedUsername, storedPassword) = _repositoryLayer.RegistrationRL();

            if (username == storedUsername && password == storedPassword)
                return "Login Successful";
            else
                return "Invalid username and password";
        }
    }
}
