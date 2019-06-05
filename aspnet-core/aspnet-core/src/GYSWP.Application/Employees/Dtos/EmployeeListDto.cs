

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using GYSWP.Employees;
using Abp.AutoMapper;
using System.Collections.Generic;

namespace GYSWP.Employees.Dtos
{
    [AutoMapFrom(typeof(Employee))]
    public class EmployeeListDto : EntityDto<string> 
    {

        
		/// <summary>
		/// OpenId
		/// </summary>
		public string OpenId { get; set; }



		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// Mobile
		/// </summary>
		public string Mobile { get; set; }



		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; }



		/// <summary>
		/// Active
		/// </summary>
		public bool? Active { get; set; }



		/// <summary>
		/// IsAdmin
		/// </summary>
		public bool? IsAdmin { get; set; }



		/// <summary>
		/// IsBoss
		/// </summary>
		public bool? IsBoss { get; set; }



		/// <summary>
		/// Department
		/// </summary>
		public string Department { get; set; }



		/// <summary>
		/// Position
		/// </summary>
		public string Position { get; set; }



		/// <summary>
		/// Avatar
		/// </summary>
		public string Avatar { get; set; }



		/// <summary>
		/// HiredDate
		/// </summary>
		public string HiredDate { get; set; }



		/// <summary>
		/// Roles
		/// </summary>
		public string Roles { get; set; }



		/// <summary>
		/// RoleId
		/// </summary>
		public long? RoleId { get; set; }



		/// <summary>
		/// Remark
		/// </summary>
		public string Remark { get; set; }

        /// <summary>
        /// Ա���ڵ�ǰ��������ҵ�˺ŷ�Χ�ڵ�Ψһ��ʶ��ϵͳ���ɣ��̶�ֵ������ı�
        /// </summary>
        public string Unionid { get; set; }
    }

    public class NzTreeNode
    {
        public virtual string title { get; set; }
        public virtual string key { get; set; }
        public virtual bool IsLeaf { get; set; }

        public virtual bool selected { get; set; }

        public virtual List<NzTreeNode> children { get; set; }
    }
    public class DocNzTreeNode : NzTreeNode
    {
        public override bool IsLeaf
        {
            get
            {
                if (children.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public new List<DocNzTreeNode> children { get; set; }
    }

    /// <summary>
    /// ɨ���¼��ȡ���û���Ϣ
    /// </summary>
    public class ScanUserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}