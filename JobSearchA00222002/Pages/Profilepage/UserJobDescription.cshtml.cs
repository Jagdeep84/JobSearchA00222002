using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using JobSearchA00222002.Contexts;

namespace JobSearchA00222002.Pages.Profilepage
{
    public class UserJobDescriptionModel : PageModel
    {
        private readonly Context _context;

        [FromForm]
        public JobSearchA00222002.Models.UserJobDescription UserJobDescription { get; set; }

        public UserJobDescriptionModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (UserJobDescription.JobType != null)
            {
                _context.Add(UserJobDescription);
                _context.SaveChanges();
            }

        }
    }
}
