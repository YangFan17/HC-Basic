

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

using GYSWP;
using GYSWP.SelfChekRecords;


namespace GYSWP.SelfChekRecords.DomainService
{
    /// <summary>
    /// SelfChekRecord领域层的业务管理
    ///</summary>
    public class SelfChekRecordManager :GYSWPDomainServiceBase, ISelfChekRecordManager
    {
		
		private readonly IRepository<SelfChekRecord,Guid> _repository;

		/// <summary>
		/// SelfChekRecord的构造方法
		///</summary>
		public SelfChekRecordManager(
			IRepository<SelfChekRecord, Guid> repository
		)
		{
			_repository =  repository;
		}


		/// <summary>
		/// 初始化
		///</summary>
		public void InitSelfChekRecord()
		{
			throw new NotImplementedException();
		}

		// TODO:编写领域业务代码



		 
		  
		 

	}
}
