using System;

using R5T.T0131;
using R5T.T0222;
using R5T.T0222.Extensions;


namespace R5T.Z0059
{
    [ValuesMarker]
    public partial interface IOrganizationNames : IValuesMarker
    {
        /// <summary>
        /// <para>"David Coats"</para>
        /// Note: has a space.
        /// </summary>
        public IOrganizationName DavidCoats => "David Coats".ToOrganizationName();

        /// <summary>
        /// <para>"Rivet"</para>
        /// </summary>
        public IOrganizationName Rivet => "Rivet".ToOrganizationName();

        /// <summary>
        /// <para>"Safety Cone"</para>
        /// Note: has a space.
        /// </summary>
        public IOrganizationName SafetyCone => "Safety Cone".ToOrganizationName();
    }
}
