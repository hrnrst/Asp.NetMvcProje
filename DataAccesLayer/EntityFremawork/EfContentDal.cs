using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositoires;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFremawork
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    { 
    }
}
