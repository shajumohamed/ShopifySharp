﻿using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyLineItem : ShopifyObject
    {
        /// <summary>
        /// The amount available to fulfill. This is the quantity - max(refunded_quantity, fulfilled_quantity) - pending_fulfilled_quantity.
        /// </summary>
        [JsonProperty("fulfillable_quantity")]
        public int FulfillableQuantity { get; set; }

        /// <summary>
        /// Service provider who is doing the fulfillment. Valid values are either "manual" or the name of the provider. eg: "amazon", "shipwire", etc.
        /// </summary>
        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

        /// <summary>
        /// The fulfillment status of this line item. Will be null if the line item has not been fulfilled or partially fulfilled.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public ShopifyFulfillmentStatus? FulfillmentStatus { get; set; }

        /// <summary>
        /// The weight of the item in grams.
        /// </summary>
        [JsonProperty("grams")]
        public int Grams { get; set; }

        /// <summary>
        /// The price of the item before discounts have been applied.
        /// </summary>
        /// <remarks>Shopify returns this value as a string.</remarks>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product in the fulfillment. Can be null if the original product associated with the order is deleted at a later date
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// The number of products that were purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// States whether or not the fulfillment requires shipping.
        /// </summary>
        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        /// <summary>
        /// A unique identifier of the item in the fulfillment.
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// The title of the product.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The id of the product variant. Can be null if the product purchased is not a variant.
        /// </summary>
        [JsonProperty("variant_id")]
        public long? VariantId { get; set; }

        /// <summary>
        /// The title of the product variant. Can be null if the product purchased is not a variant.
        /// </summary>
        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }

        /// <summary>
        /// The name of the product variant.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the supplier of the item.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// States whether the order used a gift card.
        /// </summary>
        [JsonProperty("gift_card")]
        public bool GiftCard { get; set; }

        /// <summary>
        /// States whether or not the product was taxable.
        /// </summary>
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        /// <summary>
        /// An array of <see cref="ShopifyTaxLine"/> objects, each of which details the taxes applicable to this <see cref="ShopifyLineItem"/>.
        /// </summary>
        [JsonProperty("tax_lines")]
        public IEnumerable<ShopifyTaxLine> TaxLines { get; set; }

        /// <summary>
        /// The total discount amount applied to this line item. This value is not subtracted in the line item price.
        /// </summary>
        [JsonProperty("total_discount")]
        public double TotalDiscount { get; set; }
    }
}
