using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Advertise.DataLayer.Context;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.ServiceLayer.Contracts.Categories;
using Advertise.ViewModel.Models.Categories;
using Advertise.ViewModel.Models.Categories.CategoryReview;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityFramework.Extensions;

namespace Advertise.ServiceLayer.EFServices.Categories
{
    public class CategoryReviewService : ICategoryReviewService

    {
        private readonly  IMapper _mapper;
        private readonly  IUnitOfWork  _unitOfWork;
        private readonly IDbSet<CategoryReview> _categoryReviews; 

        #region Ctor

        public CategoryReviewService(IMapper mapper  ,IUnitOfWork  unitOfWork )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _categoryReviews = unitOfWork.Set<CategoryReview>();

        }
        #endregion
        public async  Task  CreateAsync(CategoryReviewCreateViewModel viewModel  )
        {
            var categoryReview = _mapper.Map<CategoryReview>(viewModel);
            _categoryReviews.Add(categoryReview);
            await _unitOfWork .SaveAllChangesAsync(auditUserId : new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }

        public async Task<CategoryReviewCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CategoryReviewCreateViewModel());
        }
        public async Task  EditAsync(CategoryReviewEditViewModel viewModel )
        {
            var categoryReview = await _categoryReviews.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, categoryReview);
        }

        public async Task<CategoryReviewEditViewModel> GetForEditAsync(Guid id)
        {
            return await _categoryReviews
                .AsNoTracking()
                .ProjectTo<CategoryReviewEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<CategoryReviewListViewModel>> GetListAsync()
        {
            return await _categoryReviews 
               .AsNoTracking()
               .ProjectTo<CategoryReviewListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }

        public async Task<CategoryReviewDetailsViewModel> GetDetailsAsync(Guid id)
        {
            return await _categoryReviews
                .AsNoTracking()
                .ProjectTo<CategoryReviewDetailsViewModel>(parameters: null,
                    configuration: _mapper.ConfigurationProvider)
                .FirstAsync(model => model.Id == id);
        }






        public bool EditForIsShowOrNotShow()
        {
            throw new NotImplementedException();
        }

        public  Task  DeleteAsync(CategoryEditViewModel viewModel)
        {
            return _categoryReviews.Where(model => model.Id == viewModel.Id).DeleteAsync();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public bool GetCount()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public bool Create(int Id)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

      
    }
}