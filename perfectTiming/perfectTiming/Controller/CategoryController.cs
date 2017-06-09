using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Data.Entity;

namespace perfectTiming.Controller
{
    public class CategoryController : ICategoryController
    {

        public List<Category> Categories { get { return _context.Categories.ToList(); } }

        private perfecttimingEntities _context; // context databazy

        /// <summary>
        /// Controller na spravu ucastnikov
        /// </summary>
        public CategoryController(ref perfecttimingEntities context)
        {
            _context = context;
        }

        public CategoryController(List<Category> range)
        {
            _context = new perfecttimingEntities();
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
                _context.Categories.Add(item);
                _context.SaveChanges();
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
                _context.SaveChanges();
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
                _context.Categories.Attach(item);
                var entry = _context.Entry(item);
                entry.State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return new RequestResult<Category> { Status = Enums.RequestStatus.Success, Message = "Kategória upravená", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Category> { Status = Enums.RequestStatus.Error, Message = "Kategória nebola upravená", Detail = ex.Message };
            }
        }

        public RequestResult<bool> Save()
        {
            try
            { 
                _context.SaveChanges();
                return new RequestResult<bool> { Status = Enums.RequestStatus.Success, Message = "Kategória uložená", Data = true };
            }
            catch (Exception)
            {

                return new RequestResult<bool> { Status = Enums.RequestStatus.Error, Message = "Nepodarilo sa uložiť kategoriu", Data = false };
            }
        }

        public RequestResult<bool> IsValidName(Category item)
        {
            if (item.name == null)
                return new RequestResult<bool>
                {
                    Status = Enums.RequestStatus.Error,
                    Message = "Nezadali ste názov udalosti.\n"
                };
            if (item.name.Length < 1 || item.name.Length > 255)
                return new RequestResult<bool>
                {
                    Status = Enums.RequestStatus.Error,
                    Message = "Názov udalosti musí obsahovať 3 až 255 znakov.\n"
                };
            return new RequestResult<bool> { Status = Enums.RequestStatus.Success };
        }
    }
}
