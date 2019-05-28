
using Abp.Runtime.Validation;
using GYSWP.Dtos;
using GYSWP.Clauses;

namespace GYSWP.Clauses.Dtos
{
    public class GetClausesInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
