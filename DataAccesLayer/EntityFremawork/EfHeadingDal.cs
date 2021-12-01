using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositoires;
using EntityLayer.Concrate;

namespace DataAccesLayer.EntityFremawork
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
}
