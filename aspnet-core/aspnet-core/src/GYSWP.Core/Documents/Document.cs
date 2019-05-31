﻿using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYSWP.Documents
{
    [Table("Documents")]
    public class Document : FullAuditedEntity<Guid> //注意修改主键Id数据类型
    {
        /// <summary>
        /// 标准名称
        /// </summary>
        [StringLength(200)]
        [Required]
        public virtual string Name { get; set; }
        /// <summary>
        /// 标准编号
        /// </summary>
        [StringLength(100)]
        [Required]
        public virtual string DocNo { get; set; }
        /// <summary>
        /// 标准分类Id
        /// </summary>
        [Required]
        public virtual int CategoryId { get; set; }

        /// <summary>
        /// DeptIds
        /// </summary>
        public virtual string DeptIds { get; set; }
        /// <summary>
        /// 分类名描述（分类名层级以逗号分隔）
        /// </summary>
        [StringLength(500)]
        public virtual string CategoryDesc { get; set; }
        /// <summary>
        /// 岗位缩略图
        /// </summary>
        [StringLength(50)]
        public virtual string DocThum { get; set; }
        /// <summary>
        /// 摘要说明
        /// </summary>
        [StringLength(2000)]
        public virtual string Summary { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public virtual DateTime? PublishTime { get; set; }
        /// <summary>
        /// 二维码URL
        /// </summary>
        [StringLength(200)]
        public virtual string QrCodeUrl { get; set; }
        /// <summary>
        /// 授权员工名称（以逗号分隔）
        /// </summary>
        public virtual string EmployeeDes { get; set; }

        /// <summary>
        /// 是否是全部用户
        /// </summary>
        public virtual bool IsAllUser { get; set; }
        /// <summary>
        /// 员工授权Ids（以逗号分隔）
        /// </summary>
        public virtual string EmployeeIds { get; set; }
    }
}
