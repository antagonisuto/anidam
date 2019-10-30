using System;
using System.Collections.Generic;
using anidam.Data.Models;

namespace anidam.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
