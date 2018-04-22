﻿namespace RedListSpecies.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using RedListSpecies.Models;
    using RedListSpecies.RedListApi;

    public class RegionController : Controller
    {
        IMapper mapper;
        RegionsClient client;

        public RegionController(IMapper mapper, RegionsClient client)
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