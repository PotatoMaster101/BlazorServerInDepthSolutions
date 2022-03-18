using Microsoft.AspNetCore.Components;

namespace LayoutAndPages.Shared;

public partial class ExperimentalLayout
{
    [Inject]
    public ILogger<ExperimentalLayout>? Logger { get; init; }

    private int ThumbUp { get; set; }

    private int ThumbDown { get; set; }

    private void Upvote()
    {
        ThumbUp++;
        Logger?.LogInformation("Upvotes = {ThumbUp}", ThumbUp);
    }

    private void Downvote()
    {
        ThumbDown++;
        Logger?.LogInformation("Downvotes = {ThumbDown}", ThumbDown);
    }
}
