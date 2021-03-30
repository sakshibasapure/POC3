using System;
using System.Linq.Expressions;
using Core.Entities;
using Core.Specification;

namespace Core.Specifications
{
    public class ProductCategoriesSpecification : BaseSpecification<Product>
    {

        public ProductCategoriesSpecification()
        {
            // shows the type of category details in product list
            AddInclude(x => x.Category);
        }

        //this constructor will take criteria parameters 
        public ProductCategoriesSpecification(int id) 
            : base(x => x.Id == id)
        {
            AddInclude(x => x.Category);
        }
    }
        
}
