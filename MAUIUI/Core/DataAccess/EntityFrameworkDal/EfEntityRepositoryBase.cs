using System;
using System.Linq.Expressions;
using MAUIUI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace MAUIUI.Core.DataAccess.EntityFrameworkDal
{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).SingleOrDefault();

            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        List<TEntity> ReadExcels(string filePath, string worksheetName, Dictionary<string, Func<string, object>> columnMappings)

        {

            List<TEntity> records = new List<TEntity>();

            
                FileInfo fileInfo = new FileInfo(filePath);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[worksheetName];

                    if (worksheet == null)
                    {
                        throw new Exception($"Worksheet '{worksheetName}' not found.");
                    }

                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Start from row 2 assuming the first row is header
                    {
                        TEntity record = new TEntity();

                        foreach (var mapping in columnMappings)
                        {
                            int columnIndex = GetColumnIndex(worksheet, mapping.Key);

                            if (columnIndex == -1)
                            {
                                throw new Exception($"Column '{mapping.Key}' not found in the worksheet.'{worksheetName}'");
                            }

                            string cellValue = worksheet.Cells[row, columnIndex].Value?.ToString();
                            object parsedValue = cellValue == null ? null : mapping.Value(cellValue);

                            typeof(TEntity).GetProperty(mapping.Key)?.SetValue(record, parsedValue);
                        }

                        records.Add(record);
                    }
                }

            return records;
        }
        
            int GetColumnIndex(ExcelWorksheet worksheet, string columnName)
            {
                int columnCount = worksheet.Dimension.End.Column;
                for (int col = 1; col <= columnCount; col++)
                {
                    string headerValue = worksheet.Cells[1, col].Value?.ToString();
                    if (headerValue == columnName)
                    {
                        return col;
                    }
                }
                return -1;
            }
        
        public void importRecords(string dataFile, string tableName)
        {
            TEntity entity = new();
            foreach (var item in ReadExcels(dataFile, tableName, entity.Mapping()))
            {
                this.Add(item);
            }
        }

    }

}

