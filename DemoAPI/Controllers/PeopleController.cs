﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
  /// <summary>
  /// This is where I give you all the information about my peeps.
  /// </summary>
  public class PeopleController : ApiController
  {
    List<Person> people = new List<Person>();

    public PeopleController()
    {
      people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
      people.Add(new Person { FirstName = "Sue", LastName = "Storm", Id = 2 });
      people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 3 });
    }

    /// <summary>
    /// Gets a list of the first names of all users.
    /// </summary>
    /// <param name="userId">The id for this person.</param>
    /// <param name="age">We want to know how old they are.</param>
    /// <returns>A list of first names.</returns>
    [Route("api/People/GetFirstNamesParams/{userId:int}/{age:int}")]
    [HttpGet]
    public List<string> GetFirstNamesParams(int userId, int age)
    {
      List<string> output = new List<string>();

      foreach (Person person in people)
      {
        output.Add(person.FirstName);
      }

      return output;
    }


    [Route("api/People/GetFirstNames")]
    [HttpGet]
    public List<string> GetFirstNames()
    {
      List<string> output = new List<string>();

      foreach ( Person person in people )
      {
        output.Add(person.FirstName);
      }

      return output;
    }

    // GET: api/People
    public List<Person> Get()
    {
      return people;
    }

    // GET: api/People/5
    public Person Get(int id)
    {
      return people.Where( x => x.Id == id ).FirstOrDefault();
    }

    // POST: api/People
    public void Post(Person val)
    {
      // doesn't actually work since the controller instantiates every time and resets our list
      // example json to pass in:
      // {
      //    Id: 4,
      //    FirstName: 'Mary'
      //    LastName: 'Smith'
      // }
    people.Add(val);
    }

    // DELETE: api/People/5
    public void Delete(int id)
    {
      // doesn't actually work since the controller instantiates every time and resets our list
      var item = people.SingleOrDefault( x => x.Id == id );
      if ( item != null )
      {
        people.Remove( item );
      }
    }
  }
}
