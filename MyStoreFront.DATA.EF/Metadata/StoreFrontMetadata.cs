using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreFront.DATA.EF//.Metadata ... we need the original namespace for sharing of partial views
{
    class StoreFrontMetadata
    {
        #region Category
        [MetadataType(typeof(CategoryMetaData))]
        public partial class Category { }

        public class CategoryMetaData
        {
            // Don't need CategoryID
            [Required(ErrorMessage = "* Category Name is required.")]
            [Display(Name = "Category Name")]
            [StringLength(35, ErrorMessage = "* Cannot exceed 35 characters.")]
            public string CategoryName { get; set; }
            
        }
        #endregion

        #region Product
        [MetadataType(typeof(ProductMetaData))]
        public partial class Product { }

        public class ProductMetaData
        {
            // Again, we dont need ProductID

            [Required(ErrorMessage = "* Product Name is required.")]
            [Display(Name = "Product Name")]
            [StringLength(35, ErrorMessage = "* You may not exceed 35 characters.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "* A Description is required.")]
            [Display(Name = "Product Description")]
            [UIHint("MultilineText")]
            [StringLength(300, ErrorMessage = "* Cannot be more than 300 characters.")]
            public string Description { get; set; }

            [Required(ErrorMessage = "* Category ID is required.")]
            [Display(Name = "Category")]
            public int CategoryID { get; set; }
        }
        #endregion

        #region ProductStatus
        [MetadataType(typeof(ProductStatusMetaData))]
        public partial class ProductStatus { }

        public class ProductStatusMetaData
        {
            // No ProductStatusID...

            [Display(Name = "Is Product Out of Stock?")]
            public bool OutOfStock { get; set; }

            [Display(Name = "Is Product Featured?")]
            public bool IsFeatured { get; set; }
        }
        #endregion
    }
}
