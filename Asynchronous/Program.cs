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

Task.Run(() => progressBar.Progres());
Task.Run(()=>progressBar.ShowProgress()).Wait();









