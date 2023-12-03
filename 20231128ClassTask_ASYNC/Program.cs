using _20231128ClassTask_ASYNC;

ProgressBar progressBar = new ProgressBar();

async Task AddOne()
{
    await Task.Delay(1000);
    progressBar.progress++;
}

async Task ShowProgress()
{
    await Task.Delay(3000);
    Console.WriteLine(progressBar.progress.ToString());

}



while (true)
{
    Task.Run(() => ShowProgress());
    
    for (int i = 0; i < 100; i++)
    {
        Task.Run(() => AddOne());
    }
}
