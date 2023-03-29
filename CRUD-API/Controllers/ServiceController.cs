﻿//using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API
{
    [ApiController]
    [Route("api/services")]
    public class ServiceController: ControllerBase
    {
        private ServiceService serviceService { get; set; }

        public ServiceController(ServiceService serviceService)
        {
            this.serviceService = serviceService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Service>> GetAll()
        {
            var result = serviceService.GetAll();
            
            return Ok(result);
        }

        [HttpGet("/get/{serviceId}")]
        public ActionResult<Service> GetById(int serviceId)
        {
            var result = serviceService.GetById(serviceId);

            if (result == null)
            {
                return BadRequest("Service not found");
            }

            return Ok(result);
        }
    }
}