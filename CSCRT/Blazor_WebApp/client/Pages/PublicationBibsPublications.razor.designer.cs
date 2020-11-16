using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CyberTool.Models.PublicationBibs;
using CyberTool.Client.Pages;

namespace CyberTool.Pages
{
    public partial class PublicationBibsPublicationsComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected PublicationBibsService PublicationBibs { get; set; }
        protected RadzenGrid<CyberTool.Models.PublicationBibs.PublicationBibsPublication> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<CyberTool.Models.PublicationBibs.PublicationBibsPublication> _getPublicationBibsPublicationsResult;
        protected IEnumerable<CyberTool.Models.PublicationBibs.PublicationBibsPublication> getPublicationBibsPublicationsResult
        {
            get
            {
                return _getPublicationBibsPublicationsResult;
            }
            set
            {
                if (!object.Equals(_getPublicationBibsPublicationsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getPublicationBibsPublicationsResult", NewValue = value, OldValue = _getPublicationBibsPublicationsResult };
                    _getPublicationBibsPublicationsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getPublicationBibsPublicationsCount;
        protected int getPublicationBibsPublicationsCount
        {
            get
            {
                return _getPublicationBibsPublicationsCount;
            }
            set
            {
                if (!object.Equals(_getPublicationBibsPublicationsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getPublicationBibsPublicationsCount", NewValue = value, OldValue = _getPublicationBibsPublicationsCount };
                    _getPublicationBibsPublicationsCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddPublicationBibsPublication>("Add Publication Bibs Publication", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await PublicationBibs.ExportPublicationBibsPublicationsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "url,id,type,title,journal,booktitle,pages,month,year,volume,number,editor,event1,institution,note,day" }, $"Publication Bibs Publications");

            }

            if (args?.Value == "xlsx")
            {
                await PublicationBibs.ExportPublicationBibsPublicationsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "url,id,type,title,journal,booktitle,pages,month,year,volume,number,editor,event1,institution,note,day" }, $"Publication Bibs Publications");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var publicationBibsGetPublicationBibsPublicationsResult = await PublicationBibs.GetPublicationBibsPublications(filter:$@"(contains(url,""{search}"") or contains(type,""{search}"") or contains(title,""{search}"") or contains(journal,""{search}"") or contains(booktitle,""{search}"") or contains(pages,""{search}"") or contains(editor,""{search}"") or contains(event1,""{search}"") or contains(institution,""{search}"") or contains(note,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getPublicationBibsPublicationsResult = publicationBibsGetPublicationBibsPublicationsResult.Value.AsODataEnumerable();

                getPublicationBibsPublicationsCount = publicationBibsGetPublicationBibsPublicationsResult.Count;
            }
            catch (System.Exception publicationBibsGetPublicationBibsPublicationsException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load PublicationBibsPublications");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CyberTool.Models.PublicationBibs.PublicationBibsPublication args)
        {
            var dialogResult = await DialogService.OpenAsync<EditPublicationBibsPublication>("Edit Publication Bibs Publication", new Dictionary<string, object>() { {"id", args.id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var publicationBibsDeletePublicationBibsPublicationResult = await PublicationBibs.DeletePublicationBibsPublication(id:data.id);
                    if (publicationBibsDeletePublicationBibsPublicationResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception publicationBibsDeletePublicationBibsPublicationException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete PublicationBibsPublication");
            }
        }
    }
}
