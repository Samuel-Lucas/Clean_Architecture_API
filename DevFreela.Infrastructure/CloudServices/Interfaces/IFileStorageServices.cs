using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageServices
    {
        void UploadFile(Byte[] bytes, string fileName);
    }
}