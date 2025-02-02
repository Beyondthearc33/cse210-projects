public class PromptResponse
{
    public string Date;
    public string Prompt;
    public string Response;

    public PromptResponse(string date, string prompt, string response)
    {
        this.Date = date;
        this.Prompt = prompt;
        this.Response = response;
    }
}

