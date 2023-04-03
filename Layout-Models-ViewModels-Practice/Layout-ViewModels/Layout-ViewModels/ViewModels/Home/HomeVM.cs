using Layout_ViewModels.Models;
using Layout_ViewModels.ViewModels.Product;

namespace Layout_ViewModels.ViewModels.Home
{

    //VM-View Model -mueyyen Viewa iki ve daha cox modeli birlsedirib gondermey ucun
    //ve bir modelin bir nece propertisini gondermek ucun viewa -hamsin yox, lazim olanda
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public ProductVM Product { get; set; }
    }
}
