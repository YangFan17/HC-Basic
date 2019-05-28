
using Abp.Runtime.Validation;
using GYSWP.Dtos;
using GYSWP.Documents;

namespace GYSWP.Documents.Dtos
{
    public class GetDocumentsInput : PagedSortedAndFilteredInputDto, IShouldNormalize
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
