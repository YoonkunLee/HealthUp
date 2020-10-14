using System;
using System.Collections.Generic;
using System.Text;
using HealthUp.ViewModel;
using HealthUp.DataModel;

namespace HealthUp.ServiceLayer
{
    public class ProductService
    {
        public Product ConvertViewToData(ProductViewModel productView)
        {
            Product productData = new Product();
            productData.id = Guid.NewGuid();
            productData.name = productView.name;
            productData.description = productView.description;
            productData.benefits = productView.benefits;
            productData.size = productView.size;

            return productData;
        }

    }
}
