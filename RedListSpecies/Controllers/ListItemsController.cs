namespace RedListSpecies.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using RedListSpecies.Models;
    using RedListSpecies.RedListApi;
    using RedListSpecies.RedListApi.Contracts;
    using RedListSpecies.RedListApi.ResponseModels;

    public abstract class ListItemsController<ClientType, ResponseType, ModelType, ViewModelType> : Controller
        where ClientType : ListClientBase<ResponseType, ModelType>
        where ModelType : IDataModel
        where ResponseType : ListResponseBase<ModelType>
        where ViewModelType : ListViewModel<ModelType>
    {
        IMapper mapper;
        ClientType client;

        public ListItemsController(IMapper mapper, ClientType client)
        {
            mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            client = client ?? throw new ArgumentException(nameof(client));

            this.mapper = mapper;
            this.client = client;
        }

        public async Task<IActionResult> Index()
        {
            var result = await client.List();
            return View(mapper.Map<RegionViewModel>(result));
        }
    }
}