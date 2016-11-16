using Synergy.Core;
using Synergy.NHibernate;
using Synergy.Web.Mvc;

namespace Synergy.Strategossa.Web
{
    public class StrategossaWebLibrary : Library
    {
        public StrategossaWebLibrary() : base(
            new SynergyWebMvcLibrary(),
            new SynergyNHibernateLibrary(),
            new SynergyCoreLibrary())
        {
        }
    }
}