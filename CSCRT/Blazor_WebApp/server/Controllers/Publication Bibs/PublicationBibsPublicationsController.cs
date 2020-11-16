using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace CyberTool.Controllers.PublicationBibs
{
  using Models;
  using Data;
  using Models.PublicationBibs;

  [ODataRoutePrefix("odata/PublicationBibs/PublicationBibsPublications")]
  [Route("mvc/odata/PublicationBibs/PublicationBibsPublications")]
  public partial class PublicationBibsPublicationsController : ODataController
  {
    private Data.PublicationBibsContext context;

    public PublicationBibsPublicationsController(Data.PublicationBibsContext context)
    {
      this.context = context;
    }
    // GET /odata/PublicationBibs/PublicationBibsPublications
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.PublicationBibs.PublicationBibsPublication> GetPublicationBibsPublications()
    {
      var items = this.context.PublicationBibsPublications.AsQueryable<Models.PublicationBibs.PublicationBibsPublication>();
      this.OnPublicationBibsPublicationsRead(ref items);

      return items;
    }

    partial void OnPublicationBibsPublicationsRead(ref IQueryable<Models.PublicationBibs.PublicationBibsPublication> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<PublicationBibsPublication> GetPublicationBibsPublication(int key)
    {
        var items = this.context.PublicationBibsPublications.Where(i=>i.id == key);
        return SingleResult.Create(items);
    }
    partial void OnPublicationBibsPublicationDeleted(Models.PublicationBibs.PublicationBibsPublication item);
    partial void OnAfterPublicationBibsPublicationDeleted(Models.PublicationBibs.PublicationBibsPublication item);

    [HttpDelete("{id}")]
    public IActionResult DeletePublicationBibsPublication(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.PublicationBibsPublications
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnPublicationBibsPublicationDeleted(item);
            this.context.PublicationBibsPublications.Remove(item);
            this.context.SaveChanges();
            this.OnAfterPublicationBibsPublicationDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPublicationBibsPublicationUpdated(Models.PublicationBibs.PublicationBibsPublication item);
    partial void OnAfterPublicationBibsPublicationUpdated(Models.PublicationBibs.PublicationBibsPublication item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutPublicationBibsPublication(int key, [FromBody]Models.PublicationBibs.PublicationBibsPublication newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.id != key))
            {
                return BadRequest();
            }

            this.OnPublicationBibsPublicationUpdated(newItem);
            this.context.PublicationBibsPublications.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.PublicationBibsPublications.Where(i => i.id == key);
            this.OnAfterPublicationBibsPublicationUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchPublicationBibsPublication(int key, [FromBody]Delta<Models.PublicationBibs.PublicationBibsPublication> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.PublicationBibsPublications.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnPublicationBibsPublicationUpdated(item);
            this.context.PublicationBibsPublications.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.PublicationBibsPublications.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPublicationBibsPublicationCreated(Models.PublicationBibs.PublicationBibsPublication item);
    partial void OnAfterPublicationBibsPublicationCreated(Models.PublicationBibs.PublicationBibsPublication item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.PublicationBibs.PublicationBibsPublication item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnPublicationBibsPublicationCreated(item);
            this.context.PublicationBibsPublications.Add(item);
            this.context.SaveChanges();

            return Created($"odata/PublicationBibs/PublicationBibsPublications/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
