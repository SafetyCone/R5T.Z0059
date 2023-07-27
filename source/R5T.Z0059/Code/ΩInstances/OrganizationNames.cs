using System;


namespace R5T.Z0059
{
    public class OrganizationNames : IOrganizationNames
    {
        #region Infrastructure

        public static IOrganizationNames Instance { get; } = new OrganizationNames();


        private OrganizationNames()
        {
        }

        #endregion
    }
}
