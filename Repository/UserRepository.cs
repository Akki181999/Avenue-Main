using Avenue.Model.Avenue;
using Avenue.Model.AvenueDTO;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Repository
{
    public class UserRepository
    {
        private readonly UnitOfWork unitOfWork;

        public UserRepository()
        {
            unitOfWork = new UnitOfWork();
        }

        public UserProfile GetUserProfileByUsername(Int32 userid)
        {
            return new XPQuery<UserProfile>(unitOfWork).FirstOrDefault(u => u.UserId == userid);
        }

        public UserProfileDto CreateUser(Int32 userId, string email, string password)
        {
            try
            {
                // Create a new UserProfile object
                var newUser = new UserProfile(unitOfWork)
                {
                    UserId = userId,
                    Email = email,
                    Password = password
                };

                
                
                unitOfWork.CommitChanges();

                
                var userProfileDto = new UserProfileDto
                {
                    UserId = newUser.UserId,
                    Email = newUser.Email
                    // You can add more properties if needed
                };

                return userProfileDto;
            }
            catch (Exception ex)
            {
               
                // Handle or throw the exception as needed
                throw;
            }
        }

        public UserProfileDto SaveUser(UserProfile user)
        {
            unitOfWork.CommitChanges();

            var userProfileDto = new UserProfileDto
            {
                UserId = user.UserId,
                Email = user.Email
                // You can add more properties if needed
            };

            return userProfileDto;
        }

        public UserDetailsDto SaveUserDetails (UserDetailsDto userDetailsDto)
        {
            try
            {
                var newUsers = new userdetails(unitOfWork)
                {
                    userid = userDetailsDto.UserId,
                    nationalid = userDetailsDto.NationalId,
                    email = userDetailsDto.Email,
                    firstname = userDetailsDto.FirstName,
                    lastname = userDetailsDto.LastName,
                    genderid = userDetailsDto.GenderId,
                    contactnumber = userDetailsDto.ContactNumber,
                    dateofbirth = userDetailsDto.DateOfBirth,
                    designation = userDetailsDto.Designation,
                    departmentid = userDetailsDto.DepartmentId,
                    roleid = userDetailsDto.RoleId,
                    isactive = userDetailsDto.IsActive
                };
                unitOfWork.CommitChanges();
                return userDetailsDto;
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, and rethrow or return an appropriate error response
                throw new Exception("An error occurred while saving user details.", ex);
            }
        }

        public userdetails UpdateUserDetails(userdetails user)
        {
            try
            {
                unitOfWork.CommitChanges();
                return user;
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, and rethrow or return an appropriate error response
                throw new Exception("An error occurred while saving user details.", ex);
            }
        }

        public userdetails GetByNationalId(string nationalId)
        {
            return new XPQuery<userdetails>(unitOfWork).FirstOrDefault(u => u.nationalid == nationalId);
        }
    }
}