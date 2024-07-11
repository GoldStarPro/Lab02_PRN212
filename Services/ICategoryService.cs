using System;
using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
