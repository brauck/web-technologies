﻿using Kalevich.Domain.Models;
using Kalevich.Domain.Entities;

namespace Kalevich.UI.Services.CategoryService
{
    public interface ICategoryService
    {
        /// <summary> 
        /// Получение списка всех категорий 
        /// </summary> 
        /// <returns></returns> 
        public Task<ResponseData<List<Category>>> GetCategoryListAsync();
    }
}
