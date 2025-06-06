using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorGenerator.Components.SplitButton;
public partial class SplitButtonItem
{

  [CascadingParameter]
  public SplitButton Owner { get; set; } = default!;

  /// <summary>
  /// Gets or sets the menu item label.
  /// </summary>
  [Parameter]
  public string? Label { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the element is disabled.
  /// </summary>
  [Parameter]
  public bool Disabled { get; set; }

  /// <summary>
  /// Gets or sets the expanded state of the element.
  /// </summary>
  [Parameter]
  public bool Expanded { get; set; }

  /// <summary>
  /// Gets or sets the role of the element.
  /// </summary>
  [Parameter]
  public MenuItemRole? Role { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the element is checked.
  /// </summary>
  [Parameter]
  public bool Checked { get; set; }

  /// <summary>
  /// Gets or sets the content to be rendered inside the component.
  /// </summary>
  [Parameter]
  public RenderFragment? ChildContent { get; set; }

  /// <summary>
  /// Event raised when the user click on this item.
  /// </summary>
  [Parameter]
  public EventCallback<MouseEventArgs> OnClick { get; set; }
}
