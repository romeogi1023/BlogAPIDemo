using System;
using System.Collections.Generic;
using System.Text;

namespace BlogAPIDemo.Services.Interfaces
{
    public interface IBaseService<TEntity,TDto>
    {
        List<TDto> GetList();
        TDto FindById(int id);

        bool Create(TDto tDto);

        bool Delete(int id);

        bool Update(TDto entity);
    }
}
