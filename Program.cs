// See https://aka.ms/new-console-template for more information
    string[] FirstName = {"Bob","John","James","Mary","Amy","Jane","Olivia","Noah","Evelyn","Liam"};
    string [] MiddleName = {"Ava","Mia","Luna","Ella","Avery","Elijah","William", "Lucas","Benjamin", "Henry"};
    string [] LastName = {"Daniel","Levi","Alexander","Jackson","Mateo","Aria","Layla","Nora","Ellie","Grace"};
    string [] Job = {"Plumber", "Teacher","Truck Driver","Tax inspector","Tour guide","Shop assistant","Parametic","Researcher","Broadcaster","Cook"};
    float [] HourlyWage = {7.25F, 12.00F, 14.00F, 20.00F, 25.00F, 30.00F, 35.00F, 40.00F};
    
    int x = FirstName.Length;

    

    for(int x=0; x < FirstName.Length; x++) {  
      
        Random RandFirstName = new Random();  
     
        int x = RandFirstName.Next(FirstName.Length);
        
        Console.WriteLine($"Your first name is: {FirstName[x]}");  
  
        Console.ReadKey();  
    }

    Random RandMiddleName = new Random(MiddleName.Length);  
     
    int y = RandMiddleName.Next(MiddleName.Length);

    Random RandLastName = new Random(LastName.Length);  
     
    int z = RandLastName.Next(LastName.Length);


    Random RandJob = new Random(Job.Length);  
     
    int a = RandJob.Next(Job.Length);

    Random RandHourlyWage = new Random(HourlyWage.Length);  
     
    int b = RandHourlyWage.Next(HourlyWage.Length);
