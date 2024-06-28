using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using System.Net.Http.Headers;

namespace FoodDeliveryService.Components.Pages
{
    public partial class Home: ComponentBase
    {
        [Inject] ILocalStorageService LocalStorage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //Имитация задержки загрузки страницы
            //await Task.Delay(5000);
            
            await base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await LocalStorage.SetItemAsStringAsync("message", "Hello World!");

                StateHasChanged();
            }
        }
    }
}