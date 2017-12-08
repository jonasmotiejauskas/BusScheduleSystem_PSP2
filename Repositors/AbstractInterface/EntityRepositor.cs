using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractSchedule.Entities;

namespace Repositors.AbstractInterface
{
    public interface IEntityRepositor
    {
        Entity ReadEntity(int _id);
        int CreateEntity(Entity _o);
        void UpdateEntity(int _id, Entity _o);
        void DeleteEntity(int _id);
    }
}
