

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using GYSWP.Employees;


namespace GYSWP.Employees.DomainService
{
    public interface IEmployeeManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitEmployee();
    }
}
