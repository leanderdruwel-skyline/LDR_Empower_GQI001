using System;
using Skyline.DataMiner.Analytics.GenericInterface;

namespace LDREmpowerGQI001
{
    /// <summary>
    /// Represents a data source.
    /// See: https://aka.dataminer.services/gqi-external-data-source for a complete example.
    /// </summary>
    [GQIMetaData(Name = "LDR_Empower_GQI001")]
    public sealed class LDREmpowerGQI001 : IGQIDataSource
    {
        public GQIColumn[] GetColumns()
        {
            // Define data source columns
            // See: https://aka.dataminer.services/igqidatasource-getcolumns
            return Array.Empty<GQIColumn>();
        }

        public GQIPage GetNextPage(GetNextPageInputArgs args)
        {
            // Define data source rows
            // See: https://aka.dataminer.services/igqidatasource-getnextpage
            return new GQIPage(Array.Empty<GQIRow>())
            {
                HasNextPage = false,
            };
        }
    }
}
