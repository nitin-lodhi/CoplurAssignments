public class UserManager : IUserManager
{


static List<User> users = new List<User>
    {
        new User
        {
            id = 1,
            name = "Anubhav Gupta",
            role = "Software Engineer",
            city = "Delhi",
            projects = "E-commerce App, Inventory System",
            following = "250",
            followers = "1200"
        },
        new User
        {
            id = 2,
            name = "Sohel Mansoori",
            role = "Frontend Developer",
            city = "Mumbai",
            projects = "Portfolio Website, Blog Platform",
            following = "180",
            followers = "900"
        },
        new User
        {
            id = 3,
            name = "Abhishek Rajpoot",
            role = "Backend Developer",
            city = "Lucknow",
            projects = "API Development, CRM System",
            following = "300",
            followers = "1400"
        },
        new User
        {
            id = 4,
            name = "Saksham Pathak",
            role = "Full Stack Developer",
            city = "Bangalore",
            projects = "Chat App, Task Management Tool",
            following = "400",
            followers = "1600"
        },
        new User
        {
            id = 5,
            name = "Ravi Kumar",
            role = "DevOps Engineer",
            city = "Hyderabad",
            projects = "CI/CD Pipeline, Cloud Automation",
            following = "220",
            followers = "1300"
        }
    };


    public List<User> GetAllUser()
    {
        return users;
    }

    public User GetUserById(int id)
    {
        return users.FirstOrDefault(user => user.id == id);
    }
}