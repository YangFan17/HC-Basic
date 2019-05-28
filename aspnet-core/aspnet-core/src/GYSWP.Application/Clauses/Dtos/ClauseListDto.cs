

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using GYSWP.Clauses;

namespace GYSWP.Clauses.Dtos
{
    public class ClauseListDto : FullAuditedEntityDto<Guid> 
    {

        
		/// <summary>
		/// ParentId
		/// </summary>
		public Guid? ParentId { get; set; }



		/// <summary>
		/// Type
		/// </summary>
		[Required(ErrorMessage="Type不能为空")]
		public int Type { get; set; }



		/// <summary>
		/// DocumentId
		/// </summary>
		public Guid? DocumentId { get; set; }




    }
}