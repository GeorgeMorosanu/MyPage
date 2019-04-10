using MyPage.Data.Interfaces;
using MyPage.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPage.Data.Implementations
{
    public class DataService : IDataService
    {
        public List<EducationData> getEducationData()
        {
            List<EducationData> result = new List<EducationData>();
            result.Add(new EducationData()
            {
                Title = "Bachelor of Science", //in
                Specialization = "Computer Science",
                NameOfInstitution = "\"Alexandru Ioan Cuza\" University of Iasi, Romania",
                Interval = "October 2015 - July 2018"
            });

            result.Add(new EducationData()
            {
                Title = "High School Diploma", //()
                Specialization = " Mathematics – Informatics specialization",
                NameOfInstitution = "\"Mihail Kogalniceanu\" Academic High School, Vaslui, Romania",
                Interval = "September 2011 - July 2015"
            });
            throw new NotImplementedException();
        }
    }
}
