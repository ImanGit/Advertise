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
using Advertise.ViewModel.Models.Categories.CategoryFollow;

namespace Advertise.ServiceLayer.EFServices.Categories
{
    public class CategoryFollowService : ICategoryFollowService
    {
        #region Fields

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDbSet<CategoryFollow > _categoryFollow;

        #endregion
        #region Ctor
        public CategoryFollowService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _categoryFollow = unitOfWork.Set<CategoryFollow>();
        }
        #endregion
        #region Create
        public async Task CreateAsync(CategoryFollowCreateViewModel  viewModel)
        {
            var categoryFollow = _mapper.Map<CategoryFollow>(viewModel);
            _categoryFollow.Add(categoryFollow);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion
        #region Edit
        public async Task EditAsync(CategoryFollowEditViewModel viewModel)
        {
            var category = await _categoryFollow.FirstAsync(model => model.Id == viewModel.Id);
            _mapper.Map(viewModel, category);
            await _unitOfWork.SaveAllChangesAsync(auditUserId: new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"));
        }
        #endregion

        #region Read
        public async Task<CategoryFollowCreateViewModel> GetForCreateAsync()
        {
            return await Task.Run(() => new CategoryFollowCreateViewModel ());
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryFollowEditViewModel> GetForEditAsync(Guid id)
        {
            return await _categoryFollow 
                .AsNoTracking()
                .ProjectTo<CategoryFollowEditViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<CategoryFollowListViewModel >> GetListAsync()
        {
            return await _categoryFollow
               .AsNoTracking()
               .ProjectTo<CategoryFollowListViewModel>(parameters: null, configuration: _mapper.ConfigurationProvider)
               .ToListAsync();
        }

        #endregion
        public void Get()
        {
            throw new NotImplementedException();
        }

        //bool ICategoryFollowService.Create()
        //{
        //    throw new NotImplementedException();
        //}

        public bool EditFollowOrUnFollow()
        {
            throw new NotImplementedException();
        }

        //bool ICategoryFollowService.Delete()
        //{
        //    throw new NotImplementedException();
        //}

        public int GetCount(Guid id)
        {
            return _categoryFollow.Count(a => a.CategoryId == id && a.IsFollow == true);
        }

        public int GetUnCount()
        {
            throw new NotImplementedException();
        }

        public bool GetUserFollowCategory()
        {
            throw new NotImplementedException();
        }

        public int GetUserFollowCount()
        {
            throw new NotImplementedException();
        }

        public int GetCountFollowUserInCity()
        {
            throw new NotImplementedException();
        }

        public int GetCountUnFollowUserInCity()
        {
            throw new NotImplementedException();
        }

        public long GetMaxOrMinCategory()
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

        public bool  Delete()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }
    }
}