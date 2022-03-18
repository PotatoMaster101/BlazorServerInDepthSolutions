# Key Points
- A page can have multiple routes specified in `@page "<route>"`
- Use `{<PropName>:<Type>}` for allowing routing data
    - Use nullable (i.e., `Type?`) if routing data is optional
- Avoid unhandled exceptions, SignalR connection will be broken and user must refresh page to fix it
- Put static files (i.e., images, JS files, CSS files) under `wwwroot`
