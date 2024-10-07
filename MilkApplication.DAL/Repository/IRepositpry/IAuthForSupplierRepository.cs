using MilkApplication.DAL.enums;
using MilkApplication.DAL.Models.DTO;
using MilkApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkApplication.DAL.Repository.IRepositpry
{
    public interface IAuthForSupplierRepository
    {
        Task<ResponseDTO> GetUserByIdAsync(string userId);
        Task<ResponseDTO> GetUserByEmailAsync(string email);
        Task<ResponseDTO> GetUserByUserNameAsync(string userName);
        Task<ResponseDTO> CreateUserAsync(ApplicationUser user, string password);
        Task<ResponseDTO> CheckPasswordAsync(ApplicationUser user, string password);
        Task<ResponseDTO> AddUserToRoleAsync(ApplicationUser user, UserRole role);
        Task UpdateUserAsync(ApplicationUser user);
    }
}
