
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using CyberTool.Models.PublicationBibs;

namespace CyberTool
{
    public partial class PublicationBibsService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public PublicationBibsService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/PublicationBibs/");
        }

        public async System.Threading.Tasks.Task ExportPublicationBibsPublicationsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/publicationbibs/publicationbibspublications/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/publicationbibs/publicationbibspublications/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportPublicationBibsPublicationsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/publicationbibs/publicationbibspublications/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/publicationbibs/publicationbibspublications/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetPublicationBibsPublications(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.PublicationBibs.PublicationBibsPublication>> GetPublicationBibsPublications(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"PublicationBibsPublications");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPublicationBibsPublications(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.PublicationBibs.PublicationBibsPublication>>();
        }
        partial void OnCreatePublicationBibsPublication(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.PublicationBibs.PublicationBibsPublication> CreatePublicationBibsPublication(Models.PublicationBibs.PublicationBibsPublication publicationBibsPublication = default(Models.PublicationBibs.PublicationBibsPublication))
        {
            var uri = new Uri(baseUri, $"PublicationBibsPublications");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(publicationBibsPublication), Encoding.UTF8, "application/json");

            OnCreatePublicationBibsPublication(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.PublicationBibs.PublicationBibsPublication>();
        }
        partial void OnDeletePublicationBibsPublication(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeletePublicationBibsPublication(int? id = default(int?))
        {
            var uri = new Uri(baseUri, $"PublicationBibsPublications({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeletePublicationBibsPublication(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetPublicationBibsPublicationByid(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.PublicationBibs.PublicationBibsPublication> GetPublicationBibsPublicationByid(int? id = default(int?))
        {
            var uri = new Uri(baseUri, $"PublicationBibsPublications({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPublicationBibsPublicationByid(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.PublicationBibs.PublicationBibsPublication>();
        }
        partial void OnUpdatePublicationBibsPublication(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdatePublicationBibsPublication(int? id = default(int?), Models.PublicationBibs.PublicationBibsPublication publicationBibsPublication = default(Models.PublicationBibs.PublicationBibsPublication))
        {
            var uri = new Uri(baseUri, $"PublicationBibsPublications({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(publicationBibsPublication), Encoding.UTF8, "application/json");

            OnUpdatePublicationBibsPublication(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}
