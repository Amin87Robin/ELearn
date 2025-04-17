using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.DataLayer.DTOS.CourseGroupViewModels
{
    public class CreateCourseGroupViewModel
    {
        [Required(ErrorMessage ="مقدار نام گروه نمیتواند خالی باشد")]
        [DisplayName("نام گروه ")]
        [MaxLength(15, ErrorMessage ="مقدار کارکتر ها باید نهایتا پانزده تا باشد")]
        public string CourseGroupName { get; set; }
    }
}
