namespace Entities.RequestFeatures {
    public class OrganizationParameters : RequestParameters {
        public OrganizationParameters() {
            OrderBy = "name";
        }

        public string SearchTerm { get; set; }
    }
}
