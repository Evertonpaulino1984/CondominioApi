using CondominioApi.Core.Interface;
using CondominioApi.Domain;
using CondominioApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioApi.Core
{
    public class ResidentService : IResidentService
    {
        private readonly IResidentRepository _residentRepository;
        public ResidentService(IResidentRepository residentRepository)
        {
            _residentRepository = residentRepository;
        }
        public Resident CreateResident(Resident resident)
        {
            return _residentRepository.CreateResident(resident);
        }

        public string DeleResident(string residentKey)
        {
            throw new NotImplementedException();
        }

        public Resident GetResidentByKey(string residentKey)
        {
            var resident = _residentRepository.GetResidentByKey(residentKey);

            return resident;
        }

        public List<Resident> GetResidents()
        {
            var residents = _residentRepository.GetResident();

            return residents;
        }

        public Resident UpdateResident(Resident resident)
        {
            return _residentRepository.UpdateResident(resident);
        }
    }
}
