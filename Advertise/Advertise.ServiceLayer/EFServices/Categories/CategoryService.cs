using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryService : ICategoryService
    {
        #region Ctor

        /// <summary>
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="unitOfWork"></param>
        public CategoryService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _category = unitOfWork.Set<Category>();
        }

        #endregion

        #region Create

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        public async Task CreateAsync(CategoryCreateViewModel viewModel)
        {
            var category = _mapper.Map<Category>(viewModel);
            _category.Add(category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        #endregion

        #region Update

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public async Task EditAsync(CategoryEditViewModel viewModel)
        {
            var category = await _category.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        #endregion

        #region Delete

        /// <summary>
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public Task DeleteAsync(CategoryDeleteViewModel viewModel)
        {
            return _category.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        #endregion

        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Category> _category;

        #endregion

        #region Read

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<CategoryCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CategoryCreateViewModel {Description = "List Box"});
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryEditViewModel> GetForEditAsync(Guid id)
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryDeleteViewModel> GetForDeleteAsync(Guid id)
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryDeleteViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoryListViewModel>> GetListAsync()
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryDetailsViewModel> GetDetailsAsync(Guid id)
        {
            return await _category
                .AsNoTracking()
                .ProjectTo<CategoryDetailsViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        } 

        public async Task<CategoryListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task FillCreateViewModel(CategoryCreateViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}