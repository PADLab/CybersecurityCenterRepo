using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CyberTool.Data;

namespace CyberTool
{
    public partial class ExportPublicationBibsController : ExportController
    {
        private readonly PublicationBibsContext context;

        public ExportPublicationBibsController(PublicationBibsContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/PublicationBibs/publicationbibspublications/csv")]
        [HttpGet("/export/PublicationBibs/publicationbibspublications/csv(fileName='{fileName}')")]
        public FileStreamResult ExportPublicationBibsPublicationsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.PublicationBibsPublications, Request.Query), fileName);
        }

        [HttpGet("/export/PublicationBibs/publicationbibspublications/excel")]
        [HttpGet("/export/PublicationBibs/publicationbibspublications/excel(fileName='{fileName}')")]
        public FileStreamResult ExportPublicationBibsPublicationsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.PublicationBibsPublications, Request.Query), fileName);
        }
    }
}
