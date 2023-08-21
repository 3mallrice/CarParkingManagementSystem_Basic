using DataObject.Models;

namespace Repository
{
    public interface IUserRepository
    {
        public User CheckLogin(string email, string password);

        public List<User> GetMembers();

        public User GetMemberByMemberID(string memberID);
        public bool CheckUpdateEmailDuplicated(int memberID, string email);

        public bool CheckMemberIdDuplicated(int memberID);

        public bool CheckEmailDuplicated(int memberID, string email);

         void UpdateMember(User m);

    }
}
