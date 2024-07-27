string url = "https://jsonplaceholder.typicode.com/posts";
string data = await FetchDataAsync(url);
Console.WriteLine(data);

async Task<string> FetchDataAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseData = await response.Content.ReadAsStringAsync();
        return responseData;

    }
}