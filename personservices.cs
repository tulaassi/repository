using System;
using system.Collections.Generic;
using system.Data.Entity;
using system.Linq;
using system.Web;

public class personservice
{
	public Impperson personRepository;
	//Default Constructor
	public personservice()
	{
		personRepository = new Impperson();

	}
	//Parameterized Constructor
	public personservice(Iperson personRepository)
	{
		personRepository = personRepository;

	}
	//Inserting Data
	public string post(person a)
	{
		personRepository.post(a);
		return "Data is inserted";
	}
	//put (update)
	public string put(int Id, person per)
	{
		personRepository.put(Id, per);
		return "Updated";

	}
	//Get all the person List
	public IEnumerable<person> GetAll()
	{
		return personRepository.GetAll();

	}
	//Get the person by Id
	public person GetbyId(int Id)
	{
		return personRepository.GetbyId(Id);

	}
	//Delete
	public string delete(in Id)
	{
		personRepository.Delete(Id);
		return "Deleted";
	}
}

		
}
