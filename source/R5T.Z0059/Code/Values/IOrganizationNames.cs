using System;

using R5T.T0131;
using R5T.T0222;
using R5T.T0222.Extensions;


namespace R5T.Z0059
{
    /// <summary>
    /// Top-level organization names.
    /// </summary>
    [ValuesMarker]
    public partial interface IOrganizationNames : IValuesMarker
    {
        /// <summary>
        /// <para>"David Coats"</para>
        /// Note: has a space.
        /// </summary>
        public const string DavidCoats_Constant = "David Coats";

        /// <inheritdoc cref="DavidCoats_Constant"/>
        public IOrganizationName DavidCoats => IOrganizationNames.DavidCoats_Constant.ToOrganizationName();

        /// <summary>
        /// <para>"Rivet"</para>
        /// </summary>
        public const string Rivet_Constant = "Rivet";

        /// <inheritdoc cref="Rivet_Constant"/>
        public IOrganizationName Rivet => "Rivet".ToOrganizationName();

        /// <summary>
        /// <para>"Safety Cone"</para>
        /// Note: has a space.
        /// </summary>
        public const string SafetyCone_Constant = "Safety Cone";

        /// <inheritdoc cref="SafetyCone_Constant"/>
        public IOrganizationName SafetyCone => "Safety Cone".ToOrganizationName();
    }
}
