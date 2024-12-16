class Program
{
    private static void Main(string[] args)
    {
        var d1 = new Dog();
        var d2 = new Dog();

        if (d1.Equals(d2) ){
            Console.WriteLine("They are equal");
        }else{
            Console.WriteLine("They are not the same");
        }
    }
}

class Dog {
    public string Name{get;}
    public int    Age{get;}


    // overloading methods
    public Dog(){
        Name = "messi";
        Age  = 0;
    }

    public Dog(string name): this(name, 0){}
    public Dog(string name, int age){
        Name  = name;
        Age   = age;
    }

    


    public void Bark(){
        Console.WriteLine("Woof");
    } 
    
    public void Bark(string s){
        Console.WriteLine($"Woof {s}");
    }

    // override object.Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        Dog d = (Dog)obj;
        return Name == d.Name && Age == d.Age;
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }
}

/*
1) Create a Dog class with attributes name and age, and a bark method 
that displays "Woof!". 

2) Create an object of this class and call its bark method.
*/