// See https://aka.ms/new-console-template for more information
    string[] FirstName = {"Bob","John","James","Mary","Amy","Jane","Olivia","Noah","Evelyn","Liam"};
    string [] MiddleName = {"Ava","Mia","Luna","Ella","Avery","Elijah","William", "Lucas","Benjamin", "Henry"};
    string [] LastName = {"Daniel","Levi","Alexander","Jackson","Mateo","Aria","Layla","Nora","Ellie","Grace"};
    string [] Job = {"Plumber", "Teacher","Truck Driver","Tax inspector","Tour guide","Shop assistant","Parametic","Researcher","Broadcaster","Cook"};
    float [] HourlyWage = {7.25F, 12.00F, 14.00F, 20.00F, 25.00F, 30.00F, 35.00F, 40.00F};

    
    Random rand = new Random();  
     
    int index = rand.Next(FirstName.Length);  
      
    Console.WriteLine($"Your first name is: {FirstName[index]}");  
  
    Console.ReadKey();  
    