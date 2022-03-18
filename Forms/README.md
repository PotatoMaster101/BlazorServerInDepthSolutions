# Key Points
- `EditForm` does not use HTTP GET/POST, data is sent via SignalR
- Use `bind-Value` to bind a form field to a model property
    - `bind-Value` will update the property without validation as soon as the value has been changed on the form; might be a good or bad thing
    - To make sure input values are valid, use `OnValidSubmit`
- Use `DataAnnotationsValidator` to perform form data validation
- Use `ValidationSummary` to show validation errors on the form
