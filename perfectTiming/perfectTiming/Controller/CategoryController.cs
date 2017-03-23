using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    public class CategoryController : ICategoryController
    {

        public List<Category> Categories { get { return _categories; } set { _categories = value; } }

        private List<Category> _categories; //zoznam objektov
        private perfecttimingEntities _context; // context databazy

        /// <summary>
        /// Controller na spravu ucastnikov
        /// </summary>
        public CategoryController()
        {
            _context = new perfecttimingEntities();
            _categories = _context.Categories.ToList();
        }

        public CategoryController(List<Category> range)
        {
            _context = new perfecttimingEntities();
            _categories = range;
        }


        /// <summary>
        /// Prida kategoriu do databazy
        /// </summary>
        /// <param name="item">Objekty ktory ma byt pridany</param>
        /// <returns></returns>
        public RequestResult<Category> Add(Category item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ODstrani kategoriu z databazy
        /// </summary>
        /// <param name="item">Objekty ktory ma byt odstraneny</param>
        /// <returns></returns>
        public RequestResult<Category> Remove(Category item)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        ///Upraví kategoriu v databaze
        /// </summary>
        /// <param name="item">Objekty ktory ma byt odstraneny</param>
        /// <returns></returns>
        public RequestResult<Category> Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
