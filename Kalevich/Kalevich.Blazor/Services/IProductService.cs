﻿using Kalevich.Blazor.Components.Pages;

namespace Kalevich.Blazor.Services
{
    public interface IProductService<T>
    {
        event Action ListChanged;
        
        // Список объектов 
        IEnumerable<T> Products { get; }

        // Номер текущей страницы 
        int CurrentPage { get; }

        // Общее количество страниц 
        int TotalPages { get; }

        // Получение списка объектов 
        Task GetProducts(int pageNo = 1, int pageSize = 3);
    }
}
