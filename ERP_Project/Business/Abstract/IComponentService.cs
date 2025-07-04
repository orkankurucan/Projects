using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IComponentService
    {
        List<Components>GetAll();
        void Add(Components submaterial, out string message);
        void Delete(Components submaterial, out string message);

        void Update(Components submaterial, out string message);
        int GetComponentId(string componentCode);
        Components GetByCode(string componentCode);
        Components GetById(int componentId);
    }
}
