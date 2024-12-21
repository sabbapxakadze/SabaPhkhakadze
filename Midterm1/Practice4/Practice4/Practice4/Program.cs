/*
 ფაილების დაბეჭდვა რეკურსიულად 15 ქულა
დაწერეთ კონსოლ აპლიკაცია, რომელიც პირველ რიგში დაბეჭდავს შემდეგ ტექსტს: 
To turn off
program type "exit" otherwise enter the directory path რაც ნიშნავს შემდეგს: სანამ სიტყვა
exit - ს არ
შეიყვანს მომხმარებელი, მანამ პროგრამას უნდა შეეძლოს ფუნქციონირება, ხოლო
სიტყვა exit - ის
აკრეფის შემდეგ უნდა დაასრულოს მუშაობა. იმ შემთხვევაში როცა მომხმარებელი
შეიტანს
კონკრეტული დირექტორიის მისამართს, ასეთის არ არსებობის შემთხვევაში
პროგრამამ უნდა
გამოიტანოს შეტყობინება: The directory (შემოტანილი დირექტორია) does not exist! 
სხვა შემთხვავაში
კი რეკურსიული მექანიზმის გამოყენებით უნდა დაბეჭდოს ამ დირექქტორიის ქვეშ
არსებული ყველა
ფაილის დასახელება.
დამხმარე კლასები და მეთოდები
Directory.GetFiles("path"); გვიბრუნებს ფაილების სიას Directory.GetDirectories("path"); 
გვიბრუნებს დირექტორიების სიას Directory.Exists("path"); ამოწმებს არსებობს თუ არა
გადაცემული pat
 */

void App(string path)
{
    bool exists = Directory.Exists(path);

    if (path == "exit") return;
    if (exists == false)
    {
        Console.WriteLine($"The given directory path: \"{path}\" does not exists");
        return;
    }
    

    string[] directories = Directory.GetDirectories(path);
    string[] files = Directory.GetFiles(path);

    foreach (string directory in directories)
    {
        App(path + "\\" + directory);
    }


    foreach (string file in files)
    {
        Console.WriteLine($"{file} exists in {path}");
    }

}

Console.WriteLine("To turn off program, type \"exit\", otherwise enter the directory path");
string path = Console.ReadLine();

App(path);