#pragma checksum "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc11fae921b769168981b2777f74010aaf03f49"
// <auto-generated/>
#pragma warning disable 1591
namespace CyberTool_BLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using CyberTool_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using CyberTool_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using BlazorFluentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using BlazorFluentUI.Demo.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\_Imports.razor"
using BlazorFluentUI.Demo.Shared.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
using DynamicData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
using DynamicData.Binding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
using System.Reactive.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dataview")]
    public partial class Data_View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorFluentUI.BFUStack>(0);
            __builder.AddAttribute(1, "Style", "height:100%;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.AddMarkupContent(4, "<h3>DetailsList</h3>\r\n    ");
                __builder2.OpenComponent<BlazorFluentUI.BFUStack>(5);
                __builder2.AddAttribute(6, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Tokens", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFluentUI.BFUStackTokens>(
#nullable restore
#line 10 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                        new BFUStackTokens { ChildrenGap = new double[] { 10.0 } }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<BlazorFluentUI.BFUTextField>(9);
                __builder2.AddAttribute(10, "Label", "Search");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                               dataContainer.Filter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "OnInput", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dataContainer.Filter = __value, dataContainer.Filter))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<BlazorFluentUI.BFUStack>(14);
                __builder2.AddAttribute(15, "Horizontal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                        "height:44px"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<BlazorFluentUI.BFUCommandBarButton>(19);
                    __builder3.AddAttribute(20, "IconName", "Mail");
                    __builder3.AddAttribute(21, "Text", "Send mail");
                    __builder3.AddAttribute(22, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                                                        Disabled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 16 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                                                                           Checked

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n        ");
                    __builder3.OpenComponent<BlazorFluentUI.BFUDropdown>(25);
                    __builder3.AddAttribute(26, "ItemsSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BlazorFluentUI.IBFUDropdownOption>>(
#nullable restore
#line 17 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                  selectionModeOptions

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Style", "max-width:300px;");
                    __builder3.AddAttribute(28, "SelectedOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFluentUI.IBFUDropdownOption>(
#nullable restore
#line 18 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                          selectedModeOption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "SelectedOptionChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorFluentUI.IBFUDropdownOption>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorFluentUI.IBFUDropdownOption>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedModeOption = __value, selectedModeOption))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __Blazor.CyberTool_BLAZOR.Pages.Data_View.TypeInference.CreateBFUDetailsList_0(__builder2, 32, 33, 
#nullable restore
#line 22 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                 ReadonlyList

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 23 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                   false

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 24 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                            false

#line default
#line hidden
#nullable disable
                , 36, 
#nullable restore
#line 25 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                             ReadonlyColumns

#line default
#line hidden
#nullable disable
                , 37, 
#nullable restore
#line 26 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                DetailsListLayoutMode.Justified

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 28 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                    (SelectionMode)Enum.Parse(typeof(SelectionMode), selectedModeOption.Key)

#line default
#line hidden
#nullable disable
                , 39, 
#nullable restore
#line 27 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
                                     selection

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selection = __value, selection)));
                __builder2.AddMarkupContent(41, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Eliel\source\repos\Cybersecurity Tool\CyberTool_BLAZOR\CyberTool_BLAZOR\Pages\Data_View.razor"
       

    // You DO NOT have to use DynamicData and Observables with DetailsList.  You can do it all manually.  See
    // https://developer.microsoft.com/en-us/fluentui#/controls/web/detailslist for examples of how to use DetailsList
    // other ways.

    bool isVirtualizing = false;
    bool isCompact = false;
    IBFUDropdownOption selectedModeOption;
    List<IBFUDropdownOption> selectionModeOptions;


    Selection<DataItem> selection = new Selection<DataItem>();

    // SourceCache is from DynamicData and is basically a container for your items that you can dynamically transform by filtering, sorting, etc.
    SourceCache<DataItem, string> dataSource = new SourceCache<DataItem, string>(x => x.Key);
    public ReadOnlyObservableCollection<DataItem> ReadonlyList;
    int count = 0;

    // We're creating another container for the column array that needs to be defined to show columns in DetailsList.
    SourceCache<BFUDetailsRowColumn<DataItem>, string> columnsSource = new SourceCache<BFUDetailsRowColumn<DataItem>, string>(x => x.Key);
    public ReadOnlyObservableCollection<BFUDetailsRowColumn<DataItem>> ReadonlyColumns;

    // This class just holds some properties that make it easier to sort and filter data.
    ObservableDataContainer dataContainer = new ObservableDataContainer();

    class ObservableDataContainer : AbstractNotifyPropertyChanged
    {
        private string filter = "";
        public string Filter { get => filter; set => SetAndRaise(ref filter, value); }

        private bool descending = false;
        public bool Descending { get => descending; set => SetAndRaise(ref descending, value); }

        // When you click a column, we change this so DynamicData can know which property to sort by.
        private Func<DataItem, IComparable> sortSelector = x => x.KeyNumber;
        public Func<DataItem, IComparable> SortSelector { get => sortSelector; set => SetAndRaise(ref sortSelector, value); }

        // This is an observable that is similar to the above callback, just in observable form.  This tells us when and how to change filtering.
        public IObservable<Func<DataItem, bool>> DynamicDescriptionFilter { get; private set; }

        public IObservable<SortExpressionComparer<DataItem>> DynamicSortExpression { get; private set; }

        public IObservable<bool> IsFiltered { get; private set; }

        public ObservableDataContainer()
        {
            // This creates the observable that outputs a new filtering function.  Basically, return true if the string contains x.
            // Throttle is an operator that limits how often the observable is fired.  This is useful when you type so the filter
            // observable doesn't fire every time you hit a key.  This requires threading to work smoothly so doesn't work well
            // in client-side blazor yet.
            DynamicDescriptionFilter = this.WhenValueChanged(@this => @this.Filter)
                //.Throttle(TimeSpan.FromMilliseconds(250))  //this freezes the ui in wasm since there are no threads
                .Select<string, Func<DataItem, bool>>(f => item => item.Description.Contains(f));

            // DynamicData requires a specific expression for sorting.  This is where the expression is created.  The SortSelector
            // property is combined with the IsDescending property.  When either of them is changed, the DynamicSortExpression
            // observable is fired with the newly created SortExpressionComparer.
            DynamicSortExpression = this.WhenValueChanged(@this => @this.SortSelector).CombineLatest(this.WhenValueChanged(@this => @this.Descending), (selector, isDescending) =>
            {

                if (isDescending)
                {
                    return SortExpressionComparer<DataItem>.Descending(selector);
                }
                else
                {
                    return SortExpressionComparer<DataItem>.Ascending(selector);
                }
            });

            // We create the IsFiltered observable here.  Basically, when the Filter property is changed, fire the IsFiltered observable.
            IsFiltered = this.WhenValueChanged(@this => @this.Filter).Select(x => !string.IsNullOrWhiteSpace(x));
        }
    }


    protected override void OnInitialized()
    {
        selectionModeOptions = Enum.GetValues(typeof(SelectionMode)).Cast<SelectionMode>()
           .Select(x => new BFUDropdownOption { Key = x.ToString(), Text = x.ToString() })
           .Cast<IBFUDropdownOption>()
           .ToList();
        selectedModeOption = selectionModeOptions.FirstOrDefault(x => x.Key == "Single");

        // We load the column data into the columnsSource SourceCache.
        columnsSource.AddOrUpdate(new BFUDetailsRowColumn<DataItem>("Key", x => x.KeyNumber) { MaxWidth = 70, Index = 0, OnColumnClick = this.OnColumnClick, IsResizable = true });
        columnsSource.AddOrUpdate(new BFUDetailsRowColumn<DataItem>("Name", x => x.DisplayName) { Index = 1, MaxWidth = 150, OnColumnClick = this.OnColumnClick, IsResizable = true });
        var descColumn = new BFUDetailsRowColumn<DataItem>("Description", x => x.Description) { Index = 2, OnColumnClick = this.OnColumnClick };
        columnsSource.AddOrUpdate(descColumn);

        // We're loading our sample data into the dataSource SourceCache.
        for (var i = 0; i < 100; i++)
        {
            count++;
            dataSource.AddOrUpdate(new DataItem(count));
        }

        // We subscribe to the IsFiltered observable so that we know when to mark the description column with a Filter icon.
        // All we have to do is change the column class and use the AddOrUpdate method on the SourceCache.  DynamicData will
        // automatically change the contents and notify anything that is watching that list.
        dataContainer.IsFiltered.Subscribe(isFiltered =>
        {
            descColumn.IsFiltered = isFiltered;
            columnsSource.AddOrUpdate(descColumn);
        });

        // This is the meat of DynamicData.  We connect to the data SourceCache, apply the Filter (which is dynamic),
        // apply the Sort expression (which is also dynamic), and Bind it to a readonly list property.  This is what we're
        // going to display in the DetailsList.  It will update automatically which any changes we make.  Since DynamicData is
        // based on ReactiveExtensions, we have to Subscribe to it to make it "do stuff".
        dataSource.Connect()
                .Filter(dataContainer.DynamicDescriptionFilter)
                .Sort(dataContainer.DynamicSortExpression)
                .Bind(out ReadonlyList)
                .Subscribe();

        // Likewise, we connect to the column SourceCache.  This lets us make a change in one column and everything gets updated
        // automatically.  We also have a Do operator in there that calls a StateHasChanged whenever the contents are changed or if
        // the Sort expression changes.
        columnsSource.Connect()
            .Sort(SortExpressionComparer<BFUDetailsRowColumn<DataItem>>.Ascending(x => x.Index))
            .Bind(out ReadonlyColumns)
            .Do(_ => StateHasChanged())  //when a column is clicked, that column's details will update... but other columns won't.  Need to call StateHasChanged to redraw all.
            .Subscribe();



        base.OnInitialized();
    }

    // This callback is fired when a column header is clicked.  We go through each column item and change their sort properties.
    // To update the changes in our UI, we just use the `AddOrUpdate` method and DynamicData will make the changes in the bound
    // list.
    private void OnColumnClick(BFUDetailsRowColumn<DataItem> column)
    {
        if (column.IsSorted)
        {
            column.IsSortedDescending = !column.IsSortedDescending;
            dataContainer.Descending = column.IsSortedDescending;
            dataContainer.SortSelector = column.FieldSelector;
            columnsSource.AddOrUpdate(column);
        }
        else
        {
            var copyList = columnsSource.Items.ToList();
            foreach (var col in copyList)
            {
                col.IsSorted = false;
                if (col == column)
                {
                    col.IsSorted = true;
                    col.IsSortedDescending = false;
                }
            }
            columnsSource.AddOrUpdate(copyList);
        }
        dataContainer.Descending = column.IsSortedDescending;
        dataContainer.SortSelector = column.FieldSelector;

    }

    BlazorFluentUI.Demo.Shared.Utils.RelayCommand buttonCommand;
    bool commandEnabled = false;
    bool CommandEnabled
    {
        get => commandEnabled;
        set
        {
            commandEnabled = value;
            buttonCommand.OnCanExecuteChanged();
        }
    }

    int commandCount = 0;
    bool isChecked = false;
    bool muted;
    string buttonDebug = "";
    bool Checked;
    bool Disabled;

    bool isToggled = false;

    IEnumerable<BFUContextualMenuItem> MenuProperties;

    private void OnClickHandler(string button)
    {
        buttonDebug = $"{button.ToString()} button was clicked. {commandCount++}";
    }

    private void Mute()
    {
        muted = !muted;
    }

    protected override Task OnInitializedAsync()
    {
        MenuProperties = new System.Collections.Generic.List<BFUContextualMenuItem>()
{
            new BFUContextualMenuItem() { Key = "emailMessage", Text = "Email message", IconName="Mail"},
        };
        buttonCommand = new BlazorFluentUI.Demo.Shared.Utils.RelayCommand((p) =>
        {
            buttonDebug = $"Button with command was clicked. {commandCount++}";
            StateHasChanged();
        },
            p =>
            {
                return ((Func<bool>)p).Invoke();
            }
        );

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CyberTool_BLAZOR.Pages.Data_View
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBFUDetailsList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Collections.Generic.IEnumerable<global::BlazorFluentUI.BFUDetailsRowColumn<TItem>> __arg3, int __seq4, global::BlazorFluentUI.DetailsListLayoutMode __arg4, int __seq5, global::BlazorFluentUI.SelectionMode __arg5, int __seq6, global::BlazorFluentUI.Selection<TItem> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<global::BlazorFluentUI.Selection<TItem>> __arg7)
        {
        __builder.OpenComponent<global::BlazorFluentUI.BFUDetailsList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemsSource", __arg0);
        __builder.AddAttribute(__seq1, "IsVirtualizing", __arg1);
        __builder.AddAttribute(__seq2, "Compact", __arg2);
        __builder.AddAttribute(__seq3, "Columns", __arg3);
        __builder.AddAttribute(__seq4, "LayoutMode", __arg4);
        __builder.AddAttribute(__seq5, "SelectionMode", __arg5);
        __builder.AddAttribute(__seq6, "Selection", __arg6);
        __builder.AddAttribute(__seq7, "SelectionChanged", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
