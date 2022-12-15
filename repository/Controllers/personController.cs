using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static repository tulasi.repository.Impperson;


namespace repository.Controllers
{
    public class personController : ApiController
    {
        private personservice _Addservices;
        //Default Constructor
        public personController()
        {

            _Addservices = new personservice(); 

        }
        public personController(personservice addservice)
        {
            _Addservices = addservice;
        }
        //inserting data
        public string post(person a)
        {
            _Addservices.Post(a);
            return "data is inserted";
        }
        //get the person list
        public IEnumerable<person> GetAll()
        {
            return _Addservices.GetAll();
        }
        //get the person by id
        public personController GetbyID(int id)
        {
            return _Addservices.GetbyID(id);
        }
        //PUT UPDATE
        public string put(int id,Person per)
        {
            _Addservices.put(id, per);
            return "updated";
        }
        //delete
        public string Delete(int id)
        {
            _Addservices.Delete(id);
            return "deleted";
        }
    }
}