# Key Points
- URL matching:
    - `NavLinkMatch.All` - matches an exact match of URL, behavior similar to `string.Equals()`
    - `NavLinkMatch.Prefix` - default, matches the first part of URL, behavior similar to `string.StartsWith()`
- To split code from HTML, create a `partial class` with the same name as the page, which will act as a "code behind"
    - If the code in HTML is minimum (i.e., few lines), it might not be worth splitting
    - Use `[Inject]` on a "dependency property" to inject dependency into the "code behind", a constructor will not work
