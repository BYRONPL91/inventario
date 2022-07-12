using EFRepository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Repository : EFRepository.Repository, IRepository, IDisposable
    {
        public Repository(bool autoDetectChangesEnabled = false, bool proxiCreationEnabled = false) :
            base(new Entidades(), autoDetectChangesEnabled, proxiCreationEnabled)
        {
        }
    }
}
