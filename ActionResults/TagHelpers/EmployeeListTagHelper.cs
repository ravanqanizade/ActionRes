using ActionResults.entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionResults.TagHelpers
{

    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        public List<Employee> employee;

        public EmployeeListTagHelper()
        {
            employee = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Firstname = "Ravan",
                    Lastname = "Qanizade",
                    CityId = 1,
                },
                new Employee()
                {
                    Id = 2,
                    Firstname = "Bayram",
                    Lastname = "Qurbanov",
                    CityId = 2,
                },
                new Employee()
                {
                    Id = 3,
                    Firstname = "Tofiq",
                    Lastname = "Cavadli",
                    CityId = 3,
                },
            };
        }
        
            private const string ListCountAttribute = "count";

        public int ListCount { get; set; }
        [HtmlAttributeName(ListCountAttribute)]
        public List<Employee> Employee { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = employee.Take(ListCount);
            StringBuilder sb = new();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href ='employee/detail/{0}'>{1}</a></h2>", item.Id , item.Firstname);
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }

}
