﻿using Machine.Specifications;
using ShopifySharp.Tests.Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.Product
{
    [Subject(typeof(ShopifyProductService))]
    public class When_updating_a_product
    {
        Establish context = () =>
        {
            Service = new ShopifyProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            Product = Service.CreateAsync(ProductCreation.CreateValidProducts(), new ShopifyProductCreateOptions() { Published = false }).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Product.Title = "Changed";
            Product = Service.UpdateAsync(Product).Await().AsTask.Result;
        };

        It should_update_a_product = () => Product.Title.ShouldEqual("Changed");

        Cleanup after = () =>
        {
            if (Product != null)
            {
                Service.DeleteAsync(Product.Id.Value).Await();
            }
        };

        static ShopifyProductService Service;

        static ShopifyProduct Product;
    }
}
