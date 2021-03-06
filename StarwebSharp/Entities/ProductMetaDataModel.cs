using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductMetaDataModel
    {
        /// <summary>The ID of the meta data.</summary>
        [JsonProperty("metaDataId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int MetaDataId { get; set; }

        /// <summary>
        ///     The ID of the meta data type. Available meta data types can be fetched using the /product-meta-data-types
        ///     endpoint
        /// </summary>
        [JsonProperty("metaDataTypeId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? MetaDataTypeId { get; set; }

        /// <summary>The sort index of this meta data for this product</summary>
        [JsonProperty("sortIndex",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? SortIndex { get; set; }

        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ProductMetaLanguageDataModelCollection Languages { get; set; }
    }
}