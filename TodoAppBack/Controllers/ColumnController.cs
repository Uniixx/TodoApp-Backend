using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppBack.DAL.Models;
using TodoAppBack.DAL.Repositories;

namespace TodoAppBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColumnController : ControllerBase
    {
        private IColumnRepository _columns;

        public ColumnController(IColumnRepository columnRepository)
        {
            _columns = columnRepository;
        }

        [HttpGet]
        public IActionResult GetColumns()
        {
            List<Column> columns = _columns.GetColumns();
            return Ok(columns);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            Column col = _columns.GetColumn(Id);

            if (col == null)
            {
                return NotFound();
            }

            return Ok(col);
        }

        [HttpPost]
        public IActionResult Post(Column column)
        {
            Column col = _columns.Create(column);

            return Ok(col);
        }
    }
}
