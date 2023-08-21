using DataObject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDao
    {
        private static CustomerDao instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDao() { }

        public static CustomerDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDao();
                    }
                    return instance;
                }
            }
        }
        public User GetMemberByMemberID(string memberID)
        {
            User mem = new User();
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    mem = dbContext.Users.SingleOrDefault(m => m.UserId == int.Parse(memberID));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }
        public List<User> GetMembers()
        {
            var listMembers = new List<User>();
            try
            {
                using (var db = new BookingCarParkingManagementContext())
                {
                    listMembers = db.Users.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listMembers;
        }
        public User CheckLogin(String email, String password)
        {
            var listMembers = new List<User>();
            User member;
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    member = dbContext.Users.SingleOrDefault(m => m.Email == email && m.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        public Boolean CheckMemberIdDuplicated(int memberID)
        {
            Boolean check = false;
            User mem = new User();
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    mem = dbContext.Users.SingleOrDefault(m => m.UserId == memberID);
                }
                if (mem != null)
                {
                    check = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

        public Boolean CheckEmailDuplicated(string email)
        {
            Boolean check = false;
            User mem = new User();
            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    mem = dbContext.Users.SingleOrDefault(m => m.Email.Equals(email));
                }
                if (mem != null)
                {
                    check = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }
        public void UpdateMember(User m)
        {
            try
            {
                using (var context = new BookingCarParkingManagementContext())
                {
                    context.Entry<User>(m).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Boolean CheckUpdateEmailDuplicated(int memberID, string email)
        {
            Boolean check = false;
            User mem = new User();

            try
            {
                using (var dbContext = new BookingCarParkingManagementContext())
                {
                    mem = dbContext.Users.SingleOrDefault(m => m.Email.Equals(email));
                }
                if (mem == null)
                {
                    check = false;
                }
                else
                {
                    if (mem.UserId.Equals(memberID))
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return check;
        }

    }
}
