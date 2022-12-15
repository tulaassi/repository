using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace explanation.Repository

public interface Iperson
{
    IEnumerable<person> GetAll();
    Iperson GetbyId(int Id);
    void Post(Person a);
    void put(int id, Iperson a); 
    void delete(inyt id);
}
