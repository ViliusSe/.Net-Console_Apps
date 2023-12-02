//async Task<string> ParodytiEilute(){
//    return "bbb";
//    }


//async void Uzlaikymas()
//{ 
//    await Task ParodytiEilute().Delay(2000);
//    Console.WriteLine("ksjdasdj");
//}


using Asynchronous;

ProgressBar progressBar = new ProgressBar();

for (int i = 0; i < 100; i++)
{
    await Task.Delay(1000);
    int x = progressBar.Progres();
    Task.Delay(3000);
    Wait3Sec(x);

}

async void Wait3Sec(int x)
{
        Console.WriteLine(x);
}




