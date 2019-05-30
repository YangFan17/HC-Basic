

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using GYSWP.Documents;

namespace GYSWP.Documents.Dtos
{
    public class DocumentListDto : FullAuditedEntityDto<Guid> 
    {
		/// <summary>
		/// Name
		/// </summary>
		[Required(ErrorMessage="Name不能为空")]
		public string Name { get; set; }


		/// <summary>
		/// DocNo
		/// </summary>
		[Required(ErrorMessage="DocNo不能为空")]
		public string DocNo { get; set; }


        /// <summary>
        /// DeptIds
        /// </summary>
        public string DeptIds { get; set; }
        /// <summary>
        /// CategoryId
        /// </summary>
        [Required(ErrorMessage="CategoryId不能为空")]
		public int CategoryId { get; set; }


		/// <summary>
		/// CategoryDesc
		/// </summary>
		public string CategoryDesc { get; set; }


		/// <summary>
		/// DocThum
		/// </summary>
		public string DocThum { get; set; }


		/// <summary>
		/// Summary
		/// </summary>
		public string Summary { get; set; }


        /// <summary>
        /// 是否发布
        /// </summary>
        public bool IsPublish { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime? PublishTime { get; set; }


        /// <summary>
        /// QrCodeUrl
        /// </summary>
        public string QrCodeUrl { get; set; }
    }
}