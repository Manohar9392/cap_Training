
namespace CommonLib{

public abstract class Login_access
    {
        public abstract String Login(String username,int id);
        public abstract String Logout();

        protected String Confidential_data()
        {
            return "This Lab Secret id is 5677";
        }

        public bool Login_process()
        {
            return true;
        }
        
    } 

}
