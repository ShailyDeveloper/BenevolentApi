using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BenProductsApi.Data;
using BenProductsApi.Dto;
using BenProductsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BenProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProducts _prod;
        private readonly IMapper _mapper;

        public ProductController(IProducts prod, IMapper mapper)
        {
            _prod = prod;
            _mapper = mapper;
        }

        // Get api/controller
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> GetProducts()
        {
            var ProdItems = _prod.GetProducts();
            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(ProdItems));

        }

        // Get api/controller/{id}
        [HttpGet("{ID}", Name = "GetProductbyID")]
        public ActionResult<IEnumerable<ProductReadDto>> GetProductbyID(int ID)
        {
            var ProddatabyID = _prod.GetProductbyID(ID);

            if (ProddatabyID != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(ProddatabyID));
                

            }
            return NotFound();
        }

        //POST api/controller
        [HttpPost]
        public ActionResult<ProductReadDto> CreateProduct(ProductCreateDto ProdCreateDto)
        {
            var ProductModel = _mapper.Map<Products>(ProdCreateDto);
            _prod.CreateProduct(ProductModel);
            _prod.SaveChanges();
            return NoContent();

        }

        //PUT api/controller/{id}
        [HttpPut("{ID}")]
        public ActionResult UpdateProduct(int ID, ProductUpdateDto prodUpdate)
        {
            var ProdDatafromRepo = _prod.GetProductbyID(ID);
            if (ProdDatafromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(prodUpdate, ProdDatafromRepo);
            _prod.UpdateProduct(ProdDatafromRepo);
            _prod.SaveChanges();
            return NoContent(); 

        }

        //DELETE api/controller/{id}
        [HttpDelete("{ID}")]
        public ActionResult DeleteVehicleType(int ID)
        {
            var ProdDatafromRepo = _prod.GetProductbyID(ID);
            if (ProdDatafromRepo == null)
            {
                return NotFound();
            }

            _prod.DeleteProduct(ProdDatafromRepo);
            _prod.SaveChanges();

            return NoContent();

        }
    }

    
}