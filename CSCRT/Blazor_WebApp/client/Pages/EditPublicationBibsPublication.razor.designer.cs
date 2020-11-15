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
    public partial class EditPublicationBibsPublicationComponent : ComponentBase
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

        [Parameter]
        public dynamic id { get; set; }

        CyberTool.Models.PublicationBibs.PublicationBibsPublication _publicationbibspublication;
        protected CyberTool.Models.PublicationBibs.PublicationBibsPublication publicationbibspublication
        {
            get
            {
                return _publicationbibspublication;
            }
            set
            {
                if (!object.Equals(_publicationbibspublication, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "publicationbibspublication", NewValue = value, OldValue = _publicationbibspublication };
                    _publicationbibspublication = value;
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
            var publicationBibsGetPublicationBibsPublicationByidResult = await PublicationBibs.GetPublicationBibsPublicationByid(id:id);
            publicationbibspublication = publicationBibsGetPublicationBibsPublicationByidResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(CyberTool.Models.PublicationBibs.PublicationBibsPublication args)
        {
            try
            {
                var publicationBibsUpdatePublicationBibsPublicationResult = await PublicationBibs.UpdatePublicationBibsPublication(id:id, publicationBibsPublication:publicationbibspublication);
                DialogService.Close(publicationbibspublication);
            }
            catch (System.Exception publicationBibsUpdatePublicationBibsPublicationException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update PublicationBibsPublication");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
