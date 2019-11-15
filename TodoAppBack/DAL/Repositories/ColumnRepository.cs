using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppBack.DAL.Models;

namespace TodoAppBack.DAL.Repositories
{
    public interface IColumnRepository
    {
        List<Column> GetColumns();
        Column GetColumn(string Id);
        Column Create(Column column);
    }
    public class ColumnRepository : IColumnRepository
    {
        private TodoContext _db;

        public ColumnRepository(TodoContext database)
        {
            _db = database;
        } 

        public List<Column> GetColumns()
        {
            return _db.Columns
                .Include(c => c.Projects)
                .ToList();
        }

        public Column GetColumn(string Id)
        {
            List<Column> columns = GetColumns();

            return columns.FirstOrDefault(c => c.Id == Id);
        }

        public Column Create(Column column)
        {
            _db.Columns.Add(column);
            _db.SaveChanges();

            return column;
        }
    }
}
