using Library.Context;
using User1.Model;
using Dapper;
using System.Data;

namespace User1.Repository
{
    public class AuthRepository
    {
        public interface IAuthRepository
        {
            UserLogin GetUserByEmail(string email);
            void AddUser(UserLogin user);
        }
        public class AuthRepository : IAuthRepository
        {
            private readonly LibraryDbContext _dbContext;

            public AuthRepository(LibraryDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void AddUser(UserLogin user)
            {
                var query = "INSERT INTO Users(Name,Email,PasswordHash,PasswordSalt) VALUES(@name,@surn,@email,@passwordHash,@passwordSalt)";
                
                var parameters = new DynamicParameters();

                parameters.Add("name", user.Name, DbType.String);
                parameters.Add("email", user.Email, DbType.String);
                parameters.Add("passwordHash", user.PasswordHash, DbType.Binary);
                parameters.Add("passwordSalt", user.PasswordSalt, DbType.Binary);

                using (var connection = _dbContext.CreateConnection())
                {
                    connection.Execute(query, parameters);
                }
            }

            public UserLogin GetUserByEmail(string email)
            {
                var query = "Select * from Users Where Email = @email";
                using (var connection = _dbContext.CreateConnection())
                {
                    var user = connection.QuerySingleOrDefault<UserLogin>(query, new { email });
                    return user;
                }
            }
        }
    }
}

