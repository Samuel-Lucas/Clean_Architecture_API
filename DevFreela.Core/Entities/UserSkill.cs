using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class UserSkill : MainEntity
    {
        public int IdUser { get; private set; }
        public int IdSkill { get; private set; }
    }
}