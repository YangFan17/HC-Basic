
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using GYSWP.Documents;

namespace  GYSWP.Documents.Dtos
{
    public class DocumentEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public Guid? Id { get; set; }         


        
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
		/// ReleaseDate
		/// </summary>
		public DateTime? ReleaseDate { get; set; }



		/// <summary>
		/// QrCodeUrl
		/// </summary>
		public string QrCodeUrl { get; set; }




    }
}