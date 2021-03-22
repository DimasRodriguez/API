
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreCodeCamp.Data
{
  public class Camp
  {
    //[Required]
    public int CampId { get; set; }
    //[Required]
    //[StringLength(100)]
    public string Name { get; set; }
    //[Required]
    public string Moniker { get; set; }
    public Location Location  { get; set; }
    public DateTime EventDate { get; set; } = DateTime.MinValue;
    //[Range(0, 100)]
    public int Length { get; set; } = 1;
    public ICollection<Talk> Talks { get; set; }
  }
}