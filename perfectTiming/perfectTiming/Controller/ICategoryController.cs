using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    interface ICategoryController
    {
        List<Category> Categories { get; }

        RequestResult<Category> Add(Category  item);
        RequestResult<Category> Update(Category item);
        RequestResult<Category> Remove(Category item);
        RequestResult<bool> Save();
        bool IsValidName(Category item);

    }
}
