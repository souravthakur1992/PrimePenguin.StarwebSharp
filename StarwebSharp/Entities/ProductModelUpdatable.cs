using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarwebSharp.Entities
{
    public class ProductModelUpdatable
    {
        [JsonProperty("productId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>A timestamp of when the product was created. The time should be formatted using ISO-8601</summary>
        [JsonProperty("createdAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     The default vat rate for this product. Will fall back to shop default if null. To fetch country specific vat
        ///     rates, please use include=vatRates or use the /products/x/vat-rates endpoint.
        /// </summary>
        [JsonProperty("defaultVatRate",
            NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultVatRate { get; set; }

        /// <summary>The visibility of this product. Supported values are: hidden, visible, pricelists</summary>
        [JsonProperty("visibility",
            NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; } = "hidden";

        /// <summary>A valid URL to a web page with more information for this product</summary>
        [JsonProperty("moreInfoUrl",
            NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(255)]
        public string MoreInfoUrl { get; set; }

        /// <summary>
        ///     The id of the manufacturer to use for this product. Fetch and handle available manufacturers using the
        ///     /product-manufacturers endpoint
        /// </summary>
        [JsonProperty("manufacturerId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? ManufacturerId { get; set; }

        /// <summary>
        ///     The id of the unit to use for this product if not standard. Fetch and handle available units using the
        ///     /product-units endpoint
        /// </summary>
        [JsonProperty("unitId",
            NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitId { get; set; }

        /// <summary>Sort index for this product in a list</summary>
        [JsonProperty("sortIndex",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(1, 10000)]
        public int? SortIndex { get; set; }

        /// <summary>Should this product be watchable for customers when it is back in stock?</summary>
        [JsonProperty("isBackInStockWatchable",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool IsBackInStockWatchable { get; set; } = true;

        /// <summary>Account number for managing accounting on product level</summary>
        [JsonProperty("accounting",
            NullValueHandling = NullValueHandling.Ignore)]
        [Range(100, 9999)]
        public int? Accounting { get; set; }

        /// <summary>
        ///     Indicates if the products has several variants or not. The remaining variants can be fetched using the
        ///     /products/{product id}/variants endpoint
        /// </summary>
        [JsonProperty("hasSeveralVariants",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool HasSeveralVariants { get; set; }

        /// <summary>A timestamp of when the product was modified. The time should be formatted using ISO-8601</summary>
        [JsonProperty("modifiedAt",
            NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>A collection of variants</summary>
        [JsonProperty("variants",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVariantModel> Variants { get; set; } =
            new Collection<ProductVariantModel>();

        /// <summary>A collection of media files</summary>
        [JsonProperty("mediaFiles",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductMediaFileLinkModel> MediaFiles { get; set; } =
            new Collection<ProductMediaFileLinkModel>();

        /// <summary>A collection of product languages</summary>
        [JsonProperty("languages",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductLanguageModel> Languages { get; set; } =
            new Collection<ProductLanguageModel>();

        /// <summary>A collection of country specific vat rates</summary>
        [JsonProperty("vatRates",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductVatRateModel> VatRates { get; set; } =
            new Collection<ProductVatRateModel>();

        /// <summary>A collection of categories</summary>
        [JsonProperty("categories",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductCategoryLinkModel> Categories { get; set; } =
            new Collection<ProductCategoryLinkModel>();

        /// <summary>A collection of meta data</summary>
        [JsonProperty("metaData",
            NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProductMetaDataModelUpdatable> MetaData { get; set; } =
            new Collection<ProductMetaDataModelUpdatable>();
    }
}