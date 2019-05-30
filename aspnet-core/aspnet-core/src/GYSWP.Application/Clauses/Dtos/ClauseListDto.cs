

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using GYSWP.Clauses;
using System.Collections.Generic;
using Abp.AutoMapper;

namespace GYSWP.Clauses.Dtos
{
    [AutoMapFrom(typeof(Clause))]
    public class ClauseListDto: FullAuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        /// <summary>
        /// ParentId
        /// </summary>
        public Guid? ParentId { get; set; }
  

        public string Title { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        /// <summary>
        /// 父Id（root 为 空）
        /// </summary>
        [Required]
        public string ClauseNo { get; set; }
        /// <summary>
        /// 类型（文本、表格）是否含有附件
        /// </summary>
        [Required]
        public bool HasAttchment { get; set; }

        /// <summary>
        /// DocumentId
        /// </summary>
        public Guid? DocumentId { get; set; }
    }

    /// <summary>
    /// 条款树形表格
    /// </summary>
    [AutoMapFrom(typeof(Clause))]
    public class ClauseTreeNodeDto
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }

        public string ClauseNo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public int Level { get; set; } = 0;
        public List<ClauseTreeNodeDto> Children = new List<ClauseTreeNodeDto>();
    }
    [AutoMapFrom(typeof(Clause))]
    public class ClauseTreeListDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// ParentId
        /// </summary>
        public Guid? ParentId { get; set; }


        public string Title { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 父Id（root 为 空）
        /// </summary>
        public string ClauseNo { get; set; }
    }
}