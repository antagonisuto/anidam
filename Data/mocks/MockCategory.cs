using System;
using System.Collections.Generic;
using anidam.Data.interfaces;
using anidam.Data.Models;

namespace anidam.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Electro Cars", desc = "Modern car view"  },
                    new Category { categoryName = "Classical Cars", desc = "Cars with inner engine"}
                };
            }
        }
    }
}
