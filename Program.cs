    string[] FirstName = { "Bob", "John", "James", "Mary", "Amy", "Jane", "Olivia", "Noah", "Evelyn", "Liam" };
    string[] MiddleName = { "Ava", "Mia", "Luna", "Ella", "Avery", "Elijah", "William", "Lucas", "Benjamin", "Henry" };
    string[] LastName = { "Daniel", "Levi", "Alexander", "Jackson", "Mateo", "Aria", "Layla", "Nora", "Ellie", "Grace" };
    string[] Job = { "Plumber", "Teacher", "Truck Driver", "Tax inspector", "Tour guide", "Shop assistant", "Parametic", "Researcher", "Broadcaster", "Cook" };
    float[] HourlyWage = { 7.25F, 12.00F, 14.00F, 20.00F, 25.00F, 30.00F, 35.00F, 40.00F };

    string[] firstNames = new string[1000];
    string[] middleNames = new string[1000];
    string[] lastNames = new string[1000];
    string[] job = new string[1000];
    float[] hourlyWages = new float[1000];
    float[] salaries = new float[1000];

    Random rand = new Random();

        for (int x = 0; x < 1000; x++) {

            firstNames[x] = FirstName[rand.Next(FirstName.Length)];

            middleNames[x] = MiddleName[rand.Next(MiddleName.Length)];

            lastNames[x] = LastName[rand.Next(LastName.Length)];
            // check if the name is unique
            bool isUnique = false;
            while (!isUnique && x > 0) {
                for (int i = 0; i < x; i++) {
                    if (firstNames[i] != firstNames[x] || middleNames[i] != middleNames[x] ||
                            lastNames[i] != lastNames[x]) {
                            isUnique = true;
                            break;
                        }
                    }

                    if (!isUnique) {
                        firstNames[x] = FirstName[rand.Next(FirstName.Length)];

                        middleNames[x] = MiddleName[rand.Next(MiddleName.Length)];

                        lastNames[x] = lastNames[rand.Next(LastName.Length)];
                    }
                    
                }

                job[x] = Job[rand.Next(Job.Length)];

                hourlyWages[x] = HourlyWage[rand.Next(HourlyWage.Length)];
                salaries[x] = hourlyWages[x] * 40 * 50;

                Console.WriteLine($"Your first name is: {firstNames[x]}, Middle name is: {middleNames[x]}, Last name is: {lastNames[x]}, Your job is: {job[x]}, Youe salary is: {salaries[x]}");
            }    