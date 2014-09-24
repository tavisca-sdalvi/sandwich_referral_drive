using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Data;
namespace DataAccessLayer
{
    public interface IFileReadWrite
    {
        void Write(ReferredApplicant obj);
        DataTable  Read();
        void Update(string updatedStatus,int refNo);
        DataView Search(string searchContent,string searchByCategory);
    }
}
