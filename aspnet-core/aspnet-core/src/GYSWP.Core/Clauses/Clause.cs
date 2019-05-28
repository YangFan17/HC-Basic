using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYSWP.Clauses
{
    [Table("Clauses")]
    public class Clause : FullAuditedEntity<Guid> //注意修改主键Id数据类型
    {
        /// <summary>
        /// 父Id（root 为 空）
        /// </summary>
        public virtual Guid? ParentId { get; set; }
        /// <summary>
        /// 类型（文本、表格）
        /// </summary>
        [Required]
        public virtual int Type { get; set; }
        /// <summary>
        /// 所属标准
        /// </summary>
        public virtual Guid? DocumentId { get; set; }
    }
}
