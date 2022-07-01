using Entities.Entities.RequestFeatures;

namespace Entities.RequestFeatures {
    public class UserParameters : RequestParameters {
        public UserParameters()
        {
            OrderBy = "name";
        }

        public uint MinAge { get; set; }
        public uint MaxAge { get; set; }

        public bool ValidAgeRange => MaxAge > MinAge;

        public string SearchTerm { get; set; }

    }

}
