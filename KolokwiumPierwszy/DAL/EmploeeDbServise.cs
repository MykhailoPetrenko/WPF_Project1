using KolokwiumPierwszy.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumPierwszy.DAL
{
    class EmploeeDbServise
    {
        private EmploeeDbContext _context = new EmploeeDbContext();

        public IEnumerable<EMP> GetPracowniki()
        {
            return _context.EMP.ToList();
        }

        public void AddPracownik(EMP newEmp)
        {
            _context.EMP.Add(newEmp);
            _context.SaveChanges();
        }

        public List<string> GetDname()
        {
            List<string> result = _context.DEPT.Select(dept => dept.DNAME.ToString()).ToList();
            return result;
        }

        public int GetDname(String Dname)
        {
            String result = _context.DEPT.Where(dept => dept.DNAME.Equals(Dname)).Select(dept => dept.DEPTNO.ToString()).First();
            Console.WriteLine(result);
            return Convert.ToInt32(result);
        }

        public int GetLastEmpno()
        {
            int result = _context.EMP.Max(emp => emp.EMPNO);
            result += 1;
            return result;
        }

        public IEnumerable<EMP> SzukajPoNazwisku(String Nazwisko)
        {
            var result = _context.EMP.Where(emp => emp.ENAME.Equals(Nazwisko));
            return result;
        }
        public void deleteAnimal(EMP _emploee)
        {
            _context.EMP.Remove(_emploee);
            _context.SaveChanges();
        }
    }
}
