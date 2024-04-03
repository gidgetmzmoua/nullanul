public class Repository
{
    private string _repoName;

    public Repository(string name)
    {
        _repoName = name;
    }

    public string RepoName
    {
        get { return _repoName; }
        set { _repoName = value; }
    }

    // Other repository-related methods can be added here
}

// Usage
var myRepo = new Repository("example-repo");
Console.WriteLine(myRepo.RepoName);
myRepo.RepoName = "new-repo-name";
Console.WriteLine(myRepo.RepoName);
