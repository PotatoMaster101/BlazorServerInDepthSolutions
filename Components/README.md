# Key Points
- Components are like WPF's `UserControl` - put common UI code in there and drop it in on any page
- Use `[Parameter]` to pass data into components while creating them on the page
- Use `RenderFragment` parameters to pass in additional UI (HTML or some other component or both)
- Use `EventCallback<T>` to pass data back to parent (i.e., component -> page)
    - Cannot use other types of delegates (such as `Func`/`Action`), as `EventCallback` will redraw parent and child once called and others will not
- To assign functions with parameters to "events" (i.e., `@onclick`), use a lambda expression, e.g., `@onclick="() => Foo(args)"`
