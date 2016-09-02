using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories.Category;
using AutoMapper;

namespace Advertise.ServiceLayer.EFServices.Categories
{
    /// <summary>
    /// </summary>
    public class CategoryService : ICategoryService
    {
        #region Ctor

        public CategoryService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _category = unitOfWork.Set<Category>();
        }

        #endregion

        #region Create

        public async void Add(CategoryCreateViewModel viewModel)
        {
            var category = _mapper.Map<Category>(viewModel);
            _category.Add(category);
            

        }

        #endregion

        #region Update

        public Task EditAsync(CategoryEditViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<Category> _category;

        #endregion

        #region Read

        public Task<int> GetCount()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetLastToDay()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryListViewModel> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveHard(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}