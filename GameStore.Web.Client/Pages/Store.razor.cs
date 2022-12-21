using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using GameStore.Web.Client;
using GameStore.Web.Client.Shared;
using GameStore.Web.Shared.Models.SummaryModels;

namespace GameStore.Web.Client.Pages
{
    public partial class Store
    {
        private IList<StoreSummaryModel> storeSummaryModel = Array.Empty<StoreSummaryModel>();
		protected override async Task OnInitializedAsync()
        {
            storeSummaryModel = await GetStoreSummary();
        }

        public async Task<IList<StoreSummaryModel>> GetStoreSummary()
        {
            return await http.GetFromJsonAsync<IList<StoreSummaryModel>>("/api/GameStore/list");
        }

        public async Task<string> ViewCurrentStore(Guid id)
        {
            var response = await http.GetFromJsonAsync<StoreSummaryModel>($"/api/GameStore/{id}");
            UriHelper.NavigateTo($"/store/{id}");
            return response.Name;
        }
    }
}