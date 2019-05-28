
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using GYSWP.Clauses;
using GYSWP.Clauses.Dtos;
using GYSWP.Clauses.DomainService;



namespace GYSWP.Clauses
{
    /// <summary>
    /// Clause应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class ClauseAppService : GYSWPAppServiceBase, IClauseAppService
    {
        private readonly IRepository<Clause, Guid> _entityRepository;

        private readonly IClauseManager _entityManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public ClauseAppService(
        IRepository<Clause, Guid> entityRepository
        ,IClauseManager entityManager
        )
        {
            _entityRepository = entityRepository; 
             _entityManager=entityManager;
        }


        /// <summary>
        /// 获取Clause的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
		 
        public async Task<PagedResultDto<ClauseListDto>> GetPaged(GetClausesInput input)
		{

		    var query = _entityRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
            

			var count = await query.CountAsync();

			var entityList = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();

			// var entityListDtos = ObjectMapper.Map<List<ClauseListDto>>(entityList);
			var entityListDtos =entityList.MapTo<List<ClauseListDto>>();

			return new PagedResultDto<ClauseListDto>(count,entityListDtos);
		}


		/// <summary>
		/// 通过指定id获取ClauseListDto信息
		/// </summary>
		 
		public async Task<ClauseListDto> GetById(EntityDto<Guid> input)
		{
			var entity = await _entityRepository.GetAsync(input.Id);

		    return entity.MapTo<ClauseListDto>();
		}

		/// <summary>
		/// 获取编辑 Clause
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task<GetClauseForEditOutput> GetForEdit(NullableIdDto<Guid> input)
		{
			var output = new GetClauseForEditOutput();
ClauseEditDto editDto;

			if (input.Id.HasValue)
			{
				var entity = await _entityRepository.GetAsync(input.Id.Value);

				editDto = entity.MapTo<ClauseEditDto>();

				//clauseEditDto = ObjectMapper.Map<List<clauseEditDto>>(entity);
			}
			else
			{
				editDto = new ClauseEditDto();
			}

			output.Clause = editDto;
			return output;
		}


		/// <summary>
		/// 添加或者修改Clause的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task CreateOrUpdate(CreateOrUpdateClauseInput input)
		{

			if (input.Clause.Id.HasValue)
			{
				await Update(input.Clause);
			}
			else
			{
				await Create(input.Clause);
			}
		}


		/// <summary>
		/// 新增Clause
		/// </summary>
		
		protected virtual async Task<ClauseEditDto> Create(ClauseEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Clause>(input);
            var entity=input.MapTo<Clause>();
			

			entity = await _entityRepository.InsertAsync(entity);
			return entity.MapTo<ClauseEditDto>();
		}

		/// <summary>
		/// 编辑Clause
		/// </summary>
		
		protected virtual async Task Update(ClauseEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _entityRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
		    await _entityRepository.UpdateAsync(entity);
		}



		/// <summary>
		/// 删除Clause信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		
		public async Task Delete(EntityDto<Guid> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(input.Id);
		}



		/// <summary>
		/// 批量删除Clause的方法
		/// </summary>
		
		public async Task BatchDelete(List<Guid> input)
		{
			// TODO:批量删除前的逻辑判断，是否允许删除
			await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出Clause为excel表,等待开发。
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}

    }
}


