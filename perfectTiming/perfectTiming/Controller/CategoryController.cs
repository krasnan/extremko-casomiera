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

            try
            {
                if (item.name == "" || (_categories.FindIndex(o => o.name == item.name) != -1))
                    return new RequestResult<Category> { Status = Enums.RequestStatus.Error, Message = "Kategóriu sa nepodarilo pridať" };
                
                _context.Categories.Add(item);
                _categories.Add(item);

                return new RequestResult<Category> { Status = Enums.RequestStatus.Success, Message = "Kategória bola pridaná", Data = item };

            }
            catch (Exception ex)
            {

                return new RequestResult<Category> { Status = Enums.RequestStatus.Error, Message = "Kategóriu sa nepodarilo pridať", Detail = ex.Message };

            }

        }

        /// <summary>
        /// ODstrani kategoriu z databazy
        /// </summary>
        /// <param name="item">Objekty ktory ma byt odstraneny</param>
        /// <returns></returns>
        public RequestResult<Category> Remove(Category item)
        {
            try
            {
                _context.Categories.Attach(item);
                _context.Categories.Remove(item);
                _categories.Remove(item);

                return new RequestResult<Category> { Status = Enums.RequestStatus.Success, Message = "Kategória vymazaná", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Category> { Status = Enums.RequestStatus.Error, Message = "Kategória nebola vymazaná", Detail = ex.Message };
                
            }
        }
        /// <summary>
        ///Upraví kategoriu v databaze
        /// </summary>
        /// <param name="item">Objekty ktory ma byt upraveny</param>
        /// <returns></returns>
        public RequestResult<Category> Update(Category item)
        {
            try
            {
                if(item.name == "")
                    throw new Exception();

                int index = _categories.FindIndex(o => o.id == item.id);
                if (index != -1) {

                    if (_categories[index].name != item.name)
                    {
                        if (_categories.FindIndex(o => o.name == item.name) != -1)
                            return new RequestResult<Category> { Status = Enums.RequestStatus.Error, Message = "Kategória nebola upravená", Detail = ex.Message };

                    }


                    _context.Categories.Attach(item);
                    var entry = _context.Entry(item);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    _categories[index] = item;

                } else {

                    throw new Exception();
                }


                return new RequestResult<Category> { Status = Enums.RequestStatus.Success, Message = "Kategória upravená", Data = item };
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
