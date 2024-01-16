using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignerUnityOfWork.Interfaces.Repositories
{
    public interface IUnityOfWork : IDisposable
    {
        Task Commit();
    }
}