using FinalAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalAssessment.DataAccess
{
    public interface IDoctorDetailsService
    {
        public Task<List<DoctorDetail>> GetDoctorDetailsAsync();
        public Task CreateDoctorAsync(DoctorDetail doctorDetail);
        public Task<DoctorDetail?> DoctorDetailsAsync(int? id);
        public Task EditDoctorAsync(DoctorDetail doctorDetail);
        public Task DeleteDoctorAsync(DoctorDetail? doctorDetail);
    }
}
