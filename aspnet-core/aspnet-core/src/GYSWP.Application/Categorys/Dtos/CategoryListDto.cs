

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using GYSWP.Categorys;

namespace GYSWP.Categorys.Dtos
{
    public class CategoryListDto : FullAuditedEntityDto 
    {

        
		/// <summary>
		/// Name
		/// </summary>
		[Required(ErrorMessage="Name不能为空")]
		public string Name { get; set; }



		/// <summary>
		/// ParentId
		/// </summary>
		public int? ParentId { get; set; }



		/// <summary>
		/// Desc
		/// </summary>
		public string Desc { get; set; }




    }
}