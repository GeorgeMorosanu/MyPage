using MyPage.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPage.Data.Interfaces
{
    public interface IDataService
    {
        List<EducationData> getEducationData();
    }
}
