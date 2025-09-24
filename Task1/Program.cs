Console.WriteLine("Enter name for teacher:");
        string teacherName = Console.ReadLine();

        Console.WriteLine("Enter name for first student:");
        string student1Name = Console.ReadLine();

        Console.WriteLine("Enter name for second student:");
        string student2Name = Console.ReadLine();
        Person[] people = new Person[3];
        people[0] = new Teacher(teacherName);
        people[1] = new Student(student1Name);
        people[2] = new Student(student2Name);
        ((Teacher)people[0]).Explain();
        ((Student)people[1]).Study();
        ((Student)people[2]).Study();