using Newtonsoft.Json;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp.Domain.DTO
{
  public class EmployeesDTO : DataTransferObject
  {
        public string Name { get; set; }
        public string Phone { get; set; }
  }
}
