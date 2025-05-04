

//using Microsoft.AspNetCore.Mvc;
//using MyWeb.Data;
//using MyWeb.Models.Entities;
//using MyWeb.Tools;
//using OzoneERP.Helpers;

//namespace MyWeb.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    [Authorize]
//    public class EmployeesController : ControllerBase
//    {
//        private readonly ApplicationDBContext _context;

//        public EmployeesController(ApplicationDBContext context)
//        {
//            _context = context;
//        }

//        // GET: Employees
//        [HttpGet("GetAll")]
//        [Authorize]
//        public IActionResult GteAll()
//        {
//            var list = _context.Employees.ToList();

//            return Ok(list);
//        }

//        // GET: Employees
//        [HttpGet("{id}")]
//        public IActionResult GteEmployeeByID(int id)
//        {
//            var item = _context.Employees.Find(id);

//            if(item == null)
//            {
//                return NotFound("Employee not exist");
//            }

//            return Ok(item);
//        }

//        // Post: Employees
//        [HttpPost]
//        public IActionResult Add(EmployeeDTO employeeDTO)
//        {
//            Employee employee = employeeDTO.CopyTo<Employee>();
//            _context.Employees.Add(employee);

//            _context.SaveChanges();

//            return Ok(employeeDTO);
//        }

//        //// GET: Employees/Details/5
//        //public async Task<IActionResult> Details(Guid? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var employee = await _context.Employees
//        //        .FirstOrDefaultAsync(m => m.ID == id);
//        //    if (employee == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(employee);
//        //}

//        //// GET: Employees/Create
//        //public IActionResult Create()
//        //{
//        //    return View();
//        //}

//        //// POST: Employees/Create
//        //// To protect from overposting attacks, enable the specific properties you want to bind to.
//        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Create([Bind("ID,Name,Email,Phone,Salary")] Employee employee)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        employee.ID = Guid.NewGuid();
//        //        _context.Add(employee);
//        //        await _context.SaveChangesAsync();
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(employee);
//        //}

//        //// GET: Employees/Edit/5
//        //public async Task<IActionResult> Edit(Guid? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var employee = await _context.Employees.FindAsync(id);
//        //    if (employee == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return View(employee);
//        //}

//        //// POST: Employees/Edit/5
//        //// To protect from overposting attacks, enable the specific properties you want to bind to.
//        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Email,Phone,Salary")] Employee employee)
//        //{
//        //    if (id != employee.ID)
//        //    {
//        //        return NotFound();
//        //    }

//        //    if (ModelState.IsValid)
//        //    {
//        //        try
//        //        {
//        //            _context.Update(employee);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //        catch (DbUpdateConcurrencyException)
//        //        {
//        //            if (!EmployeeExists(employee.ID))
//        //            {
//        //                return NotFound();
//        //            }
//        //            else
//        //            {
//        //                throw;
//        //            }
//        //        }
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(employee);
//        //}

//        //// GET: Employees/Delete/5
//        //public async Task<IActionResult> Delete(Guid? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var employee = await _context.Employees
//        //        .FirstOrDefaultAsync(m => m.ID == id);
//        //    if (employee == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(employee);
//        //}

//        //// POST: Employees/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> DeleteConfirmed(Guid id)
//        //{
//        //    var employee = await _context.Employees.FindAsync(id);
//        //    if (employee != null)
//        //    {
//        //        _context.Employees.Remove(employee);
//        //    }

//        //    await _context.SaveChangesAsync();
//        //    return RedirectToAction(nameof(Index));
//        //}

//        //private bool EmployeeExists(Guid id)
//        //{
//        //    return _context.Employees.Any(e => e.ID == id);
//        //}
//    }
//}
