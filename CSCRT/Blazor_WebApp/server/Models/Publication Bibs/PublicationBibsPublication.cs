using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberTool.Models.PublicationBibs
{
  [Table("publications", Schema = "cyber")]
  public partial class PublicationBibsPublication
  {
    public string url
    {
      get;
      set;
    }
    [Key]
    public int id
    {
      get;
      set;
    }
    public string type
    {
      get;
      set;
    }
    public string title
    {
      get;
      set;
    }
    public string journal
    {
      get;
      set;
    }
    public string booktitle
    {
      get;
      set;
    }
    public string pages
    {
      get;
      set;
    }
    public int? month
    {
      get;
      set;
    }
    public int year
    {
      get;
      set;
    }
    public int? volume
    {
      get;
      set;
    }
    public int? number
    {
      get;
      set;
    }
    public string editor
    {
      get;
      set;
    }

    [Column("event")]
    public string event1
    {
      get;
      set;
    }
    public string institution
    {
      get;
      set;
    }
    public string note
    {
      get;
      set;
    }
    public int? day
    {
      get;
      set;
    }
  }
}
