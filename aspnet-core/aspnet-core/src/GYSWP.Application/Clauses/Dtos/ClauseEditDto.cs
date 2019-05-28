
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using GYSWP.Clauses;

namespace  GYSWP.Clauses.Dtos
{
    public class ClauseEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public Guid? Id { get; set; }         


        
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