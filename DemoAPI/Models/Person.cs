﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
  /// <summary>
  /// Represents one specific person.
  /// </summary>
  public class Person
  {
    /// <summary>
    /// The Id from sql.
    /// </summary>
    public int Id { get; set; } = 0;

    /// <summary>
    /// The user's first name.
    /// </summary>
    public string FirstName { get; set; } = "";

    /// <summary>
    /// The user's last name.
    /// </summary>
    public string LastName { get; set; } = "";

  }
}