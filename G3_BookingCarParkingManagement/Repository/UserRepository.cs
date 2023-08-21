using DataAccessObject;
using DataObject.Models;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>
    {
        public List<User> GetMembers() => CustomerDao.Instance.GetMembers();

        public User CheckLogin(string email, string password) => CustomerDao.Instance.CheckLogin(email, password);

        public User GetMemberByMemberID(string memberID) => CustomerDao.Instance.GetMemberByMemberID(memberID);

        public bool CheckUpdateEmailDuplicated(int memberID, string email) => CustomerDao.Instance.CheckUpdateEmailDuplicated(memberID, email);

        public bool CheckMemberIdDuplicated(int memberID) => CustomerDao.Instance.CheckMemberIdDuplicated(memberID);

        public bool CheckEmailDuplicated(int memberID, string email) => CustomerDao.Instance.CheckEmailDuplicated(email);

        public void UpdateMember(User m) => CustomerDao.Instance.UpdateMember(m);

        // Additional methods from RepositoryBase<User>
        public List<Baixe> GetBaiXe() => throw new NotImplementedException();

        public List<Baixe> SearchProduct(string keyword, string type) => throw new NotImplementedException();
    }
}
