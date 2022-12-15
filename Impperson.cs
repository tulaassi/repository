using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace explanation.Repository

public class Impperson:Iperson
{
private readonly Entities_context;
        public Impperson()
    {
        _context = new Entities();

    }
    public Impperson(Entities context)
    {
        _context = context;

    }
    public IEnumerable<person>GetAll()
    {
        return _context.people.Find(ID);
    }
    public void post(person a)
    {
        _context.people.Add(a);
        _context.SaveChanges();
    }
    public void put(int id,Impperson per)
    {
        var person_ = _context.pepole.Find(id);
        person_.Id = per.Id;
        person_name = per.name;
        _context.Entry(person_).state = System.Data.Entity.EntityState.Modified;
    }
    public  void delete(int ID)
    {
        Impperson per = _context.pepole.Find(ID);
        _context.people.Remove(per);
        _context.SaveChanges();
    }
}
