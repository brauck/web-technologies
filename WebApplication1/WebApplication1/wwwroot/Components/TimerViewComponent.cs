using System;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.wwwroot.Components
{
    public class TimerViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return $"Текущее время: {DateTime.Now.ToString("hh:mm:ss")}";
        }
    }
}
