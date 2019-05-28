
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using GYSWP.Categorys;

namespace  GYSWP.Categorys.Dtos
{
    public class CategoryEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
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