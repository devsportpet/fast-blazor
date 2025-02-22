using Microsoft.AspNetCore.Components;

namespace Microsoft.Fast.Components.FluentUI;

public partial class FluentMenuItem : FluentComponentBase, IDisposable
{
    /// <summary>
    /// Gets or sets the owning FluentMenu
    /// </summary>
    [CascadingParameter]
    public FluentMenu Owner { get; set; } = default!;

    /// <summary>
    /// Gets or sets if the id
    /// </summary>
    [Parameter]
    public string Id { get; set; } = Identifier.NewId();

    /// <summary>
    /// Gets or sets if the element is disabled
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The expanded state of the element.
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// The role of the element.
    /// </summary>
    [Parameter]
    public MenuItemRole? Role { get; set; }

    /// <summary>
    /// Gets or sets if the element is checked
    /// </summary>
    [Parameter]
    public bool? Checked { get; set; }
  
    /// <summary>
    /// Gets or sets the content to be rendered inside the component.
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    protected override void OnInitialized()
    {
        Owner?.Register(this);
    }

    public void Dispose() => Owner?.Unregister(this);
}
