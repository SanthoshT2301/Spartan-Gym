using System;
using System.Collections.Generic;
using System.Text;
using SpartanGym_Core.DTO;

namespace SpartanGym_Business.Interface.Supplements
{

//GetAllSupplements
//GetSupplementById
//AddSupplement
//RemoveSupplement

    public interface ISupplementService
    {
        public Task<List<SupplementDto>> GetAllSupplements();
        public Task<SupplementDto> GetSupplementById(int Id);
        public Task<bool> AddSupplement(SupplementDto AddSupplement);
        public Task<bool> DeleteSupplement(int Id);
        
    }
}
