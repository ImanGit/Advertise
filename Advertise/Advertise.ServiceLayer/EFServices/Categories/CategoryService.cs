using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories.Category;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryService : ICategoryService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Category> _category;

        #endregion

        #region Ctor

        public CategoryService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _category = unitOfWork.Set<Category>();
        }

        #endregion

        #region Create

        public async Task CreateAsync(CategoryCreateViewModel viewModel)
        {
            var category = _mapper.Map<Category>(viewModel);
            _category.Add(category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        #endregion

        #region Update

        public async Task EditAsync(CategoryEditViewModel viewModel)
        {
            var category = await _category.FirstAsync(a => a.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveChangesAsync();
            //await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        #endregion

        #region Read

        public async Task<IEnumerable<CategoryListViewModel>> GetListAsync()
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<CategoryEditViewModel> GetForEditAsync(Guid id)
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<CategoryListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task DeleteAsync(Guid id)
        {
            return _category.Where(a => a.Id == id).DeleteAsync();
        }

        #endregion
    }
}